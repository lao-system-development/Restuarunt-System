namespace Restuarunt_System.Login
{
    partial class frmTest
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
            this.component_table1 = new Restuarunt_System.UIFunction.Component_table();
            this.SuspendLayout();
            // 
            // component_table1
            // 
            this.component_table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.component_table1.Font = new System.Drawing.Font("Phetsarath OT", 12F);
            this.component_table1.Location = new System.Drawing.Point(13, 15);
            this.component_table1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.component_table1.Name = "component_table1";
            this.component_table1.Size = new System.Drawing.Size(175, 152);
            this.component_table1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.component_table1);
            this.Name = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UIFunction.Component_table component_table1;
    }
}