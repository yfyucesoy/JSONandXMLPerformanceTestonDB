using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace VTYS_proje
{


    public partial class Form1 : Form
    {
        Robot robot1 = new Robot("Robot1", 1);
        Robot robot2 = new Robot("Robot2", 2);
        Robot robot3 = new Robot("Robot3", 3);
        Robot robot4 = new Robot("Robot4", 4);
        Robot robot5 = new Robot("Robot5", 5);

        

        void pageSelect(Button selected)
        {
            panelSelect.Height = selected.Height;
            panelSelect.Top = selected.Top;

        }

        public Form1()
        {
            InitializeComponent();
            pageSelect(btnHome);
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void btnRobotCtrl_Click(object sender, EventArgs e)
        {
            pageSelect(btnRobotCtrl);
            tabControl1.SelectedIndex = 1;
        }

        private void btnUserCtrl_Click(object sender, EventArgs e)
        {
            pageSelect(btnUserCtrl);
            tabControl1.SelectedIndex = 2;
        }

        private void btnDataCtrl_Click(object sender, EventArgs e)
        {
            pageSelect(btnDataCtrl);
            tabControl1.SelectedIndex = 3;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pageSelect(btnHome);
            tabControl1.SelectedIndex = 0;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRobotEkle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgv.ForeColor = Color.Black;
            dgv.Rows.Add("Robot1", "Durdu");
            dgv.Rows.Add("Robot2", "Durdu");
            dgv.Rows.Add("Robot3", "Durdu");
            dgv.Rows.Add("Robot4", "Durdu");
            dgv.Rows.Add("Robot5", "Durdu");
            

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "admin" && tbPass.Text == "admin")
            {
                pnlLogin.Visible = false;
            }
            else
            {
                lbYanlis.Visible = true;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRobotBaslat_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Durum"].Value);

                if(a == "Durdu")
                {
                    if(selectedrowindex == 0)
                        robot1.run();
                    else if (selectedrowindex == 1)
                        robot2.run();
                    else if (selectedrowindex == 2)
                        robot3.run();
                    else if (selectedrowindex == 3)
                        robot4.run();
                    else if (selectedrowindex == 4)
                        robot5.run();

                    selectedRow.Cells["Durum"].Value = "Calisiyor";
                }

            }
        }

        private void btnRobotDurdur_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Durum"].Value);

                if (a == "Calisiyor")
                {
                    if (selectedrowindex == 0)
                        robot1.rbthread1.Suspend();
                    else if (selectedrowindex == 1)
                        robot2.rbthread1.Suspend();
                    else if (selectedrowindex == 2)
                        robot3.rbthread1.Suspend();
                    else if (selectedrowindex == 3)
                        robot4.rbthread1.Suspend();
                    else if (selectedrowindex == 4)
                        robot5.rbthread1.Suspend();

                    selectedRow.Cells["Durum"].Value = "Durdu";
                }

            }
        }

        private void btnTekParca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8NQ7HV\;Initial Catalog=SmartFactory;Trusted_Connection=Yes;");
            conn.Open();
            SqlCommand command = new SqlCommand("JSON_YAZ", conn);
            DateTime ilkSure = DateTime.Now;
            command.ExecuteNonQuery();
            TimeSpan sonSure = DateTime.Now - ilkSure;
            TekParcaEkleSure.Text = "Süre: " + sonSure.TotalMilliseconds.ToString() + "ms";
            conn.Close();
        }

        private void btnAyri_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8NQ7HV\;Initial Catalog=SmartFactory;Trusted_Connection=Yes;");
            conn.Open();
            SqlCommand command = new SqlCommand("TABLO_YAZ", conn);
            DateTime ilkSure = DateTime.Now;
            command.ExecuteNonQuery();
            TimeSpan sonSure = DateTime.Now - ilkSure;
            SutunlaraAyirEkleSure.Text = "Süre: " + sonSure.TotalMilliseconds.ToString() + "ms";
            conn.Close();
        }

        private void btnTekParcadanOku_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8NQ7HV\;Initial Catalog=SmartFactory;Trusted_Connection=Yes;");
            conn.Open();
            SqlCommand command = new SqlCommand("JSON_OKU", conn);
            DateTime ilkSure = DateTime.Now;
            command.ExecuteNonQuery();
            TimeSpan sonSure = DateTime.Now - ilkSure;
            lbTekParcadanOku.Text = "Süre: " + sonSure.TotalMilliseconds.ToString() + "ms";
            conn.Close();
        }

        private void btnSutunlardanOku_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K8NQ7HV\;Initial Catalog=SmartFactory;Trusted_Connection=Yes;");
            conn.Open();
            SqlCommand command = new SqlCommand("TABLO_OKU", conn);
            DateTime ilkSure = DateTime.Now;
            command.ExecuteNonQuery();
            TimeSpan sonSure = DateTime.Now - ilkSure;
            lbSutunlardanOku.Text = "Süre: " + sonSure.TotalMilliseconds.ToString() + "ms";
            conn.Close();
        }
    }
    
}
