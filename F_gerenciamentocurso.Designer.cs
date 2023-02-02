namespace ProjetoEscola1
{
    partial class F_gerenciamentocurso
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
            this.tb_area = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_area
            // 
            this.tb_area.Location = new System.Drawing.Point(85, 162);
            this.tb_area.Name = "tb_area";
            this.tb_area.Size = new System.Drawing.Size(250, 20);
            this.tb_area.TabIndex = 70;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(85, 59);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(253, 20);
            this.tb_nome.TabIndex = 68;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(86, 355);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 67;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(644, 401);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 66;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(512, 401);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 65;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(375, 401);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_limpar.TabIndex = 64;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(232, 401);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(75, 23);
            this.bt_atualizar.TabIndex = 63;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(85, 401);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 62;
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
            this.cb_status.TabIndex = 61;
            // 
            // dgv_curso
            // 
            this.dgv_curso.AllowUserToAddRows = false;
            this.dgv_curso.AllowUserToDeleteRows = false;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_curso.EnableHeadersVisualStyles = false;
            this.dgv_curso.Location = new System.Drawing.Point(388, 43);
            this.dgv_curso.MultiSelect = false;
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.ReadOnly = true;
            this.dgv_curso.RowHeadersVisible = false;
            this.dgv_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_curso.Size = new System.Drawing.Size(319, 287);
            this.dgv_curso.TabIndex = 60;
            this.dgv_curso.SelectionChanged += new System.EventHandler(this.dgv_curso_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "A: Ativo  B:Bloqueado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Área";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome";
            // 
            // F_gerenciamentocurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_area);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.dgv_curso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_gerenciamentocurso";
            this.Text = "F_gerenciamentocurso";
            this.Load += new System.EventHandler(this.F_gerenciamentocurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_area;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}