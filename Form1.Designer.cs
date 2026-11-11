namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.btnFilterTwo = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrandAge = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShowAll2 = new System.Windows.Forms.Button();
            this.btnGroupJoin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAll_Click = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckPrice = new System.Windows.Forms.TextBox();
            this.btnAny = new System.Windows.Forms.Button();
            this.txtAny = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCars.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCars.Location = new System.Drawing.Point(10, 12);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 72;
            this.dgvCars.RowTemplate.Height = 31;
            this.dgvCars.Size = new System.Drawing.Size(726, 333);
            this.dgvCars.TabIndex = 0;
            // 
            // dgvBrands
            // 
            this.dgvBrands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrands.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBrands.Location = new System.Drawing.Point(814, 12);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.RowHeadersWidth = 72;
            this.dgvBrands.RowTemplate.Height = 31;
            this.dgvBrands.Size = new System.Drawing.Size(734, 333);
            this.dgvBrands.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightYellow;
            this.btnFilter.Location = new System.Drawing.Point(45, 364);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(228, 38);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Цена > 50000";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightYellow;
            this.btnShowAll.Location = new System.Drawing.Point(45, 610);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(228, 57);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Показать все\r\nАвтомобили";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "2.";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.BackColor = System.Drawing.Color.LightYellow;
            this.txtMaxPrice.Location = new System.Drawing.Point(43, 431);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(230, 29);
            this.txtMaxPrice.TabIndex = 6;
            // 
            // btnFilterTwo
            // 
            this.btnFilterTwo.BackColor = System.Drawing.Color.LightYellow;
            this.btnFilterTwo.Location = new System.Drawing.Point(45, 466);
            this.btnFilterTwo.Name = "btnFilterTwo";
            this.btnFilterTwo.Size = new System.Drawing.Size(228, 43);
            this.btnFilterTwo.TabIndex = 7;
            this.btnFilterTwo.Text = "Найти Audi по цене";
            this.btnFilterTwo.UseVisualStyleBackColor = false;
            this.btnFilterTwo.Click += new System.EventHandler(this.btnFilterTwo_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LightYellow;
            this.btnSort.Location = new System.Drawing.Point(45, 528);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(228, 41);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Сортировка по цене";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "3.";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.LightYellow;
            this.btnCount.Location = new System.Drawing.Point(396, 364);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(244, 64);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Количество дорогих >20000";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // cmbOperation
            // 
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "Max",
            "Average",
            "Sum"});
            this.cmbOperation.Location = new System.Drawing.Point(396, 441);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(244, 32);
            this.cmbOperation.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(367, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "4.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightYellow;
            this.btnCalculate.Location = new System.Drawing.Point(395, 479);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(245, 43);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(367, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "5.";
            // 
            // btnBrandAge
            // 
            this.btnBrandAge.BackColor = System.Drawing.Color.LightYellow;
            this.btnBrandAge.Location = new System.Drawing.Point(954, 364);
            this.btnBrandAge.Name = "btnBrandAge";
            this.btnBrandAge.Size = new System.Drawing.Size(213, 67);
            this.btnBrandAge.TabIndex = 16;
            this.btnBrandAge.Text = "Рассчитать возраст";
            this.btnBrandAge.UseVisualStyleBackColor = false;
            this.btnBrandAge.Click += new System.EventHandler(this.btnBrandAge_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.LightYellow;
            this.btnGroup.Location = new System.Drawing.Point(954, 437);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(213, 72);
            this.btnGroup.TabIndex = 19;
            this.btnGroup.Text = "Группировка по\r\nстранам";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(924, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "6.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(924, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "7.";
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.LightYellow;
            this.btnJoin.Location = new System.Drawing.Point(954, 530);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(213, 60);
            this.btnJoin.TabIndex = 21;
            this.btnJoin.Text = "Соединение двух таблиц";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(924, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "8.";
            // 
            // btnShowAll2
            // 
            this.btnShowAll2.BackColor = System.Drawing.Color.LightYellow;
            this.btnShowAll2.Location = new System.Drawing.Point(954, 610);
            this.btnShowAll2.Name = "btnShowAll2";
            this.btnShowAll2.Size = new System.Drawing.Size(213, 57);
            this.btnShowAll2.TabIndex = 17;
            this.btnShowAll2.Text = "Показать все\r\nМарки";
            this.btnShowAll2.UseVisualStyleBackColor = false;
            this.btnShowAll2.Click += new System.EventHandler(this.btnShowAll2_Click);
            // 
            // btnGroupJoin
            // 
            this.btnGroupJoin.BackColor = System.Drawing.Color.LightYellow;
            this.btnGroupJoin.Location = new System.Drawing.Point(1225, 364);
            this.btnGroupJoin.Name = "btnGroupJoin";
            this.btnGroupJoin.Size = new System.Drawing.Size(258, 67);
            this.btnGroupJoin.TabIndex = 23;
            this.btnGroupJoin.Text = "Групповое соединение";
            this.btnGroupJoin.UseVisualStyleBackColor = false;
            this.btnGroupJoin.Click += new System.EventHandler(this.btnGroupJoin_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1195, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "9.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightYellow;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(19, 688);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1533, 46);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAll_Click
            // 
            this.btnAll_Click.BackColor = System.Drawing.Color.LightYellow;
            this.btnAll_Click.Location = new System.Drawing.Point(395, 585);
            this.btnAll_Click.Name = "btnAll_Click";
            this.btnAll_Click.Size = new System.Drawing.Size(245, 62);
            this.btnAll_Click.TabIndex = 26;
            this.btnAll_Click.Text = "Проверить все цены";
            this.btnAll_Click.UseVisualStyleBackColor = false;
            this.btnAll_Click.Click += new System.EventHandler(this.btnAll_Click_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(353, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "10.";
            // 
            // txtCheckPrice
            // 
            this.txtCheckPrice.BackColor = System.Drawing.Color.LightYellow;
            this.txtCheckPrice.Location = new System.Drawing.Point(395, 550);
            this.txtCheckPrice.Name = "txtCheckPrice";
            this.txtCheckPrice.Size = new System.Drawing.Size(245, 29);
            this.txtCheckPrice.TabIndex = 25;
            // 
            // btnAny
            // 
            this.btnAny.BackColor = System.Drawing.Color.LightYellow;
            this.btnAny.Location = new System.Drawing.Point(1225, 478);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(258, 68);
            this.btnAny.TabIndex = 27;
            this.btnAny.Text = "Проверить год основания";
            this.btnAny.UseVisualStyleBackColor = false;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // txtAny
            // 
            this.txtAny.BackColor = System.Drawing.SystemColors.Info;
            this.txtAny.Location = new System.Drawing.Point(1225, 437);
            this.txtAny.Name = "txtAny";
            this.txtAny.Size = new System.Drawing.Size(258, 29);
            this.txtAny.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1180, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "11.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(180)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1560, 746);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAny);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.dgvBrands);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.btnFilterTwo);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrandAge);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnShowAll2);
            this.Controls.Add(this.btnGroupJoin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAll_Click);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCheckPrice);
            this.Controls.Add(this.btnAny);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Lab5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Button btnFilterTwo;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrandAge;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowAll2;
        private System.Windows.Forms.Button btnGroupJoin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAll_Click;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckPrice;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.TextBox txtAny;
        private System.Windows.Forms.Label label11;
    }
}

