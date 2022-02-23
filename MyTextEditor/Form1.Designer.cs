
namespace MyTextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelChars = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.labelLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxText.Location = new System.Drawing.Point(12, 28);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(776, 387);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // labelChars
            // 
            this.labelChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChars.AutoSize = true;
            this.labelChars.Location = new System.Drawing.Point(13, 425);
            this.labelChars.Name = "labelChars";
            this.labelChars.Size = new System.Drawing.Size(67, 13);
            this.labelChars.TabIndex = 1;
            this.labelChars.Text = "Caracteres:0";
            // 
            // labelWords
            // 
            this.labelWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(111, 425);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(57, 13);
            this.labelWords.TabIndex = 2;
            this.labelWords.Text = "Palavras:0";
            // 
            // labelLines
            // 
            this.labelLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLines.AutoSize = true;
            this.labelLines.Location = new System.Drawing.Point(218, 425);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(47, 13);
            this.labelLines.TabIndex = 3;
            this.labelLines.Text = "Linhas:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLines);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.labelChars);
            this.Controls.Add(this.textBoxText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labelChars;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Label labelLines;
    }
}

