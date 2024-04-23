using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            ListBoxContatos.Items.Add(contato.ToString());
        }
    }
}
