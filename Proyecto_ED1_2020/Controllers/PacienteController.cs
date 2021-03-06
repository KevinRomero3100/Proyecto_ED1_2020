﻿using System;
using System.Collections.Generic;
using CustumGenerics.Structures;
using Proyecto_ED1_2020.Helpers;
using Proyecto_ED1_2020.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_ED1_2020.Controllers
{
    public class PacienteController : Controller
    {
        public ActionResult Registrar()
        {
            if (Storage.Instance.IncocacionCamas)
            {
                IndexCama camas = new IndexCama();
                Storage.Instance.hashGUA = camas.hashGUA();
                Storage.Instance.hashQUE = camas.hashQUE();
                Storage.Instance.hashORI = camas.hashORI();
                Storage.Instance.hashESC = camas.hashESC();
                Storage.Instance.hashPET = camas.hashPET();
                Storage.Instance.IncocacionCamas = false;
            }
            Paciente paciente = new Paciente();
            return View(paciente);
        }
        public ActionResult Estadisticas()
        {
            Estadistica estadistica = new Estadistica();
            return View(estadistica);
        }
       
        public ActionResult BusquedaAvanzada()
        {
            return View();
        }
        public ActionResult Detalles(long id)
        {
            var Paciente = new Paciente();
            Paciente = Paciente.Busqueda(id);
            return View(Paciente);
        }


        public ActionResult Camas()
        {
            if (Storage.Instance.IncocacionCamas)
            {
                IndexCama camas = new IndexCama();
                Storage.Instance.hashGUA = camas.hashGUA();
                Storage.Instance.hashQUE = camas.hashQUE();
                Storage.Instance.hashORI = camas.hashORI();
                Storage.Instance.hashESC = camas.hashESC();
                Storage.Instance.hashPET = camas.hashPET();
                Storage.Instance.IncocacionCamas = false;
            }
            List<IndexCama> disponibles = new List<IndexCama>();

            var capital = Storage.Instance.hashGUA;
            while (capital.Count() != 0)
            {
                var valor = capital.Dequeue();
                disponibles.Add(valor);
            }
            var quetzaltenango = Storage.Instance.hashQUE;
            while (quetzaltenango.Count() != 0)
            {
                var valor = quetzaltenango.Dequeue();
                disponibles.Add(valor);
            }
            var escuintla = Storage.Instance.hashESC;
            while (escuintla.Count() != 0 )
            {
                var valor = escuintla.Dequeue();
                disponibles.Add(valor);
            }
            var oriente = Storage.Instance.hashORI;
            while (oriente.Count() != 0)
            {
                var valor = oriente.Dequeue();
                disponibles.Add(valor);
            }
            var peten = Storage.Instance.hashPET;
            while (peten.Count() != 0)
            {
                var valor = peten.Dequeue();
                disponibles.Add(valor);
            }
            return View(disponibles);
        }

        public ActionResult CambiarEstado(long id)
        {
            Paciente paciente = new Paciente();
            paciente = paciente.Recuperar(id);
            return View("Detalles", paciente);
        }

        public ActionResult NuevaPrueva(long id)
        {
            Paciente paciente = new Paciente();
            paciente = paciente.Diagnosticar(id);
            return View("Detalles", paciente);
        }

        [HttpPost]
        public ActionResult BusquedaAvanzada(FormCollection formcollection)
        {
            if (Storage.Instance.RegistroGeneral.Count() != 0)
            {
                Paciente Buscado = new Paciente();
                List<Paciente> pacientes = new List<Paciente>();
                try
                {
                    var prueva = formcollection["ParametroDeBusqueda"];
                    long CUI = long.Parse(formcollection["ParametroDeBusqueda"]);
                    Buscado = Buscado.Busqueda(CUI);
                    pacientes.Add(Buscado);
                    return View(pacientes);
                }
                catch (Exception)
                {
                    var prueva = formcollection["ParametroDeBusqueda"];
                    pacientes = Buscado.BusquedaAvanzada(formcollection["ParametroDeBusqueda"]);
                    return View(pacientes);
                }
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult SelecionarDepto(FormCollection formcollection)
        {
            var departamento = formcollection["Departamento"];
            string[] recorte = departamento.Split(',');
            if (formcollection.Count >= 9)
            {
                Paciente paciente = new Paciente()
                {
                    Nombre = formcollection["Nombre"],
                    Apellido = formcollection["Apellido"],
                    CUI = long.Parse(formcollection["CUI"]),
                    Edad = int.Parse(formcollection["Edad"]),
                    Munucipio = formcollection["Munucipio"],
                    Departamento = recorte[0],
                    DescripcionDePosibleContagio = formcollection["Descripcion"]
                };
                paciente.Sintomas = new List<string>();
                #region sintomas
                if (formcollection["Fiebre"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Fiebre"]);
                }
                if (formcollection["Cansancio"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Cansancio"]);
                }
                if (formcollection["Tos seca"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Tos seca"]);
                }
                if (formcollection["Dolor corporal"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Dolor corporal"]);
                }
                if (formcollection["Congestion nasal"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Congestion nasal"]);
                }
                if (formcollection["Secrecion nasal"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Secrecion nasal"]);
                }
                if (formcollection["Dolor de garganta"] != null)
                {
                    paciente.Sintomas.Add(formcollection["Dolor de garganta"]);
                }
                #endregion
                if (paciente.Guardar())
                {
                    paciente = new Paciente();
                    ViewBag.Confirmacion = "Paciente registrado con exito";

                    return View("Registrar", paciente);
                }
                else
                {
                    paciente = new Paciente();
                    ViewBag.Error = "No se ha podido registrar al paciente";
                    return View("Registrar", paciente);
                }
            }
            else
            { 
                Paciente paciente = new Paciente()
                {
                    Nombre = formcollection["Nombre"],
                    Apellido = formcollection["Apellido"],
                    CUI = long.Parse(formcollection["CUI"]),
                    Edad = int.Parse(formcollection["Edad"])
                };
                
                paciente.Departamento = recorte[0];
                paciente.ObtenerMunicipios(paciente.Departamento);
                return View("Registrar", paciente);
            }
        }

        



    }
}
