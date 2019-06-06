namespace Kruskal_LVUB0T
{
    partial class InputGraph
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
            this.startV_TextBox = new System.Windows.Forms.TextBox();
            this.endV_TextBox = new System.Windows.Forms.TextBox();
            this.weightE_TextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OneMore_BTN = new System.Windows.Forms.Button();
            this.NoMore_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startV_TextBox
            // 
            this.startV_TextBox.Location = new System.Drawing.Point(55, 63);
            this.startV_TextBox.Name = "startV_TextBox";
            this.startV_TextBox.Size = new System.Drawing.Size(63, 20);
            this.startV_TextBox.TabIndex = 0;
            this.startV_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endV_TextBox
            // 
            this.endV_TextBox.Location = new System.Drawing.Point(146, 63);
            this.endV_TextBox.Name = "endV_TextBox";
            this.endV_TextBox.Size = new System.Drawing.Size(63, 20);
            this.endV_TextBox.TabIndex = 1;
            this.endV_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightE_TextBox
            // 
            this.weightE_TextBox.Location = new System.Drawing.Point(237, 63);
            this.weightE_TextBox.Name = "weightE_TextBox";
            this.weightE_TextBox.Size = new System.Drawing.Size(63, 20);
            this.weightE_TextBox.TabIndex = 2;
            this.weightE_TextBox.Text = "0";
            this.weightE_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(53, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Kezdőcsúcs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Végcsúcs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Súly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adj meg egy élet!";
            // 
            // OneMore_BTN
            // 
            this.OneMore_BTN.Location = new System.Drawing.Point(268, 108);
            this.OneMore_BTN.Name = "OneMore_BTN";
            this.OneMore_BTN.Size = new System.Drawing.Size(75, 23);
            this.OneMore_BTN.TabIndex = 7;
            this.OneMore_BTN.Text = "Felvesz";
            this.OneMore_BTN.UseVisualStyleBackColor = true;
            this.OneMore_BTN.Click += new System.EventHandler(this.OneMore_BTN_Click);
            // 
            // NoMore_BTN
            // 
            this.NoMore_BTN.Location = new System.Drawing.Point(187, 108);
            this.NoMore_BTN.Name = "NoMore_BTN";
            this.NoMore_BTN.Size = new System.Drawing.Size(75, 23);
            this.NoMore_BTN.TabIndex = 8;
            this.NoMore_BTN.Text = "Eldob";
            this.NoMore_BTN.UseVisualStyleBackColor = true;
            this.NoMore_BTN.Click += new System.EventHandler(this.NoMore_BTN_Click);
            // 
            // InputGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 145);
            this.Controls.Add(this.NoMore_BTN);
            this.Controls.Add(this.OneMore_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.weightE_TextBox);
            this.Controls.Add(this.endV_TextBox);
            this.Controls.Add(this.startV_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputGraph";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputGraph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startV_TextBox;
        private System.Windows.Forms.TextBox endV_TextBox;
        private System.Windows.Forms.TextBox weightE_TextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OneMore_BTN;
        private System.Windows.Forms.Button NoMore_BTN;
    }
}