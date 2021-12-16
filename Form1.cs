using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace TPR
{
    public partial class Form1 : Form
    {
        private int[][,] Arr3Create()
        {
            int i = 0, j = 0, k = 0;

            int[][,] ArrYear = new int[11][,];
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("mydata.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode attrYearPro = xnode.Attributes.GetNamedItem("yearOfProduction");

                    if (Int32.Parse(attrYearPro.Value) == -1)
                    {
                        i = 0;
                        ArrYear[i] = new int[3, 12 - Int32.Parse(attrYearPro.Value)];
                    }
                    else
                    {
                        i = Int32.Parse(attrYearPro.Value);
                        ArrYear[i] = new int[3, 11 - Int32.Parse(attrYearPro.Value)];
                    }

                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            XmlNode atrYear = childnode.Attributes.GetNamedItem("year");
                            k = Int32.Parse(atrYear.Value);
                            foreach (XmlNode child in childnode.ChildNodes)
                            {
                                if (child.Name == "sum")
                                {
                                    ArrYear[i][j, k] = Convert.ToInt32(child.InnerText);
                                    j++;
                                }
                                if (child.Name == "serviseCost")
                                {
                                    ArrYear[i][j, k] = Convert.ToInt32(child.InnerText);
                                    j++;
                                }
                                if (child.Name == "changeCost")
                                {
                                    ArrYear[i][j, k] = Convert.ToInt32(child.InnerText);
                                    j = 0;
                                }
                            }
                        }
                    }
                }
                return ArrYear;
            
        }
        

            private int Max(int[][,] data)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!
            return 13;
        }

       private int[,] ResCreate(int[][,] data, int max,int n,int r)
        {
            int[,] result = new int[n+1,max];
            for (int i = 0; i <= n; i++)
            {
                for (int j=0;j<max;j++)                           
                {
                    result[i, j] = -1;
                }
            }
            for (int i=0;i<=n;i++)
            {
                result[i, i + 2] = data[0][r,i+2];
                for (int j=0;j<i;j++)
                {
                    result[i,j]= data[i-j][r, j];
                }
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            r_t.Visible = true;
            s_t.Visible = false;
            u_t.Visible = false;
            arr1.Visible = true;
            arr2.Visible = false;
            arr3.Visible = false;
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] data_res = ResCreate(data, max, Convert.ToInt32(n.Text), 0);
            string s = "";
            for (int i = 0; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    s = s + data_res[i, j] + "\t";
                }
                s = s + "\n";
            }
            arr1.Text = s;
        }

        private void утриманняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = true;
            u_t.Visible = false;
            arr1.Visible = false;
            arr2.Visible = true;
            arr3.Visible = false;
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] data_res = ResCreate(data, max, Convert.ToInt32(n.Text), 1);
            string s = "";
            for (int i = -1; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == -1)
                    {
                        s = s + (j)+"\t";
                    }
                    else
                    {
                        s = s + data_res[i, j] + "\t";
                    }
                }
                if (i == -1)
                {
                    s = s + "\n";
                    for (int j = 0; j < max; j++)
                    {
                        s = s + "----\t";
                    }                    
                }
                s = s + "\n";
            }            
            arr2.Text = s;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = true;
            arr1.Visible = false;
            arr2.Visible = false;
            arr3.Visible = true;
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] data_res = ResCreate(data, max, Convert.ToInt32(n.Text), 2);
            string s = "";
            for (int i = 0; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    s = s + data_res[i, j] + "\t";
                }
                s = s + "\n";
            }
            
            arr3.Text = s;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
