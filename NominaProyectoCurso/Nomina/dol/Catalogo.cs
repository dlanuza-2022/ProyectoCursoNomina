using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaProyectoCurso.dol
{
    internal class Catalogo
    {

        public Catalogo() {

            empleados = new List<Empleado>();
            
        }


        public List<Empleado> getEmpleados() { return empleados; }
        public List<Empleado> setEmpleados(List<Empleado> empleados) => this.empleados = empleados;


      

        public void addEmpleado(Empleado empleado) 
        {
            empleados.Add(empleado);  

        }


      

        public void removeEmpleado(int indice)
        {
            empleados.RemoveAt(indice);
        }


  


        public void setEmpleadoAt(int indice, Empleado empleado)
        {
            empleados.Insert(indice, empleado);
        }

        public void deleteList()
        {
            empleados.Clear();

        }

        private List<Empleado> empleados;
       
    }

}
