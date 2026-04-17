using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Atalasoft.Imaging.Codec;
namespace RawDemo
{
	/// <summary>
	/// Summary description for ImageMetrics.
	/// </summary>
	public class ImageMetrics : System.Windows.Forms.Form
	{
		private RawDecoder _decoder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxBrightness;
		private System.Windows.Forms.TextBox textBoxRed;
		private System.Windows.Forms.TextBox textBoxBlue;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImageMetrics()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public ImageMetrics( RawDecoder decoder )
		{
			_decoder = decoder;
			InitializeComponent();

			textBoxBrightness.Text = _decoder.Brightness.ToString();
			textBoxRed.Text = _decoder.RedAberration.ToString();
			textBoxBlue.Text = _decoder.BlueAberration.ToString();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxBrightness = new System.Windows.Forms.TextBox();
			this.textBoxRed = new System.Windows.Forms.TextBox();
			this.textBoxBlue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Brightness";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Red Aberration";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Blue Aberration";
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(176, 80);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(104, 32);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "Ok";
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(8, 80);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(104, 32);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxBrightness
			// 
			this.textBoxBrightness.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBoxBrightness.Location = new System.Drawing.Point(96, 8);
			this.textBoxBrightness.Name = "textBoxBrightness";
			this.textBoxBrightness.Size = new System.Drawing.Size(184, 20);
			this.textBoxBrightness.TabIndex = 5;
			this.textBoxBrightness.Text = "";
			// 
			// textBoxRed
			// 
			this.textBoxRed.Location = new System.Drawing.Point(96, 32);
			this.textBoxRed.Name = "textBoxRed";
			this.textBoxRed.Size = new System.Drawing.Size(184, 20);
			this.textBoxRed.TabIndex = 6;
			this.textBoxRed.Text = "";
			// 
			// textBoxBlue
			// 
			this.textBoxBlue.Location = new System.Drawing.Point(96, 56);
			this.textBoxBlue.Name = "textBoxBlue";
			this.textBoxBlue.Size = new System.Drawing.Size(184, 20);
			this.textBoxBlue.TabIndex = 7;
			this.textBoxBlue.Text = "";
			// 
			// ImageMetrics
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 114);
			this.Controls.Add(this.textBoxBlue);
			this.Controls.Add(this.textBoxRed);
			this.Controls.Add(this.textBoxBrightness);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ImageMetrics";
			this.Text = "ImageMetrics";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			_decoder.Brightness = Double.Parse(textBoxBrightness.Text);
			_decoder.RedAberration = Double.Parse(textBoxRed.Text);
			_decoder.BlueAberration = Double.Parse(textBoxBlue.Text);

			this.Close();
		}


	}
}
