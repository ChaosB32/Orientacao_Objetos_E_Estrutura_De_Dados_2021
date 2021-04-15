using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaP1
{
    class Endereco
    {
        public Endereco(long numero, string rua, Bairro bairro, Cidade cidade)
        {
            this.numero = numero;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public long numero { get; private set; }
        public string rua { get; private set; }
        public Bairro bairro { get; private set; }
        public Cidade cidade { get; private set; }
    }
}
