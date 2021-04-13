namespace Lab06connect
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCommand1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxAttribute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.textBoxTableCmd = new System.Windows.Forms.TextBox();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoQuery = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCmd2 = new System.Windows.Forms.Button();
            this.textBoxValuesCmd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFields = new System.Windows.Forms.TextBox();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnCmd1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // dgwData
            // 
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(11, 12);
            this.dgwData.Name = "dgwData";
            this.dgwData.Size = new System.Drawing.Size(618, 316);
            this.dgwData.TabIndex = 2;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(86, 59);
            this.textBoxTable.Multiline = true;
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(128, 20);
            this.textBoxTable.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCmd1);
            this.groupBox1.Controls.Add(this.cmbSort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbCommand1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxValue);
            this.groupBox1.Controls.Add(this.textBoxAttribute);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(635, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation (SELECT/SEARCH/SORT)";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(86, 154);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(127, 24);
            this.cmbSort.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sort:";
            // 
            // cmbCommand1
            // 
            this.cmbCommand1.FormattingEnabled = true;
            this.cmbCommand1.Location = new System.Drawing.Point(87, 27);
            this.cmbCommand1.Name = "cmbCommand1";
            this.cmbCommand1.Size = new System.Drawing.Size(127, 24);
            this.cmbCommand1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Command:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(86, 123);
            this.textBoxValue.Multiline = true;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(128, 20);
            this.textBoxValue.TabIndex = 10;
            // 
            // textBoxAttribute
            // 
            this.textBoxAttribute.Location = new System.Drawing.Point(86, 92);
            this.textBoxAttribute.Multiline = true;
            this.textBoxAttribute.Name = "textBoxAttribute";
            this.textBoxAttribute.Size = new System.Drawing.Size(128, 20);
            this.textBoxAttribute.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attribute:";
            // 
            // textBoxSet
            // 
            this.textBoxSet.Location = new System.Drawing.Point(279, 24);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(135, 23);
            this.textBoxSet.TabIndex = 8;
            // 
            // textBoxTableCmd
            // 
            this.textBoxTableCmd.Location = new System.Drawing.Point(87, 60);
            this.textBoxTableCmd.Name = "textBoxTableCmd";
            this.textBoxTableCmd.Size = new System.Drawing.Size(127, 23);
            this.textBoxTableCmd.TabIndex = 10;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(15, 22);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(467, 94);
            this.textBoxQuery.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoQuery);
            this.groupBox2.Controls.Add(this.textBoxQuery);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // btnDoQuery
            // 
            this.btnDoQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoQuery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoQuery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDoQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDoQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoQuery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoQuery.ForeColor = System.Drawing.Color.White;
            this.btnDoQuery.Location = new System.Drawing.Point(497, 51);
            this.btnDoQuery.Name = "btnDoQuery";
            this.btnDoQuery.Size = new System.Drawing.Size(90, 28);
            this.btnDoQuery.TabIndex = 14;
            this.btnDoQuery.Text = "Do";
            this.btnDoQuery.UseVisualStyleBackColor = false;
            this.btnDoQuery.Click += new System.EventHandler(this.btnDoQuery_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCmd2);
            this.groupBox3.Controls.Add(this.textBoxValuesCmd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxFields);
            this.groupBox3.Controls.Add(this.textBoxWhere);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbCommand);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSet);
            this.groupBox3.Controls.Add(this.textBoxTableCmd);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(926, 158);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation (INSERT/UPDATE/DELETE)";
            // 
            // btnCmd2
            // 
            this.btnCmd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCmd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCmd2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCmd2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCmd2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCmd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmd2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCmd2.ForeColor = System.Drawing.Color.White;
            this.btnCmd2.Location = new System.Drawing.Point(106, 100);
            this.btnCmd2.Name = "btnCmd2";
            this.btnCmd2.Size = new System.Drawing.Size(90, 28);
            this.btnCmd2.TabIndex = 15;
            this.btnCmd2.Text = "Do";
            this.btnCmd2.UseVisualStyleBackColor = false;
            this.btnCmd2.Click += new System.EventHandler(this.btnCmd2_Click);
            // 
            // textBoxValuesCmd
            // 
            this.textBoxValuesCmd.Location = new System.Drawing.Point(277, 61);
            this.textBoxValuesCmd.Multiline = true;
            this.textBoxValuesCmd.Name = "textBoxValuesCmd";
            this.textBoxValuesCmd.Size = new System.Drawing.Size(559, 68);
            this.textBoxValuesCmd.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(220, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Values:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(220, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fields:";
            // 
            // textBoxFields
            // 
            this.textBoxFields.Location = new System.Drawing.Point(279, 25);
            this.textBoxFields.Name = "textBoxFields";
            this.textBoxFields.Size = new System.Drawing.Size(557, 23);
            this.textBoxFields.TabIndex = 17;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(279, 60);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(135, 23);
            this.textBoxWhere.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Command:";
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Location = new System.Drawing.Point(87, 24);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(127, 24);
            this.cmbCommand.TabIndex = 12;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "From:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(639, 278);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 16);
            this.labelInfo.TabIndex = 14;
            // 
            // btnCmd1
            // 
            this.btnCmd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCmd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCmd1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCmd1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCmd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmd1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCmd1.ForeColor = System.Drawing.Color.White;
            this.btnCmd1.Location = new System.Drawing.Point(106, 184);
            this.btnCmd1.Name = "btnCmd1";
            this.btnCmd1.Size = new System.Drawing.Size(90, 28);
            this.btnCmd1.TabIndex = 15;
            this.btnCmd1.Text = "Do";
            this.btnCmd1.UseVisualStyleBackColor = false;
            this.btnCmd1.Click += new System.EventHandler(this.btnCmd1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 643);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Laboratory work 6";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwData;

        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxAttribute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSet;
        private System.Windows.Forms.TextBox textBoxTableCmd;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValuesCmd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFields;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Button btnCmd2;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCommand1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCmd1;
    }
}

