namespace acai_bao
{
    public partial class Form1 : Form
    {
        int preco = 0;
        public Form1()
        {
            InitializeComponent();
            preco = 0;
        }

        private void gpTamanho(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Selecionar(object sender, EventArgs e)
        {

        }

        private void CalcPedido_Click(object sender, EventArgs e)
        {

        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparComanda_Click(object sender, EventArgs e)
        {
            Comanda.Items.Clear();
        }

        private void cbOreo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checar(object sender, EventArgs e)
        {
            if (cbOreo.Checked)
            {
                preco = preco + 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Add(cbOreo.Text);
            }
            else
            {
                preco = preco - 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Remove(cbOreo.Text);
            }
        }

        private void cbBis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBis.Checked)
            {
                preco = preco + 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Add(cbBis.Text);
            }
            else
            {
                preco = preco - 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Remove(cbBis.Text);
            }
        }

        private void cbNutella_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNutella.Checked)
            {
                preco = preco + 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Add(cbNutella.Text);
            }
            else
            {
                preco = preco - 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Remove(cbNutella.Text);
            }
        }

        private void cbKitKat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKitKat.Checked)
            {
                preco = preco + 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Add(cbKitKat.Text);
            }
            else
            {
                preco = preco - 03;
                Pao.Text = preco.ToString();
                Comanda.Items.Remove(cbKitKat.Text);
            }
        }

        private void tamanho300ml_CheckedChanged(object sender, EventArgs e)
        {
            if (tamanho300ml.Checked)
            {
                preco = preco + 12;
                Pao.Text = preco.ToString();
                Comanda.Items.Add(tamanho300ml.Text);
            }
            else
            {
                preco = preco - 12;
                Pao.Text = preco.ToString();
                Comanda.Items.Remove(tamanho300ml.Text);
            }
        }

        private void tamanho500ml_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (tamanho500ml.Checked)
                {
                    preco = preco + 15;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(tamanho500ml.Text);
                }
                else
                {
                    preco = preco - 15;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(tamanho500ml.Text);
                }
            }
        }

        private void tamanho700ml_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (tamanho300ml.Checked)
                {
                    preco = preco + 18;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(tamanho700ml.Text);
                }
                else
                {
                    preco = preco - 18;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(tamanho700ml.Text);
                }
            }
        }

        private void tamanho1l_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (tamanho1l.Checked)
                {
                    preco = preco + 21;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(tamanho1l.Text);
                }
                else
                {
                    preco = preco - 21;
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(tamanho1l.Text);
                }
            }
        }

        private void Comanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLeite_em_po_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbLeite_em_po.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbLeite_em_po.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbLeite_em_po.Text);
                }
            }
        }

        private void cbOvo_Maltine_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    if (cbOvo_Maltine.Checked)
                    {
                        Pao.Text = preco.ToString();
                        Comanda.Items.Add(cbOvo_Maltine.Text);
                    }
                    else
                    {
                        Pao.Text = preco.ToString();
                        Comanda.Items.Remove(cbOvo_Maltine.Text);
                    }
                }
            }
        }

        private void cbLeite_Condensado_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbLeite_Condensado.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbLeite_Condensado.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbLeite_Condensado.Text);
                }
            }
        }

        private void cbGranola_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbGranola.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbGranola.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbGranola.Text);
                }
            }
        }

        private void cbPacoca_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbPacoca.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbPacoca.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbPacoca.Text);
                }
            }
        }

        private void cbSucrilhos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbSucrilhos.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbSucrilhos.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbSucrilhos.Text);
                }
            }
        }

        private void cbGotas_Chocolate_CheckedChanged(object sender, EventArgs e)
        {
            {
                {
                    if (cbGotas_Chocolate.Checked)
                    {
                        Pao.Text = preco.ToString();
                        Comanda.Items.Add(cbGotas_Chocolate.Text);
                    }
                    else
                    {
                        Pao.Text = preco.ToString();
                        Comanda.Items.Remove(cbGotas_Chocolate.Text);
                    }
                }
            }
        }

        private void cbChocoball_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbChocoball.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbChocoball.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbChocoball.Text);
                }
            }
        }

        private void cbAmendoim_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbAmendoim.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(cbAmendoim.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(cbAmendoim.Text);
                }
            }
        }

        private void coberChocolate_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (coberChocolate.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(coberChocolate.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(coberChocolate.Text);
                }
            }
        }

        private void coberMenta_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (coberMenta.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(coberMenta.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(coberMenta.Text);
                }
            }
        }

        private void coberMorango_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (coberMorango.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(coberMorango.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(coberMorango.Text);
                }
            }
        }

        private void coberMel_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (coberMel.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(coberMel.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(coberMel.Text);
                }
            }
        }

        private void frutaBanana_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (frutaBanana.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(frutaBanana.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(frutaBanana.Text);
                }
            }
        }

        private void frutaMorango_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (frutaMorango.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(frutaMorango.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(frutaMorango.Text);
                }
            }
        }

        private void frutaMaca_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (frutaMaca.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(frutaMaca.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(frutaMaca.Text);
                }
            }
        }

        private void frutaUva_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (frutaUva.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(frutaUva.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(frutaUva.Text);
                }
            }
        }
            private void frutaManga_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (frutaManga.Checked)
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Add(frutaManga.Text);
                }
                else
                {
                    Pao.Text = preco.ToString();
                    Comanda.Items.Remove(frutaManga.Text);
                }
            }
        }
    }
}