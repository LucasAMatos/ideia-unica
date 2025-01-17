﻿using EasyHortifruti.Componentes;

namespace EasyHortifruti
{
    partial class FormGeralCad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeralCad));
            this.panelCadGeralForm = new System.Windows.Forms.Panel();
            this.panelFormCadGeral = new System.Windows.Forms.Panel();
            this.DgViewCadGeral = new System.Windows.Forms.DataGridView();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFonte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPesquisarCadGeral = new System.Windows.Forms.Panel();
            this.cbTpFontePesquisa = new EasyHortifruti.Componentes.AltComboBox();
            this.cbFiltro = new EasyHortifruti.Componentes.AltComboBox();
            this.tbFiltro = new EasyHortifruti.Componentes.AltTextBox();
            this.panel3FormCadGeralBotoes = new System.Windows.Forms.Panel();
            this.BtSairCadGeral = new System.Windows.Forms.Button();
            this.BtImprimirCadGeral = new System.Windows.Forms.Button();
            this.BtExcluirCadGeral = new System.Windows.Forms.Button();
            this.BtEditarCadGeral = new System.Windows.Forms.Button();
            this.BtIncluirCadGeral = new System.Windows.Forms.Button();
            this.panelTituloCadGeral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCadGeralForm.SuspendLayout();
            this.panelFormCadGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGeral)).BeginInit();
            this.panelPesquisarCadGeral.SuspendLayout();
            this.panel3FormCadGeralBotoes.SuspendLayout();
            this.panelTituloCadGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadGeralForm
            // 
            this.panelCadGeralForm.Controls.Add(this.panelFormCadGeral);
            this.panelCadGeralForm.Controls.Add(this.panelPesquisarCadGeral);
            this.panelCadGeralForm.Controls.Add(this.panel3FormCadGeralBotoes);
            this.panelCadGeralForm.Controls.Add(this.panelTituloCadGeral);
            this.panelCadGeralForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadGeralForm.Location = new System.Drawing.Point(0, 0);
            this.panelCadGeralForm.Name = "panelCadGeralForm";
            this.panelCadGeralForm.Size = new System.Drawing.Size(934, 661);
            this.panelCadGeralForm.TabIndex = 0;
            // 
            // panelFormCadGeral
            // 
            this.panelFormCadGeral.Controls.Add(this.DgViewCadGeral);
            this.panelFormCadGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCadGeral.Location = new System.Drawing.Point(0, 175);
            this.panelFormCadGeral.Name = "panelFormCadGeral";
            this.panelFormCadGeral.Size = new System.Drawing.Size(934, 486);
            this.panelFormCadGeral.TabIndex = 5;
            // 
            // DgViewCadGeral
            // 
            this.DgViewCadGeral.AllowUserToAddRows = false;
            this.DgViewCadGeral.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgViewCadGeral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgViewCadGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFantasia,
            this.RazaoSocial,
            this.CPF,
            this.RG,
            this.logradouro,
            this.numero,
            this.complemento,
            this.bairro,
            this.cidade,
            this.uf,
            this.fone,
            this.celular,
            this.email,
            this.ID,
            this.TipoFonte});
            this.DgViewCadGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadGeral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgViewCadGeral.Location = new System.Drawing.Point(0, 0);
            this.DgViewCadGeral.Name = "DgViewCadGeral";
            this.DgViewCadGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewCadGeral.Size = new System.Drawing.Size(934, 486);
            this.DgViewCadGeral.TabIndex = 0;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.DataPropertyName = "nomefantasia";
            this.NomeFantasia.HeaderText = "Nome / Fantasia";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.Width = 150;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.DataPropertyName = "razaosocial";
            this.RazaoSocial.HeaderText = "Razão Social";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.Width = 250;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cnpj_cpf";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CPF.DefaultCellStyle = dataGridViewCellStyle10;
            this.CPF.HeaderText = "CNPJ / CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.DataPropertyName = "ie_rg";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RG.DefaultCellStyle = dataGridViewCellStyle11;
            this.RG.HeaderText = "I.E. / RG.";
            this.RG.Name = "RG";
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Endereço";
            this.logradouro.Name = "logradouro";
            this.logradouro.Width = 180;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero.DefaultCellStyle = dataGridViewCellStyle12;
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.Width = 35;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.Width = 130;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.Width = 130;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uf.DefaultCellStyle = dataGridViewCellStyle13;
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.Width = 30;
            // 
            // fone
            // 
            this.fone.DataPropertyName = "fone";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fone.DefaultCellStyle = dataGridViewCellStyle14;
            this.fone.HeaderText = "Fone";
            this.fone.Name = "fone";
            this.fone.Width = 65;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.celular.DefaultCellStyle = dataGridViewCellStyle15;
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.Width = 65;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_recno";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle16;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // TipoFonte
            // 
            this.TipoFonte.DataPropertyName = "classificacao";
            this.TipoFonte.HeaderText = "TipoFonte";
            this.TipoFonte.Name = "TipoFonte";
            this.TipoFonte.Visible = false;
            // 
            // panelPesquisarCadGeral
            // 
            this.panelPesquisarCadGeral.Controls.Add(this.cbTpFontePesquisa);
            this.panelPesquisarCadGeral.Controls.Add(this.cbFiltro);
            this.panelPesquisarCadGeral.Controls.Add(this.tbFiltro);
            this.panelPesquisarCadGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisarCadGeral.Location = new System.Drawing.Point(0, 120);
            this.panelPesquisarCadGeral.Name = "panelPesquisarCadGeral";
            this.panelPesquisarCadGeral.Size = new System.Drawing.Size(934, 55);
            this.panelPesquisarCadGeral.TabIndex = 4;
            // 
            // cbTpFontePesquisa
            // 
            this.cbTpFontePesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbTpFontePesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbTpFontePesquisa.Caption = "TipoFonte";
            this.cbTpFontePesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTpFontePesquisa.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbTpFontePesquisa.FormattingEnabled = true;
            this.cbTpFontePesquisa.Location = new System.Drawing.Point(462, 5);
            this.cbTpFontePesquisa.Name = "cbTpFontePesquisa";
            this.cbTpFontePesquisa.Obrigatorio = false;
            this.cbTpFontePesquisa.SelectedIndex = -1;
            this.cbTpFontePesquisa.SelectedItem = null;
            this.cbTpFontePesquisa.SelectedText = "";
            this.cbTpFontePesquisa.Size = new System.Drawing.Size(163, 46);
            this.cbTpFontePesquisa.TabIndex = 7;
            this.cbTpFontePesquisa.SelectedIndexChanged += new System.EventHandler(this.CbTpFontePesquisa_SelectedIndexChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFiltro.Caption = "Campo para Filtrar";
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(12, 5);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Obrigatorio = false;
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.SelectedText = "";
            this.cbFiltro.Size = new System.Drawing.Size(205, 46);
            this.cbFiltro.TabIndex = 5;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Caption = "Digite para Filtrar";
            this.tbFiltro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.FonteCaption = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.FonteTexto = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(238, 1);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFiltro.MaxLength = 32767;
            this.tbFiltro.Multiline = true;
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Obrigatorio = false;
            this.tbFiltro.ReadOnly = false;
            this.tbFiltro.SelectionLength = 0;
            this.tbFiltro.SelectionStart = 0;
            this.tbFiltro.Size = new System.Drawing.Size(202, 44);
            this.tbFiltro.TabIndex = 6;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiltro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panel3FormCadGeralBotoes
            // 
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtSairCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtImprimirCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtExcluirCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtEditarCadGeral);
            this.panel3FormCadGeralBotoes.Controls.Add(this.BtIncluirCadGeral);
            this.panel3FormCadGeralBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3FormCadGeralBotoes.Location = new System.Drawing.Point(0, 59);
            this.panel3FormCadGeralBotoes.Name = "panel3FormCadGeralBotoes";
            this.panel3FormCadGeralBotoes.Size = new System.Drawing.Size(934, 61);
            this.panel3FormCadGeralBotoes.TabIndex = 2;
            // 
            // BtSairCadGeral
            // 
            this.BtSairCadGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtSairCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairCadGeral.BackgroundImage")));
            this.BtSairCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairCadGeral.FlatAppearance.BorderSize = 0;
            this.BtSairCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairCadGeral.Location = new System.Drawing.Point(869, 4);
            this.BtSairCadGeral.Name = "BtSairCadGeral";
            this.BtSairCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtSairCadGeral.TabIndex = 5;
            this.BtSairCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairCadGeral.UseVisualStyleBackColor = false;
            this.BtSairCadGeral.Click += new System.EventHandler(this.BtSairCadGeral_Click);
            // 
            // BtImprimirCadGeral
            // 
            this.BtImprimirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirCadGeral.BackgroundImage")));
            this.BtImprimirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtImprimirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirCadGeral.Location = new System.Drawing.Point(171, 4);
            this.BtImprimirCadGeral.Name = "BtImprimirCadGeral";
            this.BtImprimirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirCadGeral.TabIndex = 3;
            this.BtImprimirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirCadGeral.UseVisualStyleBackColor = false;
            this.BtImprimirCadGeral.Click += new System.EventHandler(this.BtImprimirCadGeral_Click);
            // 
            // BtExcluirCadGeral
            // 
            this.BtExcluirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirCadGeral.BackgroundImage")));
            this.BtExcluirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtExcluirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirCadGeral.Location = new System.Drawing.Point(116, 3);
            this.BtExcluirCadGeral.Name = "BtExcluirCadGeral";
            this.BtExcluirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirCadGeral.TabIndex = 2;
            this.BtExcluirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirCadGeral.UseVisualStyleBackColor = false;
            this.BtExcluirCadGeral.Click += new System.EventHandler(this.BtExcluirCadGeral_Click);
            // 
            // BtEditarCadGeral
            // 
            this.BtEditarCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarCadGeral.BackgroundImage")));
            this.BtEditarCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarCadGeral.FlatAppearance.BorderSize = 0;
            this.BtEditarCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarCadGeral.Location = new System.Drawing.Point(64, 3);
            this.BtEditarCadGeral.Name = "BtEditarCadGeral";
            this.BtEditarCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtEditarCadGeral.TabIndex = 1;
            this.BtEditarCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarCadGeral.UseVisualStyleBackColor = false;
            this.BtEditarCadGeral.Click += new System.EventHandler(this.BtEditarCadGeral_Click);
            // 
            // BtIncluirCadGeral
            // 
            this.BtIncluirCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirCadGeral.BackgroundImage")));
            this.BtIncluirCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirCadGeral.FlatAppearance.BorderSize = 0;
            this.BtIncluirCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirCadGeral.Location = new System.Drawing.Point(12, 3);
            this.BtIncluirCadGeral.Name = "BtIncluirCadGeral";
            this.BtIncluirCadGeral.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirCadGeral.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirCadGeral.TabIndex = 0;
            this.BtIncluirCadGeral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirCadGeral.UseVisualStyleBackColor = false;
            this.BtIncluirCadGeral.Click += new System.EventHandler(this.BtIncluirCliente_Click);
            // 
            // panelTituloCadGeral
            // 
            this.panelTituloCadGeral.BackColor = System.Drawing.Color.Transparent;
            this.panelTituloCadGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloCadGeral.BackgroundImage")));
            this.panelTituloCadGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTituloCadGeral.Controls.Add(this.panel1);
            this.panelTituloCadGeral.Controls.Add(this.label1);
            this.panelTituloCadGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCadGeral.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCadGeral.Name = "panelTituloCadGeral";
            this.panelTituloCadGeral.Size = new System.Drawing.Size(934, 59);
            this.panelTituloCadGeral.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Geral";
            // 
            // FormGeralCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.panelCadGeralForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGeralCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti";
            this.Load += new System.EventHandler(this.FormCadGeral_Load);
            this.panelCadGeralForm.ResumeLayout(false);
            this.panelFormCadGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGeral)).EndInit();
            this.panelPesquisarCadGeral.ResumeLayout(false);
            this.panel3FormCadGeralBotoes.ResumeLayout(false);
            this.panelTituloCadGeral.ResumeLayout(false);
            this.panelTituloCadGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadGeralForm;
        private System.Windows.Forms.Panel panelTituloCadGeral;
        private System.Windows.Forms.Panel panel3FormCadGeralBotoes;
        private System.Windows.Forms.Button BtSairCadGeral;
        private System.Windows.Forms.Button BtImprimirCadGeral;
        private System.Windows.Forms.Button BtExcluirCadGeral;
        private System.Windows.Forms.Button BtEditarCadGeral;
        private System.Windows.Forms.Button BtIncluirCadGeral;
        private System.Windows.Forms.Panel panelPesquisarCadGeral;
        private System.Windows.Forms.Panel panelFormCadGeral;
        private System.Windows.Forms.DataGridView DgViewCadGeral;
        private AltComboBox cbFiltro;
        private AltTextBox tbFiltro;
        private AltComboBox cbTpFontePesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFonte;
    }
}