using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace VisualMutatorGUI
{
    static class Program
    {
        //Taken from: http://stackoverflow.com/a/27241858/1806760
        public static void HighlightLine(this RichTextBox richTextBox, int index, Color color)
        {
            var lines = richTextBox.Lines;
            if (index < 0 || index >= lines.Length)
                return;
            var start = richTextBox.GetFirstCharIndexFromLine(index); // Get the 1st char index of the appended text
            var length = lines[index].Length;
            richTextBox.Select(start, length); // Select from there to the end
            richTextBox.SelectionBackColor = color;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualMutatorGUI());
        }
    }
}
