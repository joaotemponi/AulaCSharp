using System.Xml.Linq;

namespace WinFormsAppCalculadora
{
    public partial class formCalculadora : Form
    {

        private double valor1 = 0, valor2 = 0;
        private string operacao = "";
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        #region Botões Calculadora
        private void btn1_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MetodoBotoes((Button)sender);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            MetodosSinais((Button)sender);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            MetodosSinais((Button)sender);
        }

        #endregion

        //Numeros da calculadora
        private void MetodoBotoes(Button sender)
        {
            var botao = (Button)sender;
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += botao.Text;

            lbResultado.Text += botao.Text;
        }

        //Sinais Matemáticos
        private void MetodosSinais(Button sender)
        {
            //Valida se tem algum valor digitado
            if (txtResultado.Text.Length == 0)
                return;

            var botao = (Button)sender;
            valor1 = double.Parse(txtResultado.Text);
            operacao = botao.Text;
            txtResultado.Clear();

            lbResultado.Text += botao.Text;
        }

        //Botões Especiais

        //Limpar

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            valor1 = valor2 = 0;
            operacao = "0";

            lbResultado.Text = "";
        }

        //Vírgula
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }


        private void btnResultado_Click_1(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtResultado.Text);
            switch (operacao)
            {
                case "+":
                    txtResultado.Text = (valor1 + valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "-":
                    txtResultado.Text = (valor1 - valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "x":
                    txtResultado.Text = (valor1 * valor2).ToString();
                    lbResultado.Text = txtResultado.Text;
                    break;
                case "/":
                    txtResultado.Text = valor2 != 0 ? (valor1 / valor2).ToString() : "Erro";
                    lbResultado.Text = txtResultado.Text;
                    break;
            }
        }

        private void btnMultiplicacao_Click_1(object sender, EventArgs e)
        {
            MetodosSinais((Button)sender);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            MetodosSinais((Button)sender);
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            MetodosSinais((Button)sender);
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            FrmEditorTexto frmEditorTexto = new FrmEditorTexto();
            frmEditorTexto.ShowDialog();
        }
    }


}
