using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Estado
    {
       
        List<Cidade> _listacidade = new List<Cidade>();
        public void CadrastarCidade(Cidade cidade)
        {
            _listacidade.Add(cidade);
        }
        public void ImprimirCidade()
        {
            foreach (var cid in _listacidade)
            {
                Console.WriteLine(cid.Nome);
                Console.WriteLine(cid.Populacao);
            }
        }
        public Cidade LocalizarCidadeMaiorPopulacao()
        {
            
            var cid = _listacidade.OrderByDescending(C => C.Populacao);
            return (Cidade)cid;
        }
    }
}
