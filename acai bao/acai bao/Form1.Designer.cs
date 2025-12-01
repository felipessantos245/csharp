namespace acai_bao
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
            label1 = new Label();
            gpTamanhos = new GroupBox();
            tamanho300ml = new CheckBox();
            tamanho700ml = new CheckBox();
            tamanho1l = new CheckBox();
            tamanho500ml = new CheckBox();
            gpFrutas = new GroupBox();
            frutaUva = new CheckBox();
            frutaManga = new CheckBox();
            frutaMaca = new CheckBox();
            frutaMorango = new CheckBox();
            frutaBanana = new CheckBox();
            gpComplementos = new GroupBox();
            cbAmendoim = new CheckBox();
            cbGotas_Chocolate = new CheckBox();
            cbChocoball = new CheckBox();
            cbSucrilhos = new CheckBox();
            cbGranola = new CheckBox();
            cbPacoca = new CheckBox();
            cbLeite_Condensado = new CheckBox();
            cbOvo_Maltine = new CheckBox();
            cbLeite_em_po = new CheckBox();
            gpAdicionais = new GroupBox();
            cbKitKat = new CheckBox();
            cbNutella = new CheckBox();
            cbBis = new CheckBox();
            cbOreo = new CheckBox();
            coberMenta = new CheckBox();
            coberMel = new CheckBox();
            coberMorango = new CheckBox();
            coberChocolate = new CheckBox();
            gpCoberturas = new GroupBox();
            Comanda = new ListBox();
            Finalizar = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            LimparComanda = new Button();
            Pao = new TextBox();
            gpTamanhos.SuspendLayout();
            gpFrutas.SuspendLayout();
            gpComplementos.SuspendLayout();
            gpAdicionais.SuspendLayout();
            gpCoberturas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 0;
            label1.Text = "Sabores Do Pará";
            // 
            // gpTamanhos
            // 
            gpTamanhos.BackColor = Color.Transparent;
            gpTamanhos.Controls.Add(tamanho300ml);
            gpTamanhos.Controls.Add(tamanho700ml);
            gpTamanhos.Controls.Add(tamanho1l);
            gpTamanhos.Controls.Add(tamanho500ml);
            gpTamanhos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gpTamanhos.ForeColor = SystemColors.ControlLightLight;
            gpTamanhos.Location = new Point(167, 52);
            gpTamanhos.Name = "gpTamanhos";
            gpTamanhos.Size = new Size(129, 248);
            gpTamanhos.TabIndex = 1;
            gpTamanhos.TabStop = false;
            gpTamanhos.Text = "Tamanho";
            gpTamanhos.Enter += gpTamanho;
            // 
            // tamanho300ml
            // 
            tamanho300ml.AutoSize = true;
            tamanho300ml.Location = new Point(6, 54);
            tamanho300ml.Name = "tamanho300ml";
            tamanho300ml.Size = new Size(99, 34);
            tamanho300ml.TabIndex = 3;
            tamanho300ml.Text = "300ml ";
            tamanho300ml.UseVisualStyleBackColor = true;
            tamanho300ml.CheckedChanged += tamanho300ml_CheckedChanged;
            tamanho300ml.Click += Selecionar;
            // 
            // tamanho700ml
            // 
            tamanho700ml.AutoSize = true;
            tamanho700ml.Location = new Point(6, 134);
            tamanho700ml.Name = "tamanho700ml";
            tamanho700ml.Size = new Size(93, 34);
            tamanho700ml.TabIndex = 2;
            tamanho700ml.Text = "700ml";
            tamanho700ml.UseVisualStyleBackColor = true;
            tamanho700ml.CheckedChanged += tamanho700ml_CheckedChanged;
            tamanho700ml.Click += Selecionar;
            // 
            // tamanho1l
            // 
            tamanho1l.AutoSize = true;
            tamanho1l.Location = new Point(6, 174);
            tamanho1l.Name = "tamanho1l";
            tamanho1l.Size = new Size(55, 34);
            tamanho1l.TabIndex = 1;
            tamanho1l.Text = "1L";
            tamanho1l.UseVisualStyleBackColor = true;
            tamanho1l.CheckedChanged += tamanho1l_CheckedChanged;
            tamanho1l.Click += Selecionar;
            // 
            // tamanho500ml
            // 
            tamanho500ml.AutoSize = true;
            tamanho500ml.Location = new Point(6, 94);
            tamanho500ml.Name = "tamanho500ml";
            tamanho500ml.Size = new Size(99, 34);
            tamanho500ml.TabIndex = 0;
            tamanho500ml.Text = "500ml ";
            tamanho500ml.UseVisualStyleBackColor = true;
            tamanho500ml.CheckedChanged += tamanho500ml_CheckedChanged;
            tamanho500ml.Click += Selecionar;
            // 
            // gpFrutas
            // 
            gpFrutas.BackColor = Color.Transparent;
            gpFrutas.Controls.Add(frutaUva);
            gpFrutas.Controls.Add(frutaManga);
            gpFrutas.Controls.Add(frutaMaca);
            gpFrutas.Controls.Add(frutaMorango);
            gpFrutas.Controls.Add(frutaBanana);
            gpFrutas.FlatStyle = FlatStyle.Flat;
            gpFrutas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gpFrutas.ForeColor = SystemColors.ControlLightLight;
            gpFrutas.Location = new Point(12, 52);
            gpFrutas.Name = "gpFrutas";
            gpFrutas.Size = new Size(153, 248);
            gpFrutas.TabIndex = 2;
            gpFrutas.TabStop = false;
            gpFrutas.Text = "Frutas";
            // 
            // frutaUva
            // 
            frutaUva.AutoSize = true;
            frutaUva.Location = new Point(6, 174);
            frutaUva.Name = "frutaUva";
            frutaUva.Size = new Size(69, 34);
            frutaUva.TabIndex = 6;
            frutaUva.Text = "Uva";
            frutaUva.UseVisualStyleBackColor = true;
            frutaUva.CheckedChanged += frutaUva_CheckedChanged;
            frutaUva.Click += Selecionar;
            // 
            // frutaManga
            // 
            frutaManga.AutoSize = true;
            frutaManga.Location = new Point(6, 214);
            frutaManga.Name = "frutaManga";
            frutaManga.Size = new Size(100, 34);
            frutaManga.TabIndex = 5;
            frutaManga.Text = "Manga";
            frutaManga.UseVisualStyleBackColor = true;
            frutaManga.CheckedChanged += frutaManga_CheckedChanged;
            frutaManga.Click += Selecionar;
            // 
            // frutaMaca
            // 
            frutaMaca.AutoSize = true;
            frutaMaca.Location = new Point(6, 134);
            frutaMaca.Name = "frutaMaca";
            frutaMaca.Size = new Size(84, 34);
            frutaMaca.TabIndex = 4;
            frutaMaca.Text = "Maçã";
            frutaMaca.UseVisualStyleBackColor = true;
            frutaMaca.CheckedChanged += frutaMaca_CheckedChanged;
            frutaMaca.Click += Selecionar;
            // 
            // frutaMorango
            // 
            frutaMorango.AutoSize = true;
            frutaMorango.Location = new Point(6, 94);
            frutaMorango.Name = "frutaMorango";
            frutaMorango.Size = new Size(123, 34);
            frutaMorango.TabIndex = 1;
            frutaMorango.Text = "Morango";
            frutaMorango.UseVisualStyleBackColor = true;
            frutaMorango.CheckedChanged += frutaMorango_CheckedChanged;
            frutaMorango.Click += Selecionar;
            // 
            // frutaBanana
            // 
            frutaBanana.AutoSize = true;
            frutaBanana.Location = new Point(6, 54);
            frutaBanana.Name = "frutaBanana";
            frutaBanana.Size = new Size(104, 34);
            frutaBanana.TabIndex = 0;
            frutaBanana.Text = "Banana";
            frutaBanana.UseVisualStyleBackColor = true;
            frutaBanana.CheckedChanged += frutaBanana_CheckedChanged;
            frutaBanana.Click += Selecionar;
            // 
            // gpComplementos
            // 
            gpComplementos.BackColor = Color.Transparent;
            gpComplementos.Controls.Add(cbAmendoim);
            gpComplementos.Controls.Add(cbGotas_Chocolate);
            gpComplementos.Controls.Add(cbChocoball);
            gpComplementos.Controls.Add(cbSucrilhos);
            gpComplementos.Controls.Add(cbGranola);
            gpComplementos.Controls.Add(cbPacoca);
            gpComplementos.Controls.Add(cbLeite_Condensado);
            gpComplementos.Controls.Add(cbOvo_Maltine);
            gpComplementos.Controls.Add(cbLeite_em_po);
            gpComplementos.FlatStyle = FlatStyle.Flat;
            gpComplementos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gpComplementos.ForeColor = SystemColors.ControlLightLight;
            gpComplementos.Location = new Point(302, 52);
            gpComplementos.Name = "gpComplementos";
            gpComplementos.Size = new Size(459, 402);
            gpComplementos.TabIndex = 7;
            gpComplementos.TabStop = false;
            gpComplementos.Text = "Complementos";
            gpComplementos.Enter += groupBox3_Enter;
            // 
            // cbAmendoim
            // 
            cbAmendoim.AutoSize = true;
            cbAmendoim.Location = new Point(6, 354);
            cbAmendoim.Name = "cbAmendoim";
            cbAmendoim.Size = new Size(141, 34);
            cbAmendoim.TabIndex = 13;
            cbAmendoim.Text = "Amendoim";
            cbAmendoim.UseVisualStyleBackColor = true;
            cbAmendoim.CheckedChanged += cbAmendoim_CheckedChanged;
            cbAmendoim.Click += Selecionar;
            // 
            // cbGotas_Chocolate
            // 
            cbGotas_Chocolate.AutoSize = true;
            cbGotas_Chocolate.Location = new Point(6, 274);
            cbGotas_Chocolate.Name = "cbGotas_Chocolate";
            cbGotas_Chocolate.Size = new Size(222, 34);
            cbGotas_Chocolate.TabIndex = 12;
            cbGotas_Chocolate.Text = "Gotas de Chocolate";
            cbGotas_Chocolate.UseVisualStyleBackColor = true;
            cbGotas_Chocolate.CheckedChanged += cbGotas_Chocolate_CheckedChanged;
            cbGotas_Chocolate.Click += Selecionar;
            // 
            // cbChocoball
            // 
            cbChocoball.AutoSize = true;
            cbChocoball.Location = new Point(6, 314);
            cbChocoball.Name = "cbChocoball";
            cbChocoball.Size = new Size(130, 34);
            cbChocoball.TabIndex = 11;
            cbChocoball.Text = "ChocoBall";
            cbChocoball.UseVisualStyleBackColor = true;
            cbChocoball.CheckedChanged += cbChocoball_CheckedChanged;
            cbChocoball.Click += Selecionar;
            // 
            // cbSucrilhos
            // 
            cbSucrilhos.AutoSize = true;
            cbSucrilhos.Location = new Point(6, 234);
            cbSucrilhos.Name = "cbSucrilhos";
            cbSucrilhos.Size = new Size(122, 34);
            cbSucrilhos.TabIndex = 9;
            cbSucrilhos.Text = "Sucrilhos";
            cbSucrilhos.UseVisualStyleBackColor = true;
            cbSucrilhos.CheckedChanged += cbSucrilhos_CheckedChanged;
            cbSucrilhos.Click += Selecionar;
            // 
            // cbGranola
            // 
            cbGranola.AutoSize = true;
            cbGranola.Location = new Point(6, 154);
            cbGranola.Name = "cbGranola";
            cbGranola.Size = new Size(109, 34);
            cbGranola.TabIndex = 6;
            cbGranola.Text = "Granola";
            cbGranola.UseVisualStyleBackColor = true;
            cbGranola.CheckedChanged += cbGranola_CheckedChanged;
            cbGranola.Click += Selecionar;
            // 
            // cbPacoca
            // 
            cbPacoca.AutoSize = true;
            cbPacoca.Location = new Point(6, 194);
            cbPacoca.Name = "cbPacoca";
            cbPacoca.Size = new Size(99, 34);
            cbPacoca.TabIndex = 5;
            cbPacoca.Text = "Paçoca";
            cbPacoca.UseVisualStyleBackColor = true;
            cbPacoca.CheckedChanged += cbPacoca_CheckedChanged;
            cbPacoca.Click += Selecionar;
            // 
            // cbLeite_Condensado
            // 
            cbLeite_Condensado.AutoSize = true;
            cbLeite_Condensado.Location = new Point(6, 114);
            cbLeite_Condensado.Name = "cbLeite_Condensado";
            cbLeite_Condensado.Size = new Size(207, 34);
            cbLeite_Condensado.TabIndex = 4;
            cbLeite_Condensado.Text = "Leite Condensado";
            cbLeite_Condensado.UseVisualStyleBackColor = true;
            cbLeite_Condensado.CheckedChanged += cbLeite_Condensado_CheckedChanged;
            cbLeite_Condensado.Click += Selecionar;
            // 
            // cbOvo_Maltine
            // 
            cbOvo_Maltine.AutoSize = true;
            cbOvo_Maltine.Location = new Point(6, 74);
            cbOvo_Maltine.Name = "cbOvo_Maltine";
            cbOvo_Maltine.Size = new Size(147, 34);
            cbOvo_Maltine.TabIndex = 1;
            cbOvo_Maltine.Text = "OvoMaltine";
            cbOvo_Maltine.UseVisualStyleBackColor = true;
            cbOvo_Maltine.CheckedChanged += cbOvo_Maltine_CheckedChanged;
            cbOvo_Maltine.Click += Selecionar;
            // 
            // cbLeite_em_po
            // 
            cbLeite_em_po.AutoSize = true;
            cbLeite_em_po.Location = new Point(6, 34);
            cbLeite_em_po.Name = "cbLeite_em_po";
            cbLeite_em_po.Size = new Size(147, 34);
            cbLeite_em_po.TabIndex = 0;
            cbLeite_em_po.Text = "Leite em pó";
            cbLeite_em_po.UseVisualStyleBackColor = true;
            cbLeite_em_po.CheckedChanged += cbLeite_em_po_CheckedChanged;
            cbLeite_em_po.Click += Selecionar;
            // 
            // gpAdicionais
            // 
            gpAdicionais.BackColor = Color.Transparent;
            gpAdicionais.Controls.Add(cbKitKat);
            gpAdicionais.Controls.Add(cbNutella);
            gpAdicionais.Controls.Add(cbBis);
            gpAdicionais.Controls.Add(cbOreo);
            gpAdicionais.FlatStyle = FlatStyle.Flat;
            gpAdicionais.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gpAdicionais.ForeColor = SystemColors.ControlLightLight;
            gpAdicionais.Location = new Point(12, 460);
            gpAdicionais.Name = "gpAdicionais";
            gpAdicionais.Size = new Size(284, 230);
            gpAdicionais.TabIndex = 8;
            gpAdicionais.TabStop = false;
            gpAdicionais.Text = "Adicionais R3,00 Cada";
            // 
            // cbKitKat
            // 
            cbKitKat.AutoSize = true;
            cbKitKat.Location = new Point(6, 174);
            cbKitKat.Name = "cbKitKat";
            cbKitKat.Size = new Size(93, 34);
            cbKitKat.TabIndex = 7;
            cbKitKat.Text = "KitKat";
            cbKitKat.UseVisualStyleBackColor = true;
            cbKitKat.CheckedChanged += cbKitKat_CheckedChanged;
            // 
            // cbNutella
            // 
            cbNutella.AutoSize = true;
            cbNutella.Location = new Point(6, 134);
            cbNutella.Name = "cbNutella";
            cbNutella.Size = new Size(104, 34);
            cbNutella.TabIndex = 6;
            cbNutella.Text = "Nutella";
            cbNutella.UseVisualStyleBackColor = true;
            cbNutella.CheckedChanged += cbNutella_CheckedChanged;
            cbNutella.Click += Selecionar;
            // 
            // cbBis
            // 
            cbBis.AutoSize = true;
            cbBis.Location = new Point(6, 94);
            cbBis.Name = "cbBis";
            cbBis.Size = new Size(60, 34);
            cbBis.TabIndex = 1;
            cbBis.Text = "Bis";
            cbBis.UseVisualStyleBackColor = true;
            cbBis.CheckedChanged += cbBis_CheckedChanged;
            cbBis.Click += Selecionar;
            // 
            // cbOreo
            // 
            cbOreo.AutoSize = true;
            cbOreo.Location = new Point(6, 54);
            cbOreo.Name = "cbOreo";
            cbOreo.Size = new Size(80, 34);
            cbOreo.TabIndex = 0;
            cbOreo.Text = "Oreo";
            cbOreo.UseVisualStyleBackColor = true;
            cbOreo.CheckedChanged += cbOreo_CheckedChanged;
            cbOreo.Click += checar;
            // 
            // coberMenta
            // 
            coberMenta.AutoSize = true;
            coberMenta.Location = new Point(135, 54);
            coberMenta.Name = "coberMenta";
            coberMenta.Size = new Size(95, 34);
            coberMenta.TabIndex = 0;
            coberMenta.Text = "Menta";
            coberMenta.UseVisualStyleBackColor = true;
            coberMenta.CheckedChanged += coberMenta_CheckedChanged;
            coberMenta.Click += Selecionar;
            // 
            // coberMel
            // 
            coberMel.AutoSize = true;
            coberMel.Location = new Point(142, 85);
            coberMel.Name = "coberMel";
            coberMel.Size = new Size(69, 34);
            coberMel.TabIndex = 1;
            coberMel.Text = "Mel";
            coberMel.UseVisualStyleBackColor = true;
            coberMel.CheckedChanged += coberMel_CheckedChanged;
            coberMel.Click += Selecionar;
            // 
            // coberMorango
            // 
            coberMorango.AutoSize = true;
            coberMorango.Location = new Point(6, 85);
            coberMorango.Name = "coberMorango";
            coberMorango.Size = new Size(123, 34);
            coberMorango.TabIndex = 2;
            coberMorango.Text = "Morango";
            coberMorango.UseVisualStyleBackColor = true;
            coberMorango.CheckedChanged += coberMorango_CheckedChanged;
            coberMorango.Click += Selecionar;
            // 
            // coberChocolate
            // 
            coberChocolate.AutoSize = true;
            coberChocolate.Location = new Point(6, 54);
            coberChocolate.Name = "coberChocolate";
            coberChocolate.Size = new Size(130, 34);
            coberChocolate.TabIndex = 3;
            coberChocolate.Text = "Chocolate";
            coberChocolate.UseVisualStyleBackColor = true;
            coberChocolate.CheckedChanged += coberChocolate_CheckedChanged;
            coberChocolate.Click += Selecionar;
            // 
            // gpCoberturas
            // 
            gpCoberturas.BackColor = Color.Transparent;
            gpCoberturas.Controls.Add(coberChocolate);
            gpCoberturas.Controls.Add(coberMorango);
            gpCoberturas.Controls.Add(coberMel);
            gpCoberturas.Controls.Add(coberMenta);
            gpCoberturas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gpCoberturas.ForeColor = SystemColors.ControlLightLight;
            gpCoberturas.Location = new Point(12, 306);
            gpCoberturas.Name = "gpCoberturas";
            gpCoberturas.Size = new Size(284, 148);
            gpCoberturas.TabIndex = 4;
            gpCoberturas.TabStop = false;
            gpCoberturas.Text = "Coberturas";
            // 
            // Comanda
            // 
            Comanda.FormattingEnabled = true;
            Comanda.ItemHeight = 15;
            Comanda.Location = new Point(302, 501);
            Comanda.Name = "Comanda";
            Comanda.Size = new Size(459, 229);
            Comanda.TabIndex = 9;
            Comanda.SelectedIndexChanged += Comanda_SelectedIndexChanged;
            // 
            // Finalizar
            // 
            Finalizar.FlatStyle = FlatStyle.Flat;
            Finalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Finalizar.ForeColor = SystemColors.ControlLightLight;
            Finalizar.Location = new Point(349, 806);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(153, 48);
            Finalizar.TabIndex = 11;
            Finalizar.Text = "Finalizar Pedido";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += Finalizar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 698);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 32);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 698);
            label5.Name = "label5";
            label5.Size = new Size(90, 32);
            label5.TabIndex = 14;
            label5.Text = "Nome:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Forte", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(302, 466);
            label7.Name = "label7";
            label7.Size = new Size(221, 32);
            label7.TabIndex = 15;
            label7.Text = "~~Comanda~~";
            // 
            // LimparComanda
            // 
            LimparComanda.FlatStyle = FlatStyle.Flat;
            LimparComanda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LimparComanda.ForeColor = SystemColors.ControlLightLight;
            LimparComanda.Location = new Point(528, 806);
            LimparComanda.Name = "LimparComanda";
            LimparComanda.Size = new Size(153, 48);
            LimparComanda.TabIndex = 16;
            LimparComanda.Text = "Limpar Comanda";
            LimparComanda.UseVisualStyleBackColor = true;
            LimparComanda.Click += LimparComanda_Click;
            // 
            // Pao
            // 
            Pao.Location = new Point(130, 806);
            Pao.Multiline = true;
            Pao.Name = "Pao";
            Pao.Size = new Size(183, 48);
            Pao.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(773, 866);
            Controls.Add(Pao);
            Controls.Add(LimparComanda);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(Finalizar);
            Controls.Add(Comanda);
            Controls.Add(gpAdicionais);
            Controls.Add(gpCoberturas);
            Controls.Add(gpComplementos);
            Controls.Add(gpFrutas);
            Controls.Add(gpTamanhos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Selecionar;
            gpTamanhos.ResumeLayout(false);
            gpTamanhos.PerformLayout();
            gpFrutas.ResumeLayout(false);
            gpFrutas.PerformLayout();
            gpComplementos.ResumeLayout(false);
            gpComplementos.PerformLayout();
            gpAdicionais.ResumeLayout(false);
            gpAdicionais.PerformLayout();
            gpCoberturas.ResumeLayout(false);
            gpCoberturas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox gpTamanhos;
        private CheckBox tamanho700ml;
        private CheckBox tamanho1l;
        private CheckBox tamanho500ml;
        private GroupBox gpFrutas;
        private CheckBox frutaUva;
        private CheckBox frutaManga;
        private CheckBox frutaMaca;
        private CheckBox frutaMorango;
        private CheckBox frutaBanana;
        private GroupBox gpComplementos;
        private CheckBox cbGranola;
        private CheckBox cbPacoca;
        private CheckBox cbLeite_Condensado;
        private CheckBox cbOvo_Maltine;
        private CheckBox cbLeite_em_po;
        private CheckBox tamanho300ml;
        private CheckBox cbAmendoim;
        private CheckBox cbGotas_Chocolate;
        private CheckBox cbChocoball;
        private CheckBox cbSucrilhos;
        private GroupBox gpAdicionais;
        private CheckBox cbNutella;
        private CheckBox cbBis;
        private CheckBox cbOreo;
        private CheckBox coberMenta;
        private CheckBox coberMel;
        private CheckBox coberMorango;
        private CheckBox coberChocolate;
        private GroupBox gpCoberturas;
        private ListBox Comanda;
        private Button Finalizar;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private CheckBox cbKitKat;
        private Button LimparComanda;
        private TextBox Pao;
    }
}