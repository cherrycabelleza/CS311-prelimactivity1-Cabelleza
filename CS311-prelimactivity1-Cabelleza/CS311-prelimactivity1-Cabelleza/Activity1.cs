using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_prelimactivity1_Cabelleza
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private decimal sidea, sideb, sidec, height, area, perimeter, computeAll;
        private int errorCount;
        //validations
        public void validateSideA()
        {
            if (string.IsNullOrEmpty(txtsidea.Text))
            {
                errorProvider1.SetError(txtsidea, "Input is empty");
            }
            else
            {
                errorProvider1.SetError(txtsidea, "");
            }

        }
        public void validateSideB()
        {
            if (string.IsNullOrEmpty(txtsideb.Text))
            {
                errorProvider1.SetError(txtsideb, "Input is empty");
            }
            else
            {
                errorProvider1.SetError(txtsideb, "");
            }

        }

        public void validateSideC()
        {
            if (string.IsNullOrEmpty(txtsidec.Text))
            {
                errorProvider1.SetError(txtsidec, "Input is empty");
            }
            else
            {
                errorProvider1.SetError(txtsidec, "");
            }

        }

        public void validateHeight()
        {
            if (string.IsNullOrEmpty(txtheight.Text))
            {
                errorProvider1.SetError(txtheight, "Input is empty");
            }
            else
            {
                errorProvider1.SetError(txtheight, "");
            }

        }


        private void countErrors()
        {
            errorCount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (!(string.IsNullOrEmpty(errorProvider1.GetError(c))))
                {
                    errorCount++;
                }
            }

        }



        private void btnarea_Click(object sender, EventArgs e)
        {
            validateSideB();
            validateHeight();
            countErrors();

            if (errorCount == 0)
            {
                sideb = int.Parse(txtsideb.Text);
                height = int.Parse(txtheight.Text);

                area = (sideb * height) / 2;
                txtarea.Text = area.ToString();
            }
        }

        private void btnperimeter_Click(object sender, EventArgs e)
        {
            validateSideA();
            validateSideB();
            validateSideC();
            countErrors();

            if (errorCount == 0)
            {
                sidea = int.Parse(txtsidea.Text);
                sideb = int.Parse(txtsideb.Text);
                sidec = int.Parse(txtsidec.Text);

                perimeter = sidea + sideb + sidec;
                txtperimeter.Text = perimeter.ToString();
            }
        }

        private void btncomputeall_Click(object sender, EventArgs e)
        {
            validateSideA();
            validateSideB();
            validateSideC();
            validateHeight();
            countErrors();

            if (errorCount == 0)
            {
                sidea = int.Parse(txtsidea.Text);
                sideb = int.Parse(txtsideb.Text);
                sidec = int.Parse(txtsidec.Text);
                height = int.Parse(txtheight.Text);

                area = (sideb * height) / 2;
                perimeter = sidea + sideb + sidec;

                txtarea.Text = area.ToString();
                txtperimeter.Text = perimeter.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtperimeter.Clear();
            txtsidea.Clear();
            txtsideb.Clear();
            txtsidec.Clear();
            txtheight.Clear();
            errorProvider1.Clear();
            txtsidea.Focus();
        }

        private void txtsidea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsidea, "Input must be numeric.");
                txtsidea.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsidea, "");
            }

        }

        private void txtsideb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsideb, "Input must be numeric.");
                txtsideb.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsideb, "");
            }


        }

        private void txtsidec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsidec, "Input must be numeric.");
                txtsidec.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsidec, "");
            }


        }

        private void txtheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtheight, "Input must be numeric.");
                txtheight.Focus();
            }
            else
            {
                errorProvider1.SetError(txtheight, "");
            }


        }

    }
}
