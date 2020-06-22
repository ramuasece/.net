using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading;

namespace PreviewDemo
{
    public partial class Configuration : Form
    {

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            var path = @"Config\\app.config";

            var line1 = File.ReadLines(path).ElementAt(1 - 1);
            line1 = line1.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line1;
            textBoxCameraIP1.Text = rTxtReader.Lines.ElementAt(1 - 1);
            textBoxCameraPort1.Text = rTxtReader.Lines.ElementAt(2 - 1);
            textBoxCameraUsername1.Text = rTxtReader.Lines.ElementAt(3 - 1);
            textBoxCameraPassword1.Text = rTxtReader.Lines.ElementAt(4 - 1);
            textBoxCameraChannel1.Text = rTxtReader.Lines.ElementAt(5 - 1);
            comboBoxCameraStatus1.Text = rTxtReader.Lines.ElementAt(6 - 1);


            var line2 = File.ReadLines(path).ElementAt(2 - 1);
            line2 = line2.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line2;
            textBoxCameraIP2.Text = rTxtReader.Lines.ElementAt(1 - 1);
            textBoxCameraPort2.Text = rTxtReader.Lines.ElementAt(2 - 1);
            textBoxCameraUsername2.Text = rTxtReader.Lines.ElementAt(3 - 1);
            textBoxCameraPassword2.Text = rTxtReader.Lines.ElementAt(4 - 1);
            textBoxCameraChannel2.Text = rTxtReader.Lines.ElementAt(5 - 1);
            comboBoxCameraStatus2.Text = rTxtReader.Lines.ElementAt(6 - 1);


            var line3 = File.ReadLines(path).ElementAt(3 - 1);
            line3 = line3.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line3;
            textBoxCameraIP3.Text = rTxtReader.Lines.ElementAt(1 - 1);
            textBoxCameraPort3.Text = rTxtReader.Lines.ElementAt(2 - 1);
            textBoxCameraUsername3.Text = rTxtReader.Lines.ElementAt(3 - 1);
            textBoxCameraPassword3.Text = rTxtReader.Lines.ElementAt(4 - 1);
            textBoxCameraChannel3.Text = rTxtReader.Lines.ElementAt(5 - 1);
            comboBoxCameraStatus3.Text = rTxtReader.Lines.ElementAt(6 - 1);


            var line4 = File.ReadLines(path).ElementAt(4 - 1);
            line4 = line4.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line4;
            textBoxCameraIP4.Text = rTxtReader.Lines.ElementAt(1 - 1);
            textBoxCameraPort4.Text = rTxtReader.Lines.ElementAt(2 - 1);
            textBoxCameraUsername4.Text = rTxtReader.Lines.ElementAt(3 - 1);
            textBoxCameraPassword4.Text = rTxtReader.Lines.ElementAt(4 - 1);
            textBoxCameraChannel4.Text = rTxtReader.Lines.ElementAt(5 - 1);
            comboBoxCameraStatus4.Text = rTxtReader.Lines.ElementAt(6 - 1);


            var line5 = File.ReadLines(path).ElementAt(5 - 1);
            line5 = line5.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line5;
            textBoxCameraIP5.Text = rTxtReader.Lines.ElementAt(1 - 1);
            textBoxCameraPort5.Text = rTxtReader.Lines.ElementAt(2 - 1);
            textBoxCameraUsername5.Text = rTxtReader.Lines.ElementAt(3 - 1);
            textBoxCameraPassword5.Text = rTxtReader.Lines.ElementAt(4 - 1);
            textBoxCameraChannel5.Text = rTxtReader.Lines.ElementAt(5 - 1);
            comboBoxCameraStatus5.Text = rTxtReader.Lines.ElementAt(6 - 1);


            var line7 = File.ReadLines(path).ElementAt(7 - 1);
            line7 = line7.Replace("×", "\r\n"); // '×' ascii character - not available in keyboard

            rTxtReader.Text = line7;
            comboBoxBaudRate.Text = rTxtReader.Lines.ElementAt(1 - 1);
            comboBoxDataBits.Text = rTxtReader.Lines.ElementAt(2 - 1);
            comboBoxParityBits.Text = rTxtReader.Lines.ElementAt(3 - 1);
            comboBoxStopBits.Text = rTxtReader.Lines.ElementAt(4 - 1);


            var line9 = File.ReadLines(path).ElementAt(9 - 1);
            line9 = line9.Replace("×", "\r\n");

            rTxtReader.Text = line9;
            textBoxTareWeight.Text = rTxtReader.Lines.ElementAt(1 - 1);


            rTxtReader.Clear();
        }

        private void btnConfigurationSave_Click(object sender, EventArgs e)
        {
            var path = @"Config\\app.config";
            string[] config_file = File.ReadAllLines(path);

            var new_value_line1 = textBoxCameraIP1.Text
                + "×" + textBoxCameraPort1.Text
                + "×" + textBoxCameraUsername1.Text
                + "×" + textBoxCameraPassword1.Text
                + "×" + textBoxCameraChannel1.Text
                + "×" + comboBoxCameraStatus1.SelectedItem;
            config_file[1 - 1] = new_value_line1;

            var new_value_line2 = textBoxCameraIP2.Text
                + "×" + textBoxCameraPort2.Text
                + "×" + textBoxCameraUsername2.Text
                + "×" + textBoxCameraPassword2.Text
                + "×" + textBoxCameraChannel2.Text
                + "×" + comboBoxCameraStatus2.SelectedItem;
            config_file[2 - 1] = new_value_line2;

            var new_value_line3 = textBoxCameraIP3.Text
                + "×" + textBoxCameraPort3.Text
                + "×" + textBoxCameraUsername3.Text
                + "×" + textBoxCameraPassword3.Text
                + "×" + textBoxCameraChannel3.Text
                + "×" + comboBoxCameraStatus3.SelectedItem;
            config_file[3 - 1] = new_value_line3;

            var new_value_line4 = textBoxCameraIP4.Text
                + "×" + textBoxCameraPort4.Text
                + "×" + textBoxCameraUsername4.Text
                + "×" + textBoxCameraPassword4.Text
                + "×" + textBoxCameraChannel4.Text
                + "×" + comboBoxCameraStatus4.SelectedItem;
            config_file[4 - 1] = new_value_line4;

            var new_value_line5 = textBoxCameraIP5.Text
                + "×" + textBoxCameraPort5.Text
                + "×" + textBoxCameraUsername5.Text
                + "×" + textBoxCameraPassword5.Text
                + "×" + textBoxCameraChannel5.Text
                + "×" + comboBoxCameraStatus5.SelectedItem;
            config_file[5 - 1] = new_value_line5;

            var new_value_line7 = comboBoxBaudRate.SelectedItem
                + "×" + comboBoxDataBits.SelectedItem
                + "×" + comboBoxParityBits.SelectedItem
                + "×" + comboBoxStopBits.SelectedItem;
            config_file[7 - 1] = new_value_line7;

            var new_value_line9 = textBoxTareWeight.Text;
            config_file[9 - 1] = new_value_line9;

            File.WriteAllLines(path, config_file);
            MessageBox.Show("Changes Saved Successully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Preview formPreview = (Preview)Application.OpenForms["Preview"];
            formPreview.config();

            Preview formPreview2 = (Preview)Application.OpenForms["Preview"];
            Preview formPreview3 = (Preview)Application.OpenForms["Preview"];
            Preview formPreview4 = (Preview)Application.OpenForms["Preview"];
            Preview formPreview5 = (Preview)Application.OpenForms["Preview"];

            if (comboBoxCameraStatus1.Text == "ON")
            {
                formPreview.camera1_on();
            }

            if (comboBoxCameraStatus1.Text == "OFF")
            {
                formPreview.camera1_off();
            }

            if (comboBoxCameraStatus2.Text == "ON")
            {
                formPreview2.camera2_on();
            }

            if (comboBoxCameraStatus2.Text == "OFF")
            {
                formPreview2.camera2_off();
            }

            if (comboBoxCameraStatus3.Text == "ON")
            {
                formPreview3.camera3_on();
            }

            if (comboBoxCameraStatus3.Text == "OFF")
            {
                formPreview3.camera3_off();
            }

            if (comboBoxCameraStatus4.Text == "ON")
            {
                formPreview4.camera4_on();
            }

            if (comboBoxCameraStatus4.Text == "OFF")
            {
                formPreview4.camera4_off();
            }

            if (comboBoxCameraStatus5.Text == "ON")
            {
                formPreview5.camera5_on();
            }

            if (comboBoxCameraStatus5.Text == "OFF")
            {
                formPreview5.camera5_off();
            }

            this.Close();
        }

        private void btnConfigurationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
