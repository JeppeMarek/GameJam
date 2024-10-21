using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public static class Player
    {
        public static int Lives = 1;

        // Method to add lives
        public static void AddLives (int lives)
        {
            if (lives < 0)
            {
                Lives += lives;
            } else
            {
                Lives = 1;
            }
        }
    }
}
