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

        private int[,] ResCreate(int[][,] data, int max, int n, int r)
        {
            int[,] result = new int[n + 1, max];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    result[i, j] = -1;
                }
            }
            for (int i = 0; i <= n; i++)
            {
                result[i, i + 2] = data[0][r, i + 2];
                for (int j = 0; j < i; j++)
                {
                    result[i, j] = data[i - j][r, j];
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
            arr1.Text = "\t";
            for (int i = -1; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == -1)
                    {
                        arr1.Text = arr1.Text + (j) + "\t";
                    }
                    else
                    {
                        arr1.Text = arr1.Text + data_res[i, j] + "\t";
                    }
                }
                if (i == -1)
                {
                    arr1.Text = arr1.Text + "\n\t";
                    for (int j = 0; j < max; j++)
                    {
                        arr1.Text = arr1.Text + "----\t";
                    }
                }
                if (i != Convert.ToInt32(n.Text))
                {
                    arr1.Text = arr1.Text + "\n" + (i + 1) + " |\t";
                }

            }
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
            arr2.Text = "\t";
            for (int i = -1; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == -1)
                    {
                        arr2.Text = arr2.Text + (j) + "\t";
                    }
                    else
                    {
                        arr2.Text = arr2.Text + data_res[i, j] + "\t";
                    }
                }
                if (i == -1)
                {
                    arr2.Text = arr2.Text + "\n\t";
                    for (int j = 0; j < max; j++)
                    {
                        arr2.Text = arr2.Text + "----\t";
                    }
                }
                if (i != Convert.ToInt32(n.Text))
                {
                    arr2.Text = arr2.Text + "\n" + (i + 1) + " |\t";
                }

            }

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
            arr3.Text = "\t";
            for (int i = -1; i < Convert.ToInt32(n.Text) + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == -1)
                    {
                        arr3.Text = arr3.Text + (j) + "\t";
                    }
                    else
                    {
                        arr3.Text = arr3.Text + data_res[i, j] + "\t";
                    }
                }
                if (i == -1)
                {
                    arr3.Text = arr3.Text + "\n\t";
                    for (int j = 0; j < max; j++)
                    {
                        arr3.Text = arr3.Text + "----\t";
                    }
                }
                if (i != Convert.ToInt32(n.Text))
                {
                    arr3.Text = arr3.Text + "\n" + (i + 1) + " |\t";
                }

            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(n.Text);
            int safe_profit, change_profit;
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] w = new int[k + 1, max];
            char[,] x = new char[k + 1, max];
            int[,] r = ResCreate(data, max, k, 0);
            int[,] u = ResCreate(data, max, k, 1);
            int[,] c = ResCreate(data, max, k, 2);
            for (int i = 0; i > k + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    w[i, j] = 1;
                    x[i, j] = 'f';
                }
            }
            for (int i = k + 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i == k)
                    {
                        safe_profit = r[i, j] - u[i, j];
                        change_profit = r[i, 0] - u[i, 0] - c[i, 0];
                    }
                    else
                    {
                        safe_profit = r[i, j] - u[i, j] + w[i + 1, j + 1];
                        change_profit = r[i, 0] - u[i, 0] - c[i, 0] + w[i + 1, 1];
                    }
                    if (safe_profit >= change_profit)
                    {
                        w[i, j] = safe_profit;
                        x[i, j] = 's';
                    }
                    else
                    {
                        w[i, j] = change_profit;
                        x[i, j] = 'c';
                    }
                }
                if (i == k)
                {
                    safe_profit = r[i, i + 2] - u[i, i + 2];
                    change_profit = r[i, 0] - u[i, 0] - c[i, i + 2];
                }
                else
                {
                    safe_profit = r[i, i + 2] - u[i, i + 2] + w[i + 1, i + 3];
                    change_profit = r[i, 0] - u[i, 0] - c[i, i + 2] + w[i + 1, 1];
                }
                if (safe_profit >= change_profit)
                {
                    w[i, i + 2] = safe_profit;
                    x[i, i + 2] = 's';
                }
                else
                {
                    w[i, i + 2] = change_profit;
                    x[i, i + 2] = 'c';
                }

            }

        }

    }
}
