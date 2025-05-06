using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Client> listClients = new List<Client>();

        //Cria o Iterator
        public ConcreteIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Conta os itens
        public int Count
        {
            get { return listClients.Count; }
        }

        //Adiciona itens na coleção
        public void AddClient(Client client)
        {
            listClients.Add(client);
        }

        //Retorna um item da coleção
        public Client GetClient(int pos)
        {
            return listClients[pos];
        }
    }
}
