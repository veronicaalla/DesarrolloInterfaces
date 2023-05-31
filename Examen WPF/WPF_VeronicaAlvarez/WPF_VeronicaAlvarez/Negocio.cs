using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_VeronicaAlvarez
{
    internal class Negocio
    {
        public void ActualizarDesarrollador(Desarrollador desarrolladorActualizado)
        {
            Parcial2Context db = new Parcial2Context();
            Desarrollador desarradorDB = db.Desarrolladores.FirstOrDefault(x => x.DesarrolladorId == desarrolladorActualizado.DesarrolladorId);

            if (desarradorDB != null)
            {
                db.Entry(desarradorDB).CurrentValues.SetValues(desarrolladorActualizado);
                db.SaveChanges();
            }
        }

        public void ActualizarTarea(Tarea tareaActualizada)
        {
            Parcial2Context db = new Parcial2Context();
            Tarea tareaDB = db.Tareas.FirstOrDefault(x => x.TareaId == tareaActualizada.TareaId);

            if (tareaDB != null)
            {
                db.Entry(tareaDB).CurrentValues.SetValues(tareaActualizada);
                db.SaveChanges();
            }
        }

        public void CrearDesarrollador(Desarrollador desarrollador)
        {
            Parcial2Context db = new Parcial2Context();
            db.Desarrolladores.Add(desarrollador);
            db.SaveChanges();
        }

        public void CrearTarea(Tarea tarea)
        {
            Parcial2Context db = new Parcial2Context();
            db.Tareas.Add(tarea);
            db.SaveChanges();
        }

        public void EliminarDesarrollador(Desarrollador desarrollador)
        {
            Parcial2Context db = new Parcial2Context();
            //Obtenemos las tareas asociadas a el desarrollador
            List<Tarea> listaTareas = desarrollador.Tareas.ToList();
            foreach (Tarea tarea in listaTareas)
            {
                //Eliminamos las tareas
                EliminarTarea(tarea);
            }
            //Eliminamos al desarrollador
            db.Desarrolladores.Remove(desarrollador);
            db.SaveChanges();
        }

        public void EliminarTarea(Tarea tarea)
        {
            Parcial2Context db = new Parcial2Context();
            db.Tareas.Remove(tarea);
            db.SaveChanges();
        }

        public Desarrollador[] ObtenerDesarrollades()
        {
            Parcial2Context db = new Parcial2Context();
            return db.Desarrolladores.ToArray();
            //return null;
        }

        public Tarea[] ObtenerTareas()
        {
            Parcial2Context db = new Parcial2Context();
            return db.Tareas.ToArray();
            //return null;
        }

    }
}
