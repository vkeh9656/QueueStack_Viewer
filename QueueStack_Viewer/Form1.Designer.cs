namespace QueueStack_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQueue0 = new System.Windows.Forms.Label();
            this.lblQueue1 = new System.Windows.Forms.Label();
            this.lblQueue2 = new System.Windows.Forms.Label();
            this.lblQueue3 = new System.Windows.Forms.Label();
            this.lblQueue4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQueue5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblStack5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblStack4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblStack3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStack2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStack1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStack0 = new System.Windows.Forms.Label();
            this.btnDataIn = new System.Windows.Forms.Button();
            this.btnDataOut = new System.Windows.Forms.Button();
            this.btnDataAutoOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stack";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Controls.Add(this.lblQueue0, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 85);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblQueue0
            // 
            this.lblQueue0.AutoSize = true;
            this.lblQueue0.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue0.Location = new System.Drawing.Point(418, 3);
            this.lblQueue0.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue0.Name = "lblQueue0";
            this.lblQueue0.Size = new System.Drawing.Size(78, 44);
            this.lblQueue0.TabIndex = 16;
            this.lblQueue0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue1
            // 
            this.lblQueue1.AutoSize = true;
            this.lblQueue1.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue1.Location = new System.Drawing.Point(335, 3);
            this.lblQueue1.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue1.Name = "lblQueue1";
            this.lblQueue1.Size = new System.Drawing.Size(77, 44);
            this.lblQueue1.TabIndex = 15;
            this.lblQueue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue2
            // 
            this.lblQueue2.AutoSize = true;
            this.lblQueue2.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue2.Location = new System.Drawing.Point(252, 3);
            this.lblQueue2.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue2.Name = "lblQueue2";
            this.lblQueue2.Size = new System.Drawing.Size(77, 44);
            this.lblQueue2.TabIndex = 14;
            this.lblQueue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue3
            // 
            this.lblQueue3.AutoSize = true;
            this.lblQueue3.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue3.Location = new System.Drawing.Point(169, 3);
            this.lblQueue3.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue3.Name = "lblQueue3";
            this.lblQueue3.Size = new System.Drawing.Size(77, 44);
            this.lblQueue3.TabIndex = 13;
            this.lblQueue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue4
            // 
            this.lblQueue4.AutoSize = true;
            this.lblQueue4.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue4.Location = new System.Drawing.Point(86, 3);
            this.lblQueue4.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue4.Name = "lblQueue4";
            this.lblQueue4.Size = new System.Drawing.Size(77, 44);
            this.lblQueue4.TabIndex = 12;
            this.lblQueue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(415, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 35);
            this.label13.TabIndex = 11;
            this.label13.Text = "[0]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(332, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 35);
            this.label12.TabIndex = 10;
            this.label12.Text = "[1]";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(249, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 35);
            this.label11.TabIndex = 9;
            this.label11.Text = "[2]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(166, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 35);
            this.label10.TabIndex = 8;
            this.label10.Text = "[3]";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(83, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 35);
            this.label9.TabIndex = 7;
            this.label9.Text = "[4]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(0, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "[5]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue5
            // 
            this.lblQueue5.AutoSize = true;
            this.lblQueue5.BackColor = System.Drawing.SystemColors.Control;
            this.lblQueue5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQueue5.Location = new System.Drawing.Point(3, 3);
            this.lblQueue5.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue5.Name = "lblQueue5";
            this.lblQueue5.Size = new System.Drawing.Size(77, 44);
            this.lblQueue5.TabIndex = 0;
            this.lblQueue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label20, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblStack5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblStack4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblStack3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStack2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStack1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStack0, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(157, 195);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 147);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(207, 120);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 27);
            this.label20.TabIndex = 11;
            this.label20.Text = "[5]";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack5
            // 
            this.lblStack5.AutoSize = true;
            this.lblStack5.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack5.Location = new System.Drawing.Point(3, 120);
            this.lblStack5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack5.Name = "lblStack5";
            this.lblStack5.Size = new System.Drawing.Size(201, 24);
            this.lblStack5.TabIndex = 10;
            this.lblStack5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(207, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "[4]";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack4
            // 
            this.lblStack4.AutoSize = true;
            this.lblStack4.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack4.Location = new System.Drawing.Point(3, 96);
            this.lblStack4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack4.Name = "lblStack4";
            this.lblStack4.Size = new System.Drawing.Size(201, 21);
            this.lblStack4.TabIndex = 8;
            this.lblStack4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(207, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 24);
            this.label16.TabIndex = 7;
            this.label16.Text = "[3]";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack3
            // 
            this.lblStack3.AutoSize = true;
            this.lblStack3.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack3.Location = new System.Drawing.Point(3, 72);
            this.lblStack3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack3.Name = "lblStack3";
            this.lblStack3.Size = new System.Drawing.Size(201, 21);
            this.lblStack3.TabIndex = 6;
            this.lblStack3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(207, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "[2]";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack2
            // 
            this.lblStack2.AutoSize = true;
            this.lblStack2.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack2.Location = new System.Drawing.Point(3, 48);
            this.lblStack2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack2.Name = "lblStack2";
            this.lblStack2.Size = new System.Drawing.Size(201, 21);
            this.lblStack2.TabIndex = 4;
            this.lblStack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(207, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "[1]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack1
            // 
            this.lblStack1.AutoSize = true;
            this.lblStack1.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack1.Location = new System.Drawing.Point(3, 24);
            this.lblStack1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack1.Name = "lblStack1";
            this.lblStack1.Size = new System.Drawing.Size(201, 21);
            this.lblStack1.TabIndex = 2;
            this.lblStack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(207, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "[0]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack0
            // 
            this.lblStack0.AutoSize = true;
            this.lblStack0.BackColor = System.Drawing.SystemColors.Control;
            this.lblStack0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack0.Location = new System.Drawing.Point(3, 0);
            this.lblStack0.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblStack0.Name = "lblStack0";
            this.lblStack0.Size = new System.Drawing.Size(201, 21);
            this.lblStack0.TabIndex = 0;
            this.lblStack0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDataIn
            // 
            this.btnDataIn.Location = new System.Drawing.Point(28, 119);
            this.btnDataIn.Name = "btnDataIn";
            this.btnDataIn.Size = new System.Drawing.Size(93, 37);
            this.btnDataIn.TabIndex = 18;
            this.btnDataIn.Text = "In";
            this.btnDataIn.UseVisualStyleBackColor = true;
            this.btnDataIn.Click += new System.EventHandler(this.btnDataIn_Click);
            // 
            // btnDataOut
            // 
            this.btnDataOut.Location = new System.Drawing.Point(434, 119);
            this.btnDataOut.Name = "btnDataOut";
            this.btnDataOut.Size = new System.Drawing.Size(93, 37);
            this.btnDataOut.TabIndex = 19;
            this.btnDataOut.Text = "Out";
            this.btnDataOut.UseVisualStyleBackColor = true;
            this.btnDataOut.Click += new System.EventHandler(this.btnDataOut_Click);
            // 
            // btnDataAutoOut
            // 
            this.btnDataAutoOut.Location = new System.Drawing.Point(335, 119);
            this.btnDataAutoOut.Name = "btnDataAutoOut";
            this.btnDataAutoOut.Size = new System.Drawing.Size(93, 37);
            this.btnDataAutoOut.TabIndex = 20;
            this.btnDataAutoOut.Text = "Auto Out";
            this.btnDataAutoOut.UseVisualStyleBackColor = true;
            this.btnDataAutoOut.Click += new System.EventHandler(this.btnDataAutoOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 367);
            this.Controls.Add(this.btnDataAutoOut);
            this.Controls.Add(this.btnDataOut);
            this.Controls.Add(this.btnDataIn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblQueue5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQueue0;
        private System.Windows.Forms.Label lblQueue1;
        private System.Windows.Forms.Label lblQueue2;
        private System.Windows.Forms.Label lblQueue3;
        private System.Windows.Forms.Label lblQueue4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblStack5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblStack4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblStack3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblStack2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStack1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStack0;
        private System.Windows.Forms.Button btnDataIn;
        private System.Windows.Forms.Button btnDataOut;
        private System.Windows.Forms.Button btnDataAutoOut;
    }
}

