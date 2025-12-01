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
            groupBox1 = new GroupBox();
            Player2 = new TextBox();
            Player1 = new TextBox();
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
            groupBox1.SuspendLayout();
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
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 231);
            button2.Name = "button2";
            button2.Size = new Size(86, 74);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(356, 231);
            button3.Name = "button3";
            button3.Size = new Size(86, 74);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(172, 311);
            button4.Name = "button4";
            button4.Size = new Size(86, 74);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(264, 311);
            button5.Name = "button5";
            button5.Size = new Size(86, 74);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(356, 311);
            button6.Name = "button6";
            button6.Size = new Size(86, 74);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(172, 391);
            button7.Name = "button7";
            button7.Size = new Size(86, 74);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(265, 391);
            button8.Name = "button8";
            button8.Size = new Size(86, 74);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(357, 391);
            button9.Name = "button9";
            button9.Size = new Size(86, 74);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Player2);
            groupBox1.Controls.Add(Player1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 112);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogadores";
            // 
            // Player2
            // 
            Player2.Location = new Point(6, 71);
            Player2.Name = "Player2";
            Player2.Size = new Size(178, 33);
            Player2.TabIndex = 11;
            // 
            // Player1
            // 
            Player1.Location = new Point(6, 32);
            Player1.Name = "Player1";
            Player1.Size = new Size(178, 33);
            Player1.TabIndex = 10;
            // 
            // Placar
            // 
            Placar.Controls.Add(Placar2);
            Placar.Controls.Add(Placar1);
            Placar.Location = new Point(218, 12);
            Placar.Name = "Placar";
            Placar.Size = new Size(200, 112);
            Placar.TabIndex = 10;
            Placar.TabStop = false;
            Placar.Text = "Placar";
            // 
            // Placar2
            // 
            Placar2.AutoSize = true;
            Placar2.Location = new Point(6, 74);
            Placar2.Name = "Placar2";
            Placar2.Size = new Size(0, 25);
            Placar2.TabIndex = 1;
            // 
            // Placar1
            // 
            Placar1.AutoSize = true;
            Placar1.Location = new Point(6, 35);
            Placar1.Name = "Placar1";
            Placar1.Size = new Size(0, 25);
            Placar1.TabIndex = 0;
            // 
            // opcao
            // 
            opcao.Controls.Add(xis);
            opcao.Controls.Add(bolinha);
            opcao.Controls.Add(label1);
            opcao.Controls.Add(label2);
            opcao.Location = new Point(424, 12);
            opcao.Name = "opcao";
            opcao.Size = new Size(200, 112);
            opcao.TabIndex = 11;
            opcao.TabStop = false;
            opcao.Text = "Opções";
            // 
            // xis
            // 
            xis.AutoSize = true;
            xis.Location = new Point(12, 67);
            xis.Name = "xis";
            xis.Size = new Size(42, 29);
            xis.TabIndex = 3;
            xis.TabStop = true;
            xis.Text = "X";
            xis.UseVisualStyleBackColor = true;
            // 
            // bolinha
            // 
            bolinha.AutoSize = true;
            bolinha.Location = new Point(12, 32);
            bolinha.Name = "bolinha";
            bolinha.Size = new Size(44, 29);
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
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 0;
            // 
            // Reset
            // 
            Reset.FlatStyle = FlatStyle.Popup;
            Reset.Location = new Point(127, 130);
            Reset.Name = "Reset";
            Reset.Size = new Size(109, 34);
            Reset.TabIndex = 12;
            Reset.Text = "Reiniciar";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Play
            // 
            Play.FlatStyle = FlatStyle.Popup;
            Play.Location = new Point(12, 130);
            Play.Name = "Play";
            Play.Size = new Size(109, 34);
            Play.TabIndex = 13;
            Play.Text = "Começar";
            Play.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.Popup;
            Exit.Location = new Point(242, 130);
            Exit.Name = "Exit";
            Exit.Size = new Size(109, 34);
            Exit.TabIndex = 14;
            Exit.Text = "Sair";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Velha
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(631, 489);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Reset);
            Controls.Add(opcao);
            Controls.Add(Placar);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Placar.ResumeLayout(false);
            Placar.PerformLayout();
            opcao.ResumeLayout(false);
            opcao.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private TextBox Player2;
        private TextBox Player1;
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
    }
}
