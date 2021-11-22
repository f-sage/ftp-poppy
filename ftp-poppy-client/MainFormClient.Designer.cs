
namespace ftp_poppy_client
{
    partial class MainFormClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.pnDragDrop = new System.Windows.Forms.Panel();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.pnDragDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(228, 64);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(461, 27);
            this.tbFileName.TabIndex = 1;
            // 
            // pnDragDrop
            // 
            this.pnDragDrop.AllowDrop = true;
            this.pnDragDrop.BackColor = System.Drawing.Color.MistyRose;
            this.pnDragDrop.Controls.Add(this.lblDragDrop);
            this.pnDragDrop.Location = new System.Drawing.Point(313, 176);
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.Size = new System.Drawing.Size(376, 434);
            this.pnDragDrop.TabIndex = 2;
            this.pnDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragDrop);
            this.pnDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragEnter);
            this.pnDragDrop.DragOver += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragOver);
            this.pnDragDrop.DragLeave += new System.EventHandler(this.pnDragDrop_DragLeave);
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDragDrop.ForeColor = System.Drawing.Color.Sienna;
            this.lblDragDrop.Location = new System.Drawing.Point(12, 129);
            this.lblDragDrop.MaximumSize = new System.Drawing.Size(350, 400);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(348, 156);
            this.lblDragDrop.TabIndex = 0;
            this.lblDragDrop.Text = "Перетягніть файли сюди для завантаження";
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 622);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.tbFileName);
            this.Name = "MainFormClient";
            this.Text = "client";
            this.pnDragDrop.ResumeLayout(false);
            this.pnDragDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Panel pnDragDrop;
        private System.Windows.Forms.Label lblDragDrop;
    }
}

