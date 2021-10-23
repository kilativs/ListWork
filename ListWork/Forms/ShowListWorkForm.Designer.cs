
namespace ListWork.Forms
{
    partial class ShowListWorkForm
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
            this.titlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.deadlinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.deadlineLbl = new System.Windows.Forms.Label();
            this.priorityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.conditioonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.conditionLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.closelBtn = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.deadlinePanel.SuspendLayout();
            this.priorityPanel.SuspendLayout();
            this.conditioonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.titleLbl);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(349, 48);
            this.titlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(3, 23);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(55, 23);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "label2";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.label2);
            this.descriptionPanel.Controls.Add(this.descriptionLbl);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(0, 48);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(349, 129);
            this.descriptionPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLbl.Location = new System.Drawing.Point(3, 23);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(346, 106);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "label3";
            // 
            // deadlinePanel
            // 
            this.deadlinePanel.Controls.Add(this.label3);
            this.deadlinePanel.Controls.Add(this.deadlineLbl);
            this.deadlinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deadlinePanel.Location = new System.Drawing.Point(0, 177);
            this.deadlinePanel.Name = "deadlinePanel";
            this.deadlinePanel.Size = new System.Drawing.Size(349, 47);
            this.deadlinePanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deadline:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deadlineLbl
            // 
            this.deadlineLbl.AutoSize = true;
            this.deadlineLbl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deadlineLbl.Location = new System.Drawing.Point(3, 23);
            this.deadlineLbl.Name = "deadlineLbl";
            this.deadlineLbl.Size = new System.Drawing.Size(56, 23);
            this.deadlineLbl.TabIndex = 1;
            this.deadlineLbl.Text = "label4";
            this.deadlineLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityPanel
            // 
            this.priorityPanel.Controls.Add(this.label4);
            this.priorityPanel.Controls.Add(this.priorityLbl);
            this.priorityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.priorityPanel.Location = new System.Drawing.Point(0, 224);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(349, 48);
            this.priorityPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Priority:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priorityLbl.Location = new System.Drawing.Point(3, 23);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(55, 23);
            this.priorityLbl.TabIndex = 2;
            this.priorityLbl.Text = "label5";
            this.priorityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditioonPanel
            // 
            this.conditioonPanel.Controls.Add(this.label5);
            this.conditioonPanel.Controls.Add(this.conditionLbl);
            this.conditioonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.conditioonPanel.Location = new System.Drawing.Point(0, 272);
            this.conditioonPanel.Name = "conditioonPanel";
            this.conditioonPanel.Size = new System.Drawing.Size(349, 47);
            this.conditioonPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Condition:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditionLbl
            // 
            this.conditionLbl.AutoSize = true;
            this.conditionLbl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conditionLbl.Location = new System.Drawing.Point(3, 23);
            this.conditionLbl.Name = "conditionLbl";
            this.conditionLbl.Size = new System.Drawing.Size(56, 23);
            this.conditionLbl.TabIndex = 1;
            this.conditionLbl.Text = "label4";
            this.conditionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(0, 331);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(133, 331);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(84, 23);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // closelBtn
            // 
            this.closelBtn.Location = new System.Drawing.Point(270, 331);
            this.closelBtn.Name = "closelBtn";
            this.closelBtn.Size = new System.Drawing.Size(79, 23);
            this.closelBtn.TabIndex = 7;
            this.closelBtn.Text = "Close";
            this.closelBtn.UseVisualStyleBackColor = true;
            this.closelBtn.Click += new System.EventHandler(this.closelBtn_Click);
            // 
            // ShowListWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 360);
            this.Controls.Add(this.closelBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.conditioonPanel);
            this.Controls.Add(this.priorityPanel);
            this.Controls.Add(this.deadlinePanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "ShowListWorkForm";
            this.Text = "ShowListWorkForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.deadlinePanel.ResumeLayout(false);
            this.deadlinePanel.PerformLayout();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.conditioonPanel.ResumeLayout(false);
            this.conditioonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel titlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.FlowLayoutPanel descriptionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.FlowLayoutPanel deadlinePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label deadlineLbl;
        private System.Windows.Forms.FlowLayoutPanel priorityPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priorityLbl;
        private System.Windows.Forms.FlowLayoutPanel conditioonPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label conditionLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button closelBtn;
        private System.Windows.Forms.Button editBtn;
    }
}