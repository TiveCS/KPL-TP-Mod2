
namespace TP_Mod2
{
    partial class HelloWorldApp
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
            this.button_submit = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(12, 74);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(157, 46);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(267, 89);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(59, 17);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "Output: ";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 30);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(514, 22);
            this.textBox_input.TabIndex = 2;
            // 
            // HelloWorldApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 169);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.button_submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelloWorldApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloWorld_1302204090";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_input;
    }
}

