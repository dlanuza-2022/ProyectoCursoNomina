using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NominaPractica;

namespace NominaProyectoCurso.dal
{
    internal class EmpleadosDAL
    {

        public  EmpleadosDAL()
        {

        }


        public void openEmpleados(DataGridView miTabla1, DataGridView miTabla2, string pathFile)
        {
            string[] row1/*Fila1*/ = new string[9];
            string[] row2 = new string[9];
            //int contador = 1;
            int iRow = 2;

            try
            {
                SLDocument miArchivo = new SLDocument(pathFile);

                while (!string.IsNullOrEmpty(miArchivo.GetCellValueAsString(iRow, 1)))
                {


                    row1[0] = miArchivo.GetCellValueAsString(iRow, 1);
                    row1[1] = miArchivo.GetCellValueAsString(iRow, 2);
                    row1[2] = miArchivo.GetCellValueAsString(iRow, 3);
                    row1[3] = miArchivo.GetCellValueAsString(iRow, 4);
                    row1[4] = miArchivo.GetCellValueAsString(iRow, 5);
                    row1[5] = miArchivo.GetCellValueAsString(iRow, 6);
                    row1[6] = miArchivo.GetCellValueAsString(iRow, 7);
                    row1[7] = miArchivo.GetCellValueAsString(iRow, 8);
                    row1[8] = miArchivo.GetCellValueAsString(iRow, 9);

                    row2[0] = miArchivo.GetCellValueAsString(iRow, 1);
                    row2[1] = miArchivo.GetCellValueAsString(iRow, 10);
                    row2[2] = miArchivo.GetCellValueAsString(iRow, 11);
                    row2[3] = miArchivo.GetCellValueAsString(iRow, 12);
                    row2[4] = miArchivo.GetCellValueAsString(iRow, 13);
                    row2[5] = miArchivo.GetCellValueAsString(iRow, 14);
                    row2[6] = miArchivo.GetCellValueAsString(iRow, 15);
                    row2[7] = miArchivo.GetCellValueAsString(iRow, 16);
                    row2[8] = miArchivo.GetCellValueAsString(iRow, 17);


                    miTabla1.Rows.Add(row1);
                    miTabla2.Rows.Add(row2);

                    //List.add(objetoPersona);

                    iRow++;
                    //contador++;
                }

                //miTabla1.DataSource = List;
                //miTabla2.DataSource = List;

                

                /*Se debe construir un objeto usando POO*/
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("Error con la dirección de archivo! Se intentará con la direccion estandar.");

                try
                {
                    string standartPathFile = AppDomain.CurrentDomain.BaseDirectory + "miLista.xlsx";

                    SLDocument miArchivo = new SLDocument(standartPathFile);

                    while (!string.IsNullOrEmpty(miArchivo.GetCellValueAsString(iRow, 1)))
                    {


                        row1[0] = miArchivo.GetCellValueAsString(iRow, 1);
                        row1[1] = miArchivo.GetCellValueAsString(iRow, 2);
                        row1[2] = miArchivo.GetCellValueAsString(iRow, 3);
                        row1[3] = miArchivo.GetCellValueAsString(iRow, 4);
                        row1[4] = miArchivo.GetCellValueAsString(iRow, 5);
                        row1[5] = miArchivo.GetCellValueAsString(iRow, 6);
                        row1[6] = miArchivo.GetCellValueAsString(iRow, 7);
                        row1[7] = miArchivo.GetCellValueAsString(iRow, 8);
                        row1[8] = miArchivo.GetCellValueAsString(iRow, 9);

                        row2[0] = miArchivo.GetCellValueAsString(iRow, 1);
                        row2[1] = miArchivo.GetCellValueAsString(iRow, 10);
                        row2[2] = miArchivo.GetCellValueAsString(iRow, 11);
                        row2[3] = miArchivo.GetCellValueAsString(iRow, 12);
                        row2[4] = miArchivo.GetCellValueAsString(iRow, 13);
                        row2[5] = miArchivo.GetCellValueAsString(iRow, 14);
                        row2[6] = miArchivo.GetCellValueAsString(iRow, 15);
                        row2[7] = miArchivo.GetCellValueAsString(iRow, 16);
                        row2[8] = miArchivo.GetCellValueAsString(iRow, 17);


                        miTabla1.Rows.Add(row1);
                        miTabla2.Rows.Add(row2);

                        //List.add(objetoPersona);

                        iRow++;
                        //contador++;
                    }

                    //miTabla1.DataSource = List;
                    //miTabla2.DataSource = List;


                    /*Se debe construir un objeto usando POO*/
                }catch(FileNotFoundException ex2)
                {
                    MessageBox.Show("Error! No se pudo cargar ningun archivo.");
                }



            }


        }




        public void saveEmpleados(DataGridView miTabla1, DataGridView miTabla2, string pathFile)
        {

            if (File.Exists(pathFile))
            {
                try
                {
                    File.Delete(pathFile);
                }catch(Exception e)
                {
                    MessageBox.Show("Error con el archivo!");
                }
            }

            /*Codigo para guardar*/
            SLDocument oSLDocument = new SLDocument();
            
            DataTable table = new DataTable();

            table.Columns.Add("No.", typeof(int));
            table.Columns.Add("No. Inss", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cargo", typeof(string));
            table.Columns.Add("Salario mensual", typeof(decimal));
            table.Columns.Add("Horas Extras", typeof(decimal));
            table.Columns.Add("Ingreso por horas extras", typeof(decimal));
            table.Columns.Add("Antigüedad", typeof(decimal));
            table.Columns.Add("Ingreso total", typeof(decimal));
            table.Columns.Add("Inss laboral", typeof(decimal));
            table.Columns.Add("IR", typeof(decimal));
            table.Columns.Add("Total deducciones", typeof(decimal));
            table.Columns.Add("Neto a recibir", typeof(decimal));
            table.Columns.Add("Inss patronal", typeof(decimal));
            table.Columns.Add("INATEC", typeof(decimal));
            table.Columns.Add("Vacaciones", typeof(decimal));
            table.Columns.Add("Treceavo mes", typeof(decimal));

            int fila = miTabla1.RowCount; //conteo de filas

            for (int i = 0; i < fila; i++)
            {
                table.Rows.Add(Convert.ToInt32(miTabla1.Rows[i].Cells[0].Value), Convert.ToInt32(miTabla1.Rows[i].Cells[1].Value),
                    Convert.ToString(miTabla1.Rows[i].Cells[2].Value), Convert.ToString(miTabla1.Rows[i].Cells[3].Value),
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[4].Value), Convert.ToDecimal(miTabla1.Rows[i].Cells[5].Value),
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[6].Value), Convert.ToDecimal(miTabla1.Rows[i].Cells[7].Value),
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[8].Value), Convert.ToDecimal(miTabla2.Rows[i].Cells[1].Value),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[2].Value), Convert.ToDecimal(miTabla2.Rows[i].Cells[3].Value),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[4].Value), Convert.ToDecimal(miTabla2.Rows[i].Cells[5].Value),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[6].Value), Convert.ToDecimal(miTabla2.Rows[i].Cells[7].Value),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[8].Value)
                    );


            }

            oSLDocument.ImportDataTable(1, 1, table, true);
            
            try
            {
                oSLDocument.SaveAs(pathFile);
                MessageBox.Show("Guardado satisfactoriamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error con el dirrectorio! Se usará el directorio por defecto");

                string standartPathFile = AppDomain.CurrentDomain.BaseDirectory + "miLista.xlsx";

                if (File.Exists(standartPathFile))
                {
                    try
                    {
                        File.Delete(standartPathFile);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error con el archivo!");
                    }
                }

                try
                {
                    oSLDocument.SaveAs(standartPathFile);
                    MessageBox.Show("Guardado satisfactoriamente.");
                }
                catch(NullReferenceException ex4)
                {
                    MessageBox.Show("Error! Error al guardar");
                }
                
                
            }

           
        }

    }
}
