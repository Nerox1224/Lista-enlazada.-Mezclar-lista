namespace Laboratorio3_problema2
{
    public partial class Form1 : Form
    {
        Lista list = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int.TryParse(txtnum?.Text, out int numero);
            list.Insertar(new Numeros(numero));
            list.ImprimirListaDeNumeros(Tabla);
            txtnum.Clear();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            list.ImprimirListaDeNumeros(Tabla);
        }
        private void SepararListas_Click(object sender, EventArgs e)
        {
            list.SepararListas();
        }

        private void ImprimirListas_Click(object sender, EventArgs e)
        {
            list.Imprimir_Listas(Tabla);
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
