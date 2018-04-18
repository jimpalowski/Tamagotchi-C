using System.Collections.Generic;

namespace TamaG.Models
{
    public class Pet
    {
        private string _name;
        private int _hunger;
        private int _play;
        private int _sleep;
        private static List<Pet> _instances = new List<Pet> {};

        public Pet()
        {
            _hunger = 5;
            _play = 5;
            _sleep = 5;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }

        public int GetHunger()
        {
            return _hunger;
        }
        public void SetHunger(int newHunger)
        {
            _hunger = newHunger;
        }

        public int GetPlay()
        {
            return _play;
        }
        public void SetPlay(int newPlay)
        {
            _play = newPlay;
        }

        public int GetSleep()
        {
            return _sleep;
        }
        public void SetSleep(int newSleep)
        {
            _sleep = newSleep;
        }

        public static List<Pet> GetAll()
        {
           return _instances;
        }

        public void Save()
        {
           _instances.Add(this);
        }

        public void Feed()
        {
            _hunger ++;

        }

        public void Attend()
        {
            _play++;
        }

        public void Nap()
        {
            _sleep++;
        }

        public void Kill()
        {
            _hunger--;
            _play--;
            _sleep--;
        }
    }
}
