using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallShootingGame
{
    class PaintBallGun
    {
        public const int MAGAZINE_SIZE = 16;

        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded() { return ballsLoaded; }

        public bool IsEmpty() { return ballsLoaded == 0; }

        public int GetBalls() { return balls; }

        public void SetBalls(int numberOrBalls)
        {
            if (numberOrBalls > 0)
                balls = numberOrBalls;
            Reload();
        }
        public void Reload()
        {
            if (balls > MAGAZINE_SIZE)
                ballsLoaded = MAGAZINE_SIZE;
            else
                ballsLoaded = balls;
        }
        public bool Shoot()
        {
            if (ballsLoaded == 0) return false;
            ballsLoaded--;
            balls--;
            return true;
        }
    }

}
