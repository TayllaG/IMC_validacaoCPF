namespace _2_bimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_Confimacao = new System.Windows.Forms.Label();
            this.lb_confirmacao = new System.Windows.Forms.Label();
            this.tx_senha = new System.Windows.Forms.MaskedTextBox();
            this.tx_confSenha = new System.Windows.Forms.MaskedTextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lb_confir = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_nome.Location = new System.Drawing.Point(75, 86);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(247, 20);
            this.tx_nome.TabIndex = 1;
            // 
            // tx_sexo
            // 
            this.tx_sexo.FormattingEnabled = true;
            this.tx_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Unissex"});
            this.tx_sexo.Location = new System.Drawing.Point(75, 159);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(121, 21);
            this.tx_sexo.TabIndex = 3;
            this.tx_sexo.SelectedIndexChanged += new System.EventHandler(this.tx_sexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirmar Senha:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_confir);
            this.panel1.Controls.Add(this.tx_cpf);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tx_confSenha);
            this.panel1.Controls.Add(this.tx_senha);
            this.panel1.Controls.Add(this.lb_confirmacao);
            this.panel1.Controls.Add(this.lb_Confimacao);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 281);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(198, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(84, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 281);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_Confimacao
            // 
            this.lb_Confimacao.AutoSize = true;
            this.lb_Confimacao.Location = new System.Drawing.Point(113, 232);
            this.lb_Confimacao.Name = "lb_Confimacao";
            this.lb_Confimacao.Size = new System.Drawing.Size(0, 13);
            this.lb_Confimacao.TabIndex = 21;
            this.lb_Confimacao.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_confirmacao
            // 
            this.lb_confirmacao.AutoSize = true;
            this.lb_confirmacao.Location = new System.Drawing.Point(113, 232);
            this.lb_confirmacao.Name = "lb_confirmacao";
            this.lb_confirmacao.Size = new System.Drawing.Size(0, 13);
            this.lb_confirmacao.TabIndex = 22;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(66, 178);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(169, 20);
            this.tx_senha.TabIndex = 23;
            // 
            // tx_confSenha
            // 
            this.tx_confSenha.Location = new System.Drawing.Point(110, 208);
            this.tx_confSenha.Name = "tx_confSenha";
            this.tx_confSenha.PasswordChar = '*';
            this.tx_confSenha.Size = new System.Drawing.Size(169, 20);
            this.tx_confSenha.TabIndex = 24;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(63, 112);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(216, 20);
            this.tx_cpf.TabIndex = 25;
            // 
            // lb_confir
            // 
            this.lb_confir.AutoSize = true;
            this.lb_confir.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_confir.Location = new System.Drawing.Point(107, 231);
            this.lb_confir.Name = "lb_confir";
            this.lb_confir.Size = new System.Drawing.Size(35, 13);
            this.lb_confir.TabIndex = 26;
            this.lb_confir.Text = "label2";
            this.lb_confir.Click += new System.EventHandler(this.lb_confir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 305);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "  ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.ComboBox tx_sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Confimacao;
        private System.Windows.Forms.Label lb_confirmacao;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.MaskedTextBox tx_confSenha;
        private System.Windows.Forms.MaskedTextBox tx_senha;
        private System.Windows.Forms.Label lb_confir;
    }
}

