using System.Collections.Generic;

namespace Informaker.Domain.Entities
{
    public class FornecedorContatos : EntityBase
    {
        public int FornecedorId { get; set; }

        public string TipoContato {get; set;}

        public string Descricao {get; set;}

        public Fornecedor Fornecedor { get; set; }
    }
}