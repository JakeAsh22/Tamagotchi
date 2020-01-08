using System;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public int foodLvl { get; set; }
        public int playLvl { get; set; }
        public int restLvl { get; set; }
        public bool dead { get; set; }

        public Pet ()
        {
            foodLvl = 10;
            playLvl = 10;
            restLvl = 8;
            dead = false;
        }

        public void Food()
        {
            foodLvl += 2;
            playLvl--;
            restLvl--;
        }
        public void Play()
        {
            foodLvl -= 3;
            playLvl += 2;
            restLvl--;
        }

        public void Rest()
        {
            restLvl = 8;
            foodLvl -= 2;
            playLvl -= 3;
        }

        public void Pass()
        {
            restLvl--;
            foodLvl--;
            playLvl--;
        }
        public bool IsDead()
        {
            if (foodLvl <= 0|| playLvl <= 0 || restLvl <= 0)
                return dead = true;
            return dead;
        }
    }
}