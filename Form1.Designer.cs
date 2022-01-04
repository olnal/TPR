
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.r_label = new System.Windows.Forms.Label();
            this.c_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.залежністьПрибуткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залежністьУтриманняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalisData = new System.Windows.Forms.ToolStripMenuItem();
            this.LessC = new System.Windows.Forms.ToolStripMenuItem();
            this.GreaterC = new System.Windows.Forms.ToolStripMenuItem();
            this.LessU = new System.Windows.Forms.ToolStripMenuItem();
            this.GreaterU = new System.Windows.Forms.ToolStripMenuItem();
            this.LessR = new System.Windows.Forms.ToolStripMenuItem();
            this.GreaterR = new System.Windows.Forms.ToolStripMenuItem();
            this.Close1 = new System.Windows.Forms.ToolStripMenuItem();
            this.u_label = new System.Windows.Forms.Label();
            this.desisison_table = new System.Windows.Forms.DataGridView();
            this.max_val_result = new System.Windows.Forms.Label();
            this.strategy_table = new System.Windows.Forms.DataGridView();
            this.data_result_table = new System.Windows.Forms.DataGridView();
            this.r_table = new System.Windows.Forms.DataGridView();
            this.u_table = new System.Windows.Forms.DataGridView();
            this.c_table = new System.Windows.Forms.DataGridView();
            this.data_result_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputPeriod = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desisison_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_result_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розрахунковий період";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(306, 222);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 13);
            this.l.TabIndex = 4;
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.r_label.Location = new System.Drawing.Point(24, 96);
            this.r_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(341, 20);
            this.r_label.TabIndex = 8;
            this.r_label.Text = "Залежність прибутку в році від віку машини ";
            this.r_label.Visible = false;
            // 
            // c_label
            // 
            this.c_label.AutoSize = true;
            this.c_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_label.Location = new System.Drawing.Point(24, 96);
            this.c_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.c_label.Name = "c_label";
            this.c_label.Size = new System.Drawing.Size(350, 20);
            this.c_label.TabIndex = 11;
            this.c_label.Text = "Залежність витрат на заміну від віку машини";
            this.c_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_1,
            this.Menu_2,
            this.результатToolStripMenuItem,
            this.AnalisData,
            this.Close1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
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
            this.Menu_1.Size = new System.Drawing.Size(100, 20);
            this.Menu_1.Text = "Початкові дані";
            // 
            // залежністьПрибуткуToolStripMenuItem
            // 
            this.залежністьПрибуткуToolStripMenuItem.Name = "залежністьПрибуткуToolStripMenuItem";
            this.залежністьПрибуткуToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.залежністьПрибуткуToolStripMenuItem.Text = "Прибуток";
            this.залежністьПрибуткуToolStripMenuItem.Click += new System.EventHandler(this.RInitialData);
            // 
            // залежністьУтриманняToolStripMenuItem
            // 
            this.залежністьУтриманняToolStripMenuItem.Name = "залежністьУтриманняToolStripMenuItem";
            this.залежністьУтриманняToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.залежністьУтриманняToolStripMenuItem.Text = "Утримання";
            this.залежністьУтриманняToolStripMenuItem.Click += new System.EventHandler(this.UInitialData);
            // 
            // залToolStripMenuItem
            // 
            this.залToolStripMenuItem.Name = "залToolStripMenuItem";
            this.залToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.залToolStripMenuItem.Text = "Заміна";
            this.залToolStripMenuItem.Click += new System.EventHandler(this.CInitialData);
            // 
            // Menu_2
            // 
            this.Menu_2.Name = "Menu_2";
            this.Menu_2.Size = new System.Drawing.Size(128, 20);
            this.Menu_2.Text = "Прийняття рішення";
            this.Menu_2.Click += new System.EventHandler(this.DesisionMaking);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.результатToolStripMenuItem.Text = "Результат";
            this.результатToolStripMenuItem.Click += new System.EventHandler(this.Result_Click);
            // 
            // AnalisData
            // 
            this.AnalisData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LessC,
            this.GreaterC,
            this.LessU,
            this.GreaterU,
            this.LessR,
            this.GreaterR});
            this.AnalisData.Name = "AnalisData";
            this.AnalisData.Size = new System.Drawing.Size(90, 20);
            this.AnalisData.Text = "Аналіз даних";
            // 
            // LessC
            // 
            this.LessC.Name = "LessC";
            this.LessC.Size = new System.Drawing.Size(285, 22);
            this.LessC.Text = "Зменшені витрати на заміну";
            this.LessC.Click += new System.EventHandler(this.LessC_Click);
            // 
            // GreaterC
            // 
            this.GreaterC.Name = "GreaterC";
            this.GreaterC.Size = new System.Drawing.Size(285, 22);
            this.GreaterC.Text = "Збільшені витрати на заміну";
            this.GreaterC.Click += new System.EventHandler(this.GreaterC_Click);
            // 
            // LessU
            // 
            this.LessU.Name = "LessU";
            this.LessU.Size = new System.Drawing.Size(285, 22);
            this.LessU.Text = "Зменшені витрати на обслуговування";
            this.LessU.Click += new System.EventHandler(this.LessU_Click);
            // 
            // GreaterU
            // 
            this.GreaterU.Name = "GreaterU";
            this.GreaterU.Size = new System.Drawing.Size(285, 22);
            this.GreaterU.Text = "Збільшені витрати на обслуговування";
            this.GreaterU.Click += new System.EventHandler(this.GreaterU_Click);
            // 
            // LessR
            // 
            this.LessR.Name = "LessR";
            this.LessR.Size = new System.Drawing.Size(285, 22);
            this.LessR.Text = "Зменшений прибуток";
            this.LessR.Click += new System.EventHandler(this.LessR_Click);
            // 
            // GreaterR
            // 
            this.GreaterR.Name = "GreaterR";
            this.GreaterR.Size = new System.Drawing.Size(285, 22);
            this.GreaterR.Text = "Збільшений прибуток";
            this.GreaterR.Click += new System.EventHandler(this.GreaterR_Click);
            // 
            // Close1
            // 
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(64, 20);
            this.Close1.Text = "Закрити";
            this.Close1.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // u_label
            // 
            this.u_label.AutoSize = true;
            this.u_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.u_label.Location = new System.Drawing.Point(24, 96);
            this.u_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u_label.Name = "u_label";
            this.u_label.Size = new System.Drawing.Size(384, 20);
            this.u_label.TabIndex = 17;
            this.u_label.Text = "Залежність витрат на утримання від віку машини";
            this.u_label.Visible = false;
            // 
            // desisison_table
            // 
            this.desisison_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.desisison_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.desisison_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desisison_table.Location = new System.Drawing.Point(23, 140);
            this.desisison_table.Name = "desisison_table";
            this.desisison_table.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.desisison_table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.desisison_table.Size = new System.Drawing.Size(680, 115);
            this.desisison_table.TabIndex = 19;
            this.desisison_table.Visible = false;
            // 
            // max_val_result
            // 
            this.max_val_result.AutoSize = true;
            this.max_val_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_val_result.ForeColor = System.Drawing.Color.White;
            this.max_val_result.Location = new System.Drawing.Point(24, 96);
            this.max_val_result.Name = "max_val_result";
            this.max_val_result.Size = new System.Drawing.Size(0, 20);
            this.max_val_result.TabIndex = 21;
            this.max_val_result.Visible = false;
            // 
            // strategy_table
            // 
            this.strategy_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.strategy_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.strategy_table.ColumnHeadersVisible = false;
            this.strategy_table.Location = new System.Drawing.Point(24, 140);
            this.strategy_table.Name = "strategy_table";
            this.strategy_table.RowHeadersVisible = false;
            this.strategy_table.RowHeadersWidth = 51;
            this.strategy_table.Size = new System.Drawing.Size(680, 115);
            this.strategy_table.TabIndex = 22;
            this.strategy_table.Visible = false;
            // 
            // data_result_table
            // 
            this.data_result_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_result_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_result_table.Location = new System.Drawing.Point(23, 371);
            this.data_result_table.Name = "data_result_table";
            this.data_result_table.RowHeadersWidth = 51;
            this.data_result_table.Size = new System.Drawing.Size(680, 115);
            this.data_result_table.TabIndex = 25;
            this.data_result_table.Visible = false;
            // 
            // r_table
            // 
            this.r_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.r_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.r_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r_table.Location = new System.Drawing.Point(23, 140);
            this.r_table.Name = "r_table";
            this.r_table.RowHeadersWidth = 50;
            this.r_table.Size = new System.Drawing.Size(680, 115);
            this.r_table.TabIndex = 19;
            this.r_table.Visible = false;
            // 
            // u_table
            // 
            this.u_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.u_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.u_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.u_table.Location = new System.Drawing.Point(24, 140);
            this.u_table.Name = "u_table";
            this.u_table.RowHeadersWidth = 50;
            this.u_table.Size = new System.Drawing.Size(680, 115);
            this.u_table.TabIndex = 19;
            this.u_table.Visible = false;
            // 
            // c_table
            // 
            this.c_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.c_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.c_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_table.Location = new System.Drawing.Point(23, 140);
            this.c_table.Name = "c_table";
            this.c_table.RowHeadersWidth = 50;
            this.c_table.Size = new System.Drawing.Size(680, 115);
            this.c_table.TabIndex = 19;
            this.c_table.Visible = false;
            // 
            // data_result_label
            // 
            this.data_result_label.AutoSize = true;
            this.data_result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_result_label.ForeColor = System.Drawing.Color.White;
            this.data_result_label.Location = new System.Drawing.Point(26, 348);
            this.data_result_label.Name = "data_result_label";
            this.data_result_label.Size = new System.Drawing.Size(362, 20);
            this.data_result_label.TabIndex = 23;
            this.data_result_label.Text = "Прибуток від експлуатації і заміни обладнання";
            this.data_result_label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(320, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "років";
            // 
            // InputPeriod
            // 
            this.InputPeriod.AutoSize = true;
            this.InputPeriod.BackColor = System.Drawing.Color.White;
            this.InputPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPeriod.ForeColor = System.Drawing.Color.Black;
            this.InputPeriod.Location = new System.Drawing.Point(279, 48);
            this.InputPeriod.Name = "InputPeriod";
            this.InputPeriod.Size = new System.Drawing.Size(36, 25);
            this.InputPeriod.TabIndex = 29;
            this.InputPeriod.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(756, 592);
            this.ControlBox = false;
            this.Controls.Add(this.InputPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_table);
            this.Controls.Add(this.u_table);
            this.Controls.Add(this.r_table);
            this.Controls.Add(this.data_result_table);
            this.Controls.Add(this.data_result_label);
            this.Controls.Add(this.strategy_table);
            this.Controls.Add(this.max_val_result);
            this.Controls.Add(this.desisison_table);
            this.Controls.Add(this.u_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c_label);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(772, 631);
            this.MinimumSize = new System.Drawing.Size(772, 631);
            this.Name = "Form1";
            this.Text = "Прийняття рішення";
            this.Activated += new System.EventHandler(this.Result_Click);
            this.Enter += new System.EventHandler(this.Result_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desisison_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_result_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Label c_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Close1;
        private System.Windows.Forms.Label u_label;
        private System.Windows.Forms.DataGridView desisison_table;
        private System.Windows.Forms.Label max_val_result;
        private System.Windows.Forms.DataGridView strategy_table;
        private System.Windows.Forms.DataGridView data_result_table;
        private System.Windows.Forms.ToolStripMenuItem Menu_1;
        private System.Windows.Forms.ToolStripMenuItem залежністьПрибуткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залежністьУтриманняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залToolStripMenuItem;
        private System.Windows.Forms.DataGridView r_table;
        private System.Windows.Forms.DataGridView u_table;
        private System.Windows.Forms.DataGridView c_table;
        private System.Windows.Forms.ToolStripMenuItem Menu_2;
        private System.Windows.Forms.Label data_result_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem AnalisData;
        private System.Windows.Forms.ToolStripMenuItem LessC;
        private System.Windows.Forms.ToolStripMenuItem GreaterC;
        private System.Windows.Forms.ToolStripMenuItem LessU;
        private System.Windows.Forms.ToolStripMenuItem GreaterU;
        private System.Windows.Forms.ToolStripMenuItem LessR;
        private System.Windows.Forms.ToolStripMenuItem GreaterR;
        private System.Windows.Forms.Label InputPeriod;
        private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
        
    }
}

