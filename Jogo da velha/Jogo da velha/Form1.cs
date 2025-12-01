using System.Diagnostics.Eventing.Reader;

namespace Jogo_da_velha
{
    public partial class Velha : Form
    {
        bool vezDoX;
            int jogadas;
            bool jogoEncerrado;
        public Velha()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            {
                if (jogoEncerrado)
                {
                    return;
                }
            }
            Button btn = (Button)sender;
            if(btn.Text != "")
            {
                return;
            }
            btn.Text = vezDoX ? "X" : "O";
            jogadas++;
        }

        


        private void bolinha_CheckedChanged(object sender, EventArgs e)
        {
            if (bolinha.Checked = Enabled)

            {
                bolinha.Checked = true;
            }
            else
            {
                bolinha.Checked = false;
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }
    }
}



