using System;
using Xunit;

namespace DIO.Series.Tests
{
    public class SerieRepositorioTests
    {   [Fact(DisplayName = "DADO serie valida QUANDO inserimos ENTAO persistimos")]
        public void Insere_SUcesso()
        {
            var repositorio = new SerieRepositorio();
            repositorio.Insere(new Serie(1, Genero.Aventura, "TITULO", "", 2021));

            var seriePersistida = repositorio.RetornaPorId(1);

            Assert.NotNull(seriePersistida);
            Assert.Equal("TITULO", seriePersistida.retornaTitulo());
        }
    }
}
