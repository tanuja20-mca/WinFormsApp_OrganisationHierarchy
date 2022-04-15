
namespace WinFormsApp_OrganisationHierarchy
{
    partial class Form1
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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dataDisplay = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(338, 53);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(125, 27);
            this.txtEmpID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(203, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(101, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Employee ID :";
            // 
            // dataDisplay
            // 
            this.dataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDisplay.Location = new System.Drawing.Point(91, 168);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.RowHeadersWidth = 51;
            this.dataDisplay.RowTemplate.Height = 29;
            this.dataDisplay.Size = new System.Drawing.Size(612, 188);
            this.dataDisplay.TabIndex = 2;
            this.dataDisplay.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(643, 53);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmpID);
            this.Name = "Form1";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
    }
}

