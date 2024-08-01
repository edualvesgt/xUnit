using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livros(string titulo, string autor)
        {
            // Atribui o valor do parâmetro "titulo" à propriedade "Titulo"
            Titulo = titulo;
            // Atribui o valor do parâmetro "autor" à propriedade "Autor"
            Autor = autor;
        }
    }
}
