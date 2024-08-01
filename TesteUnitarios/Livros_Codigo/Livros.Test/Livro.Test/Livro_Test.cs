using GerenciamentoDeLivros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Livro.Test
{
    public class Livro_Test
    {

        [Fact]
        public void AdicionarLivro()
        {
            // Arrange: Cria uma lista de livros e um livro a ser adicionado
            var listaDeLivros = new List<Livros>();
            var livro = new Livros("Pai Rico Pai Pobre", "Robert Kiyosak");

            // Act: Adiciona o livro à lista
            listaDeLivros.Add(livro);



            // Assert: Verifica se o livro foi adicionado corretamente à lista
            Assert.Contains(livro, listaDeLivros);
        }
    }
}
