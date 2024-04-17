﻿namespace EasyHortifruti
{
    partial class FormCadGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadGrupos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DgViewCadGrupos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSairGrupo = new System.Windows.Forms.Button();
            this.BtPesquisarGrupo = new System.Windows.Forms.Button();
            this.BtImprimirGrupo = new System.Windows.Forms.Button();
            this.BtExcluirGrupo = new System.Windows.Forms.Button();
            this.BtEditarGrupo = new System.Windows.Forms.Button();
            this.BtIncluirGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGrupos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgViewCadGrupos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 374);
            this.panel4.TabIndex = 2;
            // 
            // DgViewCadGrupos
            // 
            this.DgViewCadGrupos.AllowUserToAddRows = false;
            this.DgViewCadGrupos.AllowUserToDeleteRows = false;
            this.DgViewCadGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCadGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.observacao,
            this.id});
            this.DgViewCadGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgViewCadGrupos.Location = new System.Drawing.Point(0, 0);
            this.DgViewCadGrupos.Name = "DgViewCadGrupos";
            this.DgViewCadGrupos.Size = new System.Drawing.Size(481, 374);
            this.DgViewCadGrupos.TabIndex = 0;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "nome_grupo";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 150;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "obs_grupo";
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            this.observacao.Width = 200;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_recno";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtSairGrupo);
            this.panel3.Controls.Add(this.BtPesquisarGrupo);
            this.panel3.Controls.Add(this.BtImprimirGrupo);
            this.panel3.Controls.Add(this.BtExcluirGrupo);
            this.panel3.Controls.Add(this.BtEditarGrupo);
            this.panel3.Controls.Add(this.BtIncluirGrupo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 64);
            this.panel3.TabIndex = 1;
            // 
            // BtSairGrupo
            // 
            this.BtSairGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSairGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtSairGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSairGrupo.BackgroundImage")));
            this.BtSairGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSairGrupo.FlatAppearance.BorderSize = 0;
            this.BtSairGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSairGrupo.Location = new System.Drawing.Point(418, 6);
            this.BtSairGrupo.Name = "BtSairGrupo";
            this.BtSairGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtSairGrupo.Size = new System.Drawing.Size(44, 52);
            this.BtSairGrupo.TabIndex = 15;
            this.BtSairGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSairGrupo.UseVisualStyleBackColor = false;
            this.BtSairGrupo.Click += new System.EventHandler(this.BtSairGrupo_Click);
            // 
            // BtPesquisarGrupo
            // 
            this.BtPesquisarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtPesquisarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtPesquisarGrupo.BackgroundImage")));
            this.BtPesquisarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPesquisarGrupo.FlatAppearance.BorderSize = 0;
            this.BtPesquisarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPesquisarGrupo.Location = new System.Drawing.Point(171, 7);
            this.BtPesquisarGrupo.Name = "BtPesquisarGrupo";
            this.BtPesquisarGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtPesquisarGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtPesquisarGrupo.TabIndex = 14;
            this.BtPesquisarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPesquisarGrupo.UseVisualStyleBackColor = false;
            // 
            // BtImprimirGrupo
            // 
            this.BtImprimirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtImprimirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtImprimirGrupo.BackgroundImage")));
            this.BtImprimirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtImprimirGrupo.FlatAppearance.BorderSize = 0;
            this.BtImprimirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImprimirGrupo.Location = new System.Drawing.Point(223, 7);
            this.BtImprimirGrupo.Name = "BtImprimirGrupo";
            this.BtImprimirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtImprimirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtImprimirGrupo.TabIndex = 13;
            this.BtImprimirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtImprimirGrupo.UseVisualStyleBackColor = false;
            // 
            // BtExcluirGrupo
            // 
            this.BtExcluirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtExcluirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtExcluirGrupo.BackgroundImage")));
            this.BtExcluirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtExcluirGrupo.FlatAppearance.BorderSize = 0;
            this.BtExcluirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExcluirGrupo.Location = new System.Drawing.Point(119, 6);
            this.BtExcluirGrupo.Name = "BtExcluirGrupo";
            this.BtExcluirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtExcluirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtExcluirGrupo.TabIndex = 12;
            this.BtExcluirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtExcluirGrupo.UseVisualStyleBackColor = false;
            this.BtExcluirGrupo.Click += new System.EventHandler(this.BtExcluirGrupo_Click);
            // 
            // BtEditarGrupo
            // 
            this.BtEditarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtEditarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditarGrupo.BackgroundImage")));
            this.BtEditarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditarGrupo.FlatAppearance.BorderSize = 0;
            this.BtEditarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditarGrupo.Location = new System.Drawing.Point(67, 6);
            this.BtEditarGrupo.Name = "BtEditarGrupo";
            this.BtEditarGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtEditarGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtEditarGrupo.TabIndex = 11;
            this.BtEditarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditarGrupo.UseVisualStyleBackColor = false;
            this.BtEditarGrupo.Click += new System.EventHandler(this.BtEditarGrupo_Click);
            // 
            // BtIncluirGrupo
            // 
            this.BtIncluirGrupo.BackColor = System.Drawing.Color.Transparent;
            this.BtIncluirGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtIncluirGrupo.BackgroundImage")));
            this.BtIncluirGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIncluirGrupo.FlatAppearance.BorderSize = 0;
            this.BtIncluirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIncluirGrupo.Location = new System.Drawing.Point(15, 6);
            this.BtIncluirGrupo.Name = "BtIncluirGrupo";
            this.BtIncluirGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtIncluirGrupo.Size = new System.Drawing.Size(46, 52);
            this.BtIncluirGrupo.TabIndex = 10;
            this.BtIncluirGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtIncluirGrupo.UseVisualStyleBackColor = false;
            this.BtIncluirGrupo.Click += new System.EventHandler(this.BtIncluirGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 57);
            this.panel2.TabIndex = 0;
            // 
            // FormCadGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 495);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.FormCadGrupos_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCadGrupos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DgViewCadGrupos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtPesquisarGrupo;
        private System.Windows.Forms.Button BtImprimirGrupo;
        private System.Windows.Forms.Button BtExcluirGrupo;
        private System.Windows.Forms.Button BtEditarGrupo;
        private System.Windows.Forms.Button BtIncluirGrupo;
        private System.Windows.Forms.Button BtSairGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}