using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NominaProyectoCurso.bll
{
    internal class LogicaNomina
    {

        static public decimal calcularSalarioTotal(decimal monthlyWage, decimal overtimeWage, decimal tenureWage)
        {
            return monthlyWage + overtimeWage + tenureWage;
        }


        static public decimal calcularSalarioHorasExtras(decimal monthlyWage, decimal overtime)
        {
            decimal factor = (360 / 12) * 8;

            decimal extraHourRate = (monthlyWage / factor) * 2;

            decimal overtimeWage = extraHourRate * overtime;

            return overtimeWage;

        }


        static public decimal calcularInssLaboral(decimal totalRevenue)
        {
            decimal employeeInss, rate;

            rate = (decimal)0.07;
            employeeInss = totalRevenue * rate;

            return employeeInss;
        }




        static public decimal calcularIR(decimal totalRevenue /* Salario total */, decimal employeeInss /*Inss*/)
        {
            //deductible
            decimal taxableIncome;
            decimal yearlyWage;
            double aplicableRate;
            decimal baseTax;
            decimal anualIR;


            decimal salariosSinDeducible;

            decimal deductible;
            
            //Operaciones comienzan.
            taxableIncome/*Base aplicable*/ = (totalRevenue - employeeInss);

            yearlyWage/*Base aplicable anual*/ = (taxableIncome * 12);

            if (yearlyWage >= 1 && yearlyWage <= 100000)
            {

                baseTax = 0;
                deductible = 0;
                aplicableRate = 0;

                salariosSinDeducible = yearlyWage - deductible;


                anualIR = (salariosSinDeducible * (decimal)aplicableRate) + baseTax;

                return anualIR / 12;


            }
            else if (yearlyWage >= 100001 && yearlyWage <= 200000)
            {

                baseTax = 0;
                deductible = 100000;
                aplicableRate = 0.15;

              
                salariosSinDeducible = yearlyWage - deductible;

                anualIR = (salariosSinDeducible * (decimal)aplicableRate) + baseTax;

                return anualIR / 12;



            }
            else if (yearlyWage >= 200001 && yearlyWage <= 300000)
            {
                baseTax = 15000;
                deductible = 200000;
                aplicableRate = 0.20;

                salariosSinDeducible = yearlyWage - deductible;
                anualIR = (salariosSinDeducible * (decimal)aplicableRate) + baseTax;

                return anualIR / 12;

            }
            else if (yearlyWage >= 300001 && yearlyWage <= 500000)
            {
                baseTax = 45000;
                deductible = 300000;
                aplicableRate = 0.25;

                salariosSinDeducible = yearlyWage - deductible;
                anualIR = (salariosSinDeducible * (decimal)aplicableRate) + baseTax;

                return anualIR / 12;
            }
            else if (yearlyWage >= 500001)
            {

                baseTax = 45000;
                deductible = 500000;
                aplicableRate = 0.30;

                salariosSinDeducible = yearlyWage - deductible;

                anualIR = (salariosSinDeducible * (decimal)aplicableRate) + baseTax;

                return anualIR / 12;

            }
            else
            {
                return 0;
            }


        }



        static public decimal calcularInssPatronal(decimal totalRevenue)
        {
            decimal managmentInss;
            managmentInss = totalRevenue * 0.225M;
            return managmentInss;
        }




        static public decimal calcularInatec(decimal totalRevenue)
        {
            decimal inatec;
            inatec = totalRevenue * 0.02M;
            return inatec;
        }



        static public decimal calcularTreceavoMes(decimal monthlyWage)
        {
            return monthlyWage * 0.08333M;
        }


        static public decimal calcularVacaciones(decimal monthlyWage)
        {
            decimal vacaciones = 0;
            vacaciones = monthlyWage / 12;
            return vacaciones;
        }

        static public decimal calcularSalarioAntiguedad(int tenure/*Antiguedad*/, decimal monthlyWage/*Salario mensual*/)
        {
            switch (tenure)
            {
                case 0:
                    return 0.0M * monthlyWage;

                case 1:
                    return 0.03M * monthlyWage;

                case 2:
                    return 0.05M * monthlyWage;

                case 3:
                    return 0.07M * monthlyWage;

                case 4:
                    return 0.09M * monthlyWage;

                case 5:
                    return 0.10M * monthlyWage;

                case 6:
                    return 0.11M * monthlyWage;

                case 7:
                    return 0.12M * monthlyWage;

                case 8:
                    return 0.13M * monthlyWage;

                case 9:
                    return 0.14M * monthlyWage;

                case 10:
                    return 0.15M * monthlyWage;

                case 11:
                    return 0.155M * monthlyWage;

                case 12:
                    return 0.16M * monthlyWage;

                case 13:
                    return 0.165M * monthlyWage;

                case 14:
                    return 0.17M * monthlyWage;

                case 15:
                    return 0.175M * monthlyWage;

                case 16:
                    return 0.18M * monthlyWage;

                case 17:
                    return 0.185M * monthlyWage;


                case 18:
                    return 0.19M * monthlyWage;

                case 19:
                    return 0.195M * monthlyWage;

                case 20:
                    return 0.20M * monthlyWage;

                default:
                    MessageBox.Show("Numero de años inválido! Se ingresa como si tuviese 0 años.");
                    return 0 * monthlyWage;



            }

        }

        static public decimal calcularSalarioMensual(decimal wage, decimal regularHorus)
        {
            decimal monthlyWage = wage * regularHorus;

            return monthlyWage;
        }


    }
}
