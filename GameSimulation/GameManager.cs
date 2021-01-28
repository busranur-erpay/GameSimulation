using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GameManager: IGameService
    {
        
        List<Game> liste = new List<Game>();
        public void Add(Game game)
        {
            liste.Add(game);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(game.GameName + " başarıyla eklendi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void Delete(Game game)
        {
            int id = game.GameId;

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].GameId == id) 
                {
                    liste.RemoveAt(i);
                }
            }




            Console.WriteLine("-----------------------------------------------------------------");
            
            Console.WriteLine(game.GameName + " başarıyla silindi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }


        public void Listele()
        {
            Console.WriteLine("-------------------------- OYUN LİSTESİ -----------------------------");
            foreach (var item in liste) 
            {
                Console.WriteLine("Id: " + item.GameId + "\n" + "Oyun Adı: " + item.GameName + "\n" + "Oyun Türü: "  + item.GameType
                    + "\n" + "Oyun Fiyatı: " + item.GamePrice + "\n" +
                    "Yıl: " + item.GameYear + "\n");
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }


        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" güncellendi.");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
