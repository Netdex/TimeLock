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
            this.btnEncryptLock = new System.Windows.Forms.Button();
            this.nmbEncryptThreads = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarEncrypt = new System.Windows.Forms.ProgressBar();
            this.lblEncryptProgress = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEncryptInterrupt = new System.Windows.Forms.Button();
            this.txtEncryptOutput = new System.Windows.Forms.RichTextBox();
            this.grpEncryptOptions = new System.Windows.Forms.GroupBox();
            this.nmbEncryptSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaintext = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpEncryptControls = new System.Windows.Forms.GroupBox();
            this.grpEncryptOutput = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptThreads)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEncryptOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptSeconds)).BeginInit();
            this.grpEncryptControls.SuspendLayout();
            this.grpEncryptOutput.SuspendLayout();
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
            // btnEncryptLock
            // 
            this.btnEncryptLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptLock.BackColor = System.Drawing.Color.Lime;
            this.btnEncryptLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptLock.Location = new System.Drawing.Point(598, 15);
            this.btnEncryptLock.Name = "btnEncryptLock";
            this.btnEncryptLock.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptLock.TabIndex = 2;
            this.btnEncryptLock.Text = "Lock";
            this.btnEncryptLock.UseVisualStyleBackColor = false;
            this.btnEncryptLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // nmbEncryptThreads
            // 
            this.nmbEncryptThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmbEncryptThreads.Location = new System.Drawing.Point(53, 259);
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
            this.nmbEncryptThreads.TabIndex = 3;
            this.nmbEncryptThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Threads";
            // 
            // progressBarEncrypt
            // 
            this.progressBarEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEncrypt.Location = new System.Drawing.Point(6, 44);
            this.progressBarEncrypt.Name = "progressBarEncrypt";
            this.progressBarEncrypt.Size = new System.Drawing.Size(667, 23);
            this.progressBarEncrypt.TabIndex = 5;
            // 
            // lblEncryptProgress
            // 
            this.lblEncryptProgress.AutoSize = true;
            this.lblEncryptProgress.Location = new System.Drawing.Point(6, 70);
            this.lblEncryptProgress.Name = "lblEncryptProgress";
            this.lblEncryptProgress.Size = new System.Drawing.Size(138, 13);
            this.lblEncryptProgress.TabIndex = 6;
            this.lblEncryptProgress.Text = "PRESS \"LOCK\" TO BEGIN";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 558);
            this.tabControl.TabIndex = 8;
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
            // btnEncryptInterrupt
            // 
            this.btnEncryptInterrupt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptInterrupt.BackColor = System.Drawing.Color.Red;
            this.btnEncryptInterrupt.Enabled = false;
            this.btnEncryptInterrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptInterrupt.Location = new System.Drawing.Point(517, 15);
            this.btnEncryptInterrupt.Name = "btnEncryptInterrupt";
            this.btnEncryptInterrupt.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptInterrupt.TabIndex = 11;
            this.btnEncryptInterrupt.Text = "Interrupt";
            this.btnEncryptInterrupt.UseVisualStyleBackColor = false;
            this.btnEncryptInterrupt.Click += new System.EventHandler(this.btnEncryptInterrupt_Click);
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
            // grpEncryptOptions
            // 
            this.grpEncryptOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptOptions.Controls.Add(this.nmbEncryptSeconds);
            this.grpEncryptOptions.Controls.Add(this.label3);
            this.grpEncryptOptions.Controls.Add(this.txtPlaintext);
            this.grpEncryptOptions.Controls.Add(this.label1);
            this.grpEncryptOptions.Controls.Add(this.nmbEncryptThreads);
            this.grpEncryptOptions.Controls.Add(this.label2);
            this.grpEncryptOptions.Location = new System.Drawing.Point(8, 6);
            this.grpEncryptOptions.Name = "grpEncryptOptions";
            this.grpEncryptOptions.Size = new System.Drawing.Size(679, 285);
            this.grpEncryptOptions.TabIndex = 9;
            this.grpEncryptOptions.TabStop = false;
            this.grpEncryptOptions.Text = "Encrypt Options";
            // 
            // nmbEncryptSeconds
            // 
            this.nmbEncryptSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nmbEncryptSeconds.Location = new System.Drawing.Point(257, 259);
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
            this.nmbEncryptSeconds.TabIndex = 11;
            this.nmbEncryptSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time Span";
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
            this.tabPage2.Size = new System.Drawing.Size(695, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // grpEncryptControls
            // 
            this.grpEncryptControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptControls.Controls.Add(this.progressBarEncrypt);
            this.grpEncryptControls.Controls.Add(this.btnEncryptInterrupt);
            this.grpEncryptControls.Controls.Add(this.lblEncryptProgress);
            this.grpEncryptControls.Controls.Add(this.btnEncryptLock);
            this.grpEncryptControls.Location = new System.Drawing.Point(8, 297);
            this.grpEncryptControls.Name = "grpEncryptControls";
            this.grpEncryptControls.Size = new System.Drawing.Size(679, 89);
            this.grpEncryptControls.TabIndex = 12;
            this.grpEncryptControls.TabStop = false;
            this.grpEncryptControls.Text = "Encrypt Controls";
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
            // TimeLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 558);
            this.Controls.Add(this.tabControl);
            this.Name = "TimeLock";
            this.Text = "TimeLock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeLock_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptThreads)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEncryptOptions.ResumeLayout(false);
            this.grpEncryptOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbEncryptSeconds)).EndInit();
            this.grpEncryptControls.ResumeLayout(false);
            this.grpEncryptControls.PerformLayout();
            this.grpEncryptOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncryptLock;
        private System.Windows.Forms.NumericUpDown nmbEncryptThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarEncrypt;
        private System.Windows.Forms.Label lblEncryptProgress;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtPlaintext;
        private System.Windows.Forms.RichTextBox txtEncryptOutput;
        private System.Windows.Forms.GroupBox grpEncryptOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncryptInterrupt;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.NumericUpDown nmbEncryptSeconds;
        private System.Windows.Forms.GroupBox grpEncryptControls;
        private System.Windows.Forms.GroupBox grpEncryptOutput;
    }
}

