using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_5._12_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbkieuchu.Text = "Tahoma";
            cbbcochu.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cbbkieuchu.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                cbbcochu.Items.Add(s);
            }
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular); 
            richTextBox1.ForeColor = Color.Black;                        
            richTextBox1.BackColor = Color.White;                        

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(dlg.FileName);
        }

        private void lưuNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(dlg.FileName);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF File| *.rtf| txt File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(dlg.FileName);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null) // Kiểm tra nếu có văn bản được chọn
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                // Kiểm tra trạng thái hiện tại và chuyển đổi
                if (richTextBox1.SelectionFont.Bold)
                {
                    newStyle &= ~FontStyle.Bold; // Bỏ in đậm
                }
                else
                {
                    newStyle |= FontStyle.Bold; // Thêm in đậm
                }

                // Áp dụng font mới
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Italic)
                {
                    newStyle &= ~FontStyle.Italic; // Bỏ in nghiêng
                }
                else
                {
                    newStyle |= FontStyle.Italic; // Thêm in nghiêng
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle newStyle = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Underline)
                {
                    newStyle &= ~FontStyle.Underline; // Bỏ gạch dưới
                }
                else
                {
                    newStyle |= FontStyle.Underline; // Thêm gạch dưới
                }

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void cbbkieuchu_Click(object sender, EventArgs e)
        {
            if (cbbkieuchu.SelectedItem != null)
            {
                string fontName = cbbkieuchu.SelectedItem.ToString();
                richTextBox1.Font = new Font(fontName, richTextBox1.Font.Size, richTextBox1.Font.Style);
            }
        }

        private void cbbcochu_Click(object sender, EventArgs e)
        {
            if (cbbcochu.SelectedItem != null)
            {
                float fontSize = float.Parse(cbbcochu.SelectedItem.ToString());
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize, richTextBox1.Font.Style);
            }
        }
    }
}
