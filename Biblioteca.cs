using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho_as;

namespace gerenciamento_biblioteca
{
    public class Biblioteca 
    {
        List<ItemBiblioteca> itens = new List<ItemBiblioteca>(); 

        public void AdicionarItem(ItemBiblioteca item) // metodo para adicionar livro
        {
            itens.Add(item);
            Console.WriteLine("Livro adicionado com sucesso");
        }
        public void RemoverItem(ItemBiblioteca item) // metodo para remover livro
        {
            itens.Remove(item);
            Console.WriteLine("Livro deletado com sucesso");
        }
        public ItemBiblioteca BuscarItemPorTitulo(string titulo) // metodo para buscar um livro por titulo
        {
            foreach (ItemBiblioteca item in itens)
            {                
                if (item.Titulo == titulo)
                    return item;
            }
            return null;
        }
        public ItemBiblioteca BuscarItemPorId(int id) // metodo para buscar um livro por id
        {            
            foreach (ItemBiblioteca item in itens)
            {                
                if (item.Id == id)
                    return item;
            }
            return null;
        }
    }
}