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
        public Form1()
        {
            InitializeComponent();
        }        

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

        private char[,] X_arr(int [,]r, int[,] u, int[,] c, int max, int k, ref int[,] w, ref char [,] x)
        {
            int safe_profit, change_profit;
            for (int i = 0; i > k + 1; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    w[i, j] = 1;
                    x[i, j] = 'f';
                }
            }
            for (int i = k; i >= 0; i--)
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
                    w[i, i+2] = safe_profit;
                    x[i, i + 2] = 's';
                }
                else
                {
                    w[i, i+2] = change_profit;
                    x[i, i + 2] = 'c';
                }
            }
            return x;   
        }

        private string [] showStrategy (char [,] x, int k, int max)
        {
            string[] result=new string[k];
            int h = 3;
            for ( int i=0; i<k;i++)
            {
                if (x[i,h]=='c')
                {
                    result[i] = (i+1).ToString()+"-й рік: варто змінити обладнання";
                    h = 0;
                }
                else
                {
                    if (x[i, h] == 's')
                    {
                        result[i] = (i+1).ToString()+"-й рік: варто залишити поточне обладнання";
                        h++;
                    }
                    
                }
            }
            return result;
        }

        private void Menu1_Click(object sender, EventArgs e)
        {
            r_t.Visible = true;
            s_t.Visible = false;
            u_t.Visible = false;
            arr1.Visible = true;
            arr2.Visible = false;
            arr3.Visible = false;
            x_ar.Visible = false;
            w_ar.Visible = false;
            year_mark.Visible = false;
            max_val.Visible = false;
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

        private void Menu2_Click(object sender, EventArgs e)
    {
        r_t.Visible = false;
        s_t.Visible = true;
        u_t.Visible = false;
        arr1.Visible = false;
        arr2.Visible = true;
        arr3.Visible = false;
        x_ar.Visible = false;
        w_ar.Visible = false;
            year_mark.Visible = false;
            max_val.Visible = false;
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
        
        private void Menu3_Click(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = true;
            arr1.Visible = false;
            arr2.Visible = false;
            arr3.Visible = true;
            x_ar.Visible = false;
            w_ar.Visible = false;
            year_mark.Visible = false;
            max_val.Visible = false;
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
        
        private void Menu4_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(n.Text);
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] r = ResCreate(data, max, k, 0);
            int[,] u = ResCreate(data, max, k, 1);
            int[,] c = ResCreate(data, max, k, 2);
            int[,] w = new int[k + 1, max];
            char[,] x = new char[k + 1, max];
            x = X_arr(r, u, c, max, k, ref w, ref x);
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = false;
            arr1.Visible = false;
            arr2.Visible = false;
            arr3.Visible = false;
            w_ar.Visible = true;
            x_ar.Visible = false;
            year_mark.Visible = false;
            max_val.Visible = false;
            w_ar.RowCount = k + 1;
            w_ar.ColumnCount = max;
            for (int i = 0; i <= k; i++)
            {
                w_ar.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int j = 0; j < max; j++)
            {
                w_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i <= k; i++)
                for (int j = 0; j < max; j++)
                    w_ar.Rows[i].Cells[j].Value = w[i, j];
            w_ar.Height = w_ar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + w_ar.ColumnHeadersHeight;
        }
        
        private void Menu5_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(n.Text);
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] r = ResCreate(data, max, k, 0);
            int[,] u = ResCreate(data, max, k, 1);
            int[,] c = ResCreate(data, max, k, 2);
            int[,] w = new int[k + 1, max];
            char[,] x = new char[k + 1, max];
            x = X_arr(r, u, c, max, k, ref w, ref x);
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = false;
            arr1.Visible = false;
            arr2.Visible = false;
            arr3.Visible = false;
            x_ar.Visible = true;
            w_ar.Visible = false;
            year_mark.Visible = false;
            max_val.Visible = false;
            x_ar.RowCount = k + 1;
            x_ar.ColumnCount = max;
            for (int i = 0; i <= k; i++)
            {
                x_ar.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int j = 0; j < max; j++)
            {
                x_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i <= k; i++)
                for (int j = 0; j < max; j++)
                {
                    if (x[i, j] == 's')                
                    {
                        x_ar.Rows[i].Cells[j].Value = "+";
                        x_ar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        if (x[i, j] == 'c')
                        {
                            x_ar.Rows[i].Cells[j].Value = "-";
                            x_ar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                        }
                    }
                }
            x_ar.Height = x_ar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + x_ar.ColumnHeadersHeight;
        }
        
        

        private void MenuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = false;
            arr1.Visible = false;
            arr2.Visible = false;
            arr3.Visible = false;
            x_ar.Visible = false;
            w_ar.Visible = false;
            max_val.Visible = true;
            year_mark.Visible = true;
            int k = Convert.ToInt32(n.Text);
            int[][,] data = Arr3Create();
            int max = Max(data);
            int[,] r = ResCreate(data, max, k, 0);
            int[,] u = ResCreate(data, max, k, 1);
            int[,] c = ResCreate(data, max, k, 2);
            int[,] w = new int[k + 1, max];
            char[,] x = new char[k + 1, max];
            x = X_arr(r, u, c, max, k, ref w, ref x);
            int mark = w[1, 3];
            max_val.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[k, max];
            char[,] x1 = new char[k, max];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = new string[k];
            strat = showStrategy(x1, k, max);
            year_mark.RowCount = k;
            year_mark.ColumnCount = 1;
            for (int i = 0; i < k; i++)
            {
                year_mark.Rows[i].Cells[0].Value = strat[i];
            }
            year_mark.Height = year_mark.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            Fi.Location = new System.Drawing.Point(26, year_mark.Location.Y + year_mark.Height + 30);
            Fi.Visible = true;


            /*w1, x1 = w[1:], x[1:]
    strat = showStrategy(x)
    saveStrategy(strat, path_to_strat)
    print("\nОбчислимо значення Fi(t)")*/
        }

        private void n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(n.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void n_TextChanged(object sender, EventArgs e)
        {
            
                    Run.Enabled = true;
                    menu1.Enabled = true;
                    menu2.Enabled = true;
                    menu3.Enabled = true;
                    menu4.Enabled = true;
                    menu5.Enabled = true;           
        }        
    }
}
