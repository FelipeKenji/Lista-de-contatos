using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lista_de_contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Um vetor de contatos.
        private Contato[] contatos = new Contato[1];

        //Verdinho=tipo Azul=nome
        private void Escrever(Contato contato)
        {
            StreamWriter streamWriter = new StreamWriter("Contatos.txt");
            streamWriter.WriteLine(contatos.Length + 1);
            streamWriter.WriteLine(contato.Nome);
            streamWriter.WriteLine(contato.Sobrenome);
            streamWriter.WriteLine(contato.Telefone);

            for(int x = 0; x < contatos.Length; x++)
            {
                streamWriter.WriteLine(contatos[x].Nome);
                streamWriter.WriteLine(contatos[x].Sobrenome);
                streamWriter.WriteLine(contatos[x].Telefone);
            }

            streamWriter.Close();
        }

        private void Ler()
        {
            StreamReader streamReader = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(streamReader.ReadLine())];

            for(int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = streamReader.ReadLine();
                contatos[x].Sobrenome = streamReader.ReadLine();
                contatos[x].Telefone = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        //Atualiza a tela do programa com os contatos.

        private void Exibir()
        {
            // Limpa a lista de contatos.
            ListBoxContatos.Items.Clear();
            for(int x = 0; x < contatos.Length; x++)
            {
                ListBoxContatos.Items.Add(contatos[x].ToString());
            }
        }

        private void LimparFormulario()
        {
            Nome.Text = String.Empty;
            Sobrenome.Text = String.Empty;
            Telefone.Text = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncontato_Click(object sender, EventArgs e)
        {
            //Cria um objeto da classe contato
            Contato contato = new Contato();
            contato.Nome = Nome.Text;
            contato.Sobrenome = Sobrenome.Text;
            contato.Telefone= Telefone.Text;

            //ListBoxContatos.Items.Add(contato.ToString());
            Escrever(contato);
            Ler();
            Exibir();
            LimparFormulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }
    }
}
