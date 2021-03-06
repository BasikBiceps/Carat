﻿
namespace Carat
{
    partial class WorkTypesTableForm
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
            this.dataGridViewWorkTypes = new System.Windows.Forms.DataGridView();
            this.WorkTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTypeStudentHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkTypes
            // 
            this.dataGridViewWorkTypes.AllowDrop = true;
            this.dataGridViewWorkTypes.AllowUserToOrderColumns = true;
            this.dataGridViewWorkTypes.AllowUserToResizeRows = false;
            this.dataGridViewWorkTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkTypeName,
            this.WorkTypeStudentHours});
            this.dataGridViewWorkTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWorkTypes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWorkTypes.Name = "dataGridViewWorkTypes";
            this.dataGridViewWorkTypes.Size = new System.Drawing.Size(899, 519);
            this.dataGridViewWorkTypes.StandardTab = true;
            this.dataGridViewWorkTypes.TabIndex = 0;
            this.dataGridViewWorkTypes.TabStop = false;
            // 
            // WorkTypeName
            // 
            this.WorkTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkTypeName.HeaderText = "Назва";
            this.WorkTypeName.Name = "WorkTypeName";
            // 
            // WorkTypeStudentHours
            // 
            this.WorkTypeStudentHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WorkTypeStudentHours.HeaderText = "год./студ.";
            this.WorkTypeStudentHours.Name = "WorkTypeStudentHours";
            this.WorkTypeStudentHours.Width = 84;
            // 
            // WorkTypesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(899, 519);
            this.Controls.Add(this.dataGridViewWorkTypes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MinimumSize = new System.Drawing.Size(350, 301);
            this.Name = "WorkTypesTableForm";
            this.Text = "Види робіт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkTypesTableForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorkTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTypeStudentHours;
    }
}