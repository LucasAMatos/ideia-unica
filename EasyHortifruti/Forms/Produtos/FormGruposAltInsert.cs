﻿using System;
using System.Data;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormGruposAltInsert : FormBase
    {
        #region construtor

        public FormGruposAltInsert()
        {
            InitializeComponent();
        }

        public FormGruposAltInsert(int pID)
        {
            Id = pID;
            InitializeComponent();
        }

        #endregion construtor

        #region Eventos

        private void FormGruposAltInsert_Load(object sender, EventArgs e)
        {
            LimpaCampos();

            PreencheCampos();
        }

        private void BtGravarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                Criticar();
                string Descricao = TbDescGrupo.Text; // Obtém o texto do TextBox
                string Observacao = TbObsGrupo.Text; // Obtém o texto do TextBox
                string MargemLucro = string.IsNullOrEmpty(TbMargemGrupo.Text) ? "0" : TbMargemGrupo.Text; // Obtém o texto do TextBox

                if (string.IsNullOrEmpty(TbDescGrupo.Text))
                    throw new Exception("Nome do grupo é Obrigatório");

                if (string.IsNullOrEmpty(TbDescGrupo.Text))
                    throw new Exception("Nome do grupo é Obrigatório");

                if (Alterar)
                {
                    new ConexaoBD().AlterarGrupo(Id, Descricao, Observacao, MargemLucro);

                    MessageBox.Show(string.Format("Grupo Alterado com Sucesso!"));
                    this.Close();
                }
                else
                {
                    new ConexaoBD().InserirGrupo(Descricao, Observacao, MargemLucro);

                    DialogResult pNovaUnidade = MessageBox.Show(string.Format("Grupo {0} criado com sucesso! Deseja cadastrar uma nova unidade?", Descricao), string.Empty, MessageBoxButtons.YesNo);
                    if (pNovaUnidade == DialogResult.Yes)
                    {
                        LimpaCampos();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelGrupo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos

        #region Metodos

        private void LimpaCampos()
        {
            TbDescGrupo.Text = string.Empty;
            TbObsGrupo.Text = string.Empty;
            TbMargemGrupo.Text = string.Empty;
            LbIDGrupo.Visible = Alterar;
        }

        private void PreencheCampos()
        {
            if (Alterar)
            {
                DataSet ds = new ConexaoBD().ConsultarGrupoPorId(Id);

                TbDescGrupo.Text = ds.Tables[0].Rows[0]["nome_grupo"].ToString();
                TbObsGrupo.Text = ds.Tables[0].Rows[0]["Obs_grupo"].ToString();
                TbMargemGrupo.Text = ds.Tables[0].Rows[0]["margem_grupo"].ToString();
                LbIDGrupo.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
            }
        }

        #endregion Metodos
    }
}