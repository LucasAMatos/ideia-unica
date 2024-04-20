﻿using System;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGruposCad : FormBase
    {
        #region Propriedades
        public int IdSelecionado
        {
            get
            {
                DataGridViewSelectedRowCollection linhaSelecionada = DgViewCadGrupos.SelectedRows;

                if (linhaSelecionada != null && linhaSelecionada.Count == 1)
                    return Convert.ToInt32(linhaSelecionada[0].Cells["id"].Value);

                if (DgViewCadGrupos.SelectedCells.Count == 1)
                    return Convert.ToInt32(DgViewCadGrupos.Rows[DgViewCadGrupos.SelectedCells[0].RowIndex].Cells["id"].Value);

                return -1;
            }
        }
        #endregion

        #region Construtor
        public FormGruposCad()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormCadGrupos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void BtIncluirGrupo_Click(object sender, EventArgs e)
        {
            FormGruposAltInsert formGruposAltInsert = new FormGruposAltInsert();
            formGruposAltInsert.ShowDialog();

            CarregarGrid();
        }

        private void BtEditarGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                FormGruposAltInsert GruposAltInsert = new FormGruposAltInsert(IdSelecionado);
                GruposAltInsert.ShowDialog();

                CarregarGrid();
            }            
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void BtExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (IdSelecionado >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Excluir o registro?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new ConexaoBD().ExcluirRegistro(IdSelecionado, TabelasScript.TabelaGrupos);
                    MessageBox.Show("Registro excluído com sucesso");
                }

                CarregarGrid();
            }
            else
                MessageBox.Show("Selecione um registro para excluir");

        }

        private void BtSairGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        public void CarregarGrid()
        {
            DgViewCadGrupos.DataSource = new ConexaoBD().ConsultarTabela(TabelasScript.TabelaGrupos);
            DgViewCadGrupos.DataMember = "Table";
            DgViewCadGrupos.Sort(DgViewCadGrupos.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
        }
        #endregion
    }
}