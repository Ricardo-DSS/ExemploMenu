using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploMenu
{
    public partial class Form1 : Form
    {
        Cadastrar cadas;
        Consultar consul;
        Atualizar atuali;
        Excluir excluir;

        public Form1()
        {
            InitializeComponent();
            cadas = new Cadastrar();
            consul = new Consultar();
            atuali = new Atualizar();
            excluir = new Excluir();
        }//fim do construtor

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cadas.ShowDialog();
            Visible = true;
        }//fim do botao cadastrar

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            consul.ShowDialog();
            Visible = true;
        }//fim do botao consultar

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atuali.ShowDialog();
            Visible = true;
        }//fim do botao atualizar

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            excluir.ShowDialog();
            Visible = true;
        }//fim do botao excluir
    }//fim da classe
}//fim do projeto
