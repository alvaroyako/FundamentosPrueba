﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HospitalLinq.Models;

namespace HospitalLinq.Data
{
    public class PlantillasContext
    {
        private string cadenaconexion;
        private SqlDataAdapter adplantilla;
        private DataTable TablaPlantilla;

        public PlantillasContext()
        {
            this.cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            string sql = "select*from plantilla";
            this.adplantilla = new SqlDataAdapter(sql, cadenaconexion);
            this.TablaPlantilla = new DataTable();
            this.adplantilla.Fill(this.TablaPlantilla);
        }

        public ModelPlantillas GetPlantillaHospital(int idhospital)
        {
            var consulta = from datos in this.TablaPlantilla.AsEnumerable()
                           where datos.Field<int>("Hospital_Cod") == idhospital
                           select datos;
            List<Plantilla> plantillas = new List<Plantilla>();
            foreach (var row in consulta)
            {
                Plantilla plan = new Plantilla();
                plan.IdPlantilla = row.Field<int>("Empleado_No");
                plan.Apellido = row.Field<string>("Apellido");
                plan.Funcion = row.Field<string>("Funcion");
                plan.Salario = row.Field<int>("Salario");
                plan.Turno = row.Field<string>("T");
                plan.IdHospital = row.Field<int>("Hospital_Cod");
                plantillas.Add(plan);
            }
            int personas = plantillas.Count();
            int suma = plantillas.Sum(x=>x.Salario);
            double media = plantillas.Average(z => z.Salario);
            ModelPlantillas modelPlantillas = new ModelPlantillas();
            modelPlantillas.Plantillas = plantillas;
            modelPlantillas.SumaSalarial = suma;
            modelPlantillas.MediaSalarial = media;
            modelPlantillas.Personas = personas;
            return modelPlantillas;
        }
    }
}
