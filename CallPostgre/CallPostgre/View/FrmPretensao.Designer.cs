﻿namespace CallPostgre.View
{
    partial class FrmPretensao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretensao));
            this.tabPretCadastrar = new System.Windows.Forms.TabPage();
            this.grpPretensoesCadastrar = new System.Windows.Forms.GroupBox();
            this.lblPretCadTotal = new System.Windows.Forms.Label();
            this.txtPretCadTotal = new System.Windows.Forms.TextBox();
            this.lblPretCadPer2Dias = new System.Windows.Forms.Label();
            this.lblPretCadPer1Dias = new System.Windows.Forms.Label();
            this.txtPretCadPer2Dias = new System.Windows.Forms.TextBox();
            this.txtPretCadPer1Dias = new System.Windows.Forms.TextBox();
            this.datePretCadPer2Fim = new System.Windows.Forms.DateTimePicker();
            this.datePretCadPer2Inicio = new System.Windows.Forms.DateTimePicker();
            this.datePretCadPer1Fim = new System.Windows.Forms.DateTimePicker();
            this.datePretCadPer1Inicio = new System.Windows.Forms.DateTimePicker();
            this.btnPretCadAlterar = new System.Windows.Forms.Button();
            this.btnPretCadSalvar = new System.Windows.Forms.Button();
            this.btnPretCadIncluir = new System.Windows.Forms.Button();
            this.lblPretCadastrarPer2 = new System.Windows.Forms.Label();
            this.lblPretCadPer2Fim = new System.Windows.Forms.Label();
            this.lblPretCadPer2Inicio = new System.Windows.Forms.Label();
            this.lblPretCadastrarPer1 = new System.Windows.Forms.Label();
            this.lblPretPer1Fim = new System.Windows.Forms.Label();
            this.lblPretPer1inicio = new System.Windows.Forms.Label();
            this.grpPretensoesPaquisitivo = new System.Windows.Forms.GroupBox();
            this.lblPretCadastrarPer = new System.Windows.Forms.Label();
            this.txtPretCadPaqInicio = new System.Windows.Forms.TextBox();
            this.lblPretensaoDtInicio = new System.Windows.Forms.Label();
            this.txtPretCadPaqFim = new System.Windows.Forms.TextBox();
            this.lblPretensaoDtFinal = new System.Windows.Forms.Label();
            this.dtgPretCad = new System.Windows.Forms.DataGridView();
            this.dtgPretClOpcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl1pInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl1pFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl1pTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl2pInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl2pFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretCl2pTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPretClTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretCadRegistro = new System.Windows.Forms.TextBox();
            this.txtPretCadNome = new System.Windows.Forms.TextBox();
            this.txtPretCadTurno = new System.Windows.Forms.TextBox();
            this.cboPretCadAno = new System.Windows.Forms.ComboBox();
            this.lblPretensaoRegistro = new System.Windows.Forms.Label();
            this.lblPretensaoNome = new System.Windows.Forms.Label();
            this.lblPretensaoAno = new System.Windows.Forms.Label();
            this.lblPretensaoTurno = new System.Windows.Forms.Label();
            this.tabPretensao = new System.Windows.Forms.TabControl();
            this.tabPretCadastrar.SuspendLayout();
            this.grpPretensoesCadastrar.SuspendLayout();
            this.grpPretensoesPaquisitivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPretCad)).BeginInit();
            this.tabPretensao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPretCadastrar
            // 
            this.tabPretCadastrar.Controls.Add(this.grpPretensoesCadastrar);
            this.tabPretCadastrar.Controls.Add(this.grpPretensoesPaquisitivo);
            this.tabPretCadastrar.Controls.Add(this.dtgPretCad);
            this.tabPretCadastrar.Controls.Add(this.txtPretCadRegistro);
            this.tabPretCadastrar.Controls.Add(this.txtPretCadNome);
            this.tabPretCadastrar.Controls.Add(this.txtPretCadTurno);
            this.tabPretCadastrar.Controls.Add(this.cboPretCadAno);
            this.tabPretCadastrar.Controls.Add(this.lblPretensaoRegistro);
            this.tabPretCadastrar.Controls.Add(this.lblPretensaoNome);
            this.tabPretCadastrar.Controls.Add(this.lblPretensaoAno);
            this.tabPretCadastrar.Controls.Add(this.lblPretensaoTurno);
            this.tabPretCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabPretCadastrar.Name = "tabPretCadastrar";
            this.tabPretCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPretCadastrar.Size = new System.Drawing.Size(690, 461);
            this.tabPretCadastrar.TabIndex = 0;
            this.tabPretCadastrar.Text = "Cadastrar";
            this.tabPretCadastrar.UseVisualStyleBackColor = true;
            // 
            // grpPretensoesCadastrar
            // 
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadTotal);
            this.grpPretensoesCadastrar.Controls.Add(this.txtPretCadTotal);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadPer2Dias);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadPer1Dias);
            this.grpPretensoesCadastrar.Controls.Add(this.txtPretCadPer2Dias);
            this.grpPretensoesCadastrar.Controls.Add(this.txtPretCadPer1Dias);
            this.grpPretensoesCadastrar.Controls.Add(this.datePretCadPer2Fim);
            this.grpPretensoesCadastrar.Controls.Add(this.datePretCadPer2Inicio);
            this.grpPretensoesCadastrar.Controls.Add(this.datePretCadPer1Fim);
            this.grpPretensoesCadastrar.Controls.Add(this.datePretCadPer1Inicio);
            this.grpPretensoesCadastrar.Controls.Add(this.btnPretCadAlterar);
            this.grpPretensoesCadastrar.Controls.Add(this.btnPretCadSalvar);
            this.grpPretensoesCadastrar.Controls.Add(this.btnPretCadIncluir);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadastrarPer2);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadPer2Fim);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadPer2Inicio);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretCadastrarPer1);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretPer1Fim);
            this.grpPretensoesCadastrar.Controls.Add(this.lblPretPer1inicio);
            this.grpPretensoesCadastrar.Location = new System.Drawing.Point(11, 136);
            this.grpPretensoesCadastrar.Name = "grpPretensoesCadastrar";
            this.grpPretensoesCadastrar.Size = new System.Drawing.Size(660, 152);
            this.grpPretensoesCadastrar.TabIndex = 13;
            this.grpPretensoesCadastrar.TabStop = false;
            this.grpPretensoesCadastrar.Text = "Cadastrar Pretensões";
            // 
            // lblPretCadTotal
            // 
            this.lblPretCadTotal.AutoSize = true;
            this.lblPretCadTotal.Location = new System.Drawing.Point(557, 89);
            this.lblPretCadTotal.Name = "lblPretCadTotal";
            this.lblPretCadTotal.Size = new System.Drawing.Size(31, 13);
            this.lblPretCadTotal.TabIndex = 31;
            this.lblPretCadTotal.Text = "Total";
            // 
            // txtPretCadTotal
            // 
            this.txtPretCadTotal.BackColor = System.Drawing.Color.White;
            this.txtPretCadTotal.Location = new System.Drawing.Point(600, 86);
            this.txtPretCadTotal.Name = "txtPretCadTotal";
            this.txtPretCadTotal.ReadOnly = true;
            this.txtPretCadTotal.Size = new System.Drawing.Size(50, 20);
            this.txtPretCadTotal.TabIndex = 30;
            this.txtPretCadTotal.TextChanged += new System.EventHandler(this.txtPretCadTotal_TextChanged);
            // 
            // lblPretCadPer2Dias
            // 
            this.lblPretCadPer2Dias.AutoSize = true;
            this.lblPretCadPer2Dias.Location = new System.Drawing.Point(443, 70);
            this.lblPretCadPer2Dias.Name = "lblPretCadPer2Dias";
            this.lblPretCadPer2Dias.Size = new System.Drawing.Size(28, 13);
            this.lblPretCadPer2Dias.TabIndex = 25;
            this.lblPretCadPer2Dias.Text = "Dias";
            // 
            // lblPretCadPer1Dias
            // 
            this.lblPretCadPer1Dias.AutoSize = true;
            this.lblPretCadPer1Dias.Location = new System.Drawing.Point(443, 24);
            this.lblPretCadPer1Dias.Name = "lblPretCadPer1Dias";
            this.lblPretCadPer1Dias.Size = new System.Drawing.Size(28, 13);
            this.lblPretCadPer1Dias.TabIndex = 19;
            this.lblPretCadPer1Dias.Text = "Dias";
            // 
            // txtPretCadPer2Dias
            // 
            this.txtPretCadPer2Dias.BackColor = System.Drawing.Color.White;
            this.txtPretCadPer2Dias.Location = new System.Drawing.Point(446, 86);
            this.txtPretCadPer2Dias.Name = "txtPretCadPer2Dias";
            this.txtPretCadPer2Dias.ReadOnly = true;
            this.txtPretCadPer2Dias.Size = new System.Drawing.Size(50, 20);
            this.txtPretCadPer2Dias.TabIndex = 26;
            this.txtPretCadPer2Dias.TextChanged += new System.EventHandler(this.txtPretCadPer2Dias_TextChanged);
            // 
            // txtPretCadPer1Dias
            // 
            this.txtPretCadPer1Dias.BackColor = System.Drawing.Color.White;
            this.txtPretCadPer1Dias.Location = new System.Drawing.Point(446, 40);
            this.txtPretCadPer1Dias.Name = "txtPretCadPer1Dias";
            this.txtPretCadPer1Dias.ReadOnly = true;
            this.txtPretCadPer1Dias.Size = new System.Drawing.Size(50, 20);
            this.txtPretCadPer1Dias.TabIndex = 20;
            this.txtPretCadPer1Dias.TextChanged += new System.EventHandler(this.txtPretCadPer1Dias_TextChanged);
            // 
            // datePretCadPer2Fim
            // 
            this.datePretCadPer2Fim.Checked = false;
            this.datePretCadPer2Fim.CustomFormat = "\"\"";
            this.datePretCadPer2Fim.Enabled = false;
            this.datePretCadPer2Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePretCadPer2Fim.Location = new System.Drawing.Point(289, 86);
            this.datePretCadPer2Fim.Name = "datePretCadPer2Fim";
            this.datePretCadPer2Fim.Size = new System.Drawing.Size(100, 20);
            this.datePretCadPer2Fim.TabIndex = 24;
            this.datePretCadPer2Fim.ValueChanged += new System.EventHandler(this.datePretCadPer2Fim_ValueChanged);
            this.datePretCadPer2Fim.Leave += new System.EventHandler(this.datePretCadPer2Fim_Leave);
            // 
            // datePretCadPer2Inicio
            // 
            this.datePretCadPer2Inicio.Checked = false;
            this.datePretCadPer2Inicio.CustomFormat = "\"\"";
            this.datePretCadPer2Inicio.Enabled = false;
            this.datePretCadPer2Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePretCadPer2Inicio.Location = new System.Drawing.Point(138, 86);
            this.datePretCadPer2Inicio.Name = "datePretCadPer2Inicio";
            this.datePretCadPer2Inicio.Size = new System.Drawing.Size(100, 20);
            this.datePretCadPer2Inicio.TabIndex = 23;
            this.datePretCadPer2Inicio.ValueChanged += new System.EventHandler(this.datePretCadPer2Inicio_ValueChanged);
            this.datePretCadPer2Inicio.Enter += new System.EventHandler(this.datePretCadPer2Inicio_Enter);
            this.datePretCadPer2Inicio.Leave += new System.EventHandler(this.datePretCadPer2Inicio_Leave);
            // 
            // datePretCadPer1Fim
            // 
            this.datePretCadPer1Fim.CustomFormat = "\"\"";
            this.datePretCadPer1Fim.Enabled = false;
            this.datePretCadPer1Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePretCadPer1Fim.Location = new System.Drawing.Point(289, 40);
            this.datePretCadPer1Fim.Name = "datePretCadPer1Fim";
            this.datePretCadPer1Fim.Size = new System.Drawing.Size(100, 20);
            this.datePretCadPer1Fim.TabIndex = 18;
            this.datePretCadPer1Fim.ValueChanged += new System.EventHandler(this.datePretCadPer1Fim_ValueChanged);
            this.datePretCadPer1Fim.Leave += new System.EventHandler(this.datePretCadPer1Fim_Leave);
            // 
            // datePretCadPer1Inicio
            // 
            this.datePretCadPer1Inicio.Checked = false;
            this.datePretCadPer1Inicio.CustomFormat = "\"\"";
            this.datePretCadPer1Inicio.Enabled = false;
            this.datePretCadPer1Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePretCadPer1Inicio.Location = new System.Drawing.Point(138, 40);
            this.datePretCadPer1Inicio.Name = "datePretCadPer1Inicio";
            this.datePretCadPer1Inicio.Size = new System.Drawing.Size(100, 20);
            this.datePretCadPer1Inicio.TabIndex = 16;
            this.datePretCadPer1Inicio.ValueChanged += new System.EventHandler(this.datePretCadPer1Inicio_ValueChanged);
            this.datePretCadPer1Inicio.Leave += new System.EventHandler(this.datePretCadPer1Inicio_Leave);
            // 
            // btnPretCadAlterar
            // 
            this.btnPretCadAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnPretCadAlterar.BackgroundImage = global::CallPostgre.Properties.Resources.laranja;
            this.btnPretCadAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPretCadAlterar.Enabled = false;
            this.btnPretCadAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretCadAlterar.ForeColor = System.Drawing.Color.White;
            this.btnPretCadAlterar.Location = new System.Drawing.Point(276, 121);
            this.btnPretCadAlterar.Name = "btnPretCadAlterar";
            this.btnPretCadAlterar.Size = new System.Drawing.Size(109, 25);
            this.btnPretCadAlterar.TabIndex = 28;
            this.btnPretCadAlterar.Text = "Alterar";
            this.btnPretCadAlterar.UseVisualStyleBackColor = false;
            this.btnPretCadAlterar.Visible = false;
            this.btnPretCadAlterar.Click += new System.EventHandler(this.btnPretCadAlterar_Click);
            // 
            // btnPretCadSalvar
            // 
            this.btnPretCadSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnPretCadSalvar.BackgroundImage = global::CallPostgre.Properties.Resources.verde;
            this.btnPretCadSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPretCadSalvar.Enabled = false;
            this.btnPretCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretCadSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnPretCadSalvar.Location = new System.Drawing.Point(541, 121);
            this.btnPretCadSalvar.Name = "btnPretCadSalvar";
            this.btnPretCadSalvar.Size = new System.Drawing.Size(109, 25);
            this.btnPretCadSalvar.TabIndex = 29;
            this.btnPretCadSalvar.Text = "Salvar e enviar";
            this.btnPretCadSalvar.UseVisualStyleBackColor = false;
            this.btnPretCadSalvar.Visible = false;
            this.btnPretCadSalvar.Click += new System.EventHandler(this.btnPretCadSalvar_Click);
            // 
            // btnPretCadIncluir
            // 
            this.btnPretCadIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnPretCadIncluir.BackgroundImage = global::CallPostgre.Properties.Resources.azul;
            this.btnPretCadIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPretCadIncluir.Enabled = false;
            this.btnPretCadIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretCadIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretCadIncluir.ForeColor = System.Drawing.Color.White;
            this.btnPretCadIncluir.Location = new System.Drawing.Point(16, 121);
            this.btnPretCadIncluir.Name = "btnPretCadIncluir";
            this.btnPretCadIncluir.Size = new System.Drawing.Size(109, 25);
            this.btnPretCadIncluir.TabIndex = 27;
            this.btnPretCadIncluir.Text = "Incluir pretensão";
            this.btnPretCadIncluir.UseVisualStyleBackColor = false;
            this.btnPretCadIncluir.Visible = false;
            this.btnPretCadIncluir.Click += new System.EventHandler(this.btnPretCadIncluir_Click);
            // 
            // lblPretCadastrarPer2
            // 
            this.lblPretCadastrarPer2.AutoSize = true;
            this.lblPretCadastrarPer2.Location = new System.Drawing.Point(16, 89);
            this.lblPretCadastrarPer2.Name = "lblPretCadastrarPer2";
            this.lblPretCadastrarPer2.Size = new System.Drawing.Size(91, 13);
            this.lblPretCadastrarPer2.TabIndex = 21;
            this.lblPretCadastrarPer2.Text = "Segundo Período";
            // 
            // lblPretCadPer2Fim
            // 
            this.lblPretCadPer2Fim.AutoSize = true;
            this.lblPretCadPer2Fim.Location = new System.Drawing.Point(286, 70);
            this.lblPretCadPer2Fim.Name = "lblPretCadPer2Fim";
            this.lblPretCadPer2Fim.Size = new System.Drawing.Size(23, 13);
            this.lblPretCadPer2Fim.TabIndex = 24;
            this.lblPretCadPer2Fim.Text = "Fim";
            // 
            // lblPretCadPer2Inicio
            // 
            this.lblPretCadPer2Inicio.AutoSize = true;
            this.lblPretCadPer2Inicio.Location = new System.Drawing.Point(135, 70);
            this.lblPretCadPer2Inicio.Name = "lblPretCadPer2Inicio";
            this.lblPretCadPer2Inicio.Size = new System.Drawing.Size(34, 13);
            this.lblPretCadPer2Inicio.TabIndex = 22;
            this.lblPretCadPer2Inicio.Text = "Início";
            // 
            // lblPretCadastrarPer1
            // 
            this.lblPretCadastrarPer1.AutoSize = true;
            this.lblPretCadastrarPer1.Location = new System.Drawing.Point(16, 43);
            this.lblPretCadastrarPer1.Name = "lblPretCadastrarPer1";
            this.lblPretCadastrarPer1.Size = new System.Drawing.Size(85, 13);
            this.lblPretCadastrarPer1.TabIndex = 14;
            this.lblPretCadastrarPer1.Text = "Primeiro Período";
            // 
            // lblPretPer1Fim
            // 
            this.lblPretPer1Fim.AutoSize = true;
            this.lblPretPer1Fim.Location = new System.Drawing.Point(286, 24);
            this.lblPretPer1Fim.Name = "lblPretPer1Fim";
            this.lblPretPer1Fim.Size = new System.Drawing.Size(23, 13);
            this.lblPretPer1Fim.TabIndex = 17;
            this.lblPretPer1Fim.Text = "Fim";
            // 
            // lblPretPer1inicio
            // 
            this.lblPretPer1inicio.AutoSize = true;
            this.lblPretPer1inicio.Location = new System.Drawing.Point(135, 24);
            this.lblPretPer1inicio.Name = "lblPretPer1inicio";
            this.lblPretPer1inicio.Size = new System.Drawing.Size(34, 13);
            this.lblPretPer1inicio.TabIndex = 15;
            this.lblPretPer1inicio.Text = "Início";
            // 
            // grpPretensoesPaquisitivo
            // 
            this.grpPretensoesPaquisitivo.Controls.Add(this.lblPretCadastrarPer);
            this.grpPretensoesPaquisitivo.Controls.Add(this.txtPretCadPaqInicio);
            this.grpPretensoesPaquisitivo.Controls.Add(this.lblPretensaoDtInicio);
            this.grpPretensoesPaquisitivo.Controls.Add(this.txtPretCadPaqFim);
            this.grpPretensoesPaquisitivo.Controls.Add(this.lblPretensaoDtFinal);
            this.grpPretensoesPaquisitivo.Location = new System.Drawing.Point(175, 61);
            this.grpPretensoesPaquisitivo.Name = "grpPretensoesPaquisitivo";
            this.grpPretensoesPaquisitivo.Size = new System.Drawing.Size(446, 63);
            this.grpPretensoesPaquisitivo.TabIndex = 13;
            this.grpPretensoesPaquisitivo.TabStop = false;
            // 
            // lblPretCadastrarPer
            // 
            this.lblPretCadastrarPer.AutoSize = true;
            this.lblPretCadastrarPer.Location = new System.Drawing.Point(6, 37);
            this.lblPretCadastrarPer.Name = "lblPretCadastrarPer";
            this.lblPretCadastrarPer.Size = new System.Drawing.Size(93, 13);
            this.lblPretCadastrarPer.TabIndex = 8;
            this.lblPretCadastrarPer.Text = "Período Aquisitivo";
            // 
            // txtPretCadPaqInicio
            // 
            this.txtPretCadPaqInicio.BackColor = System.Drawing.Color.White;
            this.txtPretCadPaqInicio.Location = new System.Drawing.Point(131, 33);
            this.txtPretCadPaqInicio.Name = "txtPretCadPaqInicio";
            this.txtPretCadPaqInicio.ReadOnly = true;
            this.txtPretCadPaqInicio.Size = new System.Drawing.Size(100, 20);
            this.txtPretCadPaqInicio.TabIndex = 10;
            // 
            // lblPretensaoDtInicio
            // 
            this.lblPretensaoDtInicio.AutoSize = true;
            this.lblPretensaoDtInicio.Location = new System.Drawing.Point(131, 16);
            this.lblPretensaoDtInicio.Name = "lblPretensaoDtInicio";
            this.lblPretensaoDtInicio.Size = new System.Drawing.Size(34, 13);
            this.lblPretensaoDtInicio.TabIndex = 9;
            this.lblPretensaoDtInicio.Text = "Início";
            // 
            // txtPretCadPaqFim
            // 
            this.txtPretCadPaqFim.BackColor = System.Drawing.Color.White;
            this.txtPretCadPaqFim.Location = new System.Drawing.Point(317, 34);
            this.txtPretCadPaqFim.Name = "txtPretCadPaqFim";
            this.txtPretCadPaqFim.ReadOnly = true;
            this.txtPretCadPaqFim.Size = new System.Drawing.Size(100, 20);
            this.txtPretCadPaqFim.TabIndex = 12;
            // 
            // lblPretensaoDtFinal
            // 
            this.lblPretensaoDtFinal.AutoSize = true;
            this.lblPretensaoDtFinal.Location = new System.Drawing.Point(314, 16);
            this.lblPretensaoDtFinal.Name = "lblPretensaoDtFinal";
            this.lblPretensaoDtFinal.Size = new System.Drawing.Size(23, 13);
            this.lblPretensaoDtFinal.TabIndex = 11;
            this.lblPretensaoDtFinal.Text = "Fim";
            // 
            // dtgPretCad
            // 
            this.dtgPretCad.AllowUserToDeleteRows = false;
            this.dtgPretCad.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgPretCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPretCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgPretClOpcao,
            this.dtgPretCl1pInicio,
            this.dtgPretCl1pFim,
            this.dtgPretCl1pTotal,
            this.dtgPretCl2pInicio,
            this.dtgPretCl2pFim,
            this.dtgPretCl2pTotal,
            this.dtgPretClTotal});
            this.dtgPretCad.Enabled = false;
            this.dtgPretCad.Location = new System.Drawing.Point(11, 305);
            this.dtgPretCad.Name = "dtgPretCad";
            this.dtgPretCad.ReadOnly = true;
            this.dtgPretCad.Size = new System.Drawing.Size(660, 150);
            this.dtgPretCad.TabIndex = 30;
            this.dtgPretCad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPretCad_CellDoubleClick);
            // 
            // dtgPretClOpcao
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgPretClOpcao.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPretClOpcao.HeaderText = "Opção";
            this.dtgPretClOpcao.Name = "dtgPretClOpcao";
            this.dtgPretClOpcao.ReadOnly = true;
            this.dtgPretClOpcao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPretClOpcao.Width = 50;
            // 
            // dtgPretCl1pInicio
            // 
            this.dtgPretCl1pInicio.HeaderText = "Início";
            this.dtgPretCl1pInicio.Name = "dtgPretCl1pInicio";
            this.dtgPretCl1pInicio.ReadOnly = true;
            // 
            // dtgPretCl1pFim
            // 
            this.dtgPretCl1pFim.HeaderText = "Fim";
            this.dtgPretCl1pFim.Name = "dtgPretCl1pFim";
            this.dtgPretCl1pFim.ReadOnly = true;
            // 
            // dtgPretCl1pTotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgPretCl1pTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPretCl1pTotal.HeaderText = "Dias";
            this.dtgPretCl1pTotal.Name = "dtgPretCl1pTotal";
            this.dtgPretCl1pTotal.ReadOnly = true;
            this.dtgPretCl1pTotal.Width = 50;
            // 
            // dtgPretCl2pInicio
            // 
            this.dtgPretCl2pInicio.HeaderText = "Início";
            this.dtgPretCl2pInicio.Name = "dtgPretCl2pInicio";
            this.dtgPretCl2pInicio.ReadOnly = true;
            // 
            // dtgPretCl2pFim
            // 
            this.dtgPretCl2pFim.HeaderText = "Fim";
            this.dtgPretCl2pFim.Name = "dtgPretCl2pFim";
            this.dtgPretCl2pFim.ReadOnly = true;
            // 
            // dtgPretCl2pTotal
            // 
            this.dtgPretCl2pTotal.HeaderText = "Dias";
            this.dtgPretCl2pTotal.Name = "dtgPretCl2pTotal";
            this.dtgPretCl2pTotal.ReadOnly = true;
            this.dtgPretCl2pTotal.Width = 60;
            // 
            // dtgPretClTotal
            // 
            this.dtgPretClTotal.HeaderText = "Total";
            this.dtgPretClTotal.Name = "dtgPretClTotal";
            this.dtgPretClTotal.ReadOnly = true;
            this.dtgPretClTotal.Width = 50;
            // 
            // txtPretCadRegistro
            // 
            this.txtPretCadRegistro.BackColor = System.Drawing.Color.White;
            this.txtPretCadRegistro.Location = new System.Drawing.Point(27, 30);
            this.txtPretCadRegistro.MaxLength = 6;
            this.txtPretCadRegistro.Name = "txtPretCadRegistro";
            this.txtPretCadRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtPretCadRegistro.TabIndex = 1;
            this.txtPretCadRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretCadRegistro_KeyPress);
            this.txtPretCadRegistro.Leave += new System.EventHandler(this.txtPretCadRegistro_Leave);
            // 
            // txtPretCadNome
            // 
            this.txtPretCadNome.BackColor = System.Drawing.Color.White;
            this.txtPretCadNome.Location = new System.Drawing.Point(175, 30);
            this.txtPretCadNome.Name = "txtPretCadNome";
            this.txtPretCadNome.ReadOnly = true;
            this.txtPretCadNome.Size = new System.Drawing.Size(347, 20);
            this.txtPretCadNome.TabIndex = 3;
            // 
            // txtPretCadTurno
            // 
            this.txtPretCadTurno.BackColor = System.Drawing.Color.White;
            this.txtPretCadTurno.Location = new System.Drawing.Point(571, 30);
            this.txtPretCadTurno.Name = "txtPretCadTurno";
            this.txtPretCadTurno.ReadOnly = true;
            this.txtPretCadTurno.Size = new System.Drawing.Size(100, 20);
            this.txtPretCadTurno.TabIndex = 5;
            // 
            // cboPretCadAno
            // 
            this.cboPretCadAno.BackColor = System.Drawing.Color.White;
            this.cboPretCadAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPretCadAno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPretCadAno.FormattingEnabled = true;
            this.cboPretCadAno.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.cboPretCadAno.Location = new System.Drawing.Point(27, 93);
            this.cboPretCadAno.Name = "cboPretCadAno";
            this.cboPretCadAno.Size = new System.Drawing.Size(100, 21);
            this.cboPretCadAno.TabIndex = 7;
            this.cboPretCadAno.SelectedValueChanged += new System.EventHandler(this.cboPretCadAno_SelectedValueChanged);
            this.cboPretCadAno.Leave += new System.EventHandler(this.cboPretCadAno_Leave);
            // 
            // lblPretensaoRegistro
            // 
            this.lblPretensaoRegistro.AutoSize = true;
            this.lblPretensaoRegistro.Location = new System.Drawing.Point(27, 11);
            this.lblPretensaoRegistro.Name = "lblPretensaoRegistro";
            this.lblPretensaoRegistro.Size = new System.Drawing.Size(46, 13);
            this.lblPretensaoRegistro.TabIndex = 0;
            this.lblPretensaoRegistro.Text = "Registro";
            // 
            // lblPretensaoNome
            // 
            this.lblPretensaoNome.AutoSize = true;
            this.lblPretensaoNome.Location = new System.Drawing.Point(175, 11);
            this.lblPretensaoNome.Name = "lblPretensaoNome";
            this.lblPretensaoNome.Size = new System.Drawing.Size(35, 13);
            this.lblPretensaoNome.TabIndex = 2;
            this.lblPretensaoNome.Text = "Nome";
            // 
            // lblPretensaoAno
            // 
            this.lblPretensaoAno.AutoSize = true;
            this.lblPretensaoAno.Location = new System.Drawing.Point(27, 77);
            this.lblPretensaoAno.Name = "lblPretensaoAno";
            this.lblPretensaoAno.Size = new System.Drawing.Size(26, 13);
            this.lblPretensaoAno.TabIndex = 6;
            this.lblPretensaoAno.Text = "Ano";
            // 
            // lblPretensaoTurno
            // 
            this.lblPretensaoTurno.AutoSize = true;
            this.lblPretensaoTurno.Location = new System.Drawing.Point(568, 11);
            this.lblPretensaoTurno.Name = "lblPretensaoTurno";
            this.lblPretensaoTurno.Size = new System.Drawing.Size(35, 13);
            this.lblPretensaoTurno.TabIndex = 4;
            this.lblPretensaoTurno.Text = "Turno";
            // 
            // tabPretensao
            // 
            this.tabPretensao.Controls.Add(this.tabPretCadastrar);
            this.tabPretensao.Location = new System.Drawing.Point(12, 12);
            this.tabPretensao.Name = "tabPretensao";
            this.tabPretensao.SelectedIndex = 0;
            this.tabPretensao.Size = new System.Drawing.Size(698, 487);
            this.tabPretensao.TabIndex = 13;
            this.tabPretensao.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPretensao_Selected);
            // 
            // FrmPretensao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 511);
            this.Controls.Add(this.tabPretensao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPretensao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pretensões de férias";
            this.Load += new System.EventHandler(this.FrmPretensao_Load);
            this.tabPretCadastrar.ResumeLayout(false);
            this.tabPretCadastrar.PerformLayout();
            this.grpPretensoesCadastrar.ResumeLayout(false);
            this.grpPretensoesCadastrar.PerformLayout();
            this.grpPretensoesPaquisitivo.ResumeLayout(false);
            this.grpPretensoesPaquisitivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPretCad)).EndInit();
            this.tabPretensao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPretCadastrar;
        private System.Windows.Forms.GroupBox grpPretensoesCadastrar;
        private System.Windows.Forms.Label lblPretCadTotal;
        private System.Windows.Forms.TextBox txtPretCadTotal;
        private System.Windows.Forms.Label lblPretCadPer2Dias;
        private System.Windows.Forms.Label lblPretCadPer1Dias;
        private System.Windows.Forms.TextBox txtPretCadPer2Dias;
        private System.Windows.Forms.TextBox txtPretCadPer1Dias;
        private System.Windows.Forms.DateTimePicker datePretCadPer2Fim;
        private System.Windows.Forms.DateTimePicker datePretCadPer2Inicio;
        private System.Windows.Forms.DateTimePicker datePretCadPer1Fim;
        private System.Windows.Forms.DateTimePicker datePretCadPer1Inicio;
        private System.Windows.Forms.Button btnPretCadAlterar;
        private System.Windows.Forms.Button btnPretCadSalvar;
        private System.Windows.Forms.Button btnPretCadIncluir;
        private System.Windows.Forms.Label lblPretCadastrarPer2;
        private System.Windows.Forms.Label lblPretCadPer2Fim;
        private System.Windows.Forms.Label lblPretCadPer2Inicio;
        private System.Windows.Forms.Label lblPretCadastrarPer1;
        private System.Windows.Forms.Label lblPretPer1Fim;
        private System.Windows.Forms.Label lblPretPer1inicio;
        private System.Windows.Forms.GroupBox grpPretensoesPaquisitivo;
        private System.Windows.Forms.Label lblPretCadastrarPer;
        private System.Windows.Forms.TextBox txtPretCadPaqInicio;
        private System.Windows.Forms.Label lblPretensaoDtInicio;
        private System.Windows.Forms.TextBox txtPretCadPaqFim;
        private System.Windows.Forms.Label lblPretensaoDtFinal;
        private System.Windows.Forms.DataGridView dtgPretCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretClOpcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl1pInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl1pFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl1pTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl2pInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl2pFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretCl2pTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPretClTotal;
        private System.Windows.Forms.TextBox txtPretCadRegistro;
        private System.Windows.Forms.TextBox txtPretCadNome;
        private System.Windows.Forms.TextBox txtPretCadTurno;
        private System.Windows.Forms.ComboBox cboPretCadAno;
        private System.Windows.Forms.Label lblPretensaoRegistro;
        private System.Windows.Forms.Label lblPretensaoNome;
        private System.Windows.Forms.Label lblPretensaoAno;
        private System.Windows.Forms.Label lblPretensaoTurno;
        private System.Windows.Forms.TabControl tabPretensao;
    }
}