using Relembrando_POO.Domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relembrando_POO
{
    
    public partial class FrmAgendar : Form
    {
        //ATRIBUTO global
        Agendamento agenda;

        //Método construtor
        public FrmAgendar()
        {
            InitializeComponent();

            if (rdbConv.Checked == true)
            {
                txtConv.Visible = true;
                txtNconv.Visible = true;
                lblNconv.Visible = true;
                lblConvenio.Visible = true;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string hora, nome, sus, rg, nconv="", conv="", nomeM, crm, esp;
            int dia, mes, ano;
            bool p=false, c = false, s = false;
            bool tc = false;
            dia = dtpData.Value.Day;
            mes = dtpData.Value.Month;
            ano = dtpData.Value.Year;
            hora = txtHora.Text;
            nome = txtNome.Text;
            sus = txtSus.Text;
            rg = txtRG.Text;
            nomeM = txtNomeM.Text;
            crm = txtCRM.Text;
            esp = txtEsp.Text;
            if (rdbConv.Checked == true)
            {
                nconv = txtNconv.Text;
                conv = txtConv.Text;
                tc = true;
            }
            if (ckbSus.Checked)
            {
                s = true;
            }
            if (ckbConv.Checked)
            {
                c = true;
            }
            if (ckbPart.Checked)
            {
                p = true;
            }
            agenda = new Agendamento();
            var data = new DateTime(ano, mes, dia);
            var tempo = TimeSpan.Parse($"{hora}");
            //lblDados.Text = tempo.ToString();
            Paciente pac = agenda.CadastraPaciente(nome, rg, tc, sus);
            pac.CadastrarConvenio(conv, nconv);
            Medico med = agenda.CadastraMedico(nomeM, crm, esp, p, s, c);
            agenda = new Agendamento(data, tempo, pac, med);
            MessageBox.Show("Agendamento feito com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDados.Text = agenda.infosAgendamento()+pac.ExibirDados()+med.ExibirDados();
        }
    }
}
