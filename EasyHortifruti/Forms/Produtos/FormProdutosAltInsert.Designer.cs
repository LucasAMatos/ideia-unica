﻿using EasyHortifruti.Componentes;
using System;

namespace EasyHortifruti
{
    partial class FormProdutosAltInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutosAltInsert));
            this.panelInserirProduto = new System.Windows.Forms.Panel();
            this.BtCadNCM = new System.Windows.Forms.Button();
            this.txtNCM = new EasyHortifruti.Componentes.AltTextBox();
            this.MtbPrecoVenda = new EasyHortifruti.Componentes.AltTextBox();
            this.MtbMargemLucro = new EasyHortifruti.Componentes.AltTextBox();
            this.MtbPrecoCompra = new EasyHortifruti.Componentes.AltTextBox();
            this.BtCadSubGrupo = new System.Windows.Forms.Button();
            this.BtCadGrupo = new System.Windows.Forms.Button();
            this.BtCadUnidade = new System.Windows.Forms.Button();
            this.cbSubGrupoProduto = new EasyHortifruti.Componentes.AltComboBox();
            this.cbGrupoProduto = new EasyHortifruti.Componentes.AltComboBox();
            this.cbUnidProduto = new EasyHortifruti.Componentes.AltComboBox();
            this.tbDescricaoProduto = new EasyHortifruti.Componentes.AltTextBox();
            this.panelBotoesInserirProduto = new System.Windows.Forms.Panel();
            this.labelIDProduto = new System.Windows.Forms.Label();
            this.BtGravaAlterProd = new System.Windows.Forms.Button();
            this.BtCancelaProduto = new System.Windows.Forms.Button();
            this.panelInserirProduto.SuspendLayout();
            this.panelBotoesInserirProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInserirProduto
            // 
            this.panelInserirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInserirProduto.Controls.Add(this.BtCadNCM);
            this.panelInserirProduto.Controls.Add(this.txtNCM);
            this.panelInserirProduto.Controls.Add(this.MtbPrecoVenda);
            this.panelInserirProduto.Controls.Add(this.MtbMargemLucro);
            this.panelInserirProduto.Controls.Add(this.MtbPrecoCompra);
            this.panelInserirProduto.Controls.Add(this.BtCadSubGrupo);
            this.panelInserirProduto.Controls.Add(this.BtCadGrupo);
            this.panelInserirProduto.Controls.Add(this.BtCadUnidade);
            this.panelInserirProduto.Controls.Add(this.cbSubGrupoProduto);
            this.panelInserirProduto.Controls.Add(this.cbGrupoProduto);
            this.panelInserirProduto.Controls.Add(this.cbUnidProduto);
            this.panelInserirProduto.Controls.Add(this.tbDescricaoProduto);
            this.panelInserirProduto.Controls.Add(this.panelBotoesInserirProduto);
            this.panelInserirProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInserirProduto.Location = new System.Drawing.Point(0, 0);
            this.panelInserirProduto.Name = "panelInserirProduto";
            this.panelInserirProduto.Size = new System.Drawing.Size(546, 452);
            this.panelInserirProduto.TabIndex = 0;
            // 
            // BtCadNCM
            // 
            this.BtCadNCM.BackColor = System.Drawing.Color.Transparent;
            this.BtCadNCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCadNCM.FlatAppearance.BorderSize = 0;
            this.BtCadNCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadNCM.Image = ((System.Drawing.Image)(resources.GetObject("BtCadNCM.Image")));
            this.BtCadNCM.Location = new System.Drawing.Point(107, 162);
            this.BtCadNCM.Name = "BtCadNCM";
            this.BtCadNCM.Size = new System.Drawing.Size(26, 25);
            this.BtCadNCM.TabIndex = 3;
            this.BtCadNCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadNCM.UseVisualStyleBackColor = false;
            this.BtCadNCM.Click += new System.EventHandler(this.BtCadNCM_Click);
            // 
            // txtNCM
            // 
            this.txtNCM.Caption = "NCM";
            this.txtNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCM.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtNCM.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCM.Location = new System.Drawing.Point(18, 141);
            this.txtNCM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNCM.MaxLength = 32767;
            this.txtNCM.Multiline = true;
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Obrigatorio = false;
            this.txtNCM.ReadOnly = false;
            this.txtNCM.SelectionLength = 0;
            this.txtNCM.SelectionStart = 0;
            this.txtNCM.Size = new System.Drawing.Size(88, 48);
            this.txtNCM.TabIndex = 2;
            this.txtNCM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNCM.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // MtbPrecoVenda
            // 
            this.MtbPrecoVenda.Caption = "R$ Venda";
            this.MtbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPrecoVenda.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MtbPrecoVenda.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPrecoVenda.Location = new System.Drawing.Point(18, 224);
            this.MtbPrecoVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MtbPrecoVenda.MaxLength = 32767;
            this.MtbPrecoVenda.Multiline = true;
            this.MtbPrecoVenda.Name = "MtbPrecoVenda";
            this.MtbPrecoVenda.Obrigatorio = false;
            this.MtbPrecoVenda.ReadOnly = true;
            this.MtbPrecoVenda.SelectionLength = 0;
            this.MtbPrecoVenda.SelectionStart = 0;
            this.MtbPrecoVenda.Size = new System.Drawing.Size(96, 48);
            this.MtbPrecoVenda.TabIndex = 6;
            this.MtbPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MtbPrecoVenda.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // MtbMargemLucro
            // 
            this.MtbMargemLucro.Caption = "% Lucro";
            this.MtbMargemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbMargemLucro.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MtbMargemLucro.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbMargemLucro.Location = new System.Drawing.Point(426, 141);
            this.MtbMargemLucro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MtbMargemLucro.MaxLength = 32767;
            this.MtbMargemLucro.Multiline = true;
            this.MtbMargemLucro.Name = "MtbMargemLucro";
            this.MtbMargemLucro.Obrigatorio = false;
            this.MtbMargemLucro.ReadOnly = false;
            this.MtbMargemLucro.SelectionLength = 0;
            this.MtbMargemLucro.SelectionStart = 0;
            this.MtbMargemLucro.Size = new System.Drawing.Size(88, 48);
            this.MtbMargemLucro.TabIndex = 7;
            this.MtbMargemLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbMargemLucro.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.NUMERO;
            this.MtbMargemLucro.TextChanged += new System.EventHandler(this.MtbMargemLucro_TextChanged);
            // 
            // MtbPrecoCompra
            // 
            this.MtbPrecoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MtbPrecoCompra.Caption = "R$ Compra";
            this.MtbPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPrecoCompra.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MtbPrecoCompra.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbPrecoCompra.Location = new System.Drawing.Point(314, 141);
            this.MtbPrecoCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MtbPrecoCompra.MaxLength = 32767;
            this.MtbPrecoCompra.Multiline = true;
            this.MtbPrecoCompra.Name = "MtbPrecoCompra";
            this.MtbPrecoCompra.Obrigatorio = false;
            this.MtbPrecoCompra.ReadOnly = false;
            this.MtbPrecoCompra.SelectionLength = 0;
            this.MtbPrecoCompra.SelectionStart = 0;
            this.MtbPrecoCompra.Size = new System.Drawing.Size(93, 48);
            this.MtbPrecoCompra.TabIndex = 6;
            this.MtbPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbPrecoCompra.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.MOEDA;
            this.MtbPrecoCompra.TextChanged += new System.EventHandler(this.MtbPrecoCompra_TextChanged);
            // 
            // BtCadSubGrupo
            // 
            this.BtCadSubGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtCadSubGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCadSubGrupo.FlatAppearance.BorderSize = 0;
            this.BtCadSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadSubGrupo.Image = ((System.Drawing.Image)(resources.GetObject("BtCadSubGrupo.Image")));
            this.BtCadSubGrupo.Location = new System.Drawing.Point(484, 244);
            this.BtCadSubGrupo.Name = "BtCadSubGrupo";
            this.BtCadSubGrupo.Size = new System.Drawing.Size(26, 25);
            this.BtCadSubGrupo.TabIndex = 11;
            this.BtCadSubGrupo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadSubGrupo.UseVisualStyleBackColor = false;
            this.BtCadSubGrupo.Click += new System.EventHandler(this.BtCadSubGrupo_Click);
            // 
            // BtCadGrupo
            // 
            this.BtCadGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtCadGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCadGrupo.FlatAppearance.BorderSize = 0;
            this.BtCadGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadGrupo.Image = ((System.Drawing.Image)(resources.GetObject("BtCadGrupo.Image")));
            this.BtCadGrupo.Location = new System.Drawing.Point(274, 244);
            this.BtCadGrupo.Name = "BtCadGrupo";
            this.BtCadGrupo.Size = new System.Drawing.Size(26, 25);
            this.BtCadGrupo.TabIndex = 9;
            this.BtCadGrupo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadGrupo.UseVisualStyleBackColor = false;
            this.BtCadGrupo.Click += new System.EventHandler(this.BtCadGrupo_Click);
            // 
            // BtCadUnidade
            // 
            this.BtCadUnidade.BackColor = System.Drawing.Color.Transparent;
            this.BtCadUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCadUnidade.FlatAppearance.BorderSize = 0;
            this.BtCadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadUnidade.Image = ((System.Drawing.Image)(resources.GetObject("BtCadUnidade.Image")));
            this.BtCadUnidade.Location = new System.Drawing.Point(268, 163);
            this.BtCadUnidade.Name = "BtCadUnidade";
            this.BtCadUnidade.Size = new System.Drawing.Size(26, 25);
            this.BtCadUnidade.TabIndex = 5;
            this.BtCadUnidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCadUnidade.UseVisualStyleBackColor = false;
            this.BtCadUnidade.Click += new System.EventHandler(this.BtCadUnidade_Click);
            // 
            // cbSubGrupoProduto
            // 
            this.cbSubGrupoProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSubGrupoProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubGrupoProduto.Caption = "SubGrupo";
            this.cbSubGrupoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubGrupoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubGrupoProduto.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbSubGrupoProduto.FormattingEnabled = true;
            this.cbSubGrupoProduto.Location = new System.Drawing.Point(328, 225);
            this.cbSubGrupoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubGrupoProduto.Name = "cbSubGrupoProduto";
            this.cbSubGrupoProduto.Obrigatorio = false;
            this.cbSubGrupoProduto.SelectedIndex = -1;
            this.cbSubGrupoProduto.SelectedItem = null;
            this.cbSubGrupoProduto.SelectedText = "";
            this.cbSubGrupoProduto.Size = new System.Drawing.Size(155, 48);
            this.cbSubGrupoProduto.TabIndex = 10;
            // 
            // cbGrupoProduto
            // 
            this.cbGrupoProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGrupoProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGrupoProduto.Caption = "Grupo";
            this.cbGrupoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupoProduto.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbGrupoProduto.FormattingEnabled = true;
            this.cbGrupoProduto.Location = new System.Drawing.Point(154, 225);
            this.cbGrupoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGrupoProduto.Name = "cbGrupoProduto";
            this.cbGrupoProduto.Obrigatorio = false;
            this.cbGrupoProduto.SelectedIndex = -1;
            this.cbGrupoProduto.SelectedItem = null;
            this.cbGrupoProduto.SelectedText = "";
            this.cbGrupoProduto.Size = new System.Drawing.Size(119, 48);
            this.cbGrupoProduto.TabIndex = 8;
            // 
            // cbUnidProduto
            // 
            this.cbUnidProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbUnidProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnidProduto.Caption = "Unidade";
            this.cbUnidProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidProduto.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbUnidProduto.FormattingEnabled = true;
            this.cbUnidProduto.Location = new System.Drawing.Point(154, 144);
            this.cbUnidProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUnidProduto.Name = "cbUnidProduto";
            this.cbUnidProduto.Obrigatorio = false;
            this.cbUnidProduto.SelectedIndex = -1;
            this.cbUnidProduto.SelectedItem = null;
            this.cbUnidProduto.SelectedText = "";
            this.cbUnidProduto.Size = new System.Drawing.Size(113, 48);
            this.cbUnidProduto.TabIndex = 4;
            // 
            // tbDescricaoProduto
            // 
            this.tbDescricaoProduto.Caption = "Descrição";
            this.tbDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoProduto.FonteCaption = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tbDescricaoProduto.FonteTexto = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoProduto.Location = new System.Drawing.Point(18, 57);
            this.tbDescricaoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescricaoProduto.MaxLength = 32767;
            this.tbDescricaoProduto.Multiline = true;
            this.tbDescricaoProduto.Name = "tbDescricaoProduto";
            this.tbDescricaoProduto.Obrigatorio = false;
            this.tbDescricaoProduto.ReadOnly = false;
            this.tbDescricaoProduto.SelectionLength = 0;
            this.tbDescricaoProduto.SelectionStart = 0;
            this.tbDescricaoProduto.Size = new System.Drawing.Size(496, 48);
            this.tbDescricaoProduto.TabIndex = 1;
            this.tbDescricaoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescricaoProduto.Tipo = EasyHortifruti.Componentes.AltTextBox.TipoCampo.TEXTO;
            // 
            // panelBotoesInserirProduto
            // 
            this.panelBotoesInserirProduto.BackColor = System.Drawing.Color.Transparent;
            this.panelBotoesInserirProduto.Controls.Add(this.labelIDProduto);
            this.panelBotoesInserirProduto.Controls.Add(this.BtGravaAlterProd);
            this.panelBotoesInserirProduto.Controls.Add(this.BtCancelaProduto);
            this.panelBotoesInserirProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoesInserirProduto.Location = new System.Drawing.Point(0, 390);
            this.panelBotoesInserirProduto.Name = "panelBotoesInserirProduto";
            this.panelBotoesInserirProduto.Size = new System.Drawing.Size(546, 62);
            this.panelBotoesInserirProduto.TabIndex = 0;
            // 
            // labelIDProduto
            // 
            this.labelIDProduto.AutoSize = true;
            this.labelIDProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelIDProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDProduto.ForeColor = System.Drawing.Color.Black;
            this.labelIDProduto.Location = new System.Drawing.Point(12, 21);
            this.labelIDProduto.Name = "labelIDProduto";
            this.labelIDProduto.Size = new System.Drawing.Size(30, 22);
            this.labelIDProduto.TabIndex = 0;
            this.labelIDProduto.Text = "ID";
            // 
            // BtGravaAlterProd
            // 
            this.BtGravaAlterProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtGravaAlterProd.BackColor = System.Drawing.Color.Transparent;
            this.BtGravaAlterProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtGravaAlterProd.BackgroundImage")));
            this.BtGravaAlterProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtGravaAlterProd.FlatAppearance.BorderSize = 0;
            this.BtGravaAlterProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGravaAlterProd.Location = new System.Drawing.Point(337, 17);
            this.BtGravaAlterProd.Name = "BtGravaAlterProd";
            this.BtGravaAlterProd.Size = new System.Drawing.Size(94, 30);
            this.BtGravaAlterProd.TabIndex = 12;
            this.BtGravaAlterProd.UseVisualStyleBackColor = false;
            this.BtGravaAlterProd.Click += new System.EventHandler(this.BtGravaAlterProd_Click);
            // 
            // BtCancelaProduto
            // 
            this.BtCancelaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancelaProduto.BackColor = System.Drawing.Color.Transparent;
            this.BtCancelaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtCancelaProduto.BackgroundImage")));
            this.BtCancelaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCancelaProduto.FlatAppearance.BorderSize = 0;
            this.BtCancelaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelaProduto.Location = new System.Drawing.Point(437, 17);
            this.BtCancelaProduto.Name = "BtCancelaProduto";
            this.BtCancelaProduto.Size = new System.Drawing.Size(94, 30);
            this.BtCancelaProduto.TabIndex = 13;
            this.BtCancelaProduto.UseVisualStyleBackColor = false;
            this.BtCancelaProduto.Click += new System.EventHandler(this.BtCancelaProduto_Click);
            // 
            // FormProdutosAltInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 452);
            this.Controls.Add(this.panelInserirProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormProdutosAltInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyHortifruti - Inserir Produto";
            this.Load += new System.EventHandler(this.FormProdutosAltInsert_Load);
            this.panelInserirProduto.ResumeLayout(false);
            this.panelBotoesInserirProduto.ResumeLayout(false);
            this.panelBotoesInserirProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btCadUnidade_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelInserirProduto;
        private System.Windows.Forms.Panel panelBotoesInserirProduto;
        private System.Windows.Forms.Button BtCancelaProduto;
        private System.Windows.Forms.Button BtGravaAlterProd;
        private AltTextBox tbDescricaoProduto;
        private AltComboBox cbUnidProduto;
        private AltComboBox cbSubGrupoProduto;
        private AltComboBox cbGrupoProduto;
        private System.Windows.Forms.Label labelIDProduto;
        private System.Windows.Forms.Button BtCadUnidade;
        private System.Windows.Forms.Button BtCadGrupo;
        private System.Windows.Forms.Button BtCadSubGrupo;
        private AltTextBox MtbPrecoCompra;
        private AltTextBox MtbMargemLucro;
        private AltTextBox MtbPrecoVenda;
        private AltTextBox txtNCM;
        private System.Windows.Forms.Button BtCadNCM;
    }
}