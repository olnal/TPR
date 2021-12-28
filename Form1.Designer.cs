
namespace TPR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.arr1 = new System.Windows.Forms.RichTextBox();
            this.r_t = new System.Windows.Forms.Label();
            this.s_t = new System.Windows.Forms.Label();
            this.arr2 = new System.Windows.Forms.RichTextBox();
            this.arr3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.u_t = new System.Windows.Forms.Label();
            this.x_ar = new System.Windows.Forms.DataGridView();
            this.w_ar = new System.Windows.Forms.DataGridView();
            this.max_val = new System.Windows.Forms.Label();
            this.year_mark = new System.Windows.Forms.DataGridView();
            this.Fi = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.lastResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість років";
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n.ForeColor = System.Drawing.Color.Black;
            this.n.Location = new System.Drawing.Point(281, 53);
            this.n.Margin = new System.Windows.Forms.Padding(2);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(94, 32);
            this.n.TabIndex = 1;
            this.n.TextChanged += new System.EventHandler(this.n_TextChanged);
            this.n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_KeyPress);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(306, 236);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 13);
            this.l.TabIndex = 4;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(410, 89);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 13);
            this.l2.TabIndex = 5;
            // 
            // arr1
            // 
            this.arr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr1.Location = new System.Drawing.Point(22, 142);
            this.arr1.Margin = new System.Windows.Forms.Padding(2);
            this.arr1.Name = "arr1";
            this.arr1.Size = new System.Drawing.Size(680, 182);
            this.arr1.TabIndex = 7;
            this.arr1.Text = "";
            this.arr1.Visible = false;
            // 
            // r_t
            // 
            this.r_t.AutoSize = true;
            this.r_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.r_t.Location = new System.Drawing.Point(19, 119);
            this.r_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.r_t.Name = "r_t";
            this.r_t.Size = new System.Drawing.Size(341, 20);
            this.r_t.TabIndex = 8;
            this.r_t.Text = "Залежність прибутку в році від віку машини ";
            this.r_t.Visible = false;
            // 
            // s_t
            // 
            this.s_t.AutoSize = true;
            this.s_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.s_t.Location = new System.Drawing.Point(19, 119);
            this.s_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.s_t.Name = "s_t";
            this.s_t.Size = new System.Drawing.Size(354, 20);
            this.s_t.TabIndex = 11;
            this.s_t.Text = "Витрати на утримання в році від віку машини ";
            this.s_t.Visible = false;
            // 
            // arr2
            // 
            this.arr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr2.Location = new System.Drawing.Point(22, 142);
            this.arr2.Margin = new System.Windows.Forms.Padding(2);
            this.arr2.Name = "arr2";
            this.arr2.Size = new System.Drawing.Size(680, 115);
            this.arr2.TabIndex = 10;
            this.arr2.Text = "";
            this.arr2.Visible = false;
            // 
            // arr3
            // 
            this.arr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr3.Location = new System.Drawing.Point(22, 142);
            this.arr3.Margin = new System.Windows.Forms.Padding(2);
            this.arr3.Name = "arr3";
            this.arr3.Size = new System.Drawing.Size(680, 115);
            this.arr3.TabIndex = 14;
            this.arr3.Text = "";
            this.arr3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2,
            this.menu3,
            this.menu4,
            this.menu5,
            this.Close});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.Enabled = false;
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(73, 20);
            this.menu1.Text = "Прибуток";
            this.menu1.Click += new System.EventHandler(this.Menu1_Click);
            // 
            // menu2
            // 
            this.menu2.Enabled = false;
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(80, 20);
            this.menu2.Text = "Утримання";
            this.menu2.Click += new System.EventHandler(this.Menu2_Click);
            // 
            // menu3
            // 
            this.menu3.Enabled = false;
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(57, 20);
            this.menu3.Text = "Заміна";
            this.menu3.Click += new System.EventHandler(this.Menu3_Click);
            // 
            // menu4
            // 
            this.menu4.Enabled = false;
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(73, 20);
            this.menu4.Text = "Прибуток";
            this.menu4.Click += new System.EventHandler(this.Menu4_Click);
            // 
            // menu5
            // 
            this.menu5.Enabled = false;
            this.menu5.Name = "menu5";
            this.menu5.Size = new System.Drawing.Size(66, 20);
            this.menu5.Text = "Рішення";
            this.menu5.Click += new System.EventHandler(this.Menu5_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(64, 20);
            this.Close.Text = "Закрити";
            this.Close.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // u_t
            // 
            this.u_t.AutoSize = true;
            this.u_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.u_t.Location = new System.Drawing.Point(19, 119);
            this.u_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_t.Name = "u_t";
            this.u_t.Size = new System.Drawing.Size(320, 20);
            this.u_t.TabIndex = 17;
            this.u_t.Text = "Витрати на заміну в році від віку машини ";
            this.u_t.Visible = false;
            // 
            // x_ar
            // 
            this.x_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.x_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.x_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x_ar.Location = new System.Drawing.Point(25, 142);
            this.x_ar.Name = "x_ar";
            this.x_ar.RowHeadersWidth = 50;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.x_ar.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.x_ar.Size = new System.Drawing.Size(680, 115);
            this.x_ar.TabIndex = 19;
            this.x_ar.Visible = false;
            // 
            // w_ar
            // 
            this.w_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.w_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.w_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.w_ar.Location = new System.Drawing.Point(25, 143);
            this.w_ar.Name = "w_ar";
            this.w_ar.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.w_ar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.w_ar.Size = new System.Drawing.Size(680, 115);
            this.w_ar.TabIndex = 20;
            this.w_ar.Visible = false;
            // 
            // max_val
            // 
            this.max_val.AutoSize = true;
            this.max_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_val.ForeColor = System.Drawing.Color.White;
            this.max_val.Location = new System.Drawing.Point(24, 114);
            this.max_val.Name = "max_val";
            this.max_val.Size = new System.Drawing.Size(0, 20);
            this.max_val.TabIndex = 21;
            this.max_val.Visible = false;
            // 
            // year_mark
            // 
            this.year_mark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.year_mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.year_mark.ColumnHeadersVisible = false;
            this.year_mark.Location = new System.Drawing.Point(20, 143);
            this.year_mark.Name = "year_mark";
            this.year_mark.RowHeadersVisible = false;
            this.year_mark.Size = new System.Drawing.Size(680, 115);
            this.year_mark.TabIndex = 22;
            this.year_mark.Visible = false;
            // 
            // Fi
            // 
            this.Fi.AutoSize = true;
            this.Fi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fi.ForeColor = System.Drawing.Color.White;
            this.Fi.Location = new System.Drawing.Point(26, 348);
            this.Fi.Name = "Fi";
            this.Fi.Size = new System.Drawing.Size(259, 20);
            this.Fi.TabIndex = 23;
            this.Fi.Text = "Обчислимо значення функції  F(i)";
            this.Fi.Visible = false;
            // 
            // Run
            // 
            this.Run.Enabled = false;
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(536, 50);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(162, 32);
            this.Run.TabIndex = 24;
            this.Run.Text = "Розрахувати";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // lastResult
            // 
            this.lastResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lastResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastResult.Location = new System.Drawing.Point(23, 380);
            this.lastResult.Name = "lastResult";
            this.lastResult.Size = new System.Drawing.Size(680, 115);
            this.lastResult.TabIndex = 25;
            this.lastResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lastResult);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Fi);
            this.Controls.Add(this.year_mark);
            this.Controls.Add(this.max_val);
            this.Controls.Add(this.w_ar);
            this.Controls.Add(this.x_ar);
            this.Controls.Add(this.u_t);
            this.Controls.Add(this.arr3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_t);
            this.Controls.Add(this.arr2);
            this.Controls.Add(this.r_t);
            this.Controls.Add(this.arr1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Прийняття рішення";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.RichTextBox arr1;
        private System.Windows.Forms.Label r_t;
        private System.Windows.Forms.Label s_t;
        private System.Windows.Forms.RichTextBox arr2;
        private System.Windows.Forms.RichTextBox arr3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem menu3;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.Label u_t;
        private System.Windows.Forms.DataGridView x_ar;
        private System.Windows.Forms.ToolStripMenuItem menu4;
        private System.Windows.Forms.ToolStripMenuItem menu5;
        private System.Windows.Forms.DataGridView w_ar;
        private System.Windows.Forms.Label max_val;
        private System.Windows.Forms.DataGridView year_mark;
        private System.Windows.Forms.Label Fi;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.DataGridView lastResult;
    }
}

