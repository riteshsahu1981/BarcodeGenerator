using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public partial class frmBarchode : Form
    {
        string barcodeType;
        public frmBarchode()
        {
            InitializeComponent();
        }

        private void frmBarchode_Load(object sender, EventArgs e)
        {
            lblBarcode.Visible = false;
            barcodeType = "2D";
            lblBarcode.Text = "2D Code";
        }



        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemCode.Text))
            {
                e.Cancel = true;
                txtItemCode.Focus();
                errorProviderApp.SetError(txtItemCode, "Item Code should not be left blank!");
                lblBarcode.Visible = false;

            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtItemCode, "");
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            picBarCode.Image = null;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show(txtItemCode.Text, "Demo App - Message!");

                lblBarcode.Visible = true;
                if (barcodeType == "2D")
                {
                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    picBarCode.Image = barcode.Draw(txtItemCode.Text, 50);
                }
                else
                {
                    Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    picBarCode.Image = barcode.Draw(txtItemCode.Text, 50);
                }


            }
        }

        private void radioBarCode_CheckedChanged(object sender, EventArgs e)
        {
            barcodeType = "2D";
            lblBarcode.Text = "2D Code";
            txtItemCode_TextChanged(sender, e);
        }

        private void radioQRCode_CheckedChanged(object sender, EventArgs e)
        {
            barcodeType = "QR";
            lblBarcode.Text = "QR Code";
            txtItemCode_TextChanged(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("Hello World!!", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10,10));
            e.Graphics.DrawImage(picBarCode.Image, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
                
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                /*printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 2.0;
                printPreviewDialog1.ShowDialog();
                */

                printDocument1.Print();

                /*PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                pd.Document = printDocument1;
                pd.AllowSelection = true;
                pd.AllowCurrentPage = true;
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    printDocument1.Print();
                }*/
            }
            else {
                txtItemCode_TextChanged(sender, e);
            }
        }
    }
         
}
