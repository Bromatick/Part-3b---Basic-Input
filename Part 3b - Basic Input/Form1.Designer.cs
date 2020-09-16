namespace Part_3b___Basic_Input
{
    partial class BasicInput
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGreetMsg = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(372, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Hello User, please tell us your name here:";
            // 
            // lblGreetMsg
            // 
            this.lblGreetMsg.AutoSize = true;
            this.lblGreetMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetMsg.Location = new System.Drawing.Point(237, 296);
            this.lblGreetMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreetMsg.Name = "lblGreetMsg";
            this.lblGreetMsg.Size = new System.Drawing.Size(0, 29);
            this.lblGreetMsg.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(435, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 30);
            this.txtName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(43, 286);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Click Here";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(124, 126);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(195, 25);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Tell us your age here";
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHight.Location = new System.Drawing.Point(124, 201);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(204, 25);
            this.lblHight.TabIndex = 5;
            this.lblHight.Text = "Tell us your hight here";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(435, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(162, 30);
            this.txtAge.TabIndex = 6;
            // 
            // txtHight
            // 
            this.txtHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHight.Location = new System.Drawing.Point(435, 198);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(162, 30);
            this.txtHight.TabIndex = 7;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 382);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblHight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGreetMsg);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BasicInput";
            this.Text = "Greetings!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGreetMsg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHight;
    }
}

