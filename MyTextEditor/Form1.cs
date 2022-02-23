using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBoxText.Text);
            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                textBoxText.Text = File.ReadAllText(fileName);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0) return;
            if (MessageBox.Show(
                "Deseja apagar o documento sem gravar?",
                "Alerta",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                textBoxText.Text = "";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxText.Text.Length == 0) return;
            if (MessageBox.Show(
                "Deseja gravar o documento?",
                "Alerta",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, textBoxText.Text);
                }

            }
        }
    }
}
