using CleanCode.Snake.Game.Tech.CleanCode;
using CleanCode.Snake.Game.Tech.NotCleanCode;
using Xunit;

namespace CleanCode.Snake.Game.Tests
{
    public class SnakeTests
    {        
        /* Leia o Readme.txt */
        [Fact]
        public void TechGameTest()
        {
            //Move a cobrinha para esquerda
            TechGame game = new TechGame();
            var diretion = game.Atualiza(38);
            game = new TechGame(diretion);
            diretion = game.Atualiza(37);

            // move a cobrinha para direita
            game = new TechGame(diretion);
            diretion = game.Atualiza(40);
            game = new TechGame(diretion);
            diretion = game.Atualiza(39);
        }

        [Fact]
        public void TechGameTestV1()
        {
            //Move a cobrinha para esquerda
            var techGame = new TechGameV1();
            var currentDiretion = techGame.ChangeDirection(38);
            techGame = new TechGameV1(currentDiretion);
            currentDiretion = techGame.ChangeDirection(37);

            // move a cobrinha para direita
            techGame = new TechGameV1(currentDiretion);
            currentDiretion = techGame.ChangeDirection(40);
            techGame = new TechGameV1(currentDiretion);
            currentDiretion = techGame.ChangeDirection(39);
        }
    }
}