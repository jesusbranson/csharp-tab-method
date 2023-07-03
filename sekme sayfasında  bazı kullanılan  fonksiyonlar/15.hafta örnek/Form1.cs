namespace _15.hafta_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = colorDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            fontDialog1.ShowColor = true;

            sonuc = fontDialog1.ShowDialog();



            if (sonuc == DialogResult.OK)
            {
                label2.Font = fontDialog1.Font;
                label2.ForeColor = fontDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal; // çalışmıyor

            sonuc = folderBrowserDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                label4.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;

            openFileDialog1.Title = "dosyayı aç ceniz";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "tüm dosyalarrr |*.*| sunu dosyaları|*.pptx";
            openFileDialog1.InitialDirectory = "c:\\";


            sonuc = openFileDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                label5.Text = openFileDialog1.FileName;
            }
        }
    }
}