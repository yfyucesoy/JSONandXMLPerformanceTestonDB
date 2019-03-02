using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace VTYS_proje
{
    class Robot
    {
        public static List<String> logOut = new List<string>();
        private int robotid;
        public Thread rbthread1;
        private String isim;
        private double hiz = 0;
        private double yon = 0;
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int trgx = 0;
        private int trgy = 0;
        private int trgz = 0;
        private double pil = 100;
        private DateTime ilkSure;
        private TimeSpan sonSure;
        private double islemSure;
        private DateTime isBasi;
        private DateTime logDate;
        public Robot(string isim, int robotid)
        {
            this.robotid = robotid;
            this.isim = isim;
            isBasi = DateTime.Now;
            rbthread1 = new Thread(perform);
            rbthread1.Start();
            rbthread1.Suspend();
        }
        public void SetTarget(int x, int y, int z = 0)
        {
            this.trgx = x * 10;
            this.trgy = y * 10;
            this.trgz = z * 10;
        }
        public void stop()
        {
            bool tf = false;
            File.AppendAllText(@"MomentaryData.txt", "[");
            foreach (var item in logOut)
            {
                if (tf)
                {
                    File.AppendAllText(@"MomentaryData.txt", ",");
                }
                File.AppendAllText(@"MomentaryData.txt", item);
                tf = true;
            }
            File.AppendAllText(@"MomentaryData.txt", "\n]");


        }
        public void run()
        {

            rbthread1.Resume();
        }
        public void perform()
        {
            double xx;
            double yy;
            while (true)
            {
                ilkSure = DateTime.Now;
                yon = 0;
                while (x < trgx)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    x += 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                ilkSure = DateTime.Now;
                yon = 180;
                while (x > trgx)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    x -= 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                ilkSure = DateTime.Now;
                yon = 90;
                while (y < trgy)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    y += 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                ilkSure = DateTime.Now;
                yon = 270;
                while (y > trgy)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    y -= 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                ilkSure = DateTime.Now;
                while (z < trgz)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    z += 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                ilkSure = DateTime.Now;
                while (z > trgz)
                {
                    System.Threading.Thread.Sleep(1000);
                    sonSure = DateTime.Now - ilkSure;
                    ilkSure = DateTime.Now;
                    String[] times = (sonSure.ToString()).Split(':');
                    islemSure = Convert.ToDouble(times[2]);
                    z -= 1;
                    hiz = 1000000 / islemSure;

                    Console.WriteLine(isim + " : " + hiz.ToString("0.00") + "m/sn    pil : " + pil.ToString("000.0") + "   x = " + x + "   y = " + y);
                    logDate = DateTime.Now;
                    xx = Convert.ToDouble(x) / 10;
                    yy = Convert.ToDouble(y) / 10;
                    logOut.Add("\n  {\n    \"Speed\": 0." + Convert.ToInt32(hiz* 100) + ",\n    \"Location\": \"" + xx + "|" + yy + "|0\",\n    \"Battery\": " + Convert.ToInt32(pil) + ",\n    \"LogTime\": \"" + logDate + "\",\n    \"RobotRobot_ID\": " + robotid + "\n  }");
                    pil -= 0.01;
                }
                if (pil < 25 && x == 0 && y == 0)
                {
                    pil = 100;
                }
                else if (pil < 25)
                {
                    SetTarget(0, 0);
                    perform();
                }
                else
                {
                    Random rast = new Random();
                    int sayi1 = 5*rast.Next(3);
                    rast = new Random();
                    int sayi2 = 5*rast.Next(3);
                    SetTarget(sayi1, sayi2);
                }
            }
        }
    }
}
