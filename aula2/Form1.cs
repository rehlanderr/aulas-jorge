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

        private void subtra��o(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 subtra��o = valor1 - valor2;
            //mostrar o alerta do resultado
            //Converter a subtra��o de inteiro para texto subtra��o.ToString()
            MessageBox.Show("Resultado: " + subtra��o.ToString());
        }


        private void divis�o(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 divis�o = valor1 / valor2;
            //mostrar o alerta do resultado
            //Converter a subtra��o de inteiro para texto subtra��o.ToString()
            MessageBox.Show("Resultado: " + divis�o.ToString());

        }

        private void multiplica��o(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox2.Text);
            Int32 valor2 = Convert.ToInt32(textBox3.Text);
            Int32 multiplica��o = valor1 * valor2;
            //mostrar o alerta do resultado
            //Converter a subtra��o de inteiro para texto subtra��o.ToString()
            MessageBox.Show("Resultado: " + multiplica��o.ToString());

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
            //matematica fun��o POW
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
