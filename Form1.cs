using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traveling_Salesman
{
    public partial class frmTSP : Form
    {
        //User Define
        int Ncities;
        int MinSpeed=1;
        int MaxSpeed;
        double T=10;
        double dT = 0.99;
        double rMultiple;
        bool BoltzFac;

        //Rand Define
        int[,] Highways;
        City[] Cities;

        //Program Vars
        Random r=new Random(DateTime.Now.Millisecond);
        List<int> CityIndx = new List<int>(0);
        List<int> ConnIndx = new List<int>(0);
        double CurDistance;
        double MinDist=0;
        double IniDistance;
        double pChange;
        double mTurns;
        
        //Misc
        int boltz;
        int move;
        bool Testing=false;
        bool iTest=false;
        bool Mdrawn = false;
        int StaleDist;
        int NMTurns;

        //Graphics
        Image MDraw;
        Image EDraw;
        Image tDraw;
        Image teDraw;
        Image IDraw;
        Graphics GMDraw;
        
        //RunMulti
        double curSpeed;
        double FinSpeed;
        bool DoMulti=false;

        //Data
        double IDist;
        double PreMetroDist;
        double FDist;
        public frmTSP()
        {
            InitializeComponent();
        }
        Run RunT;
        private void btnRun_Click(object sender, EventArgs e)
        {
            Setup();
        }
        public void Setup(){
            Ncities = (int)nudCities.Value;
            MaxSpeed = (int)nudMaxS.Value;
            Cities = new City[Ncities];
            Highways = new int[Ncities, Ncities];

            CitySetup();
            HighwaySetup();
            iniSetup();

            GenerateConnList();
            CurDistance = GetTotalDistance();
            IniDistance = CurDistance;
            lblDist.Text = CurDistance.ToString() + " px";
            MinDist = CurDistance;
            lblMin.Text = MinDist.ToString() + " px";

            T = 10;
            StaleDist = 0;
            NMTurns = 0;
            Testing = true;
            timTest.Enabled = true;
            
            btnRun.Visible = false;
            btnStop.Visible = true;

            RunT = new Run(RunTest);
            RunT.BeginInvoke(new AsyncCallback(EndTest), null);
            
        }
        delegate void Run();
        public void RunTest()
        {///////////////////////////////////3/3/3/3/3/3/3/3//3///////////////////////3/3/33/
            System.IO.StreamWriter sw = new System.IO.StreamWriter("DataMetro.csv", true);
            
            BoltzFac = chkBoltz.Checked;
            MDraw = new Bitmap(400, 400);
            MockDraw();
            EDraw = new Bitmap(MDraw);
            teDraw = new Bitmap(EDraw);
            IDraw = new Bitmap(MDraw);
            tDraw = new Bitmap(MDraw);
            IDraw.Save("InEffPath.bmp");
            move = 0;
            boltz = 0;
            NMTurns = 0;
            double oDist = 0;
            mTurns = 500;//Math.Exp(Ncities) / 10;
            CurDistance = GetTotalDistance();
            IDist = CurDistance;
            double expT;
            while (StaleDist <= mTurns)
            {
                Swap(BoltzFac);
                //GenerateConnList();
                oDist = CurDistance;
                CurDistance = GetTotalDistance();
                //BoltzFac = chkBoltz.Checked;
                if (oDist != CurDistance)
                {
                    MockDraw();
                }
                
                T = 10;
                iTest = true;
                NMTurns++;
                if (CurDistance < MinDist)
                {
                    
                    StaleDist = 0;
                    EDraw = new Bitmap(MDraw);
                    teDraw = new Bitmap(EDraw);
                    //T = 1000;
                }
                MinDist = Math.Min(CurDistance,MinDist);
                pChange = (MinDist/IniDistance) * 100.0;
                expT = Math.Exp((double)move/30.0);

                tDraw = (Bitmap)MDraw.Clone();
                if (NMTurns == 2000)
                {
                    MDraw.Save("PreMetroEffPath.bmp");
                    PreMetroDist = MinDist;
                    
                }
                else if (NMTurns > 2000)
                {
                    BoltzFac = true;
                }
                Mdrawn = true;
            }
            tDraw = new Bitmap(IDraw);
            FDist = MinDist;
            if (EDraw != null)
            {
                EDraw.Save("EffPath.bmp");
            }
            sw.WriteLine(IDist + "," + PreMetroDist + "," + FDist);
            sw.Close();
            int i = ConnIndx[0];
        }
        public void EndTest(IAsyncResult IAR)
        {
            Testing = false;
            double pBoltz = 100.0*((double)boltz / (double)move);

        }
        public void CitySetup()
        {
            for (int c = 0; c < Ncities; c++)
            {
                Cities[c] = new City();
                Cities[c].Loc.X = (int)(r.NextDouble() * panSales.Width);
                Cities[c].Loc.Y = (int)(r.NextDouble() * panSales.Height);
            }
            //EOF
        }
        public void HighwaySetup()
        {
            for (int c1 = 0; c1 < Ncities; c1++)
            {
                for (int c2 = c1; c2 < Ncities; c2++)
                {
                    int RandSpeed = r.Next(MinSpeed,MaxSpeed+1);
                    Highways[c1, c2] = RandSpeed;
                    Highways[c2, c1] = RandSpeed;
                }
            }
            //EOF
        }
        public void iniSetup()
        {
            int cCity = 0;
            int nCity;
            int cityComp = 0;
            while (cityComp < Ncities-1)
            {
                nCity = r.Next(1, Ncities);
                if (Cities[nCity].Conn1 + Cities[nCity].Conn2 == -3)
                {
                    Cities[nCity].Conn1 = cCity;
                    Cities[cCity].Conn2 = nCity;
                    cCity = nCity;
                    cityComp++;
                }
            }
            Cities[0].Conn1 = cCity;
            Cities[cCity].Conn2 = 0;
            //EOF
        }
        public void GenerateConnList()
        {

            ConnIndx.Clear();
            int city = 0;
            for (int c = 0; c <= Ncities; c++)
            {
                int tcity = Cities[city].Conn1;
                city = tcity;
                ConnIndx.Add(city);
            }
         
            //EOF
            
        }
        public double GetTotalDistance()
        {
            double dist=0;
            for (int c = 0; c < Ncities; c++)
            {
                dist += Math.Sqrt(Math.Pow(Cities[ConnIndx[c]].Loc.X - Cities[ConnIndx[c + 1]].Loc.X, 2) + Math.Pow(Cities[ConnIndx[c]].Loc.Y - Cities[ConnIndx[c + 1]].Loc.Y, 2))/(double)Highways[ConnIndx[c],ConnIndx[c+1]];
            }
            return dist;
        }
        public void Swap(bool BoltzF)
        {
            bool DoSwap = false;

            int s = r.Next(1, Ncities);
            City cS = Cities[s];

            int s1 = cS.Conn1;
            City cS1=Cities[s1];

            int s2 = cS.Conn2;
            City cS2 = Cities[s2];

            int e = r.Next(1, Ncities);
            City cE = Cities[e];
            
            int e1=cE.Conn1;            
            City cE1=Cities[e1];

            //int e2 = cE.Conn2;
            //City cE2 = Cities[e2];

            /*
            double dSE1 = DistanceBetweenCities(cS, cE1);
            double dSE = DistanceBetweenCities(cS, cE);

            double dSS1 = DistanceBetweenCities(cS, cS1);
            double dSS2 = DistanceBetweenCities(cS, cS2);

            double Ef = dSE1 + dSE;
            double Ei = dSS1 + dSS2;
             */
            //GenerateConnList();
            double Ei = GetTotalDistance();

            /*
            //Drop S out of connection
            cS1.Conn2 = s2;
            cS2.Conn1 = s1;

            //Put S back in in between E and E1
            cE.Conn1 = s;
            cS.Conn2 = e;
            cS.Conn1 = e1;
            cE1.Conn2 = s;

            GenerateConnList();
             */
            int temp = ConnIndx[s];
            ConnIndx.RemoveAt(s);
            ConnIndx.Insert(e, temp);

            double Ef = GetTotalDistance();

            if (BoltzF)
            {
                if (Ef > Ei)
                {
                    if (Math.Exp((Ei - Ef) / T) >= r.NextDouble())
                    {
                        DoSwap = true;
                        boltz++;//Should occasionally happen
                    }
                }
            }

            if (Ef < Ei)
            {
                DoSwap = true;
            }

            if (DoSwap)
            {
                //DoSwap = CheckAttach();
            }

            if (DoSwap)
            {
                StaleDist++;
                move++;
            }
            else
            {
                int tempC = ConnIndx[e];
                ConnIndx.RemoveAt(e);
                ConnIndx.Insert(s, tempC);


                /*
                cS1.Conn2 = s;
                cS2.Conn1 = s;


                cE.Conn1 = e1;
                cS.Conn2 = s2;
                cS.Conn1 = s1;
                cE1.Conn2 = e;
                 */ 
            }
            

        }
        public double DistanceBetweenCities(City c1, City c2)
        {
            return Math.Sqrt(Math.Pow(c1.Loc.X - c2.Loc.X, 2) + Math.Pow(c1.Loc.Y - c2.Loc.Y, 2));
        }
        public bool CheckAttach()
        {
            for (int i = 0; i < Ncities; i++)
            {
                int Check = ConnIndx[i];
                for (int j = i+1; j < Ncities; j++)
                {
                    if (ConnIndx[j] == Check)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panSales_Paint(object sender, PaintEventArgs e)
        {
            if (Mdrawn)
            {
                

                    e.Graphics.DrawImage(tDraw, 0, 0);
                
            }

            //EOF

        }
        public void MockDraw()
        {
            GMDraw = Graphics.FromImage(MDraw);
            GMDraw.Clear(Color.Black);
            for (int c = 0; c < Ncities; c++)
            {
                double pSpeed = 2 * 255 * ((Highways[ConnIndx[c], ConnIndx[c + 1]]-MinSpeed+1) / (double)(MaxSpeed-MinSpeed+1));
                Color clr;

                if (pSpeed <= 255)
                {
                    clr = new Color();
                    clr = Color.FromArgb(255, (int)pSpeed, 0);


                }
                else
                {
                    clr = new Color();
                    clr = Color.FromArgb(255 - (int)(pSpeed - 255), 255, 0);

                }
                GMDraw.DrawLine(new Pen(clr), Cities[ConnIndx[c]].Loc, Cities[ConnIndx[c + 1]].Loc);
            }

            for (int c = 0; c < Ncities; c++)
            {
                GMDraw.DrawEllipse(Pens.Blue, (float)(Cities[c].Loc.X - 5), (float)(Cities[c].Loc.Y - 5), 10, 10);
            }
            GMDraw.Dispose();
        }
        //EOC
        public class City
        {
            public Point Loc;
            public int Conn1;
            public int Conn2;
            public City()
            {
                Loc = new Point();
                Conn1 = -1;
                Conn2 = -2;
            }
            public void Reset()
            {
                Conn1 = -1;
                Conn2 = -2;
            }
            
        }

        private void timTest_Tick(object sender, EventArgs e)
        {
            
            if (iTest)
            {
                if (!Testing)
                {
                    
                    if (DoMulti)
                    {
                        RunMulti();
                    }
                    else
                    {
                        if (chkARes.Checked)
                        
                        {
                            chkBoltz.Checked = false;
                            BoltzFac = false;
                            Setup();
                        }
                        else
                        {
                            timTest.Enabled = false;
                            MessageBox.Show("Done!");
                            btnRun.Enabled = true;
                            
                        }
                    }
                }
            }
            chkBoltz.Checked = BoltzFac;
            panSales.Refresh();
            
            panOpt.Refresh();
            lblDist.Text = CurDistance.ToString() + " px";
            lblMin.Text = MinDist.ToString() + " px";
            lblini.Text = IniDistance.ToString() + " px";
            lblpChange.Text = Math.Round(pChange,2).ToString() + "%";
            lblTurns.Text = move.ToString();
            lblStale.Text = (mTurns - StaleDist).ToString();
            
            Random q = new Random(DateTime.Now.Millisecond);
            r = new Random(q.Next(1, 1000));

        }

        private void panSales_Click(object sender, EventArgs e)
        {
            panSales.Refresh();
        }

        private void panOpt_Paint(object sender, PaintEventArgs e)
        {
            if (Mdrawn)
            {
                
                    e.Graphics.DrawImage(teDraw, 0, 0);

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mTurns = -1;
            btnRun.Visible = true;
            btnStop.Visible = false;
        }

        public void RunMulti()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("dataRM.csv");
            sw.WriteLine(curSpeed + ", " + IniDistance + ", " + MinDist + ", " + pChange);


            Ncities = (int)nudCities.Value;
            curSpeed++;
            if (curSpeed > FinSpeed)
            {
                DoMulti = false;
                sw.Close();
                timTest.Enabled = false;
            }
            else
            {
                for (int i = 0; i < Ncities; i++)
                {
                    Cities[i].Reset();
                }
                MaxSpeed = (int)curSpeed;
                HighwaySetup();

                iniSetup();

                GenerateConnList();
                CurDistance = GetTotalDistance();
                IniDistance = CurDistance;
                lblDist.Text = CurDistance.ToString() + " px";
                MinDist = CurDistance;
                lblMin.Text = MinDist.ToString() + " px";

                T = 10;
                StaleDist = 0;
                Testing = true;
                timTest.Enabled = true;

                btnRun.Visible = false;
                btnStop.Visible = true;

                RunT = new Run(RunTest);
                RunT.BeginInvoke(new AsyncCallback(EndTest), null);
            }

        }
        private void runMultipleSameMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiSetup ms = new MultiSetup();
            ms.ShowDialog();
            FinSpeed = ms.LMspeed;
            curSpeed = ms.FMspeed;

            DoMulti = true;

            Ncities = (int)nudCities.Value;

            Cities = new City[Ncities];
            Highways = new int[Ncities, Ncities];

            CitySetup();
            HighwaySetup();

            MaxSpeed = (int)curSpeed;


            iniSetup();

            GenerateConnList();
            CurDistance = GetTotalDistance();
            IniDistance = CurDistance;
            lblDist.Text = CurDistance.ToString() + " px";
            MinDist = CurDistance;
            lblMin.Text = MinDist.ToString() + " px";

            T = 10;
            StaleDist = 0;
            Testing = true;
            timTest.Enabled = true;

            btnRun.Visible = false;
            btnStop.Visible = true;

            RunT = new Run(RunTest);
            RunT.BeginInvoke(new AsyncCallback(EndTest), null);

        }
    }
    //EOP
}
