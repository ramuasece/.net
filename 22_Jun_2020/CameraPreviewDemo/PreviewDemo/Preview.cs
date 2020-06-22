using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Threading;
using System.IO.Ports;

using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using ZXing;

namespace PreviewDemo
{
	/// <summary>
	/// Summary description of Form1.
	/// </summary>
	public class Preview : MetroFramework.Forms.MetroForm
    {
        private uint iLastErr = 0;
		private Int32 m_lUserID = -1;
		private bool m_bInitSDK = false;
		private Int32 m_lRealHandle = -1;
        private string str;

        CHCNetSDK.REALDATACALLBACK RealData = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;


        private uint iLastErr2 = 0;
        private Int32 m_lUserID2 = -1;
        private bool m_bInitSDK2 = false;
        private Int32 m_lRealHandle2 = -1;
        private string str2;

        CHCNetSDK.REALDATACALLBACK RealData2 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg2;


        private uint iLastErr3 = 0;
        private Int32 m_lUserID3 = -1;
        private bool m_bInitSDK3 = false;
        private Int32 m_lRealHandle3 = -1;
        private string str3;

        CHCNetSDK.REALDATACALLBACK RealData3 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg3;


        private uint iLastErr4 = 0;
        private Int32 m_lUserID4 = -1;
        private bool m_bInitSDK4 = false;
        private Int32 m_lRealHandle4 = -1;
        private string str4;

        CHCNetSDK.REALDATACALLBACK RealData4 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg4;


        private uint iLastErr5 = 0;
        private Int32 m_lUserID5 = -1;
        private bool m_bInitSDK5 = false;
        private Int32 m_lRealHandle5 = -1;
        private string str5;

        CHCNetSDK.REALDATACALLBACK RealData5 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg5;

		private System.Windows.Forms.PictureBox RealPlayWnd;
        private Button btnJPEG;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private PictureBox RealPlayWnd2;
        private PictureBox RealPlayWnd3;
        private PictureBox RealPlayWnd5;
        private PictureBox RealPlayWnd4;
        private GroupBox btnCamera;
        private Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private TextBox textBoxDataIN;
        private ProgressBar progressBar1;
        private Label lblDataInLength;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private TextBox textBoxQRCode;
        private Button btnScan;
        private PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private Panel panelSideMenu;
        private Panel panelSubMenuPreview;
        private Button btnMenuPreview;
        private Panel panelLogo;
        private Button btnMenuExit;
        private Panel panelChildForm;
        private Button btnSideMenuConfiguration;
        private RichTextBox rTxtReader;
        private ComboBox comboBoxCOMPort;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private TextBox textBoxCapturedTareWeight;
        private Label label2;
        private Label label1;
        private PictureBox picBoxReader;
        private IContainer components;

        public Preview()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            customizeDesign();

            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
			if (m_bInitSDK == false)
			{
				MessageBox.Show("NET_DVR_Init error!");
				return;
			}
			else
			{
                // Save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
			}
            //
            // TODO: add any constructor code after InitializeComponent call
            //
        }

		/// <summary>
        /// Clean up all resources in use.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if (m_lRealHandle >= 0)
			{
				CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
			}
			if (m_lUserID >= 0)
			{
				CHCNetSDK.NET_DVR_Logout(m_lUserID);
			}
			if (m_bInitSDK == true)
			{
				CHCNetSDK.NET_DVR_Cleanup();
			}

            if (m_lRealHandle2 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle2);
            }
            if (m_lUserID2 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID2);
            }
            if (m_bInitSDK2 == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if (m_lRealHandle3 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3);
            }
            if (m_lUserID3 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID3);
            }
            if (m_bInitSDK3 == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if (m_lRealHandle4 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4);
            }
            if (m_lUserID4 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID4);
            }
            if (m_bInitSDK4 == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if (m_lRealHandle5 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle5);
            }
            if (m_lUserID5 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID5);
            }
            if (m_bInitSDK5 == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if ( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		# region  Windows Form Designer generated code
        /// <summary>
        /// The designer supports the required method-do not use the code editor to modify
        /// The content of this method.
        /// </summary>
		private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.RealPlayWnd2 = new System.Windows.Forms.PictureBox();
            this.RealPlayWnd3 = new System.Windows.Forms.PictureBox();
            this.RealPlayWnd5 = new System.Windows.Forms.PictureBox();
            this.RealPlayWnd4 = new System.Windows.Forms.PictureBox();
            this.btnCamera = new System.Windows.Forms.GroupBox();
            this.textBoxDataIN = new System.Windows.Forms.TextBox();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.panelSubMenuPreview = new System.Windows.Forms.Panel();
            this.btnSideMenuConfiguration = new System.Windows.Forms.Button();
            this.btnMenuPreview = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.picBoxReader = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCapturedTareWeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTxtReader = new System.Windows.Forms.RichTextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).BeginInit();
            this.btnCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuPreview.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReader)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.Location = new System.Drawing.Point(6, 8);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(372, 220);
            this.RealPlayWnd.TabIndex = 4;
            this.RealPlayWnd.TabStop = false;
            // 
            // btnJPEG
            // 
            this.btnJPEG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG.Location = new System.Drawing.Point(6, 12);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(358, 38);
            this.btnJPEG.TabIndex = 9;
            this.btnJPEG.Text = "Capture JPEG";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // RealPlayWnd2
            // 
            this.RealPlayWnd2.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd2.Location = new System.Drawing.Point(760, 8);
            this.RealPlayWnd2.Name = "RealPlayWnd2";
            this.RealPlayWnd2.Size = new System.Drawing.Size(371, 220);
            this.RealPlayWnd2.TabIndex = 4;
            this.RealPlayWnd2.TabStop = false;
            // 
            // RealPlayWnd3
            // 
            this.RealPlayWnd3.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd3.Location = new System.Drawing.Point(6, 234);
            this.RealPlayWnd3.Name = "RealPlayWnd3";
            this.RealPlayWnd3.Size = new System.Drawing.Size(372, 220);
            this.RealPlayWnd3.TabIndex = 4;
            this.RealPlayWnd3.TabStop = false;
            // 
            // RealPlayWnd5
            // 
            this.RealPlayWnd5.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd5.Location = new System.Drawing.Point(760, 234);
            this.RealPlayWnd5.Name = "RealPlayWnd5";
            this.RealPlayWnd5.Size = new System.Drawing.Size(372, 220);
            this.RealPlayWnd5.TabIndex = 4;
            this.RealPlayWnd5.TabStop = false;
            // 
            // RealPlayWnd4
            // 
            this.RealPlayWnd4.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd4.Location = new System.Drawing.Point(383, 234);
            this.RealPlayWnd4.Name = "RealPlayWnd4";
            this.RealPlayWnd4.Size = new System.Drawing.Size(372, 220);
            this.RealPlayWnd4.TabIndex = 4;
            this.RealPlayWnd4.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.Controls.Add(this.textBoxDataIN);
            this.btnCamera.ForeColor = System.Drawing.Color.LightGray;
            this.btnCamera.Location = new System.Drawing.Point(384, 8);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(371, 111);
            this.btnCamera.TabIndex = 43;
            this.btnCamera.TabStop = false;
            this.btnCamera.Text = "Weighment Screen";
            // 
            // textBoxDataIN
            // 
            this.textBoxDataIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDataIN.Enabled = false;
            this.textBoxDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataIN.Location = new System.Drawing.Point(10, 18);
            this.textBoxDataIN.Name = "textBoxDataIN";
            this.textBoxDataIN.ReadOnly = true;
            this.textBoxDataIN.Size = new System.Drawing.Size(354, 83);
            this.textBoxDataIN.TabIndex = 1;
            this.textBoxDataIN.Text = "00000";
            this.textBoxDataIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDataIN.TextChanged += new System.EventHandler(this.textBoxDataIN_TextChanged);
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Enabled = false;
            this.textBoxQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQRCode.Location = new System.Drawing.Point(384, 491);
            this.textBoxQRCode.Multiline = true;
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.ReadOnly = true;
            this.textBoxQRCode.Size = new System.Drawing.Size(188, 35);
            this.textBoxQRCode.TabIndex = 65;
            this.textBoxQRCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Location = new System.Drawing.Point(383, 532);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(372, 35);
            this.btnScan.TabIndex = 66;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(6, 460);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(372, 220);
            this.pictureBox.TabIndex = 67;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.Location = new System.Drawing.Point(178, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 22);
            this.btnOpen.TabIndex = 54;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(288, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(21, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 55;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataInLength.Location = new System.Drawing.Point(6, 11);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(41, 29);
            this.lblDataInLength.TabIndex = 59;
            this.lblDataInLength.Text = "00";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.lblDataInLength);
            this.groupBox8.Location = new System.Drawing.Point(705, 121);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(50, 45);
            this.groupBox8.TabIndex = 61;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.comboBoxCOMPort);
            this.groupBox9.Controls.Add(this.progressBar1);
            this.groupBox9.Controls.Add(this.btnOpen);
            this.groupBox9.Location = new System.Drawing.Point(384, 121);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(315, 45);
            this.groupBox9.TabIndex = 62;
            this.groupBox9.TabStop = false;
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(6, 15);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(166, 21);
            this.comboBoxCOMPort.TabIndex = 57;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnMenuExit);
            this.panelSideMenu.Controls.Add(this.panelSubMenuPreview);
            this.panelSideMenu.Controls.Add(this.btnMenuPreview);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(20, 30);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(188, 688);
            this.panelSideMenu.TabIndex = 69;
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuExit.FlatAppearance.BorderSize = 0;
            this.btnMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuExit.Location = new System.Drawing.Point(0, 187);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuExit.Size = new System.Drawing.Size(188, 44);
            this.btnMenuExit.TabIndex = 4;
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuExit.UseVisualStyleBackColor = true;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // panelSubMenuPreview
            // 
            this.panelSubMenuPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuPreview.Controls.Add(this.btnSideMenuConfiguration);
            this.panelSubMenuPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPreview.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuPreview.Name = "panelSubMenuPreview";
            this.panelSubMenuPreview.Size = new System.Drawing.Size(188, 42);
            this.panelSubMenuPreview.TabIndex = 3;
            // 
            // btnSideMenuConfiguration
            // 
            this.btnSideMenuConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSideMenuConfiguration.FlatAppearance.BorderSize = 0;
            this.btnSideMenuConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenuConfiguration.ForeColor = System.Drawing.Color.LightGray;
            this.btnSideMenuConfiguration.Location = new System.Drawing.Point(0, 0);
            this.btnSideMenuConfiguration.Name = "btnSideMenuConfiguration";
            this.btnSideMenuConfiguration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSideMenuConfiguration.Size = new System.Drawing.Size(188, 40);
            this.btnSideMenuConfiguration.TabIndex = 0;
            this.btnSideMenuConfiguration.Text = "Configuration";
            this.btnSideMenuConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenuConfiguration.UseVisualStyleBackColor = true;
            this.btnSideMenuConfiguration.Click += new System.EventHandler(this.btnSideMenuConfiguration_Click);
            // 
            // btnMenuPreview
            // 
            this.btnMenuPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPreview.FlatAppearance.BorderSize = 0;
            this.btnMenuPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPreview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuPreview.Location = new System.Drawing.Point(0, 100);
            this.btnMenuPreview.Name = "btnMenuPreview";
            this.btnMenuPreview.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPreview.Size = new System.Drawing.Size(188, 45);
            this.btnMenuPreview.TabIndex = 2;
            this.btnMenuPreview.Text = "Preview";
            this.btnMenuPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPreview.UseVisualStyleBackColor = true;
            this.btnMenuPreview.Click += new System.EventHandler(this.btnMenuPreview_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.picBoxReader);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.textBoxCapturedTareWeight);
            this.panelChildForm.Controls.Add(this.groupBox1);
            this.panelChildForm.Controls.Add(this.textBoxQRCode);
            this.panelChildForm.Controls.Add(this.btnScan);
            this.panelChildForm.Controls.Add(this.pictureBox);
            this.panelChildForm.Controls.Add(this.rTxtReader);
            this.panelChildForm.Controls.Add(this.RealPlayWnd3);
            this.panelChildForm.Controls.Add(this.groupBox9);
            this.panelChildForm.Controls.Add(this.RealPlayWnd);
            this.panelChildForm.Controls.Add(this.RealPlayWnd5);
            this.panelChildForm.Controls.Add(this.RealPlayWnd2);
            this.panelChildForm.Controls.Add(this.RealPlayWnd4);
            this.panelChildForm.Controls.Add(this.groupBox8);
            this.panelChildForm.Controls.Add(this.btnCamera);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(208, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1138, 688);
            this.panelChildForm.TabIndex = 70;
            // 
            // picBoxReader
            // 
            this.picBoxReader.BackColor = System.Drawing.Color.Black;
            this.picBoxReader.Location = new System.Drawing.Point(414, 573);
            this.picBoxReader.Name = "picBoxReader";
            this.picBoxReader.Size = new System.Drawing.Size(26, 21);
            this.picBoxReader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxReader.TabIndex = 74;
            this.picBoxReader.TabStop = false;
            this.picBoxReader.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(384, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Vehicle No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(573, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Captured Weight";
            // 
            // textBoxCapturedTareWeight
            // 
            this.textBoxCapturedTareWeight.Enabled = false;
            this.textBoxCapturedTareWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapturedTareWeight.Location = new System.Drawing.Point(577, 491);
            this.textBoxCapturedTareWeight.Multiline = true;
            this.textBoxCapturedTareWeight.Name = "textBoxCapturedTareWeight";
            this.textBoxCapturedTareWeight.ReadOnly = true;
            this.textBoxCapturedTareWeight.Size = new System.Drawing.Size(178, 35);
            this.textBoxCapturedTareWeight.TabIndex = 69;
            this.textBoxCapturedTareWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJPEG);
            this.groupBox1.Location = new System.Drawing.Point(384, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 56);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // rTxtReader
            // 
            this.rTxtReader.Location = new System.Drawing.Point(386, 573);
            this.rTxtReader.Name = "rTxtReader";
            this.rTxtReader.Size = new System.Drawing.Size(22, 21);
            this.rTxtReader.TabIndex = 5;
            this.rTxtReader.Text = "";
            this.rTxtReader.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 2000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 3000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Preview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.DisplayHeader = false;
            this.Name = "Preview";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Empezar Logistics";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preview_FormClosing);
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).EndInit();
            this.btnCamera.ResumeLayout(false);
            this.btnCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuPreview.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		# endregion

		/// <summary>
        /// The main entry point of the application.
        /// </summary>
		[MTAThread]
		static void Main() 
		{
			Application.Run(new Preview());
		}

        private void customizeDesign()
        {
            panelSubMenuPreview.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuPreview.Visible == true)
                panelSubMenuPreview.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMenuPreview_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPreview);
        }

        private void btnSideMenuConfiguration_Click(object sender, EventArgs e)
        {
            openChildForm(new Configuration());
            //
            //
            //
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        string cameraIP1;
        string cameraPort1;
        string cameraUsername1;
        string cameraPassword1;
        string cameraChannel1;
        string cameraStatus1;

        string cameraIP2;
        string cameraPort2;
        string cameraUsername2;
        string cameraPassword2;
        string cameraChannel2;
        string cameraStatus2;

        string cameraIP3;
        string cameraPort3;
        string cameraUsername3;
        string cameraPassword3;
        string cameraChannel3;
        string cameraStatus3;

        string cameraIP4;
        string cameraPort4;
        string cameraUsername4;
        string cameraPassword4;
        string cameraChannel4;
        string cameraStatus4;

        string cameraIP5;
        string cameraPort5;
        string cameraUsername5;
        string cameraPassword5;
        string cameraChannel5;
        string cameraStatus5;

        string baudRate;
        string dataBits;
        string parityBits;
        string stopBits;

        string tareWeight;

        public void config()
        {
            var path = @"Config\\app.config";


            var line1 = File.ReadLines(path).ElementAt(1 - 1);
            line1 = line1.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line1;
            cameraIP1 = rTxtReader.Lines.ElementAt(1 - 1);
            cameraPort1 = rTxtReader.Lines.ElementAt(2 - 1);
            cameraUsername1 = rTxtReader.Lines.ElementAt(3 - 1);
            cameraPassword1 = rTxtReader.Lines.ElementAt(4 - 1);
            cameraChannel1 = rTxtReader.Lines.ElementAt(5 - 1);
            cameraStatus1 = rTxtReader.Lines.ElementAt(6 - 1);


            var line2 = File.ReadLines(path).ElementAt(2 - 1);
            line2 = line2.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line2;
            cameraIP2 = rTxtReader.Lines.ElementAt(1 - 1);
            cameraPort2 = rTxtReader.Lines.ElementAt(2 - 1);
            cameraUsername2 = rTxtReader.Lines.ElementAt(3 - 1);
            cameraPassword2 = rTxtReader.Lines.ElementAt(4 - 1);
            cameraChannel2 = rTxtReader.Lines.ElementAt(5 - 1);
            cameraStatus2 = rTxtReader.Lines.ElementAt(6 - 1);


            var line3 = File.ReadLines(path).ElementAt(3 - 1);
            line3 = line3.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line3;
            cameraIP3 = rTxtReader.Lines.ElementAt(1 - 1);
            cameraPort3 = rTxtReader.Lines.ElementAt(2 - 1);
            cameraUsername3 = rTxtReader.Lines.ElementAt(3 - 1);
            cameraPassword3 = rTxtReader.Lines.ElementAt(4 - 1);
            cameraChannel3 = rTxtReader.Lines.ElementAt(5 - 1);
            cameraStatus3 = rTxtReader.Lines.ElementAt(6 - 1);


            var line4 = File.ReadLines(path).ElementAt(4 - 1);
            line4 = line4.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line4;
            cameraIP4 = rTxtReader.Lines.ElementAt(1 - 1);
            cameraPort4 = rTxtReader.Lines.ElementAt(2 - 1);
            cameraUsername4 = rTxtReader.Lines.ElementAt(3 - 1);
            cameraPassword4 = rTxtReader.Lines.ElementAt(4 - 1);
            cameraChannel4 = rTxtReader.Lines.ElementAt(5 - 1);
            cameraStatus4 = rTxtReader.Lines.ElementAt(6 - 1);


            var line5 = File.ReadLines(path).ElementAt(5 - 1);
            line5 = line5.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line5;
            cameraIP5 = rTxtReader.Lines.ElementAt(1 - 1);
            cameraPort5 = rTxtReader.Lines.ElementAt(2 - 1);
            cameraUsername5 = rTxtReader.Lines.ElementAt(3 - 1);
            cameraPassword5 = rTxtReader.Lines.ElementAt(4 - 1);
            cameraChannel5 = rTxtReader.Lines.ElementAt(5 - 1);
            cameraStatus5 = rTxtReader.Lines.ElementAt(6 - 1);


            var line7 = File.ReadLines(path).ElementAt(7 - 1);
            line7 = line7.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line7;
            baudRate = rTxtReader.Lines.ElementAt(1 - 1);
            dataBits = rTxtReader.Lines.ElementAt(2 - 1);
            parityBits = rTxtReader.Lines.ElementAt(3 - 1);
            stopBits = rTxtReader.Lines.ElementAt(4 - 1);


            var line9 = File.ReadLines(path).ElementAt(9 - 1);
            line9 = line9.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line9;
            tareWeight = rTxtReader.Lines.ElementAt(1 - 1);


            rTxtReader.Clear();
        }

        public void camera1_on()
        {
            if (cameraIP1 == "" || cameraPort1 == "" ||
                cameraUsername1 == "" || cameraPassword1 == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password! of Cam 1");
                return;
            }

            if (m_lUserID < 0)
            {
                string DVRIPAddress = cameraIP1; // Device IP address or domain name
                Int16 DVRPortNumber = Int16.Parse(cameraPort1); // Device service port number
                string DVRUserName = cameraUsername1; // Device login user name
                string DVRPassword = cameraPassword1; // device login password

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                // Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    // Login successful
                    // MessageBox.Show("Login Success!");

                    if (m_lRealHandle < 0)
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle; // Preview window
                        lpPreviewInfo.lChannel = Int16.Parse(cameraChannel1); // Preview device channel
                        lpPreviewInfo.dwStreamType = 0; // stream type: 0-main stream, 1-substream, 2-stream 3, 3-stream 4, and so on
                        lpPreviewInfo.dwLinkMode = 0; // Connection mode: 0- TCP mode, 1- UDP mode, 2- multicast mode, 3- RTP mode, 4-RTP/RTSP, 5-RSTP/HTTP
                        lpPreviewInfo.bBlocked = true; // 0- non-blocking fetching, 1- blocking fetching
                        lpPreviewInfo.dwDisplayBufNum = 1; // Maximum number of buffered frames in the playback buffer of the playback library
                        lpPreviewInfo.byProtoType = 0;
                        lpPreviewInfo.byPreviewMode = 0;


                        if (RealData == null)
                        {
                            RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack); // Preview real-time stream callback function
                        }

                        IntPtr pUser = new IntPtr(); // User data

                        // Open preview Start live view
                        m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
                        if (m_lRealHandle < 0)
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; // Preview failed, output error number
                            MessageBox.Show(str);
                            return;
                        }
                        else
                        {
                            // Preview is successful
                        }

                        RealPlayWnd.Enabled = true;
                    }
                }
            }
        }

        public void camera1_off()
        {
            if (m_lUserID >= 0)
            {
                if (m_lRealHandle >= 0)
                {
                    // Stop live view
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                        MessageBox.Show(str);
                        return;
                    }
                    m_lRealHandle = -1;

                    RealPlayWnd.Enabled = false;
                }

                // Logout the device
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lUserID = -1;
            }
            return;
        }

        public void camera2_on()
        {
            if (cameraIP2 == "" || cameraPort2 == "" ||
                cameraUsername2 == "" || cameraPassword2 == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID2 < 0)
            {
                string DVRIPAddress2 = cameraIP2;
                Int16 DVRPortNumber2 = Int16.Parse(cameraPort2);
                string DVRUserName2 = cameraUsername2;
                string DVRPassword2 = cameraPassword2;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo2 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID2 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress2, DVRPortNumber2, DVRUserName2, DVRPassword2, ref DeviceInfo2);
                if (m_lUserID2 < 0)
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_Login_V30 failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                else
                {
                    // MessageBox.Show("Login Success!");

                    if (m_lRealHandle2 < 0)
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo2 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo2.hPlayWnd = RealPlayWnd2.Handle;
                        lpPreviewInfo2.lChannel = Int16.Parse(cameraChannel2);
                        lpPreviewInfo2.dwStreamType = 0;
                        lpPreviewInfo2.dwLinkMode = 0;
                        lpPreviewInfo2.bBlocked = true;
                        lpPreviewInfo2.dwDisplayBufNum = 1;
                        lpPreviewInfo2.byProtoType = 0;
                        lpPreviewInfo2.byPreviewMode = 0;


                        if (RealData2 == null)
                        {
                            RealData2 = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack2);
                        }

                        IntPtr pUser2 = new IntPtr();

                        m_lRealHandle2 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID2, ref lpPreviewInfo2, null/*RealData*/, pUser2);
                        if (m_lRealHandle2 < 0)
                        {
                            iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                            str2 = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr2;
                            MessageBox.Show(str2);
                            return;
                        }
                        else
                        {
                            // Preview is successful
                        }

                        RealPlayWnd2.Enabled = true;
                    }
                }
            }
        }

        public void camera2_off()
        {
            if (m_lUserID2 >= 0)
            {
                if (m_lRealHandle2 >= 0)
                {
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle2))
                    {
                        iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                        str2 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr2;
                        MessageBox.Show(str2);
                        return;
                    }
                    m_lRealHandle2 = -1;

                    RealPlayWnd2.Enabled = false;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID2))
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_Logout failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                m_lUserID2 = -1;
            }
            return;
        }

        public void camera3_on()
        {
            if (cameraIP3 == "" || cameraPort3 == "" ||
                cameraUsername3 == "" || cameraPassword3 == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID3 < 0)
            {
                string DVRIPAddress3 = cameraIP3;
                Int16 DVRPortNumber3 = Int16.Parse(cameraPort3);
                string DVRUserName3 = cameraUsername3;
                string DVRPassword3 = cameraPassword3;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo3 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID3 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress3, DVRPortNumber3, DVRUserName3, DVRPassword3, ref DeviceInfo3);
                if (m_lUserID3 < 0)
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_Login_V30 failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                else
                {
                    // MessageBox.Show("Login Success!");


                    if (m_lRealHandle3 < 0)
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo3 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo3.hPlayWnd = RealPlayWnd3.Handle;
                        lpPreviewInfo3.lChannel = Int16.Parse(cameraChannel3);
                        lpPreviewInfo3.dwStreamType = 0;
                        lpPreviewInfo3.dwLinkMode = 0;
                        lpPreviewInfo3.bBlocked = true;
                        lpPreviewInfo3.dwDisplayBufNum = 1;
                        lpPreviewInfo3.byProtoType = 0;
                        lpPreviewInfo3.byPreviewMode = 0;


                        if (RealData3 == null)
                        {
                            RealData3 = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack3);
                        }

                        IntPtr pUser3 = new IntPtr();

                        m_lRealHandle3 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID3, ref lpPreviewInfo3, null/*RealData*/, pUser3);
                        if (m_lRealHandle3 < 0)
                        {
                            iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                            str3 = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr3;
                            MessageBox.Show(str3);
                            return;
                        }
                        else
                        {
                            // Preview is successful
                        }

                        RealPlayWnd3.Enabled = true;
                    }
                }
            }
        }

        public void camera3_off()
        { 
            if (m_lUserID3 >= 0)
            {
                if (m_lRealHandle3 >= 0)
                {
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3))
                    {
                        iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                        str3 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr3;
                        MessageBox.Show(str3);
                        return;
                    }
                    m_lRealHandle3 = -1;

                    RealPlayWnd3.Enabled = false;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_Logout failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                m_lUserID3 = -1;
            }
            return;
        }

        public void camera4_on()
        {
            if (cameraIP4 == "" || cameraPort4 == "" ||
                cameraUsername4 == "" || cameraPassword4 == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID4 < 0)
            {
                string DVRIPAddress4 = cameraIP4;
                Int16 DVRPortNumber4 = Int16.Parse(cameraPort4);
                string DVRUserName4 = cameraUsername4;
                string DVRPassword4 = cameraPassword4;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo4 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID4 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress4, DVRPortNumber4, DVRUserName4, DVRPassword4, ref DeviceInfo4);
                if (m_lUserID4 < 0)
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_Login_V30 failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                else
                {
                    // MessageBox.Show("Login Success!");


                    if (m_lRealHandle4 < 0)
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo4 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo4.hPlayWnd = RealPlayWnd4.Handle;
                        lpPreviewInfo4.lChannel = Int16.Parse(cameraChannel4);
                        lpPreviewInfo4.dwStreamType = 0;
                        lpPreviewInfo4.dwLinkMode = 0;
                        lpPreviewInfo4.bBlocked = true;
                        lpPreviewInfo4.dwDisplayBufNum = 1;
                        lpPreviewInfo4.byProtoType = 0;
                        lpPreviewInfo4.byPreviewMode = 0;


                        if (RealData4 == null)
                        {
                            RealData4 = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack4);
                        }

                        IntPtr pUser4 = new IntPtr();

                        m_lRealHandle4 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID4, ref lpPreviewInfo4, null/*RealData*/, pUser4);
                        if (m_lRealHandle4 < 0)
                        {
                            iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                            str4 = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr4;
                            MessageBox.Show(str4);
                            return;
                        }
                        else
                        {
                            // Preview is successful
                        }

                        RealPlayWnd4.Enabled = true;
                    }
                }
            }
        }

        public void camera4_off()
        {
            if (m_lUserID4 >= 0)
            {
                if (m_lRealHandle4 >= 0)
                {
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4))
                    {
                        iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                        str4 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr4;
                        MessageBox.Show(str4);
                        return;
                    }
                    m_lRealHandle4 = -1;

                    RealPlayWnd4.Enabled = false;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_Logout failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                m_lUserID4 = -1;
            }
            return;
        }

        public void camera5_on()
        {
            if (cameraIP5 == "" || cameraPort5 == "" ||
                cameraUsername5 == "" || cameraPassword5 == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID5 < 0)
            {
                string DVRIPAddress5 = cameraIP5;
                Int16 DVRPortNumber5 = Int16.Parse(cameraPort5);
                string DVRUserName5 = cameraUsername5;
                string DVRPassword5 = cameraPassword5;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo5 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID5 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress5, DVRPortNumber5, DVRUserName5, DVRPassword5, ref DeviceInfo5);
                if (m_lUserID5 < 0)
                {
                    iLastErr5 = CHCNetSDK.NET_DVR_GetLastError();
                    str5 = "NET_DVR_Login_V30 failed, error code= " + iLastErr5;
                    MessageBox.Show(str5);
                    return;
                }
                else
                {
                    // MessageBox.Show("Login Success!");


                    if (m_lRealHandle5 < 0)
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo5 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo5.hPlayWnd = RealPlayWnd5.Handle;
                        lpPreviewInfo5.lChannel = Int16.Parse(cameraChannel5);
                        lpPreviewInfo5.dwStreamType = 0;
                        lpPreviewInfo5.dwLinkMode = 0;
                        lpPreviewInfo5.bBlocked = true;
                        lpPreviewInfo5.dwDisplayBufNum = 1;
                        lpPreviewInfo5.byProtoType = 0;
                        lpPreviewInfo5.byPreviewMode = 0;


                        if (RealData5 == null)
                        {
                            RealData5 = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack5);
                        }

                        IntPtr pUser5 = new IntPtr();

                        m_lRealHandle5 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID5, ref lpPreviewInfo5, null/*RealData*/, pUser5);
                        if (m_lRealHandle5 < 0)
                        {
                            iLastErr5 = CHCNetSDK.NET_DVR_GetLastError();
                            str5 = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr5;
                            MessageBox.Show(str5);
                            return;
                        }
                        else
                        {
                            // Preview is successful
                        }

                        RealPlayWnd5.Enabled = true;
                    }
                }
            }
        }

        public void camera5_off()
        {
            if (m_lUserID5 >= 0)
            {
                if (m_lRealHandle5 >= 0)
                {
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle5))
                    {
                        iLastErr5 = CHCNetSDK.NET_DVR_GetLastError();
                        str5 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr5;
                        MessageBox.Show(str5);
                        return;
                    }
                    m_lRealHandle5 = -1;

                    RealPlayWnd5.Enabled = false;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID5))
                {
                    iLastErr5 = CHCNetSDK.NET_DVR_GetLastError();
                    str5 = "NET_DVR_Logout failed, error code= " + iLastErr5;
                    MessageBox.Show(str5);
                    return;
                }
                m_lUserID5 = -1;
            }
            return;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            //Serial Port
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.AddRange(ports);

            if (comboBoxCOMPort.Items.Count >= 1)
            {
                comboBoxCOMPort.SelectedIndex = 0;
            }

            config();

            if (cameraStatus1 == "ON") {
                camera1_on();
                //Thread newThread1 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera1_on(); }); }); newThread1.Start(); 
            } else {
                camera1_off();
                //Thread newThread1_2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera1_off(); }); }); newThread1_2.Start();
            }
            if (cameraStatus2 == "ON") {
                camera2_on();
                //Thread newThread2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera2_on(); }); }); newThread2.Start(); 
            } else {
                camera2_off(); 
                //Thread newThread2_2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera2_off(); }); }); newThread2_2.Start();
            }
            if (cameraStatus3 == "ON") {
                camera3_on();
                //Thread newThread3 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera3_on(); }); }); newThread3.Start(); 
            } else {
                camera3_off(); 
                //Thread newThread3_2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera3_off(); }); }); newThread3_2.Start();
            }
            if (cameraStatus4 == "ON") {
                camera4_on();
                //Thread newThread4 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera4_on(); }); }); newThread4.Start(); 
            } else {
                camera4_off(); 
                //Thread newThread4_2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera4_off(); }); }); newThread4_2.Start();
            }
            if (cameraStatus5 == "ON") {
                camera5_on();
                //Thread newThread5 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera5_on(); }); }); newThread5.Start(); 
            } else {
                camera5_off();
                //Thread newThread5_2 = new Thread(() => { this.BeginInvoke((System.Action)delegate () { camera5_off(); }); }); newThread5_2.Start();
            }
        }

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
		{
            if (dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "Real-time streaming data.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();            
            }
		}

        public void RealDataCallBack2(Int32 lRealHandle2, UInt32 dwDataType2, IntPtr pBuffer2, UInt32 dwBufSize2, IntPtr pUser2)
        {
            if (dwBufSize2 > 0)
            {
                byte[] sData2 = new byte[dwBufSize2];
                Marshal.Copy(pBuffer2, sData2, 0, (Int32)dwBufSize2);

                string str2 = "Real-time streaming data2.ps";
                FileStream fs2 = new FileStream(str2, FileMode.Create);
                int iLen2 = (int)dwBufSize2;
                fs2.Write(sData2, 0, iLen2);
                fs2.Close();
            }
        }

        public void RealDataCallBack3(Int32 lRealHandle3, UInt32 dwDataType3, IntPtr pBuffer3, UInt32 dwBufSize3, IntPtr pUser3)
        {
            if (dwBufSize3 > 0)
            {
                byte[] sData3 = new byte[dwBufSize3];
                Marshal.Copy(pBuffer3, sData3, 0, (Int32)dwBufSize3);

                string str3 = "Real-time streaming data3.ps";
                FileStream fs3 = new FileStream(str3, FileMode.Create);
                int iLen3 = (int)dwBufSize3;
                fs3.Write(sData3, 0, iLen3);
                fs3.Close();
            }
        }

        public void RealDataCallBack4(Int32 lRealHandle4, UInt32 dwDataType4, IntPtr pBuffer4, UInt32 dwBufSize4, IntPtr pUser4)
        {
            if (dwBufSize4 > 0)
            {
                byte[] sData4 = new byte[dwBufSize4];
                Marshal.Copy(pBuffer4, sData4, 0, (Int32)dwBufSize4);

                string str4 = "Real-time streaming data4.ps";
                FileStream fs4 = new FileStream(str4, FileMode.Create);
                int iLen4 = (int)dwBufSize4;
                fs4.Write(sData4, 0, iLen4);
                fs4.Close();
            }
        }

        public void RealDataCallBack5(Int32 lRealHandle5, UInt32 dwDataType5, IntPtr pBuffer5, UInt32 dwBufSize5, IntPtr pUser5)
        {
            if (dwBufSize5 > 0)
            {
                byte[] sData5 = new byte[dwBufSize5];
                Marshal.Copy(pBuffer5, sData5, 0, (Int32)dwBufSize5);

                string str5 = "Real-time streaming data5.ps";
                FileStream fs5 = new FileStream(str5, FileMode.Create);
                int iLen5 = (int)dwBufSize5;
                fs5.Write(sData5, 0, iLen5);
                fs5.Close();
            }
        }

        public void camera1_JPEG() 
        {
            string sJpegPicFileName;
            // The path and file name to save
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName = "Photos\\Cam1_" + i + ".jpg";

            int lChannel = Int16.Parse(cameraChannel1); // Channel number Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; // Image quality Image quality
            lpJpegPara.wPicSize = 0xff; // Picture resolution Picture size: 2- 4CIF, 0xff- Auto (using the current stream resolution), the resolution of the screenshot needs device support, please refer to the SDK documentation for more values

            // JPEG Screenshot Capture a JPEG picture
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        public void camera2_JPEG()
        {
            string sJpegPicFileName2;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName2 = "Photos\\Cam2_" + i + ".jpg";

            int lChannel2 = Int16.Parse(cameraChannel2);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara2 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara2.wPicQuality = 0;
            lpJpegPara2.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID2, lChannel2, ref lpJpegPara2, sJpegPicFileName2))
            {
                iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                str2 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr2;
                MessageBox.Show(str2);
                return;
            }
            else
            {
                str2 = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName2;
                MessageBox.Show(str2);
            }
            return;
        }

        public void camera3_JPEG()
        {
            string sJpegPicFileName3;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName3 = "Photos\\Cam3_" + i + ".jpg";

            int lChannel3 = Int16.Parse(cameraChannel3);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara3 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara3.wPicQuality = 0;
            lpJpegPara3.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID3, lChannel3, ref lpJpegPara3, sJpegPicFileName3))
            {
                iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                str3 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr3;
                MessageBox.Show(str3);
                return;
            }
            else
            {
                str3 = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName3;
                MessageBox.Show(str3);
            }
            return;
        }

        public void camera4_JPEG()
        {
            string sJpegPicFileName4;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName4 = "Photos\\Cam4_" + i + ".jpg";

            int lChannel4 = Int16.Parse(cameraChannel4);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara4 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara4.wPicQuality = 0;
            lpJpegPara4.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID4, lChannel4, ref lpJpegPara4, sJpegPicFileName4))
            {
                iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                str4 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr4;
                MessageBox.Show(str4);
                return;
            }
            else
            {
                str4 = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName4;
                MessageBox.Show(str4);
            }
            return;
        }

        public void camera5_JPEG()
        {
            string sJpegPicFileName5;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName5 = "Photos\\Cam5_" + i + ".jpg";

            int lChannel5 = Int16.Parse(cameraChannel5);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara5 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara5.wPicQuality = 0;
            lpJpegPara5.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID5, lChannel5, ref lpJpegPara5, sJpegPicFileName5))
            {
                iLastErr5 = CHCNetSDK.NET_DVR_GetLastError();
                str5 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr5;
                MessageBox.Show(str5);
                return;
            }
            else
            {
                str5 = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName5;
                MessageBox.Show(str5);
            }
            return;
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            if (cameraStatus1 == "ON") { camera1_JPEG(); }
            if (cameraStatus2 == "ON") { camera2_JPEG(); }
            if (cameraStatus3 == "ON") { camera3_JPEG(); }
            if (cameraStatus4 == "ON") { camera4_JPEG(); }
            if (cameraStatus5 == "ON") { camera5_JPEG(); }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnOpen.Text = "OPEN";
                progressBar1.Value = 0;
                textBoxDataIN.Text = "00000";
                lblDataInLength.Text = "00";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBoxCOMPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudRate);
                    serialPort1.DataBits = Convert.ToInt32(dataBits);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits);

                    serialPort1.Open();
                    btnOpen.Text = "CLOSE";
                    progressBar1.Value = 100;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string dataIN;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int dataINLength = dataIN.Length;
            lblDataInLength.Text = String.Format("{0:00}", dataINLength);
            textBoxDataIN.Text = dataIN;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            
            btnScan.Text = "Scanning";
            btnScan.Enabled = false;
            timer1.Start();
        }

        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Error Loading File.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string qrJpeg;
            qrJpeg = "Photos\\qr.jpg";

            int lChannel4 = Int16.Parse(cameraChannel4);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara4 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara4.wPicQuality = 0;
            lpJpegPara4.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID4, lChannel4, ref lpJpegPara4, qrJpeg))
            {
                iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                str4 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr4;
                MessageBox.Show(str4);
                // return;
            }
            else
            {

            }

            picBoxReader.Image = LoadBitmap(qrJpeg);
            if (picBoxReader.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)picBoxReader.Image);
                if (result != null)
                {
                    textBoxQRCode.Text = result.ToString();
                    btnScan.Text = "Scan";
                    btnScan.Enabled = false;
                    timer1.Stop();

                    timer3.Start();
                    timer4.Start();
                    timer5.Start();
                }
            }
        }

        private void textBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDataIN.Text.Length > 5) { textBoxDataIN.Text = textBoxDataIN.Text.Substring(0, 5); }
            if (Convert.ToInt32(textBoxDataIN.Text) == Convert.ToInt32(tareWeight))
            {
                if (textBoxDataIN.Text.Length > 5) { textBoxDataIN.Text = textBoxDataIN.Text.Substring(0, 5); }
                btnScan.PerformClick();
            }
            if (Convert.ToInt32(textBoxDataIN.Text) == 00000)
            {
                textBoxQRCode.Clear();
                textBoxCapturedTareWeight.Clear();

            }
        }

        string tareWeight_a;
        string tareWeight_b;
        string tareWeight_c;

        private void timer3_Tick(object sender, EventArgs e)
        {
            tareWeight_a = textBoxDataIN.Text;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            tareWeight_b = textBoxDataIN.Text;
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tareWeight_c = textBoxDataIN.Text;
            timer5.Stop();
            capture_weight();
        }

        private void capture_weight() 
        {
            if (tareWeight_a == tareWeight_b && tareWeight_b == tareWeight_c)
            {
                textBoxCapturedTareWeight.Text = tareWeight_a.ToString();
            }
            else 
            {
                timer3.Start();
                timer4.Start();
                timer5.Start();
            }
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                // Close Serial Port
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                // Stop Capture QR Scan
                /*if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }*/

                // Stop live view
                if (m_lRealHandle >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                    m_lRealHandle = -1;
                }

                // Logout the device
                if (m_lUserID >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID);
                    m_lUserID = -1;
                }

                if (m_lRealHandle2 >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle2);
                    m_lRealHandle2 = -1;
                }

                if (m_lUserID2 >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID2);
                    m_lUserID2 = -1;
                }

                if (m_lRealHandle3 >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3);
                    m_lRealHandle3 = -1;
                }

                if (m_lUserID3 >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID3);
                    m_lUserID3 = -1;
                }

                if (m_lRealHandle4 >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4);
                    m_lRealHandle4 = -1;
                }

                if (m_lUserID4 >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID4);
                    m_lUserID4 = -1;
                }

                if (m_lRealHandle5 >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle5);
                    m_lRealHandle5 = -1;
                }

                if (m_lUserID5 >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID5);
                    m_lUserID5 = -1;
                }

                CHCNetSDK.NET_DVR_Cleanup();
            }
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Close Serial Port
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            // Stop Capture QR Scan
            /*if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }*/

            // Stop live view
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                m_lRealHandle = -1;
            }

            // Logout the device
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
                m_lUserID = -1;
            }

            if (m_lRealHandle2 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle2);
                m_lRealHandle2 = -1;
            }

            if (m_lUserID2 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID2);
                m_lUserID2 = -1;
            }

            if (m_lRealHandle3 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3);
                m_lRealHandle3 = -1;
            }

            if (m_lUserID3 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID3);
                m_lUserID3 = -1;
            }

            if (m_lRealHandle4 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4);
                m_lRealHandle4 = -1;
            }

            if (m_lUserID4 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID4);
                m_lUserID4 = -1;
            }

            if (m_lRealHandle5 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle5);
                m_lRealHandle5 = -1;
            }

            if (m_lUserID5 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID5);
                m_lUserID5 = -1;
            }

            CHCNetSDK.NET_DVR_Cleanup();

            Application.Exit();
        }
    }
}
