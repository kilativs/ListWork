
namespace ListWork.Forms
{
    partial class ListWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListWorkForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.actionBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.createListWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 340);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionBtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // actionBtn
            // 
            this.actionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actionBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createListWorkToolStripMenuItem});
            this.actionBtn.Image = ((System.Drawing.Image)(resources.GetObject("actionBtn.Image")));
            this.actionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(58, 20);
            this.actionBtn.Text = "Action";
            // 
            // createListWorkToolStripMenuItem
            // 
            this.createListWorkToolStripMenuItem.Name = "createListWorkToolStripMenuItem";
            this.createListWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createListWorkToolStripMenuItem.Text = "Create ListWork";
            this.createListWorkToolStripMenuItem.Click += new System.EventHandler(this.createListWorkToolStripMenuItem_Click);
            // 
            // ListWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 340);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ListWorkForm";
            this.Text = "ListWorkForm";
            this.Load += new System.EventHandler(this.ListWorkForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton actionBtn;
        private System.Windows.Forms.ToolStripMenuItem createListWorkToolStripMenuItem;
    }
}