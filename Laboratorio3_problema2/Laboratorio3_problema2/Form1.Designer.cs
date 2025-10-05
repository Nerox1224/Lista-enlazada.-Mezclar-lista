namespace Laboratorio3_problema2
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
            Tabla = new DataGridView();
            Numeros = new DataGridViewTextBoxColumn();
            Pares = new DataGridViewTextBoxColumn();
            Impares = new DataGridViewTextBoxColumn();
            txtnum = new TextBox();
            label1 = new Label();
            Add = new Button();
            label2 = new Label();
            Imprimir = new Button();
            ImprimirListas = new Button();
            SepararListas = new Button();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Numeros, Pares, Impares });
            Tabla.Location = new Point(200, 9);
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            Tabla.Size = new Size(302, 217);
            Tabla.TabIndex = 0;
            Tabla.TabStop = false;
            // 
            // Numeros
            // 
            Numeros.Frozen = true;
            Numeros.HeaderText = "Números";
            Numeros.Name = "Numeros";
            Numeros.ReadOnly = true;
            // 
            // Pares
            // 
            Pares.Frozen = true;
            Pares.HeaderText = "Pares";
            Pares.Name = "Pares";
            Pares.ReadOnly = true;
            // 
            // Impares
            // 
            Impares.Frozen = true;
            Impares.HeaderText = "Impares";
            Impares.Name = "Impares";
            Impares.ReadOnly = true;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(78, 31);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(100, 23);
            txtnum.TabIndex = 1;
            txtnum.KeyPress += txtnum_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 2;
            label1.Text = "Números";
            // 
            // Add
            // 
            Add.Location = new Point(23, 72);
            Add.Name = "Add";
            Add.Size = new Size(150, 29);
            Add.TabIndex = 3;
            Add.Text = "Insertar";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(15, 34);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Número: ";
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(23, 107);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(150, 29);
            Imprimir.TabIndex = 5;
            Imprimir.TabStop = false;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += Imprimir_Click;
            // 
            // ImprimirListas
            // 
            ImprimirListas.Location = new Point(23, 177);
            ImprimirListas.Name = "ImprimirListas";
            ImprimirListas.Size = new Size(150, 29);
            ImprimirListas.TabIndex = 6;
            ImprimirListas.TabStop = false;
            ImprimirListas.Text = "Imprimir listas";
            ImprimirListas.UseVisualStyleBackColor = true;
            ImprimirListas.Click += ImprimirListas_Click;
            // 
            // SepararListas
            // 
            SepararListas.Location = new Point(23, 142);
            SepararListas.Name = "SepararListas";
            SepararListas.Size = new Size(150, 29);
            SepararListas.TabIndex = 7;
            SepararListas.TabStop = false;
            SepararListas.Text = "Separar listas";
            SepararListas.UseVisualStyleBackColor = true;
            SepararListas.Click += SepararListas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 238);
            Controls.Add(SepararListas);
            Controls.Add(ImprimirListas);
            Controls.Add(Imprimir);
            Controls.Add(label2);
            Controls.Add(Add);
            Controls.Add(label1);
            Controls.Add(txtnum);
            Controls.Add(Tabla);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Tabla;
        private TextBox txtnum;
        private Label label1;
        private Button Add;
        private Label label2;
        private Button Imprimir;
        private DataGridViewTextBoxColumn Numeros;
        private DataGridViewTextBoxColumn Pares;
        private DataGridViewTextBoxColumn Impares;
        private Button ImprimirListas;
        private Button SepararListas;
    }
}
