﻿namespace ProjektZespolowy.Models.MyModels
{
    public class Usluga
    {
        public string TypUslugi { get; set; }
        public double Cena {
            get
            {
                return Cena;
            }
            set
            {
                Cena = System.Math.Round(value,2);
            }
        }
        public int PunktyZysk { get; set; }
        public int PunktyKoszt { get; set; }

    }
}