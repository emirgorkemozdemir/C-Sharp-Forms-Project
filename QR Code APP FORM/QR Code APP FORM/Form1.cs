using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingToolkit.QRCode.Codec;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Code_APP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnencode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();

            pictureBox1.Image = encoder.Encode(txtboxinput.Text);
        }

        private void btndecode_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();

            txtboxinput.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }
    }
}
