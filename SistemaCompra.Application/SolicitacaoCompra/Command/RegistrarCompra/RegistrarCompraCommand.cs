using MediatR;
using System;
using System.Collections.Generic;


namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public IList<Item> Itens { get; set; }
        public string UsuarioSolicitante { get; set; }
        public string NomeFornecedor { get; set; }
        public int CondicaoPagamento { get; set; }
    }

    public class Item
    {
        public Guid IdProduto { get; set; }
        public int Qtde { get; set; }
    }
}
