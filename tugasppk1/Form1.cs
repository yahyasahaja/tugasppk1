using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasppk1
{
    public partial class Form_1086_1 : Form
    {
        FontStyle fontStyle = FontStyle.Regular;
        public Form_1086_1()
        {
            InitializeComponent();
            this.button_1086_1.BackgroundImageLayout = ImageLayout.None;
            comboBox_1086_1.Items.AddRange(FontFamily.Families.Select(s => s.Name).ToArray());
            comboBox_1086_1.SelectedIndex = 1;
            comboBox_1086_2.SelectedIndex = 13;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_1086_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                int index = comboBox_1086_2.SelectedIndex == -1 ? 0 : comboBox_1086_2.SelectedIndex;
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font((String)comboBox_1086_1.SelectedItem, (float)Convert.ToDouble(comboBox_1086_2.Items[index]), fontStyle);
            }
        }

        private void comboBox_1086_2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font((String) comboBox_1086_1.SelectedItem, (float)Convert.ToDouble(comboBox_1086_2.SelectedItem), fontStyle);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                int index = comboBox_1086_2.SelectedIndex == comboBox_1086_2.MaxDropDownItems - 1 ? comboBox_1086_2.MaxDropDownItems - 1 : comboBox_1086_2.SelectedIndex + 1;
                comboBox_1086_2.SelectedIndex = index;
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font.FontFamily, (float) Convert.ToDouble(comboBox_1086_2.Items[index]), fontStyle);
            }
        }

        private void button_1086_2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                int index = comboBox_1086_2.SelectedIndex == 0 ? 0 : comboBox_1086_2.SelectedIndex - 1;
                comboBox_1086_2.SelectedIndex = index;
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font.FontFamily, (float)Convert.ToDouble(comboBox_1086_2.Items[index]), fontStyle);
            }
        }

        private void button_1086_13_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                richTextBox_1086_1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void button_1086_12_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                richTextBox_1086_1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void button_1086_7_Click(object sender, EventArgs e)
        {

        }

        private void button_1086_4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font, fontStyle = fontStyle ^ FontStyle.Bold);
            }
        }

        private void button_1086_3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font, fontStyle = fontStyle ^ FontStyle.Italic);
            }
        }

        private void button_1086_6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font, fontStyle = fontStyle ^ FontStyle.Underline);
            }
        }

        private void button_1086_5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                fontDialog1.Font = richTextBox_1086_1.SelectionFont = new Font(fontDialog1.Font, fontStyle = fontStyle ^ FontStyle.Strikeout);
            }
        }

        private void button_1086_9_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                colorDialog1.ShowDialog();
                richTextBox_1086_1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button_1086_11_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1086_1.Text))
            {
                richTextBox_1086_1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void button_1086_21_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                Clipboard.SetImage(img);
                richTextBox_1086_1.Paste();
                richTextBox_1086_1.Focus();
            }
            else
            {
                richTextBox_1086_1.Focus();
            }
        }

        const int INDENT_SIZE = 70;

        private void button_1086_17_Click(object sender, EventArgs e)
        {
            richTextBox_1086_1.SelectionIndent -= INDENT_SIZE;
        }

        private void button_1086_16_Click(object sender, EventArgs e)
        {
            richTextBox_1086_1.SelectionIndent += INDENT_SIZE;
        }

        const int LIST_INDENT_SIZE = 40;
        private void button_1086_15_Click(object sender, EventArgs e)
        {
            Boolean isListed = richTextBox_1086_1.SelectionBullet;

            if (!isListed)
            {
                richTextBox_1086_1.SelectionIndent = LIST_INDENT_SIZE;
                richTextBox_1086_1.SelectionBullet = true;
                richTextBox_1086_1.BulletIndent = 25;
            } else
            {
                richTextBox_1086_1.SelectionIndent = 0;
                richTextBox_1086_1.SelectionBullet = false;
                richTextBox_1086_1.BulletIndent = 0;
            }
            
        }
    }
}
