﻿using System;
using System.Windows.Forms;

namespace Lettering {
    internal partial class MainWindow : Form {
        internal MainWindow() {
            InitializeComponent();
        }

        internal void MoveToTop() {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void btnCsvAutomation_Click(object sender, EventArgs e) {
            Lettering.AutomateCsv();
        }

        private void btnCutAutomation_Click(object sender, EventArgs e) {
            DateTime? startDate = null;
            if(datePickerStart.Checked) {
                startDate = datePickerStart.Value;
            }

            DateTime? endDate = null;
            if(datePickerEnd.Checked) {
                endDate = datePickerEnd.Value;
            }

            Lettering.AutomateReport(startDate, endDate);
        }

        private void btnCheckSetup_Click(object sender, EventArgs e) {
            if(Lettering.CheckMacroSetup()) {
                Messenger.Show("Setup is Ok!");
            }
        }

        private void btnCutReport_Click(object sender, EventArgs e) {
            ExportReport(LetteringType.Cut);
        }

        private void btnSewReport_Click(object sender, EventArgs e) {
            ExportReport(LetteringType.Sew);
        }

        private void btnStoneReport_Click(object sender, EventArgs e) {
            ExportReport(LetteringType.Stone);
        }

        private void btnASFReport_Click(object sender, EventArgs e)
        {
            ExportReport(LetteringType.ASFStone);
        }

        private void btnPHTReport_Click(object sender, EventArgs e)
        {
            ExportReport(LetteringType.PHT);
        }

        
        private void ExportReport(LetteringType type) {
            DateTime? startDate = null;
            if(datePickerStart.Checked) {
                startDate = datePickerStart.Value;
            }

            DateTime? endDate = null;
            if(datePickerEnd.Checked) {
                endDate = datePickerEnd.Value;
            }

            Lettering.ExportReport(type, startDate, endDate);
        }

        private void loadAllConfigsToolStripMenuItem_Click(object sender, EventArgs e) {
            Lettering.LoadAllConfigs();
        }

        private void checkFontsToolStripMenuItem_Click(object sender, EventArgs e) {
            Lettering.CheckFonts();
        }

        private void viewErrorLogToolStripMenuItem1_Click(object sender, EventArgs e) {
            Messenger.ShowErrorLog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void editConfigsToolStripMenuItem_Click(object sender, EventArgs e) {
            Lettering.LaunchConfigEditor();
        }
    }
}
