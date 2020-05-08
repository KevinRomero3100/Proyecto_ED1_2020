using System;
using CustumGenerics.Structures;
using Proyecto_ED1_2020.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_ED1_2020.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        public int Contagiados { get; set; }
        public int Sospechos { get; set; }
        public double PorcentajeDeSospechososPositivos { get; set; }
        public int recuperados { get; set; }

        public Random RandomParaDiagnostivo = new Random();


        public AVL<Paciente> RegistroGeneral = new AVL<Paciente>();

        public HashTable<Paciente> CamasOcupadas = new HashTable<Paciente>();

        public Heep<Paciente> ContagiadosCapitalEspera = new Heep<Paciente>();
        public Heep<Paciente> ContagiadoQuetzaltenagoEspera = new Heep<Paciente>();
        public Heep<Paciente> ContagiadosPetenEspera = new Heep<Paciente>();
        public Heep<Paciente> ContagiadosEscuintlaEspera = new Heep<Paciente>();
        public Heep<Paciente> ContagiadosOrienteEspera = new Heep<Paciente>();

        public Heep<Paciente> SospechososCapitalEspera = new Heep<Paciente>();
        public Heep<Paciente> SospechososQuetzaltenagoEspera = new Heep<Paciente>();
        public Heep<Paciente> SospechososPetenEspera = new Heep<Paciente>();
        public Heep<Paciente> SospechososEscuintlaEspera = new Heep<Paciente>();
        public Heep<Paciente> SospechososOrienteEspera = new Heep<Paciente>();



    }
}