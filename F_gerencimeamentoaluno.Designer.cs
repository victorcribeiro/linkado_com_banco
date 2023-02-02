namespace ProjetoEscola1
{
    partial class F_gerencimeamentoaluno
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
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(88, 183);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(250, 20);
            this.tb_cpf.TabIndex = 53;
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(88, 118);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(250, 20);
            this.tb_contato.TabIndex = 52;
            this.tb_contato.TextChanged += new System.EventHandler(this.tb_contato_TextChanged);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(85, 43);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(253, 20);
            this.tb_nome.TabIndex = 51;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(86, 355);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 50;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(644, 401);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 49;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(512, 401);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 48;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(368, 401);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 47;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(229, 401);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 46;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(85, 401);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 45;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(85, 253);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "A: Ativo  B:Bloqueado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome";
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.AllowUserToAddRows = false;
            this.dgv_aluno.AllowUserToDeleteRows = false;
            this.dgv_aluno.AllowUserToResizeColumns = false;
            this.dgv_aluno.AllowUserToResizeRows = false;
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_aluno.EnableHeadersVisualStyles = false;
            this.dgv_aluno.Location = new System.Drawing.Point(411, 43);
            this.dgv_aluno.MultiSelect = false;
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.ReadOnly = true;
            this.dgv_aluno.RowHeadersVisible = false;
            this.dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aluno.Size = new System.Drawing.Size(319, 287);
            this.dgv_aluno.TabIndex = 54;
            this.dgv_aluno.SelectionChanged += new System.EventHandler(this.dgv_aluno_SelectionChanged_1);
            // 
            // F_gerencimeamentoaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_gerencimeamentoaluno";
            this.Text = "F_gerencimeamentoaluno";
            this.Load += new System.EventHandler(this.F_gerencimeamentoaluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_aluno;
    }
}