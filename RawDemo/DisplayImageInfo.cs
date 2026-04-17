using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Atalasoft.Imaging.Codec;

namespace RawDemo
{
	/// <summary>
	/// Summary description for DisplayImageInfo.
	/// </summary>
	public class DisplayImageInfo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBoxCameraInfo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBoxRawImageInfo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBoxImageInfo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxIIColorDepth;
		private System.Windows.Forms.TextBox textBoxIIFrameCount;
		private System.Windows.Forms.TextBox textBoxIIImageType;
		private System.Windows.Forms.TextBox textBoxIIPixelFormat;
		private System.Windows.Forms.TextBox textBoxIIResolution;
		private System.Windows.Forms.TextBox textBoxIISize;
		private System.Windows.Forms.TextBox textBoxRIDataSize;
		private System.Windows.Forms.TextBox textBoxRIImageSize;
		private System.Windows.Forms.TextBox textBoxCIDataSize;
		private System.Windows.Forms.TextBox textBoxCIMake;
		private System.Windows.Forms.TextBox textBoxCIModel;
		private System.Windows.Forms.TextBox textBoxCIModelExt;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DisplayImageInfo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public DisplayImageInfo( ImageInfo info )
		{
			InitializeComponent();

			RawImageInfo rawInfo = info as RawImageInfo;
			CameraInfo camInfo = rawInfo.CameraInfo;

			textBoxIIColorDepth.Text = info.ColorDepth.ToString();
			textBoxIIFrameCount.Text = info.FrameCount.ToString();
			textBoxIIImageType.Text = info.ImageType.ToString();
			textBoxIIPixelFormat.Text = info.PixelFormat.ToString();
			textBoxIIResolution.Text = info.Resolution.ToString();
			textBoxIISize.Text = info.Size.ToString();

			textBoxRIImageSize.Text = rawInfo.RawImageSize.ToString();
			textBoxRIDataSize.Text = rawInfo.DataSize.ToString();

			textBoxCIDataSize.Text = camInfo.DataSize.ToString();
			textBoxCIMake.Text = camInfo.Make.ToString();
			textBoxCIModel.Text = camInfo.Model.ToString();
			textBoxCIModelExt.Text = camInfo.ModelExtended.ToString();
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
			this.textBoxRIDataSize = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxRIImageSize = new System.Windows.Forms.TextBox();
			this.groupBoxRawImageInfo = new System.Windows.Forms.GroupBox();
			this.groupBoxCameraInfo = new System.Windows.Forms.GroupBox();
			this.textBoxCIModelExt = new System.Windows.Forms.TextBox();
			this.textBoxCIModel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCIDataSize = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCIMake = new System.Windows.Forms.TextBox();
			this.groupBoxImageInfo = new System.Windows.Forms.GroupBox();
			this.textBoxIISize = new System.Windows.Forms.TextBox();
			this.textBoxIIResolution = new System.Windows.Forms.TextBox();
			this.textBoxIIPixelFormat = new System.Windows.Forms.TextBox();
			this.textBoxIIImageType = new System.Windows.Forms.TextBox();
			this.textBoxIIFrameCount = new System.Windows.Forms.TextBox();
			this.textBoxIIColorDepth = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBoxRawImageInfo.SuspendLayout();
			this.groupBoxCameraInfo.SuspendLayout();
			this.groupBoxImageInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxRIDataSize
			// 
			this.textBoxRIDataSize.Location = new System.Drawing.Point(80, 16);
			this.textBoxRIDataSize.Name = "textBoxRIDataSize";
			this.textBoxRIDataSize.Size = new System.Drawing.Size(176, 20);
			this.textBoxRIDataSize.TabIndex = 0;
			this.textBoxRIDataSize.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data Size:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Image Size:";
			// 
			// textBoxRIImageSize
			// 
			this.textBoxRIImageSize.Location = new System.Drawing.Point(80, 40);
			this.textBoxRIImageSize.Name = "textBoxRIImageSize";
			this.textBoxRIImageSize.Size = new System.Drawing.Size(176, 20);
			this.textBoxRIImageSize.TabIndex = 3;
			this.textBoxRIImageSize.Text = "";
			// 
			// groupBoxRawImageInfo
			// 
			this.groupBoxRawImageInfo.Controls.Add(this.label1);
			this.groupBoxRawImageInfo.Controls.Add(this.textBoxRIDataSize);
			this.groupBoxRawImageInfo.Controls.Add(this.label2);
			this.groupBoxRawImageInfo.Controls.Add(this.textBoxRIImageSize);
			this.groupBoxRawImageInfo.Location = new System.Drawing.Point(8, 8);
			this.groupBoxRawImageInfo.Name = "groupBoxRawImageInfo";
			this.groupBoxRawImageInfo.Size = new System.Drawing.Size(264, 72);
			this.groupBoxRawImageInfo.TabIndex = 4;
			this.groupBoxRawImageInfo.TabStop = false;
			this.groupBoxRawImageInfo.Text = "RawImageInfo";
			// 
			// groupBoxCameraInfo
			// 
			this.groupBoxCameraInfo.Controls.Add(this.textBoxCIModelExt);
			this.groupBoxCameraInfo.Controls.Add(this.textBoxCIModel);
			this.groupBoxCameraInfo.Controls.Add(this.label6);
			this.groupBoxCameraInfo.Controls.Add(this.label5);
			this.groupBoxCameraInfo.Controls.Add(this.label3);
			this.groupBoxCameraInfo.Controls.Add(this.textBoxCIDataSize);
			this.groupBoxCameraInfo.Controls.Add(this.label4);
			this.groupBoxCameraInfo.Controls.Add(this.textBoxCIMake);
			this.groupBoxCameraInfo.Location = new System.Drawing.Point(8, 88);
			this.groupBoxCameraInfo.Name = "groupBoxCameraInfo";
			this.groupBoxCameraInfo.Size = new System.Drawing.Size(264, 120);
			this.groupBoxCameraInfo.TabIndex = 5;
			this.groupBoxCameraInfo.TabStop = false;
			this.groupBoxCameraInfo.Text = "CameraInfo";
			// 
			// textBoxCIModelExt
			// 
			this.textBoxCIModelExt.Location = new System.Drawing.Point(80, 88);
			this.textBoxCIModelExt.Name = "textBoxCIModelExt";
			this.textBoxCIModelExt.Size = new System.Drawing.Size(176, 20);
			this.textBoxCIModelExt.TabIndex = 7;
			this.textBoxCIModelExt.Text = "";
			// 
			// textBoxCIModel
			// 
			this.textBoxCIModel.Location = new System.Drawing.Point(80, 64);
			this.textBoxCIModel.Name = "textBoxCIModel";
			this.textBoxCIModel.Size = new System.Drawing.Size(176, 20);
			this.textBoxCIModel.TabIndex = 6;
			this.textBoxCIModel.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "Model Ext:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Model:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Data Size:";
			// 
			// textBoxCIDataSize
			// 
			this.textBoxCIDataSize.Location = new System.Drawing.Point(80, 16);
			this.textBoxCIDataSize.Name = "textBoxCIDataSize";
			this.textBoxCIDataSize.Size = new System.Drawing.Size(176, 20);
			this.textBoxCIDataSize.TabIndex = 0;
			this.textBoxCIDataSize.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Make:";
			// 
			// textBoxCIMake
			// 
			this.textBoxCIMake.Location = new System.Drawing.Point(80, 40);
			this.textBoxCIMake.Name = "textBoxCIMake";
			this.textBoxCIMake.Size = new System.Drawing.Size(176, 20);
			this.textBoxCIMake.TabIndex = 3;
			this.textBoxCIMake.Text = "";
			// 
			// groupBoxImageInfo
			// 
			this.groupBoxImageInfo.Controls.Add(this.textBoxIISize);
			this.groupBoxImageInfo.Controls.Add(this.textBoxIIResolution);
			this.groupBoxImageInfo.Controls.Add(this.textBoxIIPixelFormat);
			this.groupBoxImageInfo.Controls.Add(this.textBoxIIImageType);
			this.groupBoxImageInfo.Controls.Add(this.textBoxIIFrameCount);
			this.groupBoxImageInfo.Controls.Add(this.textBoxIIColorDepth);
			this.groupBoxImageInfo.Controls.Add(this.label12);
			this.groupBoxImageInfo.Controls.Add(this.label11);
			this.groupBoxImageInfo.Controls.Add(this.label10);
			this.groupBoxImageInfo.Controls.Add(this.label9);
			this.groupBoxImageInfo.Controls.Add(this.label8);
			this.groupBoxImageInfo.Controls.Add(this.label7);
			this.groupBoxImageInfo.Location = new System.Drawing.Point(8, 216);
			this.groupBoxImageInfo.Name = "groupBoxImageInfo";
			this.groupBoxImageInfo.Size = new System.Drawing.Size(264, 168);
			this.groupBoxImageInfo.TabIndex = 6;
			this.groupBoxImageInfo.TabStop = false;
			this.groupBoxImageInfo.Text = "ImageInfo";
			// 
			// textBoxIISize
			// 
			this.textBoxIISize.Location = new System.Drawing.Point(80, 136);
			this.textBoxIISize.Name = "textBoxIISize";
			this.textBoxIISize.Size = new System.Drawing.Size(176, 20);
			this.textBoxIISize.TabIndex = 19;
			this.textBoxIISize.Text = "";
			// 
			// textBoxIIResolution
			// 
			this.textBoxIIResolution.Location = new System.Drawing.Point(80, 112);
			this.textBoxIIResolution.Name = "textBoxIIResolution";
			this.textBoxIIResolution.Size = new System.Drawing.Size(176, 20);
			this.textBoxIIResolution.TabIndex = 18;
			this.textBoxIIResolution.Text = "";
			// 
			// textBoxIIPixelFormat
			// 
			this.textBoxIIPixelFormat.Location = new System.Drawing.Point(80, 88);
			this.textBoxIIPixelFormat.Name = "textBoxIIPixelFormat";
			this.textBoxIIPixelFormat.Size = new System.Drawing.Size(176, 20);
			this.textBoxIIPixelFormat.TabIndex = 17;
			this.textBoxIIPixelFormat.Text = "";
			// 
			// textBoxIIImageType
			// 
			this.textBoxIIImageType.Location = new System.Drawing.Point(80, 64);
			this.textBoxIIImageType.Name = "textBoxIIImageType";
			this.textBoxIIImageType.Size = new System.Drawing.Size(176, 20);
			this.textBoxIIImageType.TabIndex = 16;
			this.textBoxIIImageType.Text = "";
			// 
			// textBoxIIFrameCount
			// 
			this.textBoxIIFrameCount.Location = new System.Drawing.Point(80, 40);
			this.textBoxIIFrameCount.Name = "textBoxIIFrameCount";
			this.textBoxIIFrameCount.Size = new System.Drawing.Size(176, 20);
			this.textBoxIIFrameCount.TabIndex = 15;
			this.textBoxIIFrameCount.Text = "";
			// 
			// textBoxIIColorDepth
			// 
			this.textBoxIIColorDepth.Location = new System.Drawing.Point(80, 16);
			this.textBoxIIColorDepth.Name = "textBoxIIColorDepth";
			this.textBoxIIColorDepth.Size = new System.Drawing.Size(176, 20);
			this.textBoxIIColorDepth.TabIndex = 14;
			this.textBoxIIColorDepth.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 13;
			this.label12.Text = "Size:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 24);
			this.label11.TabIndex = 12;
			this.label11.Text = "Resolution:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 11;
			this.label10.Text = "Pixel Format:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 10;
			this.label9.Text = "Image Type:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 24);
			this.label8.TabIndex = 9;
			this.label8.Text = "Frame Count:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 24);
			this.label7.TabIndex = 8;
			this.label7.Text = "Color Depth:";
			// 
			// DisplayImageInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 389);
			this.Controls.Add(this.groupBoxImageInfo);
			this.Controls.Add(this.groupBoxCameraInfo);
			this.Controls.Add(this.groupBoxRawImageInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DisplayImageInfo";
			this.Text = "DisplayImageInfo";
			this.groupBoxRawImageInfo.ResumeLayout(false);
			this.groupBoxCameraInfo.ResumeLayout(false);
			this.groupBoxImageInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


	}
}
