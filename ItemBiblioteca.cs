using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho_as;

namespace gerenciamento_biblioteca
{
    public abstract class ItemBiblioteca : Base // classe abastrata que herda da classe base
    {
        protected ItemBiblioteca(string titulo, string autor) // contrutor que obriga que cada item da biblioteca tenha um titulo e autor 
        {
            Autor = autor;
            Titulo = titulo;
        }
        public string Titulo { get; set; } 
        public string Autor { get; set; } 
        protected string DescricaoInterna = "descricao nao informada do livro"; // descricao interna caso o usuario nao passe sera 
                                                                                // atribuido a mensagem padrao
    }
}
