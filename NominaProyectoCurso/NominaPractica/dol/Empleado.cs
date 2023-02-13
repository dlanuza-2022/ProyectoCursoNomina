using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaProyectoCurso.dol
{

    public enum Departamento {Ventas, Administración}

    public class Empleado
    {
        /*Constructor vacio*/
        public Empleado()
        {

        }


        /*Properties
         Usamos las "Properties" del lenguaje y creamos una para cada variable de modo que luego en vez de
         acceder a la variable encapsulada directamente, la leeremos y escribiremos en ella usando el "propertie".
         */
        public int NumInss
        {
            get { return numInss; }
            set { numInss = value; }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public decimal SalarioXHora
        {
            get { return salarioXHora; }
            set { salarioXHora = value; }
        }

        public decimal SalarioMensual
        {
            get { return salarioMensual; }
            set
            {
                salarioMensual = value;
            }
        }

        public double HorasExtra
        {
            get { return horasExtra; }
            set
            {
                horasExtra = value;
            }
        }

        public decimal IngresoHorasExtra
        {
            get { return ingresoHorasExtra; }
            set
            {
                ingresoHorasExtra = value;
            }
        }

        public int Antiguedad
        {
            get { return antiguedad; }
            set
            {
                antiguedad = value;
            }
        }

        public decimal IngresoAntiguedad
        {
            get { return ingresoAntiguedad; }
            set { ingresoAntiguedad = value; }

        }

        public decimal SalarioTotal
        {
            get { return salarioTotal; }
            set
            {
                salarioTotal = value;
            }
        }


        public decimal InssLaboral
        {
            get { return inssLaboral; }
            set
            {
                inssLaboral = value;
            }
        }


        public decimal ImpuestoRenta
        {
            get { return impuestoRenta; }
            set
            {
                impuestoRenta = value;
            }
        }

        public decimal TotalDeducciones
        {
            get { return totalDeducciones; }
            set { totalDeducciones = value; }
        }


        public decimal NetoARecibir
        {
            get { return netoARecibir; }
            set { netoARecibir = value; }
        }


        public decimal InssPatronal
        {
            get { return inssPatronal; }
            set
            {
                inssPatronal = value;
            }
        }


        public decimal Inatec
        {
            get { return inatec; }
            set
            {
                inatec = value;
            }
        }


        public decimal Vacaciones
        {
            get { return vacaciones; }
            set
            {
                vacaciones = value;
            }
        }

        public decimal TreceavoMes
        {
            get { return treceavoMes; }
            set
            {
                treceavoMes = value;
            }
        }
        
        public double HorasRegulares
        {
            get { return horasRegulares; }
            set { horasRegulares = value; }
        }
        
        public void setDepartamento(Departamento departamento)
        {
            this.departamento = departamento;
        }
      
        public Departamento getDepartamento()
        {
            return departamento;
        }


        /*  DATOS NOMINA */
        private int numInss;
        private string nombre;
        private string apellido;
        private string cargo;

        /*Renumeración bruta*/
        private decimal salarioXHora;
        private decimal salarioMensual;
        private double horasRegulares; //Semana
        private double horasExtra; //Mensuales
        private decimal ingresoHorasExtra;
        private int antiguedad;   
        private decimal ingresoAntiguedad;   
        private decimal salarioTotal; // Salario mensual + ingreso horas extra + ingreso antiguedad 

        /*Deducciones*/
        private decimal inssLaboral;  // salario * 7% (0.07)
        private decimal impuestoRenta; 
        private decimal totalDeducciones; // IR + Inss

        /*Neto a recibir*/
        private decimal netoARecibir; 

        /*Impuestos al empleador*/
        private decimal inssPatronal; // salario mensual * 22.5% 
        private decimal inatec; // salario mensual * 2%


        /*Prestaciones sociales*/
        private decimal vacaciones; //salario mensual / 12
        private decimal treceavoMes; // salario mensual * 0.08333


        //Separar por departamentos: Ventas, administración, produccion, etc...
        private Departamento departamento;
        



    }
}
