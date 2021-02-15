using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { databaseLoggerService, fileloggerService });

            List<ILoggerService> loggerServices = new List<ILoggerService>();
            loggerServices.Add(databaseLoggerService);
            loggerServices.Add(fileloggerService);
            basvuruManager.BasvuruYap(konutKrediManager, loggerServices);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

           


        }
    }
}
