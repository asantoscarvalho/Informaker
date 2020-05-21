using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Informaker.Domain.Entities;

namespace Informaker.Domain.Interfaces.Repositories
{
    public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
    {
         Task<Fornecedor[]> BuscarPorNome(string nome);

         Task<Fornecedor> BuscarPorCpfCnpj(string CpfCnpj);
         Task<Fornecedor[]> BuscarPorDataCadastro(DateTime DataInicial,DateTime DataFinal);

         Task<Fornecedor> GetById(int id);

    }
}