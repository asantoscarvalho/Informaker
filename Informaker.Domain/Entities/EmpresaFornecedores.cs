using System.Collections.Generic;

namespace Informaker.Domain.Entities
{
    public class EmpresaFornecedores : EntityBase
    {
        public int EmpresaId {get; set;}
        public Empresa Empresa { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}