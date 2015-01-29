using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using smw;

namespace PrinterAxeso
{
    public partial class Main : Form
    {
        private Config rconfig;
        public Main()
        {
            InitializeComponent();
            rconfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@".\config.json"));

            sequenceLabel.Text = rconfig.SequenceFilePath;
            TagLabel.Text = rconfig.PrintFilePath;
            PrinterBox.Text = rconfig.PrinterPath;
            templatePath.Text = rconfig.TemplatePath;
            //File.Copy(rconfig.TemplatePath,rconfig.PrinterPath);
        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            sequenceFileDialog.ShowDialog();
        }

        private void templateButton_Click(object sender, EventArgs e)
        {
            templateFileDialog.ShowDialog();
        }

        private void TagsButton_Click(object sender, EventArgs e)
        {
            tagFileDialog.ShowDialog();
        }

        private void sequenceFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rconfig.SequenceFilePath = sequenceFileDialog.FileName;
            sequenceLabel.Text = sequenceFileDialog.FileName;
        }

        private void templateFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rconfig.TemplatePath = templateFileDialog.FileName;
            templatePath.Text = templateFileDialog.FileName;
        }

        private void tagFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            rconfig.PrintFilePath = tagFileDialog.FileName;
            TagLabel.Text = tagFileDialog.FileName;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            TagPrinter printer = new TagPrinter(rconfig);
            printer.printTags();            
        }

        private void PrinterBox_TextChanged(object sender, EventArgs e)
        {
            rconfig.PrinterPath = PrinterBox.Text;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(@".\config.json", JsonConvert.SerializeObject(rconfig));
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }

    public class Config
    {
        public string PrinterPath { get; set; }
        public string TemplatePath { get; set; }
        public string SequenceFilePath { get; set; }
        public string PrintFilePath { get; set; }
    }
}
