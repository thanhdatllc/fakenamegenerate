using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HtmlAgilityPack;
using Thanh_Dat_LLC_Frameworks;

namespace Fake_Name_Generator
{
    public partial class FrmMain : Form
    {
        private static readonly Color TitleColorBack = ColorTranslator.FromHtml("#3f51b5");
        //Global variables;
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);

        public FrmMain()
        {
            InitializeComponent();
            InitializeSetting();
        }

        private void InitializeSetting()
        {
            pnMain.BackColor = ColorTranslator.FromHtml("#1B5E20");
            BackColor = TitleColorBack;
            pnTitle.BackColor = TitleColorBack;
            lblTitleMain.Text = $"{Text} - Thanh Dat LLC";
            pnBottom.BackColor = TitleColorBack;
            lblVersion.Text = $"Version: {ProductVersion}";
            cbb_name_set.SelectedIndex = 0;
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true; // _dragging is your variable flag
            _startPoint = new Point(e.X, e.Y);
        }

        private void pnTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
            pnTitle.Cursor = Cursors.Default;
        }

        private void pnTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                pnTitle.Cursor = Cursors.SizeAll;
                var p = PointToScreen(e.Location);
                Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!NetworkFramewords.CheckHostIsAvailabel("fakenamegenerator.com"))
            {
                MessageBox.Show(@"Checking server connection failed");
                return;
            }
            var url = "http://www.fakenamegenerator.com/gen-random-jpja-us.php";
            var index = cbb_name_set.SelectedIndex;
            switch (index)
            {
                case 0:
                    url = "http://www.fakenamegenerator.com/gen-random-jpja-us.php";
                    break;
                case 1:
                    url = "http://www.fakenamegenerator.com/gen-random-us-us.php";
                    break;
                case 2:
                    url = "http://www.fakenamegenerator.com/gen-random-ar-us.php";
                    break;
                case 3:
                    url = "http://www.fakenamegenerator.com/gen-random-zhtw-us.php";
                    break;
                case 4:
                    url = "http://www.fakenamegenerator.com/gen-random-gr-us.php";
                    break;
                case 5:
                    url = "http://www.fakenamegenerator.com/gen-random-rucyr-us.php";
                    break;
                case 6:
                    url = "http://www.fakenamegenerator.com/gen-random-hr-us.php";
                    break;
                case 7:
                    url = "http://www.fakenamegenerator.com/gen-random-fa-us.php";
                    break;
                case 8:
                    url = "http://www.fakenamegenerator.com/gen-random-br-us.php";
                    break;
                case 9:
                    url = "http://www.fakenamegenerator.com/gen-random-cs-us.php";
                    break;
                case 10:
                    url = "http://www.fakenamegenerator.com/gen-random-dk-us.php";
                    break;
                case 11:
                    url = "http://www.fakenamegenerator.com/gen-random-nl-us.php";
                    break;
                case 12:
                    url = "http://www.fakenamegenerator.com/gen-random-fr-us.php";
                    break;
                case 13:
                    url = "http://www.fakenamegenerator.com/gen-random-hu-us.php";
                    break;
                case 14:
                    url = "http://www.fakenamegenerator.com/gen-random-pl-us.php";
                    break;
                case 15:
                    url = "http://www.fakenamegenerator.com/gen-random-th-us.php";
                    break;
                case 16:
                    url = "http://www.fakenamegenerator.com/gen-random-gd-us.php";
                    break;
            }
            var web = new HtmlWeb();
            var document = web.Load(url);
            var node = document.DocumentNode.SelectSingleNode("//div[@class='content']//div[@class='address']//h3");
            var nodes = document.DocumentNode.SelectNodes("//div[@class='extra']//dl//dd").ToArray();
            txt_name.Text = node.InnerText;
            foreach (var item in nodes)
            {
                if (item.InnerText.Contains("@inbound.plus"))
                {
                    var email =
                        $"{item.InnerHtml.Split('@')[0].ToLower()}{StringFramewords.GetRandomString()}@gmail.com";
                    txt_email.Text = email;
                }
            }
        }
    }
}