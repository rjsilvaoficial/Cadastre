using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controle
{
    public class ctlContato
    {

        public void IncluirContato(long cpf, string nome, long telefone)
        {
            metodosDal _metodosDal = new metodosDal();
            mdlContato _mdlContato = new mdlContato();

            _mdlContato.cpf = cpf;
            _mdlContato.nome = nome;
            _mdlContato.telefone = telefone;

            _metodosDal.CadastrarDb(_mdlContato.cpf, _mdlContato.nome, _mdlContato.telefone);
        }

        public void PesquisarContato(long cpf, out mdlContato _dbContato)
        {
            metodosDal _metodosDal = new metodosDal();
            mdlContato _mdlContato = new mdlContato();

            _mdlContato.cpf = cpf;

            _metodosDal.ConsultarDb(_mdlContato.cpf, out mdlContato _objBusca);

            _dbContato = _objBusca;
        }

        public void AtualizarContato(long cpf, string nome,long telefone)
        {
            metodosDal _metodosDal = new metodosDal();
            mdlContato _mdlContato = new mdlContato();

            _mdlContato.cpf = cpf;
            _mdlContato.nome = nome;
            _mdlContato.telefone = telefone;

            _metodosDal.AtualizarDb(_mdlContato.cpf, _mdlContato.nome,_mdlContato.telefone);

        }

        public void DeletarContato(long cpf)
        {
            metodosDal _metodosDal = new metodosDal();
            mdlContato _mdlContato = new mdlContato();

            _mdlContato.cpf = cpf;

            _metodosDal.DeletarDb(_mdlContato.cpf);

        }
    }
}
