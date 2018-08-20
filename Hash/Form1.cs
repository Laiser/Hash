using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hash
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridHash.ColumnCount = 2;
            dataGridHash.RowCount = 21;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            if (tbValor.Text == "")
            {
                MessageBox.Show("Informe um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbHash.Text == "")
            {
                MessageBox.Show("Escolha um métod de hash!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                dataGridHash.Columns[0].Width = 50;
                dataGridHash.Columns[1].Width = 130;

                dataGridHash.Columns[0].Name = "Posição";
                dataGridHash.Columns[1].Name = "Matricula";

                for (int i = 0; i < dataGridHash.RowCount; i++)
                {
                    dataGridHash.Rows[i].Cells[0].Value = i;
                }
            }

            verificaPreenchimento();

        }


        public void metodoMidSquare()
        {
            string x = (Math.Pow(Convert.ToInt32(tbValor.Text), 2)).ToString();
            int[] vetorMatricula = new int[x.Length];
            var lista = new List<Int32>();
            string soma = "";

            for (int i = 0; i < x.Length; i++)
            {
                Int32 num = 0;
                if (Int32.TryParse(x.Substring(i, 1), out num))
                    lista.Add(num);
                listBox1.Items.Add("posicao:" + i + "==>" + lista[i]);
                vetorMatricula[i] = lista[i];

            }


            int meio = (vetorMatricula.Length / 2) - 1;

            soma += vetorMatricula[meio].ToString() + vetorMatricula[meio + 1].ToString();

            int resultado = (Convert.ToInt32(soma)) % 21;

            MessageBox.Show("O valor : " + tbValor.Text + " será armazanado na posição :" + Convert.ToString(resultado) + " , ou na próxima posição vazia", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            testaColisao(resultado);

        }


        public void metodoFolding()
        {

            var lista = new List<Int32>();
            var x = tbValor.Text;
            int[] vetorMatricula = new int[x.Length];

            int soma = 0;
            if (tbValor.Text.Length != 0)
            {

                for (int i = 0; i < x.Length; i++)
                {
                    Int32 num = 0;
                    if (Int32.TryParse(x.Substring(i, 1), out num))
                        lista.Add(num);
                    listBox1.Items.Add("posicao:" + i + "==>" + lista[i]);
                    vetorMatricula[i] = lista[i];

                }


            }

            for (int i = 0; i <= (vetorMatricula.Length - 1);)
            {
                if (i == (vetorMatricula.Length - 1))
                {
                    soma += vetorMatricula[i];
                    i = i + 2;
                }
                else
                {
                    string valor = vetorMatricula[i].ToString() + vetorMatricula[i + 1].ToString();
                    soma += Convert.ToInt32(valor);

                    i = i + 2;
                }

            }


            MessageBox.Show("O valor : " + tbValor.Text + " será armazanado na posição :" + Convert.ToString(soma % x.Length) + " , ou na próxima posição vazia", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            int resultado = soma % x.Length;

            testaColisao(resultado);

        }


        public void verificaPreenchimento()
        {
            int contador = 0;
            for (int i = 0; i < dataGridHash.RowCount; i++)
            {
                if (dataGridHash.Rows[i].Cells[1].Value != null)
                {
                    contador = contador + 1;

                    if (contador == 21)
                    {
                        MessageBox.Show("Todas posições já estão preenchidas! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        return;
                    }

                }
            }

            if (cbHash.SelectedIndex == 1)
            {
                metodoFolding();
            }

            if (cbHash.SelectedIndex == 2)
            {
                metodoMidSquare();
            }

        }

        public void testaColisao(int resultado)
        {
            if (dataGridHash.Rows[resultado].Cells[1].Value == null)
            {
                dataGridHash.Rows[resultado].Cells[1].Value = tbValor.Text;
            }
            else
            {
                int pontoDePartida = resultado;

                for (int i = pontoDePartida + 1; i < dataGridHash.RowCount;)
                {
                    if (dataGridHash.Rows[i].Cells[1].Value == null)
                    {
                        dataGridHash.Rows[i].Cells[1].Value = tbValor.Text;
                        return;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == 21)
                    {
                        for (i = 0; i < pontoDePartida; i++)
                        {
                            if (dataGridHash.Rows[i].Cells[1].Value == null)
                            {
                                dataGridHash.Rows[i].Cells[1].Value = tbValor.Text;
                                return;
                            }

                        }
                    }
                }

            }
        }

        private void cbHash_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridHash.RowCount; i++)
            {
                dataGridHash.Rows[i].DataGridView.Columns.Clear();
            }

            dataGridHash.ColumnCount = 2;
            dataGridHash.RowCount = 21;
            dataGridHash.Columns[0].Width = 50;
            dataGridHash.Columns[1].Width = 130;

            dataGridHash.Columns[0].Name = "Posição";
            dataGridHash.Columns[1].Name = "Matricula";

            for (int i = 0; i < dataGridHash.RowCount; i++)
            {
                dataGridHash.Rows[i].Cells[0].Value = i;
            }
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
