
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaProyectoCurso.dol;

namespace NominaProyectoCurso.bll
{
    internal class Application
    {
        public static Catalogo ctl = new Catalogo();

        static public void addEmpleado(Empleado emp)
        {
            ctl.addEmpleado(emp);
        }
        

        static public void addEmpleadoAt(int indice, Empleado emp)
        {
            ctl.setEmpleadoAt(indice, emp);
        }

        static public void removeEmpleadoAt(int indice)
        {
            ctl.removeEmpleado(indice);
        }

        static public void deleteList()
        {
            ctl.deleteList();
        }
    }
}
