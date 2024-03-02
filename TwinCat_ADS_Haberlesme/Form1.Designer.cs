namespace TwinCat_ADS_Haberlesme
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fValue = new System.Windows.Forms.TextBox();
            this.lbl_Counter = new System.Windows.Forms.Label();
            this.textBoxnCounter = new System.Windows.Forms.TextBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox_fValue
            // 
            this.textBox_fValue.Location = new System.Drawing.Point(184, 42);
            this.textBox_fValue.Name = "textBox_fValue";
            this.textBox_fValue.Size = new System.Drawing.Size(100, 22);
            this.textBox_fValue.TabIndex = 1;
            // 
            // lbl_Counter
            // 
            this.lbl_Counter.AutoSize = true;
            this.lbl_Counter.Location = new System.Drawing.Point(95, 168);
            this.lbl_Counter.Name = "lbl_Counter";
            this.lbl_Counter.Size = new System.Drawing.Size(60, 16);
            this.lbl_Counter.TabIndex = 0;
            this.lbl_Counter.Text = "nCounter";
            // 
            // textBoxnCounter
            // 
            this.textBoxnCounter.Location = new System.Drawing.Point(184, 161);
            this.textBoxnCounter.Name = "textBoxnCounter";
            this.textBoxnCounter.Size = new System.Drawing.Size(100, 22);
            this.textBoxnCounter.TabIndex = 1;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(350, 42);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Read.TabIndex = 2;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(468, 42);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Write.TabIndex = 3;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Location = new System.Drawing.Point(95, 49);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(45, 16);
            this.lbl_Value.TabIndex = 0;
            this.lbl_Value.Text = "fValue";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(338, 161);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 409);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.textBoxnCounter);
            this.Controls.Add(this.lbl_Counter);
            this.Controls.Add(this.textBox_fValue);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fValue;
        private System.Windows.Forms.Label lbl_Counter;
        private System.Windows.Forms.TextBox textBoxnCounter;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Button btn_Reset;
    }
}

