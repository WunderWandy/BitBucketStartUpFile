
namespace A1WandaEbyCalculator
{
    partial class MainForm
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.lblDisplayEquation = new System.Windows.Forms.Label();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(66, 156);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(44, 42);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(128, 156);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(44, 42);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(66, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearClick);
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Location = new System.Drawing.Point(66, 57);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.ReadOnly = true;
            this.txtCurrentValue.Size = new System.Drawing.Size(280, 22);
            this.txtCurrentValue.TabIndex = 5;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(268, 305);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(45, 42);
            this.btnEquals.TabIndex = 7;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.EqualsClick);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(268, 156);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(45, 42);
            this.btnSubtract.TabIndex = 8;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(268, 204);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(45, 42);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(268, 252);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 42);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(194, 156);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(44, 42);
            this.btnThree.TabIndex = 11;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(66, 204);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(44, 42);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(128, 204);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(44, 42);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(66, 252);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(44, 42);
            this.btnSeven.TabIndex = 14;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(194, 204);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(44, 42);
            this.btnSix.TabIndex = 15;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(129, 252);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(44, 42);
            this.btnEight.TabIndex = 16;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(194, 252);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(44, 42);
            this.btnNine.TabIndex = 17;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(129, 305);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(44, 42);
            this.btnZero.TabIndex = 18;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(194, 305);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(44, 42);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.DigitOrDecimalClick);
            // 
            // lblDisplayEquation
            // 
            this.lblDisplayEquation.AutoSize = true;
            this.lblDisplayEquation.Location = new System.Drawing.Point(68, 28);
            this.lblDisplayEquation.Name = "lblDisplayEquation";
            this.lblDisplayEquation.Size = new System.Drawing.Size(30, 17);
            this.lblDisplayEquation.TabIndex = 20;
            this.lblDisplayEquation.Text = "null";
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(128, 108);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(44, 42);
            this.btnClearEntry.TabIndex = 21;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.ClearEntryClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.lblDisplayEquation);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtCurrentValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Label lblDisplayEquation;
        private System.Windows.Forms.Button btnClearEntry;
    }
}

