using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciamento_biblioteca
{
    public class Livro : ItemBiblioteca // classe livro que herda de itemBiblioteca
    {
        public Livro(string titulo, string autor, string descricao ) : base(titulo, autor) // contrutor do livro que passa titulo,autor e uma descricao 
        {                                                                                        
            this.DescricaoInterna = $"descricao: {descricao}"; 
        }
        public Livro(string titulo, string autor) : base(titulo, autor) {} // caso o usuario deseja passar sem a descricao, sera possivel mas setando a descricao padrao

        public void ExibirDescricaoInterna() // metodo para exibir a descricao interna do livro 
        { 
            Console.WriteLine("Descricao interna: " + DescricaoInterna);
        }
    }
}