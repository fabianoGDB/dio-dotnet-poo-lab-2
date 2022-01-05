using DIO.Series.Interfaces;
using DIO.Series.Web.Controllers;
using Moq;
using System;
using Xunit;

namespace DIO.Series.Web.Tests
{
    public class SerieControllerTest
    {
        [Fact(DisplayName = "DADA uma serie Valida Quando inserimos Entao chamamos o repositorio")]
        public void InsereSucesso()
        {
            var serie = new SerieModel() { Titulo = "O poderoso" };
            // Crio Repositorio MOCK
            var repositorio = new Mock<IRepositorio<Serie>>();

            //Defino que sempre ao chegar vai retornar 1
            repositorio.Setup(_ => _.ProximoId()).Returns(1);

            //Crio o controller
            var controller = new SerieController(repositorio.Object);

            //Insiro
            controller.Insere(serie);


            repositorio.Verify(_ => _.Insere(It.Is<Serie>(_ => _.Id == 1 && _.retornaTitulo() == "O poderoso")), Times.Once);

        }
    }
}
