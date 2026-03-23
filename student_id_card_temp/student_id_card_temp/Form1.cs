using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace student_id_card_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStudentData();
        }

        //private void MakePictureBoxRound(PictureBox pictureBox)
        //    {
        //        GraphicsPath gp = new GraphicsPath();
        //        gp.AddEllipse(0, 0, pictureBox.Width - 4, pictureBox.Height - 4);
        //        Region rg = new Region(gp);
        //        pictureBox.Region = rg;
        //    }

        private void LoadStudentData()
        {
            string filePath = "student_data.csv";
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Error student-data.csv file not found!");
                    MessageBox.Show("Looking for file in: " + Directory.GetCurrentDirectory());
                    return;
                }
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Error student-data.csv is empty!");
                    return;
                }
                string[] data = lines[lines.Length - 1].Split(',');
                if (data.Length >= 6)
                {
                    textBox1.Text = data[0];
                    textBox2.Text = data[1];
                    textBox3.Text = data[2];
                    textBox4.Text = data[3];
                    textBox5.Text = data[4];
                    textBox6.Text = data[5];
                    pictureBox1.ImageLocation = data[6];
                }
                else
                {
                    MessageBox.Show("Error Insufficient data!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading:" + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            //     MakePictureBoxRound(pictureBox1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
