
namespace ListWork.Forms.UserControls
{
    partial class ListWorkItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deadlineLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.conditionalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deadlineLbl
            // 
            this.deadlineLbl.AutoSize = true;
            this.deadlineLbl.Location = new System.Drawing.Point(4, 4);
            this.deadlineLbl.Name = "deadlineLbl";
            this.deadlineLbl.Size = new System.Drawing.Size(121, 15);
            this.deadlineLbl.TabIndex = 0;
            this.deadlineLbl.Text = "01.02.2020 15:00:00:00";
            this.deadlineLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(144, 4);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(97, 15);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Going from shop";
            this.titleLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(264, 4);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(287, 15);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = "hhhhhhhhhhhhhhhhggggggggghhhhhhhhhhhhhhh";
            this.descriptionLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Location = new System.Drawing.Point(574, 4);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(38, 15);
            this.priorityLbl.TabIndex = 3;
            this.priorityLbl.Text = "label1";
            this.priorityLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            // 
            // conditionalLbl
            // 
            this.conditionalLbl.AutoSize = true;
            this.conditionalLbl.Location = new System.Drawing.Point(715, 3);
            this.conditionalLbl.Name = "conditionalLbl";
            this.conditionalLbl.Size = new System.Drawing.Size(38, 15);
            this.conditionalLbl.TabIndex = 4;
            this.conditionalLbl.Text = "label1";
            this.conditionalLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            // 
            // ListWorkItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conditionalLbl);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.deadlineLbl);
            this.Name = "ListWorkItem";
            this.Size = new System.Drawing.Size(800, 34);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListWorkItem_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deadlineLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label priorityLbl;
        private System.Windows.Forms.Label conditionalLbl;
    }
}
