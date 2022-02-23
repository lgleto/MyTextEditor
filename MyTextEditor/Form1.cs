using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            labelChars.Text = $"Caracteres:{textBoxText.Text.Length }";
            labelWords.Text = $"Palavras:{StringHelper.wordsCount(textBoxText.Text)}";
            labelLines.Text = $"Linhas:{StringHelper.linesCount(textBoxText.Text)}";
        }
    }
}
