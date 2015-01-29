using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReadWriteCsv;
using System.IO;
using smw;

namespace PrinterAxeso
{
    class TagPrinter
    {
        private Config rconfig;
        private Dictionary<string,TagSequence> tsequence;
        private List<TagPrint> tprint;
        private string ttemplate="";
        public TagPrinter(Config tempconfig)
        {
            rconfig = tempconfig;
            tsequence = new Dictionary<string, TagSequence>();
            getSequence(rconfig.SequenceFilePath);

            tprint = new List<TagPrint>();
            getTags(rconfig.PrintFilePath);

            ttemplate = File.ReadAllText(rconfig.TemplatePath);
            createPrintFile();
        }

        public void printTags(){
            File.Copy(AssemblyDirectory+"\\calibrate.txt", rconfig.PrinterPath);
            File.Copy(AssemblyDirectory + "\\printfile.txt", rconfig.PrinterPath);
        }

        private void createPrintFile()
        {
            string finaltextfile = "";
            string temptemplate = "";
            string epc = "";

            EpcTools epctool = new EpcTools();
            foreach (TagPrint tag in tprint)
            {
                if (tag.count > 0)
                {
                    for (int i = 0; i < tag.count; i++)
                    {
                        temptemplate = ttemplate;
                        epc = epctool.getNewEPC(48, 1, 5, tag.upc, tsequence[tag.upc].Sequence);
                        temptemplate = temptemplate.Replace("<<EPC>>", epc);
                        temptemplate = temptemplate.Replace("<<UPC>>", tag.upc);
                        temptemplate = temptemplate.Replace("<<NAME>>", tag.name);
                        temptemplate = temptemplate.Replace("<<BARCODEEPC>>", tag.upc);
                        finaltextfile = finaltextfile + temptemplate;
                        temptemplate = "";
                        tsequence[tag.upc].Sequence++;
                    }
                }
            }
            setSequence(rconfig.SequenceFilePath);
            File.WriteAllText(AssemblyDirectory + "\\printfile.txt", finaltextfile);
        }

        /*private string formatBarcodePRN(string epc)
        {
            string barcodeFormat = "";
            barcodeFormat = epc.Substring(0, 8);
            barcodeFormat += ">6"+epc.Substring(7,6);
            barcodeFormat += +epc.Substring(15, 7);
            barcodeFormat += epc.Substring(22, 7);
            return barcodeFormat;
        }*/

        /*
        private void createPrintFile(){
            string finaltextfile="";
            string temptemplate = "";

            EpcTools epctool = new EpcTools();            
            foreach(TagPrint tag in tprint){
                if(tag.count>0){
                    for (int i = 0; i < tag.count; i++) {
                        temptemplate = ttemplate;
                        temptemplate=temptemplate.Replace("<<EPC>>", epctool.getNewEPC(48, 1, 5, tag.upc, tsequence[tag.upc].Sequence));
                        temptemplate = temptemplate.Replace("<<UPC>>", tag.upc);
                        temptemplate = temptemplate.Replace("<<NAME>>", tag.name);
                        finaltextfile = finaltextfile + temptemplate;
                        temptemplate = "";
                        tsequence[tag.upc].Sequence++;
                    }
                }
            }
            setSequence(rconfig.SequenceFilePath);
            File.WriteAllText(AssemblyDirectory + "\\printfile.txt", finaltextfile);
        }
        */
        private void getSequence(string PathSequence) {
            using (CsvFileReader reader = new CsvFileReader(PathSequence))
            {
                CsvRow row = new CsvRow();
                TagSequence tempsequence;
                while (reader.ReadRow(row))
                {
                    tempsequence = new TagSequence();
                    tempsequence.upc=row[0];
                    tempsequence.name = row[1];
                    tempsequence.Sequence = Convert.ToInt32(row[2]);
                    tsequence.Add(row[0],tempsequence);
                }
            }
        }

        private void setSequence(string PathSequence)
        {
            using (CsvFileWriter writer = new CsvFileWriter(PathSequence))
            {
                TagSequence item;
                foreach (KeyValuePair<string, TagSequence> entry in tsequence)
                {
                    item=entry.Value;
                    CsvRow row = new CsvRow();
                    row.Add(item.upc);
                    row.Add(item.name);
                    row.Add(item.Sequence.ToString());
                    writer.WriteRow(row);
                }
            }
        }

        private void getTags(string PathTags)
        {
            using (CsvFileReader reader = new CsvFileReader(PathTags))
            {
                CsvRow row = new CsvRow();
                TagPrint temptags;
                reader.ReadRow(row);
                while (reader.ReadRow(row))
                {
                    temptags = new TagPrint();
                    temptags.upc = row[0];
                    temptags.name = row[1];
                    temptags.count = Convert.ToInt32(row[2]);
                    tprint.Add(temptags);
                }
            }
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }

    public class TagSequence
    {
        public string upc { get; set; }
        public string name { get; set; }
        public int Sequence { get; set; }
    }

    public class TagPrint
    {
        public string upc { get; set; }
        public string name { get; set; }
        public int count { get; set; }
    }

}
