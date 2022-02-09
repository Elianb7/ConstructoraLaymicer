using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio :DbContext
    {

        public Repositorio(DbContextOptions<Repositorio> options)
            : base(options)
        {

        }
        public DbSet<Cita> citas { get; set; }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Medico> medicos { get; set; }
        public DbSet<Dia> dias { get; set; }
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Especialidad> especialidades { get; set; }
        public DbSet<InformacionPaciente> informacionpacientes { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-BF9LF28;Integrated Security=true; Initial Catalog=CitasMedicasV3");
        //}
        protected override void OnModelCreating(ModelBuilder model)
        {
            //CITA - PACIENTE           ----UNO A  VARIOS
            model.Entity<Cita>()
            .HasOne(cita => cita.Paciente)
            .WithMany(paciente => paciente.Citas)
            .OnDelete(DeleteBehavior.NoAction)          //DESACTIVAR BORRADO EN CASCADA
            .HasForeignKey(cita => cita.PacienteId);
            
            //CITA - MEDICO             ----UNO A  VARIOS
            model.Entity<Cita>()
            .HasOne(cita => cita.Medico)
            .WithMany(medico => medico.Citas)
            .HasForeignKey(cita => cita.MedicoId);
            
            //MEDICO - ESPECIALIDAD     ----UNO A  VARIOS
            model.Entity<Medico>()
            .HasOne(medico => medico.Especialidad)
            .WithMany(especialidad => especialidad.Medicos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(medico => medico.EspecialidadId);
            
            // CLAVE PRIMARIA COMPUESTA
            model.Entity<Dia>()               
               .HasKey(dh => new { dh.HorarioId, dh.MedicoId });
            
            //DIAS - HORARIO       ----UNO A  VARIOS
            model.Entity<Dia>()            
            .HasOne(dia => dia.Horario)
            .WithMany(horario => horario.Dias)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(dia => dia.HorarioId);
            
            // MEDICO - DIA         ----UNO A  VARIOS
            model.Entity<Dia>()            
            .HasOne(dia => dia.Medico)
            .WithMany(medico => medico.Dias)
            .OnDelete(DeleteBehavior.NoAction)      
            .HasForeignKey(dia => dia.MedicoId);

            // PACIENTE - INFORMACION PACIENTE      ----UNO A UNO
            model.Entity<Paciente>()
            .HasOne<InformacionPaciente>(inf => inf.InformacionPaciente)
            .WithOne(p => p.Paciente)
            .HasForeignKey<InformacionPaciente>(p => p.InformacionPacienteId);
        }
    }
}
