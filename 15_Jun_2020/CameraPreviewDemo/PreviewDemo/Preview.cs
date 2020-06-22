using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
/*using System.Linq;*/
using System.Threading;
using System.IO.Ports;
using AForge.Video;
using AForge.Video.DirectShow;

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
        private bool m_bRecord = false;
        private bool m_bTalk = false;
		private Int32 m_lRealHandle = -1;
        private int lVoiceComHandle = -1;
        private string str;

        CHCNetSDK.REALDATACALLBACK RealData = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;


        private uint iLastErr1 = 0;
        private Int32 m_lUserID1 = -1;
        private bool m_bInitSDK1 = false;
        private bool m_bRecord1 = false;
        private bool m_bTalk1 = false;
        private Int32 m_lRealHandle1 = -1;
        private int lVoiceComHandle1 = -1;
        private string str1;

        CHCNetSDK.REALDATACALLBACK RealData1 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg1;


        private uint iLastErr2 = 0;
        private Int32 m_lUserID2 = -1;
        private bool m_bInitSDK2 = false;
        private bool m_bRecord2 = false;
        private bool m_bTalk2 = false;
        private Int32 m_lRealHandle2 = -1;
        private int lVoiceComHandle2 = -1;
        private string str2;

        CHCNetSDK.REALDATACALLBACK RealData2 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg2;


        private uint iLastErr3 = 0;
        private Int32 m_lUserID3 = -1;
        private bool m_bInitSDK3 = false;
        private bool m_bRecord3 = false;
        private bool m_bTalk3 = false;
        private Int32 m_lRealHandle3 = -1;
        private int lVoiceComHandle3 = -1;
        private string str3;

        CHCNetSDK.REALDATACALLBACK RealData3 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg3;


        private uint iLastErr4 = 0;
        private Int32 m_lUserID4 = -1;
        private bool m_bInitSDK4 = false;
        private bool m_bRecord4 = false;
        private bool m_bTalk4 = false;
        private Int32 m_lRealHandle4 = -1;
        private int lVoiceComHandle4 = -1;
        private string str4;

        CHCNetSDK.REALDATACALLBACK RealData4 = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg4;


        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.PictureBox RealPlayWnd;
        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button btnBMP;
        private Button btnJPEG;
        private Label label13;
        private TextBox textBoxChannel;
        private Button btnRecord;
        private Button btn_Exit;
        private Button btnVioceTalk;
        private Label label16;
        private Label label17;
        private TextBox textBoxID;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button PreSet;
        private Label label23;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLogin1;
        private TextBox textBoxPort1;
        private TextBox textBoxIP1;
        private TextBox textBoxID1;
        private TextBox textBoxUserName1;
        private Label label15;
        private Button btnRecord1;
        private TextBox textBoxPassword1;
        private Label label25;
        private Label label27;
        private Button btnJPEG1;
        private Label label28;
        private Button btnBMP1;
        private Label label29;
        private PictureBox RealPlayWnd1;
        private TextBox textBoxChannel1;
        private Label label30;
        private Button btnPreview1;
        private GroupBox groupBox3;
        private Button btnLogin2;
        private TextBox textBoxPort2;
        private TextBox textBoxIP2;
        private TextBox textBoxID2;
        private TextBox textBoxUserName2;
        private Label label32;
        private Button btnRecord2;
        private TextBox textBoxPassword2;
        private Label label35;
        private Label label37;
        private Button btnJPEG2;
        private Label label38;
        private Button btnBMP2;
        private Label label39;
        private PictureBox RealPlayWnd2;
        private TextBox textBoxChannel2;
        private Label label40;
        private Button btnPreview2;
        private GroupBox groupBox4;
        private Button btnLogin3;
        private TextBox textBoxPort3;
        private TextBox textBoxIP3;
        private TextBox textBoxID3;
        private TextBox textBoxUserName3;
        private Label label9;
        private Button btnRecord3;
        private TextBox textBoxPassword3;
        private Label label11;
        private Label label12;
        private Button btnJPEG3;
        private Label label14;
        private Button btnBMP3;
        private Label label18;
        private PictureBox RealPlayWnd3;
        private TextBox textBoxChannel3;
        private Label label24;
        private Button btnPreview3;
        private GroupBox groupBox5;
        private Button btnLogin4;
        private TextBox textBoxPort4;
        private TextBox textBoxIP4;
        private TextBox textBoxID4;
        private TextBox textBoxUserName4;
        private Label label26;
        private Button btnRecord4;
        private TextBox textBoxPassword4;
        private Label label31;
        private Label label33;
        private Button btnJPEG4;
        private Label label34;
        private Button btnBMP4;
        private Label label36;
        private PictureBox RealPlayWnd4;
        private TextBox textBoxChannel4;
        private Label label41;
        private Button btnPreview4;
        private GroupBox groupBox6;
        private Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private TextBox textBoxDataIN;
        private Label label43;
        private Label label44;
        private Label label45;
        private ComboBox comboBoxCOMPort;
        private ComboBox comboBoxBaudRate;
        private ComboBox comboBoxDataBits;
        private Label label46;
        private ComboBox comboBoxStopBits;
        private Label label47;
        private ComboBox comboBoxParityBits;
        private GroupBox groupBox7;
        private ProgressBar progressBar1;
        private Label lblDataInLength;
        private Label label48;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private ComboBox comboBoxCam;
        private TextBox textBoxQRCode;
        private Button btnScan;
        private PictureBox pictureBox;
        private GroupBox groupBox10;
        private System.Windows.Forms.Timer timer1;
        private Label label42;
        private IContainer components;

        public Preview()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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

            if (m_lRealHandle1 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle1);
            }
            if (m_lUserID1 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID1);
            }
            if (m_bInitSDK1 == true)
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBMP = new System.Windows.Forms.Button();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnVioceTalk = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.PreSet = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.textBoxPort1 = new System.Windows.Forms.TextBox();
            this.textBoxIP1 = new System.Windows.Forms.TextBox();
            this.textBoxID1 = new System.Windows.Forms.TextBox();
            this.textBoxUserName1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRecord1 = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnJPEG1 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnBMP1 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.RealPlayWnd1 = new System.Windows.Forms.PictureBox();
            this.textBoxChannel1 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnPreview1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.textBoxPort2 = new System.Windows.Forms.TextBox();
            this.textBoxIP2 = new System.Windows.Forms.TextBox();
            this.textBoxID2 = new System.Windows.Forms.TextBox();
            this.textBoxUserName2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnRecord2 = new System.Windows.Forms.Button();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.btnJPEG2 = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.btnBMP2 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.RealPlayWnd2 = new System.Windows.Forms.PictureBox();
            this.textBoxChannel2 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.btnPreview2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLogin3 = new System.Windows.Forms.Button();
            this.textBoxPort3 = new System.Windows.Forms.TextBox();
            this.textBoxIP3 = new System.Windows.Forms.TextBox();
            this.textBoxID3 = new System.Windows.Forms.TextBox();
            this.textBoxUserName3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRecord3 = new System.Windows.Forms.Button();
            this.textBoxPassword3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnJPEG3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBMP3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.RealPlayWnd3 = new System.Windows.Forms.PictureBox();
            this.textBoxChannel3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnPreview3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLogin4 = new System.Windows.Forms.Button();
            this.textBoxPort4 = new System.Windows.Forms.TextBox();
            this.textBoxIP4 = new System.Windows.Forms.TextBox();
            this.textBoxID4 = new System.Windows.Forms.TextBox();
            this.textBoxUserName4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnRecord4 = new System.Windows.Forms.Button();
            this.textBoxPassword4 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnJPEG4 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.btnBMP4 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.RealPlayWnd4 = new System.Windows.Forms.PictureBox();
            this.textBoxChannel4 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.btnPreview4 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxDataIN = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBoxCam = new System.Windows.Forms.ComboBox();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(315, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(404, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(483, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(572, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 37;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(318, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPreview.Location = new System.Drawing.Point(14, 303);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Live View";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.Location = new System.Drawing.Point(14, 58);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(400, 220);
            this.RealPlayWnd.TabIndex = 4;
            this.RealPlayWnd.TabStop = false;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(14, 35);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(70, 20);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "172.16.10.25";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(90, 35);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "8000";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(166, 35);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(70, 20);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(242, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(70, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "scube1024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Device IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Device Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(224, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 33;
            // 
            // btnBMP
            // 
            this.btnBMP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBMP.Location = new System.Drawing.Point(151, 303);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(81, 23);
            this.btnBMP.TabIndex = 8;
            this.btnBMP.Text = "Capture BMP ";
            this.btnBMP.UseVisualStyleBackColor = true;
            this.btnBMP.Click += new System.EventHandler(this.btnBMP_Click);
            // 
            // btnJPEG
            // 
            this.btnJPEG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG.Location = new System.Drawing.Point(238, 303);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(87, 23);
            this.btnJPEG.TabIndex = 9;
            this.btnJPEG.Text = "Capture JPEG";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "capture channel";
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.Location = new System.Drawing.Point(103, 281);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(21, 20);
            this.textBoxChannel.TabIndex = 6;
            this.textBoxChannel.Text = "1";
            // 
            // btnRecord
            // 
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord.Location = new System.Drawing.Point(331, 303);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(83, 23);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Start Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Exit.Location = new System.Drawing.Point(468, 356);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(430, 36);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Tag = "";
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnVioceTalk
            // 
            this.btnVioceTalk.Location = new System.Drawing.Point(763, 30);
            this.btnVioceTalk.Name = "btnVioceTalk";
            this.btnVioceTalk.Size = new System.Drawing.Size(62, 21);
            this.btnVioceTalk.TabIndex = 25;
            this.btnVioceTalk.Text = "Start Talk";
            this.btnVioceTalk.UseVisualStyleBackColor = true;
            this.btnVioceTalk.Visible = false;
            this.btnVioceTalk.Click += new System.EventHandler(this.btnVioceTalk_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(680, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "TwoWayAudio";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(333, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "stream ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(393, 281);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(21, 20);
            this.textBoxID.TabIndex = 28;
            // 
            // PreSet
            // 
            this.PreSet.Location = new System.Drawing.Point(898, 30);
            this.PreSet.Name = "PreSet";
            this.PreSet.Size = new System.Drawing.Size(81, 21);
            this.PreSet.TabIndex = 31;
            this.PreSet.Text = "PTZ Control";
            this.PreSet.UseVisualStyleBackColor = true;
            this.PreSet.Visible = false;
            this.PreSet.Click += new System.EventHandler(this.PreSet_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(829, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "PTZ control";
            this.label23.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnJPEG);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBMP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.RealPlayWnd);
            this.groupBox1.Controls.Add(this.textBoxChannel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Location = new System.Drawing.Point(30, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 335);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLogin1);
            this.groupBox2.Controls.Add(this.textBoxPort1);
            this.groupBox2.Controls.Add(this.textBoxIP1);
            this.groupBox2.Controls.Add(this.textBoxID1);
            this.groupBox2.Controls.Add(this.textBoxUserName1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnRecord1);
            this.groupBox2.Controls.Add(this.textBoxPassword1);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnJPEG1);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.btnBMP1);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.RealPlayWnd1);
            this.groupBox2.Controls.Add(this.textBoxChannel1);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.btnPreview1);
            this.groupBox2.Location = new System.Drawing.Point(906, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 335);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera 2";
            // 
            // btnLogin1
            // 
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin1.Location = new System.Drawing.Point(320, 19);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(96, 36);
            this.btnLogin1.TabIndex = 1;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // textBoxPort1
            // 
            this.textBoxPort1.Location = new System.Drawing.Point(92, 35);
            this.textBoxPort1.Name = "textBoxPort1";
            this.textBoxPort1.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort1.TabIndex = 3;
            this.textBoxPort1.Text = "8000";
            // 
            // textBoxIP1
            // 
            this.textBoxIP1.Location = new System.Drawing.Point(16, 35);
            this.textBoxIP1.Name = "textBoxIP1";
            this.textBoxIP1.Size = new System.Drawing.Size(70, 20);
            this.textBoxIP1.TabIndex = 2;
            this.textBoxIP1.Text = "172.16.10.23";
            // 
            // textBoxID1
            // 
            this.textBoxID1.Location = new System.Drawing.Point(395, 281);
            this.textBoxID1.Name = "textBoxID1";
            this.textBoxID1.Size = new System.Drawing.Size(21, 20);
            this.textBoxID1.TabIndex = 28;
            // 
            // textBoxUserName1
            // 
            this.textBoxUserName1.Location = new System.Drawing.Point(168, 35);
            this.textBoxUserName1.Name = "textBoxUserName1";
            this.textBoxUserName1.Size = new System.Drawing.Size(70, 20);
            this.textBoxUserName1.TabIndex = 4;
            this.textBoxUserName1.Text = "admin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(337, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "stream ID";
            // 
            // btnRecord1
            // 
            this.btnRecord1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord1.Location = new System.Drawing.Point(333, 303);
            this.btnRecord1.Name = "btnRecord1";
            this.btnRecord1.Size = new System.Drawing.Size(83, 23);
            this.btnRecord1.TabIndex = 10;
            this.btnRecord1.Text = "Start Record";
            this.btnRecord1.UseVisualStyleBackColor = true;
            this.btnRecord1.Click += new System.EventHandler(this.btnRecord1_Click);
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword1.Location = new System.Drawing.Point(244, 35);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(70, 20);
            this.textBoxPassword1.TabIndex = 5;
            this.textBoxPassword1.Text = "scube1024";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Device IP";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(89, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Device Port";
            // 
            // btnJPEG1
            // 
            this.btnJPEG1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG1.Location = new System.Drawing.Point(240, 303);
            this.btnJPEG1.Name = "btnJPEG1";
            this.btnJPEG1.Size = new System.Drawing.Size(87, 23);
            this.btnJPEG1.TabIndex = 9;
            this.btnJPEG1.Text = "Capture JPEG";
            this.btnJPEG1.UseVisualStyleBackColor = true;
            this.btnJPEG1.Click += new System.EventHandler(this.btnJPEG1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(165, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "User Name";
            // 
            // btnBMP1
            // 
            this.btnBMP1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBMP1.Location = new System.Drawing.Point(153, 303);
            this.btnBMP1.Name = "btnBMP1";
            this.btnBMP1.Size = new System.Drawing.Size(81, 23);
            this.btnBMP1.TabIndex = 8;
            this.btnBMP1.Text = "Capture BMP ";
            this.btnBMP1.UseVisualStyleBackColor = true;
            this.btnBMP1.Click += new System.EventHandler(this.btnBMP1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(241, 19);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "Password";
            // 
            // RealPlayWnd1
            // 
            this.RealPlayWnd1.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd1.Location = new System.Drawing.Point(16, 58);
            this.RealPlayWnd1.Name = "RealPlayWnd1";
            this.RealPlayWnd1.Size = new System.Drawing.Size(400, 220);
            this.RealPlayWnd1.TabIndex = 4;
            this.RealPlayWnd1.TabStop = false;
            // 
            // textBoxChannel1
            // 
            this.textBoxChannel1.Location = new System.Drawing.Point(103, 281);
            this.textBoxChannel1.Name = "textBoxChannel1";
            this.textBoxChannel1.Size = new System.Drawing.Size(21, 20);
            this.textBoxChannel1.TabIndex = 6;
            this.textBoxChannel1.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 284);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "capture channel";
            // 
            // btnPreview1
            // 
            this.btnPreview1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPreview1.Location = new System.Drawing.Point(16, 303);
            this.btnPreview1.Name = "btnPreview1";
            this.btnPreview1.Size = new System.Drawing.Size(109, 23);
            this.btnPreview1.TabIndex = 7;
            this.btnPreview1.Text = "Live View";
            this.btnPreview1.Click += new System.EventHandler(this.btnPreview1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLogin2);
            this.groupBox3.Controls.Add(this.textBoxPort2);
            this.groupBox3.Controls.Add(this.textBoxIP2);
            this.groupBox3.Controls.Add(this.textBoxID2);
            this.groupBox3.Controls.Add(this.textBoxUserName2);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.btnRecord2);
            this.groupBox3.Controls.Add(this.textBoxPassword2);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.btnJPEG2);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.btnBMP2);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.RealPlayWnd2);
            this.groupBox3.Controls.Add(this.textBoxChannel2);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.btnPreview2);
            this.groupBox3.Location = new System.Drawing.Point(30, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 335);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera 3";
            // 
            // btnLogin2
            // 
            this.btnLogin2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin2.Location = new System.Drawing.Point(318, 19);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(96, 36);
            this.btnLogin2.TabIndex = 1;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // textBoxPort2
            // 
            this.textBoxPort2.Location = new System.Drawing.Point(90, 35);
            this.textBoxPort2.Name = "textBoxPort2";
            this.textBoxPort2.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort2.TabIndex = 3;
            this.textBoxPort2.Text = "8000";
            // 
            // textBoxIP2
            // 
            this.textBoxIP2.Location = new System.Drawing.Point(14, 35);
            this.textBoxIP2.Name = "textBoxIP2";
            this.textBoxIP2.Size = new System.Drawing.Size(70, 20);
            this.textBoxIP2.TabIndex = 2;
            this.textBoxIP2.Text = "172.16.10.24";
            // 
            // textBoxID2
            // 
            this.textBoxID2.Location = new System.Drawing.Point(393, 281);
            this.textBoxID2.Name = "textBoxID2";
            this.textBoxID2.Size = new System.Drawing.Size(21, 20);
            this.textBoxID2.TabIndex = 28;
            // 
            // textBoxUserName2
            // 
            this.textBoxUserName2.Location = new System.Drawing.Point(166, 35);
            this.textBoxUserName2.Name = "textBoxUserName2";
            this.textBoxUserName2.Size = new System.Drawing.Size(70, 20);
            this.textBoxUserName2.TabIndex = 4;
            this.textBoxUserName2.Text = "admin";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(335, 284);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 27;
            this.label32.Text = "stream ID";
            // 
            // btnRecord2
            // 
            this.btnRecord2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord2.Location = new System.Drawing.Point(331, 303);
            this.btnRecord2.Name = "btnRecord2";
            this.btnRecord2.Size = new System.Drawing.Size(83, 23);
            this.btnRecord2.TabIndex = 10;
            this.btnRecord2.Text = "Start Record";
            this.btnRecord2.UseVisualStyleBackColor = true;
            this.btnRecord2.Click += new System.EventHandler(this.btnRecord2_Click);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword2.Location = new System.Drawing.Point(242, 35);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(70, 20);
            this.textBoxPassword2.TabIndex = 5;
            this.textBoxPassword2.Text = "scube1024";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 19);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(54, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Device IP";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(87, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(63, 13);
            this.label37.TabIndex = 10;
            this.label37.Text = "Device Port";
            // 
            // btnJPEG2
            // 
            this.btnJPEG2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG2.Location = new System.Drawing.Point(238, 303);
            this.btnJPEG2.Name = "btnJPEG2";
            this.btnJPEG2.Size = new System.Drawing.Size(87, 23);
            this.btnJPEG2.TabIndex = 9;
            this.btnJPEG2.Text = "Capture JPEG";
            this.btnJPEG2.UseVisualStyleBackColor = true;
            this.btnJPEG2.Click += new System.EventHandler(this.btnJPEG2_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(163, 19);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 13);
            this.label38.TabIndex = 11;
            this.label38.Text = "User Name";
            // 
            // btnBMP2
            // 
            this.btnBMP2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBMP2.Location = new System.Drawing.Point(151, 303);
            this.btnBMP2.Name = "btnBMP2";
            this.btnBMP2.Size = new System.Drawing.Size(81, 23);
            this.btnBMP2.TabIndex = 8;
            this.btnBMP2.Text = "Capture BMP ";
            this.btnBMP2.UseVisualStyleBackColor = true;
            this.btnBMP2.Click += new System.EventHandler(this.btnBMP2_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(239, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 13);
            this.label39.TabIndex = 12;
            this.label39.Text = "Password";
            // 
            // RealPlayWnd2
            // 
            this.RealPlayWnd2.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd2.Location = new System.Drawing.Point(14, 58);
            this.RealPlayWnd2.Name = "RealPlayWnd2";
            this.RealPlayWnd2.Size = new System.Drawing.Size(400, 220);
            this.RealPlayWnd2.TabIndex = 4;
            this.RealPlayWnd2.TabStop = false;
            // 
            // textBoxChannel2
            // 
            this.textBoxChannel2.Location = new System.Drawing.Point(103, 281);
            this.textBoxChannel2.Name = "textBoxChannel2";
            this.textBoxChannel2.Size = new System.Drawing.Size(21, 20);
            this.textBoxChannel2.TabIndex = 6;
            this.textBoxChannel2.Text = "1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(13, 284);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 13);
            this.label40.TabIndex = 19;
            this.label40.Text = "capture channel";
            // 
            // btnPreview2
            // 
            this.btnPreview2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPreview2.Location = new System.Drawing.Point(14, 303);
            this.btnPreview2.Name = "btnPreview2";
            this.btnPreview2.Size = new System.Drawing.Size(110, 23);
            this.btnPreview2.TabIndex = 7;
            this.btnPreview2.Text = "Live View";
            this.btnPreview2.Click += new System.EventHandler(this.btnPreview2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnLogin3);
            this.groupBox4.Controls.Add(this.textBoxPort3);
            this.groupBox4.Controls.Add(this.textBoxIP3);
            this.groupBox4.Controls.Add(this.textBoxID3);
            this.groupBox4.Controls.Add(this.textBoxUserName3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnRecord3);
            this.groupBox4.Controls.Add(this.textBoxPassword3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnJPEG3);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnBMP3);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.RealPlayWnd3);
            this.groupBox4.Controls.Add(this.textBoxChannel3);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.btnPreview3);
            this.groupBox4.Location = new System.Drawing.Point(468, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 335);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera 4";
            // 
            // btnLogin3
            // 
            this.btnLogin3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin3.Location = new System.Drawing.Point(318, 19);
            this.btnLogin3.Name = "btnLogin3";
            this.btnLogin3.Size = new System.Drawing.Size(96, 36);
            this.btnLogin3.TabIndex = 1;
            this.btnLogin3.Text = "Login";
            this.btnLogin3.Click += new System.EventHandler(this.btnLogin3_Click);
            // 
            // textBoxPort3
            // 
            this.textBoxPort3.Location = new System.Drawing.Point(90, 35);
            this.textBoxPort3.Name = "textBoxPort3";
            this.textBoxPort3.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort3.TabIndex = 3;
            this.textBoxPort3.Text = "8000";
            // 
            // textBoxIP3
            // 
            this.textBoxIP3.Location = new System.Drawing.Point(14, 35);
            this.textBoxIP3.Name = "textBoxIP3";
            this.textBoxIP3.Size = new System.Drawing.Size(70, 20);
            this.textBoxIP3.TabIndex = 2;
            this.textBoxIP3.Text = "172.16.10.24";
            // 
            // textBoxID3
            // 
            this.textBoxID3.Location = new System.Drawing.Point(393, 281);
            this.textBoxID3.Name = "textBoxID3";
            this.textBoxID3.Size = new System.Drawing.Size(21, 20);
            this.textBoxID3.TabIndex = 28;
            // 
            // textBoxUserName3
            // 
            this.textBoxUserName3.Location = new System.Drawing.Point(166, 35);
            this.textBoxUserName3.Name = "textBoxUserName3";
            this.textBoxUserName3.Size = new System.Drawing.Size(70, 20);
            this.textBoxUserName3.TabIndex = 4;
            this.textBoxUserName3.Text = "admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "stream ID";
            // 
            // btnRecord3
            // 
            this.btnRecord3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord3.Location = new System.Drawing.Point(331, 303);
            this.btnRecord3.Name = "btnRecord3";
            this.btnRecord3.Size = new System.Drawing.Size(83, 23);
            this.btnRecord3.TabIndex = 10;
            this.btnRecord3.Text = "Start Record";
            this.btnRecord3.UseVisualStyleBackColor = true;
            this.btnRecord3.Click += new System.EventHandler(this.btnRecord3_Click);
            // 
            // textBoxPassword3
            // 
            this.textBoxPassword3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword3.Location = new System.Drawing.Point(242, 35);
            this.textBoxPassword3.Name = "textBoxPassword3";
            this.textBoxPassword3.PasswordChar = '*';
            this.textBoxPassword3.Size = new System.Drawing.Size(70, 20);
            this.textBoxPassword3.TabIndex = 5;
            this.textBoxPassword3.Text = "scube1024";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Device IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Device Port";
            // 
            // btnJPEG3
            // 
            this.btnJPEG3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG3.Location = new System.Drawing.Point(238, 303);
            this.btnJPEG3.Name = "btnJPEG3";
            this.btnJPEG3.Size = new System.Drawing.Size(87, 23);
            this.btnJPEG3.TabIndex = 9;
            this.btnJPEG3.Text = "Capture JPEG";
            this.btnJPEG3.UseVisualStyleBackColor = true;
            this.btnJPEG3.Click += new System.EventHandler(this.btnJPEG3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(163, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "User Name";
            // 
            // btnBMP3
            // 
            this.btnBMP3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBMP3.Location = new System.Drawing.Point(151, 303);
            this.btnBMP3.Name = "btnBMP3";
            this.btnBMP3.Size = new System.Drawing.Size(81, 23);
            this.btnBMP3.TabIndex = 8;
            this.btnBMP3.Text = "Capture BMP ";
            this.btnBMP3.UseVisualStyleBackColor = true;
            this.btnBMP3.Click += new System.EventHandler(this.btnBMP3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Password";
            // 
            // RealPlayWnd3
            // 
            this.RealPlayWnd3.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd3.Location = new System.Drawing.Point(14, 58);
            this.RealPlayWnd3.Name = "RealPlayWnd3";
            this.RealPlayWnd3.Size = new System.Drawing.Size(400, 220);
            this.RealPlayWnd3.TabIndex = 4;
            this.RealPlayWnd3.TabStop = false;
            // 
            // textBoxChannel3
            // 
            this.textBoxChannel3.Location = new System.Drawing.Point(103, 281);
            this.textBoxChannel3.Name = "textBoxChannel3";
            this.textBoxChannel3.Size = new System.Drawing.Size(21, 20);
            this.textBoxChannel3.TabIndex = 6;
            this.textBoxChannel3.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 284);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "capture channel";
            // 
            // btnPreview3
            // 
            this.btnPreview3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPreview3.Location = new System.Drawing.Point(14, 303);
            this.btnPreview3.Name = "btnPreview3";
            this.btnPreview3.Size = new System.Drawing.Size(110, 23);
            this.btnPreview3.TabIndex = 7;
            this.btnPreview3.Text = "Live View";
            this.btnPreview3.Click += new System.EventHandler(this.btnPreview3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnLogin4);
            this.groupBox5.Controls.Add(this.textBoxPort4);
            this.groupBox5.Controls.Add(this.textBoxIP4);
            this.groupBox5.Controls.Add(this.textBoxID4);
            this.groupBox5.Controls.Add(this.textBoxUserName4);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.btnRecord4);
            this.groupBox5.Controls.Add(this.textBoxPassword4);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.btnJPEG4);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.btnBMP4);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.RealPlayWnd4);
            this.groupBox5.Controls.Add(this.textBoxChannel4);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.btnPreview4);
            this.groupBox5.Location = new System.Drawing.Point(906, 395);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 335);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Camera 5";
            // 
            // btnLogin4
            // 
            this.btnLogin4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin4.Location = new System.Drawing.Point(319, 19);
            this.btnLogin4.Name = "btnLogin4";
            this.btnLogin4.Size = new System.Drawing.Size(96, 36);
            this.btnLogin4.TabIndex = 1;
            this.btnLogin4.Text = "Login";
            this.btnLogin4.Click += new System.EventHandler(this.btnLogin4_Click);
            // 
            // textBoxPort4
            // 
            this.textBoxPort4.Location = new System.Drawing.Point(91, 35);
            this.textBoxPort4.Name = "textBoxPort4";
            this.textBoxPort4.Size = new System.Drawing.Size(70, 20);
            this.textBoxPort4.TabIndex = 3;
            this.textBoxPort4.Text = "8000";
            // 
            // textBoxIP4
            // 
            this.textBoxIP4.Location = new System.Drawing.Point(15, 35);
            this.textBoxIP4.Name = "textBoxIP4";
            this.textBoxIP4.Size = new System.Drawing.Size(70, 20);
            this.textBoxIP4.TabIndex = 2;
            this.textBoxIP4.Text = "172.16.10.24";
            // 
            // textBoxID4
            // 
            this.textBoxID4.Location = new System.Drawing.Point(394, 281);
            this.textBoxID4.Name = "textBoxID4";
            this.textBoxID4.Size = new System.Drawing.Size(21, 20);
            this.textBoxID4.TabIndex = 28;
            // 
            // textBoxUserName4
            // 
            this.textBoxUserName4.Location = new System.Drawing.Point(167, 35);
            this.textBoxUserName4.Name = "textBoxUserName4";
            this.textBoxUserName4.Size = new System.Drawing.Size(70, 20);
            this.textBoxUserName4.TabIndex = 4;
            this.textBoxUserName4.Text = "admin";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(336, 284);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "stream ID";
            // 
            // btnRecord4
            // 
            this.btnRecord4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord4.Location = new System.Drawing.Point(332, 303);
            this.btnRecord4.Name = "btnRecord4";
            this.btnRecord4.Size = new System.Drawing.Size(83, 23);
            this.btnRecord4.TabIndex = 10;
            this.btnRecord4.Text = "Start Record";
            this.btnRecord4.UseVisualStyleBackColor = true;
            this.btnRecord4.Click += new System.EventHandler(this.btnRecord4_Click);
            // 
            // textBoxPassword4
            // 
            this.textBoxPassword4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword4.Location = new System.Drawing.Point(243, 35);
            this.textBoxPassword4.Name = "textBoxPassword4";
            this.textBoxPassword4.PasswordChar = '*';
            this.textBoxPassword4.Size = new System.Drawing.Size(70, 20);
            this.textBoxPassword4.TabIndex = 5;
            this.textBoxPassword4.Text = "scube1024";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 19);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Device IP";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(88, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "Device Port";
            // 
            // btnJPEG4
            // 
            this.btnJPEG4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJPEG4.Location = new System.Drawing.Point(239, 303);
            this.btnJPEG4.Name = "btnJPEG4";
            this.btnJPEG4.Size = new System.Drawing.Size(87, 23);
            this.btnJPEG4.TabIndex = 9;
            this.btnJPEG4.Text = "Capture JPEG";
            this.btnJPEG4.UseVisualStyleBackColor = true;
            this.btnJPEG4.Click += new System.EventHandler(this.btnJPEG4_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(164, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(60, 13);
            this.label34.TabIndex = 11;
            this.label34.Text = "User Name";
            // 
            // btnBMP4
            // 
            this.btnBMP4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBMP4.Location = new System.Drawing.Point(152, 303);
            this.btnBMP4.Name = "btnBMP4";
            this.btnBMP4.Size = new System.Drawing.Size(81, 23);
            this.btnBMP4.TabIndex = 8;
            this.btnBMP4.Text = "Capture BMP ";
            this.btnBMP4.UseVisualStyleBackColor = true;
            this.btnBMP4.Click += new System.EventHandler(this.btnBMP4_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(240, 19);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 13);
            this.label36.TabIndex = 12;
            this.label36.Text = "Password";
            // 
            // RealPlayWnd4
            // 
            this.RealPlayWnd4.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd4.Location = new System.Drawing.Point(15, 58);
            this.RealPlayWnd4.Name = "RealPlayWnd4";
            this.RealPlayWnd4.Size = new System.Drawing.Size(400, 220);
            this.RealPlayWnd4.TabIndex = 4;
            this.RealPlayWnd4.TabStop = false;
            // 
            // textBoxChannel4
            // 
            this.textBoxChannel4.Location = new System.Drawing.Point(104, 281);
            this.textBoxChannel4.Name = "textBoxChannel4";
            this.textBoxChannel4.Size = new System.Drawing.Size(21, 20);
            this.textBoxChannel4.TabIndex = 6;
            this.textBoxChannel4.Text = "1";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(14, 284);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(84, 13);
            this.label41.TabIndex = 19;
            this.label41.Text = "capture channel";
            // 
            // btnPreview4
            // 
            this.btnPreview4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPreview4.Location = new System.Drawing.Point(15, 303);
            this.btnPreview4.Name = "btnPreview4";
            this.btnPreview4.Size = new System.Drawing.Size(110, 23);
            this.btnPreview4.TabIndex = 7;
            this.btnPreview4.Text = "Live View";
            this.btnPreview4.Click += new System.EventHandler(this.btnPreview4_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxDataIN);
            this.groupBox6.Location = new System.Drawing.Point(468, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 111);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Weighment Screen";
            // 
            // textBoxDataIN
            // 
            this.textBoxDataIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDataIN.Enabled = false;
            this.textBoxDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataIN.Location = new System.Drawing.Point(10, 18);
            this.textBoxDataIN.MaxLength = 5;
            this.textBoxDataIN.Name = "textBoxDataIN";
            this.textBoxDataIN.ReadOnly = true;
            this.textBoxDataIN.Size = new System.Drawing.Size(410, 83);
            this.textBoxDataIN.TabIndex = 1;
            this.textBoxDataIN.Text = "00000";
            this.textBoxDataIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.Location = new System.Drawing.Point(5, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 20);
            this.btnOpen.TabIndex = 54;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(251, 16);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 13);
            this.label43.TabIndex = 44;
            this.label43.Text = "COM Port";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 16);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 13);
            this.label44.TabIndex = 45;
            this.label44.Text = "Baud Rate";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(68, 16);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(50, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Data Bits";
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(254, 32);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(58, 21);
            this.comboBoxCOMPort.TabIndex = 47;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(10, 32);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(55, 21);
            this.comboBoxBaudRate.TabIndex = 48;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(71, 32);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(55, 21);
            this.comboBoxDataBits.TabIndex = 49;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(190, 16);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(49, 13);
            this.label46.TabIndex = 50;
            this.label46.Text = "Stop Bits";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(193, 32);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(55, 21);
            this.comboBoxStopBits.TabIndex = 51;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(129, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 13);
            this.label47.TabIndex = 52;
            this.label47.Text = "Parity Bits";
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParityBits.Location = new System.Drawing.Point(132, 32);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(55, 21);
            this.comboBoxParityBits.TabIndex = 53;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label47);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.comboBoxCOMPort);
            this.groupBox7.Controls.Add(this.comboBoxParityBits);
            this.groupBox7.Controls.Add(this.comboBoxBaudRate);
            this.groupBox7.Controls.Add(this.comboBoxDataBits);
            this.groupBox7.Controls.Add(this.comboBoxStopBits);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Location = new System.Drawing.Point(468, 170);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(320, 64);
            this.groupBox7.TabIndex = 60;
            this.groupBox7.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(78, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(21, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 55;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(78, 10);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(21, 13);
            this.lblDataInLength.TabIndex = 59;
            this.lblDataInLength.Text = "00";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 10);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(75, 13);
            this.label48.TabIndex = 58;
            this.label48.Text = "Data Length : ";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.lblDataInLength);
            this.groupBox8.Controls.Add(this.label48);
            this.groupBox8.Location = new System.Drawing.Point(794, 170);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(104, 29);
            this.groupBox8.TabIndex = 61;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.progressBar1);
            this.groupBox9.Controls.Add(this.btnOpen);
            this.groupBox9.Location = new System.Drawing.Point(794, 198);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(104, 36);
            this.groupBox9.TabIndex = 62;
            this.groupBox9.TabStop = false;
            // 
            // comboBoxCam
            // 
            this.comboBoxCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCam.FormattingEnabled = true;
            this.comboBoxCam.Location = new System.Drawing.Point(173, 16);
            this.comboBoxCam.Name = "comboBoxCam";
            this.comboBoxCam.Size = new System.Drawing.Size(153, 21);
            this.comboBoxCam.TabIndex = 63;
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQRCode.Location = new System.Drawing.Point(127, 43);
            this.textBoxQRCode.Multiline = true;
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.ReadOnly = true;
            this.textBoxQRCode.Size = new System.Drawing.Size(293, 65);
            this.textBoxQRCode.TabIndex = 65;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(332, 14);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(88, 23);
            this.btnScan.TabIndex = 66;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(10, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(108, 89);
            this.pictureBox.TabIndex = 67;
            this.pictureBox.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxQRCode);
            this.groupBox10.Controls.Add(this.comboBoxCam);
            this.groupBox10.Controls.Add(this.label42);
            this.groupBox10.Controls.Add(this.btnScan);
            this.groupBox10.Controls.Add(this.pictureBox);
            this.groupBox10.Location = new System.Drawing.Point(468, 236);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(430, 118);
            this.groupBox10.TabIndex = 68;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "QR Scanner";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(124, 19);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 13);
            this.label42.TabIndex = 64;
            this.label42.Text = "Camera";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Preview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PreSet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnVioceTalk);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Movable = false;
            this.Name = "Preview";
            this.Resizable = false;
            this.Text = "Empezar Logistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preview_FormClosing);
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Preview_Load(object sender, EventArgs e)
        {
            //Serial Port
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.AddRange(ports);

            comboBoxBaudRate.SelectedIndex = 2;
            comboBoxDataBits.SelectedIndex = 2;
            comboBoxParityBits.SelectedIndex = 0;
            comboBoxStopBits.SelectedIndex = 1;
            comboBoxCOMPort.SelectedIndex = 0;

            // QR Scanner
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                comboBoxCam.Items.Add(filterInfo.Name);
            }

            if (comboBoxCam.Items.Count >= 1)
            {
                comboBoxCam.SelectedIndex = 0;
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (textBoxIP.Text == "" || textBoxPort.Text == "" ||
				textBoxUserName.Text == "" || textBoxPassword.Text == "")
			{
				MessageBox.Show("Please input IP, Port, User name and Password!");
				return;
			}

            if (m_lUserID < 0)
            {
                string DVRIPAddress = textBoxIP.Text; // Device IP address or domain name
                Int16 DVRPortNumber = Int16.Parse(textBoxPort.Text); // Device service port number
                string DVRUserName = textBoxUserName.Text; // Device login user name
                string DVRPassword = textBoxPassword.Text; // device login password

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
                    btnLogin.Text = "Logout";
                }

            }
            else
            {
                // Logout the device
                if (m_lRealHandle >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;           
                }
                m_lUserID = -1;
                btnLogin.Text = "Login";
            }
            return;
		}

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (textBoxIP1.Text == "" || textBoxPort1.Text == "" ||
                textBoxUserName1.Text == "" || textBoxPassword1.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID1 < 0)
            {
                string DVRIPAddress1 = textBoxIP1.Text;
                Int16 DVRPortNumber1 = Int16.Parse(textBoxPort1.Text);
                string DVRUserName1 = textBoxUserName1.Text;
                string DVRPassword1 = textBoxPassword1.Text;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo1 = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID1 = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress1, DVRPortNumber1, DVRUserName1, DVRPassword1, ref DeviceInfo1);
                if (m_lUserID1 < 0)
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_Login_V30 failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                else
                {
                    // MessageBox.Show("Login Success!");
                    btnLogin1.Text = "Logout";
                }

            }
            else
            {
                if (m_lRealHandle1 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID1))
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_Logout failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                m_lUserID1 = -1;
                btnLogin1.Text = "Login";
            }
            return;
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            if (textBoxIP2.Text == "" || textBoxPort2.Text == "" ||
                textBoxUserName2.Text == "" || textBoxPassword2.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID2 < 0)
            {
                string DVRIPAddress2 = textBoxIP2.Text;
                Int16 DVRPortNumber2 = Int16.Parse(textBoxPort2.Text);
                string DVRUserName2 = textBoxUserName2.Text;
                string DVRPassword2 = textBoxPassword2.Text;

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
                    btnLogin2.Text = "Logout";
                }

            }
            else
            {
                if (m_lRealHandle2 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID2))
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_Logout failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                m_lUserID2 = -1;
                btnLogin2.Text = "Login";
            }
            return;
        }

        private void btnLogin3_Click(object sender, EventArgs e)
        {
            if (textBoxIP3.Text == "" || textBoxPort3.Text == "" ||
                textBoxUserName3.Text == "" || textBoxPassword3.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID3 < 0)
            {
                string DVRIPAddress3 = textBoxIP3.Text;
                Int16 DVRPortNumber3 = Int16.Parse(textBoxPort3.Text);
                string DVRUserName3 = textBoxUserName3.Text;
                string DVRPassword3 = textBoxPassword3.Text;

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
                    btnLogin3.Text = "Logout";
                }

            }
            else
            {
                if (m_lRealHandle3 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_Logout failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                m_lUserID3 = -1;
                btnLogin3.Text = "Login";
            }
            return;
        }

        private void btnLogin4_Click(object sender, EventArgs e)
        {
            if (textBoxIP4.Text == "" || textBoxPort4.Text == "" ||
                textBoxUserName4.Text == "" || textBoxPassword4.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }

            if (m_lUserID4 < 0)
            {
                string DVRIPAddress4 = textBoxIP4.Text;
                Int16 DVRPortNumber4 = Int16.Parse(textBoxPort4.Text);
                string DVRUserName4 = textBoxUserName4.Text;
                string DVRPassword4 = textBoxPassword4.Text;

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
                    btnLogin4.Text = "Logout";
                }

            }
            else
            {
                if (m_lRealHandle4 >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_Logout failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                m_lUserID4 = -1;
                btnLogin4.Text = "Login";
            }
            return;
        }

        private void btnPreview_Click(object sender, System.EventArgs e)
		{
            if(m_lUserID < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle; // Preview window
                lpPreviewInfo.lChannel = Int16.Parse(textBoxChannel.Text); // Preview device channel
                lpPreviewInfo.dwStreamType = 0; // stream type: 0-main stream, 1-substream, 2-stream 3, 3-stream 4, and so on
                lpPreviewInfo.dwLinkMode = 0; // Connection mode: 0- TCP mode, 1- UDP mode, 2- multicast mode, 3- RTP mode, 4-RTP/RTSP, 5-RSTP/HTTP
                lpPreviewInfo.bBlocked = true; // 0- non-blocking fetching, 1- blocking fetching
                lpPreviewInfo.dwDisplayBufNum = 1; // Maximum number of buffered frames in the playback buffer of the playback library
                lpPreviewInfo.byProtoType = 0;
                lpPreviewInfo.byPreviewMode = 0;


                if (textBoxID.Text != "")
                {
                    lpPreviewInfo.lChannel = -1;
                    byte[] byStreamID = System.Text.Encoding.Default.GetBytes(textBoxID.Text);
                    lpPreviewInfo.byStreamID = new byte[32];
                    byStreamID.CopyTo(lpPreviewInfo.byStreamID, 0);
                }


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
                    btnPreview.Text = "Stop Live View";
                }

                RealPlayWnd.Enabled = true;
            }
            else
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
                btnPreview.Text = "Live View";

                RealPlayWnd.Enabled = false;
            }
            return;
		}

        private void btnPreview1_Click(object sender, EventArgs e)
        {
            if (m_lUserID1 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle1 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo1 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo1.hPlayWnd = RealPlayWnd1.Handle;
                lpPreviewInfo1.lChannel = Int16.Parse(textBoxChannel1.Text);
                lpPreviewInfo1.dwStreamType = 0;
                lpPreviewInfo1.dwLinkMode = 0;
                lpPreviewInfo1.bBlocked = true;
                lpPreviewInfo1.dwDisplayBufNum = 1;
                lpPreviewInfo1.byProtoType = 0;
                lpPreviewInfo1.byPreviewMode = 0;


                if (textBoxID1.Text != "")
                {
                    lpPreviewInfo1.lChannel = -1;
                    byte[] byStreamID1 = System.Text.Encoding.Default.GetBytes(textBoxID1.Text);
                    lpPreviewInfo1.byStreamID = new byte[32];
                    byStreamID1.CopyTo(lpPreviewInfo1.byStreamID, 0);
                }


                if (RealData1 == null)
                {
                    RealData1 = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack1);
                }

                IntPtr pUser1 = new IntPtr();

                m_lRealHandle1 = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID1, ref lpPreviewInfo1, null/*RealData*/, pUser1);
                if (m_lRealHandle1 < 0)
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                else
                {
                    btnPreview1.Text = "Stop Live View";
                }

                RealPlayWnd1.Enabled = true;
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle1))
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                m_lRealHandle1 = -1;
                btnPreview1.Text = "Live View";

                RealPlayWnd1.Enabled = false;
            }
            return;
        }

        private void btnPreview2_Click(object sender, EventArgs e)
        {
            if (m_lUserID2 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle2 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo2 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo2.hPlayWnd = RealPlayWnd2.Handle;
                lpPreviewInfo2.lChannel = Int16.Parse(textBoxChannel2.Text);
                lpPreviewInfo2.dwStreamType = 0;
                lpPreviewInfo2.dwLinkMode = 0;
                lpPreviewInfo2.bBlocked = true;
                lpPreviewInfo2.dwDisplayBufNum = 1;
                lpPreviewInfo2.byProtoType = 0;
                lpPreviewInfo2.byPreviewMode = 0;


                if (textBoxID2.Text != "")
                {
                    lpPreviewInfo2.lChannel = -1;
                    byte[] byStreamID2 = System.Text.Encoding.Default.GetBytes(textBoxID2.Text);
                    lpPreviewInfo2.byStreamID = new byte[32];
                    byStreamID2.CopyTo(lpPreviewInfo2.byStreamID, 0);
                }


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
                    btnPreview2.Text = "Stop Live View";
                }

                RealPlayWnd2.Enabled = true;
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle2))
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                m_lRealHandle2 = -1;
                btnPreview2.Text = "Live View";

                RealPlayWnd2.Enabled = false;
            }
            return;
        }

        private void btnPreview3_Click(object sender, EventArgs e)
        {
            if (m_lUserID3 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle3 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo3 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo3.hPlayWnd = RealPlayWnd3.Handle;
                lpPreviewInfo3.lChannel = Int16.Parse(textBoxChannel3.Text);
                lpPreviewInfo3.dwStreamType = 0;
                lpPreviewInfo3.dwLinkMode = 0;
                lpPreviewInfo3.bBlocked = true;
                lpPreviewInfo3.dwDisplayBufNum = 1;
                lpPreviewInfo3.byProtoType = 0;
                lpPreviewInfo3.byPreviewMode = 0;


                if (textBoxID3.Text != "")
                {
                    lpPreviewInfo3.lChannel = -1;
                    byte[] byStreamID3 = System.Text.Encoding.Default.GetBytes(textBoxID3.Text);
                    lpPreviewInfo3.byStreamID = new byte[32];
                    byStreamID3.CopyTo(lpPreviewInfo3.byStreamID, 0);
                }


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
                    btnPreview3.Text = "Stop Live View";
                }

                RealPlayWnd3.Enabled = true;
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                m_lRealHandle3 = -1;
                btnPreview3.Text = "Live View";

                RealPlayWnd3.Enabled = false;
            }
            return;
        }

        private void btnPreview4_Click(object sender, EventArgs e)
        {
            if (m_lUserID4 < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle4 < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo4 = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo4.hPlayWnd = RealPlayWnd4.Handle;
                lpPreviewInfo4.lChannel = Int16.Parse(textBoxChannel4.Text);
                lpPreviewInfo4.dwStreamType = 0;
                lpPreviewInfo4.dwLinkMode = 0;
                lpPreviewInfo4.bBlocked = true;
                lpPreviewInfo4.dwDisplayBufNum = 1;
                lpPreviewInfo4.byProtoType = 0;
                lpPreviewInfo4.byPreviewMode = 0;


                if (textBoxID4.Text != "")
                {
                    lpPreviewInfo4.lChannel = -1;
                    byte[] byStreamID4 = System.Text.Encoding.Default.GetBytes(textBoxID4.Text);
                    lpPreviewInfo4.byStreamID = new byte[32];
                    byStreamID4.CopyTo(lpPreviewInfo4.byStreamID, 0);
                }


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
                    btnPreview4.Text = "Stop Live View";
                }

                RealPlayWnd4.Enabled = true;
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_StopRealPlay failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                m_lRealHandle4 = -1;
                btnPreview4.Text = "Live View";

                RealPlayWnd4.Enabled = false;
            }
            return;
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

        public void RealDataCallBack1(Int32 lRealHandle1, UInt32 dwDataType1, IntPtr pBuffer1, UInt32 dwBufSize1, IntPtr pUser1)
        {
            if (dwBufSize1 > 0)
            {
                byte[] sData1 = new byte[dwBufSize1];
                Marshal.Copy(pBuffer1, sData1, 0, (Int32)dwBufSize1);

                string str1 = "Real-time streaming data.ps";
                FileStream fs1 = new FileStream(str1, FileMode.Create);
                int iLen1 = (int)dwBufSize1;
                fs1.Write(sData1, 0, iLen1);
                fs1.Close();
            }
        }

        public void RealDataCallBack2(Int32 lRealHandle2, UInt32 dwDataType2, IntPtr pBuffer2, UInt32 dwBufSize2, IntPtr pUser2)
        {
            if (dwBufSize2 > 0)
            {
                byte[] sData2 = new byte[dwBufSize2];
                Marshal.Copy(pBuffer2, sData2, 0, (Int32)dwBufSize2);

                string str2 = "Real-time streaming data.ps";
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

                string str3 = "Real-time streaming data.ps";
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

                string str4 = "Real-time streaming data.ps";
                FileStream fs4 = new FileStream(str4, FileMode.Create);
                int iLen4 = (int)dwBufSize4;
                fs4.Write(sData4, 0, iLen4);
                fs4.Close();
            }
        }

        private void btnBMP_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName;
            // The path and file name to save
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sBmpPicFileName = "Photos\\BMP_test_" + i + ".bmp";

            // BMP Screenshot Capture a BMP picture
            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle, sBmpPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CapturePicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btnBMP1_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName1;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sBmpPicFileName1 = "Photos\\BMP_test1_" + i + ".bmp";

            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle1, sBmpPicFileName1))
            {
                iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                str1 = "NET_DVR_CapturePicture failed, error code= " + iLastErr1;
                MessageBox.Show(str1);
                return;
            }
            else
            {
                str1 = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName1;
                MessageBox.Show(str1);
            }
            return;
        }

        private void btnBMP2_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName2;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sBmpPicFileName2 = "Photos\\BMP_test2_" + i + ".bmp";

            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle2, sBmpPicFileName2))
            {
                iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                str2 = "NET_DVR_CapturePicture failed, error code= " + iLastErr2;
                MessageBox.Show(str2);
                return;
            }
            else
            {
                str2 = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName2;
                MessageBox.Show(str2);
            }
            return;
        }

        private void btnBMP3_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName3;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sBmpPicFileName3 = "Photos\\BMP_test3_" + i + ".bmp";

            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle3, sBmpPicFileName3))
            {
                iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                str3 = "NET_DVR_CapturePicture failed, error code= " + iLastErr3;
                MessageBox.Show(str3);
                return;
            }
            else
            {
                str3 = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName3;
                MessageBox.Show(str3);
            }
            return;
        }

        private void btnBMP4_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName4;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sBmpPicFileName4 = "Photos\\BMP_test4_" + i + ".bmp";

            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle4, sBmpPicFileName4))
            {
                iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                str4 = "NET_DVR_CapturePicture failed, error code= " + iLastErr4;
                MessageBox.Show(str4);
                return;
            }
            else
            {
                str4 = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName4;
                MessageBox.Show(str4);
            }
            return;
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName;
            // The path and file name to save
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName = "Photos\\JPEG_test_" + i + ".jpg";

            int lChannel = Int16.Parse(textBoxChannel.Text); // Channel number Channel number

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

        private void btnJPEG1_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName1;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName1 = "Photos\\JPEG_test1_" + i + ".jpg";

            int lChannel1 = Int16.Parse(textBoxChannel1.Text);

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara1 = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara1.wPicQuality = 0;
            lpJpegPara1.wPicSize = 0xff;

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID1, lChannel1, ref lpJpegPara1, sJpegPicFileName1))
            {
                iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                str1 = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr1;
                MessageBox.Show(str1);
                return;
            }
            else
            {
                str1 = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName1;
                MessageBox.Show(str1);
            }
            return;
        }

        private void btnJPEG2_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName2;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName2 = "Photos\\JPEG_test2_" + i + ".jpg";

            int lChannel2 = Int16.Parse(textBoxChannel2.Text);

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

        private void btnJPEG3_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName3;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName3 = "Photos\\JPEG_test3_" + i + ".jpg";

            int lChannel3 = Int16.Parse(textBoxChannel3.Text);

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

        private void btnJPEG4_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName4;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sJpegPicFileName4 = "Photos\\JPEG_test4_" + i + ".jpg";

            int lChannel4 = Int16.Parse(textBoxChannel4.Text);

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

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // The path and file name to save
            string sVideoFileName;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sVideoFileName = "Photos\\Record_test_" + i + ".mp4";

            if (m_bRecord == false)
            {
                // Make a I frame
                int lChannel = Int16.Parse(textBoxChannel.Text);  // Channel number Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);

                // Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {                  
                    btnRecord.Text = "Stop Record";
                    m_bRecord = true;
                }
            }
            else
            {
                // Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    str = "Successful to stop recording and the saved file is " + sVideoFileName;
                    MessageBox.Show(str);
                    btnRecord.Text = "Start Record";
                    m_bRecord = false;
                }            
            }
            return;
        }

        private void btnRecord1_Click(object sender, EventArgs e)
        {
            string sVideoFileName1;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sVideoFileName1 = "Photos\\Record_test1_" + i + ".mp4";

            if (m_bRecord1 == false)
            {
                int lChannel1 = Int16.Parse(textBoxChannel1.Text);
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID1, lChannel1);

                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle1, sVideoFileName1))
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_SaveRealData failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                else
                {
                    btnRecord1.Text = "Stop Record";
                    m_bRecord1 = true;
                }
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle1))
                {
                    iLastErr1 = CHCNetSDK.NET_DVR_GetLastError();
                    str1 = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr1;
                    MessageBox.Show(str1);
                    return;
                }
                else
                {
                    str1 = "Successful to stop recording and the saved file is " + sVideoFileName1;
                    MessageBox.Show(str1);
                    btnRecord1.Text = "Start Record";
                    m_bRecord1 = false;
                }
            }
            return;
        }

        private void btnRecord2_Click(object sender, EventArgs e)
        {
            string sVideoFileName2;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sVideoFileName2 = "Photos\\Record_test2_" + i + ".mp4";

            if (m_bRecord2 == false)
            {
                int lChannel2 = Int16.Parse(textBoxChannel2.Text);
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID2, lChannel2);

                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle2, sVideoFileName2))
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_SaveRealData failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                else
                {
                    btnRecord2.Text = "Stop Record";
                    m_bRecord2 = true;
                }
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle2))
                {
                    iLastErr2 = CHCNetSDK.NET_DVR_GetLastError();
                    str2 = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr2;
                    MessageBox.Show(str2);
                    return;
                }
                else
                {
                    str2 = "Successful to stop recording and the saved file is " + sVideoFileName2;
                    MessageBox.Show(str2);
                    btnRecord2.Text = "Start Record";
                    m_bRecord2 = false;
                }
            }
            return;
        }

        private void btnRecord3_Click(object sender, EventArgs e)
        {
            string sVideoFileName3;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sVideoFileName3 = "Photos\\Record_test3_" + i + ".mp4";

            if (m_bRecord3 == false)
            {
                int lChannel3 = Int16.Parse(textBoxChannel3.Text);
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID3, lChannel3);

                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle3, sVideoFileName3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_SaveRealData failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                else
                {
                    btnRecord3.Text = "Stop Record";
                    m_bRecord3 = true;
                }
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle3))
                {
                    iLastErr3 = CHCNetSDK.NET_DVR_GetLastError();
                    str3 = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr3;
                    MessageBox.Show(str3);
                    return;
                }
                else
                {
                    str3 = "Successful to stop recording and the saved file is " + sVideoFileName3;
                    MessageBox.Show(str3);
                    btnRecord3.Text = "Start Record";
                    m_bRecord3 = false;
                }
            }
            return;
        }

        private void btnRecord4_Click(object sender, EventArgs e)
        {
            string sVideoFileName4;
            String i = DateTime.Now.ToString().Replace("-", "").Replace(":", "").Replace(" ", "_");
            sVideoFileName4 = "Photos\\Record_test4_" + i + ".mp4";

            if (m_bRecord4 == false)
            {
                int lChannel4 = Int16.Parse(textBoxChannel4.Text);
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID4, lChannel4);

                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle4, sVideoFileName4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_SaveRealData failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                else
                {
                    btnRecord4.Text = "Stop Record";
                    m_bRecord4 = true;
                }
            }
            else
            {
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle4))
                {
                    iLastErr4 = CHCNetSDK.NET_DVR_GetLastError();
                    str4 = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr4;
                    MessageBox.Show(str4);
                    return;
                }
                else
                {
                    str4 = "Successful to stop recording and the saved file is " + sVideoFileName4;
                    MessageBox.Show(str4);
                    btnRecord4.Text = "Start Record";
                    m_bRecord4 = false;
                }
            }
            return;
        }

        private void btnPTZ_Click(object sender, EventArgs e)
        {

        }

        public void VoiceDataCallBack(int lVoiceComHandle, IntPtr pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser)
        {
            byte[] sString = new byte[dwBufSize];
            Marshal.Copy(pRecvDataBuffer, sString, 0, (Int32)dwBufSize);

            if (byAudioFlag ==0)
            {
                // save the data into a file
                string str = "PC capture audio file.pcm";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sString, 0, iLen);
                fs.Close();
            }
            if (byAudioFlag == 1)
            {
                // save the data into a file
                string str = "Device audio file.pcm";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sString, 0, iLen);
                fs.Close();
            }

        }

        private void btnVioceTalk_Click(object sender, EventArgs e)
        {
            if (m_bTalk == false)
            {
                // Start two-way talk
                CHCNetSDK.VOICEDATACALLBACKV30 VoiceData = new CHCNetSDK.VOICEDATACALLBACKV30(VoiceDataCallBack); // Preview real-time stream callback function

                lVoiceComHandle = CHCNetSDK.NET_DVR_StartVoiceCom_V30(m_lUserID, 1, true, VoiceData, IntPtr.Zero);
                // bNeedCBNoEncData [in] Type of voice data to be called back: 0- voice data after encoding, 1- PCM original data before encoding

                if (lVoiceComHandle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StartVoiceCom_V30 failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    btnVioceTalk.Text = "Stop Talk";
                    m_bTalk = true;
                }
            }
            else
            {
                // Stop two-way talk
                if (!CHCNetSDK.NET_DVR_StopVoiceCom(lVoiceComHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopVoiceCom failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    btnVioceTalk.Text = "Start Talk";
                    m_bTalk = false;
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Ptz_Set_Click(object sender, EventArgs e)
        {

        }

        private void PreSet_Click(object sender, EventArgs e)
        {
            PreSet dlg = new PreSet();
            dlg.m_lUserID = m_lUserID;
            dlg.m_lChannel = 1;
            dlg.m_lRealHandle = m_lRealHandle;
            dlg.ShowDialog();
            
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
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                    serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);

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
            if (comboBoxCam.SelectedIndex >= 0)
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxCam.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
                btnScan.Text = "Scanning";
                btnScan.Enabled = false;
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    textBoxQRCode.Text = result.ToString();
                    /*timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }*/
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
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

            if (m_lRealHandle1 >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle1);
                m_lRealHandle1 = -1;
            }

            if (m_lUserID1 >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID1);
                m_lUserID1 = -1;
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

            CHCNetSDK.NET_DVR_Cleanup();

            Application.Exit();
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

                if (m_lRealHandle1 >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle1);
                    m_lRealHandle1 = -1;
                }

                if (m_lUserID1 >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID1);
                    m_lUserID1 = -1;
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

                CHCNetSDK.NET_DVR_Cleanup();
            }
        }
    }
}
