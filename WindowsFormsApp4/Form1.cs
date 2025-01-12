using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> All__ = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] files123;
            List<string> AllPath = new List<string>();
            string path = string.Empty;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                path = textBox1.Text;

                if (System.IO.Directory.Exists(path))
                {
                    System.IO.DirectoryInfo dir = new DirectoryInfo(path);
                    if (dir.FullName.Length > 0)
                    {
                    
                            string[] files = Directory.GetFiles(path);

                            foreach (var item in files)
                            {
                                AllPath.Add(item);

                            }
                    }
                    List<string> PH = new List<string>();
                    int count = 0;
                   


                        List<int> files_Length = new List<int>();
                        for (int i = 0; i < AllPath.Count; i++)
                        {
                            files_Length.Add(AllPath[i].Length);
                        }

                        for (int i = 0; i < AllPath.Count; i++)
                        {
                          
                            FileInfo fileInfo1 = new FileInfo(AllPath[i]);


                            for(int j = 0; j < AllPath.Count; j++)
                            {
                                FileInfo fileInfo2 = new FileInfo(AllPath[j]);

                                if (fileInfo1.Length == fileInfo2.Length)
                                {
                                    if (!files_Length.Contains(int.Parse(fileInfo1.Length.ToString())))
                                    {
                                        files_Length.Add(int.Parse(fileInfo1.Length.ToString()));
                                        string TXT = textBox2.Text;

                                        string fileName = Path.GetFileName(AllPath[i]);
                                        string newFilePath = Path.Combine(TXT, fileName);

                                        Directory.CreateDirectory(TXT);
                                        string extencion = Path.GetExtension(AllPath[i]);
                                        string last_path = Path.Combine(textBox2.Text,extencion);


                                        count++;
                                        File.Copy(AllPath[i],newFilePath);
                                        label4.Text += newFilePath+"\n";
                                   
                                }
                                }   
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Путь не существует ! ");
                }
            }

        }
    }
}
