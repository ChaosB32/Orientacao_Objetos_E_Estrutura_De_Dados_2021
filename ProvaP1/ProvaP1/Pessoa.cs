using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Pessoa:IItemRelatorio
    {
        public Pessoa(string nome,long id, Endereco endereco, string email)
        {
            this.nome = nome;
            this.id = id;
            this.endereco = endereco;
            this.email = email;
        }
        public string nome { get; private set; }
        public long id { get; private set; }
        public Endereco endereco { get; private set; }
        public string email { get; private set; }

        public virtual void MostrarDescricao()
        {
            Console.WriteLine(" "+nome+" "+id+ " " + endereco+ " " + email);
        }
    }
}
