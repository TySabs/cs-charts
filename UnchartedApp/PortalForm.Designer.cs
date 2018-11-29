namespace UnchartedApp
{
    partial class PortalForm
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
            this.MainPortalLabel = new System.Windows.Forms.Label();
            this.BarButton = new System.Windows.Forms.Button();
            this.PieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPortalLabel
            // 
            this.MainPortalLabel.AllowDrop = true;
            this.MainPortalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPortalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainPortalLabel.Location = new System.Drawing.Point(0, 0);
            this.MainPortalLabel.Name = "MainPortalLabel";
            this.MainPortalLabel.Size = new System.Drawing.Size(2200, 159);
            this.MainPortalLabel.TabIndex = 0;
            this.MainPortalLabel.Text = "Uncharted Portal";
            this.MainPortalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarButton
            // 
            this.BarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BarButton.Location = new System.Drawing.Point(902, 231);
            this.BarButton.Name = "BarButton";
            this.BarButton.Size = new System.Drawing.Size(373, 126);
            this.BarButton.TabIndex = 1;
            this.BarButton.Text = "Bar Chart";
            this.BarButton.UseVisualStyleBackColor = true;
            this.BarButton.Click += new System.EventHandler(this.BarButton_Click);
            // 
            // PieButton
            // 
            this.PieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PieButton.Location = new System.Drawing.Point(902, 440);
            this.PieButton.Name = "PieButton";
            this.PieButton.Size = new System.Drawing.Size(373, 126);
            this.PieButton.TabIndex = 2;
            this.PieButton.Text = "Pie Chart";
            this.PieButton.UseVisualStyleBackColor = true;
            this.PieButton.Click += new System.EventHandler(this.PieButton_Click);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 1102);
            this.Controls.Add(this.PieButton);
            this.Controls.Add(this.BarButton);
            this.Controls.Add(this.MainPortalLabel);
            this.Name = "PortalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uncharted Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainPortalLabel;
        private System.Windows.Forms.Button BarButton;
        private System.Windows.Forms.Button PieButton;
    }
}

