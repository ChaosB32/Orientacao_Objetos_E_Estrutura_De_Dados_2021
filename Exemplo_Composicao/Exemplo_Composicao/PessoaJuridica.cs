using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Composicao
{
    class PessoaJuridica:Pessoa
    {
        public PessoaJuridica(string nome,string cNPJ, PorteEmpresa porte):base(nome)
        {
            CNPJ = cNPJ;
            this.porte = porte;
        }

        public string CNPJ { get; set; }
        public PorteEmpresa porte { get; set; }
    }
    enum PorteEmpresa
    {
        PequenoPorte,
        MédioPorte,
        GrandePorte
    }
}
