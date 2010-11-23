namespace PDFViewer
{
    partial class frmExportSWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportSWF));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmdChoseFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtPagesRange = new System.Windows.Forms.TextBox();
            this.optPrintCurrent = new System.Windows.Forms.RadioButton();
            this.udTopage = new System.Windows.Forms.NumericUpDown();
            this.udFromPage = new System.Windows.Forms.NumericUpDown();
            this.optFromPage = new System.Windows.Forms.RadioButton();
            this.optPrintAll = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLoaderSWF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtViewerSWF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.udQuality = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.udResolution = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optFullBitmap = new System.Windows.Forms.RadioButton();
            this.optPolyToBitmap = new System.Windows.Forms.RadioButton();
            this.cmdToDefault = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkOpenInNewWindow = new System.Windows.Forms.CheckBox();
            this.chkStoreFonts = new System.Windows.Forms.CheckBox();
            this.chkFontsToShapes = new System.Windows.Forms.CheckBox();
            this.chkAddPageStop = new System.Windows.Forms.CheckBox();
            this.chkEnableLinks = new System.Windows.Forms.CheckBox();
            this.chkIgnoreDrawOrder = new System.Windows.Forms.CheckBox();
            this.chkFlattenSWF = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFlashVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colorPicker1 = new PJLControls.ColorPicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTopage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFromPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolution)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFlashVersion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFileName
            // 
            resources.ApplyResources(this.txtFileName, "txtFileName");
            this.txtFileName.Name = "txtFileName";
            // 
            // cmdChoseFile
            // 
            resources.ApplyResources(this.cmdChoseFile, "cmdChoseFile");
            this.cmdChoseFile.Name = "cmdChoseFile";
            this.cmdChoseFile.UseVisualStyleBackColor = true;
            this.cmdChoseFile.Click += new System.EventHandler(this.cmdChoseFile_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtPagesRange);
            this.groupBox1.Controls.Add(this.optPrintCurrent);
            this.groupBox1.Controls.Add(this.udTopage);
            this.groupBox1.Controls.Add(this.udFromPage);
            this.groupBox1.Controls.Add(this.optFromPage);
            this.groupBox1.Controls.Add(this.optPrintAll);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtPagesRange
            // 
            resources.ApplyResources(this.txtPagesRange, "txtPagesRange");
            this.txtPagesRange.Name = "txtPagesRange";
            // 
            // optPrintCurrent
            // 
            resources.ApplyResources(this.optPrintCurrent, "optPrintCurrent");
            this.optPrintCurrent.Name = "optPrintCurrent";
            this.optPrintCurrent.UseVisualStyleBackColor = true;
            // 
            // udTopage
            // 
            resources.ApplyResources(this.udTopage, "udTopage");
            this.udTopage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTopage.Name = "udTopage";
            this.udTopage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udFromPage
            // 
            resources.ApplyResources(this.udFromPage, "udFromPage");
            this.udFromPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udFromPage.Name = "udFromPage";
            this.udFromPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // optFromPage
            // 
            resources.ApplyResources(this.optFromPage, "optFromPage");
            this.optFromPage.Name = "optFromPage";
            this.optFromPage.UseVisualStyleBackColor = true;
            this.optFromPage.CheckedChanged += new System.EventHandler(this.optFromPage_CheckedChanged);
            // 
            // optPrintAll
            // 
            this.optPrintAll.Checked = true;
            resources.ApplyResources(this.optPrintAll, "optPrintAll");
            this.optPrintAll.Name = "optPrintAll";
            this.optPrintAll.TabStop = true;
            this.optPrintAll.UseVisualStyleBackColor = true;
            this.optPrintAll.CheckedChanged += new System.EventHandler(this.optPrintAll_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pgBar
            // 
            resources.ApplyResources(this.pgBar, "pgBar");
            this.pgBar.Name = "pgBar";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgSave
            // 
            resources.ApplyResources(this.dlgSave, "dlgSave");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLoaderSWF
            // 
            resources.ApplyResources(this.txtLoaderSWF, "txtLoaderSWF");
            this.txtLoaderSWF.Name = "txtLoaderSWF";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtViewerSWF
            // 
            resources.ApplyResources(this.txtViewerSWF, "txtViewerSWF");
            this.txtViewerSWF.Name = "txtViewerSWF";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // udQuality
            // 
            resources.ApplyResources(this.udQuality, "udQuality");
            this.udQuality.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.udQuality.Name = "udQuality";
            this.udQuality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // udResolution
            // 
            resources.ApplyResources(this.udResolution, "udResolution");
            this.udResolution.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udResolution.Minimum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.udResolution.Name = "udResolution";
            this.udResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.optFullBitmap);
            this.groupBox2.Controls.Add(this.optPolyToBitmap);
            this.groupBox2.Controls.Add(this.udQuality);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.udResolution);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // optFullBitmap
            // 
            resources.ApplyResources(this.optFullBitmap, "optFullBitmap");
            this.optFullBitmap.Name = "optFullBitmap";
            this.optFullBitmap.TabStop = true;
            this.optFullBitmap.UseVisualStyleBackColor = true;
            // 
            // optPolyToBitmap
            // 
            resources.ApplyResources(this.optPolyToBitmap, "optPolyToBitmap");
            this.optPolyToBitmap.Name = "optPolyToBitmap";
            this.optPolyToBitmap.TabStop = true;
            this.optPolyToBitmap.UseVisualStyleBackColor = true;
            // 
            // cmdToDefault
            // 
            resources.ApplyResources(this.cmdToDefault, "cmdToDefault");
            this.cmdToDefault.Name = "cmdToDefault";
            this.cmdToDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.cboFlashVersion);
            this.groupBox3.Controls.Add(this.chkOpenInNewWindow);
            this.groupBox3.Controls.Add(this.colorPicker1);
            this.groupBox3.Controls.Add(this.chkStoreFonts);
            this.groupBox3.Controls.Add(this.chkFontsToShapes);
            this.groupBox3.Controls.Add(this.chkAddPageStop);
            this.groupBox3.Controls.Add(this.chkEnableLinks);
            this.groupBox3.Controls.Add(this.chkIgnoreDrawOrder);
            this.groupBox3.Controls.Add(this.chkFlattenSWF);
            this.groupBox3.Controls.Add(this.label9);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chkOpenInNewWindow
            // 
            resources.ApplyResources(this.chkOpenInNewWindow, "chkOpenInNewWindow");
            this.chkOpenInNewWindow.Name = "chkOpenInNewWindow";
            this.chkOpenInNewWindow.UseVisualStyleBackColor = true;
            // 
            // chkStoreFonts
            // 
            resources.ApplyResources(this.chkStoreFonts, "chkStoreFonts");
            this.chkStoreFonts.Name = "chkStoreFonts";
            this.chkStoreFonts.UseVisualStyleBackColor = true;
            // 
            // chkFontsToShapes
            // 
            resources.ApplyResources(this.chkFontsToShapes, "chkFontsToShapes");
            this.chkFontsToShapes.Name = "chkFontsToShapes";
            this.chkFontsToShapes.UseVisualStyleBackColor = true;
            // 
            // chkAddPageStop
            // 
            resources.ApplyResources(this.chkAddPageStop, "chkAddPageStop");
            this.chkAddPageStop.Name = "chkAddPageStop";
            this.chkAddPageStop.UseVisualStyleBackColor = true;
            // 
            // chkEnableLinks
            // 
            resources.ApplyResources(this.chkEnableLinks, "chkEnableLinks");
            this.chkEnableLinks.Name = "chkEnableLinks";
            this.chkEnableLinks.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreDrawOrder
            // 
            resources.ApplyResources(this.chkIgnoreDrawOrder, "chkIgnoreDrawOrder");
            this.chkIgnoreDrawOrder.Name = "chkIgnoreDrawOrder";
            this.chkIgnoreDrawOrder.UseVisualStyleBackColor = true;
            // 
            // chkFlattenSWF
            // 
            resources.ApplyResources(this.chkFlattenSWF, "chkFlattenSWF");
            this.chkFlattenSWF.Name = "chkFlattenSWF";
            this.chkFlattenSWF.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cboFlashVersion
            // 
            resources.ApplyResources(this.cboFlashVersion, "cboFlashVersion");
            this.cboFlashVersion.Name = "cboFlashVersion";
            this.cboFlashVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxEdit1.Properties.Buttons"))))});
            this.cboFlashVersion.Properties.Items.AddRange(new object[] {
            resources.GetString("comboBoxEdit1.Properties.Items"),
            resources.GetString("comboBoxEdit1.Properties.Items1"),
            resources.GetString("comboBoxEdit1.Properties.Items2"),
            resources.GetString("comboBoxEdit1.Properties.Items3")});
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // colorPicker1
            // 
            this.colorPicker1.DisplayColorName = true;
            resources.ApplyResources(this.colorPicker1, "colorPicker1");
            this.colorPicker1.Name = "colorPicker1";
            // 
            // frmExportSWF
            // 
            this.AcceptButton = this.btnExport;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdToDefault);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtViewerSWF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLoaderSWF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdChoseFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "frmExportSWF";
            this.Load += new System.EventHandler(this.frmExportSWF_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExportJpg_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTopage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFromPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolution)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFlashVersion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button cmdChoseFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown udTopage;
        private System.Windows.Forms.NumericUpDown udFromPage;
        private System.Windows.Forms.RadioButton optFromPage;
        private System.Windows.Forms.RadioButton optPrintAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.RadioButton optPrintCurrent;
        private System.Windows.Forms.TextBox txtPagesRange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLoaderSWF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtViewerSWF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown udQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udResolution;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optFullBitmap;
        private System.Windows.Forms.RadioButton optPolyToBitmap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdToDefault;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkOpenInNewWindow;
        private PJLControls.ColorPicker colorPicker1;
        private System.Windows.Forms.CheckBox chkStoreFonts;
        private System.Windows.Forms.CheckBox chkFontsToShapes;
        private System.Windows.Forms.CheckBox chkAddPageStop;
        private System.Windows.Forms.CheckBox chkEnableLinks;
        private System.Windows.Forms.CheckBox chkIgnoreDrawOrder;
        private System.Windows.Forms.CheckBox chkFlattenSWF;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboFlashVersion;
    }
}