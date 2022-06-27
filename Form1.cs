using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPG_v._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordLengthSlider.Minimum = 5;
            passwordLengthSlider.Maximum = 50;
        }

        const string LOWER_CASE = "abcdefghijklmnopqrstuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMERIC = "1234567890";
        const string SPECIAL_CHARACTERS = @"~!@#$%^&*()+=-";

        int currentPasswordLength = 0;
        Random character = new Random();



        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool numberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (numberic)
                charSet += NUMERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTERS;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(255, 85, 85);
            formSkin1.Refresh();
        }

        private void flatColorPalette1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dracula/dracula-theme");
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(139, 233, 253);
            formSkin1.Refresh();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(98, 114, 164);
            formSkin1.Refresh();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(80, 250, 123);
            formSkin1.Refresh();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(255, 184, 108);
            formSkin1.Refresh();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(189, 147, 249);
            formSkin1.Refresh();
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(68, 71, 90);
            formSkin1.Refresh();
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = Color.FromArgb(248, 248, 242);
            formSkin1.Refresh();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                passwordLabel.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecial.Checked, int.Parse(PasswordLengthLabel.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }

        private void passwordLengthSlider_Scroll(object sender)
        {
            PasswordLengthLabel.Text = " " + passwordLengthSlider.Value.ToString();
            currentPasswordLength = passwordLengthSlider.Value;
        }
    }
}
