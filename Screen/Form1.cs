using System;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Screen
{
  public partial class FenixSearch : Form
  {
    public FenixSearch()
    {
      InitializeComponent();
    }
    static string MyURL = "";
    static string MyPath = "";
    static string Address = "";
    static int count = 70;
    static int sleepTime = 600;
    static String myName;
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {

      Thread ParsThread = new Thread(GetAddress);
      ParsThread.Start();
    }

    private void CopyButton_Click(object sender, EventArgs e)
    {
      Thread Monitor = new Thread(GetLastCopyAddress);
      Monitor.Start();
    }
    public void GetLastCopyAddress()
    {
      Rectangle rect = new Rectangle(300, 100, 1400, 860);
      Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
      Graphics g = Graphics.FromImage(bmp);
      g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
      bmp.Save(MyPath, ImageFormat.Png);
      StreamWriter myURL = new StreamWriter(@"C:\Users\Public\FenixKey.txt", true);
      myURL.WriteLine(MyURL);
      myURL.Close();
    }
    public void GetAddress()
    {
      ChromeOptions chromeOptions = new ChromeOptions();
      chromeOptions.AddArgument(@"user-data-dir=C:\Users\"+Environment.UserName+@"\AppData\Local\Google\Chrome\User Data");
      ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
      for (int value = 0; value < count; value++)
      {//https://prnt.sc/opx1sl
        Address = textBox1.Text;
        string id = value.ToString();
        string pageAddress = "https://prnt.sc/" + Address + id;
        MyURL = pageAddress;
        MyPath = @"C:\Users\Public\pics\" + Address + id + ".png";
        chromeDriver.Navigate().GoToUrl(pageAddress);
        Thread.Sleep(sleepTime);
      }
      chromeDriver.Close();
    }

    private void FenixSearch_Load(object sender, EventArgs e)
    {
      Settings settings = new Settings();
      settings.Show();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      sleepTime = trackBar1.Value * 100;
    }

    private void textBoxValue_Leave(object sender, EventArgs e)
    {
      
    }

    private void textBoxValue_MouseDoubleClick(object sender, MouseEventArgs e)
    {
     
    }

    private void textBoxValue_TextChanged(object sender, EventArgs e)
    {
      if (textBoxValue.Text.Length >= 2)
        count = Convert.ToInt32(textBoxValue.Text);
    }
  }
}
