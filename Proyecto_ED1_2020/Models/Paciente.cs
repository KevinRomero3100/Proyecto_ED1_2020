using System;
using Proyecto_ED1_2020.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_ED1_2020.Models
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long CUI { get; set; }
        public int Edad { get; set; }
        public double Probabilidad { get; set; }
        public int Categoria { get; set; }
        public string Departamento { get; set; }
        public string Munucipio { get; set; }
        public List<string> Sintomas { get; set; }
        public string DescripcionDePosibleContagio { get; set; }
        public string Estado { get; set; }


        public string HospitalDeAtencion { get; set; }

        public static string[] Departamentos { get; set; }
        public List<string> Municipios { get; set; }

        #region Form
        public List<string> ObtenerMunicipios(string departamento)
        {
            Municipios = new List<string>();
            if (departamento == "Alta Verapaz")
            {
                Municipios.Add("Chahal");
                Municipios.Add("Chisec");
                Municipios.Add("Cobán ");
                Municipios.Add("Fray Bartolomé de las Casas");
                Municipios.Add("Panzóz");
                Municipios.Add("Raxruhá");
                Municipios.Add("San Agustín Lanquín");
                Municipios.Add("San Cristóbal Verapaz");
                Municipios.Add("San Juan Chamelco");
                Municipios.Add("San Miguel Tucurú");
                Municipios.Add("San Pedro Carchá");
                Municipios.Add("Santa Catalina La Tinta");
                Municipios.Add("Santa Cruz Verapaz");
                Municipios.Add("Santa María Cahabón");
                Municipios.Add("Senahú");
                Municipios.Add("Tactic");
                Municipios.Add("Tamahú");
                return Municipios;
            }
            else if (departamento == "Baja Verapaz")
            {
                Municipios.Add("Cubulco");
                Municipios.Add("Granados");
                Municipios.Add("Purulhá");
                Municipios.Add("Rabinal");
                Municipios.Add("Salamá");
                Municipios.Add("San Jerónimo");
                Municipios.Add("San Miguel Chicaj");
                Municipios.Add("Santa Cruz el Chol");

                return Municipios;
            }
            else if (departamento == "Chimaltenango")
            {
                Municipios.Add("Acatenango");
                Municipios.Add("Chimaltenango");
                Municipios.Add("El Tejar");
                Municipios.Add("Parramos");
                Municipios.Add("Patzicía");
                Municipios.Add("Patzún");
                Municipios.Add("San Andrés Itzapa");
                Municipios.Add("San José Poaquil");
                Municipios.Add("San Juan Comalapa");
                Municipios.Add("San Martín Jilotepeque");
                Municipios.Add("San Miguel Pochuta");
                Municipios.Add("San Pedro Yepocapa");
                Municipios.Add("Santa Apolonia");
                Municipios.Add("Santa Cruz Balanyá");
                Municipios.Add("Tecpán");
                Municipios.Add("Zaragoza");
                ;
                return Municipios;
            }
            else if (departamento == "Chiquimula")
            {
                Municipios.Add("Camotán");
                Municipios.Add("Chiquimula"); 
                Municipios.Add("Concepción Las Minas");
                Municipios.Add("Esquipulas");
                Municipios.Add("Ipala");
                Municipios.Add("Jocotán");
                Municipios.Add("Olopa");
                Municipios.Add("Quezaltepeque");
                Municipios.Add("San Jacinto");
                Municipios.Add("San José la Arada");
                Municipios.Add("San Juan Hermita.");

                return Municipios;
            }
            else if (departamento == "El Progreso")
            {
                Municipios.Add("El Jícaro");
                Municipios.Add("Guastatoya");
                Municipios.Add("Morazán");
                Municipios.Add("San Agustín Acasaguastlán");
                Municipios.Add("San Antonio La Paz");
                Municipios.Add("San Cristóbal Acasaguastlán");
                Municipios.Add("Sanarate");
                Municipios.Add("Sansare");

                return Municipios;
            }
            else if (departamento == "Escuintla")
            {
                Municipios.Add("Escuintla");
                Municipios.Add("Guaganazapa");
                Municipios.Add("Iztapa");
                Municipios.Add("La Democracia");
                Municipios.Add("La Gomera");
                Municipios.Add("Masagua");
                Municipios.Add("Nueva Concepción");
                Municipios.Add("Palín");
                Municipios.Add("San José");
                Municipios.Add("San Vicente Pacaya");
                Municipios.Add("Santa Lucía Cotzumalguapa");
                Municipios.Add("Siquinalá");
                Municipios.Add("Tiquisate");

                return Municipios;
            }
            else if (departamento == "Guatemala")
            {
                Municipios.Add("Amatitlán");
                Municipios.Add("Chinautla");
                Municipios.Add("Chuarrancho");
                Municipios.Add("Fraijanes");
                Municipios.Add("Guatemala");
                Municipios.Add("Mixco");
                Municipios.Add("Palencia");
                Municipios.Add("San José del Golfo");
                Municipios.Add("San José Pinula");
                Municipios.Add("San Juan Sacatepéquez");
                Municipios.Add("San Miguel Petapa");
                Municipios.Add("San Pedro Ayampuc");
                Municipios.Add("San Pedro Sacatapéquez");
                Municipios.Add("San Raymundo");
                Municipios.Add("Santa Catarina Pinula");
                Municipios.Add("Villa Canales");
                Municipios.Add("Villa Nueva");

                return Municipios;
            }
            else if (departamento == "Huehuetenango")
            {
                Municipios.Add("Aguacatán");
                Municipios.Add("Chiantla");
                Municipios.Add("Colotenango");
                Municipios.Add("Concepción Huista");
                Municipios.Add("Cuilco");
                Municipios.Add("Huehuetenango ");
                Municipios.Add("Ixtahuacán");
                Municipios.Add("Jacaltenango");
                Municipios.Add("La Democracia");
                Municipios.Add("La Libertad");
                Municipios.Add("Malacatancito");
                Municipios.Add("Nentón");
                Municipios.Add("San Antonio Huista");
                Municipios.Add("San Gaspar Ixchil");
                Municipios.Add("San Juan Atitlán");
                Municipios.Add("San Juan Ixcoy");
                Municipios.Add("San Mateo Ixtatán");
                Municipios.Add("San Miguel Acatán");
                Municipios.Add("San Pedro Necta");
                Municipios.Add("San Rafael La Independencia");
                Municipios.Add("San Rafael Petzal");
                Municipios.Add("San Sebastián Coatán");
                Municipios.Add("San Sebastián Huehuetenango");
                Municipios.Add("Santa Ana Huista");
                Municipios.Add("Santa Bárbara");
                Municipios.Add("Santa Cruz Barillas");
                Municipios.Add("Santa Eulalia");
                Municipios.Add("Santiago Chimaltenango");
                Municipios.Add("Soloma");
                Municipios.Add("Tectitán");
                Municipios.Add("Todos Santos Cuchumatán");
                return Municipios;
            }
            else if (departamento == "Izabal")
            {
                Municipios.Add("El Estor");
                Municipios.Add("Livingston");
                Municipios.Add("Los Amates");
                Municipios.Add("Morales");
                Municipios.Add("Puerto Barrios");
                return Municipios;
            }
            else if (departamento == "Jalapa")
            {
                Municipios.Add("Jalapa");
                Municipios.Add("Mataquescuintla ");
                Municipios.Add("Monjas");
                Municipios.Add("San Carlos Alzatate");
                Municipios.Add("San Luis Jilotepeque");
                Municipios.Add("San Manuel Chaparrón");
                Municipios.Add("San Pedro Pinula");
                return Municipios;
            }
            else if (departamento == "Jutiapa")
            {
                Municipios.Add("Agua Blanca");
                Municipios.Add("Asunción Mita");
                Municipios.Add("Atescatempa");
                Municipios.Add("Comapa");
                Municipios.Add("Conguaco");
                Municipios.Add("El Adelanto");
                Municipios.Add("El Progreso");
                Municipios.Add("Jalpatagua");
                Municipios.Add("Jerez");
                Municipios.Add("Jutiapa");
                Municipios.Add("Moyuta");
                Municipios.Add("Pasaco");
                Municipios.Add("Quesada");
                Municipios.Add("Santa Catarina Mita");
                Municipios.Add("Yupiltepeque");
                Municipios.Add("Zapotitlán");

                return Municipios;
            }
            else if (departamento == "Petén")
            {
                Municipios.Add("Flores");
                Municipios.Add("Dolores");
                Municipios.Add("La Libertad");
                Municipios.Add("Melchor de Mencos");
                Municipios.Add("Poptún");
                Municipios.Add("San Andrés");
                Municipios.Add("San Benit");
                Municipios.Add("San Francisco");
                Municipios.Add("San José");
                Municipios.Add("San Luis");
                Municipios.Add("Santa Ana");
                Municipios.Add("Sayaxché");
                return Municipios;
            }
            else if (departamento == "Quetzaltenango")
            {
                Municipios.Add("Quetzaltenango");
                Municipios.Add("Almolonga");
                Municipios.Add("Cabricán");
                Municipios.Add("Cajolá");
                Municipios.Add("Cantel");
                Municipios.Add("Coatepeque");
                Municipios.Add("Colomba");
                Municipios.Add("Concepción Chiquirichapa");
                Municipios.Add("El Palmar");
                Municipios.Add("Flores Costa Cuca");
                Municipios.Add("Génova");
                Municipios.Add("Huitán");
                Municipios.Add("La Esperanza");
                Municipios.Add("Olintepeque");
                Municipios.Add("Palestina de Los Altos");
                Municipios.Add("Salcajá");
                Municipios.Add("San Carlos Sija");
                Municipios.Add("San Francisco La Unión");
                Municipios.Add("San Juan Ostuncalco");
                Municipios.Add("San Martín Sacatepéquez");
                Municipios.Add("San Mateo");
                Municipios.Add("San Miguel Sigüilá");
                Municipios.Add("Sibilia");
                Municipios.Add("Zunil");

                return Municipios;
            }
            else if (departamento == "Quiché")
            {
                Municipios.Add("Canillá	");
                Municipios.Add("Chajul");
                Municipios.Add("Chicamán");
                Municipios.Add("Chiché");
                Municipios.Add("Chinique");
                Municipios.Add("Cunén");
                Municipios.Add("Ixcán");
                Municipios.Add("Pachalum");
                Municipios.Add("Patzité");
                Municipios.Add("Sacapulas");
                Municipios.Add("San Andrés Sajcabajá");
                Municipios.Add("San Antonio Ilotenango");
                Municipios.Add("San Bartolomé");
                Municipios.Add("Jocotenango");
                Municipios.Add("San Juan Cotzal");
                Municipios.Add("San Pedro Jocopilas");
                Municipios.Add("Santa Cruz del Quiché ");
                Municipios.Add("Santa María Joyabaj");
                Municipios.Add("Santa María Nebaj");
                Municipios.Add("Santo Tomás Chichicastenango");
                Municipios.Add("Uspantán");
                Municipios.Add("Zacualpa");

                return Municipios;
            }
            else if (departamento == "Retalhuleu")
            {
                Municipios.Add("Retalhuleu");
                Municipios.Add("San Sebastián");
                Municipios.Add("Santa Cruz Muluá");
                Municipios.Add("San Martín Zapotitlán");
                Municipios.Add("San Felipe");
                Municipios.Add("San Andrés Villa Seca");
                Municipios.Add("Champerico");
                Municipios.Add("Nuevo San Carlos");
                Municipios.Add("El Asintal");

                return Municipios;
            }
            else if (departamento == "Sacatepéquez")
            {
                Municipios.Add("Alotenango");
                Municipios.Add("Antigua Guatemala");
                Municipios.Add("Ciudad Vieja");
                Municipios.Add("Jocotenango");
                Municipios.Add("Magdalena Milpas Altas");
                Municipios.Add("Pastores");
                Municipios.Add("San Antonio Aguas Calientes");
                Municipios.Add("San Bartolomé Milpas Altas");
                Municipios.Add("San Lucas Sacatepéquez");
                Municipios.Add("San Miguel Dueñas");
                Municipios.Add("Santa Catarina Barahona");
                Municipios.Add("Santa Lucía Milpas Altas");
                Municipios.Add("Santa María de Jesús");
                Municipios.Add("Santiago Sacatepéquez");
                Municipios.Add("Santo Domingo Xenacoj");
                Municipios.Add("Sumpango");

                return Municipios;
            }
            else if (departamento == "San Marcos")
            {
                Municipios.Add("Ayutla	");
                Municipios.Add("Catarina");
                Municipios.Add("Comitancillo");
                Municipios.Add("Concepción Tutuapa");
                Municipios.Add("El Quetzal");
                Municipios.Add("El Rodeo");
                Municipios.Add("El Tumblador	");
                Municipios.Add("Esquipulas Palo Gordo	");
                Municipios.Add("Ixchiguán");
                Municipios.Add("La Blanca");
                Municipios.Add("La Reforma");
                Municipios.Add("Malacatán");
                Municipios.Add("Nuevo Progreso");
                Municipios.Add("Ocós");
                Municipios.Add("Pajapita");
                Municipios.Add("Río Blanco");
                Municipios.Add("San Antonio Sacatepéquez");
                Municipios.Add("San Cristóbal Cucho");
                Municipios.Add("San José Ojetenam");
                Municipios.Add("San Lorenzo");
                Municipios.Add("San Marcos");
                Municipios.Add("San Miguel Ixtahuacán	");
                Municipios.Add("San Pablo");
                Municipios.Add("San Pedro Sacatepéquez");
                Municipios.Add("San Rafael Pie de la Cuesta");
                Municipios.Add("Sibinal	");
                Municipios.Add("Sipacapa");
                Municipios.Add("Tacaná");
                Municipios.Add("Tajumulco");
                Municipios.Add("Tejutla");

                return Municipios;
            }
            else if (departamento == "Santa Rosa")
            {
                Municipios.Add("Barberena");
                Municipios.Add("Casillas Santa Rosa");
                Municipios.Add("Chiquimulilla");
                Municipios.Add("Cuilapa");
                Municipios.Add("Guazacapán");
                Municipios.Add("Nueva Santa Rosa");
                Municipios.Add("Oratorio");
                Municipios.Add("Pueblo Nuevo Viñas");
                Municipios.Add("San Juan Tecuaco");
                Municipios.Add("San Rafael Las Flores");
                Municipios.Add("Santa Cruz Naranjo");
                Municipios.Add("Santa María Ixhuatán");
                Municipios.Add("Santa Rosa de Lima");
                Municipios.Add("Taxisco");

                return Municipios;
            }
            else if (departamento == "Sololá")
            {
                Municipios.Add("Sololá");
                Municipios.Add("Concepción");
                Municipios.Add("Nahualá");
                Municipios.Add("Panajachel ");
                Municipios.Add("San Andrés Semetabaj");
                Municipios.Add("San Antonio Palopó");
                Municipios.Add("San José Chacayá");
                Municipios.Add("San Juan La Laguna");
                Municipios.Add("San Lucas Tolimán");
                Municipios.Add("San Marcos La Laguna");
                Municipios.Add("San Pablo La Laguna");
                Municipios.Add("San Pedro La Laguna");
                Municipios.Add("Santa Catarina Ixtahuacán");
                Municipios.Add("Santa Catarina Palopó");
                Municipios.Add("Santa Clara La Laguna");
                Municipios.Add("Santa Cruz La Laguna");
                Municipios.Add("Santa Lucía Utatlán");
                Municipios.Add("Santa María Visitación");
                Municipios.Add("Santiago Atitlán");
                return Municipios;
            }
            else if (departamento == "Suchitepéquez")
            {
                Municipios.Add("Chicacao");
                Municipios.Add("Cuyotenango");
                Municipios.Add("Mazatenango");
                Municipios.Add("Patulul");
                Municipios.Add("Pueblo Nuevo");
                Municipios.Add("Río Bravo");
                Municipios.Add("Samayac");
                Municipios.Add("San Antonio Suchitépequez");
                Municipios.Add("San Bernardino");
                Municipios.Add("San Francisco Zapotitlán");
                Municipios.Add("San Gabriel");
                Municipios.Add("San José El Ídolo");
                Municipios.Add("San Juan Bautista");
                Municipios.Add("San Lorenzo");
                Municipios.Add("San Miguel Panán");
                Municipios.Add("San Pablo Jocopilas");
                Municipios.Add("Santa Bárbara");
                Municipios.Add("Santo Domingo Suchitépequez");
                Municipios.Add("Santo Tomás La Unión");
                Municipios.Add("Zunilito");

                return Municipios;
            }
            else if (departamento == "Totonicapán")
            {
                Municipios.Add("Momostenango");
                Municipios.Add("San Andrés Xecul");
                Municipios.Add("San Bartolo");
                Municipios.Add("San Cristóbal Totonicapán");
                Municipios.Add("San Francisco El Alto");
                Municipios.Add("Santa Lucía La Reforma");
                Municipios.Add("Santa María Chiquimula");
                Municipios.Add("Totonicapán");

                return Municipios;
            }
            else if (departamento == "Zacapa")
            {
                Municipios.Add("Cabañas");
                Municipios.Add("Estanzuela");
                Municipios.Add("Gualán");
                Municipios.Add("Huité");
                Municipios.Add("La Unión");
                Municipios.Add("Río Hondo");
                Municipios.Add("San Diego");
                Municipios.Add("San Jorge");
                Municipios.Add("Teculután");
                Municipios.Add("Usumatlá");
                Municipios.Add("Zacapa ");
                return Municipios;
            }
            else 
            {
                return Municipios = null;
            }
        }

        public string[] fullDepartamento()
        {
            Departamentos = new string[22];
            Departamentos[0] = "Alta Verapaz";
            Departamentos[1] = "Baja Verapaz";
            Departamentos[2] = "Chimaltenango";
            Departamentos[3] = "Chiquimula";
            Departamentos[4] = "El Progreso";
            Departamentos[5] = "Escuintla";
            Departamentos[6] = "Guatemala";
            Departamentos[7] = "Huehuetenango";
            Departamentos[8] = "Izabal";
            Departamentos[9] = "Jalapa";
            Departamentos[10] = "Jutiapa";
            Departamentos[11] = "Petén";
            Departamentos[12] = "Quetzaltenango";
            Departamentos[13] = "Quiché";
            Departamentos[14] = "Retalhuleu";
            Departamentos[15] = "Sacatepéquez";
            Departamentos[16] = "San Marcos";
            Departamentos[17] = "Santa Rosa";
            Departamentos[18] = "Sololá";
            Departamentos[19] = "Suchitepéquez";
            Departamentos[20] = "Totonicapán";
            Departamentos[21] = "Zacapa";
            return Departamentos;
        }
        #endregion
        public double CrearProbabilidad()
        {
            
            double probabilidad = 0.05;
            string text = this.DescripcionDePosibleContagio.ToLower();
            text.ToLower();
            if (text.Contains("viaje a españa"))
            {
                probabilidad = probabilidad + 0.1;
            }
            if (text.Contains("viaje a italia"))
            {
                probabilidad = probabilidad + 0.1;
            }
            if (text.Contains("viaje a francia"))
            {
                probabilidad = probabilidad + 0.1;
            }
            if (text.Contains("viaje a alemania"))
            {
                probabilidad = probabilidad + 0.1;
            }
            if (text.Contains("viaje a rino unido"))
            {
                probabilidad = probabilidad + 0.1;
            }
            if (text.Contains("jefe contagiado"))
            {
                probabilidad = probabilidad + 0.15;
            }
            if (text.Contains("amigo contagiado"))
            {
                probabilidad = probabilidad + 0.15;
            }
            if (text.Contains("vecino contagiado"))
            {
                probabilidad = probabilidad + 0.15;
            }
            if (text.Contains("compañero de trabajajo contagiado"))
            {
                probabilidad = probabilidad + 0.15;
            }
            if (text.Contains("familiar contagiado"))
            {
                probabilidad = probabilidad + 0.30;
            }

            return probabilidad;
        }
        public string Diagnosticar()
        {
            var prob = CrearProbabilidad();
            this.Probabilidad = prob;
            string[] arrayvalores = new string[] { "Confirmado", "Sospechoso" };
            double[] pesos = new double[] { prob, 1-prob };
            int resultado = 0;
            double[] pesosAcumulados = pesos.Aggregate((IEnumerable<double>)new List<double>(),
                        (x, i) => x.Concat(new[] { x.LastOrDefault() + i })).ToArray();
            int[] resultadoaleatorio = new int[4];
            for (int i = 0; i < 1; i++)
            {
                resultado = pesosAcumulados.ToList().IndexOf(pesosAcumulados.Where(x => x > Storage.Instance.RandomParaDiagnostivo.NextDouble() * pesos.Sum()).FirstOrDefault());
            }
            if (arrayvalores[resultado] == "Confirmado")
            {
                Storage.Instance.Contagiados++;
            }
            else
            {
                Storage.Instance.Sospechos++;
            }
            return arrayvalores[resultado];
        }
        public void AsignarHospital()
        {
            var depto = this.Departamento;
            if ( depto == "Petén" || depto == "Alta Verapaz"||depto == "Quiché")
            {
                this.HospitalDeAtencion = "PETEN";
            }
            else if (depto == "Guatemala" || depto == "Baja Verapaz" || depto == "El Progreso" || depto == "Jalapa" || depto == "Santa Rosa")
            {
                this.HospitalDeAtencion = "GUATEMALA";
            }
            else if (depto == "Zacapa" || depto == "Izabal" || depto == "Chiquimula" || depto == "Jutiapa")
            {
                this.HospitalDeAtencion = "ZACAPA";
            }
            else if (depto == "Quetzaltenango" || depto == "Huehuetenango" || depto == "San Marcos" || depto == "Totonicapán" || depto == "Retalhuleu")
            {
                this.HospitalDeAtencion = "QUETZALTENANGO";
            }
            else if (depto == "Escuintla" || depto == "Sacatepéquez" || depto == "Chimaltenango" || depto == "Sololá" || depto == "Suchitepéquez")
            {
                this.HospitalDeAtencion = "ESCUINTLA";
            }
        }

        public void Recuperar()
        {
            this.Estado = "Recuperado";
            Storage.Instance.recuperados++;
        }

        public Paciente Busqueda(long CUI)
        {
            Paciente buscado = new Paciente();
            if (Storage.Instance.RegistroGeneral != null)
            {
                    buscado.CUI = CUI;
                    var encontrado = Storage.Instance.RegistroGeneral.search(buscado, CompararPorCUI);
                    return encontrado.Value;
            }
            else
            {
                return buscado;
            }
        }
        public List<Paciente> BusquedaAvanzada(string parametroDeBusqueda)
        {
            Paciente buscado = new Paciente();
            List<Paciente> encontrado = new List<Paciente>();
            if (Storage.Instance.RegistroGeneral != null)
            {
                
                buscado.Nombre = parametroDeBusqueda;
                encontrado = Storage.Instance.RegistroGeneral.where(buscado, CompararPorNombre, 0);
                if (encontrado.Count > 0)
                {
                    return encontrado;
                }
                else
                {
                    buscado.Apellido = parametroDeBusqueda;
                    encontrado = Storage.Instance.RegistroGeneral.where(buscado, CompararPorApellido, 0);
                    return encontrado;
                }
            }
            else
            {
                return encontrado;
            }
        }

        private void AsignarCategoria()
        {
            if (this.Estado== "Confirmado")
            {
                if (Edad <= 0)
                {
                    this.Categoria = 2;
                }
                else if (Edad >= 27 && Edad <= 59) 
                {
                    this.Categoria = 3;
                }
                else if (Edad >= 60)
                {
                    this.Categoria = 1;
                }
                else if (Edad > 0 && Edad < 27) 
                {
                    this.Categoria = 5;
                }
                else
                {

                }
            }
            else if (this.Estado== "Sospechoso")
            {
                if (Edad <= 0)
                {
                    this.Categoria = 6;
                }
                else if (Edad >= 27 && Edad <= 59)
                {
                    this.Categoria = 7;
                }
                else if (Edad >= 60)
                {
                    this.Categoria = 4;
                }
                else if (Edad > 0 && Edad < 27)
                {
                    this.Categoria = 8;
                }
            }
          
        }

        private void IncertarEnCola()
        {
            if (this.HospitalDeAtencion == "PETEN")
            {
                if (Estado== "Confirmado")
                {
                    Storage.Instance.ContagiadosPetenEspera.Insert(this, CompareByCategory);
                }
                else if (Estado == "Sospechoso")
                {
                    Storage.Instance.SospechososPetenEspera.Insert(this, CompareByCategory);
                }
            }
            if (this.HospitalDeAtencion == "GUATEMALA")
            {
                if (Estado == "Confirmado")
                {
                    Storage.Instance.ContagiadosCapitalEspera.Insert(this, CompareByCategory);
                }
                else if (Estado == "Sospechoso")
                {
                    Storage.Instance.SospechososCapitalEspera.Insert(this, CompareByCategory);
                }
            }
            if (this.HospitalDeAtencion == "ZACAPA")
            {
                if (Estado == "Confirmado")
                {
                    Storage.Instance.ContagiadosOrienteEspera.Insert(this, CompareByCategory);
                }
                else if (Estado == "Sospechoso")
                {
                    Storage.Instance.SospechososOrienteEspera.Insert(this, CompareByCategory);
                }
            }
            if (this.HospitalDeAtencion == "QUETZALTENANGO")
            {
                if (Estado == "Confirmado")
                {
                    Storage.Instance.ContagiadoQuetzaltenagoEspera.Insert(this, CompareByCategory);
                }
                else if (Estado == "Sospechoso")
                {
                    Storage.Instance.SospechososQuetzaltenagoEspera.Insert(this, CompareByCategory);
                }
            }
            if (this.HospitalDeAtencion == "ESCUINTLA")
            {
                if (Estado == "Confirmado")
                {
                    Storage.Instance.ContagiadosEscuintlaEspera.Insert(this, CompareByCategory);
                }
                else if (Estado == "Sospechoso")
                {
                    Storage.Instance.SospechososEscuintlaEspera.Insert(this, CompareByCategory);
                }
            }

        }
        public bool Guardar()
        {
            try
            {
                this.Estado = Diagnosticar();
                AsignarCategoria();
                CrearProbabilidad();
                AsignarHospital();
                Storage.Instance.RegistroGeneral.Insert(this, CompararPorCUI);
                IncertarEnCola();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        #region
        public static Comparison<Paciente> CompararPorCUI = delegate (Paciente indice1, Paciente indice2)
        {
            return indice1.CUI.CompareTo(indice2.CUI);
        };
        public static Comparison<Paciente> CompararPorNombre = delegate (Paciente indice1, Paciente indice2)
        {
            return indice1.Nombre.CompareTo(indice2.Nombre);
        };
        public static Comparison<Paciente> CompararPorApellido = delegate (Paciente indice1, Paciente indice2)
        {
            return indice1.Apellido.CompareTo(indice2.Apellido);
        };

        public delegate int Compare(Paciente value1, Paciente value2);
        public static Compare CompareByCategory = CompareTo;

        public static int CompareTo(Paciente father, Paciente song)
        {
            int prueva = song.Categoria.CompareTo(father.Categoria);
            return song.Categoria.CompareTo(father.Categoria);
        }
        #endregion

    }
}