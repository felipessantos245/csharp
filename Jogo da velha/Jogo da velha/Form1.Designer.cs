namespace Jogo_da_velha
{
    partial class Velha
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Placar = new GroupBox();
            Placar2 = new Label();
            Placar1 = new Label();
            opcao = new GroupBox();
            xis = new RadioButton();
            bolinha = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            Reset = new Button();
            Play = new Button();
            Exit = new Button();
            labelStatus = new Label();
            Placar.SuspendLayout();
            opcao.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 231);
            button1.Name = "button1";
            button1.Size = new Size(86, 74);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_CLick;
            // 
            // button2
            // 
            button2.Location = new Point(264, 231);
            button2.Name = "button2";
            button2.Size = new Size(86, 74);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_CLick;
            // 
            // button3
            // 
            button3.Location = new Point(356, 231);
            button3.Name = "button3";
            button3.Size = new Size(86, 74);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_CLick;
            // 
            // button4
            // 
            button4.Location = new Point(172, 311);
            button4.Name = "button4";
            button4.Size = new Size(86, 74);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_CLick;
            // 
            // button5
            // 
            button5.Location = new Point(264, 311);
            button5.Name = "button5";
            button5.Size = new Size(86, 74);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_CLick;
            // 
            // button6
            // 
            button6.Location = new Point(356, 311);
            button6.Name = "button6";
            button6.Size = new Size(86, 74);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_CLick;
            // 
            // button7
            // 
            button7.Location = new Point(172, 391);
            button7.Name = "button7";
            button7.Size = new Size(86, 74);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_CLick;
            // 
            // button8
            // 
            button8.Location = new Point(265, 391);
            button8.Name = "button8";
            button8.Size = new Size(86, 74);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_CLick;
            // 
            // button9
            // 
            button9.Location = new Point(357, 391);
            button9.Name = "button9";
            button9.Size = new Size(86, 74);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_CLick;
            // 
            // Placar
            // 
            Placar.Controls.Add(Placar2);
            Placar.Controls.Add(Placar1);
            Placar.Location = new Point(12, 12);
            Placar.Name = "Placar";
            Placar.Size = new Size(200, 129);
            Placar.TabIndex = 10;
            Placar.TabStop = false;
            Placar.Text = "Placar";
            // 
            // Placar2
            // 
            Placar2.AutoSize = true;
            Placar2.Location = new Point(6, 74);
            Placar2.Name = "Placar2";
            Placar2.Size = new Size(0, 32);
            Placar2.TabIndex = 1;
            // 
            // Placar1
            // 
            Placar1.AutoSize = true;
            Placar1.Location = new Point(6, 35);
            Placar1.Name = "Placar1";
            Placar1.Size = new Size(0, 32);
            Placar1.TabIndex = 0;
            // 
            // opcao
            // 
            opcao.Controls.Add(xis);
            opcao.Controls.Add(bolinha);
            opcao.Controls.Add(label1);
            opcao.Controls.Add(label2);
            opcao.Location = new Point(231, 12);
            opcao.Name = "opcao";
            opcao.Size = new Size(200, 129);
            opcao.TabIndex = 11;
            opcao.TabStop = false;
            opcao.Text = "Opções";
            // 
            // xis
            // 
            xis.AutoSize = true;
            xis.Location = new Point(12, 74);
            xis.Name = "xis";
            xis.Size = new Size(50, 36);
            xis.TabIndex = 3;
            xis.TabStop = true;
            xis.Text = "X";
            xis.UseVisualStyleBackColor = true;
            xis.CheckedChanged += xis_CheckedChanged;
            // 
            // bolinha
            // 
            bolinha.AutoSize = true;
            bolinha.Location = new Point(12, 32);
            bolinha.Name = "bolinha";
            bolinha.Size = new Size(53, 36);
            bolinha.TabIndex = 2;
            bolinha.TabStop = true;
            bolinha.Text = "O";
            bolinha.UseVisualStyleBackColor = true;
            bolinha.CheckedChanged += bolinha_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 0;
            // 
            // Reset
            // 
            Reset.FlatStyle = FlatStyle.Popup;
            Reset.Location = new Point(138, 161);
            Reset.Name = "Reset";
            Reset.Size = new Size(133, 47);
            Reset.TabIndex = 12;
            Reset.Text = "Reiniciar";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Play
            // 
            Play.FlatStyle = FlatStyle.Popup;
            Play.Location = new Point(12, 161);
            Play.Name = "Play";
            Play.Size = new Size(120, 47);
            Play.TabIndex = 13;
            Play.Text = "Começar";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.Popup;
            Exit.Location = new Point(277, 161);
            Exit.Name = "Exit";
            Exit.Size = new Size(109, 47);
            Exit.TabIndex = 14;
            Exit.Text = "Sair";
            Exit.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(405, 161);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 32);
            labelStatus.TabIndex = 15;
            // 
            // Velha
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(684, 489);
            Controls.Add(labelStatus);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Reset);
            Controls.Add(opcao);
            Controls.Add(Placar);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Velha";
            Text = "Jogo da Velha";
            Placar.ResumeLayout(false);
            Placar.PerformLayout();
            opcao.ResumeLayout(false);
            opcao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private GroupBox Placar;
        private Label Placar2;
        private Label Placar1;
        private GroupBox opcao;
        private RadioButton xis;
        private RadioButton bolinha;
        private Label label1;
        private Label label2;
        private Button Reset;
        private Button Play;
        private Button Exit;
        private Label labelStatus;
    }
}
