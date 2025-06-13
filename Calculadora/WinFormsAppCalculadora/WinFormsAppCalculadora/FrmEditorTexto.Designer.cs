namespace WinFormsAppCalculadora
{
    partial class FrmEditorTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            lbEstilo = new Label();
            btnNegrito = new Button();
            btnItalico = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            cbTamanhoTexto = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 477);
            textBox1.TabIndex = 0;
            // 
            // lbEstilo
            // 
            lbEstilo.AutoSize = true;
            lbEstilo.BackColor = SystemColors.ActiveCaptionText;
            lbEstilo.ForeColor = SystemColors.ControlLightLight;
            lbEstilo.Location = new Point(11, 9);
            lbEstilo.Name = "lbEstilo";
            lbEstilo.Size = new Size(83, 15);
            lbEstilo.TabIndex = 6;
            lbEstilo.Text = "Estilo do Texto";
            // 
            // btnNegrito
            // 
            btnNegrito.BackColor = SystemColors.ButtonHighlight;
            btnNegrito.FlatStyle = FlatStyle.Flat;
            btnNegrito.ForeColor = SystemColors.ActiveCaptionText;
            btnNegrito.Location = new Point(13, 48);
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(21, 20);
            btnNegrito.TabIndex = 1;
            btnNegrito.Text = "Negrito";
            btnNegrito.UseVisualStyleBackColor = false;
            btnNegrito.Click += this.button1_Click;
            // 
            // btnItalico
            // 
            btnItalico.BackColor = SystemColors.ButtonHighlight;
            btnItalico.FlatStyle = FlatStyle.Flat;
            btnItalico.ForeColor = SystemColors.ActiveCaptionText;
            btnItalico.Location = new Point(54, 48);
            btnItalico.Name = "btnItalico";
            btnItalico.Size = new Size(21, 20);
            btnItalico.TabIndex = 2;
            btnItalico.Text = "Italico";
            btnItalico.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(104, 48);
            button3.Name = "button3";
            button3.Size = new Size(31, 20);
            button3.TabIndex = 3;
            button3.Text = "Maiúsculo";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(154, 48);
            button4.Name = "button4";
            button4.Size = new Size(21, 20);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(193, 48);
            button5.Name = "button5";
            button5.Size = new Size(21, 20);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // cbTamanhoTexto
            // 
            cbTamanhoTexto.FormattingEnabled = true;
            cbTamanhoTexto.Location = new Point(266, 35);
            cbTamanhoTexto.Name = "cbTamanhoTexto";
            cbTamanhoTexto.Size = new Size(121, 23);
            cbTamanhoTexto.TabIndex = 9;
            cbTamanhoTexto.Text = "Tamanho do Texto";
            // 
            // FrmEditorTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(440, 575);
            Controls.Add(cbTamanhoTexto);
            Controls.Add(lbEstilo);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnItalico);
            Controls.Add(btnNegrito);
            Controls.Add(textBox1);
            Name = "FrmEditorTexto";
            Text = "FrmEditor1";
            Load += this.FrmEditorTexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnNegrito;
        private Button btnItalico;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lbEstilo;
        private ComboBox cbTamanhoTexto;
        private ComboBox cbCorTexto;
    }
}