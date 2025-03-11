using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace DadosEmMemoria
{
    // All the code in this file is included in all platforms.
    public class Dados : IRepositorioDeContatos
    {
        public Task AdicionarContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Task AdicionarContatoAsync(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarContato(Contato contato)
        {
            var contatoAtualizar = _contatos.FirstOrDefault(char => char.Id == contato)
                if (contatoAtualizar != null)
            throw new NotImplementedException();
        }

        public Task AtualizarContatoAsync(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Task<Contato> BuscarContatoPorId(Guid id)
        {
            var contato = _contato.FirstOrDefault(contato => contato.Id == id);
            return contato != null ? Task.FromResult(contato) : Task.FromResult(new contato());
        }

        public Task<List<Contato>> BuscarContatos(string filtro)
        {
            if (string.IsNullOrWhitSpace(filtro))
            {
                return Task.FromResult(_contatos.Where(x=> !string.IsNullOrDefault);
            }
            var contatosPorNome
        }

        public Task<List<Contato>> BuscarTodosContatos()
        {
            var contato = _contatos.FisrtOrDefault(contato => contato.Id == id);
            return contato != null;
        }

        public Task ExcluirContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirContatoAsync(Contato contato)
        {
            throw new NotImplementedException();
        }
    }
}
