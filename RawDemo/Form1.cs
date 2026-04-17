using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Reflection;

using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
namespace RawDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private RawDecoder _decoder;
		private double _scaleFactor = 0.5;

		private Atalasoft.Imaging.WinControls.ImageViewer imageViewer1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemDecoder;
		private System.Windows.Forms.MenuItem menuItemOpenScaled;
		private System.Windows.Forms.MenuItem menuItemInterpolation;
		private System.Windows.Forms.MenuItem menuItemOpenThumbnail;
		private System.Windows.Forms.MenuItem menuItemOpenPreview;
		private System.Windows.Forms.MenuItem menuItemWhiteBalance;
		private System.Windows.Forms.MenuItem menuItemLoadingPolicy;
		private System.Windows.Forms.MenuItem menuItemUseCameraMatrix;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.MenuItem menuItemSetImageMetrics;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuItem menuItemImageInfo;
        private MenuItem menuHelp;
        private MenuItem menuHelpAbout;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			InitializeDecoder();
			InitializeMenus();
		}

		private void InitializeDecoder()
		{
			_decoder = new RawDecoder();
			RegisteredDecoders.Decoders.Insert(0, _decoder);
		}

		private void InitializeMenus()
		{
			//Populate LoadingPolicy
			populateMenu( menuItemLoadingPolicy, typeof(LoadingPolicy), new EventHandler(this.menuItemLoadingPolicy_Click) );
			setDefaultMenuItem( menuItemLoadingPolicy, _decoder.Policy.ToString() );
			
			//Populate Interpolation
			populateMenu( menuItemInterpolation, typeof(RawInterpolationMethods), new EventHandler( this.menuItemRawInterpolationMethods_Click ) );
			setDefaultMenuItem( menuItemInterpolation, _decoder.Interpolation.ToString() );

			//Populate WhiteBalance
			populateMenu( menuItemWhiteBalance, typeof(RawWhiteBalanceMethods), new EventHandler( this.menuItemRawWhiteBalanceMethods_Click ) );
			setDefaultMenuItem( menuItemWhiteBalance, _decoder.WhiteBalance.ToString() );

			//Set UseCameraMatrix MenuItem
			menuItemUseCameraMatrix.Checked = _decoder.UseCameraMatrix;
		}

		private void setDefaultMenuItem( MenuItem parent, string selected )
		{
			foreach( MenuItem item in parent.MenuItems )
			{
				if (item.Text.Equals( selected ))
				{
					item.Checked = true;
					return;
				}
			}
		}

		private void populateMenu( MenuItem baseItem, Type inType, EventHandler inEvent ) 
		{
			foreach( string name in Enum.GetNames( inType ))
			{
				MenuItem newItem = new MenuItem( name );
				newItem.Click += inEvent;
				baseItem.MenuItems.Add( newItem );
			}

		}

		private void checkAndUncheckSiblings( MenuItem selectedItem )
		{
			foreach ( MenuItem subItem in selectedItem.Parent.MenuItems )
			{
				subItem.Checked = false;
			}

			selectedItem.Checked = true;
		}

		private void menuItemLoadingPolicy_Click(object sender, System.EventArgs e)
		{
			MenuItem selectedItem = sender as MenuItem;
			checkAndUncheckSiblings( selectedItem );
			
			_decoder.Policy = (LoadingPolicy) Enum.Parse( typeof(LoadingPolicy), selectedItem.Text );
		}

		private void menuItemRawInterpolationMethods_Click(object sender, System.EventArgs e)
		{
			MenuItem selectedItem = sender as MenuItem;
			checkAndUncheckSiblings( selectedItem );

			_decoder.Interpolation = (RawInterpolationMethods) Enum.Parse( typeof(RawInterpolationMethods), selectedItem.Text );

		}

		private void menuItemRawWhiteBalanceMethods_Click(object sender, System.EventArgs e)
		{
			MenuItem selectedItem = sender as MenuItem;
			checkAndUncheckSiblings( selectedItem );

			_decoder.WhiteBalance = (RawWhiteBalanceMethods) Enum.Parse( typeof(RawWhiteBalanceMethods), selectedItem.Text );
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            this.imageViewer1 = new Atalasoft.Imaging.WinControls.ImageViewer();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemOpenScaled = new System.Windows.Forms.MenuItem();
            this.menuItemOpenThumbnail = new System.Windows.Forms.MenuItem();
            this.menuItemOpenPreview = new System.Windows.Forms.MenuItem();
            this.menuItemImageInfo = new System.Windows.Forms.MenuItem();
            this.menuItemDecoder = new System.Windows.Forms.MenuItem();
            this.menuItemLoadingPolicy = new System.Windows.Forms.MenuItem();
            this.menuItemInterpolation = new System.Windows.Forms.MenuItem();
            this.menuItemWhiteBalance = new System.Windows.Forms.MenuItem();
            this.menuItemSetImageMetrics = new System.Windows.Forms.MenuItem();
            this.menuItemUseCameraMatrix = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuHelpAbout = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // imageViewer1
            // 
            this.imageViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageViewer1.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray;
            this.imageViewer1.DisplayProfile = null;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Magnifier.BackColor = System.Drawing.Color.White;
            this.imageViewer1.Magnifier.BorderColor = System.Drawing.Color.Black;
            this.imageViewer1.Magnifier.Size = new System.Drawing.Size(100, 100);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.OutputProfile = null;
            this.imageViewer1.Selection = null;
            this.imageViewer1.Size = new System.Drawing.Size(680, 560);
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
            this.imageViewer1.MouseTool = Atalasoft.Imaging.WinControls.MouseToolType.Magnifier;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemDecoder,
            this.menuHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOpen,
            this.menuItemOpenScaled,
            this.menuItemOpenThumbnail,
            this.menuItemOpenPreview,
            this.menuItemImageInfo});
            this.menuItemFile.Text = "File";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 0;
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemOpenScaled
            // 
            this.menuItemOpenScaled.Index = 1;
            this.menuItemOpenScaled.Text = "Open Scaled";
            this.menuItemOpenScaled.Click += new System.EventHandler(this.menuItemOpenScaled_Click);
            // 
            // menuItemOpenThumbnail
            // 
            this.menuItemOpenThumbnail.Index = 2;
            this.menuItemOpenThumbnail.Text = "Open Thumbnail";
            this.menuItemOpenThumbnail.Click += new System.EventHandler(this.menuItemOpenThumbnail_Click);
            // 
            // menuItemOpenPreview
            // 
            this.menuItemOpenPreview.Index = 3;
            this.menuItemOpenPreview.Text = "Open Preview";
            this.menuItemOpenPreview.Click += new System.EventHandler(this.menuItemOpenPreview_Click);
            // 
            // menuItemImageInfo
            // 
            this.menuItemImageInfo.Index = 4;
            this.menuItemImageInfo.Text = "Open Image Info";
            this.menuItemImageInfo.Click += new System.EventHandler(this.menuItemImageInfo_Click);
            // 
            // menuItemDecoder
            // 
            this.menuItemDecoder.Index = 1;
            this.menuItemDecoder.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemLoadingPolicy,
            this.menuItemInterpolation,
            this.menuItemWhiteBalance,
            this.menuItemSetImageMetrics,
            this.menuItemUseCameraMatrix});
            this.menuItemDecoder.Text = "Decoder";
            // 
            // menuItemLoadingPolicy
            // 
            this.menuItemLoadingPolicy.Index = 0;
            this.menuItemLoadingPolicy.Text = "Loading Policy";
            // 
            // menuItemInterpolation
            // 
            this.menuItemInterpolation.Index = 1;
            this.menuItemInterpolation.Text = "Interpolation";
            // 
            // menuItemWhiteBalance
            // 
            this.menuItemWhiteBalance.Index = 2;
            this.menuItemWhiteBalance.Text = "White Balance";
            // 
            // menuItemSetImageMetrics
            // 
            this.menuItemSetImageMetrics.Index = 3;
            this.menuItemSetImageMetrics.Text = "Set Image Metrics";
            this.menuItemSetImageMetrics.Click += new System.EventHandler(this.menuItemSetImageMetrics_Click);
            // 
            // menuItemUseCameraMatrix
            // 
            this.menuItemUseCameraMatrix.Index = 4;
            this.menuItemUseCameraMatrix.Text = "Use Camera Matrix";
            this.menuItemUseCameraMatrix.Click += new System.EventHandler(this.menuItemUseCameraMatrix_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 565);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(680, 24);
            this.statusBar1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(8, 568);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(648, 16);
            this.progressBar1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files|*.*|Raw Files|*.dcr;*.dng;*.eff;*.mrw;*.nef;*.orf;*.pef;*.raf;*.srf;*.x" +
                "3f;*.crw;*.cr2;*.tif;*.ppm";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Raw File";
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelpAbout});
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Index = 0;
            this.menuHelpAbout.Text = "About ...";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(680, 589);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.imageViewer1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Raw Demo";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Viewer_Progress(object sender, ProgressEventArgs e)
		{
			if (e.Total == 0) 
				e.Total = 1;
			progressBar1.Value = e.Current * 100 / e.Total;
			if (progressBar1.Value == 100)
				progressBar1.Value = 0;
		}

		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{				
				try 
				{
					imageViewer1.Image = _decoder.Read( openFileDialog1.OpenFile(), new Atalasoft.Imaging.ProgressEventHandler( Viewer_Progress ) );
				}
				catch (Exception E)
				{
					MessageBox.Show( "Image Could Not Be Read:\n " + E.ToString() ); 
				}
			}
		}

		private void menuItemOpenScaled_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				try 
				{
					imageViewer1.Image = _decoder.ReadScaled( openFileDialog1.OpenFile(), 0, _scaleFactor, new Atalasoft.Imaging.ProgressEventHandler( Viewer_Progress ) );
				}
				catch (Exception E)
				{
					MessageBox.Show( "Image Could Not Be Read:\n " + E.ToString() ); 
				}
			}
		}

		private void menuItemOpenThumbnail_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				try 
				{
					imageViewer1.Image = _decoder.GetThumbnail( openFileDialog1.OpenFile() );
				}
				catch (Exception E)
				{
					MessageBox.Show( "Thumbnail Could Not Be Read:\n " + E.ToString() ); 
				}

				if ( imageViewer1.Image == null )
					MessageBox.Show( "No Thumbnail Could Be Found." );
			}
		}

		private void menuItemOpenPreview_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				try 
				{
					imageViewer1.Image = _decoder.GetPreviewImage( openFileDialog1.OpenFile() );
				}
				catch (Exception E)
				{
					MessageBox.Show( "Preview Could Not Be Read:\n " + E.ToString() ); 
				}

				if ( imageViewer1.Image == null )
					MessageBox.Show( "No Preview Could Be Found." );
			}
		}

		private void menuItemImageInfo_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				ImageInfo info;

				try 
				{
					info = _decoder.GetImageInfo( openFileDialog1.OpenFile() );
					
					DisplayImageInfo dInfo = new DisplayImageInfo( info );
					dInfo.ShowDialog();
				}
				catch (Exception E)
				{
					MessageBox.Show( "ImageInfo Could Not Be Read:\n " + E.ToString() ); 
				}
			}
		}

		private void menuItemUseCameraMatrix_Click(object sender, System.EventArgs e)
		{
			MenuItem item = sender as MenuItem;
			if (item.Checked == true)
			{
				item.Checked = false;
				_decoder.UseCameraMatrix = false;

			}
			else
			{
				item.Checked = true;
				_decoder.UseCameraMatrix = true;
			}	
		}

		private void menuItemSetImageMetrics_Click(object sender, System.EventArgs e)
		{
			ImageMetrics form = new ImageMetrics( _decoder );
			form.ShowDialog();
		}

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("About Atalasoft Raw Demo", "Raw Demo");
            aboutBox.Description = "A basic image viewer using our RawDecoder to load/view RAW format images (DNG, RAW, CR2, etc...) as well as the embedded thumbnails and image info.\r\n\r\n" +
                                   "Demonstrates using our RawDecoder to view and scale RAW format images, as well as accessing the embedded thumbnail, preview, and Image Info.\r\n\r\n" +
                                   "In addition, our RawDecoder allows for control over loading policy, interpolation, white balance and Image metrics. This demo provides a practical working example of these settings.";
            aboutBox.ShowDialog();
        }


	}
}
