using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Own_Pizza
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }
        void AddSizeToOrderSummary()
        {
            if (rbSizeSmall.Checked)
            {
                lblOrderSummarySize.Text = "Small";
                return;
            }

            if (rbSizeMedium.Checked)
            {
                lblOrderSummarySize.Text = "Medium";
                return;
            }

            if (rbSizeLarge.Checked)
            {
                lblOrderSummarySize.Text = "Large";
                return;
            }

        }

        void AddToppingsToOrderSummary()
        {
            string Toppings = "";

            if (chkToppingExtraCheese.Checked)
            {
                Toppings += " Extra Cheese ";
            }

            if (chkToppingJalapeño.Checked)
            {
                Toppings += "\n Jalapeño ";
            }

            if (chkToppingMushroom.Checked)
            {
                Toppings += " Mushroom ";
            }

            if (chkToppingOlive.Checked)
            {
                Toppings += "\n Olive ";
            }

            if (chkToppingOnion.Checked)
            {
                Toppings += " Onion ";
            }

            if (chkToppingTomato.Checked)
            {
                Toppings += "\n Tomato ";
            }

            if(Toppings == "")
            {
                Toppings = "No Toppings";
            }

            lblOrderSummaryToppings.Text = Toppings;

        }

        void AddCrustToOrderSummary()
        {
            if (rbCrustThick.Checked)
            {
                lblOrderSummaryCrustType.Text = "Thick";
            }
            else lblOrderSummaryCrustType.Text = "Thin";
        }

        void AddWhereToEatToOrderSummary()
        {
            if (rbDineIn.Checked)
            {
                lblOrderSummaryWhereToEat.Text = "Eat In";
            }
            else lblOrderSummaryWhereToEat.Text = "Take Out";
        }
        float CalculateSizePrice()
        {
            if (rbSizeSmall.Checked)
            { return Convert.ToSingle(rbSizeSmall.Tag); }

            else if (rbSizeMedium.Checked)
            { return Convert.ToSingle(rbSizeMedium.Tag); }

            else
            { return Convert.ToSingle(rbSizeLarge.Tag); }
 
        }
    
        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (chkToppingExtraCheese.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingExtraCheese.Tag);
            }
            if (chkToppingJalapeño.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingJalapeño.Tag);
            }
            if (chkToppingMushroom.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingMushroom.Tag);
            }
            if (chkToppingOlive.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingOlive.Tag);
            }
            if (chkToppingOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingOnion.Tag);
            }
            if (chkToppingTomato.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkToppingTomato.Tag);
            }

            return ToppingsPrice;

        }

        float CalculateCrustPrice()
        {
            float CrustPrice = 0;
            if (rbCrustThick.Checked)
            {
                CrustPrice += Convert.ToSingle(rbCrustThick.Tag);
            }

            return CrustPrice;
        }

        float CalculateTotalPrice()
        {
            return CalculateSizePrice() + CalculateCrustPrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lblOrderSummaryPrice.Text = "$" + Convert.ToString(CalculateTotalPrice()); 
        }
        private void rbSizeSmall_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateTotalPrice();
            AddSizeToOrderSummary();
        }

        private void rbSizeMedium_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateTotalPrice();
            AddSizeToOrderSummary();
        }

        private void rbSizeLarge_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateTotalPrice();
            AddSizeToOrderSummary();
        }

        private void chkToppingExtraCheese_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
                
        }

        private void chkToppingMushroom_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
        }

        private void chkToppingTomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
        }

        private void chkToppingOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
        }

        private void chkToppingOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
        }

        private void chkToppingJalapeño_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddToppingsToOrderSummary();
        }

        private void rbCrustThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddCrustToOrderSummary();

        }

        private void rbCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            AddCrustToOrderSummary();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            AddWhereToEatToOrderSummary();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            AddWhereToEatToOrderSummary();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Place Order?", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled =true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Crust Type
            rbCrustThin.Checked = true;

            //reset Size
            rbSizeSmall.Checked = true;

            //reset Toppings
            chkToppingExtraCheese.Checked = false;
            chkToppingJalapeño.Checked = false;
            chkToppingMushroom.Checked = false;
            chkToppingOlive.Checked = false;
            chkToppingOnion.Checked = false;
            chkToppingTomato.Checked = false;

            //reset Where To Eat
            rbDineIn.Checked = true;
           
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
