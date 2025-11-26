namespace Formula_de_Baskhara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Selecionar(object sender, EventArgs e)
        {
            {
                Button Selecionar = sender as Button;

                if (Selecionar != null)
                {
                    string conteudo = Selecionar.Text;
                    txtbox_A.Text += conteudo;
                }
            }
        }

        private void lbl_visor_TextChanged(object sender, EventArgs e)
        {
            {
                Button Selecionar = sender as Button;

                if (Selecionar != null)
                {
                    string numeros = Selecionar.Text;
                    txtbox_A.Text = numeros;
                }
            }


        }

        private void txtbox_B_TextChanged(object sender, EventArgs e)
        {
            {
                Button Selecionar = sender as Button;

                if (Selecionar != null)
                {
                    string numeros = Selecionar.Text;
                    txtbox_B.Text = numeros;
                }
            }

        }

        private void txtbox_C_TextChanged(object sender, EventArgs e)
        {
            {
                Button Selecionar = sender as Button;
                if (Selecionar != null)
                {
                    string numeros = Selecionar.Text;
                    txtbox_C.Text = numeros;
                }
            }

        }





        private void Limpar_Click(object sender, EventArgs e)
        {
            {
                txtbox_A.Text = string.Empty;
                txtbox_A.Focus();

                txtbox_A.Text = string.Empty;

                txtbox_B.Focus();
                txtbox_B.Text = string.Empty;

                txtbox_A.Focus();
                txtbox_C.Text = string.Empty;
            }
        }
    }
}