using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GamerManager: IGamerService
    {

        //uservalidaiton kullanmak için
        IUserValidationService _userValidationService;

        //artık gamer manager ın bir bağımlılığı var. Bunun içinde bir doğrulama servisini kullancağımızı söylüyoruz.
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

       
        List<Gamer> liste = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {

             liste.Add(gamer);
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " başarıyla eklendi." + "\n");
             Console.WriteLine("-----------------------------------------------------------------");

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız,kayıt başarısız.");
            }

        }

        public void Delete(Gamer gamer)
        {
            int id = gamer.Id; //silinmek istenen müşterinin id bilgisini musteri.id ile aldı ve o integer
            //değeri id adında bir değişkene atadı.
            
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].Id==id) //liste tek tek gezilip silinmek istenen müşterinin id sine eşit olan müşteri arandı ve bulunan müşteri silindi
                {
                   liste.RemoveAt(i);
                }
            }

            


            Console.WriteLine("-----------------------------------------------------------------");
            //silinen müşterinin adını ve soy adını yazdırma
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " başarıyla silindi." + "\n");
            Console.WriteLine("-----------------------------------------------------------------");
        }


        public void Listele()
        {
            Console.WriteLine("------------------------- LİSTE -------------------------------");
            foreach (var item in liste) //liste adındaki listedeki tüm müşterilerin istenilen özelliklerini sıralar.
            {
                Console.WriteLine("Id: " + item.Id + "\n" + "Ad-Soyad: " + item.FirstName + item.LastName
                    + "\n" + "TC no: " + item.TcNo + "\n" +
                    "Birthday:" + item.Birthday + "\n");
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Kayıt güncellendi");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
