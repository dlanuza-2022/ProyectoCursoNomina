namespace NominaPractica
{
    partial class FormNomina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.miTabla1 = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNoInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRevenueOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miTabla2 = new System.Windows.Forms.DataGridView();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmployeeInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNetToGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnManagmentInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnINATEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVacations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column13thMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNoInss = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblTenure = new System.Windows.Forms.Label();
            this.txtNoInss = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtHourlyWage = new System.Windows.Forms.TextBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.txtTenure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegularHours = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnCleanTable = new System.Windows.Forms.Button();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblTotalDeducciones = new System.Windows.Forms.Label();
            this.lblTotalNetoRecibir = new System.Windows.Forms.Label();
            this.lblTotalInssPatronal = new System.Windows.Forms.Label();
            this.lblTotalINATEC = new System.Windows.Forms.Label();
            this.lblTotalVacaciones = new System.Windows.Forms.Label();
            this.lblTotalTreceavoMes = new System.Windows.Forms.Label();
            this.lbl_TotalDeducciones = new System.Windows.Forms.Label();
            this.lbl_TotalNetoRecibir = new System.Windows.Forms.Label();
            this.lbl_TotalInssPatronal = new System.Windows.Forms.Label();
            this.lbl_TotalInatec = new System.Windows.Forms.Label();
            this.lbl_TotalVacaciones = new System.Windows.Forms.Label();
            this.lbl_TreceavoMes = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtRowsNumber = new System.Windows.Forms.TextBox();
            this.btnCleanPath = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textModifyRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TotalAntiguedad = new System.Windows.Forms.Label();
            this.lbl_TotalHorasExtras = new System.Windows.Forms.Label();
            this.lblIngresoAntiguedad = new System.Windows.Forms.Label();
            this.lbl_TotalSalarioMensual = new System.Windows.Forms.Label();
            this.lblTotalIngresoHorasExtras = new System.Windows.Forms.Label();
            this.lblTotalSalarioMensual = new System.Windows.Forms.Label();
            this.lbl_TotalIR = new System.Windows.Forms.Label();
            this.lbl_TotalInssLaboral = new System.Windows.Forms.Label();
            this.lbl_TotalIngresoTotal = new System.Windows.Forms.Label();
            this.lblTotalIR = new System.Windows.Forms.Label();
            this.lblTotalInssLaboral = new System.Windows.Forms.Label();
            this.lblTotalIngresoTotal = new System.Windows.Forms.Label();
            this.btnLimpiarTotales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // miTabla1
            // 
            this.miTabla1.AllowUserToAddRows = false;
            this.miTabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnNoInss,
            this.columnNombre,
            this.columnJob,
            this.columnSalary,
            this.columnOvertime,
            this.columnRevenueOvertime,
            this.columnTenure,
            this.columnTotalRevenue});
            this.miTabla1.Location = new System.Drawing.Point(27, 171);
            this.miTabla1.Name = "miTabla1";
            this.miTabla1.RowTemplate.Height = 25;
            this.miTabla1.Size = new System.Drawing.Size(942, 256);
            this.miTabla1.TabIndex = 0;
            // 
            // columnNumber
            // 
            this.columnNumber.Frozen = true;
            this.columnNumber.HeaderText = "No.";
            this.columnNumber.Name = "columnNumber";
            // 
            // columnNoInss
            // 
            this.columnNoInss.Frozen = true;
            this.columnNoInss.HeaderText = "No. Inss";
            this.columnNoInss.Name = "columnNoInss";
            // 
            // columnNombre
            // 
            this.columnNombre.Frozen = true;
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            // 
            // columnJob
            // 
            this.columnJob.Frozen = true;
            this.columnJob.HeaderText = "Cargo";
            this.columnJob.Name = "columnJob";
            // 
            // columnSalary
            // 
            this.columnSalary.Frozen = true;
            this.columnSalary.HeaderText = "Salario mensual";
            this.columnSalary.Name = "columnSalary";
            // 
            // columnOvertime
            // 
            this.columnOvertime.Frozen = true;
            this.columnOvertime.HeaderText = "Horas extras";
            this.columnOvertime.Name = "columnOvertime";
            // 
            // columnRevenueOvertime
            // 
            this.columnRevenueOvertime.Frozen = true;
            this.columnRevenueOvertime.HeaderText = "Ingreso por horas extras";
            this.columnRevenueOvertime.Name = "columnRevenueOvertime";
            // 
            // columnTenure
            // 
            this.columnTenure.Frozen = true;
            this.columnTenure.HeaderText = "Antigüedad";
            this.columnTenure.Name = "columnTenure";
            // 
            // columnTotalRevenue
            // 
            this.columnTotalRevenue.Frozen = true;
            this.columnTotalRevenue.HeaderText = "Ingreso total";
            this.columnTotalRevenue.Name = "columnTotalRevenue";
            // 
            // miTabla2
            // 
            this.miTabla2.AllowUserToAddRows = false;
            this.miTabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNo,
            this.columnEmployeeInss,
            this.columnIR,
            this.columnTotalDeduction,
            this.columnNetToGet,
            this.columnManagmentInss,
            this.columnINATEC,
            this.columnVacations,
            this.column13thMonth});
            this.miTabla2.Location = new System.Drawing.Point(27, 431);
            this.miTabla2.Name = "miTabla2";
            this.miTabla2.RowTemplate.Height = 25;
            this.miTabla2.Size = new System.Drawing.Size(942, 266);
            this.miTabla2.TabIndex = 1;
            // 
            // columnNo
            // 
            this.columnNo.Frozen = true;
            this.columnNo.HeaderText = "No.";
            this.columnNo.Name = "columnNo";
            // 
            // columnEmployeeInss
            // 
            this.columnEmployeeInss.Frozen = true;
            this.columnEmployeeInss.HeaderText = "Inss Laboral";
            this.columnEmployeeInss.Name = "columnEmployeeInss";
            // 
            // columnIR
            // 
            this.columnIR.Frozen = true;
            this.columnIR.HeaderText = "IR";
            this.columnIR.Name = "columnIR";
            // 
            // columnTotalDeduction
            // 
            this.columnTotalDeduction.Frozen = true;
            this.columnTotalDeduction.HeaderText = "Total deducciones";
            this.columnTotalDeduction.Name = "columnTotalDeduction";
            // 
            // columnNetToGet
            // 
            this.columnNetToGet.Frozen = true;
            this.columnNetToGet.HeaderText = "Neto a recibir";
            this.columnNetToGet.Name = "columnNetToGet";
            // 
            // columnManagmentInss
            // 
            this.columnManagmentInss.Frozen = true;
            this.columnManagmentInss.HeaderText = "Inss patronal";
            this.columnManagmentInss.Name = "columnManagmentInss";
            // 
            // columnINATEC
            // 
            this.columnINATEC.Frozen = true;
            this.columnINATEC.HeaderText = "INATEC";
            this.columnINATEC.Name = "columnINATEC";
            // 
            // columnVacations
            // 
            this.columnVacations.Frozen = true;
            this.columnVacations.HeaderText = "Vacaciones";
            this.columnVacations.Name = "columnVacations";
            // 
            // column13thMonth
            // 
            this.column13thMonth.Frozen = true;
            this.column13thMonth.HeaderText = "Treceavo mes";
            this.column13thMonth.Name = "column13thMonth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(47, 105);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido:";
            // 
            // lblNoInss
            // 
            this.lblNoInss.AutoSize = true;
            this.lblNoInss.Location = new System.Drawing.Point(47, 27);
            this.lblNoInss.Name = "lblNoInss";
            this.lblNoInss.Size = new System.Drawing.Size(49, 15);
            this.lblNoInss.TabIndex = 4;
            this.lblNoInss.Text = "No. Inss";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(47, 145);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 15);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Cargo:";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(314, 24);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(93, 15);
            this.lblHourlyWage.TabIndex = 6;
            this.lblHourlyWage.Text = "Salario por hora:";
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Location = new System.Drawing.Point(315, 101);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(70, 15);
            this.lblOvertime.TabIndex = 7;
            this.lblOvertime.Text = "Horas extra:\r\n";
            // 
            // lblTenure
            // 
            this.lblTenure.AutoSize = true;
            this.lblTenure.Location = new System.Drawing.Point(315, 137);
            this.lblTenure.Name = "lblTenure";
            this.lblTenure.Size = new System.Drawing.Size(72, 15);
            this.lblTenure.TabIndex = 8;
            this.lblTenure.Text = "Antiguedad:";
            // 
            // txtNoInss
            // 
            this.txtNoInss.Location = new System.Drawing.Point(107, 24);
            this.txtNoInss.Name = "txtNoInss";
            this.txtNoInss.Size = new System.Drawing.Size(174, 23);
            this.txtNoInss.TabIndex = 9;
            this.txtNoInss.TextChanged += new System.EventHandler(this.txtNoInss_TextChanged);
            this.txtNoInss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoInss_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 23);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(107, 142);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(174, 23);
            this.txtPost.TabIndex = 12;
            this.txtPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPost_KeyPress);
            // 
            // txtHourlyWage
            // 
            this.txtHourlyWage.Location = new System.Drawing.Point(411, 23);
            this.txtHourlyWage.Name = "txtHourlyWage";
            this.txtHourlyWage.Size = new System.Drawing.Size(143, 23);
            this.txtHourlyWage.TabIndex = 13;
            this.txtHourlyWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourlyWage_KeyPress);
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(411, 96);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(143, 23);
            this.txtOvertime.TabIndex = 14;
            this.txtOvertime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOvertime_KeyPress);
            // 
            // txtTenure
            // 
            this.txtTenure.Location = new System.Drawing.Point(411, 131);
            this.txtTenure.Name = "txtTenure";
            this.txtTenure.Size = new System.Drawing.Size(143, 23);
            this.txtTenure.TabIndex = 15;
            this.txtTenure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenure_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Horas regulares:\r\n(Semana)\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRegularHours
            // 
            this.txtRegularHours.Location = new System.Drawing.Point(411, 57);
            this.txtRegularHours.Name = "txtRegularHours";
            this.txtRegularHours.Size = new System.Drawing.Size(143, 23);
            this.txtRegularHours.TabIndex = 17;
            this.txtRegularHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegularHours_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 26);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(733, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 27);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(579, 105);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteRow.TabIndex = 23;
            this.btnDeleteRow.Text = "Eliminar fila";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnCleanTable
            // 
            this.btnCleanTable.Location = new System.Drawing.Point(579, 137);
            this.btnCleanTable.Name = "btnCleanTable";
            this.btnCleanTable.Size = new System.Drawing.Size(127, 25);
            this.btnCleanTable.TabIndex = 24;
            this.btnCleanTable.Text = "Eliminar tabla";
            this.btnCleanTable.UseVisualStyleBackColor = true;
            this.btnCleanTable.Click += new System.EventHandler(this.btnCleanTable_Click);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(975, 171);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(98, 25);
            this.btnCalculateTotal.TabIndex = 25;
            this.btnCalculateTotal.Text = "Calcular totales";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(733, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 26);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Guardar en Excel";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(733, 104);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(153, 27);
            this.btnRead.TabIndex = 27;
            this.btnRead.Text = "Cargar tabla de Excel";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotalDeducciones
            // 
            this.lblTotalDeducciones.AutoSize = true;
            this.lblTotalDeducciones.Location = new System.Drawing.Point(975, 386);
            this.lblTotalDeducciones.Name = "lblTotalDeducciones";
            this.lblTotalDeducciones.Size = new System.Drawing.Size(133, 15);
            this.lblTotalDeducciones.TabIndex = 30;
            this.lblTotalDeducciones.Text = "Total Total deducciones:";
            // 
            // lblTotalNetoRecibir
            // 
            this.lblTotalNetoRecibir.AutoSize = true;
            this.lblTotalNetoRecibir.Location = new System.Drawing.Point(975, 412);
            this.lblTotalNetoRecibir.Name = "lblTotalNetoRecibir";
            this.lblTotalNetoRecibir.Size = new System.Drawing.Size(112, 15);
            this.lblTotalNetoRecibir.TabIndex = 31;
            this.lblTotalNetoRecibir.Text = "Total Neto a Recibir:";
            // 
            // lblTotalInssPatronal
            // 
            this.lblTotalInssPatronal.AutoSize = true;
            this.lblTotalInssPatronal.Location = new System.Drawing.Point(975, 440);
            this.lblTotalInssPatronal.Name = "lblTotalInssPatronal";
            this.lblTotalInssPatronal.Size = new System.Drawing.Size(105, 15);
            this.lblTotalInssPatronal.TabIndex = 32;
            this.lblTotalInssPatronal.Text = "Total Inss patronal:";
            // 
            // lblTotalINATEC
            // 
            this.lblTotalINATEC.AutoSize = true;
            this.lblTotalINATEC.Location = new System.Drawing.Point(975, 465);
            this.lblTotalINATEC.Name = "lblTotalINATEC";
            this.lblTotalINATEC.Size = new System.Drawing.Size(77, 15);
            this.lblTotalINATEC.TabIndex = 33;
            this.lblTotalINATEC.Text = "Total INATEC:";
            // 
            // lblTotalVacaciones
            // 
            this.lblTotalVacaciones.AutoSize = true;
            this.lblTotalVacaciones.Location = new System.Drawing.Point(975, 491);
            this.lblTotalVacaciones.Name = "lblTotalVacaciones";
            this.lblTotalVacaciones.Size = new System.Drawing.Size(96, 15);
            this.lblTotalVacaciones.TabIndex = 34;
            this.lblTotalVacaciones.Text = "Total Vacaciones:";
            // 
            // lblTotalTreceavoMes
            // 
            this.lblTotalTreceavoMes.AutoSize = true;
            this.lblTotalTreceavoMes.Location = new System.Drawing.Point(975, 519);
            this.lblTotalTreceavoMes.Name = "lblTotalTreceavoMes";
            this.lblTotalTreceavoMes.Size = new System.Drawing.Size(109, 15);
            this.lblTotalTreceavoMes.TabIndex = 35;
            this.lblTotalTreceavoMes.Text = "Total Treceavo mes:";
            // 
            // lbl_TotalDeducciones
            // 
            this.lbl_TotalDeducciones.AutoSize = true;
            this.lbl_TotalDeducciones.Location = new System.Drawing.Point(1115, 385);
            this.lbl_TotalDeducciones.Name = "lbl_TotalDeducciones";
            this.lbl_TotalDeducciones.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalDeducciones.TabIndex = 43;
            // 
            // lbl_TotalNetoRecibir
            // 
            this.lbl_TotalNetoRecibir.AutoSize = true;
            this.lbl_TotalNetoRecibir.Location = new System.Drawing.Point(1092, 410);
            this.lbl_TotalNetoRecibir.Name = "lbl_TotalNetoRecibir";
            this.lbl_TotalNetoRecibir.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalNetoRecibir.TabIndex = 44;
            // 
            // lbl_TotalInssPatronal
            // 
            this.lbl_TotalInssPatronal.AutoSize = true;
            this.lbl_TotalInssPatronal.Location = new System.Drawing.Point(1093, 445);
            this.lbl_TotalInssPatronal.Name = "lbl_TotalInssPatronal";
            this.lbl_TotalInssPatronal.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalInssPatronal.TabIndex = 45;
            // 
            // lbl_TotalInatec
            // 
            this.lbl_TotalInatec.AutoSize = true;
            this.lbl_TotalInatec.Location = new System.Drawing.Point(1065, 464);
            this.lbl_TotalInatec.Name = "lbl_TotalInatec";
            this.lbl_TotalInatec.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalInatec.TabIndex = 46;
            // 
            // lbl_TotalVacaciones
            // 
            this.lbl_TotalVacaciones.AutoSize = true;
            this.lbl_TotalVacaciones.Location = new System.Drawing.Point(1079, 492);
            this.lbl_TotalVacaciones.Name = "lbl_TotalVacaciones";
            this.lbl_TotalVacaciones.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalVacaciones.TabIndex = 47;
            // 
            // lbl_TreceavoMes
            // 
            this.lbl_TreceavoMes.AutoSize = true;
            this.lbl_TreceavoMes.Location = new System.Drawing.Point(1094, 521);
            this.lbl_TreceavoMes.Name = "lbl_TreceavoMes";
            this.lbl_TreceavoMes.Size = new System.Drawing.Size(0, 15);
            this.lbl_TreceavoMes.TabIndex = 48;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(724, 142);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(62, 15);
            this.lblPath.TabIndex = 49;
            this.lblPath.Text = "Directorio:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(783, 137);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(186, 23);
            this.txtFilePath.TabIndex = 50;
            // 
            // txtRowsNumber
            // 
            this.txtRowsNumber.Location = new System.Drawing.Point(665, 108);
            this.txtRowsNumber.Name = "txtRowsNumber";
            this.txtRowsNumber.Size = new System.Drawing.Size(41, 23);
            this.txtRowsNumber.TabIndex = 51;
            this.txtRowsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRowsNumber_KeyPress);
            // 
            // btnCleanPath
            // 
            this.btnCleanPath.Location = new System.Drawing.Point(923, 108);
            this.btnCleanPath.Name = "btnCleanPath";
            this.btnCleanPath.Size = new System.Drawing.Size(57, 25);
            this.btnCleanPath.TabIndex = 52;
            this.btnCleanPath.Text = "Clean";
            this.btnCleanPath.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(580, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 27);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textModifyRow
            // 
            this.textModifyRow.Location = new System.Drawing.Point(652, 76);
            this.textModifyRow.Name = "textModifyRow";
            this.textModifyRow.Size = new System.Drawing.Size(54, 23);
            this.textModifyRow.TabIndex = 54;
            this.textModifyRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textModifyRow_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 55;
            this.label2.Text = "No. fila \r\na modificar\r\n";
            // 
            // lbl_TotalAntiguedad
            // 
            this.lbl_TotalAntiguedad.AutoSize = true;
            this.lbl_TotalAntiguedad.Location = new System.Drawing.Point(1149, 280);
            this.lbl_TotalAntiguedad.Name = "lbl_TotalAntiguedad";
            this.lbl_TotalAntiguedad.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalAntiguedad.TabIndex = 61;
            // 
            // lbl_TotalHorasExtras
            // 
            this.lbl_TotalHorasExtras.AutoSize = true;
            this.lbl_TotalHorasExtras.Location = new System.Drawing.Point(1154, 251);
            this.lbl_TotalHorasExtras.Name = "lbl_TotalHorasExtras";
            this.lbl_TotalHorasExtras.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalHorasExtras.TabIndex = 60;
            // 
            // lblIngresoAntiguedad
            // 
            this.lblIngresoAntiguedad.AutoSize = true;
            this.lblIngresoAntiguedad.Location = new System.Drawing.Point(975, 279);
            this.lblIngresoAntiguedad.Name = "lblIngresoAntiguedad";
            this.lblIngresoAntiguedad.Size = new System.Drawing.Size(161, 15);
            this.lblIngresoAntiguedad.TabIndex = 59;
            this.lblIngresoAntiguedad.Text = "Total Ingreso por antiguedad:";
            // 
            // lbl_TotalSalarioMensual
            // 
            this.lbl_TotalSalarioMensual.AutoSize = true;
            this.lbl_TotalSalarioMensual.Location = new System.Drawing.Point(1117, 225);
            this.lbl_TotalSalarioMensual.Name = "lbl_TotalSalarioMensual";
            this.lbl_TotalSalarioMensual.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalSalarioMensual.TabIndex = 58;
            // 
            // lblTotalIngresoHorasExtras
            // 
            this.lblTotalIngresoHorasExtras.AutoSize = true;
            this.lblTotalIngresoHorasExtras.Location = new System.Drawing.Point(975, 251);
            this.lblTotalIngresoHorasExtras.Name = "lblTotalIngresoHorasExtras";
            this.lblTotalIngresoHorasExtras.Size = new System.Drawing.Size(164, 15);
            this.lblTotalIngresoHorasExtras.TabIndex = 57;
            this.lblTotalIngresoHorasExtras.Text = "Total Ingreso por horas extras:";
            // 
            // lblTotalSalarioMensual
            // 
            this.lblTotalSalarioMensual.AutoSize = true;
            this.lblTotalSalarioMensual.Location = new System.Drawing.Point(975, 225);
            this.lblTotalSalarioMensual.Name = "lblTotalSalarioMensual";
            this.lblTotalSalarioMensual.Size = new System.Drawing.Size(121, 15);
            this.lblTotalSalarioMensual.TabIndex = 56;
            this.lblTotalSalarioMensual.Text = "Total Salario mensual:";
            // 
            // lbl_TotalIR
            // 
            this.lbl_TotalIR.AutoSize = true;
            this.lbl_TotalIR.Location = new System.Drawing.Point(1038, 355);
            this.lbl_TotalIR.Name = "lbl_TotalIR";
            this.lbl_TotalIR.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalIR.TabIndex = 67;
            // 
            // lbl_TotalInssLaboral
            // 
            this.lbl_TotalInssLaboral.AutoSize = true;
            this.lbl_TotalInssLaboral.Location = new System.Drawing.Point(1094, 330);
            this.lbl_TotalInssLaboral.Name = "lbl_TotalInssLaboral";
            this.lbl_TotalInssLaboral.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalInssLaboral.TabIndex = 66;
            // 
            // lbl_TotalIngresoTotal
            // 
            this.lbl_TotalIngresoTotal.AutoSize = true;
            this.lbl_TotalIngresoTotal.Location = new System.Drawing.Point(1094, 306);
            this.lbl_TotalIngresoTotal.Name = "lbl_TotalIngresoTotal";
            this.lbl_TotalIngresoTotal.Size = new System.Drawing.Size(0, 15);
            this.lbl_TotalIngresoTotal.TabIndex = 65;
            // 
            // lblTotalIR
            // 
            this.lblTotalIR.AutoSize = true;
            this.lblTotalIR.Location = new System.Drawing.Point(975, 358);
            this.lblTotalIR.Name = "lblTotalIR";
            this.lblTotalIR.Size = new System.Drawing.Size(48, 15);
            this.lblTotalIR.TabIndex = 64;
            this.lblTotalIR.Text = "Total IR:";
            // 
            // lblTotalInssLaboral
            // 
            this.lblTotalInssLaboral.AutoSize = true;
            this.lblTotalInssLaboral.Location = new System.Drawing.Point(975, 330);
            this.lblTotalInssLaboral.Name = "lblTotalInssLaboral";
            this.lblTotalInssLaboral.Size = new System.Drawing.Size(100, 15);
            this.lblTotalInssLaboral.TabIndex = 63;
            this.lblTotalInssLaboral.Text = "Total Inss Laboral:";
            // 
            // lblTotalIngresoTotal
            // 
            this.lblTotalIngresoTotal.AutoSize = true;
            this.lblTotalIngresoTotal.Location = new System.Drawing.Point(975, 304);
            this.lblTotalIngresoTotal.Name = "lblTotalIngresoTotal";
            this.lblTotalIngresoTotal.Size = new System.Drawing.Size(104, 15);
            this.lblTotalIngresoTotal.TabIndex = 62;
            this.lblTotalIngresoTotal.Text = "Total Ingreso total:";
            // 
            // btnLimpiarTotales
            // 
            this.btnLimpiarTotales.Location = new System.Drawing.Point(1092, 171);
            this.btnLimpiarTotales.Name = "btnLimpiarTotales";
            this.btnLimpiarTotales.Size = new System.Drawing.Size(91, 25);
            this.btnLimpiarTotales.TabIndex = 68;
            this.btnLimpiarTotales.Text = "Limpiar";
            this.btnLimpiarTotales.UseVisualStyleBackColor = true;
            this.btnLimpiarTotales.Click += new System.EventHandler(this.btnLimpiarTotales_Click);
            // 
            // FormNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1207, 703);
            this.Controls.Add(this.btnLimpiarTotales);
            this.Controls.Add(this.lbl_TotalIR);
            this.Controls.Add(this.lbl_TotalInssLaboral);
            this.Controls.Add(this.lbl_TotalIngresoTotal);
            this.Controls.Add(this.lblTotalIR);
            this.Controls.Add(this.lblTotalInssLaboral);
            this.Controls.Add(this.lblTotalIngresoTotal);
            this.Controls.Add(this.lbl_TotalAntiguedad);
            this.Controls.Add(this.lbl_TotalHorasExtras);
            this.Controls.Add(this.lblIngresoAntiguedad);
            this.Controls.Add(this.lbl_TotalSalarioMensual);
            this.Controls.Add(this.lblTotalIngresoHorasExtras);
            this.Controls.Add(this.lblTotalSalarioMensual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textModifyRow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCleanPath);
            this.Controls.Add(this.txtRowsNumber);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lbl_TreceavoMes);
            this.Controls.Add(this.lbl_TotalVacaciones);
            this.Controls.Add(this.lbl_TotalInatec);
            this.Controls.Add(this.lbl_TotalInssPatronal);
            this.Controls.Add(this.lbl_TotalNetoRecibir);
            this.Controls.Add(this.lbl_TotalDeducciones);
            this.Controls.Add(this.lblTotalTreceavoMes);
            this.Controls.Add(this.lblTotalVacaciones);
            this.Controls.Add(this.lblTotalINATEC);
            this.Controls.Add(this.lblTotalInssPatronal);
            this.Controls.Add(this.lblTotalNetoRecibir);
            this.Controls.Add(this.lblTotalDeducciones);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.btnCleanTable);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRegularHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenure);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.txtHourlyWage);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNoInss);
            this.Controls.Add(this.lblTenure);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblNoInss);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.miTabla2);
            this.Controls.Add(this.miTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNomina";
            this.Text = "Nomina Mensual";
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView miTabla1;
        private DataGridViewTextBoxColumn columnNumber;
        private DataGridViewTextBoxColumn columnNoInss;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnJob;
        private DataGridViewTextBoxColumn columnSalary;
        private DataGridViewTextBoxColumn columnOvertime;
        private DataGridViewTextBoxColumn columnRevenueOvertime;
        private DataGridViewTextBoxColumn columnTenure;
        private DataGridViewTextBoxColumn columnTotalRevenue;
        private DataGridView miTabla2;
        private DataGridViewTextBoxColumn columnNo;
        private DataGridViewTextBoxColumn columnEmployeeInss;
        private DataGridViewTextBoxColumn columnIR;
        private DataGridViewTextBoxColumn columnTotalDeduction;
        private DataGridViewTextBoxColumn columnNetToGet;
        private DataGridViewTextBoxColumn columnManagmentInss;
        private DataGridViewTextBoxColumn columnINATEC;
        private DataGridViewTextBoxColumn columnVacations;
        private DataGridViewTextBoxColumn column13thMonth;
        private Label lblName;
        private Label lblLastName;
        private Label lblNoInss;
        private Label lblJob;
        private Label lblHourlyWage;
        private Label lblOvertime;
        private Label lblTenure;
        private TextBox txtNoInss;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPost;
        private TextBox txtHourlyWage;
        private TextBox txtOvertime;
        private TextBox txtTenure;
        private Label label1;
        private TextBox txtRegularHours;
        private Button btnAdd;
        private Button btnNew;
        private Button btnDeleteRow;
        private Button btnCleanTable;
        private Button btnCalculateTotal;
        private Button btnSave;
        private Button btnRead;
        private Label lblTotalDeducciones;
        private Label lblTotalNetoRecibir;
        private Label lblTotalInssPatronal;
        private Label lblTotalINATEC;
        private Label lblTotalVacaciones;
        private Label lblTotalTreceavoMes;
        private Label lbl_TotalDeducciones;
        private Label lbl_TotalNetoRecibir;
        private Label lbl_TotalInssPatronal;
        private Label lbl_TotalInatec;
        private Label lbl_TotalVacaciones;
        private Label lbl_TreceavoMes;
        private Label lblPath;
        private TextBox txtFilePath;
        private TextBox txtRowsNumber;
        private Button btnCleanPath;
        private Button btnUpdate;
        private TextBox textModifyRow;
        private Label label2;
        private Label lbl_TotalAntiguedad;
        private Label lbl_TotalHorasExtras;
        private Label lblIngresoAntiguedad;
        private Label lbl_TotalSalarioMensual;
        private Label lblTotalIngresoHorasExtras;
        private Label lblTotalSalarioMensual;
        private Label lbl_TotalIR;
        private Label lbl_TotalInssLaboral;
        private Label lbl_TotalIngresoTotal;
        private Label lblTotalIR;
        private Label lblTotalInssLaboral;
        private Label lblTotalIngresoTotal;
        private Button btnLimpiarTotales;
    }
}