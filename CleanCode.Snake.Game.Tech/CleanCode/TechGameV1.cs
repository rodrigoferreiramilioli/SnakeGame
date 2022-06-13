using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Snake.Game.Tech.CleanCode
{
    public class TechGameV1
    {
        private string _currentDirection { get; set; }
        public TechGameV1()
        {
            _currentDirection = "right";
        }
        public TechGameV1(string currentDirection)
        {
            _currentDirection = currentDirection;
        }
        public string ChangeDirection(int keyCode)
        {
            if ((keyCode == 37) && (_currentDirection != "right"))
                return "left";
            else if ((keyCode == 38) && (_currentDirection != "down"))
                return "up";
            else if ((keyCode == 39) && (_currentDirection != "left"))
                return "right";
            else if ((keyCode == 40) && (_currentDirection != "up"))
                return "down";

            return "NotFound";
        }
    }
}
