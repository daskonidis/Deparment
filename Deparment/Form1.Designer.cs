namespace Deparment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numLogicPort = new System.Windows.Forms.NumericUpDown();
            this.numDepartmentNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numVatCode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDefaultPrice = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ckbDefaultPrice = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKeyPosition = new System.Windows.Forms.Label();
            this.numKeyPosition = new System.Windows.Forms.NumericUpDown();
            this.ecr = new AxCOECRCOMLib.AxCoEcrCom();
            this.ckbSetKeyboard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLogicPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepartmentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVatCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logic Port:";
            // 
            // numLogicPort
            // 
            this.numLogicPort.Location = new System.Drawing.Point(76, 7);
            this.numLogicPort.Name = "numLogicPort";
            this.numLogicPort.Size = new System.Drawing.Size(45, 20);
            this.numLogicPort.TabIndex = 1;
            this.numLogicPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDepartmentNumber
            // 
            this.numDepartmentNumber.Location = new System.Drawing.Point(90, 21);
            this.numDepartmentNumber.Name = "numDepartmentNumber";
            this.numDepartmentNumber.Size = new System.Drawing.Size(45, 20);
            this.numDepartmentNumber.TabIndex = 3;
            this.numDepartmentNumber.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Αρ. Τμήματος:";
            // 
            // numVatCode
            // 
            this.numVatCode.Location = new System.Drawing.Point(90, 47);
            this.numVatCode.Name = "numVatCode";
            this.numVatCode.Size = new System.Drawing.Size(45, 20);
            this.numVatCode.TabIndex = 5;
            this.numVatCode.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Κωδ. Φ.Π.Α.:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(117, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Αξία:";
            this.lblPrice.Visible = false;
            // 
            // txtDefaultPrice
            // 
            this.txtDefaultPrice.Location = new System.Drawing.Point(157, 73);
            this.txtDefaultPrice.Name = "txtDefaultPrice";
            this.txtDefaultPrice.Size = new System.Drawing.Size(40, 20);
            this.txtDefaultPrice.TabIndex = 7;
            this.txtDefaultPrice.Text = "0.04";
            this.txtDefaultPrice.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(207, 172);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Αποστολή";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ckbDefaultPrice
            // 
            this.ckbDefaultPrice.AutoSize = true;
            this.ckbDefaultPrice.Location = new System.Drawing.Point(9, 75);
            this.ckbDefaultPrice.Name = "ckbDefaultPrice";
            this.ckbDefaultPrice.Size = new System.Drawing.Size(102, 17);
            this.ckbDefaultPrice.TabIndex = 9;
            this.ckbDefaultPrice.Text = "Εξορισμού Αξία";
            this.ckbDefaultPrice.UseVisualStyleBackColor = true;
            this.ckbDefaultPrice.CheckedChanged += new System.EventHandler(this.ckbDefaultPrice_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKeyPosition);
            this.groupBox1.Controls.Add(this.numKeyPosition);
            this.groupBox1.Controls.Add(this.ecr);
            this.groupBox1.Controls.Add(this.ckbSetKeyboard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckbDefaultPrice);
            this.groupBox1.Controls.Add(this.numDepartmentNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDefaultPrice);
            this.groupBox1.Controls.Add(this.numVatCode);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 133);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Τμήμα";
            // 
            // lblKeyPosition
            // 
            this.lblKeyPosition.AutoSize = true;
            this.lblKeyPosition.Location = new System.Drawing.Point(117, 105);
            this.lblKeyPosition.Name = "lblKeyPosition";
            this.lblKeyPosition.Size = new System.Drawing.Size(86, 13);
            this.lblKeyPosition.TabIndex = 14;
            this.lblKeyPosition.Text = "Θέση Πλήκτρου:";
            this.lblKeyPosition.Visible = false;
            // 
            // numKeyPosition
            // 
            this.numKeyPosition.Location = new System.Drawing.Point(209, 103);
            this.numKeyPosition.Name = "numKeyPosition";
            this.numKeyPosition.Size = new System.Drawing.Size(45, 20);
            this.numKeyPosition.TabIndex = 13;
            this.numKeyPosition.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numKeyPosition.Visible = false;
            // 
            // ecr
            // 
            this.ecr.Enabled = true;
            this.ecr.Location = new System.Drawing.Point(298, 9);
            this.ecr.Name = "ecr";
            this.ecr.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ecr.OcxState")));
            this.ecr.Size = new System.Drawing.Size(32, 32);
            this.ecr.TabIndex = 11;
            // 
            // ckbSetKeyboard
            // 
            this.ckbSetKeyboard.AutoSize = true;
            this.ckbSetKeyboard.Location = new System.Drawing.Point(9, 104);
            this.ckbSetKeyboard.Name = "ckbSetKeyboard";
            this.ckbSetKeyboard.Size = new System.Drawing.Size(110, 17);
            this.ckbSetKeyboard.TabIndex = 12;
            this.ckbSetKeyboard.Text = "Προγρ. Πλήκτρου";
            this.ckbSetKeyboard.UseVisualStyleBackColor = true;
            this.ckbSetKeyboard.CheckedChanged += new System.EventHandler(this.ckbSetKeyboard_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.numLogicPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.numLogicPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepartmentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVatCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLogicPort;
        private System.Windows.Forms.NumericUpDown numDepartmentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVatCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDefaultPrice;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox ckbDefaultPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxCOECRCOMLib.AxCoEcrCom ecr;
        private System.Windows.Forms.NumericUpDown numKeyPosition;
        private System.Windows.Forms.CheckBox ckbSetKeyboard;
        private System.Windows.Forms.Label lblKeyPosition;
    }
}

