namespace EventAggregatorExampleApp
{
	partial class MainForm
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
			this._formLayout = new System.Windows.Forms.TableLayoutPanel();
			this._topLayout = new System.Windows.Forms.TableLayoutPanel();
			this._helloWorldButton = new System.Windows.Forms.Button();
			this._doWorkButton = new System.Windows.Forms.Button();
			this._notificationLog = new EventAggregatorExampleApp.NotificationLogControl();
			this._formLayout.SuspendLayout();
			this._topLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// _formLayout
			// 
			this._formLayout.ColumnCount = 1;
			this._formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._formLayout.Controls.Add(this._topLayout, 0, 0);
			this._formLayout.Controls.Add(this._notificationLog, 0, 1);
			this._formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._formLayout.Location = new System.Drawing.Point(0, 0);
			this._formLayout.Margin = new System.Windows.Forms.Padding(0);
			this._formLayout.Name = "_formLayout";
			this._formLayout.RowCount = 2;
			this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._formLayout.Size = new System.Drawing.Size(384, 261);
			this._formLayout.TabIndex = 0;
			// 
			// _topLayout
			// 
			this._topLayout.ColumnCount = 2;
			this._topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._topLayout.Controls.Add(this._helloWorldButton, 0, 0);
			this._topLayout.Controls.Add(this._doWorkButton, 1, 0);
			this._topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this._topLayout.Location = new System.Drawing.Point(0, 0);
			this._topLayout.Margin = new System.Windows.Forms.Padding(0);
			this._topLayout.Name = "_topLayout";
			this._topLayout.RowCount = 1;
			this._topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._topLayout.Size = new System.Drawing.Size(384, 130);
			this._topLayout.TabIndex = 0;
			// 
			// _helloWorldButton
			// 
			this._helloWorldButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._helloWorldButton.AutoSize = true;
			this._helloWorldButton.Location = new System.Drawing.Point(51, 50);
			this._helloWorldButton.Margin = new System.Windows.Forms.Padding(0);
			this._helloWorldButton.Name = "_helloWorldButton";
			this._helloWorldButton.Size = new System.Drawing.Size(90, 29);
			this._helloWorldButton.TabIndex = 0;
			this._helloWorldButton.Text = "Hello World";
			this._helloWorldButton.UseVisualStyleBackColor = true;
			// 
			// _doWorkButton
			// 
			this._doWorkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._doWorkButton.AutoSize = true;
			this._doWorkButton.Location = new System.Drawing.Point(251, 50);
			this._doWorkButton.Margin = new System.Windows.Forms.Padding(0);
			this._doWorkButton.Name = "_doWorkButton";
			this._doWorkButton.Size = new System.Drawing.Size(73, 29);
			this._doWorkButton.TabIndex = 1;
			this._doWorkButton.Text = "Do Work";
			this._doWorkButton.UseVisualStyleBackColor = true;
			// 
			// _notificationLog
			// 
			this._notificationLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this._notificationLog.Font = new System.Drawing.Font("Segoe UI", 10F);
			this._notificationLog.Location = new System.Drawing.Point(0, 130);
			this._notificationLog.Margin = new System.Windows.Forms.Padding(0);
			this._notificationLog.Name = "_notificationLog";
			this._notificationLog.Size = new System.Drawing.Size(384, 131);
			this._notificationLog.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this._formLayout);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EventAggregator Example";
			this._formLayout.ResumeLayout(false);
			this._topLayout.ResumeLayout(false);
			this._topLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _formLayout;
		private System.Windows.Forms.TableLayoutPanel _topLayout;
		private NotificationLogControl _notificationLog;
		private System.Windows.Forms.Button _helloWorldButton;
		private System.Windows.Forms.Button _doWorkButton;
	}
}

