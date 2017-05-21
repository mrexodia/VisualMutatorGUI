using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Linq;

namespace VisualMutatorGUI
{
    public partial class VisualMutatorGUI : Form
    {
        private Dictionary<string, MutationTestingSessionMutantsAssemblyTypeMethodMutant> mutants;
        private List<string> liveMutants;
        private Dictionary<string, string> codeListings;

        public VisualMutatorGUI()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            listBoxMutants.SelectedIndexChanged += ListBoxMutants_SelectedIndexChanged;
        }

        private void ListBoxMutants_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mutantId = liveMutants[listBoxMutants.SelectedIndex];
            richTextCode.Text = mutants[mutantId].Description + ":\n" + codeListings[mutantId];
            for (var i = 0; i < richTextCode.Lines.Length; i++)
            {
                var line = richTextCode.Lines[i];
                if(i == 0) //first line, full name for the mutated method
                    richTextCode.HighlightLine(0, Color.LightGray);
                else if (Regex.Match(line, @" +\d+ +\-").Success) //removed line
                    richTextCode.HighlightLine(i, Color.PaleVioletRed);
                else if (Regex.Match(line, @" +\d+ +\+").Success) //added line
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

            //Load mutants
            mutants = new Dictionary<string, MutationTestingSessionMutantsAssemblyTypeMethodMutant>();
            liveMutants = new List<string>();
            var name = new List<string>();
            foreach (var assembly in testingSession.Mutants.Assembly)
            {
                if (assembly.Type == null)
                    continue;
                name.Add(assembly.Name);
                foreach (var type in assembly.Type)
                {
                    name.Add(type.Namespace + "." + type.Name);
                    foreach (var method in type.Method)
                    {
                        name.Add(method.Name);
                        var fullName = string.Join(".", name);
                        foreach (var mutant in method.Mutant)
                        {
                            mutant.Description = fullName;
                            mutants.Add(mutant.Id, mutant);
                            if (mutant.State == "Live")
                                liveMutants.Add(mutant.Id);
                        }
                        name.RemoveAt(name.Count - 1);
                    }
                    name.RemoveAt(name.Count - 1);
                }
                name.RemoveAt(name.Count - 1);
            }

            //Load code listings
            codeListings = new Dictionary<string, string>();
            foreach (var listing in testingSession.CodeDifferenceListings)
                codeListings.Add(listing.MutantId, listing.Code.Trim('\r', '\n'));

            //Update listbox with live mutants
            listBoxMutants.DataSource = liveMutants;
        }

        private void linkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com");
        }
    }
}
