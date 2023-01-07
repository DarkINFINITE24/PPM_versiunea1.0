using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPM
{
    public partial class Form1 : Form
    {
        //string[] lineInstruction = new string[50000]; //x
        List<string> lineInstruction = new List<string>();
        //int[] convertedBranchState = new int[50000];
        List<int> convertedBranchState = new List<int>();
        //int[] predictedValues = new int[50000];
        List<int> predictedValues = new List<int>();
        string istorieglobala;
        int nrIstorieGolbala, nrInstructiuneUrmatoare;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseTraceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Trace Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "tra",
                Filter = "tra files (*.tra)|*.tra",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.FileName;
            }

        }


        private void ReadFromFile()
        {
            //string[] line = new string[3];
            foreach (string line in System.IO.File.ReadLines(textBoxFileName.Text))
            {
                string[] substrings = line.Split(',');
                //line = sr.ReadLine().Split(' ');
                lineInstruction.Add(substrings[0]);
            }
            Convertor();
        }

        private void Convertor()
        {
            foreach(string s in lineInstruction)
            {
                if (s.IndexOf('B') == 0)
                {
                    convertedBranchState.Add(1);
                }
                else
                {
                    convertedBranchState.Add(0);
                }
            }
        }

        private void HRg()
        {
            nrIstorieGolbala = Convert.ToInt32(comboBoxBitiHRg.SelectedItem);
            nrInstructiuneUrmatoare = nrIstorieGolbala + 1;
            for (int i = 0; i < nrIstorieGolbala; i++)
            {
                istorieglobala += Convert.ToString(convertedBranchState[i]);
                predictedValues.Add(-1);
            }

        }

        private void HRgUpdate()
        {
            //if (convertedBranchState[nrInstructiuneUrmatoare] != null)
            //{
            Debug.WriteLine("HRgUpdate");
            istorieglobala = istorieglobala.Remove(0, 1);
            Debug.WriteLine(istorieglobala);
            Debug.WriteLine(istorieglobala.Length);
            //istorieglobala = istorieglobala.Insert(nrIstorieGolbala, Convert.ToString(convertedBranchState[nrInstructiuneUrmatoare]));
            istorieglobala += Convert.ToString(convertedBranchState[nrInstructiuneUrmatoare]);
            nrInstructiuneUrmatoare++;
            //}
        }

        private void Prediction()
        {
            bool start = true;
            int[] frecventa = new int[2];
            string pattern = istorieglobala;
            pattern = pattern.Remove(0, 1);
            var cnt = 0;
            while (start)
            {
                int found = 0;
                int count = 0; //de cate ori s-a gasit un pattern
                Debug.WriteLine("cnt " + cnt++);
                Debug.WriteLine("pattern: " + pattern);
                if (pattern.Length == 1)
                {
                    int tempCounterForZero = istorieglobala.Count(s => s.Equals('0'));
                    int tempCounterForOne = istorieglobala.Length - tempCounterForZero;
                    if (tempCounterForZero > tempCounterForOne)
                    {
                        //predictedValues[nrInstructiuneUrmatoare] = 0;
                        predictedValues.Add(0);
                        start = false;
                    }
                    else
                    {
                        //predictedValues[nrInstructiuneUrmatoare] = 1;
                        predictedValues.Add(1);
                        start = false;
                    }
                }
                if (pattern.Length > 1)
                {
                    while ((found = istorieglobala.IndexOf(pattern, found)) != -1)
                    {
                        Debug.WriteLine("pattern found counter: " + count++);
                        if (istorieglobala.Substring(found + pattern.Length).IndexOf('1') == 0)
                        {
                            frecventa[1]++;
                        }
                        if (istorieglobala.Substring(found + pattern.Length).IndexOf('0') == 0)
                        {
                            frecventa[0]++;
                        }
                        found++;
                    }
                }
                if (frecventa[0] > frecventa[1])
                {
                    //predictedValues[nrInstructiuneUrmatoare] = 0;
                    predictedValues.Add(0);
                    start = false;
                }
                else
                {
                    if (frecventa[0] < frecventa[1])
                    {
                        //predictedValues[nrInstructiuneUrmatoare] = 1;
                        predictedValues.Add(1);
                        start = false;
                    }
                }
                pattern = pattern.Remove(0, 1);
            }
            HRgUpdate();
        }

        private void Accuracy()
        {
            int contor = 0;
            for (int i = nrIstorieGolbala; i < nrInstructiuneUrmatoare - 1; i++)
            {
                if (convertedBranchState[i] == predictedValues[i])
                {
                    contor++;
                }
            }
            double result;
            result = ((double)(contor / (double)(convertedBranchState.Count - nrIstorieGolbala)) * 100.0);
            textBoxAcuratete.Text = Convert.ToString(result);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBitiHRg.SelectedItem = null;
            comboBoxBitiHRg.SelectedText = "--Select a value--";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(textBoxFileName.Text);
            ReadFromFile();
            HRg();
            for (int i = nrIstorieGolbala ; i < convertedBranchState.Count -1; i++)
            {
                Prediction();
            }
            Accuracy();
        }
    }
}
