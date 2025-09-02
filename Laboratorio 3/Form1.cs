namespace Laboratorio_3
{
    public partial class Form1 : Form
    {
        Lista list = new Lista();
        public Form1()
        {
            InitializeComponent();
            list.agregar(1, new Cursos(1, 16, 0));
            list.agregar(2, new Cursos(4, 16, 4));
            list.agregar(3, new Cursos(2, 1, 20));
            list.agregar(4, new Cursos(16, 3, 20));
            list.agregar(5, new Cursos(20, 16, 20));
            list.agregar(6, new Cursos(19, 16, 20));
            list.agregar(7, new Cursos(3, 1, 20));
            list.agregar(8, new Cursos(1, 16, 3));
            list.agregar(9, new Cursos(0, 2, 2));
            list.agregar(10, new Cursos(14, 16, 3));
            list.Imprimir(Tabla);
        }

        private void Add_Notas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ED.Text) || string.IsNullOrWhiteSpace(txt_FA.Text) || string.IsNullOrWhiteSpace(txt_Math.Text)) { MessageBox.Show("Rellene todos los campos"); return; }
            int id = Tabla.Rows.Count + 1;
            list.agregar(id, new Cursos(Convert.ToInt32(txt_ED.Text), Convert.ToInt32(txt_FA.Text), Convert.ToInt32(txt_Math.Text)));
            list.Imprimir(Tabla);
            txt_ED.Clear();
            txt_FA.Clear();
            txt_Math.Clear();
        }

        private void txt_ED_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchNota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Id.Text)) { MessageBox.Show("Ingrese el id del alumno"); return; }
            list.Buscar(Convert.ToInt32(txt_Id.Text), Tabla);
            txt_Id.Clear();
        }

        private void DeleteNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selec = DeleteNotas.SelectedItem;
            string selection = selec.ToString();
            switch (selection)
            {
                case "Estructura de datos":
                    list.Eliminar_Nota1();
                    list.Imprimir(Tabla);
                    break;
                case "Fundamento de algoritmos":
                    list.Eliminar_Nota2();
                    list.Imprimir(Tabla);
                    break;
                case "Matemática":
                    list.Eliminar_Nota3();
                    list.Imprimir(Tabla);
                    break;
                default:
                    MessageBox.Show("Elija una opción");
                    break;
            }
        }

        private void PrintNotas_Click(object sender, EventArgs e)
        {
            list.Imprimir(Tabla);
            Tabla.BackgroundColor = Color.Gray;
        }
    }
}
