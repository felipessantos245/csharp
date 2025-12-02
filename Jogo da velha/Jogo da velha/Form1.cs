using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace Jogo_da_velha
{
    public partial class Velha : Form
    {
        private string jogadorAtual = "X";
        private int contadorJogadas = 0;
        private string nomePlayerX = "Jogador X";
        private string nomePlayerO = "Jogador O";

        private int placarX = 0;
        private int placarO = 0;

        private Button[] botoesTabuleiro;

        public Velha()
        {
            InitializeComponent();

            botoesTabuleiro = new Button[] {
                button1, button2, button3,
                button4, button5, button6,
                button7, button8, button9
            };

            if (xis != null) xis.Checked = false;
            if (bolinha != null) bolinha.Checked = false;

            SolicitarNomesJogadores();


            ResetarJogo(true);
        }



        private void ResetarJogo(bool resetarPlacar = false)
            {
                   HabilitarTabuleiro(false); 

  
            xis.Enabled = true;
            bolinha.Enabled = true;


            Play.Enabled = false;


            foreach (Button botao in botoesTabuleiro)
            {
                botao.Text = "";
            }

            jogadorAtual = "X";
            contadorJogadas = 0;

            if (resetarPlacar)
            {
                placarX = 0;
                placarO = 0;
            }

            AtualizarPlacar();
            labelStatus.Text = $"Escolha seu símbolo (X ou O) para habilitar o 'Começar Jogo'.";
            }

        private void HabilitarTabuleiro(bool habilitar)
        {
            foreach (Button botao in botoesTabuleiro)
            {
                botao.Enabled = habilitar ? string.IsNullOrEmpty(botao.Text) : false;
            }
        }

        private void AtualizarPlacar()
        {
            Placar.Text = $"{nomePlayerX} (X): {placarX} | {nomePlayerO} (O): {placarO}";
        }

        private void SolicitarNomesJogadores()
        {
            nomePlayerX = Interaction.InputBox("Digite o nome do Jogador X (começa):", "Nome do Jogador X", "Jogador X");
            if (string.IsNullOrWhiteSpace(nomePlayerX)) nomePlayerX = "Jogador X";

            nomePlayerO = Interaction.InputBox("Digite o nome do Jogador O:", "Nome do Jogador O", "Jogador O");
            if (string.IsNullOrWhiteSpace(nomePlayerO)) nomePlayerO = "Jogador O";
        }


        private bool VerificarLinha(Button b1, Button b2, Button b3)
        {
            return !string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text;
        }

        private bool VerificarVencedor()
        {
            if (VerificarLinha(button1, button2, button3)) return true;
            if (VerificarLinha(button4, button5, button6)) return true;
            if (VerificarLinha(button7, button8, button9)) return true;
            if (VerificarLinha(button1, button4, button7)) return true;
            if (VerificarLinha(button2, button5, button8)) return true;
            if (VerificarLinha(button3, button6, button9)) return true;
            if (VerificarLinha(button1, button5, button9)) return true;
            if (VerificarLinha(button3, button5, button7)) return true;
            return false;
        }

        private void xis_CheckedChanged(object sender, EventArgs e)
        {
            Play.Enabled = xis.Checked || bolinha.Checked;

        }

        private void bolinha_CheckedChanged(object sender, EventArgs e)

        {
            Play.Enabled = xis.Checked || bolinha.Checked;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            {
                {
                    if (!xis.Checked && !bolinha.Checked)
                    {
                        MessageBox.Show("Por favor, selecione seu símbolo (X ou O) para começar.", "Erro de Início", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    jogadorAtual = xis.Checked ? "X" : "O";
                    contadorJogadas = 0;

                    foreach (Button botao in botoesTabuleiro)
                    {
                        botao.Text = "";
                    }
                    HabilitarTabuleiro(true);

                    xis.Enabled = false;
                    bolinha.Enabled = false;
                    Play.Enabled = false;

                    string nomeInicial = (jogadorAtual == "X") ? nomePlayerX : nomePlayerO;
                    labelStatus.Text = $"Vez de: {nomeInicial} ({jogadorAtual})";
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            {

                ResetarJogo();
            }
        }

        private void Button_CLick(object sender, EventArgs e)
        {
            {
                Button botaoClicado = (Button)sender;

                if (string.IsNullOrEmpty(botaoClicado.Text))
                {
                    botaoClicado.Text = jogadorAtual;
                    botaoClicado.Enabled = false;
                    contadorJogadas++;

                    string nomeVencedor = (jogadorAtual == "X") ? nomePlayerX : nomePlayerO;

                    if (VerificarVencedor())
                    {
                        if (jogadorAtual == "X") placarX++;
                        else placarO++;

                        AtualizarPlacar();
                        MessageBox.Show($"O jogador '{nomeVencedor}' VENCEU!", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelStatus.Text = $"Vencedor: {nomeVencedor}!";

                        HabilitarTabuleiro(false);
                        xis.Enabled = true;
                        bolinha.Enabled = true;
                        Play.Enabled = xis.Checked || bolinha.Checked;
                        return;
                    }

                    if (contadorJogadas == 9)
                    {
                        MessageBox.Show("O jogo terminou empatado (Deu Velha)!", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelStatus.Text = "Fim de Jogo: Empate!";

                        HabilitarTabuleiro(false);
                        xis.Enabled = true;
                        bolinha.Enabled = true;
                        Play.Enabled = xis.Checked || bolinha.Checked; 
                        return;
                    }

                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                    string proximoNome = (jogadorAtual == "X") ? nomePlayerX : nomePlayerO;
                    labelStatus.Text = $"Vez de: {proximoNome} ({jogadorAtual})";
                }
            }
        }
    }
}





