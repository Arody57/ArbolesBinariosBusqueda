using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasArboles
{
    public class EquipoDesarrollo: Comparador
    {
        public String nombreTarea { get; set; }
        public String duracion { get; set; }
        public String porcentajeAvance { get; set; }
        public String NombreDesarrollador { get; set; }

        public EquipoDesarrollo()
        {
        }
        public EquipoDesarrollo(String nombreTask, String duracionTarea, String porcentAvance, String nombreProgramador)
        {
            nombreTarea = nombreTask;
            duracion = duracionTarea;
            porcentajeAvance = porcentAvance;
            NombreDesarrollador = nombreProgramador;
        }

        public bool igualQue(object q)
        {
            EquipoDesarrollo equipoDrllo = (EquipoDesarrollo)q;
            return nombreTarea.CompareTo(equipoDrllo.nombreTarea) == 0 ? true : false;
        }

        public bool menorQue(object q)
        {
            EquipoDesarrollo equipoDrllo = (EquipoDesarrollo)q;
            return nombreTarea.CompareTo(equipoDrllo.nombreTarea) < 0 ? true : false;
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            EquipoDesarrollo equipoDrllo = (EquipoDesarrollo)q;
            return nombreTarea.CompareTo(equipoDrllo.nombreTarea) > 0 ? true : false;
            //return idTarea > desarrolladorAux.idTarea;
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return " [ \n " + "Nombre Tarea: \n" + nombreTarea + "\nDuracion: \n" + duracion + " min. \n" + "Porcentaje Avance: \n" + porcentajeAvance + "% \n" + "Programador Asignado: \n" + NombreDesarrollador + " \n " + " ] \n ";
        }
    }
}
