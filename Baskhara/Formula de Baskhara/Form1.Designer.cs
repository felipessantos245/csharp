namespace Formula_de_Baskhara
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            txtbox_A = new TextBox();
            txtbox_C = new TextBox();
            txtbox_B = new TextBox();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_X = new Button();
            btn_0 = new Button();
            negativo = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            txtboxDelta = new TextBox();
            label2 = new Label();
            txtboxX1 = new TextBox();
            txtboxX2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Ver_Calc_historico = new Button();
            Calc = new Button();
            Limpar = new Button();
            Calc_historico = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 120);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 3;
            label1.Text = "Equação do 2° Grau";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(378, 37);
            label5.TabIndex = 18;
            label5.Text = "(       )  x² +   (      )  x + (      ) =0";
            // 
            // txtbox_A
            // 
            txtbox_A.Location = new Point(29, 165);
            txtbox_A.Multiline = true;
            txtbox_A.Name = "txtbox_A";
            txtbox_A.Size = new Size(43, 25);
            txtbox_A.TabIndex = 19;
            txtbox_A.Text = "A";
            txtbox_A.TextChanged += lbl_visor_TextChanged;
            // 
            // txtbox_C
            // 
            txtbox_C.Location = new Point(290, 165);
            txtbox_C.Multiline = true;
            txtbox_C.Name = "txtbox_C";
            txtbox_C.Size = new Size(43, 23);
            txtbox_C.TabIndex = 20;
            txtbox_C.Text = "C";
            txtbox_C.TextChanged += txtbox_C_TextChanged;
            // 
            // txtbox_B
            // 
            txtbox_B.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_B.Location = new Point(177, 165);
            txtbox_B.Multiline = true;
            txtbox_B.Name = "txtbox_B";
            txtbox_B.Size = new Size(38, 25);
            txtbox_B.TabIndex = 21;
            txtbox_B.Text = "B";
            txtbox_B.TextChanged += txtbox_B_TextChanged;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Bisque;
            btn_7.BackgroundImageLayout = ImageLayout.None;
            btn_7.FlatStyle = FlatStyle.Popup;
            btn_7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(12, 212);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(103, 53);
            btn_7.TabIndex = 22;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += Selecionar;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.Bisque;
            btn_8.BackgroundImageLayout = ImageLayout.None;
            btn_8.FlatStyle = FlatStyle.Popup;
            btn_8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(140, 212);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(103, 53);
            btn_8.TabIndex = 23;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += Selecionar;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.Bisque;
            btn_9.BackgroundImageLayout = ImageLayout.None;
            btn_9.FlatStyle = FlatStyle.Popup;
            btn_9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(265, 212);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(103, 53);
            btn_9.TabIndex = 24;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += Selecionar;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Bisque;
            btn_4.BackgroundImageLayout = ImageLayout.None;
            btn_4.FlatStyle = FlatStyle.Popup;
            btn_4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(12, 271);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(103, 53);
            btn_4.TabIndex = 25;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += Selecionar;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.Bisque;
            btn_5.BackgroundImageLayout = ImageLayout.None;
            btn_5.FlatStyle = FlatStyle.Popup;
            btn_5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(140, 271);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(103, 53);
            btn_5.TabIndex = 26;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += Selecionar;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.Bisque;
            btn_6.BackgroundImageLayout = ImageLayout.None;
            btn_6.FlatStyle = FlatStyle.Popup;
            btn_6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(265, 271);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(103, 53);
            btn_6.TabIndex = 27;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += Selecionar;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Bisque;
            btn_1.BackgroundImageLayout = ImageLayout.None;
            btn_1.FlatStyle = FlatStyle.Popup;
            btn_1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(12, 330);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(103, 53);
            btn_1.TabIndex = 28;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += Selecionar;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.Bisque;
            btn_2.BackgroundImageLayout = ImageLayout.None;
            btn_2.FlatStyle = FlatStyle.Popup;
            btn_2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(140, 330);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(103, 53);
            btn_2.TabIndex = 29;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += Selecionar;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.Bisque;
            btn_3.BackgroundImageLayout = ImageLayout.None;
            btn_3.FlatStyle = FlatStyle.Popup;
            btn_3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(265, 330);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(103, 53);
            btn_3.TabIndex = 30;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += Selecionar;
            // 
            // btn_X
            // 
            btn_X.BackColor = Color.Bisque;
            btn_X.BackgroundImageLayout = ImageLayout.None;
            btn_X.FlatStyle = FlatStyle.Popup;
            btn_X.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_X.Location = new Point(12, 389);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(103, 53);
            btn_X.TabIndex = 31;
            btn_X.Text = "x";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += Selecionar;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.Bisque;
            btn_0.BackgroundImageLayout = ImageLayout.None;
            btn_0.FlatStyle = FlatStyle.Popup;
            btn_0.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.Location = new Point(140, 389);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(103, 53);
            btn_0.TabIndex = 32;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += Selecionar;
            // 
            // negativo
            // 
            negativo.BackColor = Color.Bisque;
            negativo.BackgroundImageLayout = ImageLayout.None;
            negativo.FlatStyle = FlatStyle.Popup;
            negativo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            negativo.Location = new Point(265, 389);
            negativo.Name = "negativo";
            negativo.Size = new Size(103, 53);
            negativo.TabIndex = 33;
            negativo.Text = "-";
            negativo.UseVisualStyleBackColor = false;
            negativo.Click += Selecionar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 455);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 264);
            textBox1.TabIndex = 35;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(154, 470);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // txtboxDelta
            // 
            txtboxDelta.BackColor = Color.DarkOrange;
            txtboxDelta.Location = new Point(265, 470);
            txtboxDelta.Multiline = true;
            txtboxDelta.Name = "txtboxDelta";
            txtboxDelta.Size = new Size(100, 33);
            txtboxDelta.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(227, 473);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 38;
            label2.Text = "=";
            // 
            // txtboxX1
            // 
            txtboxX1.BackColor = Color.DarkOrange;
            txtboxX1.Location = new Point(101, 538);
            txtboxX1.Multiline = true;
            txtboxX1.Name = "txtboxX1";
            txtboxX1.Size = new Size(100, 33);
            txtboxX1.TabIndex = 39;
            // 
            // txtboxX2
            // 
            txtboxX2.BackColor = Color.DarkOrange;
            txtboxX2.Location = new Point(265, 538);
            txtboxX2.Multiline = true;
            txtboxX2.Name = "txtboxX2";
            txtboxX2.Size = new Size(100, 33);
            txtboxX2.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 538);
            label4.Name = "label4";
            label4.Size = new Size(36, 32);
            label4.TabIndex = 42;
            label4.Text = "x':";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 538);
            label3.Name = "label3";
            label3.Size = new Size(39, 32);
            label3.TabIndex = 43;
            label3.Text = "x\":";
            // 
            // Ver_Calc_historico
            // 
            Ver_Calc_historico.BackColor = Color.Bisque;
            Ver_Calc_historico.BackgroundImageLayout = ImageLayout.None;
            Ver_Calc_historico.FlatStyle = FlatStyle.Popup;
            Ver_Calc_historico.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ver_Calc_historico.Location = new Point(29, 670);
            Ver_Calc_historico.Name = "Ver_Calc_historico";
            Ver_Calc_historico.Size = new Size(326, 41);
            Ver_Calc_historico.TabIndex = 44;
            Ver_Calc_historico.Text = "Ver Histórico do Cálculo";
            Ver_Calc_historico.UseVisualStyleBackColor = false;
            // 
            // Calc
            // 
            Calc.BackColor = Color.Bisque;
            Calc.BackgroundImageLayout = ImageLayout.None;
            Calc.FlatStyle = FlatStyle.Popup;
            Calc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Calc.Location = new Point(29, 577);
            Calc.Name = "Calc";
            Calc.Size = new Size(326, 39);
            Calc.TabIndex = 45;
            Calc.Text = "CALCULAR";
            Calc.UseVisualStyleBackColor = false;
            // 
            // Limpar
            // 
            Limpar.BackColor = Color.Bisque;
            Limpar.BackgroundImageLayout = ImageLayout.None;
            Limpar.FlatStyle = FlatStyle.Popup;
            Limpar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Limpar.Location = new Point(29, 622);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(326, 42);
            Limpar.TabIndex = 46;
            Limpar.Text = "LIMPAR";
            Limpar.UseVisualStyleBackColor = false;
            Limpar.Click += Limpar_Click;
            // 
            // Calc_historico
            // 
            Calc_historico.Location = new Point(12, 717);
            Calc_historico.Multiline = true;
            Calc_historico.Name = "Calc_historico";
            Calc_historico.Size = new Size(356, 134);
            Calc_historico.TabIndex = 47;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(384, 881);
            Controls.Add(Calc_historico);
            Controls.Add(Limpar);
            Controls.Add(Calc);
            Controls.Add(Ver_Calc_historico);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtboxX2);
            Controls.Add(txtboxX1);
            Controls.Add(label2);
            Controls.Add(txtboxDelta);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(negativo);
            Controls.Add(btn_0);
            Controls.Add(btn_X);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(txtbox_B);
            Controls.Add(txtbox_C);
            Controls.Add(txtbox_A);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Calc de Bhaskará";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private TextBox txtbox_A;
        private TextBox txtbox_C;
        private TextBox txtbox_B;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_X;
        private Button btn_0;
        private Button negativo;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private TextBox txtboxDelta;
        private Label label2;
        private TextBox txtboxX1;
        private TextBox txtboxX2;
        private Label label4;
        private Label label3;
        private Button Ver_Calc_historico;
        private Button Calc;
        private Button Limpar;
        private TextBox Calc_historico;
    }
}