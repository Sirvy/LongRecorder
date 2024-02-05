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
            includeTaskbarCheckbox = new CheckBox();
            label4 = new Label();
            SelectScreenCombobox = new ComboBox();
            ScreenshotStatusLabel = new Label();
            RecordButton = new Button();
            ScreenshotFormatCombobox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            buttonOpenScreenshotPath = new Button();
            ScreenshotPathTextbox = new TextBox();
            label1 = new Label();
            IntervalNumericUpDown = new NumericUpDown();
            RecordingIndicationLabel = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            GenerateVideoButton = new Button();
            button1 = new Button();
            videoPathTextbox = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            folderBrowserDialogScreenshotPath = new FolderBrowserDialog();
            ScreenshotTimer = new System.Windows.Forms.Timer(components);
            VideoGeneratorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntervalNumericUpDown).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(319, 186);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(includeTaskbarCheckbox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(SelectScreenCombobox);
            tabPage1.Controls.Add(ScreenshotStatusLabel);
            tabPage1.Controls.Add(RecordButton);
            tabPage1.Controls.Add(ScreenshotFormatCombobox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(buttonOpenScreenshotPath);
            tabPage1.Controls.Add(ScreenshotPathTextbox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(IntervalNumericUpDown);
            tabPage1.Controls.Add(RecordingIndicationLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(311, 158);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Screenshots";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // includeTaskbarCheckbox
            // 
            includeTaskbarCheckbox.AutoSize = true;
            includeTaskbarCheckbox.Location = new Point(199, 84);
            includeTaskbarCheckbox.Name = "includeTaskbarCheckbox";
            includeTaskbarCheckbox.Size = new Size(106, 19);
            includeTaskbarCheckbox.TabIndex = 12;
            includeTaskbarCheckbox.Text = "Include taskbar";
            includeTaskbarCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 11;
            label4.Text = "Select screen:";
            // 
            // SelectScreenCombobox
            // 
            SelectScreenCombobox.FormattingEnabled = true;
            SelectScreenCombobox.Location = new Point(115, 82);
            SelectScreenCombobox.Name = "SelectScreenCombobox";
            SelectScreenCombobox.Size = new Size(76, 23);
            SelectScreenCombobox.TabIndex = 10;
            SelectScreenCombobox.Text = "Screen 1";
            SelectScreenCombobox.SelectedIndexChanged += SelectScreenCombobox_SelectedIndexChanged;
            // 
            // ScreenshotStatusLabel
            // 
            ScreenshotStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScreenshotStatusLabel.AutoSize = true;
            ScreenshotStatusLabel.Location = new Point(124, 125);
            ScreenshotStatusLabel.Name = "ScreenshotStatusLabel";
            ScreenshotStatusLabel.RightToLeft = RightToLeft.No;
            ScreenshotStatusLabel.Size = new Size(64, 15);
            ScreenshotStatusLabel.TabIndex = 8;
            ScreenshotStatusLabel.Text = "Generated:";
            // 
            // RecordButton
            // 
            RecordButton.Location = new Point(6, 118);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(75, 28);
            RecordButton.TabIndex = 7;
            RecordButton.Text = "Start";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += StartButton_Click;
            // 
            // ScreenshotFormatCombobox
            // 
            ScreenshotFormatCombobox.FormattingEnabled = true;
            ScreenshotFormatCombobox.Items.AddRange(new object[] { "JPEG", "BMP", "GIF", "PNG" });
            ScreenshotFormatCombobox.Location = new Point(230, 50);
            ScreenshotFormatCombobox.Name = "ScreenshotFormatCombobox";
            ScreenshotFormatCombobox.Size = new Size(71, 23);
            ScreenshotFormatCombobox.TabIndex = 6;
            ScreenshotFormatCombobox.Text = "JPEG";
            ScreenshotFormatCombobox.SelectedIndexChanged += ScreenshotFormatCombobox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 54);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Format:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 4;
            label2.Text = "Interval (seconds):";
            // 
            // buttonOpenScreenshotPath
            // 
            buttonOpenScreenshotPath.Location = new Point(197, 19);
            buttonOpenScreenshotPath.Name = "buttonOpenScreenshotPath";
            buttonOpenScreenshotPath.Size = new Size(104, 26);
            buttonOpenScreenshotPath.TabIndex = 3;
            buttonOpenScreenshotPath.Text = "Open Location";
            buttonOpenScreenshotPath.UseVisualStyleBackColor = true;
            buttonOpenScreenshotPath.Click += buttonOpenScreenshotPath_Click;
            // 
            // ScreenshotPathTextbox
            // 
            ScreenshotPathTextbox.Location = new Point(6, 21);
            ScreenshotPathTextbox.Name = "ScreenshotPathTextbox";
            ScreenshotPathTextbox.ReadOnly = true;
            ScreenshotPathTextbox.Size = new Size(185, 23);
            ScreenshotPathTextbox.TabIndex = 2;
            ScreenshotPathTextbox.Click += ScreenshotPathTextbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Path:";
            // 
            // IntervalNumericUpDown
            // 
            IntervalNumericUpDown.Location = new Point(115, 50);
            IntervalNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            IntervalNumericUpDown.Name = "IntervalNumericUpDown";
            IntervalNumericUpDown.Size = new Size(55, 23);
            IntervalNumericUpDown.TabIndex = 0;
            IntervalNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IntervalNumericUpDown.ValueChanged += IntervalNumericUpDown_ValueChanged;
            // 
            // RecordingIndicationLabel
            // 
            RecordingIndicationLabel.AutoSize = true;
            RecordingIndicationLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            RecordingIndicationLabel.ForeColor = Color.Red;
            RecordingIndicationLabel.Location = new Point(88, 105);
            RecordingIndicationLabel.Name = "RecordingIndicationLabel";
            RecordingIndicationLabel.Size = new Size(33, 45);
            RecordingIndicationLabel.TabIndex = 9;
            RecordingIndicationLabel.Text = "•";
            RecordingIndicationLabel.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(progressBar1);
            tabPage2.Controls.Add(GenerateVideoButton);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(videoPathTextbox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(311, 158);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Video";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 108);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 9;
            label7.Text = "0/0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(183, 26);
            progressBar1.TabIndex = 8;
            // 
            // GenerateVideoButton
            // 
            GenerateVideoButton.Location = new Point(197, 79);
            GenerateVideoButton.Name = "GenerateVideoButton";
            GenerateVideoButton.Size = new Size(104, 26);
            GenerateVideoButton.TabIndex = 7;
            GenerateVideoButton.Text = "Generate video";
            GenerateVideoButton.UseVisualStyleBackColor = true;
            GenerateVideoButton.Click += GenerateVideoButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(197, 18);
            button1.Name = "button1";
            button1.Size = new Size(104, 26);
            button1.TabIndex = 6;
            button1.Text = "Open Location";
            button1.UseVisualStyleBackColor = true;
            // 
            // videoPathTextbox
            // 
            videoPathTextbox.Location = new Point(6, 20);
            videoPathTextbox.Name = "videoPathTextbox";
            videoPathTextbox.ReadOnly = true;
            videoPathTextbox.Size = new Size(185, 23);
            videoPathTextbox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 2);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 4;
            label6.Text = "Image source path:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "video.mp4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 53);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 0;
            label5.Text = "Filename:";
            // 
            // ScreenshotTimer
            // 
            ScreenshotTimer.Interval = 1000;
            ScreenshotTimer.Tick += ScreenshotTimer_Tick;
            // 
            // VideoGeneratorBackgroundWorker
            // 
            VideoGeneratorBackgroundWorker.DoWork += VideoGeneratorBackgroundWorker_DoWork_1;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 185);
            Controls.Add(tabControl1);
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
            ResumeLayout(false);
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
        private ComboBox ScreenshotFormatCombobox;
        private Label label3;
        private Button RecordButton;
        private Label ScreenshotStatusLabel;
        private FolderBrowserDialog folderBrowserDialogScreenshotPath;
        private Label RecordingIndicationLabel;
        private System.Windows.Forms.Timer ScreenshotTimer;
        private ComboBox SelectScreenCombobox;
        private Label label4;
        private CheckBox includeTaskbarCheckbox;
        private Button button1;
        private TextBox videoPathTextbox;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private ProgressBar progressBar1;
        private Button GenerateVideoButton;
        private System.ComponentModel.BackgroundWorker VideoGeneratorBackgroundWorker;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}