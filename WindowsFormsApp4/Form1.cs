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

                    using(FileStream stream1 = new FileStream("NEW PATH", FileMode.CreateNew))
                    {
                      
                        for (int i = 0; i < AllPath.Count; i++)
                        {
                            int count = 0;
                            FileInfo fileInfo1 = new FileInfo(AllPath[i]);

                            for(int j = 0; j < AllPath.Count; j++)
                            {
                                FileInfo fileInfo2 = new FileInfo(AllPath[j]);

                                if (fileInfo1.Length == fileInfo2.Length)
                                {
                                    count++;
                                }
                                if (count > 1)
                                {
                                    All__.Add(AllPath[i]);
                                    break;
                                }
                              
                            }
                            if(count > 1)
                            {

                            }

                        }

                    }
                        for (int i = 0;i < All__.Count; i++)
                        {
                        //  File.WriteAllText("NEW PATH", All__.ElementAt(i));
                        File.Move();
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
