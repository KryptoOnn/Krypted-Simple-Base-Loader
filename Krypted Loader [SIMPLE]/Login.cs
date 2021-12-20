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
using System.Runtime.InteropServices;
using Krypted_Loader__SIMPLE_;

/*
A Simple Cheat Loader I Created Design Isn't Too Crazy But Simple And Nice
Loader Created By KryptoOnFunDip#2800 [OPEN SOURCE]
You May Also Sell, Modify And Release This As Your Own. As I Really Don't Care What You Do With It
Contact Me For Any Help! 
DISCORD : KryptoOnFunDip#2800
*/

namespace Krypted_Loader_Simple
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRect(0, 0, Width, Height, 7, 7));

            ConsoleStart();
        }

        #region ConsoleStuff
        public async void ConsoleStart()
        {
            LoginButton.Enabled = false;

            UsernameBox.Enabled = false;

            PasswordBox.Enabled = false;

            InfoBox.AppendText(string.Format(time + " - Console Reloading..." + Environment.NewLine));

            await Task.Delay(5000);

            InfoBox.AppendText(string.Format(time + " - Console Successfully Loaded!" + Environment.NewLine));

            await Task.Delay(1000);

            InfoBox.AppendText(string.Format(time + " - Waiting For User To Login" + Environment.NewLine));

            LoginButton.Enabled = true;

            UsernameBox.Enabled = true;

            PasswordBox.Enabled = true;
        }

        public async void ConsoleReload()
        {
            InfoBox.AppendText(string.Format(time + " - Login Was Incorrect! Or You Didn't Input A Username" + Environment.NewLine));

            await Task.Delay(2000);

            InfoBox.AppendText(string.Format(time + " - Please Try Again..." + Environment.NewLine));

            await Task.Delay(2000);

            InfoBox.Clear();

            ConsoleStart();
        }

        #endregion

        #region UI - Workings

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameget = UsernameBox.Text;

            LoginButton.Enabled = false;

            UsernameBox.Enabled = false;

            PasswordBox.Enabled = false;

            if (UsernameBox.Text == "")
            {
                InfoBox.AppendText(string.Format(time + " - Username Box Cannot Be Left Empty!" + Environment.NewLine));

                InfoBox.Clear();

                ConsoleReload();
            }
            else if (PasswordBox.Text == "123")
            {
                InfoBox.AppendText(string.Format(time + " - Checking..." + Environment.NewLine));

                await Task.Delay(3000);

                InfoBox.AppendText(string.Format(time + " - Login Correct!" + Environment.NewLine));

                await Task.Delay(2000);

                InfoBox.AppendText(string.Format(time + " - Welcome " + usernameget + Environment.NewLine));

                InfoBox.AppendText(string.Format(time + " - Please Wait Loading..." + Environment.NewLine));

                await Task.Delay(2000);

                Loading LD = new Loading();
                this.Hide();
                LD.ShowDialog();
                this.Close();
            }
            else
            {

                InfoBox.AppendText(string.Format(time + " - Checking..." + Environment.NewLine));

                await Task.Delay(3000);

                UsernameBox.Clear();
                PasswordBox.Clear();
                InfoBox.Clear();
                ConsoleReload();

                LoginButton.Enabled = true;

                UsernameBox.Enabled = true;

                PasswordBox.Enabled = true;
            }
        }
    }
}
