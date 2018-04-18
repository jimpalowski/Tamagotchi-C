
using System.Collections.Generic;
using TamaG.Models;

namespace Games.Models
{
    public static class Game
    {
        private static List<Pet> _instances = new List<Pet> {};

        public static List<Pet> GetAll()
       {
           return _instances;
       }

        // public void Save()
        // {
        //     _instances.Add(this);
        // }

   }
}
