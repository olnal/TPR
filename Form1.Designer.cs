
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
            System.Windows.Forms.Label n;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.r_t = new System.Windows.Forms.Label();
            this.s_t = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.залежністьПрибуткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залежністьУтриманняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Close1 = new System.Windows.Forms.ToolStripMenuItem();
            this.u_t = new System.Windows.Forms.Label();
            this.x_ar = new System.Windows.Forms.DataGridView();
            this.max_val = new System.Windows.Forms.Label();
            this.year_mark = new System.Windows.Forms.DataGridView();
            this.Run = new System.Windows.Forms.Button();
            this.lastResult = new System.Windows.Forms.DataGridView();
            this.r_ar = new System.Windows.Forms.DataGridView();
            this.u_ar = new System.Windows.Forms.DataGridView();
            this.c_ar = new System.Windows.Forms.DataGridView();
            this.Fi = new System.Windows.Forms.Label();
            n = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // n
            // 
            n.AutoSize = true;
            n.BackColor = System.Drawing.Color.White;
            n.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            n.Location = new System.Drawing.Point(446, 62);
            n.Name = "n";
            n.Size = new System.Drawing.Size(47, 32);
            n.TabIndex = 27;
            n.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть вік машини";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(408, 273);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 17);
            this.l.TabIndex = 4;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(547, 101);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 17);
            this.l2.TabIndex = 5;
            // 
            // r_t
            // 
            this.r_t.AutoSize = true;
            this.r_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.r_t.Location = new System.Drawing.Point(25, 124);
            this.r_t.Name = "r_t";
            this.r_t.Size = new System.Drawing.Size(424, 25);
            this.r_t.TabIndex = 8;
            this.r_t.Text = "Залежність прибутку в році від віку машини ";
            this.r_t.Visible = false;
            // 
            // s_t
            // 
            this.s_t.AutoSize = true;
            this.s_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.s_t.Location = new System.Drawing.Point(25, 124);
            this.s_t.Name = "s_t";
            this.s_t.Size = new System.Drawing.Size(438, 25);
            this.s_t.TabIndex = 11;
            this.s_t.Text = "Витрати на утримання в році від віку машини ";
            this.s_t.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_1,
            this.Menu_2,
            this.Close1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_1
            // 
            this.Menu_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.залежністьПрибуткуToolStripMenuItem,
            this.залежністьУтриманняToolStripMenuItem,
            this.залToolStripMenuItem});
            this.Menu_1.Name = "Menu_1";
            this.Menu_1.Size = new System.Drawing.Size(126, 24);
            this.Menu_1.Text = "Початкові дані";
            // 
            // залежністьПрибуткуToolStripMenuItem
            // 
            this.залежністьПрибуткуToolStripMenuItem.Name = "залежністьПрибуткуToolStripMenuItem";
            this.залежністьПрибуткуToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.залежністьПрибуткуToolStripMenuItem.Text = "Прибуток";
            this.залежністьПрибуткуToolStripMenuItem.Click += new System.EventHandler(this.Menu11);
            // 
            // залежністьУтриманняToolStripMenuItem
            // 
            this.залежністьУтриманняToolStripMenuItem.Name = "залежністьУтриманняToolStripMenuItem";
            this.залежністьУтриманняToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.залежністьУтриманняToolStripMenuItem.Text = "Утримання";
            this.залежністьУтриманняToolStripMenuItem.Click += new System.EventHandler(this.Menu12);
            // 
            // залToolStripMenuItem
            // 
            this.залToolStripMenuItem.Name = "залToolStripMenuItem";
            this.залToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.залToolStripMenuItem.Text = "Заміна";
            this.залToolStripMenuItem.Click += new System.EventHandler(this.Menu13);
            // 
            // Menu_2
            // 
            this.Menu_2.Name = "Menu_2";
            this.Menu_2.Size = new System.Drawing.Size(161, 24);
            this.Menu_2.Text = "Прийняття рішення";
            this.Menu_2.Click += new System.EventHandler(this.Menu2);
            // 
            // Close1
            // 
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(79, 24);
            this.Close1.Text = "Закрити";
            this.Close1.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // u_t
            // 
            this.u_t.AutoSize = true;
            this.u_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_t.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.u_t.Location = new System.Drawing.Point(25, 124);
            this.u_t.Name = "u_t";
            this.u_t.Size = new System.Drawing.Size(397, 25);
            this.u_t.TabIndex = 17;
            this.u_t.Text = "Витрати на заміну в році від віку машини ";
            this.u_t.Visible = false;
            // 
            // x_ar
            // 
            this.x_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.x_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.x_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x_ar.Location = new System.Drawing.Point(31, 172);
            this.x_ar.Margin = new System.Windows.Forms.Padding(4);
            this.x_ar.Name = "x_ar";
            this.x_ar.RowHeadersWidth = 50;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.x_ar.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.x_ar.Size = new System.Drawing.Size(907, 142);
            this.x_ar.TabIndex = 19;
            this.x_ar.Visible = false;
            // 
            // max_val
            // 
            this.max_val.AutoSize = true;
            this.max_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_val.ForeColor = System.Drawing.Color.White;
            this.max_val.Location = new System.Drawing.Point(32, 118);
            this.max_val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max_val.Name = "max_val";
            this.max_val.Size = new System.Drawing.Size(0, 25);
            this.max_val.TabIndex = 21;
            this.max_val.Visible = false;
            // 
            // year_mark
            // 
            this.year_mark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.year_mark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.year_mark.ColumnHeadersVisible = false;
            this.year_mark.Location = new System.Drawing.Point(30, 172);
            this.year_mark.Margin = new System.Windows.Forms.Padding(4);
            this.year_mark.Name = "year_mark";
            this.year_mark.RowHeadersVisible = false;
            this.year_mark.RowHeadersWidth = 51;
            this.year_mark.Size = new System.Drawing.Size(907, 142);
            this.year_mark.TabIndex = 22;
            this.year_mark.Visible = false;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(712, 59);
            this.Run.Margin = new System.Windows.Forms.Padding(4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(216, 39);
            this.Run.TabIndex = 24;
            this.Run.Text = "Розрахувати";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // lastResult
            // 
            this.lastResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lastResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastResult.Location = new System.Drawing.Point(31, 457);
            this.lastResult.Margin = new System.Windows.Forms.Padding(4);
            this.lastResult.Name = "lastResult";
            this.lastResult.RowHeadersWidth = 51;
            this.lastResult.Size = new System.Drawing.Size(907, 142);
            this.lastResult.TabIndex = 25;
            this.lastResult.Visible = false;
            // 
            // r_ar
            // 
            this.r_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.r_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.r_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r_ar.Location = new System.Drawing.Point(30, 172);
            this.r_ar.Margin = new System.Windows.Forms.Padding(4);
            this.r_ar.Name = "r_ar";
            this.r_ar.RowHeadersWidth = 50;
            this.r_ar.Size = new System.Drawing.Size(907, 142);
            this.r_ar.TabIndex = 19;
            this.r_ar.Visible = false;
            // 
            // u_ar
            // 
            this.u_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.u_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.u_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.u_ar.Location = new System.Drawing.Point(31, 172);
            this.u_ar.Margin = new System.Windows.Forms.Padding(4);
            this.u_ar.Name = "u_ar";
            this.u_ar.RowHeadersWidth = 50;
            this.u_ar.Size = new System.Drawing.Size(907, 142);
            this.u_ar.TabIndex = 19;
            this.u_ar.Visible = false;
            // 
            // c_ar
            // 
            this.c_ar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_ar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.c_ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_ar.Location = new System.Drawing.Point(31, 172);
            this.c_ar.Margin = new System.Windows.Forms.Padding(4);
            this.c_ar.Name = "c_ar";
            this.c_ar.RowHeadersWidth = 50;
            this.c_ar.Size = new System.Drawing.Size(907, 142);
            this.c_ar.TabIndex = 19;
            this.c_ar.Visible = false;
                        // 
            // Fi
            // 
            this.Fi.AutoSize = true;
            this.Fi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fi.ForeColor = System.Drawing.Color.White;
            this.Fi.Location = new System.Drawing.Point(35, 428);
            this.Fi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fi.Name = "Fi";
            this.Fi.Size = new System.Drawing.Size(447, 25);
            this.Fi.TabIndex = 23;
            this.Fi.Text = "Прибуток від експлуатації і заміни обладнання";
            this.Fi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(n);
            this.Controls.Add(this.c_ar);
            this.Controls.Add(this.u_ar);
            this.Controls.Add(this.r_ar);
            this.Controls.Add(this.lastResult);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Fi);
            this.Controls.Add(this.year_mark);
            this.Controls.Add(this.max_val);
            this.Controls.Add(this.x_ar);
            this.Controls.Add(this.u_t);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_t);
            this.Controls.Add(this.r_t);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Прийняття рішення";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label r_t;
        private System.Windows.Forms.Label s_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Close1;
        private System.Windows.Forms.Label u_t;
        private System.Windows.Forms.DataGridView x_ar;
        private System.Windows.Forms.Label max_val;
        private System.Windows.Forms.DataGridView year_mark;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.DataGridView lastResult;
        private System.Windows.Forms.ToolStripMenuItem Menu_1;
        private System.Windows.Forms.ToolStripMenuItem залежністьПрибуткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залежністьУтриманняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залToolStripMenuItem;
        private System.Windows.Forms.DataGridView r_ar;
        private System.Windows.Forms.DataGridView u_ar;
        private System.Windows.Forms.DataGridView c_ar;
        private System.Windows.Forms.ToolStripMenuItem Menu_2;
        private System.Windows.Forms.Label Fi;
    }
}

