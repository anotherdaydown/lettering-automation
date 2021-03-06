﻿namespace Lettering {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllConfigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewErrorLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCutAutomation = new System.Windows.Forms.Button();
            this.btnCutReport = new System.Windows.Forms.Button();
            this.btnSewReport = new System.Windows.Forms.Button();
            this.btnStoneReport = new System.Windows.Forms.Button();
            this.btnCsvAutomation = new System.Windows.Forms.Button();
            this.btnCheckMacroSetup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnASFReport = new System.Windows.Forms.Button();
            this.btnPHTReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAllConfigsToolStripMenuItem,
            this.editConfigsToolStripMenuItem,
            this.checkFontsToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewErrorLogToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadAllConfigsToolStripMenuItem
            // 
            this.loadAllConfigsToolStripMenuItem.Name = "loadAllConfigsToolStripMenuItem";
            this.loadAllConfigsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadAllConfigsToolStripMenuItem.Text = "&Load All Configs";
            this.loadAllConfigsToolStripMenuItem.Click += new System.EventHandler(this.loadAllConfigsToolStripMenuItem_Click);
            // 
            // editConfigsToolStripMenuItem
            // 
            this.editConfigsToolStripMenuItem.Name = "editConfigsToolStripMenuItem";
            this.editConfigsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editConfigsToolStripMenuItem.Text = "Edit &Configs";
            this.editConfigsToolStripMenuItem.Click += new System.EventHandler(this.editConfigsToolStripMenuItem_Click);
            // 
            // checkFontsToolStripMenuItem
            // 
            this.checkFontsToolStripMenuItem.Name = "checkFontsToolStripMenuItem";
            this.checkFontsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.checkFontsToolStripMenuItem.Text = "Check &Fonts";
            this.checkFontsToolStripMenuItem.Click += new System.EventHandler(this.checkFontsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // viewErrorLogToolStripMenuItem1
            // 
            this.viewErrorLogToolStripMenuItem1.Name = "viewErrorLogToolStripMenuItem1";
            this.viewErrorLogToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.viewErrorLogToolStripMenuItem1.Text = "&View Error Log";
            this.viewErrorLogToolStripMenuItem1.Click += new System.EventHandler(this.viewErrorLogToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date:";
            // 
            // datePickerStart
            // 
            this.datePickerStart.Checked = false;
            this.datePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerStart.Location = new System.Drawing.Point(83, 27);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.ShowCheckBox = true;
            this.datePickerStart.Size = new System.Drawing.Size(99, 20);
            this.datePickerStart.TabIndex = 4;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Checked = false;
            this.datePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEnd.Location = new System.Drawing.Point(253, 27);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.ShowCheckBox = true;
            this.datePickerEnd.Size = new System.Drawing.Size(97, 20);
            this.datePickerEnd.TabIndex = 5;
            // 
            // btnCutAutomation
            // 
            this.btnCutAutomation.Location = new System.Drawing.Point(41, 60);
            this.btnCutAutomation.Name = "btnCutAutomation";
            this.btnCutAutomation.Size = new System.Drawing.Size(141, 29);
            this.btnCutAutomation.TabIndex = 6;
            this.btnCutAutomation.Text = "Cut Lettering Automation";
            this.btnCutAutomation.UseVisualStyleBackColor = true;
            this.btnCutAutomation.Click += new System.EventHandler(this.btnCutAutomation_Click);
            // 
            // btnCutReport
            // 
            this.btnCutReport.Location = new System.Drawing.Point(193, 60);
            this.btnCutReport.Name = "btnCutReport";
            this.btnCutReport.Size = new System.Drawing.Size(141, 29);
            this.btnCutReport.TabIndex = 7;
            this.btnCutReport.Text = "Cut Lettering Report";
            this.btnCutReport.UseVisualStyleBackColor = true;
            this.btnCutReport.Click += new System.EventHandler(this.btnCutReport_Click);
            // 
            // btnSewReport
            // 
            this.btnSewReport.Location = new System.Drawing.Point(193, 95);
            this.btnSewReport.Name = "btnSewReport";
            this.btnSewReport.Size = new System.Drawing.Size(141, 29);
            this.btnSewReport.TabIndex = 8;
            this.btnSewReport.Text = "Sew Report";
            this.btnSewReport.UseVisualStyleBackColor = true;
            this.btnSewReport.Click += new System.EventHandler(this.btnSewReport_Click);
            // 
            // btnStoneReport
            // 
            this.btnStoneReport.Location = new System.Drawing.Point(193, 130);
            this.btnStoneReport.Name = "btnStoneReport";
            this.btnStoneReport.Size = new System.Drawing.Size(141, 29);
            this.btnStoneReport.TabIndex = 9;
            this.btnStoneReport.Text = "Stone/Sequin Report";
            this.btnStoneReport.UseVisualStyleBackColor = true;
            this.btnStoneReport.Click += new System.EventHandler(this.btnStoneReport_Click);
            // 
            // btnCsvAutomation
            // 
            this.btnCsvAutomation.Location = new System.Drawing.Point(41, 95);
            this.btnCsvAutomation.Name = "btnCsvAutomation";
            this.btnCsvAutomation.Size = new System.Drawing.Size(141, 29);
            this.btnCsvAutomation.TabIndex = 10;
            this.btnCsvAutomation.Text = "CSV Automation";
            this.btnCsvAutomation.UseVisualStyleBackColor = true;
            this.btnCsvAutomation.Click += new System.EventHandler(this.btnCsvAutomation_Click);
            // 
            // btnCheckMacroSetup
            // 
            this.btnCheckMacroSetup.Location = new System.Drawing.Point(53, 133);
            this.btnCheckMacroSetup.Name = "btnCheckMacroSetup";
            this.btnCheckMacroSetup.Size = new System.Drawing.Size(115, 23);
            this.btnCheckMacroSetup.TabIndex = 11;
            this.btnCheckMacroSetup.Text = "Check Macro Setup";
            this.btnCheckMacroSetup.UseVisualStyleBackColor = true;
            this.btnCheckMacroSetup.Click += new System.EventHandler(this.btnCheckSetup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Date:";
            // 
            // btnASFReport
            // 
            this.btnASFReport.Location = new System.Drawing.Point(193, 165);
            this.btnASFReport.Name = "btnASFReport";
            this.btnASFReport.Size = new System.Drawing.Size(141, 29);
            this.btnASFReport.TabIndex = 14;
            this.btnASFReport.Text = "ASF Report";
            this.btnASFReport.UseVisualStyleBackColor = true;
            this.btnASFReport.Click += new System.EventHandler(this.btnASFReport_Click);
            // 
            // btnPHTReport
            // 
            this.btnPHTReport.Location = new System.Drawing.Point(41, 165);
            this.btnPHTReport.Name = "btnPHTReport";
            this.btnPHTReport.Size = new System.Drawing.Size(141, 29);
            this.btnPHTReport.TabIndex = 15;
            this.btnPHTReport.Text = "PHT Lettering Report";
            this.btnPHTReport.UseVisualStyleBackColor = true;
            this.btnPHTReport.Click += new System.EventHandler(this.btnPHTReport_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 209);
            this.Controls.Add(this.btnPHTReport);
            this.Controls.Add(this.btnASFReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckMacroSetup);
            this.Controls.Add(this.btnCsvAutomation);
            this.Controls.Add(this.btnStoneReport);
            this.Controls.Add(this.btnSewReport);
            this.Controls.Add(this.btnCutReport);
            this.Controls.Add(this.btnCutAutomation);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lettering";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConfigsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllConfigsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Button btnCutAutomation;
        private System.Windows.Forms.Button btnCutReport;
        private System.Windows.Forms.Button btnSewReport;
        private System.Windows.Forms.Button btnStoneReport;
        private System.Windows.Forms.Button btnCsvAutomation;
        private System.Windows.Forms.Button btnCheckMacroSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem checkFontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogToolStripMenuItem1;
        private System.Windows.Forms.Button btnASFReport;
        private System.Windows.Forms.Button btnPHTReport;
    }
}