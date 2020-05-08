using System;
using System.Collections.Generic;
using Proyecto_ED1_2020.Helpers;
using System.Linq;
using System.Web;

namespace Proyecto_ED1_2020.Models
{
    public class Estadistica
    {
        public int Contagiados { get; set; }
        public int Sospechosos { get; set; }
        public int Recuperados { get; set; }
        public double PorsentageSospechososPocitivos { get; set; }

        public Estadistica()
        {
            Contagiados = Storage.Instance.Contagiados;
            Sospechosos = Storage.Instance.Sospechos;
            Recuperados = Storage.Instance.recuperados;
            if (Sospechosos != 0)
                PorsentageSospechososPocitivos =  (Contagiados * 100)/ Storage.Instance.RegistroGeneral.Count();
            else
                PorsentageSospechososPocitivos = 0.0;
        }
    }
}