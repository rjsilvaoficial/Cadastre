using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controle;

namespace View
{
    public partial class Menu_Inicial : Form
    {
        public Menu_Inicial()
        {
            InitializeComponent();
            txtCpf.Visible = false;
            lblCpf.Visible = false;

            txtNome.Visible = false;
            lblNome.Visible = false;

            txtFone.Visible = false;
            lblFone.Visible = false;

            btnConfirmaIncluir.Visible = false;
            btnConfirmaBuscar.Visible = false;
            btnConfirmaAtualizar.Visible = false;
            btnConfirmaDeletar.Visible = false;

            atualizarToolStripMenuItem.Visible = false;

        }

        private void btnConfirmaIncluir_Click(object sender, EventArgs e)
        {
            ctlContato _ctlContato = new ctlContato();

            _ctlContato.IncluirContato(long.Parse(txtCpf.Text), txtNome.Text, long.Parse(txtFone.Text));
            
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        private void btnConfirmaBuscar_Click(object sender, EventArgs e)
        {
            ctlContato _ctlContato = new ctlContato();

            _ctlContato.PesquisarContato(long.Parse(txtCpf.Text), out mdlContato _dbContato);

            if(_dbContato.nome != null)
            {
                txtCpf.Enabled = false;
                lblCpf.Enabled = false;

                txtNome.Visible = true;
                lblNome.Visible = true;

                txtFone.Visible = true;
                lblFone.Visible = true;

                btnConfirmaIncluir.Visible = false;
                btnConfirmaBuscar.Visible = true;
                btnConfirmaAtualizar.Visible = false;
                btnConfirmaDeletar.Visible = false;



                txtNome.Text = _dbContato.nome;
                txtFone.Text = _dbContato.telefone.ToString();
                MessageBox.Show("Cadastro encontrado com sucesso!");

                txtNome.Enabled = false;
                lblNome.Enabled = false;
                txtFone.Enabled = false;
                lblFone.Enabled = false;

                atualizarToolStripMenuItem.Visible = true;
            }
            else
            {
                txtNome.Visible = false;
                lblNome.Visible = false;
                txtFone.Visible = false;
                lblFone.Visible = false;
                MessageBox.Show("Cadastro não encontrado!");
            }
        }

        private void btnConfirmaAtualizar_Click(object sender, EventArgs e)
        {
            ctlContato _ctlContato = new ctlContato();

            _ctlContato.AtualizarContato(long.Parse(txtCpf.Text), txtNome.Text,long.Parse(txtFone.Text));

            MessageBox.Show("Cadastro atualizado com sucesso!");
        }

        private void btnConfirmaDeletar_Click(object sender, EventArgs e)
        {
            ctlContato _ctlContato = new ctlContato();

            _ctlContato.DeletarContato(long.Parse(txtCpf.Text));

            MessageBox.Show("Cadastro excluído com sucesso!");
        }


        //Configurações de exibição de itens do MenuStrip
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCpf.Visible = true;
            lblCpf.Visible = true;

            txtNome.Visible = true;
            lblNome.Visible = true;

            txtFone.Visible = true;
            lblFone.Visible = true;

            btnConfirmaIncluir.Visible = true;
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCpf.Enabled = true;
            lblCpf.Enabled = true;
            txtCpf.Visible = true;
            lblCpf.Visible = true;

            btnConfirmaBuscar.Visible = true;

            txtNome.Visible = false;
            lblNome.Visible = false;

            txtFone.Visible = false;
            lblFone.Visible = false;

            btnConfirmaIncluir.Visible = false;
            btnConfirmaAtualizar.Visible = false;
            btnConfirmaDeletar.Visible = false;


        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            lblNome.Enabled = true;
            txtFone.Enabled = true;
            lblFone.Enabled = true;
            btnConfirmaAtualizar.Visible = true;
            btnConfirmaDeletar.Visible = true;

        }
    }
}
