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

        private int Max()
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

        private char[,] X_arr(int[,] r, int[,] u, int[,] c, int max, int k, ref int[,] w, ref char[,] x)
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
                        change_profit = r[i, 0] - u[i, 0] - c[i, j];
                    }
                    else
                    {
                        safe_profit = r[i, j] - u[i, j] + w[i + 1, j + 1];
                        change_profit = r[i, 0] - u[i, 0] - c[i, j] + w[i + 1, 1];
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
            return x;
        }

        private string[] ShowStrategy(char[,] x, int k)
        {
            string[] result = new string[k];
            int h = 3;
            for (int i = 0; i < k; i++)
            {
                if (x[i, h] == 'c')
                {
                    result[i] = (i + 1).ToString() + "-й рік: варто змінити обладнання";
                    h = 0;
                }
                else
                {
                    if (x[i, h] == 's')
                    {
                        result[i] = (i + 1).ToString() + "-й рік: варто залишити поточне обладнання";
                        h++;
                    }

                }
            }
            return result;
        }

        private void ToFile(string[] str, int k)
        {
            string path = "result.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < k; i++)
                {
                    sw.WriteLine(str[i]);
                }
            }
        }

        private void Menu11(object sender, EventArgs e)
        {
            r_t.Visible = true;
            s_t.Visible = false;
            u_t.Visible = false;
            r_ar.Visible = true;
            u_ar.Visible = false;
            c_ar.Visible = false;
            max_val.Visible = false;
            year_mark.Visible = false;
            Fi.Visible = false;
            lastResult.Visible = false;
            int k = 10;
            int[][,] data = Arr3Create();
            int max = Max();
            int[,] data_res = ResCreate(data, max, k, 0);
            r_ar.RowCount = k;
            r_ar.ColumnCount = max;
            for (int i = 0; i < k; i++)
            {
                r_ar.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < max; j++)
            {
                r_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < k; i++)
                for (int j = 0; j < max; j++)
                {
                    if (data_res[i + 1, j] != -1)
                    {
                        r_ar.Rows[i].Cells[j].Value = data_res[i + 1, j];
                    }
                }
            r_ar.Height = r_ar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + r_ar.ColumnHeadersHeight;
        }

        private void Menu12(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = true;
            u_t.Visible = false;
            r_ar.Visible = false;
            u_ar.Visible = true;
            c_ar.Visible = false;
            max_val.Visible = false;
            year_mark.Visible = false;
            Fi.Visible = false;
            lastResult.Visible = false;
            int k = 10;
            int[][,] data = Arr3Create();
            int max = Max();
            int[,] data_res = ResCreate(data, max, k, 1);
            u_ar.RowCount = k;
            u_ar.ColumnCount = max;
            for (int i = 0; i < k; i++)
            {
                u_ar.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < max; j++)
            {
                u_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < k; i++)
                for (int j = 0; j < max; j++)
                {
                    if (data_res[i + 1, j] != -1)
                    {
                        u_ar.Rows[i].Cells[j].Value = data_res[i + 1, j];
                    }
                }
            u_ar.Height = u_ar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + u_ar.ColumnHeadersHeight;
        }

        private void Menu13(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = true;
            r_ar.Visible = false;
            u_ar.Visible = false;
            c_ar.Visible = true;
            max_val.Visible = false;
            year_mark.Visible = false;
            Fi.Visible = false;
            lastResult.Visible = false;
            int k = 10;
            int[][,] data = Arr3Create();
            int max = Max();
            int[,] data_res = ResCreate(data, max, k, 2);
            c_ar.RowCount = k;
            c_ar.ColumnCount = max;
            for (int i = 0; i < k; i++)
            {
                c_ar.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < max; j++)
            {
                c_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < k; i++)
                for (int j = 0; j < max; j++)
                {
                    if (data_res[i + 1, j] != -1)
                    {
                        c_ar.Rows[i].Cells[j].Value = data_res[i + 1, j];
                    }
                }
            c_ar.Height = c_ar.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + c_ar.ColumnHeadersHeight;
        }



        private void Menu2(object sender, EventArgs e)
        {
            r_t.Visible = false;
            s_t.Visible = false;
            u_t.Visible = false;
            x_ar.Visible = true;
            r_ar.Visible = false;
            u_ar.Visible = false;
            c_ar.Visible = false;
            max_val.Visible = false;
            year_mark.Visible = false;
            Fi.Visible = false;
            lastResult.Visible = false;
            int k = 10;
            int[][,] data = Arr3Create();
            int max = Max();
            int[,] r = ResCreate(data, max, k, 0);
            int[,] u = ResCreate(data, max, k, 1);
            int[,] c = ResCreate(data, max, k, 2);
            int[,] w = new int[k + 1, max];
            char[,] x = new char[k + 1, max];
            x = X_arr(r, u, c, max, k, ref w, ref x);
            x_ar.RowCount = k;
            x_ar.ColumnCount = max;
            for (int i = 0; i < k; i++)
            {
                x_ar.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < max; j++)
            {
                x_ar.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < k; i++)
                for (int j = 0; j < max; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        x_ar.Rows[i].Cells[j].Value = "C";
                        x_ar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            x_ar.Rows[i].Cells[j].Value = "K";
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
            r_ar.Visible = false;
            u_ar.Visible = false;
            c_ar.Visible = false;
            x_ar.Visible = false;
            max_val.Visible = true;
            year_mark.Visible = true;
            Fi.Visible = true;
            lastResult.Visible = true;
            int k = 10;
            int[][,] data = Arr3Create();
            int max = Max();
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
            strat = ShowStrategy(x1, k);
            if (k % 2 == 0)
            {
                year_mark.RowCount = k / 2;
            }
            else
            {
                year_mark.RowCount = k / 2 + 1;
            }
            year_mark.ColumnCount = 2;
            for (int i = 0; i < k; i++)
            {
                if (i >= k / 2)
                {
                    year_mark.Rows[i - k / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    year_mark.Rows[i].Cells[0].Value = strat[i];
                }
            }
            year_mark.Height = year_mark.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            Fi.Location = new System.Drawing.Point(26, year_mark.Location.Y + year_mark.Height + 30);


            //запис результатів до файлу
            ToFile(strat, k);

            //обчислення таблиці F(i)

            lastResult.RowCount = k;
            lastResult.ColumnCount = max;
            for (int i = 0; i < k; i++)
            {
                lastResult.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < max; j++)
            {
                lastResult.Columns[j].HeaderText = Convert.ToString(j);
            }
            lastResult.Height = lastResult.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + lastResult.ColumnHeadersHeight;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        lastResult.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        lastResult.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            lastResult.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            lastResult.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            lastResult.Location = new System.Drawing.Point(26, Fi.Location.Y + Fi.Height + 30);
        }

        
    }
}
