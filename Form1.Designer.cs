namespace Wes_Calculator
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_CurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOne.BackgroundImage")));
            this.buttonOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(12, 185);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(45, 45);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEquals.BackgroundImage")));
            this.buttonEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.Location = new System.Drawing.Point(216, 185);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(45, 96);
            this.buttonEquals.TabIndex = 1;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(165, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(45, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDecimal.BackgroundImage")));
            this.buttonDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(114, 236);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(45, 45);
            this.buttonDecimal.TabIndex = 3;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZero.BackgroundImage")));
            this.buttonZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(12, 236);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(96, 45);
            this.buttonZero.TabIndex = 4;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEight.BackgroundImage")));
            this.buttonEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(63, 83);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(45, 45);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDivision.BackgroundImage")));
            this.buttonDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(165, 83);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(45, 45);
            this.buttonDivision.TabIndex = 7;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCE.BackgroundImage")));
            this.buttonCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(216, 83);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(45, 45);
            this.buttonCE.TabIndex = 6;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSeven.BackgroundImage")));
            this.buttonSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(12, 83);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(45, 45);
            this.buttonSeven.TabIndex = 5;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubtract.BackgroundImage")));
            this.buttonSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(165, 185);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(45, 45);
            this.buttonSubtract.TabIndex = 14;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSix.BackgroundImage")));
            this.buttonSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(114, 134);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(45, 45);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNine.BackgroundImage")));
            this.buttonNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(114, 83);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(45, 45);
            this.buttonNine.TabIndex = 12;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFive.BackgroundImage")));
            this.buttonFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(63, 134);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(45, 45);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFour.BackgroundImage")));
            this.buttonFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(12, 134);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(45, 45);
            this.buttonFour.TabIndex = 19;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThree.BackgroundImage")));
            this.buttonThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(114, 185);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(45, 45);
            this.buttonThree.TabIndex = 18;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMultiply.BackgroundImage")));
            this.buttonMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(165, 134);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 45);
            this.buttonMultiply.TabIndex = 17;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackgroundImage")));
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(216, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(45, 45);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "C";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTwo.BackgroundImage")));
            this.buttonTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(63, 185);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(45, 45);
            this.buttonTwo.TabIndex = 15;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 48);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(249, 29);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_CurrentOperation
            // 
            this.label_CurrentOperation.AutoSize = true;
            this.label_CurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.label_CurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentOperation.Location = new System.Drawing.Point(25, 21);
            this.label_CurrentOperation.Name = "label_CurrentOperation";
            this.label_CurrentOperation.Size = new System.Drawing.Size(0, 24);
            this.label_CurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 293);
            this.Controls.Add(this.label_CurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_CurrentOperation;
    }
}

