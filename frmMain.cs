using HIDInterface;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PATOMatic
{


    public partial class frmPAT : Form
    {
        int readcount = 0;
        string downloadedData;
        List<Asset> assets = new List<Asset>();
        HIDDevice device;
        double res;
        double res_limit;
        int test;
        class Result
        {
            public class resultTypeText
            {
                public const string visual = "Visual";
                public const string testCurrent = "Test Current";
                public const string earthBond = "Earth Bond";
                public const string bondRange = "Earth Bond Range";
                public const string insulation = "Insulation Resistance";
                public const string continuity = "Continuity";
                public const string load = "Load";
                public const string current = "Current";
                public const string leakage = "Leakage";


            }
            public enum ResultType { visual, testCurrent, earthBond, bondRange, insulation, continuity, load, current, leakage }

            public ResultType type;
            public bool isnumeric;
            public double limit;
            public double measurement;
            public string unit;
            public bool pass;
        };
        class Asset
        {
            public int testNo;
            public DateTime testDate;
            public string assetID;
            public string site;
            public int test;
            public bool auto;
            public List<Result> results = new List<Result>();

            public void parse(string input)
            {
                List<string> lines = new List<string>(
                               input.Split(new string[] { "\r\n" },
                               StringSplitOptions.RemoveEmptyEntries));
                foreach (var line in lines)
                {
                    List<string> words = new List<string>(
                               line.Split(new char[] { ' ' },
                               StringSplitOptions.RemoveEmptyEntries));


                    Result aresult = new Result();
                    switch (words[0])
                    {

                        case "TEST":
                            switch (words[1])
                            {
                                case "NUMBER":
                                    testNo = Convert.ToInt16(words[2]);
                                    break;
                                case "MODE":
                                    test = Convert.ToInt16(words[2]);
                                    auto = words[3].Equals("AUTO");
                                    break;

                            }
                            break;

                        case "DATE":
                            testDate = Convert.ToDateTime(words[1]);
                            break;
                        case "APP":
                            assetID = line.Substring(8);
                            assetID = assetID.Trim();
                            break;
                        case "SITE":
                            site = line.Substring(8);
                            site = site.Trim();
                            break;

                        case "VISUAL":

                            aresult.type = Result.ResultType.visual;
                            aresult.pass = words[2].Equals("P");
                            aresult.isnumeric = false;
                            results.Add(aresult);
                            break;

                        case "BOND":

                            aresult.type = Result.ResultType.bondRange;
                            int pos = 0;
                            while (!Char.IsLetter(words[2][pos]))
                            {
                                ++pos;
                            }

                            aresult.measurement = Convert.ToSingle(words[2].Substring(0, pos));
                            aresult.unit = words[2].Substring(pos);

                            results.Add(aresult);

                            break;
                        case "EARTH":

                            aresult.type = Result.ResultType.earthBond;

                            if (words[1][0] == '>')
                            {
                                aresult.measurement = Convert.ToSingle(words[1].Substring(1));

                            }
                            else
                            {
                                aresult.measurement = Convert.ToSingle(words[1]);
                            }
                            aresult.unit = words[2];
                            aresult.pass = words[3].Equals("P");


                            results.Add(aresult);

                            break;

                        case "LIMIT":
                            aresult = results[results.Count - 1];
                            aresult.limit = Convert.ToSingle(words[1]);
                            break;

                        case "INS":

                            aresult.type = Result.ResultType.insulation;

                            if (words[2][0] == '>')
                            {
                                aresult.measurement = Convert.ToSingle(words[2].Substring(1));

                            }
                            else
                            {
                                aresult.measurement = Convert.ToSingle(words[2]);
                            }
                            aresult.unit = words[3];
                            aresult.pass = words[4].Equals("P");


                            results.Add(aresult);

                            break;
                        case "PN":
                        case "LEAD":

                            aresult.type = Result.ResultType.continuity;
                            aresult.pass = words[2].Equals("P");
                            aresult.isnumeric = false;
                            results.Add(aresult);
                            break;

                        case "LOAD":

                            aresult.type = Result.ResultType.load;

                            aresult.measurement = Convert.ToSingle(words[1]);
                            aresult.unit = words[2];
                            aresult.pass = words[3].Equals("P");


                            results.Add(aresult);

                            break;

                        case "CURRENT":

                            aresult.type = Result.ResultType.current;

                            aresult.measurement = Convert.ToSingle(words[1]);
                            aresult.unit = words[2];
                            aresult.pass = words[3].Equals("P");


                            results.Add(aresult);

                            break;

                        case "LKGE":

                            aresult.type = Result.ResultType.leakage;

                            aresult.measurement = Convert.ToSingle(words[1]);
                            aresult.unit = words[2];
                            aresult.pass = words[3].Equals("P");


                            results.Add(aresult);

                            break;


                    }
                }


            }
        };
        class pat_command
        {
            public const string bond_200_mA = "\x01";
            public const string bond_25A = "\x02";
            public const string misc_1 = "\x03";
            public const string insulation = "\x04";
            public const string i_sub = "\x05";
            public const string i_touch = "\x06";
            public const string load_leak = "\x07";
            public const string iec_lead = "\x08";
            public const string visual = "\x09";
            public const string misc_2 = "\x0a";
            public const string auto = "\x0b";
            public const string go = "\x0c";
            public const string enter = "\x0d";
            public const string stop = "\x0e";
            public const string setup = "\x0f";
            public const string memory = "\x10";
            public const string backspace = "\x11";
            public const string print = "\x12";
            public const string yes = "\x13";
            public const string no = "\x14";
            public const string help = "\x15";
            public const string up = "\x16";
            public const string down = "\x17";
            public const string left = "\x18";
            public const string right = "\x19";
            public const string misc_3 = "\x0a";
        };
        SerialPort _serialPort;

        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);

        public frmPAT()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            calculateR();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Asset ID";
            dataGridView1.Columns[1].Name = "Lead Continuity";
            dataGridView1.Columns[2].Name = "Earth Bond";
            dataGridView1.Columns[3].Name = "Bond Limit";
            dataGridView1.Columns[4].Name = "Insulation Resistance";
            dataGridView1.Columns[5].Name = "Insulation Limit";

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboComPort.Items.Add(port);
            }


        }

        void parseData(string testdatatxt)
        {
            List<string> splitdata = new List<string>(
                          testdatatxt.Split(new string[] { "\r\n\r\n" },
                          StringSplitOptions.RemoveEmptyEntries));


            foreach (var line in splitdata)
            {
                if (line.StartsWith("TEST NUMBER") == true)
                {
                    Asset test = new Asset();
                    test.parse(line);
                    assets.Add(test);
                }
            }
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (_serialPort.BytesToRead > 0)
            {
                //Thread.Sleep(500);
                string data = _serialPort.ReadLine() + "\n";
                //SerialPort sp = (SerialPort)sender;
                //string data = sp.ReadExisting();

                System.IO.File.AppendAllText(@"C:\Users\Chris\Desktop\read from pat.txt", data);

                downloadedData += data;
                if (data.Equals("\r\n") == true)
                {

                    if (downloadedData.StartsWith("TEST NUMBER") == true && downloadedData.EndsWith("\r\n\r\n"))
                    {
                        readcount++;
                        this.BeginInvoke(new SetTextDeleg(si_count), new object[] { Convert.ToString(readcount) });

                        this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { downloadedData });
                        Asset test = new Asset();
                        test.parse(downloadedData);
                        assets.Add(test);
                    }
                    downloadedData = "";

                }

            }

            /*
            if (data.StartsWith("MODEL") == true){
                downloadedData = "";
            }
            else if (data.StartsWith("END OF DATA") == true)
                {
                parseData(downloadedData);
            }
            else
            {
                downloadedData += data;
            }

    */

            //this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }

        private void si_DataReceived(string data)
        {
            txtLineRX.Text = data.Trim();
        }

        private void si_count(string data)
        {
            txtLineCnt.Text = data.Trim();
        }

        private void btnIECTest(object sender, EventArgs e)
        {
            // Makes sure serial port is open before trying to write
            try
            {
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
                _serialPort.Write(pat_command.stop);
                Thread.Sleep(500);
                _serialPort.Write(pat_command.auto);
                Thread.Sleep(500);
                _serialPort.Write("999 " + txt_asset.Text + pat_command.go);
                Thread.Sleep(2000);
                _serialPort.Write(pat_command.go);
                Thread.Sleep(16000);
                //assume it may have failed
                _serialPort.Write(pat_command.no);
                Thread.Sleep(2000);
                _serialPort.Write(pat_command.no);

                Thread.Sleep(1000);
                _serialPort.Write(pat_command.memory);
                Thread.Sleep(1000);
                _serialPort.Write(pat_command.go);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void btnSetUser_Click(object sender, EventArgs e)
        {
            _serialPort.Write(pat_command.stop);
            Thread.Sleep(500);
            _serialPort.Write(pat_command.setup);
            Thread.Sleep(500);

            _serialPort.Write(pat_command.down + pat_command.down + pat_command.down + pat_command.go);
            Thread.Sleep(500);


            _serialPort.Write(txt_user.Text);
            Thread.Sleep(700);
            _serialPort.Write(pat_command.go);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            _serialPort.Write(pat_command.stop);
            Thread.Sleep(500);
            _serialPort.Write(pat_command.print);
            Thread.Sleep(500);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1500);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(500);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(500);


        }



        private void btnParseFile_Click(object sender, EventArgs e)
        {
            string testdatatxt = System.IO.File.ReadAllText(@"C:\Users\Chris\Desktop\testdata.txt");
            parseData(testdatatxt);


        }

        private void btn_site_Click(object sender, EventArgs e)
        {
            _serialPort.Write(pat_command.stop);
            Thread.Sleep(500);
            _serialPort.Write(pat_command.setup);
            Thread.Sleep(500);

            _serialPort.Write(pat_command.down + pat_command.down + pat_command.go);
            Thread.Sleep(500);


            _serialPort.Write(txt_site.Text);
            Thread.Sleep(700);
            _serialPort.Write(pat_command.go);
        }

        private void cbo_socket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_CSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateR();
        }

        void calculateR()
        {
            double res_p_m;

            switch (cbo_CSA.Text)
            {
                case "0.5":
                    res_p_m = 0.039;
                    break;
                case "0.75":
                    res_p_m = 0.026;
                    break;
                case "1.0":
                    res_p_m = 0.0195;
                    break;
                case "1.5":
                    res_p_m = 0.0156;
                    break;
                case "2.5":
                    res_p_m = 0.0133;
                    break;
                case "4.0":
                    res_p_m = 0.00798;
                    break;
                case "6.0":
                    res_p_m = 0.00495;
                    break;
                case "10":
                    res_p_m = 0.0033;
                    break;
                case "16":
                    res_p_m = 0.00191;
                    break;
                case "25":
                    res_p_m = 0.00121;
                    break;
                case "35":
                    res_p_m = 0.00078;
                    break;
                default:
                    res_p_m = -1;
                    break;

            }

            res = res_p_m * Convert.ToDouble(txt_length.Text);
            res_limit = res + 0.1 + (double)CALVAL.Value;

            lbl_R.Text = res.ToString("N3");
            lbl_R_limit.Text = res_limit.ToString("N3");
            //pick correct test ID

            //no round, need to check result in pc
            //test = 899 + (int)Math.Ceiling(res_limit) * 10);

            //round to 2dp , probably acceptable.
            test = 899 + (int)Math.Ceiling(Math.Round(res_limit, 2) * 10);
            lbl_code.Text = test.ToString();
        }


        private void txt_length_TextChanged(object sender, EventArgs e)
        {
            calculateR();
        }

        public class bondTest
        {
            public bool Enabled;
            public testCurrent Current;
            public double RLimit;
            public int Duration;

            public enum testCurrent { _200mA, _25A }

            public bondTest(bool enabled, testCurrent current, double rLimit, int duration)
            {
                Enabled = enabled;
                Current = current;
                RLimit = rLimit;
            }

            public bondTest(bool enabled)
            {
                Enabled = enabled;
            }


        }


        class insulationTest
        {
            public bool Enabled;
            public testClass AppClass;
            public double RLimit;
            public int Duration;

            public enum testClass { Class1, Class2 }

            public insulationTest(bool enabled, testClass appClass, double rlimit, int duration)
            {
                Enabled = enabled;
                AppClass = appClass;
                RLimit = rlimit;
                Duration = duration;

            }
            public insulationTest(bool enabled)
            {
                Enabled = enabled;
            }

        }

        class substituteTest
        {
            public bool Enabled;
            public TestClass AppClass;
            public double LeakLimit;
            public int Duration;

            public enum TestClass { Class1, Class2 }

            public substituteTest(bool enabled, TestClass appClass, double leakLimit, int duration)
            {
                Enabled = enabled;
                AppClass = appClass;
                LeakLimit = leakLimit;
                Duration = duration;
            }

            public substituteTest(bool enabled)
            {
                Enabled = enabled;
            }
        }

        class loadTest
        {
            public bool Enabled;
            public double LeakLimit;
            public double VALimit;
            public int Duration;

            public loadTest(bool enabled, double leakLimit, double vALimit, int duration)
            {
                Enabled = enabled;
                LeakLimit = leakLimit;
                VALimit = vALimit;
                Duration = duration;
            }
            public loadTest(bool enabled)
            {
                Enabled = enabled;
            }


        }

        class touchTest
        {

            public bool Enabled;
            public double LeakLimit;
            public int Duration;

            public touchTest(bool enabled, double leakLimit, int duration)
            {
                Enabled = enabled;
                LeakLimit = leakLimit;
                Duration = duration;
            }

            public touchTest(bool enabled)
            {
                Enabled = enabled;
            }
        }
        class IECTest
        {
            public bool Enabled;
            public double RLimit;
            public int Duration;

            public IECTest(bool enabled, double rLimit, int duration)
            {
                Enabled = enabled;
                RLimit = rLimit;
                Duration = duration;
            }

            public IECTest(bool enabled)
            {
                Enabled = enabled;
            }
        }


        private void btn_configure_Click(object sender, EventArgs e)
        {
            bondTest bond = new bondTest(false);
            insulationTest insulation = new insulationTest(false);
            substituteTest substitute = new substituteTest(false);
            loadTest load = new loadTest(false);
            touchTest touch = new touchTest(false);
            IECTest iec = new IECTest(false);

            /*
            //IEC
            bond.Enabled = false;
            insulation.Enabled = false;
            substitute.Enabled = false;
            load.Enabled = false;
            touch.Enabled = false;
            iec.Enabled = true;

            iec.Duration = 5;
            iec.RLimit = .5;
            
          
            for (int i = 0; i < 10; i++)
            {
                iec.RLimit = .1 + (i * .1);
                configureTest(900 + i, false, bond, insulation, substitute, load, touch, iec);
            }


            
            
            //class 1 3.5 mA "Other Class 1" (131)
            bond.Enabled = true;
            insulation.Enabled = true;
            substitute.Enabled = false;
            load.Enabled = true;
            touch.Enabled = false;
            iec.Enabled = false;


            bond.Duration = 5;

            insulation.RLimit = 1;
            insulation.AppClass = insulationTest.testClass.Class1;
            insulation.Duration = 5;

            load.Duration = 5;
            load.VALimit = 3000;


           
            bond.Current = bondTest.testCurrent._25A;
            load.LeakLimit = 3.5;

            for (int i = 0; i < 5; i++)
            {
                bond.RLimit = .1 + (i * .1);
                configureTest(910 + i, false, bond, insulation, substitute, load, touch, iec);
            }




            //class 1 0.75 mA "Portable or hand-held" (132)

                        bond.Enabled = true;
            insulation.Enabled = true;
            substitute.Enabled = false;
            load.Enabled = true;
            touch.Enabled = false;
            iec.Enabled = false;


            bond.Duration = 5;

            insulation.RLimit = 1;
            insulation.AppClass = insulationTest.testClass.Class1;
            insulation.Duration = 5;

            load.Duration = 5;
            load.VALimit = 3000;


            load.LeakLimit = 0.75;
            bond.Current = bondTest.testCurrent._25A;

            for (int i = 0; i < 5; i++)
            {
                bond.RLimit = .1 + (i * .1);
                configureTest(915 + i, false, bond, insulation, substitute, load, touch, iec);
            }


   
            //class 1 IT 3.5 mA "Other Class 1" (133)
            bond.Enabled = true;
            insulation.Enabled = true;
            substitute.Enabled = false;
            load.Enabled = true;
            touch.Enabled = false;
            iec.Enabled = false;


            bond.Duration = 5;

            insulation.RLimit = 1;
            insulation.AppClass = insulationTest.testClass.Class1;
            insulation.Duration = 5;

            load.Duration = 5;
            load.VALimit = 3000;



            load.LeakLimit = 3.5;
            bond.Current = bondTest.testCurrent._200mA;
            for (int i = 0; i < 5; i++)
            {
                bond.RLimit = .1 + (i * .1);
                configureTest(920 + i, false, bond, insulation, substitute, load, touch, iec);
            }

    */

            //class 1 IT 0.75 mA "Portable or hand-held" (134)
            bond.Enabled = true;
            insulation.Enabled = true;
            substitute.Enabled = false;
            load.Enabled = true;
            touch.Enabled = false;
            iec.Enabled = false;


            bond.Duration = 5;

            insulation.RLimit = 1;
            insulation.AppClass = insulationTest.testClass.Class1;
            insulation.Duration = 5;

            load.Duration = 5;
            load.VALimit = 3000;


            load.LeakLimit = 0.75;
            bond.Current = bondTest.testCurrent._200mA;
            for (int i = 0; i < 5; i++)
            {
                bond.RLimit = .1 + (i * .1);
                configureTest(925 + i, false, bond, insulation, substitute, load, touch, iec);
            }


            //class 2 (234)
            bond.Enabled = false;
            insulation.Enabled = true;
            substitute.Enabled = false;
            load.Enabled = true;
            touch.Enabled = false;
            iec.Enabled = false;

            insulation.RLimit = 2;
            insulation.AppClass = insulationTest.testClass.Class2;
            insulation.Duration = 5;

            load.Duration = 5;
            load.VALimit = 3000;
            load.LeakLimit = 0.25;

            configureTest(930, false, bond, insulation, substitute, load, touch, iec);
            //


        }


        void configureTest(int test, bool visual, bondTest bond, insulationTest insulation, substituteTest substitute, loadTest load, touchTest touch, IECTest iec)
        {
            _serialPort.Write(pat_command.stop);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.setup);
            Thread.Sleep(1000);

            _serialPort.Write(pat_command.down + pat_command.down + pat_command.down + pat_command.down + pat_command.down + pat_command.go);
            Thread.Sleep(1000);


            _serialPort.Write("9999");
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1000);
            _serialPort.Write("137");
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1000);
            _serialPort.Write(Convert.ToString(test));
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.down);
            Thread.Sleep(1000);

            if (visual == true)
            {

            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            if (bond.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((bond.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);

                steps = Convert.ToInt32(bond.RLimit / .1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }
                if (bond.Current == bondTest.testCurrent._25A)
                {
                    _serialPort.Write(pat_command.up);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.up);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                }
                else
                {

                }
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }


            if (insulation.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((insulation.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);
                //0.1 teps up to 1, 1 afterwards
                if (insulation.RLimit < 1)
                {
                    steps = Convert.ToInt32((insulation.RLimit / .1));
                }
                else
                {
                    steps = 10 + Convert.ToInt32((insulation.RLimit) - 1);
                }


                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }
                if (insulation.AppClass == insulationTest.testClass.Class2)
                {
                    _serialPort.Write(pat_command.up);
                    Thread.Sleep(500);

                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                }
                else
                {
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                }
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);


            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            if (substitute.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((substitute.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);

                steps = Convert.ToInt32((substitute.LeakLimit / .5));



                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }
                if (substitute.AppClass == substituteTest.TestClass.Class2)
                {
                    _serialPort.Write(pat_command.up);
                    Thread.Sleep(500);

                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                }
                else
                {
                    _serialPort.Write(pat_command.down);
                    Thread.Sleep(500);
                }
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);


            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            if (load.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((load.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);

                steps = Convert.ToInt32((load.LeakLimit / .25));



                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);

                steps = Convert.ToInt32((load.VALimit / 100));



                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);


            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            if (touch.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((touch.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);
                if (touch.LeakLimit <= .5)
                {
                    steps = Convert.ToInt32((touch.LeakLimit / .25));
                }
                else
                {
                    steps = 2 + Convert.ToInt32(((touch.LeakLimit - .5) / .1));
                }

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }


                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);


            }
            else
            {
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }
            if (iec.Enabled == true)
            {
                _serialPort.Write(pat_command.right);
                Thread.Sleep(500);
                int steps = Convert.ToInt32((iec.Duration / 5) - 1);

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }

                _serialPort.Write(pat_command.up);
                Thread.Sleep(500);

                steps = Convert.ToInt32((iec.RLimit / .1));

                while (steps > 0)
                {
                    _serialPort.Write(pat_command.right);
                    Thread.Sleep(200);
                    steps--;
                }
                _serialPort.Write(pat_command.down);
                Thread.Sleep(500);
            }

            _serialPort.Write(pat_command.memory);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.down);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(2000);

        }

        private void testasset(string asset, int testid)
        {

            Thread.Sleep(1000);
            _serialPort.Write(pat_command.stop);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.auto);
            Thread.Sleep(1000);
            _serialPort.Write(Convert.ToString(testid) + " " + asset);
            Thread.Sleep(2000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(2000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(16000);
            //assume it may have failed
            _serialPort.Write(pat_command.no);
            Thread.Sleep(2000);
            _serialPort.Write(pat_command.no);

            Thread.Sleep(1000);
            _serialPort.Write(pat_command.memory);
            Thread.Sleep(1000);
            _serialPort.Write(pat_command.go);
            Thread.Sleep(1000);

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            byte[] writeData = { 0x00, 0x01, 0x02, 0x03, 0x04 };

            if (cbo_plug.Text == "Socapex")
            {
                string name;
                name = txt_asset.Text.ToUpper();
                name = name.Replace("SOCCA", "SOC");

                for (int i = 1; i <= 6; i++)
                {
                    writeData[1] = Convert.ToByte(i - 1);
                    device.write(writeData);

                    testasset(name + " " + Convert.ToString(i), Convert.ToInt16(lbl_code.Text));
                }

            }
            else
            {
                testasset(txt_asset.Text, Convert.ToInt16(lbl_code.Text));

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnParseArray(object sender, EventArgs e)
        {

            String Continuity = "";
            String EarthBond = "";
            String EarthBondLimit = "";
            String InsulationResistance = "";
            String InsulationLimit = "";

            foreach (var asset in assets)
            {
                foreach (var result in asset.results)
                {
                    switch (result.type)
                    {
                        case Result.ResultType.continuity:
                            Continuity = result.pass.ToString();
                            break;
                        case Result.ResultType.earthBond:
                            EarthBond = result.measurement.ToString("F2");
                            EarthBondLimit = result.limit.ToString("F1");
                            break;
                        case Result.ResultType.insulation:
                            InsulationResistance = result.measurement.ToString("F1");
                            InsulationLimit = result.limit.ToString("F1");
                            break;
                    }

                }
                string[] tblrow = new string[] { asset.assetID, Continuity, EarthBond, EarthBondLimit, InsulationResistance, InsulationLimit };


                dataGridView1.Rows.Add(tblrow);
            }

        }





        private void btnConnect_Click(object sender, EventArgs e)
        {
            // all of the options for a serial device
            // can be sent through the constructor of the SerialPort class
            // PortName = "COM1", Baud Rate = 19200, Parity = None, 
            // Data Bits = 8, Stop Bits = One, Handshake = None
            _serialPort = new SerialPort(cboComPort.Text, 38400, Parity.None, 8, StopBits.Two);
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 1000;
            _serialPort.Open();

            startAsyncOperation();
        }

        private void btnHIDTest_Click(object sender, EventArgs e)
        {

            byte[] writeData = { 0x00, 0x01, 0x02, 0x03, 0x04 };
            writeData[1] = Convert.ToByte(txtHIDToSend.Text);
            device.write(writeData);


        }




        // Apologies for the repeated code, however i feel it provides a better demonstration
        // of the functionality of this code.
        public void useSynchronousOperation()
        {
            //Get the details of all connected USB HID devices
            HIDDevice.interfaceDetails[] devices = HIDDevice.getConnectedDevices();
            int selectedDeviceIndex = 0;
            //loop through all connected devices to find one with the correct details
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i].VID == 0x006){
                    if (devices[i].PID== 0x1234){
                        selectedDeviceIndex = i;
                        break;
                    }
                }
            }


                //Arbitrarily select one of the devices which we found in the previous step
                //record the details of this device to be used in the class constructor
            ushort VID = devices[selectedDeviceIndex].VID;
            ushort PID = devices[selectedDeviceIndex].PID;
            int SN = devices[selectedDeviceIndex].serialNumber;
            string devicePath = devices[selectedDeviceIndex].devicePath;

            //create a handle to the device by calling the constructor of the HID class
            //This can be done using either the VID/PID/Serialnumber, or the device path (string) 
            //all of these details are available from the HIDDevice.interfaceDetails[] struct array created above
            //The "false" boolean in the constructor tells the class we only want synchronous operation
            device = new HIDDevice(devicePath, false);
            //OR, the normal usage when you know the VID and PID of the device
            //HIDDevice device = new HIDDevice(VID, PID, (ushort)SN, false);

            //Write some data to the device (the write method throws an exception if the data is longer than the report length
            //specified by the device, this length can be found in the HIDDevice.interfaceDetails struct)
            byte[] writeData = { 0x00, 0x01, 0x02, 0x03, 0x04 };
            device.write(writeData);    //Its that easy!!

            //Read some data synchronously from the device. This method blocks the calling thread until the data
            //is returned. This takes 1-20ms for most HID devices
            byte[] readData = device.read();    //again, that easy!

            //close the device to release all handles etc
            device.close();
        }

        public void startAsyncOperation()
        {
            //Get the details of all connected USB HID devices
            HIDDevice.interfaceDetails[] devices = HIDDevice.getConnectedDevices();
            int selectedDeviceIndex = 0;
            //loop through all connected devices to find one with the correct details
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i].VID == 0x1234)
                {
                    if (devices[i].PID == 0x006)
                    {
                        selectedDeviceIndex = i;
                        break;
                    }
                }
            }

            //Arbitrarily select one of the devices which we found in the previous step
            //record the details of this device to be used in the class constructor
            ushort VID = devices[selectedDeviceIndex].VID;
            ushort PID = devices[selectedDeviceIndex].PID;
            int SN = devices[selectedDeviceIndex].serialNumber;
            string devicePath = devices[selectedDeviceIndex].devicePath;

            //create a handle to the device by calling the constructor of the HID class
            //This can be done using either the VID/PID/Serialnumber, or the device path (string) 
            //all of these details are available from the HIDDevice.interfaceDetails[] struct array created above
            //The "true" boolean in the constructor tells the class we want asynchronous operation this time

            device = new HIDDevice(devicePath, true);
            //OR, the normal usage when you know the VID and PID of the device
            //HIDDevice device = new HIDDevice(VID, PID, (ushort)SN, true);

            //next create the event handler for the incoming reports
            device.dataReceived += new HIDDevice.dataReceivedEvent(device_dataReceived);

            //Write some data to the device (the write method throws an exception if the data is longer than the report length
            //specified by the device, this length can be found in the HIDDevice.interfaceDetails struct)
            //The write method is identical to the synchronous mode of operation

            byte[] writeData = { 0x00, 0x01, 0x02, 0x03, 0x04 };
            device.write(writeData);    //Its that easy!!

            //Send your program off to do other stuff here, wait for UI events etc
            //When a report occurs, the device_dataReceived(byte[] message) method will be called
            //System.Threading.Thread.Sleep(1000);

            //close the device to release all handles etc
            //device.close();
        }

        //Whenever a report comes in, this method will be called and the data will be available! Like magic...
        void device_dataReceived(byte[] message)
        {
            Console.WriteLine("data {0:D}", message[1]);
            //Do something with the data here...
        }

        private void btn_lookup_Click(object sender, EventArgs e)
        {

        }

        private void CALVAL_ValueChanged(object sender, EventArgs e)
        {
            calculateR();
        }
    }
}

