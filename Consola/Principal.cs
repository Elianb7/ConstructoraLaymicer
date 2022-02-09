using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Principal
    {
        static void Main(string[] args)
        {            
          
            /*
            //lista de pacientes
            Paciente p1 = new Paciente() {
                Cedula = 1812234562,
                Nombre = "Pablo Marmol", 
                Email = "pm@gmail.com",               
            };
            //lista de pacientes
            Paciente p2 = new Paciente()
            {
                Cedula = 1721234518,
                Nombre = "Maria Aguirre",
                Email = "mag@gmail.com",               
               
            };
            //lista de informacion de paciente
            InformacionPaciente ip1 = new InformacionPaciente()
            {
                Ciudad = "Quito",
                Telefono_Convencional = "023456724",
                Telefono_Movil = "0982357912",
                Paciente = p1
            };
            //lista de informacion de paciente
            InformacionPaciente ip2 = new InformacionPaciente()
            {
                Ciudad = "Quito",
                Telefono_Convencional = "025452112",
                Telefono_Movil = "0896675791",
                Paciente = p2
            };
            //lista especialidad            
            Especialidad e1 = new Especialidad()
            {
                Nombre = "Odontologia",               
            };
            Especialidad e2 = new Especialidad()
            {
                Nombre = "Neurología",
            };

            //lista de medico
            Medico m1 = new Medico() {
                Cedula = 1701212216,
                Nombre = "Jesús Carrera", 
                Telefono = "023123831", 
                Email = "jes@gmail.com",
                Especialidad = e1                
            };
            //lista de medico
            Medico m2 = new Medico()
            {
                Cedula = 1722467111,
                Nombre = "Freddy Oyana",
                Telefono = "026243833",
                Email = "fsssqq@g.com",
                Especialidad = e2
            };
            //horarios del medico
            Horario h1 = new Horario()
            {
                Hora_Inicio= new DateTime(2022,01,01, 7, 0, 0, 0),
                Hora_Fin = new DateTime(2022, 01, 01, 9, 0, 0, 0),
                Cupos_Totales=3
            };
            Horario h2 = new Horario()
            {
                Hora_Inicio = new DateTime(2022, 01, 01, 10, 0, 0, 0),
                Hora_Fin = new DateTime(2022, 01, 01, 12, 0, 0, 0),
                Cupos_Totales = 2
            };
            Dia d1 = new Dia()
            {   
                dia="Lunes",
                Medico=m1,
                Horario=h1
            };
            Dia d2 = new Dia()
            {
                dia = "Martes",
                Medico = m2,
                Horario = h2
            };

            //datos de citas
            Cita c1 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 01, 25),
                Fecha_Registro = new DateTime(2022, 01, 18),
                Num_Orden = "OT001",               
                Paciente = p1,
                Medico = m1
            };
            Cita c2 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 01, 25),
                Fecha_Registro = new DateTime(2022, 01, 18),
                Num_Orden = "OT002",
                Paciente = p2,
                Medico = m2
            };

            //grabar las listas de datos
            Repositorio repos = new Repositorio();
            repos.informacionpacientes.Add(ip1);
            repos.informacionpacientes.Add(ip2);
            repos.dias.Add(d1);
            repos.dias.Add(d2);
            repos.citas.Add(c1);
            repos.citas.Add(c2);
            repos.SaveChanges(); */
        }
        
        
    }
}