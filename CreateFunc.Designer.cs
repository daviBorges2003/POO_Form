namespace projetoPOO
{
    partial class CreateFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameBox = new TextBox();
            CpfBox = new TextBox();
            EmailBOX = new TextBox();
            SenhaBOX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CadastroFunc = new Button();
            Cadastrado = new TextBox();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(151, 78);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 0;
            NameBox.TextChanged += Name_TextChanged;
            // 
            // CpfBox
            // 
            CpfBox.Location = new Point(257, 78);
            CpfBox.Name = "CpfBox";
            CpfBox.Size = new Size(100, 23);
            CpfBox.TabIndex = 1;
            CpfBox.TextChanged += CpfBox_TextChanged;
            // 
            // EmailBOX
            // 
            EmailBOX.Location = new Point(151, 123);
            EmailBOX.Name = "EmailBOX";
            EmailBOX.Size = new Size(206, 23);
            EmailBOX.TabIndex = 2;
            EmailBOX.TextChanged += EmailBOX_TextChanged;
            // 
            // SenhaBOX
            // 
            SenhaBOX.Location = new Point(151, 167);
            SenhaBOX.Name = "SenhaBOX";
            SenhaBOX.Size = new Size(206, 23);
            SenhaBOX.TabIndex = 5;
            SenhaBOX.TextChanged += SenhaBOX_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 60);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 60);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "Cpf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 149);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Senha:";
            // 
            // CadastroFunc
            // 
            CadastroFunc.Location = new Point(151, 205);
            CadastroFunc.Name = "CadastroFunc";
            CadastroFunc.Size = new Size(206, 31);
            CadastroFunc.TabIndex = 10;
            CadastroFunc.Text = "CADASTRAR";
            CadastroFunc.UseVisualStyleBackColor = true;
            CadastroFunc.Click += CadastroFunc_Click;
            // 
            // Cadastrado
            // 
            Cadastrado.BackColor = Color.Lime;
            Cadastrado.BorderStyle = BorderStyle.FixedSingle;
            Cadastrado.Location = new Point(151, 34);
            Cadastrado.Name = "Cadastrado";
            Cadastrado.Size = new Size(206, 23);
            Cadastrado.TabIndex = 11;
            Cadastrado.Text = "CADASTRADO";
            Cadastrado.TextAlign = HorizontalAlignment.Center;
            // 
            // CreateFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 331);
            Controls.Add(Cadastrado);
            Controls.Add(CadastroFunc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SenhaBOX);
            Controls.Add(EmailBOX);
            Controls.Add(CpfBox);
            Controls.Add(NameBox);
            Name = "CreateFunc";
            Text = "CreateFunc";
            Load += CreateFunc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox CpfBox;
        private TextBox EmailBOX;
        private TextBox SenhaBOX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CadastroFunc;
        private TextBox Cadastrado;
    }
}