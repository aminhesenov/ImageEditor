using System.Drawing.Drawing2D;

namespace ImageEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                string filePath = openFileDialog.FileName;
                bmp = new Bitmap(filePath);
                pictureBox1.Image = bmp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // bmp = new Bitmap(pictureBox1.Image);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush liner = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 225, 128, 172), Color.FromArgb(50, 52, 58, 178));
            gr.FillRectangle(liner, new Rectangle(0, 0, bmp.Width, bmp.Height));

            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv= new SaveFileDialog();
            if (DialogResult.OK == sv.ShowDialog())
            {
                string path= sv.FileName;
                bmp.Save(path);
                MessageBox.Show("Image save", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
