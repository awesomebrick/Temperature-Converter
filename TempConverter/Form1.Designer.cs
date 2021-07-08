namespace TempConverter
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
            this.outputText = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.celsiusToFahrenheit = new System.Windows.Forms.Button();
            this.fahrenheitToCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(109, 203);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(35, 13);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "label1";
            this.outputText.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(84, 49);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 20);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "Input Temp";
            // 
            // celsiusToFahrenheit
            // 
            this.celsiusToFahrenheit.Location = new System.Drawing.Point(93, 103);
            this.celsiusToFahrenheit.Name = "celsiusToFahrenheit";
            this.celsiusToFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.celsiusToFahrenheit.TabIndex = 2;
            this.celsiusToFahrenheit.Text = "C => F";
            this.celsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.celsiusToFahrenheit.Click += new System.EventHandler(this.celsiusToFahrenheit_Click);
            // 
            // fahrenheitToCelsius
            // 
            this.fahrenheitToCelsius.Location = new System.Drawing.Point(93, 142);
            this.fahrenheitToCelsius.Name = "fahrenheitToCelsius";
            this.fahrenheitToCelsius.Size = new System.Drawing.Size(75, 23);
            this.fahrenheitToCelsius.TabIndex = 3;
            this.fahrenheitToCelsius.Text = "F => C";
            this.fahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.fahrenheitToCelsius.Click += new System.EventHandler(this.fahrenheitToCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 307);
            this.Controls.Add(this.fahrenheitToCelsius);
            this.Controls.Add(this.celsiusToFahrenheit);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.outputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button celsiusToFahrenheit;
        private System.Windows.Forms.Button fahrenheitToCelsius;
    }
}

