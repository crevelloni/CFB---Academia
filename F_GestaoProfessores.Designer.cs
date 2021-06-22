
namespace CFB___Academia
{
    partial class F_GestaoProfessores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_novoProfessor = new System.Windows.Forms.Button();
            this.btn_salvarProfessor = new System.Windows.Forms.Button();
            this.btn_excluirProfessor = new System.Windows.Forms.Button();
            this.dgv_Professores = new System.Windows.Forms.DataGridView();
            this.tb_idProfessor = new System.Windows.Forms.TextBox();
            this.tb_NomeProfessor = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Professores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_novoProfessor);
            this.panel1.Controls.Add(this.btn_salvarProfessor);
            this.panel1.Controls.Add(this.btn_excluirProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 45);
            this.panel1.TabIndex = 4;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(324, 11);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 23);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_novoProfessor
            // 
            this.btn_novoProfessor.Location = new System.Drawing.Point(3, 11);
            this.btn_novoProfessor.Name = "btn_novoProfessor";
            this.btn_novoProfessor.Size = new System.Drawing.Size(99, 23);
            this.btn_novoProfessor.TabIndex = 4;
            this.btn_novoProfessor.Text = "Novo Professor";
            this.btn_novoProfessor.UseVisualStyleBackColor = true;
            this.btn_novoProfessor.Click += new System.EventHandler(this.btn_novoProfessor_Click);
            // 
            // btn_salvarProfessor
            // 
            this.btn_salvarProfessor.Location = new System.Drawing.Point(108, 11);
            this.btn_salvarProfessor.Name = "btn_salvarProfessor";
            this.btn_salvarProfessor.Size = new System.Drawing.Size(102, 23);
            this.btn_salvarProfessor.TabIndex = 5;
            this.btn_salvarProfessor.Text = "Salvar Professor";
            this.btn_salvarProfessor.UseVisualStyleBackColor = true;
            this.btn_salvarProfessor.Click += new System.EventHandler(this.btn_salvarProfessor_Click);
            // 
            // btn_excluirProfessor
            // 
            this.btn_excluirProfessor.Location = new System.Drawing.Point(216, 11);
            this.btn_excluirProfessor.Name = "btn_excluirProfessor";
            this.btn_excluirProfessor.Size = new System.Drawing.Size(102, 23);
            this.btn_excluirProfessor.TabIndex = 6;
            this.btn_excluirProfessor.Text = "Excluir Professor";
            this.btn_excluirProfessor.UseVisualStyleBackColor = true;
            this.btn_excluirProfessor.Click += new System.EventHandler(this.btn_excluirProfessor_Click);
            // 
            // dgv_Professores
            // 
            this.dgv_Professores.AllowUserToAddRows = false;
            this.dgv_Professores.AllowUserToDeleteRows = false;
            this.dgv_Professores.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Professores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Professores.EnableHeadersVisualStyles = false;
            this.dgv_Professores.Location = new System.Drawing.Point(12, 83);
            this.dgv_Professores.MultiSelect = false;
            this.dgv_Professores.Name = "dgv_Professores";
            this.dgv_Professores.ReadOnly = true;
            this.dgv_Professores.RowHeadersVisible = false;
            this.dgv_Professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Professores.Size = new System.Drawing.Size(404, 280);
            this.dgv_Professores.TabIndex = 5;
            this.dgv_Professores.SelectionChanged += new System.EventHandler(this.dgv_Professores_SelectionChanged);
            // 
            // tb_idProfessor
            // 
            this.tb_idProfessor.Enabled = false;
            this.tb_idProfessor.Location = new System.Drawing.Point(12, 48);
            this.tb_idProfessor.Name = "tb_idProfessor";
            this.tb_idProfessor.Size = new System.Drawing.Size(49, 20);
            this.tb_idProfessor.TabIndex = 8;
            // 
            // tb_NomeProfessor
            // 
            this.tb_NomeProfessor.Location = new System.Drawing.Point(67, 48);
            this.tb_NomeProfessor.Name = "tb_NomeProfessor";
            this.tb_NomeProfessor.Size = new System.Drawing.Size(198, 20);
            this.tb_NomeProfessor.TabIndex = 9;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(271, 48);
            this.mtb_telefone.Mask = "(99) 99999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(145, 20);
            this.mtb_telefone.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefone";
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_NomeProfessor);
            this.Controls.Add(this.tb_idProfessor);
            this.Controls.Add(this.dgv_Professores);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_novoProfessor;
        private System.Windows.Forms.Button btn_salvarProfessor;
        private System.Windows.Forms.Button btn_excluirProfessor;
        private System.Windows.Forms.DataGridView dgv_Professores;
        private System.Windows.Forms.TextBox tb_idProfessor;
        private System.Windows.Forms.TextBox tb_NomeProfessor;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}