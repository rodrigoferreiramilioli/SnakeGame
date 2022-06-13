namespace CleanCode.Snake.Game.Tech.NotCleanCode
{
    public class TechGame
    {
        private string _direction { get; set; }
        public TechGame()
        {
            _direction = "right";
        }
        public TechGame(string direction)
        {
            _direction = direction;
        }
        public string Atualiza(int keyCode)
        {
            if((keyCode == 37) && (_direction != "right"))
                return "left";
            else if((keyCode == 38) && (_direction != "down"))
                return "up";
            else if((keyCode == 39) && (_direction != "left"))
                return "right";
            else if ((keyCode == 40) && (_direction != "up"))
                return "down";

            return "NotFound";
        }
    }
}