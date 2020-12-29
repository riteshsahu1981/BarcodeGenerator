
namespace BarcodeGenerator
{
    partial class frmBarchode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarchode));
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioBarCode = new System.Windows.Forms.RadioButton();
            this.radioQRCode = new System.Windows.Forms.RadioButton();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(38, 40);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(102, 23);
            this.lblItemCode.TabIndex = 1;
            this.lblItemCode.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(181, 33);
            this.txtItemCode.MaxLength = 20;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(243, 30);
            this.txtItemCode.TabIndex = 2;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtItemCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemCode_Validating);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(345, 130);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 33);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picBarCode
            // 
            this.picBarCode.Location = new System.Drawing.Point(501, 85);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Size = new System.Drawing.Size(281, 227);
            this.picBarCode.TabIndex = 3;
            this.picBarCode.TabStop = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(497, 40);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(94, 23);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Bar Code";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // radioBarCode
            // 
            this.radioBarCode.AutoSize = true;
            this.radioBarCode.Checked = true;
            this.radioBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBarCode.Location = new System.Drawing.Point(181, 85);
            this.radioBarCode.Name = "radioBarCode";
            this.radioBarCode.Size = new System.Drawing.Size(109, 27);
            this.radioBarCode.TabIndex = 4;
            this.radioBarCode.TabStop = true;
            this.radioBarCode.Text = "2D Code";
            this.radioBarCode.UseVisualStyleBackColor = true;
            this.radioBarCode.CheckedChanged += new System.EventHandler(this.radioBarCode_CheckedChanged);
            // 
            // radioQRCode
            // 
            this.radioQRCode.AutoSize = true;
            this.radioQRCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQRCode.Location = new System.Drawing.Point(310, 85);
            this.radioQRCode.Name = "radioQRCode";
            this.radioQRCode.Size = new System.Drawing.Size(114, 27);
            this.radioQRCode.TabIndex = 4;
            this.radioQRCode.Text = "QR Code";
            this.radioQRCode.UseVisualStyleBackColor = true;
            this.radioQRCode.CheckedChanged += new System.EventHandler(this.radioQRCode_CheckedChanged);
            // 
            // lblCodeType
            // 
            this.lblCodeType.AutoSize = true;
            this.lblCodeType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeType.Location = new System.Drawing.Point(38, 87);
            this.lblCodeType.Name = "lblCodeType";
            this.lblCodeType.Size = new System.Drawing.Size(53, 23);
            this.lblCodeType.TabIndex = 1;
            this.lblCodeType.Text = "Type";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBarchode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 355);
            this.Controls.Add(this.radioQRCode);
            this.Controls.Add(this.radioBarCode);
            this.Controls.Add(this.picBarCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblCodeType);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.btnPrint);
            this.MinimumSize = new System.Drawing.Size(863, 402);
            this.Name = "frmBarchode";
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.frmBarchode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox picBarCode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.RadioButton radioQRCode;
        private System.Windows.Forms.RadioButton radioBarCode;
        private System.Windows.Forms.Label lblCodeType;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

