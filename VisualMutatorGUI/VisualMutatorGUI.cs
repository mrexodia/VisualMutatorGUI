using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace VisualMutatorGUI
{
    public partial class VisualMutatorGUI : Form
    {
        private Dictionary<string, MutationTestingSessionMutantsAssemblyTypeMethodMutant> mutants;
        private List<MutationTestingSessionMutantsAssemblyTypeMethodMutant> liveMutants;
        private Dictionary<string, string> codeListings;
        private Dictionary<string, Tuple<int, int>> statistics;
        private int totalKillRatio;

        public static Dictionary<string, string> MutationDescriptions;

        public VisualMutatorGUI()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            listBoxMutants.SelectedIndexChanged += ListBoxMutants_SelectedIndexChanged;

            MutationDescriptions = new Dictionary<string, string>
            {
                { "DEH", "Method delegated for event handling change" },
                { "DMC", "Delegated method change" },
                { "EMM", "Modifier method change" },
                { "EAM", "Accessor method change" },
                { "EHC", "Exception handling change" },
                { "EHR", "Exception handling removal" },
                { "EXS", "Exception swallowing" },
                { "ISD", "Base keyword deletion" },
                { "JID", "Field initialization deletion" },
                { "JTD", "This keyword deletion" },
                { "PRV", "Reference assignment with other compatible type" },
                { "MCI", "Member call from another inherited class" },
                { "AOR", "Arithmetic operator replacement" },
                { "SOR", "Shift operator replacement" },
                { "LCR", "Logical connector replacement" },
                { "LOR", "Logical operator replacement" },
                { "ROR", "Relational operator replacement" },
                { "OODL", "Operator deletion" },
                { "SSDL", "Statement block deletion" },
            };
        }

        private bool validMatch(string line, string pattern)
        {
            var m = Regex.Match(line, pattern);
            return m.Success && m.Index == 0;
        }

        private void ListBoxMutants_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mutant = liveMutants[listBoxMutants.SelectedIndex];
            richTextCode.Text = mutants[mutant.Id].Description + ":\n" + codeListings[mutant.Id];
            for (var i = 0; i < richTextCode.Lines.Length; i++)
            {
                var line = richTextCode.Lines[i];
                if (i == 0) //first line, full name for the mutated method
                    richTextCode.HighlightLine(0, Color.LightGray);
                else if (validMatch(line, @" {0,4}\d+ {7}\-")) //removed line
                    richTextCode.HighlightLine(i, Color.PaleVioletRed);
                else if (validMatch(line, @" {4,8}\d+  \+")) //added line
                    richTextCode.HighlightLine(i, Color.GreenYellow);
                else //any other line
                    richTextCode.HighlightLine(i, Color.White);
            }
        }

        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            //Open the file
            var dialog = new OpenFileDialog
            {
                Filter = "XML Files|*.xml"
            };
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            //Deserialize the file
            var serializer = new XmlSerializer(typeof(MutationTestingSession));
            MutationTestingSession testingSession;
            using (var fs = new FileStream(dialog.FileName, FileMode.Open))
            {
                var reader = XmlReader.Create(fs);
                testingSession = (MutationTestingSession)serializer.Deserialize(reader);
            }

            //Load code listings
            codeListings = new Dictionary<string, string>();
            foreach (var listing in testingSession.CodeDifferenceListings)
            {
                var trimmedCode = listing.Code.Trim('\r', '\n');
                if (trimmedCode.Length > 0)
                    codeListings.Add(listing.MutantId, trimmedCode);
            }

            //Load mutants
            mutants = new Dictionary<string, MutationTestingSessionMutantsAssemblyTypeMethodMutant>();
            liveMutants = new List<MutationTestingSessionMutantsAssemblyTypeMethodMutant>();
            statistics = new Dictionary<string, Tuple<int, int>>();
            totalKillRatio = testingSession.MutationScore;
            var name = new List<string>();
            foreach (var assembly in testingSession.Mutants.Assembly)
            {
                if (assembly.Type == null)
                    continue;
                name.Add(assembly.Name);
                foreach (var type in assembly.Type)
                {
                    name.Add(type.Namespace + "." + type.Name);
                    var typeLive = 0;
                    var typeDead = 0;
                    foreach (var method in type.Method)
                    {
                        name.Add(method.Name);
                        var fullName = string.Join(".", name);
                        foreach (var mutant in method.Mutant)
                        {
                            if (!codeListings.ContainsKey(mutant.Id))
                                continue;
                            mutant.Description = fullName;
                            mutants.Add(mutant.Id, mutant);
                            if (mutant.State == "Live")
                            {
                                typeLive++;
                                if (liveMutants.Count(m => m.Id == mutant.Id && m.Description == fullName) == 0)
                                    liveMutants.Add(mutant);
                            }
                            else
                                typeDead++;
                        }
                        name.RemoveAt(name.Count - 1);
                    }
                    statistics.Add(string.Join(".", name), new Tuple<int, int>(typeLive, typeDead));
                    name.RemoveAt(name.Count - 1);
                }
                name.RemoveAt(name.Count - 1);
            }

            //Update listbox with live mutants
            listBoxMutants.DataSource = liveMutants;
        }

        private void linkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com");
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            if (statistics == null)
                return;
            var builder = new StringBuilder();
            builder.AppendLine(@"\begin{tabular}{ |l|l| }");
            builder.AppendLine(@"\hline");
            builder.AppendLine(@"Class & Kill Ratio \\");
            builder.AppendLine(@"\hline");
            foreach (var p in statistics)
            {
                var live = p.Value.Item1;
                var dead = p.Value.Item2;
                var ratio = (float)dead / (float)(live + dead) * 100;
                if (float.IsNaN(ratio))
                    ratio = 100;
                builder.AppendLine(string.Format(@"{0} & {1}\% \\", p.Key, (int)ratio));
            }
            builder.AppendLine(@"\hline");
            builder.AppendLine(@"\end{tabular}");
            MessageBox.Show(builder.ToString(), string.Format("Kill Ratio: {0} (Ctrl+C to copy)", totalKillRatio));
        }
    }
}

public partial class MutationTestingSessionMutantsAssemblyTypeMethodMutant
{
    public override string ToString()
    {
        return string.Format("{0} -> {1} ({2})", Description, Id, VisualMutatorGUI.VisualMutatorGUI.MutationDescriptions[Id.Split('#')[0]]);
    }
}