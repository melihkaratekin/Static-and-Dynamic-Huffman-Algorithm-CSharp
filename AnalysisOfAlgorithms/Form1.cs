using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Threading.Tasks;
using Huffman;
using System.Runtime.InteropServices;

namespace AnalysisOfAlgorithms
{
    public partial class HuffmanGUI : Form
    {
        public Series series1_compress;
        public Series series2_compress;
        public string[] files;

        public HuffmanGUI()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart0.Visible = false;
        }

        public void Text_Files()
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Huffman Coding Project - Select Documents";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.FileNames;
            }
        }

        public void compressionRatioS(string filename, float staticH)
        {
            series1_compress.Points.AddXY(filename, staticH);
        }

        public void compressionRatioD(string filename, float dynamicH)
        {
            series2_compress.Points.AddXY(filename, dynamicH);
        }

        public void compressionRatioB(string filename, float staticH, float dynamicH)
        {
            series1_compress.Points.AddXY(filename, staticH);
            series2_compress.Points.AddXY(filename, dynamicH);
        }

        public void ComputeTask()
        {
            chart0.Series.Clear();   // Grafiğin içeriğini temizliyoruz.
            chart0.Palette = ChartColorPalette.Pastel; // Grafiğin renklerini ayarlıyoruz. 

            //Eğer dosya seçilmiş ise
            if (files != null)
            {
                foreach (String file in files)
                {  
                    string path = @file; //Dosyanın yolunu alıp, string'e dönüştürüyoruz.
                    string text = File.ReadAllText(path); //Dosyanın içeriğini okuyup, string'e dönüştürüyoruz.
                    string name = Path.GetFileName(path); 

                    // Statik Huffman algoritması seçilirse
                    if (StaticRadio.Checked == true)
                    {
                        DynamicResult.Text = "";
                        series1_compress = chart0.Series.Add("Static"); // Statik serisini grafiğe ekliyoruz.
                        Results.Text = name + " Static Huffman Coding started. \n"; //Başladığına dair TextArea'ya yazı yazdırıyoruz.

                        HuffmanTree huffmanTree = new HuffmanTree(); // Huffman Tree sınıfından bir obje oluşturuyoruz.
                        huffmanTree.Build(text); //Text'in içeriğine göre ağacın içerisini dolduruyoruz.
                        
                        BitArray encoded = huffmanTree.Encode(text); //Sıkıştırması için Encode fonksiyonuna dosyayı gönderdik.
                        
                        //Sıkıştırma sonrası gereken bit sayısını öğrenmek için result_static'i kullanıyoruz.
                        string result_static = "";
                        foreach (bool bit in encoded)
                        {
                            result_static = result_static + (bit ? 1 : 0) + "";
                        }
                        
                        //FREKANSLARI YAZDIRACAĞIZ
                        Results.Text = Results.Text + "------------------------------------------------- \n";
                        Results.Text = Results.Text + "FREQUENCIES: \n";
                        string result_fre = "";

                        foreach (KeyValuePair<char, int> symbol in huffmanTree.Frequencies)
                        {
                            result_fre = result_fre + symbol + "\n";
                        }

                        Results.Text = Results.Text + result_fre + "\n";
                        Results.Text = Results.Text + "------------------------------------------------- \n";

                        //CODEWORDS'LERİ YAZDIRACAĞIZ
                        Results.Text = Results.Text + "CODEWORDS: \n";
                        Dictionary<char, string> Codewords = new Dictionary<char, string>();
                        var chars = new HashSet<char>(text);
                        
                        foreach (char ch in chars)
                        {
                            Codewords[ch] = huffmanTree.EncodeChar(ch);
                            Results.Text = Results.Text + ch + " ---> " + Codewords[ch] + "\n";
                          
                        }

                        Results.Text = Results.Text + "------------------------------------------------- \n";

                        //Statik için Compression Ratio hesaplıyoruz ve TextArea'ya yazdırıyoruz.
                        float compressionRatio_static = (text.Length * 8) / (float)result_static.Length; 
                        Results.Text = Results.Text + name + " Static Compression Ratio : " + compressionRatio_static + "\n";

                        //İşlemin bittiğine dair çıktıyı TextArea'ya yazdırıyoruz.
                        Results.Text = Results.Text + name + " Static Huffman Coding finished. \n"; 

                        //Değerlerimizi grafiğe eklemek için hesaplanan değerleri parametre alarak fonksiyonlarımızı çalıştırıyoruz.
                        compressionRatioS(name, compressionRatio_static);

                    }

                    //Dinamik Huffman Algoritmasını seçilirse
                    else if (DynamicRadio.Checked == true)
                    {
                        Results.Text = "";
                        series2_compress = chart0.Series.Add("Dynamic"); // Dinamik serisini grafiğe ekliyoruz.

                        DynamicResult.Text = name + " Dynamic Huffman Coding started. \n \n"; //Başladığına dair çıktıyı TextArea'ya yazdırıyoruz.

                        //Sıkıştırması için Encode fonksiyonuna dosyayı gönderdik.
                        String result_dynamic = HuffmanAlg.Encode_StrOut(path);

                        //Dinamik için Compression Ratio hesaplıyoruz ve TextArea'ya yazdırıyoruz.
                        float compressionRatio_dynamic = (text.Length * 8) / (float)result_dynamic.Length;
                        DynamicResult.Text = DynamicResult.Text + name + " Dynamic Compression Ratio : " + compressionRatio_dynamic + "\n \n";

                        //İşlemin bittiğine dair çıktıyı TextArea'ya yazdırıyoruz.
                        DynamicResult.Text = DynamicResult.Text + name + " Dynamic Huffman Coding finished. \n \n";

                        compressionRatioD(name, compressionRatio_dynamic);
                    }

                    //Both RadioButton seçilirse
                    else if (BothRadio.Checked == true)
                    {
                        series1_compress = chart0.Series.Add("Static"); // Statik serisini grafiğe ekliyoruz.
                        series2_compress = chart0.Series.Add("Dynamic"); // Dinamik serisini grafiğe ekliyoruz.

                        //STATIC HUFFMAN CODING
                        Results.Text = name + " Static Huffman Coding started. \n"; //Başladığına dair TextArea'ya yazı yazdırıyoruz.

                        HuffmanTree huffmanTree = new HuffmanTree(); // Huffman Tree sınıfından bir obje oluşturuyoruz.
                        huffmanTree.Build(text); //Text'in içeriğine göre ağacın içerisini dolduruyoruz.

                        BitArray encoded = huffmanTree.Encode(text); //Sıkıştırması için Encode fonksiyonuna dosyayı gönderdik.

                        //Sıkıştırma sonrası gereken bit sayısını öğrenmek için result_static'i kullanıyoruz.
                        string result_static = "";
                        foreach (bool bit in encoded)
                        {
                            result_static = result_static + (bit ? 1 : 0) + "";
                        }

                        //FREKANSLARI YAZDIRACAĞIZ
                        Results.Text = Results.Text + "------------------------------------------------- \n";
                        Results.Text = Results.Text + "FREQUENCIES: \n";
                        string result_fre = "";

                        foreach (KeyValuePair<char, int> symbol in huffmanTree.Frequencies)
                        {
                            result_fre = result_fre + symbol + "\n";
                        }

                        Results.Text = Results.Text + result_fre + "\n";
                        Results.Text = Results.Text + "------------------------------------------------- \n";

                        //CODEWORDS'LERİ YAZDIRACAĞIZ
                        Results.Text = Results.Text + "CODEWORDS: \n";
                        Dictionary<char, string> Codewords = new Dictionary<char, string>();
                        var chars = new HashSet<char>(text);

                        foreach (char ch in chars)
                        {
                            Codewords[ch] = huffmanTree.EncodeChar(ch);
                            Results.Text = Results.Text + ch + " ---> " + Codewords[ch] + "\n";
                        }

                        Results.Text = Results.Text + "------------------------------------------------- \n";

                        //Statik için Compression Ratio hesaplıyoruz ve TextArea'ya yazdırıyoruz.
                        float compressionRatio_static = (text.Length * 8) / (float)result_static.Length;
                        Results.Text = Results.Text + name + " Static Compression Ratio : " + compressionRatio_static + "\n";

                        //İşlemin bittiğine dair çıktıyı TextArea'ya yazdırıyoruz.
                        Results.Text = Results.Text + name + " Static Huffman Coding finished. \n";

                        Results.Text = Results.Text + "------------------------------------------------- \n";

                        //DYNAMIC HUFFMAN CODING
                        DynamicResult.Text = name + " Dynamic Huffman Coding started. \n \n"; //Başladığına dair çıktıyı TextArea'ya yazdırıyoruz.

                        //Sıkıştırması için Encode fonksiyonuna dosyayı gönderdik.
                        String result_dynamic = HuffmanAlg.Encode_StrOut(path);

                        //Dinamik için Compression Ratio hesaplıyoruz ve TextArea'ya yazdırıyoruz.
                        float compressionRatio_dynamic = (text.Length * 8) / (float)result_dynamic.Length;
                        DynamicResult.Text = DynamicResult.Text + name + " Dynamic Compression Ratio : " + compressionRatio_dynamic + "\n \n";

                        //İşlemin bittiğine dair çıktıyı TextArea'ya yazdırıyoruz.
                        DynamicResult.Text = DynamicResult.Text + name + " Dynamic Huffman Coding finished. \n \n";

                        
                        //Statik ve Dinamik için karşılaştırmalı bir sonuç çıkması için ikisinden gelen değeri de grafiğe ekliyoruz.
                        compressionRatioB(name, compressionRatio_static, compressionRatio_dynamic);
                    }
                    
                    //Eğer herhangi bir Huffman Algoritması seçilmediyse
                    else
                    {
                        Results.Text = "No selection! \nPlease select Huffman Coding Type! \n";
                    } 
                }

                //Tüm işlemler bittikten sonra Chart gözükecek.
                chart0.Visible = true; 

            }

            //Eğer dosya seçilmemiş ise
            else
            {
                Results.Text = Results.Text + "Please select a document! \n";
            }
        }

        //Add Documents Butonuna Basılınca
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            Text_Files();
            if (files != null)
            {
                foreach (String file in files)
                {
                    string path = @file; //Dosyanın yolunu alıp, string'e dönüştürüyoruz.
                    string text = File.ReadAllText(path); //Dosyanın içeriğini okuyup, string'e dönüştürüyoruz.

                    //Dosyanın ismini yazdırıyoruz.
                    string name = Path.GetFileName(path);
                    DName.Text = name;

                    //Dosyanın boyutunu yazdırıyoruz.
                    double length = new System.IO.FileInfo(path).Length;
                    double lengthkilobyte = Math.Ceiling(length / 1024);
                    SizeLabel.Text = lengthkilobyte + " KB";

                    //Dosya içerisinde kaç tane karakter olduğunu yazdırıyoruz.
                    int characternumber = text.Length;
                    NOCLabel.Text = Convert.ToString(characternumber);
                }
            }
        }

        //Start Butonuna Basılınca
        private void start_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ComputeTask));
            t.Start();
        }

        private void FileInfLabel_Click(object sender, EventArgs e)
        {

        }

        private void CharNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
