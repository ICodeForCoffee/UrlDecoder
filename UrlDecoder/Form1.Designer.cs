namespace WindowsFormsApplication1
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Decode = new System.Windows.Forms.Button();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.Exit = new System.Windows.Forms.Button();
			this.Encode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Decode
			// 
			this.Decode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Decode.Location = new System.Drawing.Point(497, 183);
			this.Decode.Name = "Decode";
			this.Decode.Size = new System.Drawing.Size(75, 23);
			this.Decode.TabIndex = 0;
			this.Decode.Text = "Url Decode";
			this.Decode.UseVisualStyleBackColor = true;
			this.Decode.Click += new System.EventHandler(this.Decode_Click);
			// 
			// inputBox
			// 
			this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox.Location = new System.Drawing.Point(12, 12);
			this.inputBox.Multiline = true;
			this.inputBox.Name = "inputBox";
			this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.inputBox.Size = new System.Drawing.Size(560, 165);
			this.inputBox.TabIndex = 1;
			// 
			// outputBox
			// 
			this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputBox.Location = new System.Drawing.Point(12, 212);
			this.outputBox.Multiline = true;
			this.outputBox.Name = "outputBox";
			this.outputBox.ReadOnly = true;
			this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.outputBox.Size = new System.Drawing.Size(560, 165);
			this.outputBox.TabIndex = 2;
			// 
			// Exit
			// 
			this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Exit.Location = new System.Drawing.Point(497, 383);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 3;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Encode
			// 
			this.Encode.Location = new System.Drawing.Point(12, 183);
			this.Encode.Name = "Encode";
			this.Encode.Size = new System.Drawing.Size(75, 23);
			this.Encode.TabIndex = 4;
			this.Encode.Text = "Url Encode";
			this.Encode.UseVisualStyleBackColor = true;
			this.Encode.Click += new System.EventHandler(this.Encode_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 412);
			this.Controls.Add(this.Encode);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.inputBox);
			this.Controls.Add(this.Decode);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 450);
			this.Name = "Form1";
			this.Text = "Url Decoder";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Decode;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.TextBox outputBox;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button Encode;
	}
}

