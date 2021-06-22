
namespace CFB___Academia
{
    partial class F_horarios
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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.btn_salvarHoraio = new System.Windows.Forms.Button();
            this.btn_excluirHoraio = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_horario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 30);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(48, 20);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.TabStop = false;
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.AllowUserToAddRows = false;
            this.dgv_Horarios.AllowUserToDeleteRows = false;
            this.dgv_Horarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Horarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.EnableHeadersVisualStyles = false;
            this.dgv_Horarios.Location = new System.Drawing.Point(12, 56);
            this.dgv_Horarios.MultiSelect = false;
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.ReadOnly = true;
            this.dgv_Horarios.RowHeadersVisible = false;
            this.dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Horarios.Size = new System.Drawing.Size(377, 357);
            this.dgv_Horarios.TabIndex = 1;
            this.dgv_Horarios.SelectionChanged += new System.EventHandler(this.dgv_Horarios_SelectionChanged);
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Location = new System.Drawing.Point(6, 17);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(87, 23);
            this.btn_novoHorario.TabIndex = 2;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // btn_salvarHoraio
            // 
            this.btn_salvarHoraio.Location = new System.Drawing.Point(99, 17);
            this.btn_salvarHoraio.Name = "btn_salvarHoraio";
            this.btn_salvarHoraio.Size = new System.Drawing.Size(90, 23);
            this.btn_salvarHoraio.TabIndex = 3;
            this.btn_salvarHoraio.Text = "Salvar Horário";
            this.btn_salvarHoraio.UseVisualStyleBackColor = true;
            this.btn_salvarHoraio.Click += new System.EventHandler(this.btn_salvarHoraio_Click);
            // 
            // btn_excluirHoraio
            // 
            this.btn_excluirHoraio.Location = new System.Drawing.Point(195, 17);
            this.btn_excluirHoraio.Name = "btn_excluirHoraio";
            this.btn_excluirHoraio.Size = new System.Drawing.Size(95, 23);
            this.btn_excluirHoraio.TabIndex = 4;
            this.btn_excluirHoraio.Text = "Excluir Horário";
            this.btn_excluirHoraio.UseVisualStyleBackColor = true;
            this.btn_excluirHoraio.Click += new System.EventHandler(this.btn_excluirHoraio_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(296, 17);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(93, 23);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_novoHorario);
            this.groupBox1.Controls.Add(this.btn_salvarHoraio);
            this.groupBox1.Controls.Add(this.btn_excluirHoraio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Horário";
            // 
            // mtb_horario
            // 
            this.mtb_horario.Location = new System.Drawing.Point(69, 30);
            this.mtb_horario.Mask = "99:99 \\até 99:99";
            this.mtb_horario.Name = "mtb_horario";
            this.mtb_horario.Size = new System.Drawing.Size(100, 20);
            this.mtb_horario.TabIndex = 9;
            // 
            // F_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 460);
            this.Controls.Add(this.mtb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Horarios);
            this.Controls.Add(this.tb_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.DataGridView dgv_Horarios;
        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.Button btn_salvarHoraio;
        private System.Windows.Forms.Button btn_excluirHoraio;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_horario;
    }
}