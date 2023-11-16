using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallShootingGame
{
    class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded) //parameter 'balls' is same name as the class variable 'balls'. 'this' keyword wiil be needed to differentiate.
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }

        public int MagazineSize { get; set; }

        private int balls = 0;
        public int BallsLoaded { get; private set; }

        public bool IsEmpty() { return BallsLoaded == 0; }

        public int Balls
        {
            get { return balls; }

            set 
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }
        public void Reload()
        {
            if (balls > MagazineSize)
                BallsLoaded = MagazineSize;
            else
                BallsLoaded = balls;
        }
        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
    }

}
