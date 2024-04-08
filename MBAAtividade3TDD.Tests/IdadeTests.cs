namespace MBAAtividade3TDD.Tests
{
    public class IdadeTests
    {
        [Fact]
        public void ReceberIdadeInteira_VerificarSeEhNumeroInteiro_RetornaIdadeValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "19";
            string retornoEsperado = "Idade é válida";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado,retornoEsperado);
        }

        [Fact]
        public void ReceberIdadeString_VerificarSeNumeroNaoEhInteiro_RetornaIdadeInValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "a";
            string retornoEsperado = "Idade é inválida nao é um inteiro";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado, retornoEsperado);
        }

        [Fact]
        public void ReceberIdadeDecimal_VerificarSeNumeroNaoEhInteiro_RetornaIdadeInValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "3.14";
            string retornoEsperado = "Idade é inválida nao é um inteiro";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado, retornoEsperado);
        }

        [Fact]
        public void ReceberIdadeInteira_VerificarSeNumeroMenorQueZero_RetornaIdadeInValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "-10";
            string retornoEsperado = "Idade é inválida menor que zero";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado, retornoEsperado);
        }

        [Fact]
        public void ReceberIdadeInteira_VerificarSeNumeroMaiorQueCentoETrinta_RetornaIdadeInValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "140";
            string retornoEsperado = "Idade é inválida";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado, retornoEsperado);
        }

        [Fact]
        public void ReceberIdadeInteira_VerificarSeNaoEhAdulto_RetornaIdadeInValida()
        {
            //Arrange - preparar dados
            string idadeParametro = "8";
            string retornoEsperado = "Idade é inválida nao é um adulto";

            //Act - o que vc vai fazer ação
            var idade = new Idade();
            string resultado = idade.ValidaIdade(idadeParametro);

            //Assert - o acerto, a comparação
            Assert.Equal(resultado, retornoEsperado);
        }
    }
}