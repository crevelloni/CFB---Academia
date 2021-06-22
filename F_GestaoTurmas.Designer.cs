
namespace CFB___Academia
{
    partial class F_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_Horarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Turmas = new System.Windows.Forms.DataGridView();
            this.btn_NovaTurma = new System.Windows.Forms.Button();
            this.btn_SalvarEdicoes = new System.Windows.Forms.Button();
            this.btn_ExcluirTurma = new System.Windows.Forms.Button();
            this.btn_ImprimirTurma = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_DescTurmas = new System.Windows.Forms.TextBox();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nud_maxAlunos
            // 
            this.nud_maxAlunos.Location = new System.Drawing.Point(388, 128);
            this.nud_maxAlunos.Name = "nud_maxAlunos";
            this.nud_maxAlunos.Size = new System.Drawing.Size(119, 20);
            this.nud_maxAlunos.TabIndex = 3;
            this.nud_maxAlunos.ValueChanged += new System.EventHandler(this.nud_maxAlunos_ValueChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(514, 127);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(120, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_Horarios
            // 
            this.cb_Horarios.FormattingEnabled = true;
            this.cb_Horarios.Location = new System.Drawing.Point(388, 180);
            this.cb_Horarios.Name = "cb_Horarios";
            this.cb_Horarios.Size = new System.Drawing.Size(247, 21);
            this.cb_Horarios.TabIndex = 5;
            this.cb_Horarios.SelectedIndexChanged += new System.EventHandler(this.cb_Horarios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horário";
            // 
            // dgv_Turmas
            // 
            this.dgv_Turmas.AllowUserToAddRows = false;
            this.dgv_Turmas.AllowUserToDeleteRows = false;
            this.dgv_Turmas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Turmas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turmas.EnableHeadersVisualStyles = false;
            this.dgv_Turmas.Location = new System.Drawing.Point(12, 9);
            this.dgv_Turmas.MultiSelect = false;
            this.dgv_Turmas.Name = "dgv_Turmas";
            this.dgv_Turmas.ReadOnly = true;
            this.dgv_Turmas.RowHeadersVisible = false;
            this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turmas.Size = new System.Drawing.Size(370, 387);
            this.dgv_Turmas.TabIndex = 8;
            this.dgv_Turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Turmas_CellContentClick);
            this.dgv_Turmas.SelectionChanged += new System.EventHandler(this.dgv_Turmas_SelectionChanged);
            // 
            // btn_NovaTurma
            // 
            this.btn_NovaTurma.Location = new System.Drawing.Point(12, 9);
            this.btn_NovaTurma.Name = "btn_NovaTurma";
            this.btn_NovaTurma.Size = new System.Drawing.Size(123, 23);
            this.btn_NovaTurma.TabIndex = 9;
            this.btn_NovaTurma.Text = "Nova Turma";
            this.btn_NovaTurma.UseVisualStyleBackColor = true;
            this.btn_NovaTurma.Click += new System.EventHandler(this.btn_NovaTurma_Click);
            // 
            // btn_SalvarEdicoes
            // 
            this.btn_SalvarEdicoes.Location = new System.Drawing.Point(141, 9);
            this.btn_SalvarEdicoes.Name = "btn_SalvarEdicoes";
            this.btn_SalvarEdicoes.Size = new System.Drawing.Size(132, 23);
            this.btn_SalvarEdicoes.TabIndex = 10;
            this.btn_SalvarEdicoes.Text = "Salvar Edições";
            this.btn_SalvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_SalvarEdicoes.Click += new System.EventHandler(this.btn_SalvarEdicoes_Click);
            // 
            // btn_ExcluirTurma
            // 
            this.btn_ExcluirTurma.Location = new System.Drawing.Point(279, 9);
            this.btn_ExcluirTurma.Name = "btn_ExcluirTurma";
            this.btn_ExcluirTurma.Size = new System.Drawing.Size(129, 23);
            this.btn_ExcluirTurma.TabIndex = 11;
            this.btn_ExcluirTurma.Text = "Excluir Turma";
            this.btn_ExcluirTurma.UseVisualStyleBackColor = true;
            this.btn_ExcluirTurma.Click += new System.EventHandler(this.btn_ExcluirTurma_Click);
            // 
            // btn_ImprimirTurma
            // 
            this.btn_ImprimirTurma.Location = new System.Drawing.Point(414, 9);
            this.btn_ImprimirTurma.Name = "btn_ImprimirTurma";
            this.btn_ImprimirTurma.Size = new System.Drawing.Size(129, 23);
            this.btn_ImprimirTurma.TabIndex = 12;
            this.btn_ImprimirTurma.Text = "Imprimir Turma";
            this.btn_ImprimirTurma.UseVisualStyleBackColor = true;
            this.btn_ImprimirTurma.Click += new System.EventHandler(this.btn_ImprimirTurma_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(549, 9);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(89, 23);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_NovaTurma);
            this.panel1.Controls.Add(this.btn_SalvarEdicoes);
            this.panel1.Controls.Add(this.btn_ExcluirTurma);
            this.panel1.Controls.Add(this.btn_ImprimirTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 41);
            this.panel1.TabIndex = 14;
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(388, 73);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(246, 21);
            this.cb_professor.TabIndex = 2;
            this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.cb_professor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome Turma";
            // 
            // tb_DescTurmas
            // 
            this.tb_DescTurmas.Location = new System.Drawing.Point(388, 25);
            this.tb_DescTurmas.Name = "tb_DescTurmas";
            this.tb_DescTurmas.Size = new System.Drawing.Size(246, 20);
            this.tb_DescTurmas.TabIndex = 1;
            this.tb_DescTurmas.TextChanged += new System.EventHandler(this.tb_DescTurmas_TextChanged);
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(388, 249);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(100, 20);
            this.tb_vagas.TabIndex = 14;
            this.tb_vagas.TabStop = false;
            this.tb_vagas.TextChanged += new System.EventHandler(this.tb_vagas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vagas";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.tb_DescTurmas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Turmas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Horarios);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.nud_maxAlunos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_maxAlunos;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_Horarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Turmas;
        private System.Windows.Forms.Button btn_NovaTurma;
        private System.Windows.Forms.Button btn_SalvarEdicoes;
        private System.Windows.Forms.Button btn_ExcluirTurma;
        private System.Windows.Forms.Button btn_ImprimirTurma;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_DescTurmas;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.Label label6;
    }
}