using System;

namespace GameProject
{
    class Program
    {
        //6.gun
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                GamerId = 1,
                FirstName = "ENGIN",
                LastName = "DEMIROG",
                YearOfBirth = 1985,
                IdentityNumber = 12345
            };

            Gamer gamer2 = new Gamer()
            {
                GamerId = 1,
                FirstName = "ENGIN",
                LastName = "DEMIROG",
                YearOfBirth = 1986,
                IdentityNumber = 12345
            };

            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Delete(gamer);
            gamerManager.Update(new Gamer());
            gamerManager.Add(gamer);
            gamerManager.Add(gamer2);

            Console.WriteLine("-----------------------");
            EStateUserValidationManager eStateUserValidationManager = new EStateUserValidationManager();
            GamerManager gamerManager1 = new GamerManager(eStateUserValidationManager);
            gamerManager1.Add(gamer);
            


            Console.ReadLine();
        }
    }

    class Gamer
    {
        public int GamerId { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
 
    }

    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }

    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Kayit basarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit güncellendi");
        }
    }

    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }

    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="ENGIN" && 
                gamer.LastName=="DEMIROG" &&
                gamer.YearOfBirth==1985 && 
                gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class EStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            Console.WriteLine("EState dogrulandi");
            return true;
            
        }
    }

}

