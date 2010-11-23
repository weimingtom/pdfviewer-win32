using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFViewer
{
    public partial class frmExportSWF : Form
    {
        PDFLibNet.PDFWrapper _doc;
        private bool _bCancel = false;
        public delegate bool ProgressInvoker(int pageCount, int currentPage);
        public delegate void FinishedInvoker();

        public frmExportSWF(PDFLibNet.PDFWrapper doc, string fileName)
        {
            InitializeComponent();
            txtFileName.Text = fileName;
            _doc = doc;
            udTopage.Maximum = _doc.PageCount;
            udFromPage.Maximum = _doc.PageCount - 1;
            udTopage.Value = _doc.PageCount;
        }

        private bool UpdateProgress(int pageCount, int currentPage)
        {
            pgBar.Maximum = pageCount;
            pgBar.Value = currentPage;
            return true;
        }
        private void Finished()
        {
            if (!_bCancel)
                MessageBox.Show(Resources.UIStrings.MsgExportFinished, Text,  MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                this.Close();
            btnExport.Enabled = true;
            btnCancel.Enabled = true;
            cmdChoseFile.Enabled = true;

            _doc.ExportJpgProgress -= new PDFLibNet.ExportJpgProgressHandler(_doc_ExportJpgProgress);
            _doc.ExportJpgFinished -= new PDFLibNet.ExportJpgFinishedHandler(_doc_ExportJpgFinished);
        }

        void _doc_ExportJpgFinished()
        {
            Invoke(new FinishedInvoker(Finished));
        }

        bool _doc_ExportJpgProgress(int pageCount, int currentPage)
        {
            return (bool)Invoke(new ProgressInvoker(UpdateProgress), pageCount, currentPage);
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdChoseFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlgSave.FileName;
                btnExport.Enabled = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnExport.Enabled)
                Close();
            else
            {
                _bCancel = true;
                btnCancel.Enabled = false;
                _doc.CancelJpgExport();
            }
        }

        private void optPrintAll_CheckedChanged(object sender, EventArgs e)
        {
            udFromPage.Enabled = optFromPage.Checked;
            udTopage.Enabled = optFromPage.Checked;
        }

        private void frmExportJpg_FormClosing(object sender, FormClosingEventArgs e)
        {
            _doc.ExportJpgProgress -= new PDFLibNet.ExportJpgProgressHandler(_doc_ExportJpgProgress);
            _doc.ExportJpgFinished -= new PDFLibNet.ExportJpgFinishedHandler(_doc_ExportJpgFinished);
        }

        private void optFromPage_CheckedChanged(object sender, EventArgs e)
        {
            udFromPage.Enabled = optFromPage.Checked;
            udTopage.Enabled = optFromPage.Checked;
        }

        private void udQuality_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmExportSWF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                this.txtLoaderSWF.Text = dlgSave.FileName;
                btnExport.Enabled = System.IO.File.Exists(txtViewerSWF.Text) && System.IO.File.Exists(txtLoaderSWF.Text) && !string.IsNullOrEmpty(txtFileName.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                this.txtViewerSWF.Text = dlgSave.FileName;
                btnExport.Enabled = System.IO.File.Exists(txtViewerSWF.Text) && System.IO.File.Exists(txtLoaderSWF.Text) && !string.IsNullOrEmpty(txtFileName.Text);
            }
        }
    }
}