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
            this.PyramidButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPortalLabel
            // 
            this.MainPortalLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainPortalLabel.AllowDrop = true;
            this.MainPortalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MainPortalLabel.Location = new System.Drawing.Point(288, 25);
            this.MainPortalLabel.Name = "MainPortalLabel";
            this.MainPortalLabel.Size = new System.Drawing.Size(659, 170);
            this.MainPortalLabel.TabIndex = 0;
            this.MainPortalLabel.Text = "Uncharted Portal";
            this.MainPortalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarButton
            // 
            this.BarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BarButton.Location = new System.Drawing.Point(193, 342);
            this.BarButton.Name = "BarButton";
            this.BarButton.Size = new System.Drawing.Size(373, 126);
            this.BarButton.TabIndex = 1;
            this.BarButton.Text = "Bar";
            this.BarButton.UseVisualStyleBackColor = true;
            this.BarButton.Click += new System.EventHandler(this.BarButton_Click);
            // 
            // PieButton
            // 
            this.PieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PieButton.Location = new System.Drawing.Point(667, 342);
            this.PieButton.Name = "PieButton";
            this.PieButton.Size = new System.Drawing.Size(373, 126);
            this.PieButton.TabIndex = 2;
            this.PieButton.Text = "Pie";
            this.PieButton.UseVisualStyleBackColor = true;
            this.PieButton.Click += new System.EventHandler(this.PieButton_Click);
            // 
            // PyramidButton
            // 
            this.PyramidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PyramidButton.Location = new System.Drawing.Point(193, 544);
            this.PyramidButton.Name = "PyramidButton";
            this.PyramidButton.Size = new System.Drawing.Size(373, 126);
            this.PyramidButton.TabIndex = 3;
            this.PyramidButton.Text = "Pyramid";
            this.PyramidButton.UseVisualStyleBackColor = true;
            // 
            // LineButton
            // 
            this.LineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LineButton.Location = new System.Drawing.Point(667, 544);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(373, 126);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(398, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please select a chart type:";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ExitButton.Location = new System.Drawing.Point(430, 775);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(373, 126);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.MainPortalLabel);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.BarButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PieButton);
            this.panel1.Controls.Add(this.LineButton);
            this.panel1.Controls.Add(this.PyramidButton);
            this.panel1.Location = new System.Drawing.Point(735, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 1210);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2736, 1269);
            this.Controls.Add(this.panel1);
            this.Name = "PortalForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uncharted Portal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainPortalLabel;
        private System.Windows.Forms.Button BarButton;
        private System.Windows.Forms.Button PieButton;
        private System.Windows.Forms.Button PyramidButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
    }
}

