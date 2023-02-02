namespace ProjetoEscola1
{
    partial class F_gerenciamentoprofessor
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
            this.button5 = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.dgv_professor = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(22, 170);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(250, 20);
            this.tb_cpf.TabIndex = 36;
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(22, 105);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(250, 20);
            this.tb_contato.TabIndex = 35;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(19, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(253, 20);
            this.tb_nome.TabIndex = 34;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(20, 342);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(578, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Fechar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(446, 388);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 31;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(166, 388);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 29;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click_1);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(19, 388);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 28;
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
            this.cb_status.Location = new System.Drawing.Point(19, 240);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 27;
            // 
            // dgv_professor
            // 
            this.dgv_professor.AllowUserToAddRows = false;
            this.dgv_professor.AllowUserToDeleteRows = false;
            this.dgv_professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_professor.EnableHeadersVisualStyles = false;
            this.dgv_professor.Location = new System.Drawing.Point(322, 30);
            this.dgv_professor.MultiSelect = false;
            this.dgv_professor.Name = "dgv_professor";
            this.dgv_professor.ReadOnly = true;
            this.dgv_professor.RowHeadersVisible = false;
            this.dgv_professor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professor.Size = new System.Drawing.Size(319, 287);
            this.dgv_professor.TabIndex = 26;
            this.dgv_professor.SelectionChanged += new System.EventHandler(this.dgv_professor_SelectionChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "A: Ativo  B:Bloqueado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // F_gerenciamentoprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.dgv_professor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_gerenciamentoprofessor";
            this.Text = "F_gerenciamanetoprofessor";
            this.Load += new System.EventHandler(this.F_gerenciamentoprofessor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.DataGridView dgv_professor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}