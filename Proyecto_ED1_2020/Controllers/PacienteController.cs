using System;
using System.Collections.Generic;
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
            Paciente paciente = new Paciente();
            return View(paciente);
        }

        [HttpPost]
        public ActionResult SelecionarDepto(FormCollection formcollection)
        {
            if (formcollection.Count >= 9)
            {
                Paciente paciente = new Paciente()
                {
                    Nombre = formcollection["Nombre"],
                    Apellido = formcollection["Apellido"],
                    CUI = long.Parse(formcollection["CUI"]),
                    Edad = int.Parse(formcollection["Edad"]),
                    Munucipio = formcollection["Munucipio"],
                    DescripcionDePosibleContagio = formcollection["Descripcion"]
                };
                paciente.Sintomas = new List<string>();
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

                return View();
            }
            else
            { 
                Paciente paciente = new Paciente()
                    {
                        Nombre = formcollection["Nombre"],
                        Apellido = formcollection["Apellido"],
                        CUI = long.Parse(formcollection["CUI"]),
                    };
                var departamento = formcollection["Departamento"];
                string[] recorte = departamento.Split(',');
                paciente.Departamento = recorte[0];
                paciente.ObtenerMunicipios(paciente.Departamento);
                return View("Registrar", paciente);
            }
        }

        [HttpPost]
        public ActionResult Prueva(FormCollection formcollection)
        {
            return View();
        }





    }
}
