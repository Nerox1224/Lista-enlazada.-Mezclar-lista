namespace Laboratorio_3
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Tabla = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            EDatos = new DataGridViewTextBoxColumn();
            FAlgoritmos = new DataGridViewTextBoxColumn();
            Math = new DataGridViewTextBoxColumn();
            Add_Notas = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_ED = new TextBox();
            label4 = new Label();
            txt_FA = new TextBox();
            label5 = new Label();
            txt_Math = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            DeleteNotas = new ComboBox();
            txt_Id = new TextBox();
            label8 = new Label();
            SearchNota = new Button();
            PrintNotas = new Button();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { ID, EDatos, FAlgoritmos, Math });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle1;
            Tabla.Location = new Point(12, 186);
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(26, 0, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            Tabla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            Tabla.Size = new Size(418, 228);
            Tabla.TabIndex = 0;
            Tabla.TabStop = false;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "Id alumno";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 70;
            // 
            // EDatos
            // 
            EDatos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EDatos.FillWeight = 79.18782F;
            EDatos.HeaderText = "Estructura de datos";
            EDatos.Name = "EDatos";
            EDatos.ReadOnly = true;
            // 
            // FAlgoritmos
            // 
            FAlgoritmos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FAlgoritmos.FillWeight = 79.18782F;
            FAlgoritmos.HeaderText = "Fundamento de algoritmos";
            FAlgoritmos.Name = "FAlgoritmos";
            FAlgoritmos.ReadOnly = true;
            // 
            // Math
            // 
            Math.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Math.FillWeight = 79.18782F;
            Math.HeaderText = "Matemática";
            Math.Name = "Math";
            Math.ReadOnly = true;
            // 
            // Add_Notas
            // 
            Add_Notas.Location = new Point(13, 118);
            Add_Notas.Name = "Add_Notas";
            Add_Notas.Size = new Size(160, 31);
            Add_Notas.TabIndex = 3;
            Add_Notas.Text = "Agregar notas del alumno";
            Add_Notas.UseVisualStyleBackColor = true;
            Add_Notas.Click += Add_Notas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(33, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 4;
            label2.Text = "Datos del alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 6;
            label3.Text = "Nota E.D: ";
            // 
            // txt_ED
            // 
            txt_ED.Location = new Point(82, 33);
            txt_ED.MaxLength = 2;
            txt_ED.Name = "txt_ED";
            txt_ED.Size = new Size(90, 23);
            txt_ED.TabIndex = 0;
            txt_ED.KeyPress += txt_ED_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 8;
            label4.Text = "Nota F.A: ";
            // 
            // txt_FA
            // 
            txt_FA.Location = new Point(82, 62);
            txt_FA.MaxLength = 2;
            txt_FA.Name = "txt_FA";
            txt_FA.Size = new Size(90, 23);
            txt_FA.TabIndex = 1;
            txt_FA.KeyPress += txt_ED_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 91);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 10;
            label5.Text = "Nota Math: ";
            // 
            // txt_Math
            // 
            txt_Math.Location = new Point(97, 91);
            txt_Math.MaxLength = 2;
            txt_Math.Name = "txt_Math";
            txt_Math.Size = new Size(75, 23);
            txt_Math.TabIndex = 2;
            txt_Math.KeyPress += txt_ED_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(197, 13);
            label1.Name = "label1";
            label1.Size = new Size(194, 19);
            label1.TabIndex = 11;
            label1.Text = "Nota mínima para aprobar: 05";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(183, 35);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 13;
            label6.Text = "Buscar notas: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(183, 130);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 14;
            label7.Text = "Eliminar por curso: ";
            // 
            // DeleteNotas
            // 
            DeleteNotas.FormattingEnabled = true;
            DeleteNotas.Items.AddRange(new object[] { "Estructura de datos", "Fundamento de algoritmos", "Matemática" });
            DeleteNotas.Location = new Point(185, 152);
            DeleteNotas.Name = "DeleteNotas";
            DeleteNotas.Size = new Size(234, 23);
            DeleteNotas.TabIndex = 5;
            DeleteNotas.TabStop = false;
            DeleteNotas.Text = "Cursos";
            DeleteNotas.SelectedIndexChanged += DeleteNotas_SelectedIndexChanged;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(230, 57);
            txt_Id.MaxLength = 35861;
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(161, 23);
            txt_Id.TabIndex = 15;
            txt_Id.TabStop = false;
            txt_Id.KeyPress += txt_ED_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(197, 59);
            label8.Name = "label8";
            label8.Size = new Size(28, 19);
            label8.TabIndex = 16;
            label8.Text = "Id: ";
            // 
            // SearchNota
            // 
            SearchNota.Location = new Point(210, 86);
            SearchNota.Name = "SearchNota";
            SearchNota.Size = new Size(160, 34);
            SearchNota.TabIndex = 17;
            SearchNota.TabStop = false;
            SearchNota.Text = "Buscar notas";
            SearchNota.UseVisualStyleBackColor = true;
            SearchNota.Click += SearchNota_Click;
            // 
            // PrintNotas
            // 
            PrintNotas.Location = new Point(13, 152);
            PrintNotas.Name = "PrintNotas";
            PrintNotas.Size = new Size(160, 31);
            PrintNotas.TabIndex = 18;
            PrintNotas.TabStop = false;
            PrintNotas.Text = "Imprimir notas";
            PrintNotas.UseVisualStyleBackColor = true;
            PrintNotas.Click += PrintNotas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 425);
            Controls.Add(PrintNotas);
            Controls.Add(SearchNota);
            Controls.Add(label8);
            Controls.Add(txt_Id);
            Controls.Add(DeleteNotas);
            Controls.Add(Tabla);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txt_Math);
            Controls.Add(label4);
            Controls.Add(txt_FA);
            Controls.Add(label3);
            Controls.Add(txt_ED);
            Controls.Add(label2);
            Controls.Add(Add_Notas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabla;
        private Button Add_Notas;
        private Label label2;
        private Label label3;
        private TextBox txt_ED;
        private Label label4;
        private TextBox txt_FA;
        private Label label5;
        private TextBox txt_Math;
        private Label label1;
        private Label label6;
        private Label label7;
        private ComboBox DeleteNotas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn EDatos;
        private DataGridViewTextBoxColumn FAlgoritmos;
        private DataGridViewTextBoxColumn Math;
        private TextBox txt_Id;
        private Label label8;
        private Button SearchNota;
        private Button PrintNotas;
    }
}
