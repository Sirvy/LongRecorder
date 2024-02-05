using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using FFMediaToolkit.Encoding;
using FFMediaToolkit.Graphics;
using FFMediaToolkit.Decoding;
using System.Drawing;
using FFMediaToolkit;
using System.ComponentModel;

namespace TimelapseRecorder
{
    public partial class Form1 : Form
    {
        private String screenshotPath = AppDomain.CurrentDomain.BaseDirectory + "tmp\\";
        private Boolean isRecording = false;
        private ImageFormat screenshotFormat = ImageFormat.Jpeg;
        private int screenshotIntervalSeconds = 1;
        private String screenshotExtension = "jpg";
        private int selectedScreen = 0;
        private Boolean includeTaskbar = false;

        class VideoProcessorStructure
        {
            public string inputFolderPath = "";
            public string outputVideoPath = "";

            public List<string> files = new List<string>();

            public int completedCount = 0;
        }

        private VideoProcessorStructure vps = new VideoProcessorStructure();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FFmpegLoader.FFmpegPath = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg\\x86_64\\";
            ScreenshotPathTextbox.Text = this.screenshotPath;
            ScreenshotStatusLabel.Text = "";
            for (int i = 1; i <= Screen.AllScreens.Length; i++)
            {
                SelectScreenCombobox.Items.Add("Screen " + i);
            }
        }

        private void buttonOpenScreenshotPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.screenshotPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = this.screenshotPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Folder not found.", this.screenshotPath));
            }
        }

        private void ScreenshotPathTextbox_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                return;
            }

            folderBrowserDialogScreenshotPath.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialogScreenshotPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                ScreenshotPathTextbox.Text = folderBrowserDialogScreenshotPath.SelectedPath + "\\";
                this.screenshotPath = ScreenshotPathTextbox.Text;
                Environment.SpecialFolder root = folderBrowserDialogScreenshotPath.RootFolder;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                EnableScreenshotControls();
                ScreenshotTimer.Enabled = false;
            }
            else
            {
                DisableScreenshotControls();

                if (!Directory.Exists(screenshotPath))
                {
                    Directory.CreateDirectory(screenshotPath);
                }

                includeTaskbar = includeTaskbarCheckbox.Checked;

                ScreenshotTimer.Interval = screenshotIntervalSeconds * 1000;
                ScreenshotTimer.Enabled = true;
            }
        }

        private void ScreenshotFormatCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ScreenshotFormatCombobox.SelectedIndex)
            {
                case 0:
                    screenshotFormat = ImageFormat.Jpeg;
                    screenshotExtension = "jpg";
                    break;
                case 1:
                    screenshotFormat = ImageFormat.Bmp;
                    screenshotExtension = "bmp";
                    break;
                case 2:
                    screenshotFormat = ImageFormat.Gif;
                    screenshotExtension = "gif";
                    break;
                case 3:
                    screenshotFormat = ImageFormat.Png;
                    screenshotExtension = "png";
                    break;
            }
        }

        private void ScreenshotTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                String path = screenshotPath + DateTime.UtcNow.ToString("yyyyMMdd");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                String filename = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + "." + screenshotExtension;

                int selectedScreenWidth = includeTaskbar ? Screen.AllScreens[selectedScreen].Bounds.Width : Screen.AllScreens[selectedScreen].WorkingArea.Width;
                int selectedScreenHeight = includeTaskbar ? Screen.AllScreens[selectedScreen].Bounds.Height : Screen.AllScreens[selectedScreen].WorkingArea.Height;
                int selectedScreenX = includeTaskbar ? Screen.AllScreens[selectedScreen].Bounds.X : Screen.AllScreens[selectedScreen].WorkingArea.X;
                int selectedScreenY = includeTaskbar ? Screen.AllScreens[selectedScreen].Bounds.Y : Screen.AllScreens[selectedScreen].WorkingArea.Y;

                using (Bitmap ps = new Bitmap(selectedScreenWidth, selectedScreenHeight))
                {
                    using (Graphics g = Graphics.FromImage(ps))
                    {
                        g.CopyFromScreen(selectedScreenX, selectedScreenY, 0, 0, ps.Size);
                    }
                    ps.Save(path + "\\" + filename, screenshotFormat);
                }

                ScreenshotStatusLabel.Text = "Generated: " + filename;
            }
            catch (Exception exception)
            {
                EnableScreenshotControls();
                MessageBox.Show(exception.Message.ToString());
            }
        }

        private void IntervalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            screenshotIntervalSeconds = Convert.ToInt16(IntervalNumericUpDown.Value);
            if (screenshotIntervalSeconds <= 0)
            {
                screenshotIntervalSeconds = 1;
            }
        }

        private void EnableScreenshotControls()
        {
            isRecording = false;
            RecordButton.Text = "Start";
            IntervalNumericUpDown.Enabled = true;
            ScreenshotFormatCombobox.Enabled = true;
            RecordingIndicationLabel.Visible = false;
            SelectScreenCombobox.Enabled = true;
            includeTaskbarCheckbox.Enabled = true;
        }

        private void DisableScreenshotControls()
        {
            isRecording = true;
            RecordButton.Text = "Stop";
            IntervalNumericUpDown.Enabled = false;
            ScreenshotFormatCombobox.Enabled = false;
            RecordingIndicationLabel.Visible = true;
            SelectScreenCombobox.Enabled = false;
            includeTaskbarCheckbox.Enabled = false;
        }

        private void SelectScreenCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScreen = SelectScreenCombobox.SelectedIndex;
        }

        private void GenerateVideoButton_Click(object sender, EventArgs e)
        {
            vps.inputFolderPath = screenshotPath;
            vps.outputVideoPath = screenshotPath + "video.mp4";
            vps.files.AddRange(Directory.GetFiles(vps.inputFolderPath, "*.jpg", SearchOption.AllDirectories).OrderBy(f => f));
            progressBar1.Maximum = vps.files.Count;

            VideoGeneratorBackgroundWorker.RunWorkerAsync();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.Value = vps.completedCount;
                }));
                label7.Invoke(new Action(() =>
                {
                    label7.Text = vps.completedCount + "/" + vps.files.Count;
                }));
                Thread.Sleep(1000);
                if (vps.completedCount >= vps.files.Count)
                {
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = vps.completedCount;
                    }));
                    label7.Invoke(new Action(() =>
                    {
                        label7.Text = vps.completedCount + "/" + vps.files.Count;
                    }));
                    break;
                }
            } while (vps.completedCount <= vps.files.Count);

            MessageBox.Show("Finished");
        }

        private void VideoGeneratorBackgroundWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            var settings = new VideoEncoderSettings(width: 1920, height: 1080, framerate: 30, codec: VideoCodec.H264);
            settings.EncoderPreset = EncoderPreset.VerySlow;
            settings.CRF = 1;
            using (var outputFile = MediaBuilder.CreateContainer(vps.outputVideoPath).WithVideo(settings).Create())
            {
                for (int i = 0; i < vps.files.Count; i++)
                {
                    Bitmap bitmap = new Bitmap(Bitmap.FromFile(vps.files.ElementAt(i)));
                    Rectangle rect = new Rectangle(System.Drawing.Point.Empty, bitmap.Size);
                    BitmapData bitLock = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    ImageData bitmapImageData = ImageData.FromPointer(bitLock.Scan0, ImagePixelFormat.Bgr24, bitmap.Size);

                    outputFile.Video.AddFrame(bitmapImageData);

                    bitmap.UnlockBits(bitLock);

                    vps.completedCount++;
                }
            }
        }
    }
}