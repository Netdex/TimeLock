namespace TimeLock
{
    partial class TimeLock
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpChainGenerationControls = new System.Windows.Forms.GroupBox();
            this.progressBarChain = new System.Windows.Forms.ProgressBar();
            this.btnChainLock = new System.Windows.Forms.Button();
            this.btnChainInterrupt = new System.Windows.Forms.Button();
            this.lblEncryptProgress = new System.Windows.Forms.Label();
            this.grpChainGenerationOptions = new System.Windows.Forms.GroupBox();
            this.btnChainChooseSave = new System.Windows.Forms.Button();
            this.txtChainSaveLocation = new System.Windows.Forms.TextBox();
            this.nmbEncryptSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbEncryptThreads = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpEncryptOutput = new System.Windows.Forms.GroupBox();
            this.txtEncryptOutput = new System.Windows.Forms.RichTextBox();
            this.grpEncryptControls = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.grpEncryptOptions = new System.Windows.Forms.GroupBox();
            this.txtPlaintext = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpChainGenerationControls.SuspendLayout();
            this.grpChainGenerationOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptThreads)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.grpEncryptOutput.SuspendLayout();
            this.grpEncryptControls.SuspendLayout();
            this.grpEncryptOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaintext";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 558);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpChainGenerationControls);
            this.tabPage3.Controls.Add(this.grpChainGenerationOptions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(695, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Chain";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpChainGenerationControls
            // 
            this.grpChainGenerationControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChainGenerationControls.Controls.Add(this.progressBarChain);
            this.grpChainGenerationControls.Controls.Add(this.btnChainLock);
            this.grpChainGenerationControls.Controls.Add(this.btnChainInterrupt);
            this.grpChainGenerationControls.Controls.Add(this.lblEncryptProgress);
            this.grpChainGenerationControls.Location = new System.Drawing.Point(8, 86);
            this.grpChainGenerationControls.Name = "grpChainGenerationControls";
            this.grpChainGenerationControls.Size = new System.Drawing.Size(679, 97);
            this.grpChainGenerationControls.TabIndex = 20;
            this.grpChainGenerationControls.TabStop = false;
            this.grpChainGenerationControls.Text = "Chain Generation Controls";
            // 
            // progressBarChain
            // 
            this.progressBarChain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarChain.Location = new System.Drawing.Point(6, 48);
            this.progressBarChain.Name = "progressBarChain";
            this.progressBarChain.Size = new System.Drawing.Size(667, 23);
            this.progressBarChain.TabIndex = 17;
            // 
            // btnChainLock
            // 
            this.btnChainLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChainLock.BackColor = System.Drawing.Color.Lime;
            this.btnChainLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChainLock.Location = new System.Drawing.Point(598, 19);
            this.btnChainLock.Name = "btnChainLock";
            this.btnChainLock.Size = new System.Drawing.Size(75, 23);
            this.btnChainLock.TabIndex = 16;
            this.btnChainLock.Text = "Lock";
            this.btnChainLock.UseVisualStyleBackColor = false;
            this.btnChainLock.Click += new System.EventHandler(this.btnChainLock_Click);
            // 
            // btnChainInterrupt
            // 
            this.btnChainInterrupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChainInterrupt.BackColor = System.Drawing.Color.Red;
            this.btnChainInterrupt.Enabled = false;
            this.btnChainInterrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChainInterrupt.Location = new System.Drawing.Point(517, 19);
            this.btnChainInterrupt.Name = "btnChainInterrupt";
            this.btnChainInterrupt.Size = new System.Drawing.Size(75, 23);
            this.btnChainInterrupt.TabIndex = 19;
            this.btnChainInterrupt.Text = "InterruptChain";
            this.btnChainInterrupt.UseVisualStyleBackColor = false;
            this.btnChainInterrupt.Click += new System.EventHandler(this.btnChainInterrupt_Click);
            // 
            // lblEncryptProgress
            // 
            this.lblEncryptProgress.AutoSize = true;
            this.lblEncryptProgress.Location = new System.Drawing.Point(6, 74);
            this.lblEncryptProgress.Name = "lblEncryptProgress";
            this.lblEncryptProgress.Size = new System.Drawing.Size(138, 13);
            this.lblEncryptProgress.TabIndex = 18;
            this.lblEncryptProgress.Text = "PRESS \"LOCK\" TO BEGIN";
            // 
            // grpChainGenerationOptions
            // 
            this.grpChainGenerationOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChainGenerationOptions.Controls.Add(this.btnChainChooseSave);
            this.grpChainGenerationOptions.Controls.Add(this.txtChainSaveLocation);
            this.grpChainGenerationOptions.Controls.Add(this.nmbEncryptSeconds);
            this.grpChainGenerationOptions.Controls.Add(this.label3);
            this.grpChainGenerationOptions.Controls.Add(this.nmbEncryptThreads);
            this.grpChainGenerationOptions.Controls.Add(this.label2);
            this.grpChainGenerationOptions.Location = new System.Drawing.Point(8, 3);
            this.grpChainGenerationOptions.Name = "grpChainGenerationOptions";
            this.grpChainGenerationOptions.Size = new System.Drawing.Size(679, 77);
            this.grpChainGenerationOptions.TabIndex = 0;
            this.grpChainGenerationOptions.TabStop = false;
            this.grpChainGenerationOptions.Text = "Chain Generation Options";
            // 
            // btnChainChooseSave
            // 
            this.btnChainChooseSave.Location = new System.Drawing.Point(598, 17);
            this.btnChainChooseSave.Name = "btnChainChooseSave";
            this.btnChainChooseSave.Size = new System.Drawing.Size(75, 23);
            this.btnChainChooseSave.TabIndex = 17;
            this.btnChainChooseSave.Text = "...";
            this.btnChainChooseSave.UseVisualStyleBackColor = true;
            // 
            // txtChainSaveLocation
            // 
            this.txtChainSaveLocation.Location = new System.Drawing.Point(9, 19);
            this.txtChainSaveLocation.Name = "txtChainSaveLocation";
            this.txtChainSaveLocation.ReadOnly = true;
            this.txtChainSaveLocation.Size = new System.Drawing.Size(583, 20);
            this.txtChainSaveLocation.TabIndex = 16;
            // 
            // nmbEncryptSeconds
            // 
            this.nmbEncryptSeconds.Location = new System.Drawing.Point(260, 45);
            this.nmbEncryptSeconds.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmbEncryptSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbEncryptSeconds.Name = "nmbEncryptSeconds";
            this.nmbEncryptSeconds.Size = new System.Drawing.Size(122, 20);
            this.nmbEncryptSeconds.TabIndex = 15;
            this.nmbEncryptSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time Span";
            // 
            // nmbEncryptThreads
            // 
            this.nmbEncryptThreads.Location = new System.Drawing.Point(56, 45);
            this.nmbEncryptThreads.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmbEncryptThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbEncryptThreads.Name = "nmbEncryptThreads";
            this.nmbEncryptThreads.Size = new System.Drawing.Size(120, 20);
            this.nmbEncryptThreads.TabIndex = 12;
            this.nmbEncryptThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Threads";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpEncryptOutput);
            this.tabPage1.Controls.Add(this.grpEncryptControls);
            this.tabPage1.Controls.Add(this.grpEncryptOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEncryptOutput
            // 
            this.grpEncryptOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptOutput.Controls.Add(this.txtEncryptOutput);
            this.grpEncryptOutput.Location = new System.Drawing.Point(8, 392);
            this.grpEncryptOutput.Name = "grpEncryptOutput";
            this.grpEncryptOutput.Size = new System.Drawing.Size(679, 134);
            this.grpEncryptOutput.TabIndex = 13;
            this.grpEncryptOutput.TabStop = false;
            this.grpEncryptOutput.Text = "Encrypt Output";
            // 
            // txtEncryptOutput
            // 
            this.txtEncryptOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncryptOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptOutput.Location = new System.Drawing.Point(3, 16);
            this.txtEncryptOutput.Name = "txtEncryptOutput";
            this.txtEncryptOutput.Size = new System.Drawing.Size(673, 115);
            this.txtEncryptOutput.TabIndex = 10;
            this.txtEncryptOutput.Text = "";
            // 
            // grpEncryptControls
            // 
            this.grpEncryptControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptControls.Controls.Add(this.btnEncrypt);
            this.grpEncryptControls.Location = new System.Drawing.Point(8, 297);
            this.grpEncryptControls.Name = "grpEncryptControls";
            this.grpEncryptControls.Size = new System.Drawing.Size(679, 89);
            this.grpEncryptControls.TabIndex = 12;
            this.grpEncryptControls.TabStop = false;
            this.grpEncryptControls.Text = "Encrypt Controls";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.BackColor = System.Drawing.Color.Lime;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(598, 19);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            // 
            // grpEncryptOptions
            // 
            this.grpEncryptOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptOptions.Controls.Add(this.txtPlaintext);
            this.grpEncryptOptions.Controls.Add(this.label1);
            this.grpEncryptOptions.Location = new System.Drawing.Point(8, 6);
            this.grpEncryptOptions.Name = "grpEncryptOptions";
            this.grpEncryptOptions.Size = new System.Drawing.Size(679, 285);
            this.grpEncryptOptions.TabIndex = 9;
            this.grpEncryptOptions.TabStop = false;
            this.grpEncryptOptions.Text = "Encrypt Options";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaintext.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintext.Location = new System.Drawing.Point(9, 34);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(664, 219);
            this.txtPlaintext.TabIndex = 8;
            this.txtPlaintext.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // TimeLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 558);
            this.Controls.Add(this.tabControl);
            this.Name = "TimeLock";
            this.Text = "TimeLock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeLock_FormClosing);
            this.Load += new System.EventHandler(this.TimeLock_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grpChainGenerationControls.ResumeLayout(false);
            this.grpChainGenerationControls.PerformLayout();
            this.grpChainGenerationOptions.ResumeLayout(false);
            this.grpChainGenerationOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptThreads)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.grpEncryptOutput.ResumeLayout(false);
            this.grpEncryptControls.ResumeLayout(false);
            this.grpEncryptOptions.ResumeLayout(false);
            this.grpEncryptOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtPlaintext;
        private System.Windows.Forms.RichTextBox txtEncryptOutput;
        private System.Windows.Forms.GroupBox grpEncryptOptions;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox grpEncryptControls;
        private System.Windows.Forms.GroupBox grpEncryptOutput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ProgressBar progressBarChain;
        private System.Windows.Forms.Button btnChainInterrupt;
        private System.Windows.Forms.GroupBox grpChainGenerationOptions;
        private System.Windows.Forms.NumericUpDown nmbEncryptSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbEncryptThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEncryptProgress;
        private System.Windows.Forms.Button btnChainLock;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox grpChainGenerationControls;
        private System.Windows.Forms.Button btnChainChooseSave;
        private System.Windows.Forms.TextBox txtChainSaveLocation;
    }
}

