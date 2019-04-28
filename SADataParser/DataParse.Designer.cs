namespace SADataParser
{
    partial class DataParse
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
            this.lblDataParserCaption = new System.Windows.Forms.Label();
            this.lblInputBox = new System.Windows.Forms.Label();
            this.txtSearchFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownTabNo = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTabNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataParserCaption
            // 
            this.lblDataParserCaption.AutoSize = true;
            this.lblDataParserCaption.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataParserCaption.Location = new System.Drawing.Point(12, 9);
            this.lblDataParserCaption.Name = "lblDataParserCaption";
            this.lblDataParserCaption.Size = new System.Drawing.Size(193, 32);
            this.lblDataParserCaption.TabIndex = 0;
            this.lblDataParserCaption.Text = "Data Parser";
            // 
            // lblInputBox
            // 
            this.lblInputBox.AutoSize = true;
            this.lblInputBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInputBox.Location = new System.Drawing.Point(3, 0);
            this.lblInputBox.Name = "lblInputBox";
            this.lblInputBox.Size = new System.Drawing.Size(56, 13);
            this.lblInputBox.TabIndex = 0;
            this.lblInputBox.Text = "Select File";
            // 
            // txtSearchFile
            // 
            this.txtSearchFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFile.Location = new System.Drawing.Point(125, 3);
            this.txtSearchFile.Name = "txtSearchFile";
            this.txtSearchFile.Size = new System.Drawing.Size(223, 20);
            this.txtSearchFile.TabIndex = 4;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(354, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(64, 21);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "Browse ";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parse Column/Tab No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Format Data ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.10288F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.11934F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.57202F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseFile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInputBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFormat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownTabNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 112);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(125, 59);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(223, 21);
            this.comboBoxFormat.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "Process Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownTabNo
            // 
            this.numericUpDownTabNo.Location = new System.Drawing.Point(125, 31);
            this.numericUpDownTabNo.Name = "numericUpDownTabNo";
            this.numericUpDownTabNo.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownTabNo.TabIndex = 12;
            // 
            // DataParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 167);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblDataParserCaption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataParse";
            this.Text = "Parse Data";
            this.Load += new System.EventHandler(this.DataParse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTabNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataParserCaption;
        private System.Windows.Forms.Label lblInputBox;
        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownTabNo;
    }
}