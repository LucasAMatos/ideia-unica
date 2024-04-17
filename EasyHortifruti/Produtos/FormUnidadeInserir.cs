﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyHortifruti
{
    public partial class FormUnidadeAltInsert : FormBase
    {       
        public FormUnidadeAltInsert()
        {
            InitializeComponent();
        }
        private void FormUnidadeAltInsert_Load(object sender, EventArgs e)
        {
            if (idunidade > 0)
            {
                DataSet ds = new ConexaoBD().ConsultarTabelaPorId(idunidade, "UNIDADES");

                tbCadAbreviUni.Text = ds.Tables[0].Rows[0]["abrev_unid"].ToString();
                lbIDCadUnidade.Text = ds.Tables[0].Rows[0]["id_recno"].ToString();
                tbCadDescricaoUni.Text = ds.Tables[0].Rows[0]["desc_unid"].ToString();
                tbCadObsUni.Text = ds.Tables[0].Rows[0]["obs_unid"].ToString();
            }
        }

        private void BtGravarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string Abreviatura = tbCadAbreviUni.Text; // Obtém o texto do TextBox
                string Descricao = tbCadDescricaoUni.Text; // Obtém o texto do TextBox
                string Observacao = tbCadObsUni.Text; // Obtém o texto do TextBox

                if (idunidade > 0 )
                {
                    new ConexaoBD().AlterarUnidades(idunidade, Abreviatura, Descricao, Observacao);
                }
                else
                {
                    new ConexaoBD().InserirUnidades(Abreviatura, Descricao, Observacao);
                }               

                MessageBox.Show("gravou");
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BtCancelCadUnidade_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
