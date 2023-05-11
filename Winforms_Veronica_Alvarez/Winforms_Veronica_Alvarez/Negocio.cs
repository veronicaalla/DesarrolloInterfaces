using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Veronica_Alvarez
{
    internal class Negocio
    {
        public Empresa[] BuscarEmpresas()
        {
            PracticasContext bd = new PracticasContext();
            return bd.Empresas.ToArray();
        }

        public void Crear(Empresa nuevaEmpresa)
        {
            PracticasContext bd = new PracticasContext();
            bd.Empresas.Add(nuevaEmpresa);
            bd.SaveChanges();
        }

        public void Actualizar(Empresa empresa)
        {
            PracticasContext bd = new PracticasContext();
            Empresa aux = bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresa.EmpresaId);
            if (aux != null)
            {
                bd.Entry(aux).CurrentValues.SetValues(empresa);
                bd.SaveChanges();
            }
        }

        public void Borrar(Empresa empresaBorrar)
        {
            PracticasContext bd = new PracticasContext();
            Empresa aux = bd.Empresas.FirstOrDefault(x => x.EmpresaId == empresaBorrar.EmpresaId);
            if (aux != null)
            {
                if (bd.Alumnos.Any(x => x.EmpresaId == empresaBorrar.EmpresaId))
                {
                    throw new PracticasException("Antes de eliminar la empresa debe eliminar los alumnos asociados");
                }

                bd.Empresas.Remove(aux);
                bd.SaveChanges();
            }
        }

        public Alumno[] BuscarAlumnos()
        {
            PracticasContext bd = new PracticasContext();
            return bd.Alumnos.ToArray();
        }

        public void Crear(Alumno nuevoAlumno)
        {
            PracticasContext bd = new PracticasContext();
            bd.Alumnos.Add(nuevoAlumno);
            bd.SaveChanges();
        }

        public void Actualizar(Alumno alumno)
        {
            PracticasContext bd = new PracticasContext();
            Alumno aux = bd.Alumnos.FirstOrDefault(x => x.AlumnoId == alumno.AlumnoId);
            if (aux != null)
            {
                bd.Entry(aux).CurrentValues.SetValues(alumno);
                bd.SaveChanges();
            }
        }

        public void Borrar(Alumno alumnoBorrar)
        {
            PracticasContext bd = new PracticasContext();
            Alumno aux = bd.Alumnos.FirstOrDefault(x => x.AlumnoId == alumnoBorrar.AlumnoId);
            if (aux != null)
            {
                bd.Alumnos.Remove(aux);
                bd.SaveChanges();
            }
        }
    }
}
