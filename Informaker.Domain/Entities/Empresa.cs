using System.Collections.Generic;

namespace Informaker.Domain.Entities
{
    public class Empresa : EntityBase
    {
        
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string UF { get; set; }
        public List<EmpresaFornecedores> EmpresaFornecedores { get; set; }
    }
}