namespace WinFormsAppCalculadora
{
    partial class formCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculadora));
            btnSubtracao = new Button();
            txtResultado = new TextBox();
            txtCalculadora = new Label();
            btnAdicao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btnLimpar = new Button();
            btn1 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btnVirgula = new Button();
            btn3 = new Button();
            btnResultado = new Button();
            btnLigaDesliga = new Button();
            lbResultado = new Label();
            btnEditor = new Button();
            SuspendLayout();
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Black;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.ForeColor = SystemColors.ButtonHighlight;
            btnSubtracao.Location = new Point(228, 267);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(60, 44);
            btnSubtracao.TabIndex = 0;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(17, 21);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(271, 69);
            txtResultado.TabIndex = 1;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // txtCalculadora
            // 
            txtCalculadora.AutoSize = true;
            txtCalculadora.BackColor = Color.Black;
            txtCalculadora.Font = new Font("Algerian", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCalculadora.ForeColor = SystemColors.ButtonHighlight;
            txtCalculadora.Location = new Point(22, 125);
            txtCalculadora.Name = "txtCalculadora";
            txtCalculadora.Size = new Size(122, 16);
            txtCalculadora.TabIndex = 2;
            txtCalculadora.Text = "CALCULADORA";
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.Black;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.ForeColor = SystemColors.ButtonHighlight;
            btnAdicao.Location = new Point(228, 320);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(60, 44);
            btnAdicao.TabIndex = 3;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Black;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.ForeColor = SystemColors.ButtonHighlight;
            btnMultiplicacao.Location = new Point(228, 214);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(60, 44);
            btnMultiplicacao.TabIndex = 4;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click_1;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Black;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.ForeColor = SystemColors.ButtonHighlight;
            btnDivisao.Location = new Point(228, 161);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(60, 44);
            btnDivisao.TabIndex = 5;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Black;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(18, 161);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 44);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Black;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(18, 214);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 44);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Black;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpar.Location = new Point(18, 320);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(60, 44);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(18, 267);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 44);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Black;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(88, 161);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 44);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Black;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(88, 214);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 44);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Black;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(88, 320);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 44);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(88, 267);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 44);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click_1;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Black;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(159, 161);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 44);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Black;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(159, 214);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 44);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Black;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.ForeColor = SystemColors.ButtonHighlight;
            btnVirgula.Location = new Point(159, 320);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(60, 44);
            btnVirgula.TabIndex = 15;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(159, 267);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 44);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.Black;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.ForeColor = SystemColors.ButtonHighlight;
            btnResultado.Location = new Point(228, 111);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(60, 44);
            btnResultado.TabIndex = 18;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click_1;
            // 
            // btnLigaDesliga
            // 
            btnLigaDesliga.BackColor = Color.Black;
            btnLigaDesliga.FlatStyle = FlatStyle.Flat;
            btnLigaDesliga.ForeColor = SystemColors.ButtonHighlight;
            btnLigaDesliga.Location = new Point(159, 111);
            btnLigaDesliga.Name = "btnLigaDesliga";
            btnLigaDesliga.Size = new Size(60, 44);
            btnLigaDesliga.TabIndex = 19;
            btnLigaDesliga.Text = "On/Off";
            btnLigaDesliga.UseVisualStyleBackColor = false;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = SystemColors.ControlLightLight;
            lbResultado.Location = new Point(22, 389);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(89, 17);
            lbResultado.TabIndex = 20;
            lbResultado.Text = "lbResultado";
            // 
            // btnEditor
            // 
            btnEditor.BackColor = Color.Black;
            btnEditor.FlatStyle = FlatStyle.Flat;
            btnEditor.ForeColor = SystemColors.ButtonHighlight;
            btnEditor.Location = new Point(203, 420);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new Size(85, 30);
            btnEditor.TabIndex = 22;
            btnEditor.Text = "Editor";
            btnEditor.UseVisualStyleBackColor = false;
            btnEditor.Click += btnEditor_Click;
            // 
            // formCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(310, 462);
            Controls.Add(btnEditor);
            Controls.Add(lbResultado);
            Controls.Add(btnLigaDesliga);
            Controls.Add(btnResultado);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btnVirgula);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btnLimpar);
            Controls.Add(btn1);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnAdicao);
            Controls.Add(txtCalculadora);
            Controls.Add(txtResultado);
            Controls.Add(btnSubtracao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubtracao;
        private TextBox txtResultado;
        private Label txtCalculadora;
        private Button btnAdicao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btn7;
        private Button btn4;
        private Button btnLimpar;
        private Button btn1;
        private Button btn8;
        private Button btn5;
        private Button btn0;
        private Button btn2;
        private Button btn9;
        private Button btn6;
        private Button btnVirgula;
        private Button btn3;
        private Button btnResultado;
        private Button btnLigaDesliga;
        private Label lbResultado;
        private Button btnEditor;
    }
}
