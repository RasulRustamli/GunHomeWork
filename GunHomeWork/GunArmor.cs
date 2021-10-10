﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GunHomeWork
{
    class GunArmor
    {
        public string Guntype;
        public string Mode;//silahin gulle atma modu
        public int AmmoCount;//daraqdaki gulle sayi
        public int FullAmmo;//Persondaki gulle sayi
        public int Ammolimit;//daraq limiti
        
        

        public GunArmor()
        {

        }
        
        public GunArmor(string Guntype)
        {
            if (Guntype =="Ak47")
            {
                this.Guntype = Guntype;
                AmmoCount = 30;
                Ammolimit = 30;
                FullAmmo = 180;
                   
            }
            else if (Guntype == "Famas")
            {
                this.Guntype = Guntype;
                AmmoCount = 25;
                Ammolimit = 25;
                FullAmmo = 150;
            }
            else if (Guntype == "Deagle")
            {
                this.Guntype = Guntype;
                AmmoCount = 7;
                Ammolimit = 7;
                FullAmmo = 35;
                Mode = "oneshoot";
            }
            else
            {
               Console.WriteLine("Please Enter Normal Weapon name");
            }
        }

        #region OneReload
        public void OneReload()
        {
            if (AmmoCount < Ammolimit)
            {
                AmmoCount += 1;
                FullAmmo -= 1;
            }
            else
            {
                Console.WriteLine("Full magazine");
            }
        }
#endregion

        #region Reload
        public void Reload()
        {
            
            if (AmmoCount == 0)
            {
                AmmoCount = Ammolimit;
                FullAmmo -= Ammolimit;
                Console.WriteLine("Succes change magazine");
            }
            else
            {
                Console.WriteLine("Please Change magazine after empty");
            }
            
        }
        #endregion

        #region Shoot
        public void Shoot()
        {
            if (Mode != null )
            {
                if (Mode == "oneshoot")
                {

                    if (AmmoCount > 0)
                    {
                        AmmoCount -= 1;
                    }
                    else
                    {
                        Console.WriteLine("please change magazine");
                    }
                }
                else
                {
                    if (AmmoCount > 0)
                    {
                        for (int i = AmmoCount; i > 0; i--) ;
                    }
                    else Console.WriteLine("please change magazine");
                }
            }
            else
            {
                Console.WriteLine("please unlock gun fire");
            }
        }
        #endregion

        #region UnlockFire
        public void UnlockFire(string mode)
        {
            if (Guntype != "Deagle")
            {
                if (mode == "auto")
                {
                    Mode = mode;
                    Console.WriteLine("succes unlock gun fire");

                }
                else if (mode == "oneshoot")
                {
                    Mode = mode;
                    Console.WriteLine("succes unlock gun fire");
                }
                else
                {
                    Console.WriteLine("please select gun fire mode");
                }
            }
            else
            {
                Console.WriteLine("Deagle has not mode");
            }
        }
        #endregion



    }
}
