namespace MBAAtividade3TDD.Tests
{
    public class IdadeTests
    {
        [Theory]
        [InlineData("19")]
        [InlineData("50")]
        [InlineData("75")]
        public void ReceberIdadeInteira_VerificarSeEhNumeroInteiro_RetornaIdadeValida(string idadeParametro)
        {
            //Arrange - preparar dados
            string retornoEsperado = "Idade � v�lida";

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado,retornoEsperado);
        }

        [Theory]
        [InlineData("%" , "Idade � inv�lida nao � um inteiro")]
        [InlineData("&", "Idade � inv�lida nao � um inteiro"),]
        [InlineData("a", "Idade � inv�lida nao � um inteiro")]
        public void ReceberIdadeString_VerificarSeNumeroNaoEhInteiro_RetornaIdadeInValida(string idadeParametro, string retornoEsperado)
        {
            //Arrange - preparar dados
            //inline data

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado, retornoEsperado);
        }

        [Theory]
        [InlineData("0.1")]
        [InlineData("100.65")]
        [InlineData("8500.453258")]
        public void ReceberIdadeDecimal_VerificarSeNumeroNaoEhInteiro_RetornaIdadeInValida(string idadeParametro)
        {
            //Arrange - preparar dados
            string retornoEsperado = "Idade � inv�lida nao � um inteiro";

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado, retornoEsperado);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("-10")]
        [InlineData("-10000000")]
        public void ReceberIdadeInteira_VerificarSeNumeroMenorQueZero_RetornaIdadeInValida(string idadeParametro)
        {
            //Arrange - preparar dados
            string retornoEsperado = "Idade � inv�lida menor que zero";

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado, retornoEsperado);
        }

        [Theory]
        [InlineData("131")]
        [InlineData("2000")]
        [InlineData("20000000")]
        public void ReceberIdadeInteira_VerificarSeNumeroMaiorQueCentoETrinta_RetornaIdadeInValida(string idadeParametro)
        {
            //Arrange - preparar dados
            string retornoEsperado = "Idade � inv�lida";

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado, retornoEsperado);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("17")]
        [InlineData("8")]
        public void ReceberIdadeInteira_VerificarSeNaoEhAdulto_RetornaIdadeInValida(string idadeParametro)
        {
            //Arrange - preparar dados
            string retornoEsperado = "Idade � inv�lida nao � um adulto";

            //Act - o que vc vai fazer a��o
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a compara��o
            Assert.Equal(resultado, retornoEsperado);
        }
    }
}