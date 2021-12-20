using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*
A Simple Cheat Loader I Created Design Isn't Too Crazy But Simple And Nice
Loader Created By KryptoOnFunDip#2800 [OPEN SOURCE]
You May Also Sell, Modify And Release This As Your Own. As I Really Don't Care What You Do With It
Contact Me For Any Help! 
DISCORD : KryptoOnFunDip#2800
*/

namespace Krypted_Loader__SIMPLE_
{
    public partial class Loading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (
        int leftRect,
        int topRect,
        int rightRect,
        int bottomRect,
        int widthEllipse,
        int heightEllipse
        );

        string time = DateTime.Now.ToString("[h:mm:ss]");

        Point lastPoint;

        public Loading()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRect(0, 0, Width, Height, 7, 7));

            ConsoleStart();
        }

        #region UI - Workings
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CopyConsole_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(InfoBox.Text);
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        #endregion

        #region Console Stuff
        public async void ConsoleStart()
        {

            InfoBox.AppendText(string.Format(time + " - Starting Console..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - Console Successfully Started!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Checking If User Is Logged In..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - User Is Logged In!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Welcome User" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - We Will Now Start The Loading Process... Please Be Patient!" + Environment.NewLine));

            await Task.Delay(2000);

            InfoBox.AppendText(string.Format(time + " - Checking Files..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - File's Checked And Verified!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Checking For Error's In Code..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - 42 Error's Found Reloading Console To Possibly Pass Error Test..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.Clear();

            ConsoleReload();

            //InfoBox.AppendText(string.Format(time + " - Loading UI..." + Environment.NewLine));

            //await Task.Delay(5000);

            //InfoBox.AppendText(string.Format(time + " - UI Loaded!" + Environment.NewLine));

            //await Task.Delay(1000);

            //InfoBox.AppendText(string.Format(time + " - Completed All Loading Checks!" + Environment.NewLine));

            //await Task.Delay(1000);
        }

        public async void ConsoleReload()
        {
            InfoBox.AppendText(string.Format(time + " - Console Reloading Due To Error's" + Environment.NewLine));

            await Task.Delay(2000);

            InfoBox.AppendText(string.Format(time + " - Checking Files..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - File's Checked And Verified!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Checking For Error's In Code..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - No Error's Found!" + Environment.NewLine));

            InfoBox.AppendText(string.Format(time + " - Loading UI..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - UI Loaded!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Completed All Loading Checks!" + Environment.NewLine));

            await Task.Delay(1000);

            Main MF = new Main();
            this.Hide();
            MF.ShowDialog();
            this.Close();
        }

        #endregion
    }
}
