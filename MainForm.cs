using System;
using System.Windows.Forms;

namespace CalculadoraRetenciones
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calular(object sender, EventArgs e)
        {
            const double afp = 0.0287;
            const double ars = 0.0304;
            double salary = 0;
            
            try
            {
                salary = double.Parse(SalaryTxtBox.Text);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Solo se aceptan numeros",
                    "Eror",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
            if (salary < 7000)
            {
                salary = 7000;
            }

            if (salary > 200000)
            {
                salary = 200000;
            }

            double afpDeduction = salary * afp;
            double arsDeduction = salary * ars;
            
            DeductionTotal.Text = (afpDeduction + arsDeduction).ToString();
            MoneyLeft.Text = (salary - (afpDeduction + arsDeduction)).ToString();
        }
    }
}