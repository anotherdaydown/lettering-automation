﻿using System.Windows.Forms;

namespace Lettering.Forms {
    internal partial class LoadingWindow : Form {
        internal LoadingWindow() {
            InitializeComponent();
        }

        internal void SetFilesProgress(string fileName, int fileNumber, int totalFiles) {
            this.labelFileNumber.Text = $"{fileNumber}/{totalFiles}";
            this.labelFilename.Text = fileName;
            this.progressFiles.Maximum = totalFiles;
            this.progressFiles.Value = fileNumber;
        }

        internal void SetLinesProgress(int lineNumber, int totalLines) {
            this.labelLineNumber.Text = $"{lineNumber}/{totalLines}";
            this.progressLines.Maximum = totalLines;
            this.progressLines.Value = lineNumber;
        }
    }
}
