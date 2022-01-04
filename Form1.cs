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
        const byte old = 3, period = 10;
        static readonly byte maxOld = period + old;
        public Form1()
        {
            InitializeComponent();
        }
        //read data from file
        private int[][,] DataFromXML()
        {
            int i, j = 0, f;
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
                        ArrYear[i] = new int[old, maxOld - 1 - Int32.Parse(attrYearPro.Value)];
                    }
                    else
                    {
                        i = Int32.Parse(attrYearPro.Value);
                        ArrYear[i] = new int[old, maxOld - 2 - Int32.Parse(attrYearPro.Value)];
                    }

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        XmlNode atrYear = childnode.Attributes.GetNamedItem("year");
                        f = Int32.Parse(atrYear.Value);
                        foreach (XmlNode child in childnode.ChildNodes)
                        {
                            if (child.Name == "sum")
                            {
                                ArrYear[i][j, f] = Convert.ToInt32(child.InnerText);
                                j++;
                            }
                            if (child.Name == "serviseCost")
                            {
                                ArrYear[i][j, f] = Convert.ToInt32(child.InnerText);
                                j++;
                            }
                            if (child.Name == "changeCost")
                            {
                                ArrYear[i][j, f] = Convert.ToInt32(child.InnerText);
                                j = 0;
                            }
                        }
                    }
                }
            }
            return ArrYear;
        }
        //Create arrey functiot r,u or c (type 0, 1 or 2)
        private int[,] ArrCreate(int[][,] data, int type)
        {
            int[,] result = new int[period + 1, maxOld];
            for (int i = 0; i <= period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    result[i, j] = -1;
                }
            }
            for (int i = 0; i <= period; i++)
            {
                result[i, i + 2] = data[0][type, i + 2];
                for (int j = 0; j < i; j++)
                {
                    result[i, j] = data[i - j][type, j];
                }
            }
            return result;
        }
        //Create array desisison for begining 
        private void ArraysDesisison(ref int[,] w, ref char[,] x)
        {
            for (int i = 0; i > period + 1; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w[i, j] = 1;
                    x[i, j] = 'f';
                }
            }
        }
        //Create desisison
        private void Desision(int[,] r, int[,] u, int[,] c, ref int[,] w, ref char[,] x)
        {
            int safe, change;
            ArraysDesisison(ref w, ref x);
            for (int i = period; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i == period)
                    {
                        safe = r[i, j] - u[i, j];
                        change = r[i, 0] - u[i, 0] - c[i, j];
                    }
                    else
                    {
                        safe = r[i, j] - u[i, j] + w[i + 1, j + 1];
                        change = r[i, 0] - u[i, 0] - c[i, j] + w[i + 1, 1];
                    }
                    if (safe >= change)
                    {
                        w[i, j] = safe;
                        x[i, j] = 's';
                    }
                    else
                    {
                        w[i, j] = change;
                        x[i, j] = 'c';
                    }
                }
                if (i == period)
                {
                    safe = r[i, i + 2] - u[i, i + 2];
                    change = r[i, 0] - u[i, 0] - c[i, i + 2];
                }
                else
                {
                    safe = r[i, i + 2] - u[i, i + 2] + w[i + 1, i + 3];
                    change = r[i, 0] - u[i, 0] - c[i, i + 2] + w[i + 1, 1];
                }
                if (safe >= change)
                {
                    w[i, i + 2] = safe;
                    x[i, i + 2] = 's';
                }
                else
                {
                    w[i, i + 2] = change;
                    x[i, i + 2] = 'c';
                }
            }
        }
        //Create strategy
        private string[] CreateStrategy(char[,] x)
        {
            string[] result = new string[period];
            int h = 3;
            for (int i = 0; i < period; i++)
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
        //save result to File result.txt
        private void ToFile(string[] str)
        {
            string path = "result.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < period; i++)
                {
                    sw.WriteLine(str[i]);
                }
            }
        }
        //View initial data function r
        private void RInitialData(object sender, EventArgs e)
        {
            r_label.Visible = true;            
            u_label.Visible = false;
            c_label.Visible = false;
            r_table.Visible = true;
            u_table.Visible = false;
            c_table.Visible = false;
            max_val_result.Visible = false;
            desisison_table.Visible = false;
            strategy_table.Visible = false;
            data_result_label.Visible = false;
            data_result_table.Visible = false;
            int[,] rArr = ArrCreate(DataFromXML(), 0);
            r_table.RowCount = period;
            r_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                r_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                r_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < period; i++)
                for (int j = 0; j < maxOld; j++)
                {
                    if (rArr[i + 1, j] != -1)
                    {
                        r_table.Rows[i].Cells[j].Value = rArr[i + 1, j];
                    }
                }
            r_table.Height = r_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + r_table.ColumnHeadersHeight;
        }
        //View initial data function u
        private void UInitialData(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = true;
            r_table.Visible = false;
            u_table.Visible = true;
            c_table.Visible = false;
            max_val_result.Visible = false;
            desisison_table.Visible = false;
            strategy_table.Visible = false;
            data_result_label.Visible = false;
            data_result_table.Visible = false;
            int[,] uArr = ArrCreate(DataFromXML(), 1);
            u_table.RowCount = period;
            u_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                u_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                u_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < period; i++)
                for (int j = 0; j < maxOld; j++)
                {
                    if (uArr[i + 1, j] != -1)
                    {
                        u_table.Rows[i].Cells[j].Value = uArr[i + 1, j];
                    }
                }
            u_table.Height = u_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + u_table.ColumnHeadersHeight;
        }
        //View initial data function c
        private void CInitialData(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = true;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = true;
            desisison_table.Visible = false;
            max_val_result.Visible = false;
            strategy_table.Visible = false;
            data_result_label.Visible = false;
            data_result_table.Visible = false;
            int[,] cArr = ArrCreate(DataFromXML(), 2);
            c_table.RowCount = period;
            c_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                c_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                c_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < period; i++)
                for (int j = 0; j < maxOld; j++)
                {
                    if (cArr[i + 1, j] != -1)
                    {
                        c_table.Rows[i].Cells[j].Value = cArr[i + 1, j];
                    }
                }
            c_table.Height = c_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + c_table.ColumnHeadersHeight;
        }
        //Desision making C or K
        private void DesisionMaking(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            max_val_result.Visible = false;
            desisison_table.Visible = true;
            strategy_table.Visible = false;
            data_result_label.Visible = false;
            data_result_table.Visible = false;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            int[,] valDesisison = new int[period + 1, maxOld];
            char[,] charDesision = new char[period + 1, maxOld];
            Desision(r, u, c, ref valDesisison, ref charDesision);
            desisison_table.RowCount = period;
            desisison_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                desisison_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                desisison_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            for (int i = 0; i < period; i++)
                for (int j = 0; j < maxOld; j++)
                {
                    if (charDesision[i + 1, j] == 's')
                    {
                        desisison_table.Rows[i].Cells[j].Value = "C";
                        desisison_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        if (charDesision[i + 1, j] == 'c')
                        {
                            desisison_table.Rows[i].Cells[j].Value = "K";
                            desisison_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                        }
                    }
                }
            desisison_table.Height = desisison_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + desisison_table.ColumnHeadersHeight;
        }
        //data analysis
        private void LessC_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (i % 2 == 0) c[i, j] = c[i, j] - 100;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }

        private void GreaterC_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    c[i, j] = c[i, j] + 50;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }

        private void LessU_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    u[i, j] = u[i, j] - 5;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }
        private void GreaterU_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    u[i, j] = u[i, j] + 5;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }

        private void LessR_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    r[i, j] = r[i, j] - 25;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }
        
        private void GreaterR_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    r[i, j] = r[i, j] + 25;
                }
            }
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }        

        private void Result_Click(object sender, EventArgs e)
        {
            r_label.Visible = false;
            c_label.Visible = false;
            u_label.Visible = false;
            r_table.Visible = false;
            u_table.Visible = false;
            c_table.Visible = false;
            desisison_table.Visible = false;
            max_val_result.Visible = true;
            strategy_table.Visible = true;
            data_result_label.Visible = true;
            data_result_table.Visible = true;
            int[,] r = ArrCreate(DataFromXML(), 0);
            int[,] u = ArrCreate(DataFromXML(), 1);
            int[,] c = ArrCreate(DataFromXML(), 2);
            int[,] w = new int[period + 1, maxOld];
            char[,] x = new char[period + 1, maxOld];
            Desision(r, u, c, ref w, ref x);
            int mark = w[1, 3];
            max_val_result.Text = "Максимальний прибуток становить - " + mark;
            int[,] w1 = new int[period, maxOld];
            char[,] x1 = new char[period, maxOld];
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    w1[i, j] = w[i + 1, j];
                    x1[i, j] = x[i + 1, j];
                }
            }
            string[] strat = CreateStrategy(x1);
            if (period % 2 == 0)
            {
                strategy_table.RowCount = period / 2;
            }
            else
            {
                strategy_table.RowCount = period / 2 + 1;
            }
            strategy_table.ColumnCount = 2;
            for (int i = 0; i < period; i++)
            {
                if (i >= period / 2)
                {
                    strategy_table.Rows[i - period / 2].Cells[1].Value = strat[i];
                }
                else
                {
                    strategy_table.Rows[i].Cells[0].Value = strat[i];
                }
            }
            strategy_table.Height = strategy_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            data_result_label.Location = new System.Drawing.Point(26, strategy_table.Location.Y + strategy_table.Height + 30);
            //запис результатів до файлу
            ToFile(strat);
            //обчислення таблиці F(i)
            data_result_table.RowCount = period;
            data_result_table.ColumnCount = maxOld;
            for (int i = 0; i < period; i++)
            {
                data_result_table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int j = 0; j < maxOld; j++)
            {
                data_result_table.Columns[j].HeaderText = Convert.ToString(j);
            }
            data_result_table.Height = data_result_table.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + data_result_table.ColumnHeadersHeight;
            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < maxOld; j++)
                {
                    if (x[i + 1, j] == 's')
                    {
                        data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 255, 0);
                        data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                    }
                    else
                    {
                        if (x[i + 1, j] == 'c')
                        {
                            data_result_table.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 0, 0);
                            data_result_table.Rows[i].Cells[j].Value = w[i + 1, j];
                        }
                    }
                }
            }
            data_result_table.Location = new System.Drawing.Point(26, data_result_label.Location.Y + data_result_label.Height + 30);
        }

        //Close window
        private void MenuClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
