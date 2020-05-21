using System;
using System.Collections.Generic;

namespace Informaker.Domain.Entities
{
    public class Fornecedor: EntityBase
    {
        public string NomeFornecedor { get; set; }
        public string TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<EmpresaFornecedores> EmpresaFornecedores { get; set; }
        public List<FornecedorContatos> ContatosFornecedor { get; set; }
    }
}