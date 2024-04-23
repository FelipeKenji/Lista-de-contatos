using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_contatos
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        /*Propriedades (get e set)
        é um controle de acesso ás variáveis */
        public string Nome 
        { 
            get 
            { 
                return nome; 
            } 
            set 
            {  
                nome = value; 
            } 
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            //get = Leitura
            get
            {
                return telefone;
            }
            //set = Escrita/definição
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    //País-Cidade-Telefone
                    telefone = "00-00000-0000";
                }

                telefone = value;
            }
        }
        /*O método que tem o mesmo nome da classe e não retorna nada, é chamado
        CONSTRUTOR DA CLASSE */
        public Contato()
        {
            Nome = "Felipe";
            Sobrenome = "Kenji";
            Telefone = "11-99999-9999";
        }

        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1},", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", 
                Telefone.Substring(0,2), 
                Telefone.Substring(2,5), 
                Telefone.Substring(7,4));
            return saida;


        }

    }
}
