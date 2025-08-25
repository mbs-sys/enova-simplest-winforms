namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWczytajNumeryDokumentowEnova = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnWczytajNumeryDokumentowEnova
            // 
            btnWczytajNumeryDokumentowEnova.Location = new Point(12, 12);
            btnWczytajNumeryDokumentowEnova.Name = "btnWczytajNumeryDokumentowEnova";
            btnWczytajNumeryDokumentowEnova.Size = new Size(250, 23);
            btnWczytajNumeryDokumentowEnova.TabIndex = 0;
            btnWczytajNumeryDokumentowEnova.Text = "Wczytaj numery dokumentów enova";
            btnWczytajNumeryDokumentowEnova.UseVisualStyleBackColor = true;
            btnWczytajNumeryDokumentowEnova.Click += btnWczytajNumeryDokumentowEnova_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(736, 269);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 322);
            Controls.Add(richTextBox1);
            Controls.Add(btnWczytajNumeryDokumentowEnova);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnWczytajNumeryDokumentowEnova;
        private RichTextBox richTextBox1;
    }
}
