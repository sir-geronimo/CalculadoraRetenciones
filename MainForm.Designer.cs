using System.ComponentModel;

namespace CalculadoraRetenciones
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.SalaryTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.DeductionTotal = new System.Windows.Forms.TextBox();
            this.MoneyLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.Location = new System.Drawing.Point(43, 18);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(201, 23);
            this.SalaryLbl.TabIndex = 0;
            this.SalaryLbl.Text = "Sueldo del empleado";
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Location = new System.Drawing.Point(43, 44);
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(201, 23);
            this.SalaryTxtBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 160);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "3.04";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "2.87";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "ARS";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "AFP";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porcentajes de descuento";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(42, 73);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(201, 40);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "&Calcular";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.Calular);
            // 
            // ResultLbl
            // 
            this.ResultLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ResultLbl.Location = new System.Drawing.Point(43, 130);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(201, 23);
            this.ResultLbl.TabIndex = 4;
            this.ResultLbl.Text = "Total a descontar";
            // 
            // DeductionTotal
            // 
            this.DeductionTotal.Location = new System.Drawing.Point(44, 156);
            this.DeductionTotal.Name = "DeductionTotal";
            this.DeductionTotal.ReadOnly = true;
            this.DeductionTotal.Size = new System.Drawing.Size(200, 23);
            this.DeductionTotal.TabIndex = 8;
            // 
            // MoneyLeft
            // 
            this.MoneyLeft.Location = new System.Drawing.Point(45, 217);
            this.MoneyLeft.Name = "MoneyLeft";
            this.MoneyLeft.ReadOnly = true;
            this.MoneyLeft.Size = new System.Drawing.Size(199, 23);
            this.MoneyLeft.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dinero restante";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 432);
            this.Controls.Add(this.MoneyLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeductionTotal);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SalaryTxtBox);
            this.Controls.Add(this.SalaryLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = " Calculadora de retenciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox SalaryTxtBox;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.TextBox MoneyLeft;
        private System.Windows.Forms.TextBox DeductionTotal;
        private System.Windows.Forms.Label ResultLbl;
    }
}