namespace PATOMatic
{
    partial class frmPAT
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
            this.txtLineRX = new System.Windows.Forms.TextBox();
            this.btn_IEC = new System.Windows.Forms.Button();
            this.txt_asset = new System.Windows.Forms.TextBox();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_parse = new System.Windows.Forms.Button();
            this.txtLineCnt = new System.Windows.Forms.TextBox();
            this.txt_site = new System.Windows.Forms.TextBox();
            this.btn_site = new System.Windows.Forms.Button();
            this.cbo_CSA = new System.Windows.Forms.ComboBox();
            this.cbo_plug = new System.Windows.Forms.ComboBox();
            this.cbo_socket = new System.Windows.Forms.ComboBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.lbl_R_limit = new System.Windows.Forms.Label();
            this.btn_lookup = new System.Windows.Forms.Button();
            this.chk_autopat = new System.Windows.Forms.CheckBox();
            this.btn_configure = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.lbl_code = new System.Windows.Forms.Label();
            this.CALVAL = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnParse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BtnHIDTest = new System.Windows.Forms.Button();
            this.txtHIDToSend = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CALVAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLineRX
            // 
            this.txtLineRX.Location = new System.Drawing.Point(355, 723);
            this.txtLineRX.Margin = new System.Windows.Forms.Padding(6);
            this.txtLineRX.Name = "txtLineRX";
            this.txtLineRX.Size = new System.Drawing.Size(543, 31);
            this.txtLineRX.TabIndex = 0;
            // 
            // btn_IEC
            // 
            this.btn_IEC.Location = new System.Drawing.Point(229, 407);
            this.btn_IEC.Margin = new System.Windows.Forms.Padding(6);
            this.btn_IEC.Name = "btn_IEC";
            this.btn_IEC.Size = new System.Drawing.Size(179, 92);
            this.btn_IEC.TabIndex = 3;
            this.btn_IEC.Text = "IEC Lead test";
            this.btn_IEC.UseVisualStyleBackColor = true;
            this.btn_IEC.Click += new System.EventHandler(this.btnIECTest);
            // 
            // txt_asset
            // 
            this.txt_asset.Location = new System.Drawing.Point(34, 106);
            this.txt_asset.Margin = new System.Windows.Forms.Padding(6);
            this.txt_asset.Name = "txt_asset";
            this.txt_asset.Size = new System.Drawing.Size(177, 31);
            this.txt_asset.TabIndex = 4;
            this.txt_asset.Text = "test";
            // 
            // btnSetUser
            // 
            this.btnSetUser.Location = new System.Drawing.Point(193, 654);
            this.btnSetUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(150, 44);
            this.btnSetUser.TabIndex = 5;
            this.btnSetUser.Text = "Set User";
            this.btnSetUser.UseVisualStyleBackColor = true;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(46, 661);
            this.txt_user.Margin = new System.Windows.Forms.Padding(6);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(136, 31);
            this.txt_user.TabIndex = 6;
            this.txt_user.Text = "Chris";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(193, 710);
            this.btn_download.Margin = new System.Windows.Forms.Padding(6);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 44);
            this.btn_download.TabIndex = 7;
            this.btn_download.Text = "Download All";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_parse
            // 
            this.btn_parse.Location = new System.Drawing.Point(229, 311);
            this.btn_parse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(179, 92);
            this.btn_parse.TabIndex = 8;
            this.btn_parse.Text = "Parse FIle";
            this.btn_parse.UseVisualStyleBackColor = true;
            this.btn_parse.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // txtLineCnt
            // 
            this.txtLineCnt.Location = new System.Drawing.Point(355, 681);
            this.txtLineCnt.Margin = new System.Windows.Forms.Padding(6);
            this.txtLineCnt.Name = "txtLineCnt";
            this.txtLineCnt.Size = new System.Drawing.Size(543, 31);
            this.txtLineCnt.TabIndex = 9;
            // 
            // txt_site
            // 
            this.txt_site.Location = new System.Drawing.Point(46, 606);
            this.txt_site.Margin = new System.Windows.Forms.Padding(6);
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(136, 31);
            this.txt_site.TabIndex = 11;
            this.txt_site.Text = "Tec";
            // 
            // btn_site
            // 
            this.btn_site.Location = new System.Drawing.Point(193, 598);
            this.btn_site.Margin = new System.Windows.Forms.Padding(6);
            this.btn_site.Name = "btn_site";
            this.btn_site.Size = new System.Drawing.Size(150, 44);
            this.btn_site.TabIndex = 10;
            this.btn_site.Text = "Set Site";
            this.btn_site.UseVisualStyleBackColor = true;
            this.btn_site.Click += new System.EventHandler(this.btn_site_Click);
            // 
            // cbo_CSA
            // 
            this.cbo_CSA.FormattingEnabled = true;
            this.cbo_CSA.Items.AddRange(new object[] {
            "0.5",
            "0.75",
            "1.0",
            "1.5",
            "2.5",
            "4.0",
            "6.0",
            "10",
            "16",
            "25",
            "35"});
            this.cbo_CSA.Location = new System.Drawing.Point(185, 223);
            this.cbo_CSA.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_CSA.Name = "cbo_CSA";
            this.cbo_CSA.Size = new System.Drawing.Size(92, 33);
            this.cbo_CSA.TabIndex = 12;
            this.cbo_CSA.Text = "0.5";
            this.cbo_CSA.SelectedIndexChanged += new System.EventHandler(this.cbo_CSA_SelectedIndexChanged);
            // 
            // cbo_plug
            // 
            this.cbo_plug.FormattingEnabled = true;
            this.cbo_plug.Items.AddRange(new object[] {
            "IEC",
            "13A",
            "16A",
            "Powercon",
            "32A",
            "63A",
            "125A",
            "Powerlock",
            "Socapex"});
            this.cbo_plug.Location = new System.Drawing.Point(34, 223);
            this.cbo_plug.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_plug.Name = "cbo_plug";
            this.cbo_plug.Size = new System.Drawing.Size(147, 33);
            this.cbo_plug.TabIndex = 13;
            // 
            // cbo_socket
            // 
            this.cbo_socket.FormattingEnabled = true;
            this.cbo_socket.Items.AddRange(new object[] {
            "IEC",
            "13A",
            "16A",
            "Powercon",
            "32A",
            "63A",
            "125A",
            "Powerlock",
            "Socapex"});
            this.cbo_socket.Location = new System.Drawing.Point(360, 223);
            this.cbo_socket.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_socket.Name = "cbo_socket";
            this.cbo_socket.Size = new System.Drawing.Size(147, 33);
            this.cbo_socket.TabIndex = 14;
            this.cbo_socket.SelectedIndexChanged += new System.EventHandler(this.cbo_socket_SelectedIndexChanged);
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(280, 224);
            this.txt_length.Margin = new System.Windows.Forms.Padding(2);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(76, 31);
            this.txt_length.TabIndex = 15;
            this.txt_length.Text = "1";
            this.txt_length.TextChanged += new System.EventHandler(this.txt_length_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Plug";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Socket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "CSA";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Location = new System.Drawing.Point(514, 223);
            this.lbl_R.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(54, 25);
            this.lbl_R.TabIndex = 20;
            this.lbl_R.Text = "0.10";
            // 
            // lbl_R_limit
            // 
            this.lbl_R_limit.AutoSize = true;
            this.lbl_R_limit.Location = new System.Drawing.Point(583, 223);
            this.lbl_R_limit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_R_limit.Name = "lbl_R_limit";
            this.lbl_R_limit.Size = new System.Drawing.Size(54, 25);
            this.lbl_R_limit.TabIndex = 21;
            this.lbl_R_limit.Text = "0.20";
            // 
            // btn_lookup
            // 
            this.btn_lookup.Location = new System.Drawing.Point(223, 98);
            this.btn_lookup.Margin = new System.Windows.Forms.Padding(6);
            this.btn_lookup.Name = "btn_lookup";
            this.btn_lookup.Size = new System.Drawing.Size(150, 44);
            this.btn_lookup.TabIndex = 22;
            this.btn_lookup.Text = "Lookup";
            this.btn_lookup.UseVisualStyleBackColor = true;
            this.btn_lookup.Click += new System.EventHandler(this.btn_lookup_Click);
            // 
            // chk_autopat
            // 
            this.chk_autopat.AutoSize = true;
            this.chk_autopat.Location = new System.Drawing.Point(400, 107);
            this.chk_autopat.Margin = new System.Windows.Forms.Padding(2);
            this.chk_autopat.Name = "chk_autopat";
            this.chk_autopat.Size = new System.Drawing.Size(135, 29);
            this.chk_autopat.TabIndex = 23;
            this.chk_autopat.Text = "Auto PAT";
            this.chk_autopat.UseVisualStyleBackColor = true;
            // 
            // btn_configure
            // 
            this.btn_configure.Location = new System.Drawing.Point(46, 407);
            this.btn_configure.Margin = new System.Windows.Forms.Padding(2);
            this.btn_configure.Name = "btn_configure";
            this.btn_configure.Size = new System.Drawing.Size(179, 92);
            this.btn_configure.TabIndex = 24;
            this.btn_configure.Text = "Configure tests";
            this.btn_configure.UseVisualStyleBackColor = true;
            this.btn_configure.Click += new System.EventHandler(this.btn_configure_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(732, 210);
            this.btn_test.Margin = new System.Windows.Forms.Padding(6);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(150, 44);
            this.btn_test.TabIndex = 25;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(676, 223);
            this.lbl_code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(24, 25);
            this.lbl_code.TabIndex = 26;
            this.lbl_code.Text = "0";
            // 
            // CALVAL
            // 
            this.CALVAL.DecimalPlaces = 1;
            this.CALVAL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CALVAL.Location = new System.Drawing.Point(692, 98);
            this.CALVAL.Margin = new System.Windows.Forms.Padding(2);
            this.CALVAL.Name = "CALVAL";
            this.CALVAL.Size = new System.Drawing.Size(90, 31);
            this.CALVAL.TabIndex = 27;
            this.CALVAL.ValueChanged += new System.EventHandler(this.CALVAL_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(906, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 727);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(412, 311);
            this.btnParse.Margin = new System.Windows.Forms.Padding(2);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(179, 92);
            this.btnParse.TabIndex = 29;
            this.btnParse.Text = "Parse Results";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParseArray);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "R Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Test";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(46, 311);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(179, 92);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BtnHIDTest
            // 
            this.BtnHIDTest.Location = new System.Drawing.Point(704, 311);
            this.BtnHIDTest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHIDTest.Name = "BtnHIDTest";
            this.BtnHIDTest.Size = new System.Drawing.Size(178, 92);
            this.BtnHIDTest.TabIndex = 35;
            this.BtnHIDTest.Text = "hid test";
            this.BtnHIDTest.UseVisualStyleBackColor = true;
            this.BtnHIDTest.Click += new System.EventHandler(this.btnHIDTest_Click);
            // 
            // txtHIDToSend
            // 
            this.txtHIDToSend.Location = new System.Drawing.Point(704, 407);
            this.txtHIDToSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtHIDToSend.Name = "txtHIDToSend";
            this.txtHIDToSend.Size = new System.Drawing.Size(178, 31);
            this.txtHIDToSend.TabIndex = 36;
            this.txtHIDToSend.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cal offset";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(229, 273);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(179, 33);
            this.cboComPort.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "COM Port";
            // 
            // frmPAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2373, 949);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHIDToSend);
            this.Controls.Add(this.BtnHIDTest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CALVAL);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_configure);
            this.Controls.Add(this.chk_autopat);
            this.Controls.Add(this.btn_lookup);
            this.Controls.Add(this.lbl_R_limit);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.cbo_socket);
            this.Controls.Add(this.cbo_plug);
            this.Controls.Add(this.cbo_CSA);
            this.Controls.Add(this.txt_site);
            this.Controls.Add(this.btn_site);
            this.Controls.Add(this.txtLineCnt);
            this.Controls.Add(this.btn_parse);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btnSetUser);
            this.Controls.Add(this.txt_asset);
            this.Controls.Add(this.btn_IEC);
            this.Controls.Add(this.txtLineRX);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPAT";
            this.Text = "PAT-O-Matic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CALVAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLineRX;
        private System.Windows.Forms.Button btn_IEC;
        private System.Windows.Forms.TextBox txt_asset;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.TextBox txtLineCnt;
        private System.Windows.Forms.TextBox txt_site;
        private System.Windows.Forms.Button btn_site;
        private System.Windows.Forms.ComboBox cbo_CSA;
        private System.Windows.Forms.ComboBox cbo_plug;
        private System.Windows.Forms.ComboBox cbo_socket;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.Label lbl_R_limit;
        private System.Windows.Forms.Button btn_lookup;
        private System.Windows.Forms.CheckBox chk_autopat;
        private System.Windows.Forms.Button btn_configure;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.NumericUpDown CALVAL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button BtnHIDTest;
        private System.Windows.Forms.TextBox txtHIDToSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label label9;
    }
}

