using NominaProyectoCurso.dal;
using NominaProyectoCurso.dol;
using SpreadsheetLight;
using System.Data;
using NominaProyectoCurso.bll;
using DocumentFormat.OpenXml.Packaging;
using Application = NominaProyectoCurso.bll.Application;

namespace NominaPractica
{
    public partial class FormNomina : Form
    {

        int contador = 1;
        const string pathFile = @"F:\DORIAN DATA\Programacion 2\Visual Studio Workspace\miLista.xlsx";

        public FormNomina()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {




            if (String.IsNullOrEmpty(txtHourlyWage.Text) || String.IsNullOrEmpty(txtLastName.Text)
                || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtNoInss.Text) || String.IsNullOrEmpty(txtOvertime.Text)
                || String.IsNullOrEmpty(txtPost.Text) || String.IsNullOrEmpty(txtRegularHours.Text) || String.IsNullOrEmpty(txtTenure.Text))
            {

                MessageBox.Show("Advertencia! Todas las celdas deben ser rellenadas.");


            }
            else
            {
                try
                {
                    Empleado empleado = new Empleado();

                    empleado.NumInss = Convert.ToInt32(txtNoInss.Text);
                    empleado.Nombre = txtName.Text.ToString().Trim();
                    empleado.Apellido = txtLastName.Text.ToString().Trim();

                    empleado.Cargo = txtPost.Text.ToString().Trim();

                    empleado.SalarioXHora = Convert.ToDecimal(txtHourlyWage.Text);
                    empleado.HorasRegulares = Convert.ToDouble(txtRegularHours.Text) * 4;
                    empleado.HorasExtra = Convert.ToDouble(txtOvertime.Text);

                    empleado.Antiguedad = Convert.ToInt32(txtTenure.Text);

                    empleado.SalarioMensual = LogicaNomina.calcularSalarioMensual(empleado.SalarioXHora, Convert.ToDecimal(empleado.HorasRegulares));

                    empleado.IngresoHorasExtra = LogicaNomina.calcularSalarioHorasExtras(empleado.SalarioMensual, Convert.ToDecimal(empleado.HorasExtra));

                    empleado.IngresoAntiguedad = Convert.ToDecimal(LogicaNomina.calcularSalarioAntiguedad(empleado.Antiguedad, empleado.SalarioMensual));

                    empleado.SalarioTotal = LogicaNomina.calcularSalarioTotal(empleado.SalarioMensual, empleado.IngresoHorasExtra, empleado.IngresoAntiguedad);

                    empleado.InssLaboral = LogicaNomina.calcularInssLaboral(empleado.SalarioTotal);

                    empleado.ImpuestoRenta = LogicaNomina.calcularIR(empleado.SalarioTotal, empleado.InssLaboral);

                    empleado.TotalDeducciones = empleado.ImpuestoRenta + empleado.InssLaboral;

                    empleado.NetoARecibir = empleado.SalarioTotal - empleado.TotalDeducciones;

                    empleado.InssPatronal = LogicaNomina.calcularInssLaboral(empleado.SalarioTotal);

                    empleado.Inatec = LogicaNomina.calcularInatec(empleado.SalarioTotal);

                    empleado.Vacaciones = LogicaNomina.calcularVacaciones(empleado.SalarioMensual);

                    empleado.TreceavoMes = LogicaNomina.calcularTreceavoMes(empleado.SalarioMensual);


                    string[] datos1 = new string[9];
                    datos1[0] = contador.ToString();
                    datos1[1] = empleado.NumInss.ToString();
                    datos1[2] = empleado.Nombre + " " + empleado.Apellido;
                    datos1[3] = empleado.Cargo;
                    datos1[4] = empleado.SalarioMensual.ToString("0.##");
                    datos1[5] = empleado.HorasExtra.ToString("0.##");
                    datos1[6] = empleado.IngresoHorasExtra.ToString("0.##");
                    datos1[7] = empleado.IngresoAntiguedad.ToString("0.##");
                    datos1[8] = empleado.SalarioTotal.ToString("0.##");
                    miTabla1.Rows.Add(datos1);





                    string[] datos2 = new string[9];
                    datos2[0] = contador.ToString();
                    datos2[1] = empleado.InssLaboral.ToString("0.##");
                    datos2[2] = empleado.ImpuestoRenta.ToString("0.##");
                    datos2[3] = empleado.TotalDeducciones.ToString("0.##");
                    datos2[4] = empleado.NetoARecibir.ToString("0.##");
                    datos2[5] = empleado.InssPatronal.ToString("0.##");
                    datos2[6] = empleado.Inatec.ToString("0.##");
                    datos2[7] = empleado.Vacaciones.ToString("0.##");
                    datos2[8] = empleado.TreceavoMes.ToString("0.##");
                    miTabla2.Rows.Add(datos2);

                    contador++;

                    Application.addEmpleado(empleado);

                    limpiarCeldas();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Valide los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }






        }


        public void limpiarCeldas()
        {
            this.txtHourlyWage.Text = null;
            this.txtLastName.Text = null;
            this.txtName.Text = null;
            this.txtNoInss.Text = null;
            this.txtOvertime.Text = null;
            this.txtPost.Text = null;
            this.txtRegularHours.Text = null;
            this.txtTenure.Text = null;


        }






        private void btnNew_Click(object sender, EventArgs e)
        {
            limpiarCeldas();
            btnAdd.Enabled = true;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(txtRowsNumber)-1;

            try { 
            
                miTabla1.Rows.RemoveAt(row);
                miTabla2.Rows.RemoveAt(row);

                txtRowsNumber.Text = null;
                Application.removeEmpleadoAt(row);


            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ya no hay fila");
                Console.Write(ex.Message);
            }
            finally
            {
                txtRowsNumber.Text = null;
            }

        }

        public void limpiarTablas()
        {
            int fila = miTabla1.RowCount;

            for (int i = fila - 1; i >= 0; i--)
            {
                miTabla1.Rows.RemoveAt(i);
                miTabla2.Rows.RemoveAt(i);
            }
        }

        private void btnCleanTable_Click(object sender, EventArgs e)
        {
            limpiarTablas();

            Application.deleteList();



        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int fila = miTabla1.RowCount;

            decimal totalSalarioMensual = 0, totalIngresoHorasExtra = 0, totalIngresoAntiguedad = 0, totalIngresoTotal = 0,
                totalInssLaboral = 0, totalIR = 0, totalDeducciones = 0, totalNetoARecibir = 0, totalInssPatronal = 0, totalInatec = 0,
                totalVacaciones = 0, totalTreceavoMes = 0;

            for (int i = 0; i < fila; i++)
            {
                totalSalarioMensual += Convert.ToDecimal(miTabla1.Rows[i].Cells[4].Value);
                totalIngresoHorasExtra += Convert.ToDecimal(miTabla1.Rows[i].Cells[6].Value);
                totalIngresoAntiguedad += Convert.ToDecimal(miTabla1.Rows[i].Cells[7].Value);
                totalIngresoTotal += Convert.ToDecimal(miTabla1.Rows[i].Cells[8].Value);

                totalInssLaboral += Convert.ToDecimal(miTabla2.Rows[i].Cells[1].Value);
                totalIR += Convert.ToDecimal(miTabla2.Rows[i].Cells[2].Value);
                totalDeducciones += Convert.ToDecimal(miTabla2.Rows[i].Cells[3].Value);
                totalNetoARecibir += Convert.ToDecimal(miTabla2.Rows[i].Cells[4].Value);
                totalInssPatronal += Convert.ToDecimal(miTabla2.Rows[i].Cells[5].Value);
                totalInatec += Convert.ToDecimal(miTabla2.Rows[i].Cells[6].Value);
                totalVacaciones += Convert.ToDecimal(miTabla2.Rows[i].Cells[7].Value);
                totalTreceavoMes += Convert.ToDecimal(miTabla2.Rows[i].Cells[8].Value);

            }

            lbl_TotalSalarioMensual.Text = totalSalarioMensual.ToString("0.##");
            lbl_TotalHorasExtras.Text = totalIngresoHorasExtra.ToString("0.##");
            lbl_TotalAntiguedad.Text = totalIngresoAntiguedad.ToString("0.##");
            lbl_TotalIngresoTotal.Text = totalIngresoTotal.ToString("0.##");

            lbl_TotalInssLaboral.Text = totalInssLaboral.ToString("0.##");
            lbl_TotalIR.Text = totalIR.ToString("0.##");
            lbl_TotalDeducciones.Text = totalDeducciones.ToString("0.##");
            lbl_TotalNetoRecibir.Text = totalNetoARecibir.ToString("0.##");
            lbl_TotalInssPatronal.Text = totalInssLaboral.ToString("0.##");
            lbl_TotalInatec.Text = totalInatec.ToString("0.##");
            lbl_TotalVacaciones.Text = totalVacaciones.ToString("0.##");
            lbl_TreceavoMes.Text = totalTreceavoMes.ToString("0.##");

            btnCalculateTotal.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pathFile = txtFilePath.Text;



            EmpleadosDAL empleadoDAL = new EmpleadosDAL();
            empleadoDAL.saveEmpleados(miTabla1, miTabla2, pathFile);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // List < ObjetoaAgregar > = List = new List<ObjetoaAgregar>();
            EmpleadosDAL eDAL = new EmpleadosDAL();

            limpiarTablas();
            eDAL.openEmpleados(miTabla1, miTabla2, pathFile);

        }

        private void txtNoInss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoInss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 128) ||
                (e.KeyChar >= 155 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 223)  || (e.KeyChar == 225) || (e.KeyChar >= 230 && e.KeyChar <= 232) || (e.KeyChar >= 236 && e.KeyChar <= 240 ) || (e.KeyChar >= 242 && e.KeyChar <= 223))
            {
                MessageBox.Show("Solo letras!");
                e.Handled = true;
                return;

            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 128) ||
                (e.KeyChar >= 155 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 208) || (e.KeyChar >= 210 && e.KeyChar <= 223) || (e.KeyChar == 225) || (e.KeyChar >= 230 && e.KeyChar <= 232) || (e.KeyChar >= 236 && e.KeyChar <= 240) || (e.KeyChar >= 242 && e.KeyChar <= 223))
            {
                MessageBox.Show("Solo letras!");
                e.Handled = true;
                return;

            }
        }

        private void txtPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 128) ||
               (e.KeyChar >= 155 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 223) || (e.KeyChar == 225) || (e.KeyChar >= 230 && e.KeyChar <= 232) || (e.KeyChar >= 236 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras!");
                e.Handled = true;
                return;

            }
        }

        private void txtHourlyWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtRegularHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtOvertime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtTenure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtRowsNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int rowNumber;

            if (String.IsNullOrEmpty(txtHourlyWage.Text) || String.IsNullOrEmpty(txtLastName.Text)
                || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtNoInss.Text) || String.IsNullOrEmpty(txtOvertime.Text)
                || String.IsNullOrEmpty(txtPost.Text) || String.IsNullOrEmpty(txtRegularHours.Text) || String.IsNullOrEmpty(txtTenure.Text)
                || String.IsNullOrEmpty(textModifyRow.Text))
            {

                MessageBox.Show("Advertencia! Todas las celdas deben ser rellenadas.");


            }
            else
            {
                try
                {
                    rowNumber = Convert.ToInt32(textModifyRow.Text) - 1;

                    Empleado empleado = new Empleado();

                    empleado.NumInss = Convert.ToInt32(txtNoInss.Text);
                    empleado.Nombre = txtName.Text.ToString().Trim();
                    empleado.Apellido = txtLastName.Text.ToString().Trim();

                    empleado.Cargo = txtPost.Text.ToString().Trim();

                    empleado.SalarioXHora = Convert.ToDecimal(txtHourlyWage.Text);
                    empleado.HorasRegulares = Convert.ToDouble(txtRegularHours.Text);
                    empleado.HorasExtra = Convert.ToDouble(txtOvertime.Text);

                    empleado.Antiguedad = Convert.ToInt32(txtTenure.Text);

                    empleado.SalarioMensual = LogicaNomina.calcularSalarioMensual(empleado.SalarioXHora, Convert.ToDecimal(empleado.HorasRegulares));

                    empleado.IngresoHorasExtra = LogicaNomina.calcularSalarioHorasExtras(empleado.SalarioMensual, Convert.ToDecimal(empleado.HorasExtra));

                    empleado.IngresoAntiguedad = Convert.ToDecimal(LogicaNomina.calcularSalarioAntiguedad(empleado.Antiguedad, empleado.SalarioMensual));

                    empleado.SalarioTotal = LogicaNomina.calcularSalarioTotal(empleado.SalarioMensual, empleado.IngresoHorasExtra, empleado.IngresoAntiguedad);

                    empleado.InssLaboral = LogicaNomina.calcularInssLaboral(empleado.SalarioTotal);

                    empleado.ImpuestoRenta = LogicaNomina.calcularIR(empleado.SalarioTotal, empleado.InssLaboral);

                    empleado.TotalDeducciones = empleado.ImpuestoRenta + empleado.InssLaboral;

                    empleado.NetoARecibir = empleado.SalarioTotal - empleado.TotalDeducciones;

                    empleado.InssPatronal = LogicaNomina.calcularInssLaboral(empleado.SalarioTotal);

                    empleado.Inatec = LogicaNomina.calcularInatec(empleado.SalarioTotal);

                    empleado.Vacaciones = LogicaNomina.calcularVacaciones(empleado.SalarioMensual);

                    empleado.TreceavoMes = LogicaNomina.calcularTreceavoMes(empleado.SalarioMensual);

                    rowNumber += 1;

                    string[] datos1 = new string[9];
                    datos1[0] = rowNumber.ToString();
                    datos1[1] = empleado.NumInss.ToString();
                    datos1[2] = empleado.Nombre + " " + empleado.Apellido;
                    datos1[3] = empleado.Cargo;
                    datos1[4] = empleado.SalarioMensual.ToString("0.##");
                    datos1[5] = empleado.HorasExtra.ToString("0.##");
                    datos1[6] = empleado.IngresoHorasExtra.ToString("0.##");
                    datos1[7] = empleado.IngresoAntiguedad.ToString("0.##");
                    datos1[8] = empleado.SalarioTotal.ToString("0.##");

                    miTabla1.Rows.Insert(rowNumber, datos1);






                    string[] datos2 = new string[9];
                    datos2[0] = rowNumber.ToString();
                    datos2[1] = empleado.InssLaboral.ToString("0.##");
                    datos2[2] = empleado.ImpuestoRenta.ToString("0.##");
                    datos2[3] = empleado.TotalDeducciones.ToString("0.##");
                    datos2[4] = empleado.NetoARecibir.ToString("0.##");
                    datos2[5] = empleado.InssPatronal.ToString("0.##");
                    datos2[6] = empleado.Inatec.ToString("0.##");
                    datos2[7] = empleado.Vacaciones.ToString("0.##");
                    datos2[8] = empleado.TreceavoMes.ToString("0.##");
                    miTabla2.Rows.Insert(rowNumber, datos2);


                    Application.addEmpleadoAt(rowNumber, empleado);


                    limpiarCeldas();
                }

                catch (NullReferenceException e2)
                {
                    MessageBox.Show("No existe la" +
                        "" +
                        "" +
                        "" +
                        "" +
                        "" +
                        " fila");
                    Console.Write(e2.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Valide los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
        }

        private void textModifyRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarTotales_Click(object sender, EventArgs e)
        {
            lbl_TotalSalarioMensual.Text = null;
            lbl_TotalHorasExtras.Text = null;
            lbl_TotalAntiguedad.Text = null;
            lbl_TotalIngresoTotal.Text = null;

            lbl_TotalInssLaboral.Text = null;
            lbl_TotalIR.Text = null;
            lbl_TotalDeducciones.Text = null;
            lbl_TotalNetoRecibir.Text = null;
            lbl_TotalInssPatronal.Text = null;
            lbl_TotalInatec.Text = null;
            lbl_TotalVacaciones.Text = null;
            lbl_TreceavoMes.Text = null;



            btnCalculateTotal.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}