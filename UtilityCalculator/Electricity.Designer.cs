namespace UtilityCalculator
{
    partial class Electricity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnMonth = new System.Windows.Forms.RadioButton();
            this.rbnDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtWattage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.lsvAppliance = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnMonth);
            this.groupBox1.Controls.Add(this.rbnDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtUsage);
            this.groupBox1.Controls.Add(this.txtWattage);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Location = new System.Drawing.Point(31, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance";
            // 
            // rbnMonth
            // 
            this.rbnMonth.AutoSize = true;
            this.rbnMonth.Location = new System.Drawing.Point(349, 77);
            this.rbnMonth.Name = "rbnMonth";
            this.rbnMonth.Size = new System.Drawing.Size(54, 17);
            this.rbnMonth.TabIndex = 11;
            this.rbnMonth.Text = "month";
            this.rbnMonth.UseVisualStyleBackColor = true;
            // 
            // rbnDay
            // 
            this.rbnDay.AutoSize = true;
            this.rbnDay.Checked = true;
            this.rbnDay.Location = new System.Drawing.Point(301, 77);
            this.rbnDay.Name = "rbnDay";
            this.rbnDay.Size = new System.Drawing.Size(42, 17);
            this.rbnDay.TabIndex = 10;
            this.rbnDay.TabStop = true;
            this.rbnDay.Text = "day";
            this.rbnDay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "hour per";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(143, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(143, 76);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(100, 20);
            this.txtUsage.TabIndex = 6;
            // 
            // txtWattage
            // 
            this.txtWattage.Location = new System.Drawing.Point(143, 50);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(100, 20);
            this.txtWattage.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wattage(W)";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(77, 27);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(54, 13);
            this.A.TabIndex = 0;
            this.A.Text = "Appliance";
            // 
            // lsvAppliance
            // 
            this.lsvAppliance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvAppliance.FullRowSelect = true;
            this.lsvAppliance.HideSelection = false;
            this.lsvAppliance.Location = new System.Drawing.Point(31, 173);
            this.lsvAppliance.Name = "lsvAppliance";
            this.lsvAppliance.Size = new System.Drawing.Size(516, 164);
            this.lsvAppliance.TabIndex = 1;
            this.lsvAppliance.UseCompatibleStateImageBehavior = false;
            this.lsvAppliance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Appliance";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wattage(W)";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Usage";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Consumption(kWh)";
            this.columnHeader5.Width = 115;
            // 
            // txtConsumption
            // 
            this.txtConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumption.Location = new System.Drawing.Point(406, 347);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.ReadOnly = true;
            this.txtConsumption.Size = new System.Drawing.Size(141, 20);
            this.txtConsumption.TabIndex = 2;
            this.txtConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.Location = new System.Drawing.Point(407, 373);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(140, 20);
            this.txtBillAmount.TabIndex = 3;
            this.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.Location = new System.Drawing.Point(407, 399);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.ReadOnly = true;
            this.txtServiceCharge.Size = new System.Drawing.Size(140, 20);
            this.txtServiceCharge.TabIndex = 4;
            this.txtServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBill.Location = new System.Drawing.Point(406, 425);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(141, 20);
            this.txtTotalBill.TabIndex = 5;
            this.txtTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Consumption(kWh):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bill AMount(ETB):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Service Charge(ETB):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Payable Bill Amount(ETB):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(406, 451);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Electricity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 499);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.lsvAppliance);
            this.Controls.Add(this.groupBox1);
            this.Name = "Electricity";
            this.Text = "Electricity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnMonth;
        private System.Windows.Forms.RadioButton rbnDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtWattage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.ListView lsvAppliance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
    }
}