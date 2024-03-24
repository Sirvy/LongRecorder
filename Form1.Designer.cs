namespace TimelapseRecorder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            includeTaskbarCheckbox = new CheckBox();
            label4 = new Label();
            SelectScreenCombobox = new ComboBox();
            ScreenshotStatusLabel = new Label();
            RecordingIndicationLabel = new Label();
            RecordButton = new Button();
            label2 = new Label();
            IntervalNumericUpDown = new NumericUpDown();
            tabPage2 = new TabPage();
            label9 = new Label();
            numericUpDown3 = new NumericUpDown();
            fpsLabel = new Label();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            GenerateVideoButton = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            buttonOpenScreenshotPath = new Button();
            ScreenshotPathTextbox = new TextBox();
            label1 = new Label();
            folderBrowserDialogScreenshotPath = new FolderBrowserDialog();
            ScreenshotTimer = new System.Windows.Forms.Timer(components);
            VideoGeneratorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalNumericUpDown).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(325, 180);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(includeTaskbarCheckbox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(SelectScreenCombobox);
            tabPage1.Controls.Add(ScreenshotStatusLabel);
            tabPage1.Controls.Add(RecordingIndicationLabel);
            tabPage1.Controls.Add(RecordButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(IntervalNumericUpDown);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(317, 152);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Screenshots";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 15);
            label8.Name = "label8";
            label8.Size = new Size(234, 15);
            label8.TabIndex = 13;
            label8.Text = "Automaticallys take screenshots in interval.";
            // 
            // includeTaskbarCheckbox
            // 
            includeTaskbarCheckbox.AutoSize = true;
            includeTaskbarCheckbox.Checked = true;
            includeTaskbarCheckbox.CheckState = CheckState.Checked;
            includeTaskbarCheckbox.Location = new Point(199, 46);
            includeTaskbarCheckbox.Name = "includeTaskbarCheckbox";
            includeTaskbarCheckbox.Size = new Size(106, 19);
            includeTaskbarCheckbox.TabIndex = 12;
            includeTaskbarCheckbox.Text = "Include taskbar";
            includeTaskbarCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 77);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 11;
            label4.Text = "Select screen:";
            // 
            // SelectScreenCombobox
            // 
            SelectScreenCombobox.FormattingEnabled = true;
            SelectScreenCombobox.Location = new Point(115, 74);
            SelectScreenCombobox.Name = "SelectScreenCombobox";
            SelectScreenCombobox.Size = new Size(73, 23);
            SelectScreenCombobox.TabIndex = 10;
            SelectScreenCombobox.Text = "Screen 1";
            SelectScreenCombobox.SelectedIndexChanged += SelectScreenCombobox_SelectedIndexChanged;
            // 
            // ScreenshotStatusLabel
            // 
            ScreenshotStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScreenshotStatusLabel.AutoSize = true;
            ScreenshotStatusLabel.Location = new Point(124, 117);
            ScreenshotStatusLabel.Name = "ScreenshotStatusLabel";
            ScreenshotStatusLabel.RightToLeft = RightToLeft.No;
            ScreenshotStatusLabel.Size = new Size(64, 15);
            ScreenshotStatusLabel.TabIndex = 8;
            ScreenshotStatusLabel.Text = "Generated:";
            // 
            // RecordingIndicationLabel
            // 
            RecordingIndicationLabel.AutoSize = true;
            RecordingIndicationLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            RecordingIndicationLabel.ForeColor = Color.Red;
            RecordingIndicationLabel.Location = new Point(87, 98);
            RecordingIndicationLabel.Name = "RecordingIndicationLabel";
            RecordingIndicationLabel.Size = new Size(33, 45);
            RecordingIndicationLabel.TabIndex = 9;
            RecordingIndicationLabel.Text = "•";
            RecordingIndicationLabel.Visible = false;
            // 
            // RecordButton
            // 
            RecordButton.Location = new Point(6, 110);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(75, 28);
            RecordButton.TabIndex = 7;
            RecordButton.Text = "Start";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += StartButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 4;
            label2.Text = "Interval (seconds):";
            // 
            // IntervalNumericUpDown
            // 
            IntervalNumericUpDown.Location = new Point(115, 42);
            IntervalNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            IntervalNumericUpDown.Name = "IntervalNumericUpDown";
            IntervalNumericUpDown.Size = new Size(73, 23);
            IntervalNumericUpDown.TabIndex = 0;
            IntervalNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IntervalNumericUpDown.ValueChanged += IntervalNumericUpDown_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(fpsLabel);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(progressBar1);
            tabPage2.Controls.Add(GenerateVideoButton);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(317, 152);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Video";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 13);
            label9.Name = "label9";
            label9.Size = new Size(159, 15);
            label9.TabIndex = 16;
            label9.Text = "Generate video from images.";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(259, 69);
            numericUpDown3.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(43, 23);
            numericUpDown3.TabIndex = 15;
            numericUpDown3.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // fpsLabel
            // 
            fpsLabel.AutoSize = true;
            fpsLabel.Location = new Point(224, 71);
            fpsLabel.Name = "fpsLabel";
            fpsLabel.Size = new Size(29, 15);
            fpsLabel.TabIndex = 14;
            fpsLabel.Text = "FPS:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(146, 69);
            numericUpDown2.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 23);
            numericUpDown2.TabIndex = 13;
            numericUpDown2.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 71);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 12;
            label6.Text = "x";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(73, 69);
            numericUpDown1.Maximum = new decimal(new int[] { 9000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 71);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Size (px):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 130);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 9;
            label7.Text = "0/0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 101);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(183, 26);
            progressBar1.TabIndex = 8;
            // 
            // GenerateVideoButton
            // 
            GenerateVideoButton.Location = new Point(197, 101);
            GenerateVideoButton.Name = "GenerateVideoButton";
            GenerateVideoButton.Size = new Size(105, 26);
            GenerateVideoButton.TabIndex = 7;
            GenerateVideoButton.Text = "Generate video";
            GenerateVideoButton.UseVisualStyleBackColor = true;
            GenerateVideoButton.Click += GenerateVideoButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "video.mp4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 43);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 0;
            label5.Text = "Filename:";
            // 
            // buttonOpenScreenshotPath
            // 
            buttonOpenScreenshotPath.Location = new Point(200, 56);
            buttonOpenScreenshotPath.Name = "buttonOpenScreenshotPath";
            buttonOpenScreenshotPath.Size = new Size(104, 26);
            buttonOpenScreenshotPath.TabIndex = 3;
            buttonOpenScreenshotPath.Text = "Open Folder";
            buttonOpenScreenshotPath.UseVisualStyleBackColor = true;
            buttonOpenScreenshotPath.Click += buttonOpenScreenshotPath_Click;
            // 
            // ScreenshotPathTextbox
            // 
            ScreenshotPathTextbox.Location = new Point(10, 27);
            ScreenshotPathTextbox.Name = "ScreenshotPathTextbox";
            ScreenshotPathTextbox.ReadOnly = true;
            ScreenshotPathTextbox.Size = new Size(295, 23);
            ScreenshotPathTextbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Location:";
            // 
            // ScreenshotTimer
            // 
            ScreenshotTimer.Interval = 1000;
            ScreenshotTimer.Tick += ScreenshotTimer_Tick;
            // 
            // VideoGeneratorBackgroundWorker
            // 
            VideoGeneratorBackgroundWorker.DoWork += VideoGeneratorBackgroundWorker_DoWork_1;
            VideoGeneratorBackgroundWorker.RunWorkerCompleted += VideoGeneratorBackgroundWorker_RunWorkerCompleted;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // button1
            // 
            button1.Location = new Point(10, 56);
            button1.Name = "button1";
            button1.Size = new Size(135, 26);
            button1.TabIndex = 4;
            button1.Text = "Select another path";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(269, 95);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 14;
            label10.Text = "v1.0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 273);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(buttonOpenScreenshotPath);
            Controls.Add(label1);
            Controls.Add(ScreenshotPathTextbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Timelapse Recorder";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalNumericUpDown).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown IntervalNumericUpDown;
        private TabPage tabPage2;
        private Label label2;
        private Button buttonOpenScreenshotPath;
        private TextBox ScreenshotPathTextbox;
        private Label label1;
        private Button RecordButton;
        private Label ScreenshotStatusLabel;
        private FolderBrowserDialog folderBrowserDialogScreenshotPath;
        private Label RecordingIndicationLabel;
        private System.Windows.Forms.Timer ScreenshotTimer;
        private ComboBox SelectScreenCombobox;
        private Label label4;
        private CheckBox includeTaskbarCheckbox;
        private TextBox textBox1;
        private Label label5;
        private ProgressBar progressBar1;
        private Button GenerateVideoButton;
        private System.ComponentModel.BackgroundWorker VideoGeneratorBackgroundWorker;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown numericUpDown3;
        private Label fpsLabel;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}