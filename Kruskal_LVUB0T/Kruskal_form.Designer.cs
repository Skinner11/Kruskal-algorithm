namespace Kruskal_LVUB0T
{
    partial class Kruskal_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kruskal_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráfBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráfMegadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadedGraph_TextBox = new System.Windows.Forms.TextBox();
            this.minSpanTree_TextBox = new System.Windows.Forms.TextBox();
            this.genMinSpanTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.console_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearConsole_BTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráfBetöltéseToolStripMenuItem,
            this.gráfMegadásaToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // gráfBetöltéseToolStripMenuItem
            // 
            this.gráfBetöltéseToolStripMenuItem.Name = "gráfBetöltéseToolStripMenuItem";
            this.gráfBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gráfBetöltéseToolStripMenuItem.Text = "Gráf betöltése";
            this.gráfBetöltéseToolStripMenuItem.Click += new System.EventHandler(this.gráfBetöltéseToolStripMenuItem_Click);
            // 
            // gráfMegadásaToolStripMenuItem
            // 
            this.gráfMegadásaToolStripMenuItem.Name = "gráfMegadásaToolStripMenuItem";
            this.gráfMegadásaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gráfMegadásaToolStripMenuItem.Text = "Gráf megadása";
            this.gráfMegadásaToolStripMenuItem.Click += new System.EventHandler(this.gráfMegadásaToolStripMenuItem_Click);
            // 
            // loadedGraph_TextBox
            // 
            this.loadedGraph_TextBox.Location = new System.Drawing.Point(12, 27);
            this.loadedGraph_TextBox.Multiline = true;
            this.loadedGraph_TextBox.Name = "loadedGraph_TextBox";
            this.loadedGraph_TextBox.ReadOnly = true;
            this.loadedGraph_TextBox.Size = new System.Drawing.Size(371, 185);
            this.loadedGraph_TextBox.TabIndex = 1;
            // 
            // minSpanTree_TextBox
            // 
            this.minSpanTree_TextBox.Location = new System.Drawing.Point(417, 27);
            this.minSpanTree_TextBox.Multiline = true;
            this.minSpanTree_TextBox.Name = "minSpanTree_TextBox";
            this.minSpanTree_TextBox.ReadOnly = true;
            this.minSpanTree_TextBox.Size = new System.Drawing.Size(371, 185);
            this.minSpanTree_TextBox.TabIndex = 2;
            // 
            // genMinSpanTree
            // 
            this.genMinSpanTree.Location = new System.Drawing.Point(389, 68);
            this.genMinSpanTree.Name = "genMinSpanTree";
            this.genMinSpanTree.Size = new System.Drawing.Size(22, 101);
            this.genMinSpanTree.TabIndex = 3;
            this.genMinSpanTree.Text = ">";
            this.genMinSpanTree.UseVisualStyleBackColor = true;
            this.genMinSpanTree.Click += new System.EventHandler(this.genMinSpanTree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feldolgozandó gráf reprezentációja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(485, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generált minimális feszítőfa";
            // 
            // console_TextBox
            // 
            this.console_TextBox.Location = new System.Drawing.Point(12, 253);
            this.console_TextBox.Multiline = true;
            this.console_TextBox.Name = "console_TextBox";
            this.console_TextBox.ReadOnly = true;
            this.console_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_TextBox.Size = new System.Drawing.Size(577, 144);
            this.console_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(215, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tevékenységnapló";
            // 
            // clearConsole_BTN
            // 
            this.clearConsole_BTN.Location = new System.Drawing.Point(595, 253);
            this.clearConsole_BTN.Name = "clearConsole_BTN";
            this.clearConsole_BTN.Size = new System.Drawing.Size(193, 144);
            this.clearConsole_BTN.TabIndex = 8;
            this.clearConsole_BTN.Text = "Tevékenységnapló törlése";
            this.clearConsole_BTN.UseVisualStyleBackColor = true;
            this.clearConsole_BTN.Click += new System.EventHandler(this.clearConsole_BTN_Click);
            // 
            // Kruskal_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearConsole_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.console_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genMinSpanTree);
            this.Controls.Add(this.minSpanTree_TextBox);
            this.Controls.Add(this.loadedGraph_TextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kruskal_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kruskal by LVUB0T";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráfBetöltéseToolStripMenuItem;
        private System.Windows.Forms.TextBox loadedGraph_TextBox;
        private System.Windows.Forms.TextBox minSpanTree_TextBox;
        private System.Windows.Forms.Button genMinSpanTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox console_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem gráfMegadásaToolStripMenuItem;
        private System.Windows.Forms.Button clearConsole_BTN;
    }
}

