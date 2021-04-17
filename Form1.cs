using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cursos
{
    public partial class Form1 : Form
    {

        struct curso
        {
            public int codigocurso;
            public string cursoo;
            public double mensalidade;

        }

        struct alunos
        {
            public int codigoaluno;
            public string nome;
            public int telefone;
            public string sexo;
            public int nascimento;
            public string cursos;

        }

        //configuração de vetores....

        curso[] vetcurso = new curso[5];
        alunos[] vetaluno = new alunos[5];

        //sistema de loop para vetores do curso
        int a = 0;
        int cod_a = 1;

        //sistema de loop para vetores dos alunos

        int b = 0;
        int cod_b = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_nomecurso.Text == "" || tb_mensalidade.Text == "")
            {

                MessageBox.Show("Campos Vazios...Preencha todos os campos e tente novamente");
            }
            else
            {

                // pegar valores dos layouts...
                vetcurso[a].codigocurso = Convert.ToInt32(lb_codigocurso.Text);
                vetcurso[a].cursoo = tb_nomecurso.Text;
                vetcurso[a].mensalidade = Convert.ToDouble(tb_mensalidade.Text);
                cod_a++;
                lb_codigocurso.Text = Convert.ToString(cod_a);


                // limpar os layouts....

                tb_nomecurso.Clear();
                tb_mensalidade.Clear();
                tb_nomecurso.Focus();

                //valores  no grid
                dataGridView1.Rows.Add(vetcurso[a].codigocurso, vetcurso[a].cursoo, vetcurso[a].mensalidade);

                //configuração da combo box dos alunos....
                cb_curso_aluno.Items.Add(vetcurso[a].cursoo);

                //loop do vetor, configuraçãoo
                a++;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (tb_nome_aluno.Text == "" || tb_nascimento_aluno.Text == "" || cb_sexo_aluno.Text == "" || telefone_aluno.Text == "" || cb_curso_aluno.Text == "")
            {
                MessageBox.Show("Campo Vazio, Preencha Todos os Campos E tente Novamente");
            }
            else
            {

                //pegar os valores dos layouts....
                vetaluno[b].codigoaluno = Convert.ToInt32(lb_codigo_aluno.Text);
                vetaluno[b].nome = tb_nome_aluno.Text;
                vetaluno[b].nascimento = Convert.ToInt32(tb_nascimento_aluno.Text);
                vetaluno[b].sexo = cb_sexo_aluno.Text;
                vetaluno[b].telefone = Convert.ToInt32(telefone_aluno.Text);
                vetaluno[b].cursos = cb_curso_aluno.Text;
                cod_b++;
                lb_codigo_aluno.Text = Convert.ToString(cod_b);

                // limpar os layouts....
                tb_nome_aluno.Clear();
                tb_nascimento_aluno.Clear();
                cb_sexo_aluno.Text = "";
                telefone_aluno.Clear();
                cb_curso_aluno.Text = "";
                tb_nome_aluno.Focus();

                //valores o Grid
                Grid2.Rows.Add(vetaluno[b].codigoaluno, vetaluno[b].nome, vetaluno[b].nascimento, vetaluno[b].sexo, vetaluno[b].telefone, vetaluno[b].cursos);

                //loop do vetor e configuração...
                b++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_curso.Checked == true)
            {
                lb_pesquisa.Text = "Pesquisar Aluno Por Curso";
            }
        }
        
        private void rb_sexo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sexo.Checked == true)
            {
                lb_pesquisa.Text = "Pesquisar Aluno Por Sexo";
            }
        }

        private void rb_mensalidade_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mensalidade.Checked == true)
            {
                lb_pesquisa.Text = "Pesquisar Curso Por Mensalidade";
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (rb_curso.Checked == true)
            {
                Grid_pesquisa.Columns.Clear();
                Grid_pesquisa.Rows.Clear();
                Grid_pesquisa.Columns.Add("aluno", "Aluno");
                Grid_pesquisa.Columns.Add("curso", "Curso");
                Grid_pesquisa.Columns.Add("codigo", "Codigo");
                Grid_pesquisa.Columns.Add("telefone", "Telefone");
                

                int contador = 0;
                int operador = 0;
                while (contador < 5)
                {
                    if (tb_pesquisa.Text == vetaluno[contador].cursos)
                    {
                        operador = contador;
                        Grid_pesquisa.Rows.Add(vetaluno[contador].nome,vetaluno[contador].cursos,vetaluno[contador].codigoaluno,vetaluno[contador].telefone);
                    }

                    contador++;

                }

                



            }

            if (rb_sexo.Checked == true)
            {
                Grid_pesquisa.Columns.Clear();
                Grid_pesquisa.Rows.Clear();
                Grid_pesquisa.Columns.Add("aluno", "Aluno"); 
                Grid_pesquisa.Columns.Add("sexo", "Sexo");
                Grid_pesquisa.Columns.Add("curso", "Curso");
                Grid_pesquisa.Columns.Add("codigo", "Codigo");
                Grid_pesquisa.Columns.Add("telefone", "Telefone");

                int contador = 0;
                int operador = 0;
                while (contador < 5)
                {
                    if (tb_pesquisa.Text == vetaluno[contador].sexo)
                    {

                        operador = contador;
                        Grid_pesquisa.Rows.Add(vetaluno[contador].nome,vetaluno[contador].sexo,vetaluno[contador].cursos,vetaluno[contador].codigoaluno,vetaluno[contador].telefone);

                    }
                    contador++;
                }
            }

            if (rb_mensalidade.Checked == true)
            {
                Grid_pesquisa.Columns.Clear();
                Grid_pesquisa.Rows.Clear();
                Grid_pesquisa.Columns.Add("curso", "Curso"); 
                Grid_pesquisa.Columns.Add("mensalidade", "Mensalidade");
                int contador = 0;
                int operador = 0;
                double mensalidade = Convert.ToDouble(tb_pesquisa.Text);
                while (contador < 5)
                {
                    if (mensalidade == vetcurso[contador].mensalidade)
                    {
                        operador = contador;
                        Grid_pesquisa.Rows.Add(vetcurso[contador].cursoo,vetcurso[contador].mensalidade);

                    }

                    contador++;





                }



            }


        }
    }
}
