namespace WF_Snake_V3
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gameCanvas = new System.Windows.Forms.PictureBox();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.scoreValue = new System.Windows.Forms.Label();
			this.score = new System.Windows.Forms.Label();
			this.gameOverLabel = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
			this.settingsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// gameCanvas
			// 
			this.gameCanvas.BackColor = System.Drawing.Color.Black;
			this.gameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gameCanvas.Location = new System.Drawing.Point(13, 75);
			this.gameCanvas.Name = "gameCanvas";
			this.gameCanvas.Size = new System.Drawing.Size(800, 600);
			this.gameCanvas.TabIndex = 0;
			this.gameCanvas.TabStop = false;
			this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCanvas_Paint);
			// 
			// settingsPanel
			// 
			this.settingsPanel.BackColor = System.Drawing.Color.Snow;
			this.settingsPanel.Controls.Add(this.scoreValue);
			this.settingsPanel.Controls.Add(this.score);
			this.settingsPanel.Location = new System.Drawing.Point(13, 12);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(800, 57);
			this.settingsPanel.TabIndex = 1;
			// 
			// scoreValue
			// 
			this.scoreValue.AutoSize = true;
			this.scoreValue.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.scoreValue.Location = new System.Drawing.Point(98, 9);
			this.scoreValue.Name = "scoreValue";
			this.scoreValue.Size = new System.Drawing.Size(65, 38);
			this.scoreValue.TabIndex = 1;
			this.scoreValue.Text = "0.0";
			// 
			// score
			// 
			this.score.AutoSize = true;
			this.score.BackColor = System.Drawing.Color.Transparent;
			this.score.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.score.ForeColor = System.Drawing.Color.Black;
			this.score.Location = new System.Drawing.Point(5, 5);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(104, 42);
			this.score.TabIndex = 0;
			this.score.Text = "Score:";
			// 
			// gameOverLabel
			// 
			this.gameOverLabel.BackColor = System.Drawing.Color.White;
			this.gameOverLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameOverLabel.Location = new System.Drawing.Point(132, 247);
			this.gameOverLabel.Name = "gameOverLabel";
			this.gameOverLabel.Size = new System.Drawing.Size(545, 293);
			this.gameOverLabel.TabIndex = 2;
			this.gameOverLabel.Text = "label1";
			this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(824, 685);
			this.Controls.Add(this.gameOverLabel);
			this.Controls.Add(this.settingsPanel);
			this.Controls.Add(this.gameCanvas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
			this.settingsPanel.ResumeLayout(false);
			this.settingsPanel.PerformLayout();
			this.ResumeLayout(false);

		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#endregion

		private System.Windows.Forms.PictureBox gameCanvas;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Label scoreValue;
		private System.Windows.Forms.Label score;
		private System.Windows.Forms.Label gameOverLabel;
		private System.Windows.Forms.Timer gameTimer;
	}
}

