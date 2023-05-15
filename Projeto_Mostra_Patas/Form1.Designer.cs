namespace Projeto_Mostra_Patas
{
    partial class Animais
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
            cboAnimais = new ComboBox();
            btnPatas = new Button();
            pctAnimais = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctAnimais).BeginInit();
            SuspendLayout();
            // 
            // cboAnimais
            // 
            cboAnimais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnimais.FormattingEnabled = true;
            cboAnimais.Items.AddRange(new object[] { "Cachorro", "Cavalo", "Centopeia", "Cobra", "Gato", "Pássaro" });
            cboAnimais.Location = new Point(29, 26);
            cboAnimais.Name = "cboAnimais";
            cboAnimais.Size = new Size(243, 23);
            cboAnimais.Sorted = true;
            cboAnimais.TabIndex = 0;
            cboAnimais.SelectedIndexChanged += cboAnimais_SelectedIndexChanged;
            // 
            // btnPatas
            // 
            btnPatas.Location = new Point(76, 65);
            btnPatas.Name = "btnPatas";
            btnPatas.Size = new Size(148, 23);
            btnPatas.TabIndex = 1;
            btnPatas.Text = "Mostra Patas";
            btnPatas.UseVisualStyleBackColor = true;
            btnPatas.Click += btnPatas_Click;
            // 
            // pctAnimais
            // 
            pctAnimais.Location = new Point(76, 104);
            pctAnimais.Name = "pctAnimais";
            pctAnimais.Size = new Size(148, 80);
            pctAnimais.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAnimais.TabIndex = 2;
            pctAnimais.TabStop = false;
            pctAnimais.Click += pictureBox1_Click;
            // 
            // Animais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 205);
            Controls.Add(pctAnimais);
            Controls.Add(btnPatas);
            Controls.Add(cboAnimais);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Animais";
            Text = "Form1";
            Load += Animais_Load;
            ((System.ComponentModel.ISupportInitialize)pctAnimais).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboAnimais;
        private Button btnPatas;
        private PictureBox pctAnimais;
    }
}