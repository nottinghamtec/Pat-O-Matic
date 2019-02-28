namespace WindowsApplication14
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_IEC = new System.Windows.Forms.Button();
            this.txt_asset = new System.Windows.Forms.TextBox();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_parse = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 897);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(723, 38);
            this.textBox1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(61, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 420);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(679, 38);
            this.textBox2.TabIndex = 2;
            // 
            // btn_IEC
            // 
            this.btn_IEC.Location = new System.Drawing.Point(113, 678);
            this.btn_IEC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_IEC.Name = "btn_IEC";
            this.btn_IEC.Size = new System.Drawing.Size(200, 55);
            this.btn_IEC.TabIndex = 3;
            this.btn_IEC.Text = "IEC Lead test";
            this.btn_IEC.UseVisualStyleBackColor = true;
            this.btn_IEC.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_asset
            // 
            this.txt_asset.Location = new System.Drawing.Point(46, 131);
            this.txt_asset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_asset.Name = "txt_asset";
            this.txt_asset.Size = new System.Drawing.Size(235, 38);
            this.txt_asset.TabIndex = 4;
            this.txt_asset.Text = "test";
            // 
            // btnSetUser
            // 
            this.btnSetUser.Location = new System.Drawing.Point(257, 811);
            this.btnSetUser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(200, 55);
            this.btnSetUser.TabIndex = 5;
            this.btnSetUser.Text = "Set User";
            this.btnSetUser.UseVisualStyleBackColor = true;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(61, 820);
            this.txt_user.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(180, 38);
            this.txt_user.TabIndex = 6;
            this.txt_user.Text = "Chris";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(257, 880);
            this.btn_download.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(200, 55);
            this.btn_download.TabIndex = 7;
            this.btn_download.Text = "Download All";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_parse
            // 
            this.btn_parse.Location = new System.Drawing.Point(725, 538);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(239, 126);
            this.btn_parse.TabIndex = 8;
            this.btn_parse.Text = "test parse 131";
            this.btn_parse.UseVisualStyleBackColor = true;
            this.btn_parse.Click += new System.EventHandler(this.btn_parse_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(473, 845);
            this.textBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(723, 38);
            this.textBox3.TabIndex = 9;
            // 
            // txt_site
            // 
            this.txt_site.Location = new System.Drawing.Point(61, 751);
            this.txt_site.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(180, 38);
            this.txt_site.TabIndex = 11;
            this.txt_site.Text = "Tec";
            // 
            // btn_site
            // 
            this.btn_site.Location = new System.Drawing.Point(257, 742);
            this.btn_site.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_site.Name = "btn_site";
            this.btn_site.Size = new System.Drawing.Size(200, 55);
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
            this.cbo_CSA.Location = new System.Drawing.Point(247, 277);
            this.cbo_CSA.Name = "cbo_CSA";
            this.cbo_CSA.Size = new System.Drawing.Size(121, 39);
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
            "Soccapex"});
            this.cbo_plug.Location = new System.Drawing.Point(46, 277);
            this.cbo_plug.Name = "cbo_plug";
            this.cbo_plug.Size = new System.Drawing.Size(195, 39);
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
            "Soccapex"});
            this.cbo_socket.Location = new System.Drawing.Point(480, 277);
            this.cbo_socket.Name = "cbo_socket";
            this.cbo_socket.Size = new System.Drawing.Size(195, 39);
            this.cbo_socket.TabIndex = 14;
            this.cbo_socket.SelectedIndexChanged += new System.EventHandler(this.cbo_socket_SelectedIndexChanged);
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(374, 278);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 38);
            this.txt_length.TabIndex = 15;
            this.txt_length.Text = "1";
            this.txt_length.TextChanged += new System.EventHandler(this.txt_length_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Plug";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Socket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "CSA";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Location = new System.Drawing.Point(686, 277);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(71, 32);
            this.lbl_R.TabIndex = 20;
            this.lbl_R.Text = "0.10";
            // 
            // lbl_R_limit
            // 
            this.lbl_R_limit.AutoSize = true;
            this.lbl_R_limit.Location = new System.Drawing.Point(777, 277);
            this.lbl_R_limit.Name = "lbl_R_limit";
            this.lbl_R_limit.Size = new System.Drawing.Size(71, 32);
            this.lbl_R_limit.TabIndex = 21;
            this.lbl_R_limit.Text = "0.20";
            // 
            // btn_lookup
            // 
            this.btn_lookup.Location = new System.Drawing.Point(297, 122);
            this.btn_lookup.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_lookup.Name = "btn_lookup";
            this.btn_lookup.Size = new System.Drawing.Size(200, 55);
            this.btn_lookup.TabIndex = 22;
            this.btn_lookup.Text = "Lookup";
            this.btn_lookup.UseVisualStyleBackColor = true;
            // 
            // chk_autopat
            // 
            this.chk_autopat.AutoSize = true;
            this.chk_autopat.Location = new System.Drawing.Point(533, 133);
            this.chk_autopat.Name = "chk_autopat";
            this.chk_autopat.Size = new System.Drawing.Size(174, 36);
            this.chk_autopat.TabIndex = 23;
            this.chk_autopat.Text = "Auto PAT";
            this.chk_autopat.UseVisualStyleBackColor = true;
            // 
            // btn_configure
            // 
            this.btn_configure.Location = new System.Drawing.Point(422, 538);
            this.btn_configure.Name = "btn_configure";
            this.btn_configure.Size = new System.Drawing.Size(239, 114);
            this.btn_configure.TabIndex = 24;
            this.btn_configure.Text = "Configure tests";
            this.btn_configure.UseVisualStyleBackColor = true;
            this.btn_configure.Click += new System.EventHandler(this.btn_configure_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(976, 261);
            this.btn_test.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(200, 55);
            this.btn_test.TabIndex = 25;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(901, 277);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(31, 32);
            this.lbl_code.TabIndex = 26;
            this.lbl_code.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(727, 89);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1208, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1889, 901);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 68);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "R Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(886, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3164, 961);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_parse);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btnSetUser);
            this.Controls.Add(this.txt_asset);
            this.Controls.Add(this.btn_IEC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_IEC;
        private System.Windows.Forms.TextBox txt_asset;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

