
namespace Calculadora2
{
    public partial class Form1 : Form
    {
        int n;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Selector_ValueChanged(object sender, EventArgs e)
        { 

        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matris1[i, j].Value = r.Next(10) + 1;
                    Matris2[i, j].Value = r.Next(10) + 1;
                }
            }
        }

        private void Btn_llenar_Click(object sender, EventArgs e)
        {
         
        }

        private void Btn_suma_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrisResultado[i, j].Value = int.Parse(Matris1[i, j].Value.ToString())
                        + int.Parse(Matris2[i, j].Value.ToString());
                }
            }
        }

        private void Btn_resta_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrisResultado[i, j].Value = int.Parse(Matris1[i, j].Value.ToString())
                        - int.Parse(Matris2[i, j].Value.ToString());
                }
            }
        }

        private void Btn_multiplicacion_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrisResultado[i, j].Value = int.Parse(Matris1[i, j].Value.ToString())
                        * int.Parse(Matris2[i, j].Value.ToString());
                }
            }
        }

        private void Btn_divicion_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrisResultado[i, j].Value = int.Parse(Matris1[i, j].Value.ToString())
                        / int.Parse(Matris2[i, j].Value.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Llenar_Click_1(object sender, EventArgs e)
        {
            n = (int)Selector.Value;
            Matris1.Columns.Clear();
            Matris2.Columns.Clear();
            MatrisResultado.Columns.Clear();


            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna1.Name = (i + 1).ToString();
                columna1.Width = 24;
                Matris1.Columns.Add(columna1);

                DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna2.Name = (i + 1).ToString();
                columna2.Width = 24;
                Matris2.Columns.Add(columna2);

                //DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                //columna3.Name = (i + 1).ToString();
                //columna3.Width = 24;
                //MatrisResultado.Columns.Add(columna3);
            }

            Matris1.Rows.Add(n);
            Matris2.Rows.Add(n);
            //MatrisResultado.Rows.Add(n);
        }

        private void MatrisResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Llenar_resultado_Click(object sender, EventArgs e)
        {
            n = (int)Selector.Value;
            MatrisResultado.Columns.Clear();

            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna3.Name = (i + 1).ToString();
                columna3.Width = 24;
                MatrisResultado.Columns.Add(columna3);
            }
            MatrisResultado.Rows.Add(n);
        }
    }
}