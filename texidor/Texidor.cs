using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texidor
{
    public partial class Texidor : Form
    {
        public int allShownButtonsAt = 129;
        public Texidor()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grpCommon.Height = (checkBox1.Checked) ? 39 : allShownButtonsAt;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "openFileDialog1")
            {
                // validation? ... looks like java files are not expected to have an extension ...
                using (var stream = openFileDialog1.OpenFile())
                {
                    if (stream.Length > 0)
                    {
                        stream.Position = 0;
                        using (var reader = new System.IO.StreamReader(stream))
                        {
                            txtFileName.Text = openFileDialog1.FileName;
                            if (openFileDialog1.FileName.EndsWith(".png"))
                            {
                                allShownButtonsAt = 164;
                                btnSave.Enabled = false;
                                btnClear.Enabled = false;
                                btnFormat.Enabled = false;
                                lbFormats.Enabled = false;
                                btnIcon.Visible = true;
                                pbImage.Visible = true;

                                var image = Image.FromFile(openFileDialog1.FileName);
                                pbImage.Image = image.GetThumbnailImage(32, 32, null, new IntPtr());
                            }
                            else
                            {
                                richTextBox1.Text = reader.ReadToEnd();
                                allShownButtonsAt = 129;
                                btnSave.Enabled = true;
                                btnClear.Enabled = true;
                                btnFormat.Enabled = true;
                                lbFormats.Enabled = true;
                                btnIcon.Visible = false;
                                pbImage.Visible = false;
                            }
                            grpCommon.Height = allShownButtonsAt;
                            reader.Close();
                        }
                    }
                    else
                    {
                        txtFileName.Text = "Selected File has no content";
                    }
                    stream.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //txtFileName.Text = "File Save Acnowledged";
            saveFileDialog1.FileName = openFileDialog1.FileName;
            saveFileDialog1.ShowDialog();
            using(var file = new System.IO.StreamWriter(openFileDialog1.FileName))
            {
                file.Write(richTextBox1.Text);
                file.Close();
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            // copy the image
            var fileName = openFileDialog1.FileName;
            var icoFileName = fileName + ".ico";
            System.IO.File.Copy(fileName, icoFileName, true);

            // load the new image
            var stream = System.IO.File.OpenWrite(icoFileName);

            // actually convert it to an icon
            var bitmap = new Bitmap(pbImage.Image);
            bitmap.SetResolution(72, 72);
            var icon = System.Drawing.Icon.FromHandle(bitmap.GetHicon());

            // updates the file to be an icon
            icon.Save(stream); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            txtFileName.Text = string.Empty;
            while(lbBrowse.Items.Count > 0)
            {
                lbBrowse.Items.RemoveAt(0);
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            switch(lbFormats.SelectedItem.ToString())
            {
                case "XML":
                    // convert contents of rich text using XElement.Parse
                    // add line breaks between elements
                    // add line breaks between open/closes of elements
                    // color-coding of attributes?
                    lbBrowse.Visible = true;
                    lbMirth.Visible = false;
                    break;
                case "C#/Java":
                    // change color for reserved words
                    // using syntax to indent (epecially on { and } )
                    lbBrowse.Visible = true;
                    lbMirth.Visible = false;
                    break;
                case "Document":
                    // left-justify most things
                    // think "essay"
                    lbBrowse.Visible = true;
                    lbMirth.Visible = false;
                    break;
                case "Mirth":
                    btnBrowse.Text = "Play";
                    lbBrowse.Visible = false;
                    lbMirth.Visible = true;
                    break;
                default:
                    btnBrowse.Text = "Browse";
                    lbBrowse.Visible = true;
                    lbMirth.Visible = false;
                    break;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            switch(btnBrowse.Text)
            {
                case "Browse":
                    btnBrowse.Text = "Unbrowse";
                    webBrowser1.Visible = true;
                    if (string.IsNullOrEmpty(txtFileName.Text))
                    {
                        txtFileName.Text = "http://www.google.com";
                    }
                    if (!txtFileName.Text.StartsWith("http"))
                    {
                        txtFileName.Text = "http://" + txtFileName.Text;
                    }
                    webBrowser1.Url = new Uri(txtFileName.Text);
                    txtFileName.Enabled = true;
                    txtFileName.ReadOnly = false;
                    txtFileName.Width = 453;
                    btnUpdateBrowser.Visible = true;
                    btnAddToList.Visible = true;
                    break;
                case "Unbrowse":
                    btnBrowse.Text = "Browse";
                    webBrowser1.Visible = false;
                    webBrowser1.Url = null;
                    txtFileName.Enabled = false;
                    txtFileName.ReadOnly = true;
                    txtFileName.Width = 505;
                    btnUpdateBrowser.Visible = false;
                    btnAddToList.Visible = false;
                    break;
            }
        }

        private void btnUpdateBrowser_Click(object sender, EventArgs e)
        {
            switch(btnBrowse.Text)
            {
                case "Unbrowse":
                    if (string.IsNullOrEmpty(txtFileName.Text))
                    {
                        txtFileName.Text = "http://www.google.com";
                    }
                    if (!txtFileName.Text.StartsWith("http") && !txtFileName.Text.StartsWith("C:") && !txtFileName.Text.StartsWith("file"))
                    {
                        txtFileName.Text = "http://" + txtFileName.Text;
                    }

                    webBrowser1.Url = new Uri(txtFileName.Text);
                    break;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            var current = webBrowser1.Url.ToString();
            if (current.StartsWith("http://") || current.StartsWith("https://"))
            {
                current = current.Substring(6);
                while(current.Substring(0,1) == "/")
                {
                    current = current.Substring(1);
                }
            }            
            while(current.StartsWith("w") || current.StartsWith("."))
            {
                current = current.Substring(1);
            }
            while (current.EndsWith("/"))
            {
                current = current.Substring(0,current.Length-1);
            }

            if (!lbBrowse.Items.Contains(current))
            {
                lbBrowse.Items.Add(current);
            }
        }

        private void lbBrowse_Click(object sender, EventArgs e)
        {
            //txtFileName.Text = lbBrowse.SelectedItem.ToString();
            var uri = new Uri(lbBrowse.SelectedItem.ToString());
            webBrowser1.Url = uri;
        }
    }
}
