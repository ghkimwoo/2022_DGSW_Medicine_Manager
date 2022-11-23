using ProjectPT_Remaster.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectPT_Remaster
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private List<Label> menws;
        private List<Color> menw_colors;

        List<Medicine> medicines = new List<Medicine>();
        SQLiteControl sqlControl = new SQLiteControl();

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        /// 
        private void Form1_Load(object sender, EventArgs e)
        {
            menws = new List<Label>();
            menws.Add(btn_Menu1);
            menws.Add(btn_Menu2);
            menws.Add(btn_Menu3);

            menw_colors = new List<Color>();
            menw_colors.Add(Color.FromArgb(53, 124, 225));
            menw_colors.Add(Color.DarkOrange);
            menw_colors.Add(Color.FromArgb(177, 70, 194));

            Tab_Main.SelectedIndex = 0;
            medicines = sqlControl.SQLiteSetup();
        }

        private void setMenuChgane(int index)
        {
            if (Tab_Main.SelectedIndex != index)
            {
                menws[Tab_Main.SelectedIndex].ForeColor = Color.FromArgb(111, 111, 111);
                menws[index].ForeColor = menw_colors[index];
                Tab_Menu_Select_Bar.BackColor = menw_colors[index];
                Tab_Menu_Select_Bar.Location = new Point(menws[index].Location.X, 0);
                Tab_Main.SelectedIndex = index;
            }
        }

        private void btn_Menu1_Click(object sender, EventArgs e)
        {
            setMenuChgane(0);
        }

        private void btn_Menu2_Click(object sender, EventArgs e)
        {
            setMenuChgane(1);
        }

        private void btn_Menu3_Click(object sender, EventArgs e)
        {
            setMenuChgane(2);
        }

        private void Medi_Search_textBox_TextChanged(object sender, EventArgs e)
        {
            foreach (Medicine medicine in medicines)
            {

                if (medicine.itemName.Contains(Medi_Search_textBox.Text))
                {
                    if (!Medi_Search_listBox.Items.Contains(Medi_Search_textBox.Text))
                    {
                        Medi_Search_listBox.Items.Add(medicine.itemName);
                    }
                }
                else
                {
                    Medi_Search_listBox.Items.Remove(medicine.itemName);
                }
            }
            List<object> list = new List<object>();
            foreach (object o in Medi_Search_listBox.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            Medi_Search_listBox.Items.Clear();
            Medi_Search_listBox.Items.AddRange(list.ToArray());
        }

        private void MediInfo_Button_Click(object sender, EventArgs e)
        {
            if (Medi_Search_listBox.SelectedItem != null)
            {
                foreach(Medicine medicine in medicines){
                    if (medicine.itemName == Medi_Search_listBox.SelectedItem.ToString())
                    {
                        Medi_Detail medi_Detail = new Medi_Detail(medicine);
                        medi_Detail.Owner = this;
                        medi_Detail.Show();
                    }
                }
            }
        }

        private void Alarm_Enable_button_Click(object sender, EventArgs e)
        {
            {
                if (Alarm_Enable_button.Text == "알람 설정")
                {
                    if(Alarm_Content_textBox.Text != null)
                    {
                        TimerControl.TimerMain(Alarm_dateTimePicker.Value.ToString("HHmmss"), Alarm_Content_textBox.Text);
                    }
                    Alarm_Enable_button.Text = "알람 해제";
                    Alarm_Enable_button.BackColor = Color.FromArgb(53, 124, 225);
                    Alarm_Enable_button.ForeColor = Color.White;
                    Alarm_Content_textBox.Enabled = true;
                    Alarm_Content_textBox.Text = "알람 시간을 설정해주세요.";
                }
                else
                {
                    TimerControl.TimerStop();
                    Alarm_Enable_button.Text = "알람 설정";
                    Alarm_Enable_button.BackColor = Color.FromArgb(111, 111, 111);
                    Alarm_Enable_button.ForeColor = Color.FromArgb(53, 124, 225);
                    Alarm_Content_textBox.Enabled = false;
                    Alarm_Content_textBox.Text = "";
                }
            }
        }

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
            this.Tab_Back = new System.Windows.Forms.Panel();
            this.Tab_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Alarm_Enable_button = new System.Windows.Forms.Button();
            this.Alarm_Content_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_time_info = new System.Windows.Forms.Label();
            this.Alarm_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Medi_Search_listBox = new System.Windows.Forms.ListBox();
            this.MediInfo_Button = new System.Windows.Forms.Button();
            this.Medi_Search_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Tab_Menu_Back = new System.Windows.Forms.Panel();
            this.Tab_Menu_Select_Back = new System.Windows.Forms.Panel();
            this.Tab_Menu_Select_Bar = new System.Windows.Forms.Panel();
            this.btn_Menu1 = new System.Windows.Forms.Label();
            this.btn_Menu2 = new System.Windows.Forms.Label();
            this.btn_Menu3 = new System.Windows.Forms.Label();
            this.Tab_Back.SuspendLayout();
            this.Tab_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Tab_Menu_Back.SuspendLayout();
            this.Tab_Menu_Select_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Back
            // 
            this.Tab_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Tab_Back.Controls.Add(this.Tab_Main);
            this.Tab_Back.Controls.Add(this.Tab_Menu_Back);
            this.Tab_Back.Location = new System.Drawing.Point(0, 0);
            this.Tab_Back.Name = "Tab_Back";
            this.Tab_Back.Size = new System.Drawing.Size(798, 523);
            this.Tab_Back.TabIndex = 0;
            // 
            // Tab_Main
            // 
            this.Tab_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Main.Controls.Add(this.tabPage1);
            this.Tab_Main.Controls.Add(this.tabPage2);
            this.Tab_Main.Controls.Add(this.tabPage3);
            this.Tab_Main.Location = new System.Drawing.Point(-4, 40);
            this.Tab_Main.Name = "Tab_Main";
            this.Tab_Main.SelectedIndex = 0;
            this.Tab_Main.Size = new System.Drawing.Size(806, 509);
            this.Tab_Main.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Alarm_Enable_button);
            this.tabPage1.Controls.Add(this.Alarm_Content_textBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.new_time_info);
            this.tabPage1.Controls.Add(this.Alarm_dateTimePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Alarm_Enable_button
            // 
            this.Alarm_Enable_button.Location = new System.Drawing.Point(343, 294);
            this.Alarm_Enable_button.Name = "Alarm_Enable_button";
            this.Alarm_Enable_button.Size = new System.Drawing.Size(142, 40);
            this.Alarm_Enable_button.TabIndex = 7;
            this.Alarm_Enable_button.Text = "알람 설정";
            this.Alarm_Enable_button.UseVisualStyleBackColor = true;
            this.Alarm_Enable_button.Click += new System.EventHandler(this.Alarm_Enable_button_Click);
            // 
            // Alarm_Content_textBox
            // 
            this.Alarm_Content_textBox.Location = new System.Drawing.Point(259, 140);
            this.Alarm_Content_textBox.Multiline = true;
            this.Alarm_Content_textBox.Name = "Alarm_Content_textBox";
            this.Alarm_Content_textBox.Size = new System.Drawing.Size(286, 136);
            this.Alarm_Content_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "시간 : ";
            // 
            // new_time_info
            // 
            this.new_time_info.AutoSize = true;
            this.new_time_info.Location = new System.Drawing.Point(255, 43);
            this.new_time_info.Name = "new_time_info";
            this.new_time_info.Size = new System.Drawing.Size(45, 12);
            this.new_time_info.TabIndex = 3;
            this.new_time_info.Text = "새 설정";
            // 
            // Alarm_dateTimePicker
            // 
            this.Alarm_dateTimePicker.CustomFormat = "HHmmss";
            this.Alarm_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Alarm_dateTimePicker.Location = new System.Drawing.Point(343, 77);
            this.Alarm_dateTimePicker.Name = "Alarm_dateTimePicker";
            this.Alarm_dateTimePicker.ShowUpDown = true;
            this.Alarm_dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.Alarm_dateTimePicker.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Medi_Search_listBox);
            this.tabPage2.Controls.Add(this.MediInfo_Button);
            this.tabPage2.Controls.Add(this.Medi_Search_textBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "검색된 약 이름을 선택하세요";
            // 
            // Medi_Search_listBox
            // 
            this.Medi_Search_listBox.FormattingEnabled = true;
            this.Medi_Search_listBox.ItemHeight = 12;
            this.Medi_Search_listBox.Location = new System.Drawing.Point(38, 172);
            this.Medi_Search_listBox.Name = "Medi_Search_listBox";
            this.Medi_Search_listBox.Size = new System.Drawing.Size(238, 100);
            this.Medi_Search_listBox.TabIndex = 3;
            // 
            // MediInfo_Button
            // 
            this.MediInfo_Button.Location = new System.Drawing.Point(380, 190);
            this.MediInfo_Button.Name = "MediInfo_Button";
            this.MediInfo_Button.Size = new System.Drawing.Size(75, 23);
            this.MediInfo_Button.TabIndex = 2;
            this.MediInfo_Button.Text = "정보 확인";
            this.MediInfo_Button.UseVisualStyleBackColor = true;
            this.MediInfo_Button.Click += new System.EventHandler(this.MediInfo_Button_Click);
            // 
            // Medi_Search_textBox
            // 
            this.Medi_Search_textBox.Location = new System.Drawing.Point(38, 52);
            this.Medi_Search_textBox.Name = "Medi_Search_textBox";
            this.Medi_Search_textBox.Size = new System.Drawing.Size(210, 21);
            this.Medi_Search_textBox.TabIndex = 1;
            this.Medi_Search_textBox.TextChanged += new System.EventHandler(this.Medi_Search_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "약 검색어를 입력하세요";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(798, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Tab_Menu_Back
            // 
            this.Tab_Menu_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Menu_Back.Controls.Add(this.Tab_Menu_Select_Back);
            this.Tab_Menu_Back.Controls.Add(this.btn_Menu1);
            this.Tab_Menu_Back.Controls.Add(this.btn_Menu2);
            this.Tab_Menu_Back.Controls.Add(this.btn_Menu3);
            this.Tab_Menu_Back.Location = new System.Drawing.Point(0, 0);
            this.Tab_Menu_Back.Name = "Tab_Menu_Back";
            this.Tab_Menu_Back.Size = new System.Drawing.Size(798, 40);
            this.Tab_Menu_Back.TabIndex = 0;
            // 
            // Tab_Menu_Select_Back
            // 
            this.Tab_Menu_Select_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Menu_Select_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.Tab_Menu_Select_Back.Controls.Add(this.Tab_Menu_Select_Bar);
            this.Tab_Menu_Select_Back.Location = new System.Drawing.Point(0, 37);
            this.Tab_Menu_Select_Back.Name = "Tab_Menu_Select_Back";
            this.Tab_Menu_Select_Back.Size = new System.Drawing.Size(798, 3);
            this.Tab_Menu_Select_Back.TabIndex = 0;
            // 
            // Tab_Menu_Select_Bar
            // 
            this.Tab_Menu_Select_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(225)))));
            this.Tab_Menu_Select_Bar.Location = new System.Drawing.Point(0, 0);
            this.Tab_Menu_Select_Bar.Name = "Tab_Menu_Select_Bar";
            this.Tab_Menu_Select_Bar.Size = new System.Drawing.Size(150, 3);
            this.Tab_Menu_Select_Bar.TabIndex = 0;
            // 
            // btn_Menu1
            // 
            this.btn_Menu1.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Menu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(225)))));
            this.btn_Menu1.Location = new System.Drawing.Point(0, 0);
            this.btn_Menu1.Name = "btn_Menu1";
            this.btn_Menu1.Size = new System.Drawing.Size(150, 40);
            this.btn_Menu1.TabIndex = 1;
            this.btn_Menu1.Text = "label1";
            this.btn_Menu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Menu1.Click += new System.EventHandler(this.btn_Menu1_Click);
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Menu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_Menu2.Location = new System.Drawing.Point(150, 0);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(150, 40);
            this.btn_Menu2.TabIndex = 2;
            this.btn_Menu2.Text = "sss";
            this.btn_Menu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Menu2.Click += new System.EventHandler(this.btn_Menu2_Click);
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.Font = new System.Drawing.Font("넥슨Lv1고딕 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Menu3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_Menu3.Location = new System.Drawing.Point(300, 0);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(150, 40);
            this.btn_Menu3.TabIndex = 3;
            this.btn_Menu3.Text = "sss";
            this.btn_Menu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Menu3.Click += new System.EventHandler(this.btn_Menu3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_Back);
            this.Name = "Form1";
            this.Text = "약 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab_Back.ResumeLayout(false);
            this.Tab_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Tab_Menu_Back.ResumeLayout(false);
            this.Tab_Menu_Select_Back.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tab_Back;
        private System.Windows.Forms.TabControl Tab_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel Tab_Menu_Back;
        private System.Windows.Forms.Panel Tab_Menu_Select_Back;
        private System.Windows.Forms.Panel Tab_Menu_Select_Bar;
        private System.Windows.Forms.Label btn_Menu1;
        private System.Windows.Forms.Label btn_Menu2;
        private System.Windows.Forms.Label btn_Menu3;
        private TextBox Medi_Search_textBox;
        private Label label1;
        private Button Alarm_Enable_button;
        private Label label3;
        private Label label2;
        private Label new_time_info;
        private DateTimePicker Alarm_dateTimePicker;
        private Label label4;
        private ListBox Medi_Search_listBox;
        private Button MediInfo_Button;
        private TextBox Alarm_Content_textBox;
    }
}

