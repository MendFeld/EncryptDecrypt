using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = Eramake.eCryptography.Encrypt(txtValue.Text);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = Ermake.eCryptograghy.Decrypt(txtEncrypt.Text);
        }
    }
}
