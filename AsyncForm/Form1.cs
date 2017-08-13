using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace AsyncForm
{
    public partial class Form1 : Form
    {
        readonly SpeechSynthesizer _synthesizer = new SpeechSynthesizer();
        readonly List<VoiceInfo> _vocesInfo = new List<VoiceInfo>();
        Prompt _prompt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in _synthesizer.GetInstalledVoices())
            {
                _vocesInfo.Add(voice.VoiceInfo);
                comboBox1.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Enabled = false;
            bunifuImageButton2.Enabled = true;

            var nombre = _vocesInfo[comboBox1.SelectedIndex].Name;
            _synthesizer.SelectVoice(nombre);

            _synthesizer.Volume = bunifuTrackbar1.Value;
            _synthesizer.Rate = bunifuTrackbar2.Value;

            _synthesizer.SpeakCompleted += (sender2, e2) =>
            {
                bunifuImageButton1.Enabled = true;
                bunifuImageButton2.Enabled = false;
            };
            _prompt = _synthesizer.SpeakAsync(richTextBox1.Text);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsyncCancel(_prompt);
        }
    }
}