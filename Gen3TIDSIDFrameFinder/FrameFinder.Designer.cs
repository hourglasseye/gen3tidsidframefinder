namespace Gen3TIDSIDFrameFinder
{
	partial class FrameFinder
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
			if(disposing && (components != null))
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.findFrameButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.outputGridView = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.frameOffsetTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.adjustedFrameTextBox = new System.Windows.Forms.TextBox();
			this.adjustFrameButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.prngTextBox = new System.Windows.Forms.MaskedTextBox();
			this.pidTextBox = new System.Windows.Forms.MaskedTextBox();
			this.tidTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.gameComboBox = new System.Windows.Forms.ComboBox();
			this.minFrameTextBox = new System.Windows.Forms.MaskedTextBox();
			this.maxFrameTextBox = new System.Windows.Forms.MaskedTextBox();
			this.attemptedFrameTextBox = new System.Windows.Forms.MaskedTextBox();
			this.acquiredSidTextBox = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.outputGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Current Frame";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Max Frame";
			// 
			// findFrameButton
			// 
			this.findFrameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.findFrameButton.Location = new System.Drawing.Point(6, 309);
			this.findFrameButton.Name = "findFrameButton";
			this.findFrameButton.Size = new System.Drawing.Size(169, 23);
			this.findFrameButton.TabIndex = 2;
			this.findFrameButton.Text = "Find Frame To Hit";
			this.findFrameButton.UseVisualStyleBackColor = true;
			this.findFrameButton.Click += new System.EventHandler(this.OnFindFrameClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "TID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Desired PID";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "PRNG State";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.outputGridView);
			this.groupBox1.Controls.Add(this.findFrameButton);
			this.groupBox1.Location = new System.Drawing.Point(221, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(181, 337);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Frame Finder";
			// 
			// outputGridView
			// 
			this.outputGridView.AllowUserToAddRows = false;
			this.outputGridView.AllowUserToDeleteRows = false;
			this.outputGridView.AllowUserToResizeColumns = false;
			this.outputGridView.AllowUserToResizeRows = false;
			this.outputGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.outputGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.outputGridView.Location = new System.Drawing.Point(6, 19);
			this.outputGridView.Name = "outputGridView";
			this.outputGridView.ReadOnly = true;
			this.outputGridView.RowHeadersVisible = false;
			this.outputGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.outputGridView.Size = new System.Drawing.Size(169, 284);
			this.outputGridView.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.acquiredSidTextBox);
			this.groupBox2.Controls.Add(this.attemptedFrameTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.frameOffsetTextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.adjustedFrameTextBox);
			this.groupBox2.Controls.Add(this.adjustFrameButton);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(203, 157);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Frame Correction";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 103);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 28;
			this.label9.Text = "Frame Offset";
			// 
			// frameOffsetTextBox
			// 
			this.frameOffsetTextBox.Location = new System.Drawing.Point(95, 100);
			this.frameOffsetTextBox.Name = "frameOffsetTextBox";
			this.frameOffsetTextBox.ReadOnly = true;
			this.frameOffsetTextBox.Size = new System.Drawing.Size(100, 20);
			this.frameOffsetTextBox.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 129);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "Use This Instead";
			// 
			// adjustedFrameTextBox
			// 
			this.adjustedFrameTextBox.Location = new System.Drawing.Point(95, 126);
			this.adjustedFrameTextBox.Name = "adjustedFrameTextBox";
			this.adjustedFrameTextBox.ReadOnly = true;
			this.adjustedFrameTextBox.Size = new System.Drawing.Size(100, 20);
			this.adjustedFrameTextBox.TabIndex = 5;
			// 
			// adjustFrameButton
			// 
			this.adjustFrameButton.Location = new System.Drawing.Point(9, 71);
			this.adjustFrameButton.Name = "adjustFrameButton";
			this.adjustFrameButton.Size = new System.Drawing.Size(186, 23);
			this.adjustFrameButton.TabIndex = 3;
			this.adjustFrameButton.Text = "Adjust Frame";
			this.adjustFrameButton.UseVisualStyleBackColor = true;
			this.adjustFrameButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Acquired SID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Attempted Frame";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.maxFrameTextBox);
			this.groupBox3.Controls.Add(this.minFrameTextBox);
			this.groupBox3.Controls.Add(this.prngTextBox);
			this.groupBox3.Controls.Add(this.pidTextBox);
			this.groupBox3.Controls.Add(this.tidTextBox);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.gameComboBox);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(203, 174);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Config";
			// 
			// prngTextBox
			// 
			this.prngTextBox.Location = new System.Drawing.Point(95, 65);
			this.prngTextBox.Mask = ">aaaaaaaa";
			this.prngTextBox.Name = "prngTextBox";
			this.prngTextBox.Size = new System.Drawing.Size(100, 20);
			this.prngTextBox.TabIndex = 3;
			// 
			// pidTextBox
			// 
			this.pidTextBox.Location = new System.Drawing.Point(95, 39);
			this.pidTextBox.Mask = ">aaaaaaaa";
			this.pidTextBox.Name = "pidTextBox";
			this.pidTextBox.Size = new System.Drawing.Size(100, 20);
			this.pidTextBox.TabIndex = 2;
			// 
			// tidTextBox
			// 
			this.tidTextBox.Location = new System.Drawing.Point(95, 13);
			this.tidTextBox.Mask = "99999";
			this.tidTextBox.Name = "tidTextBox";
			this.tidTextBox.Size = new System.Drawing.Size(100, 20);
			this.tidTextBox.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "Game";
			// 
			// gameComboBox
			// 
			this.gameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gameComboBox.FormattingEnabled = true;
			this.gameComboBox.Items.AddRange(new object[] {
            "Emerald",
            "Fire Red/Leaf Green",
            "Colosseum"});
			this.gameComboBox.Location = new System.Drawing.Point(95, 143);
			this.gameComboBox.Name = "gameComboBox";
			this.gameComboBox.Size = new System.Drawing.Size(100, 21);
			this.gameComboBox.TabIndex = 5;
			// 
			// minFrameTextBox
			// 
			this.minFrameTextBox.Location = new System.Drawing.Point(95, 91);
			this.minFrameTextBox.Mask = "999999";
			this.minFrameTextBox.Name = "minFrameTextBox";
			this.minFrameTextBox.Size = new System.Drawing.Size(100, 20);
			this.minFrameTextBox.TabIndex = 4;
			this.minFrameTextBox.Text = "1";
			// 
			// maxFrameTextBox
			// 
			this.maxFrameTextBox.Location = new System.Drawing.Point(95, 117);
			this.maxFrameTextBox.Mask = "999999";
			this.maxFrameTextBox.Name = "maxFrameTextBox";
			this.maxFrameTextBox.Size = new System.Drawing.Size(100, 20);
			this.maxFrameTextBox.TabIndex = 5;
			this.maxFrameTextBox.Text = "100000";
			// 
			// attemptedFrameTextBox
			// 
			this.attemptedFrameTextBox.Location = new System.Drawing.Point(95, 19);
			this.attemptedFrameTextBox.Mask = ">aaaaaaaa";
			this.attemptedFrameTextBox.Name = "attemptedFrameTextBox";
			this.attemptedFrameTextBox.Size = new System.Drawing.Size(100, 20);
			this.attemptedFrameTextBox.TabIndex = 1;
			// 
			// acquiredSidTextBox
			// 
			this.acquiredSidTextBox.Location = new System.Drawing.Point(97, 45);
			this.acquiredSidTextBox.Mask = "99999";
			this.acquiredSidTextBox.Name = "acquiredSidTextBox";
			this.acquiredSidTextBox.Size = new System.Drawing.Size(100, 20);
			this.acquiredSidTextBox.TabIndex = 2;
			// 
			// FrameFinder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 360);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrameFinder";
			this.Text = "Gen 3 TID/SID Frame Finder";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.outputGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button findFrameButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox adjustedFrameTextBox;
		private System.Windows.Forms.Button adjustFrameButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox frameOffsetTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox gameComboBox;
		private System.Windows.Forms.DataGridView outputGridView;
		private System.Windows.Forms.MaskedTextBox tidTextBox;
		private System.Windows.Forms.MaskedTextBox pidTextBox;
		private System.Windows.Forms.MaskedTextBox prngTextBox;
		private System.Windows.Forms.MaskedTextBox minFrameTextBox;
		private System.Windows.Forms.MaskedTextBox maxFrameTextBox;
		private System.Windows.Forms.MaskedTextBox acquiredSidTextBox;
		private System.Windows.Forms.MaskedTextBox attemptedFrameTextBox;
	}
}

