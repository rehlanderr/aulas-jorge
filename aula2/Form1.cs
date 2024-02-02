namespace aula2
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void soma(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 soma = valor1 + valor2;
            //mostrar o alerta do resultado
            //Converter a soma de inteiro para texto soma.ToString()
            MessageBox.Show("Resultado: " + soma.ToString());
        }

        private void subtração(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 subtração = valor1 - valor2;
            //mostrar o alerta do resultado
            //Converter a subtração de inteiro para texto subtração.ToString()
            MessageBox.Show("Resultado: " + subtração.ToString());
        }


        private void divisão(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 divisão = valor1 / valor2;
            //mostrar o alerta do resultado
            //Converter a subtração de inteiro para texto subtração.ToString()
            MessageBox.Show("Resultado: " + divisão.ToString());

        }

        private void multiplicação(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 multiplicação = valor1 * valor2;
            //mostrar o alerta do resultado
            //Converter a subtração de inteiro para texto subtração.ToString()
            MessageBox.Show("Resultado: " + multiplicação.ToString());

        }
        private void butt_Click(object sender, EventArgs e)
        {
            //convert para real
            double raiz = Convert.ToDouble(textBox2.Text);
            // Mostrar o resultado em um MessageBox
            MessageBox.Show("Resultado : " + Math.Sqrt(raiz));


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox2.Text);
            double elevado = Convert.ToDouble(textBox3.Text);
            //matematica função POW
            MessageBox.Show("potencia " + Math.Pow(valor, elevado));

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
