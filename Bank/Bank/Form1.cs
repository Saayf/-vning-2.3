using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class formBank : Form
    {
        public formBank()
        {
            InitializeComponent();
        }

        public string godkänd = "Utförd utan problem.";
        public string error = "Felaktig hantering.";

        Bank bank = new Bank();

        public Boolean godkändBelopp()
        {
            if(tbxBelopp.TextLength != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean godkändRegistrering()
        {
            if(tbxPersonNr.TextLength != 0 && tbxRänteSats.TextLength != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if(godkändRegistrering())
            {
                MessageBox.Show(godkänd);
                if(tbxKredit.TextLength == 0)
                {
                    //Skapa ett sparkonto
                    BankKonto nyKonto = new SparKonto(tbxPersonNr.Text, 0, double.Parse(tbxRänteSats.Text));
                    bank.konton.Add(nyKonto);
                    uppdateraListan();
                }
                else
                {
                    //Skapa ett lånekonto            
                    BankKonto nyKonto = new LåneKonto(tbxPersonNr.Text, 0, double.Parse(tbxRänteSats.Text), double.Parse(tbxKredit.Text));
                    bank.konton.Add(nyKonto);
                    uppdateraListan();
                }
                tbxPersonNr.Clear();
                tbxRänteSats.Clear();
                tbxKredit.Clear();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public void uppdateraListan()
        {
            lbxKonton.Items.Clear();
            foreach (BankKonto konto in bank.konton)
            {
                lbxKonton.Items.Add(konto);
            }
        }

        private void btnInsättning_Click(object sender, EventArgs e)
        {
            if (godkändBelopp() && lbxKonton.SelectedItem != null)
            {
                BankKonto valdKonto = (BankKonto)lbxKonton.SelectedItem;
                valdKonto.Insättning(double.Parse(tbxBelopp.Text));
                uppdateraListan();
                tbxBelopp.Clear();
                MessageBox.Show(godkänd);
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnUttag_Click(object sender, EventArgs e)
        {
            if (godkändBelopp() && lbxKonton.SelectedItem != null)
            {
                BankKonto valdKonto = (BankKonto)lbxKonton.SelectedItem;
                if (valdKonto.Uttag(double.Parse(tbxBelopp.Text)))
                {
                    uppdateraListan();
                    tbxBelopp.Clear();
                    MessageBox.Show(godkänd);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnÅrsRänta_Click(object sender, EventArgs e)
        {
            foreach (BankKonto konto in bank.konton)
            {
                konto.BeräknaRänta();
            }

            uppdateraListan();
        }
    }
}
