using System.Collections.Generic;


namespace Tamagotchi.Models
{
    public class Pet
    {
        public int foodLvl { get; set; }
        public int playLvl { get; set; }
        public int restLvl { get; set; }
        public bool dead { get; set; }
        public string name { get; set; }
        private static List<Pet> _instances = new List<Pet> {};

        public Pet (string userInput)
        {
            foodLvl = 10;
            playLvl = 10;
            restLvl = 8;
            dead = false;
            name = userInput;
            _instances.Add(this);
        }

        public static List<Pet> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
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
                dead = true;
            return dead;
        }
    }
}