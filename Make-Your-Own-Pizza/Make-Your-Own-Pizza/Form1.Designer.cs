namespace Make_Your_Own_Pizza
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSizeLarge = new System.Windows.Forms.RadioButton();
            this.rbSizeMedium = new System.Windows.Forms.RadioButton();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkToppingJalapeño = new System.Windows.Forms.CheckBox();
            this.chkToppingOlive = new System.Windows.Forms.CheckBox();
            this.chkToppingOnion = new System.Windows.Forms.CheckBox();
            this.chkToppingTomato = new System.Windows.Forms.CheckBox();
            this.chkToppingMushroom = new System.Windows.Forms.CheckBox();
            this.chkToppingExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbCrustThick = new System.Windows.Forms.RadioButton();
            this.rbCrustThin = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblOrderSummaryWhereToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderSummaryToppings = new System.Windows.Forms.Label();
            this.lblOrderSummaryPrice = new System.Windows.Forms.Label();
            this.lblOrderSummaryCrustType = new System.Windows.Forms.Label();
            this.lblOrderSummarySize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(275, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSizeLarge);
            this.gbSize.Controls.Add(this.rbSizeMedium);
            this.gbSize.Controls.Add(this.rbSizeSmall);
            this.gbSize.Location = new System.Drawing.Point(12, 91);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(97, 131);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbSizeLarge
            // 
            this.rbSizeLarge.AutoSize = true;
            this.rbSizeLarge.Location = new System.Drawing.Point(6, 108);
            this.rbSizeLarge.Name = "rbSizeLarge";
            this.rbSizeLarge.Size = new System.Drawing.Size(52, 17);
            this.rbSizeLarge.TabIndex = 2;
            this.rbSizeLarge.TabStop = true;
            this.rbSizeLarge.Tag = "40";
            this.rbSizeLarge.Text = "Large";
            this.rbSizeLarge.UseVisualStyleBackColor = true;
            this.rbSizeLarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSizeLarge_MouseClick);
            // 
            // rbSizeMedium
            // 
            this.rbSizeMedium.AutoSize = true;
            this.rbSizeMedium.Location = new System.Drawing.Point(6, 69);
            this.rbSizeMedium.Name = "rbSizeMedium";
            this.rbSizeMedium.Size = new System.Drawing.Size(62, 17);
            this.rbSizeMedium.TabIndex = 1;
            this.rbSizeMedium.TabStop = true;
            this.rbSizeMedium.Tag = "30";
            this.rbSizeMedium.Text = "Medium";
            this.rbSizeMedium.UseVisualStyleBackColor = true;
            this.rbSizeMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSizeMedium_MouseClick);
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Checked = true;
            this.rbSizeSmall.Location = new System.Drawing.Point(6, 30);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSizeSmall.TabIndex = 0;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Tag = "20";
            this.rbSizeSmall.Text = "Small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            this.rbSizeSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSizeSmall_MouseClick);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkToppingJalapeño);
            this.gbToppings.Controls.Add(this.chkToppingOlive);
            this.gbToppings.Controls.Add(this.chkToppingOnion);
            this.gbToppings.Controls.Add(this.chkToppingTomato);
            this.gbToppings.Controls.Add(this.chkToppingMushroom);
            this.gbToppings.Controls.Add(this.chkToppingExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(269, 92);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(202, 128);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkToppingJalapeño
            // 
            this.chkToppingJalapeño.AutoSize = true;
            this.chkToppingJalapeño.Location = new System.Drawing.Point(116, 106);
            this.chkToppingJalapeño.Name = "chkToppingJalapeño";
            this.chkToppingJalapeño.Size = new System.Drawing.Size(69, 17);
            this.chkToppingJalapeño.TabIndex = 5;
            this.chkToppingJalapeño.Tag = "5";
            this.chkToppingJalapeño.Text = "Jalapeño";
            this.chkToppingJalapeño.UseVisualStyleBackColor = true;
            this.chkToppingJalapeño.CheckedChanged += new System.EventHandler(this.chkToppingJalapeño_CheckedChanged);
            // 
            // chkToppingOlive
            // 
            this.chkToppingOlive.AutoSize = true;
            this.chkToppingOlive.Location = new System.Drawing.Point(116, 67);
            this.chkToppingOlive.Name = "chkToppingOlive";
            this.chkToppingOlive.Size = new System.Drawing.Size(50, 17);
            this.chkToppingOlive.TabIndex = 4;
            this.chkToppingOlive.Tag = "5";
            this.chkToppingOlive.Text = "Olive";
            this.chkToppingOlive.UseVisualStyleBackColor = true;
            this.chkToppingOlive.CheckedChanged += new System.EventHandler(this.chkToppingOlive_CheckedChanged);
            // 
            // chkToppingOnion
            // 
            this.chkToppingOnion.AutoSize = true;
            this.chkToppingOnion.Location = new System.Drawing.Point(116, 28);
            this.chkToppingOnion.Name = "chkToppingOnion";
            this.chkToppingOnion.Size = new System.Drawing.Size(54, 17);
            this.chkToppingOnion.TabIndex = 3;
            this.chkToppingOnion.Tag = "5";
            this.chkToppingOnion.Text = "Onion";
            this.chkToppingOnion.UseVisualStyleBackColor = true;
            this.chkToppingOnion.CheckedChanged += new System.EventHandler(this.chkToppingOnion_CheckedChanged);
            // 
            // chkToppingTomato
            // 
            this.chkToppingTomato.AutoSize = true;
            this.chkToppingTomato.Location = new System.Drawing.Point(6, 106);
            this.chkToppingTomato.Name = "chkToppingTomato";
            this.chkToppingTomato.Size = new System.Drawing.Size(62, 17);
            this.chkToppingTomato.TabIndex = 2;
            this.chkToppingTomato.Tag = "5";
            this.chkToppingTomato.Text = "Tomato";
            this.chkToppingTomato.UseVisualStyleBackColor = true;
            this.chkToppingTomato.CheckedChanged += new System.EventHandler(this.chkToppingTomato_CheckedChanged);
            // 
            // chkToppingMushroom
            // 
            this.chkToppingMushroom.AutoSize = true;
            this.chkToppingMushroom.Location = new System.Drawing.Point(6, 67);
            this.chkToppingMushroom.Name = "chkToppingMushroom";
            this.chkToppingMushroom.Size = new System.Drawing.Size(75, 17);
            this.chkToppingMushroom.TabIndex = 1;
            this.chkToppingMushroom.Tag = "5";
            this.chkToppingMushroom.Text = "Mushroom";
            this.chkToppingMushroom.UseVisualStyleBackColor = true;
            this.chkToppingMushroom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppingMushroom_MouseClick);
            // 
            // chkToppingExtraCheese
            // 
            this.chkToppingExtraCheese.AutoSize = true;
            this.chkToppingExtraCheese.Location = new System.Drawing.Point(6, 28);
            this.chkToppingExtraCheese.Name = "chkToppingExtraCheese";
            this.chkToppingExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.chkToppingExtraCheese.TabIndex = 0;
            this.chkToppingExtraCheese.Tag = "5";
            this.chkToppingExtraCheese.Text = "Extra Cheese";
            this.chkToppingExtraCheese.UseVisualStyleBackColor = true;
            this.chkToppingExtraCheese.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppingExtraCheese_MouseClick);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbCrustThick);
            this.gbCrustType.Controls.Add(this.rbCrustThin);
            this.gbCrustType.Location = new System.Drawing.Point(12, 291);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(97, 97);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbCrustThick
            // 
            this.rbCrustThick.AutoSize = true;
            this.rbCrustThick.Location = new System.Drawing.Point(6, 74);
            this.rbCrustThick.Name = "rbCrustThick";
            this.rbCrustThick.Size = new System.Drawing.Size(52, 17);
            this.rbCrustThick.TabIndex = 2;
            this.rbCrustThick.TabStop = true;
            this.rbCrustThick.Tag = "5";
            this.rbCrustThick.Text = "Thick";
            this.rbCrustThick.UseVisualStyleBackColor = true;
            this.rbCrustThick.CheckedChanged += new System.EventHandler(this.rbCrustThick_CheckedChanged);
            // 
            // rbCrustThin
            // 
            this.rbCrustThin.AutoSize = true;
            this.rbCrustThin.Checked = true;
            this.rbCrustThin.Location = new System.Drawing.Point(6, 36);
            this.rbCrustThin.Name = "rbCrustThin";
            this.rbCrustThin.Size = new System.Drawing.Size(46, 17);
            this.rbCrustThin.TabIndex = 1;
            this.rbCrustThin.TabStop = true;
            this.rbCrustThin.Text = "Thin";
            this.rbCrustThin.UseVisualStyleBackColor = true;
            this.rbCrustThin.CheckedChanged += new System.EventHandler(this.rbCrustThin_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbDineIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(314, 293);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(112, 92);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(6, 69);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Checked = true;
            this.rbDineIn.Location = new System.Drawing.Point(6, 34);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(59, 17);
            this.rbDineIn.TabIndex = 2;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            this.rbDineIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(269, 403);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(71, 35);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(400, 403);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(71, 35);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryWhereToEat);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryToppings);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryPrice);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummaryCrustType);
            this.gbOrderSummary.Controls.Add(this.lblOrderSummarySize);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Location = new System.Drawing.Point(561, 92);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(204, 327);
            this.gbOrderSummary.TabIndex = 7;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblOrderSummaryWhereToEat
            // 
            this.lblOrderSummaryWhereToEat.AutoSize = true;
            this.lblOrderSummaryWhereToEat.Location = new System.Drawing.Point(126, 239);
            this.lblOrderSummaryWhereToEat.Name = "lblOrderSummaryWhereToEat";
            this.lblOrderSummaryWhereToEat.Size = new System.Drawing.Size(41, 13);
            this.lblOrderSummaryWhereToEat.TabIndex = 18;
            this.lblOrderSummaryWhereToEat.Text = "Dine In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Where To Eat:";
            // 
            // lblOrderSummaryToppings
            // 
            this.lblOrderSummaryToppings.AutoSize = true;
            this.lblOrderSummaryToppings.Location = new System.Drawing.Point(12, 96);
            this.lblOrderSummaryToppings.Name = "lblOrderSummaryToppings";
            this.lblOrderSummaryToppings.Size = new System.Drawing.Size(68, 13);
            this.lblOrderSummaryToppings.TabIndex = 16;
            this.lblOrderSummaryToppings.Text = "No Toppings";
            // 
            // lblOrderSummaryPrice
            // 
            this.lblOrderSummaryPrice.AutoSize = true;
            this.lblOrderSummaryPrice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummaryPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblOrderSummaryPrice.Location = new System.Drawing.Point(98, 284);
            this.lblOrderSummaryPrice.Name = "lblOrderSummaryPrice";
            this.lblOrderSummaryPrice.Size = new System.Drawing.Size(57, 43);
            this.lblOrderSummaryPrice.TabIndex = 15;
            this.lblOrderSummaryPrice.Text = "$0";
            // 
            // lblOrderSummaryCrustType
            // 
            this.lblOrderSummaryCrustType.AutoSize = true;
            this.lblOrderSummaryCrustType.Location = new System.Drawing.Point(126, 171);
            this.lblOrderSummaryCrustType.Name = "lblOrderSummaryCrustType";
            this.lblOrderSummaryCrustType.Size = new System.Drawing.Size(28, 13);
            this.lblOrderSummaryCrustType.TabIndex = 14;
            this.lblOrderSummaryCrustType.Text = "Thin";
            // 
            // lblOrderSummarySize
            // 
            this.lblOrderSummarySize.AutoSize = true;
            this.lblOrderSummarySize.Location = new System.Drawing.Point(66, 37);
            this.lblOrderSummarySize.Name = "lblOrderSummarySize";
            this.lblOrderSummarySize.Size = new System.Drawing.Size(32, 13);
            this.lblOrderSummarySize.TabIndex = 12;
            this.lblOrderSummarySize.Text = "Small";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Crust Type: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toppings: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size: ";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSizeLarge;
        private System.Windows.Forms.RadioButton rbSizeMedium;
        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkToppingJalapeño;
        private System.Windows.Forms.CheckBox chkToppingOlive;
        private System.Windows.Forms.CheckBox chkToppingOnion;
        private System.Windows.Forms.CheckBox chkToppingTomato;
        private System.Windows.Forms.CheckBox chkToppingMushroom;
        private System.Windows.Forms.CheckBox chkToppingExtraCheese;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbCrustThick;
        private System.Windows.Forms.RadioButton rbCrustThin;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderSummaryPrice;
        private System.Windows.Forms.Label lblOrderSummaryCrustType;
        private System.Windows.Forms.Label lblOrderSummarySize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderSummaryToppings;
        private System.Windows.Forms.Label lblOrderSummaryWhereToEat;
        private System.Windows.Forms.Label label5;
    }
}

