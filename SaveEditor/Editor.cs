using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SaveEditor
{
    public partial class Editor : Form
    {
        public byte[] oldSaveFileContents;
        public byte[] newSaveFileContents = new byte[40572];

        public byte[] header;
        public byte[] saveData;
        public byte[] checksum;
        public byte[] footer;

        public byte[] newChecksum;

        public Editor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string openFilePath = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select Save File";
            openFile.Filter = "All Files|*.*";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFile.FileName;
                oldSaveFileContents = File.ReadAllBytes(openFilePath);
                if (oldSaveFileContents.Length != 40572)
                {
                    MessageBox.Show("That is not a valid save file", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    File.WriteAllBytes(openFilePath + ".bak", oldSaveFileContents);

                int dataStart = 8232;
                int dataEnd = 40564;

                header = oldSaveFileContents.Skip(0).Take(dataStart).ToArray();
                saveData = oldSaveFileContents.Skip(dataStart).Take(dataEnd - dataStart).ToArray();
                checksum = oldSaveFileContents.Skip(dataEnd).Take(4).ToArray();
                footer = oldSaveFileContents.Skip(dataEnd + 4).Take(4).ToArray();

                saveToolStripMenuItem.Enabled = true;
                checksumBox.Enabled = true;
                checksumButton.Enabled = true;
                unlockCharsButton.Enabled = true;
                checksumBox.Text = BitConverter.ToString(checksum);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string saveFilePath = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save?";
            saveFile.Filter = "All Files|*.*";
            saveFile.FilterIndex = 0;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = saveFile.FileName;

                header.CopyTo(newSaveFileContents, 0);
                saveData.CopyTo(newSaveFileContents, header.Length);
                checksum.CopyTo(newSaveFileContents, header.Length + saveData.Length);
                footer.CopyTo(newSaveFileContents, header.Length + saveData.Length + footer.Length);

                File.WriteAllBytes(saveFilePath, newSaveFileContents);
                newSaveFileContents = new byte[40572];
                MessageBox.Show("File Saved Successfully", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static byte[] GenerateChecksum(byte[] byteArray, int salt)
        {
            int bytes = salt;
            for (int i = 0; i <= byteArray.Length-4; i += 4)
            {
                bytes += BitConverter.ToInt32(byteArray.Skip(0+i).Take(4).ToArray());
            }
            return BitConverter.GetBytes(bytes);
        }

        private void checksumButton_Click(object sender, EventArgs e)
        {
            newChecksum = GenerateChecksum(saveData, 6031769);
            checksumBox.Text = BitConverter.ToString(newChecksum);
        }

        private void unlockCharsButton_Click(object sender, EventArgs e)
        {
            for (int i = 31992; i <= saveData.Length - 4; i++)
            {
                saveData[i] = 0x03;
            }
            newChecksum = GenerateChecksum(saveData, 6031769);
        }
    }
}
