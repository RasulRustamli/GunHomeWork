using System;

namespace GunHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            GunArmor ak47 = new GunArmor("Ak47");
            ak47.UnlockFire("oneshoot");
            ak47.Shoot();
            ak47.Shoot();
           
            ak47.OneReload();
            Console.WriteLine(ak47.AmmoCount);
            ak47.Reload();


        }


    }
}
