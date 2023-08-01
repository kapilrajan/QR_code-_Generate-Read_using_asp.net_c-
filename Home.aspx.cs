using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZXing;

namespace QR_code__Generate_Read_using_asp.netc_
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void QR_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateCode(txtCode.Text);
            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
            }
            finally
            {

                last.Text = "Enter some text";

            }
        }

        protected void QR_Read_Click(object sender, EventArgs e)
        {
            ReadQRCode();
        }

        private void GenerateCode(string name)
        {
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            var result = writer.Write(name);
            string path = Server.MapPath("~/images/kapilQRImage.jpg");
            var barcodeBitmap = new Bitmap(result);


            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    barcodeBitmap.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            imgQRCode.Visible = true;
            imgQRCode.ImageUrl = "~/images/kapilQRImage.jpg";

        }

       
        private void ReadQRCode()
        {
            var reader = new BarcodeReader();
            string filename = Path.Combine(Request.MapPath("~/images"), "kapilQRImage.jpg");
           
            var result = reader.Decode(new Bitmap(filename));
            if (result != null)
            {
                lblQRCode.Text = "QR Code: " + result.Text;
            }
        }


    }
}