
using ProjectPT_Remaster.Class;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProjectPT_Remaster
{
    public partial class Medi_Detail : Form
    {
        public const string WARN_NULL = "정보가 없습니다.";
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Medicine ReceivedMedicine;
        public Medi_Detail(Medicine medicine)
        {
            InitializeComponent();
            ReceivedMedicine = medicine;
        }
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

        private void Medi_Detail_Load(object sender, EventArgs e)
        {
            Medi_ClassNum_Textbox.Text = ReceivedMedicine.itemSeq.ToString();
            Medi_entpName_textBox.Text = ReceivedMedicine.entpName;
            Medi_Name_textBox.Text = ReceivedMedicine.itemName;
            Medi_OpenDe_textBox.Text = ReceivedMedicine.openDe;
            Medi_updateDe_textBox.Text = ReceivedMedicine.updateDe;
            Medi_efcyQesitm_textBox.Text = ReceivedMedicine.efcyQesitm;
            Medi_useMethod_textBox.Text = ReceivedMedicine.useMethodQesitm;
            Medi_atpnQesitm_textBox.Text = ReceivedMedicine.atpnQesitm;
            Medi_intrcQesitm_textBox.Text = ReceivedMedicine.intrcQesitm;
            Medi_seQesitm_textBox.Text = ReceivedMedicine.seQesitm;
            Medi_deposit_textBox.Text = ReceivedMedicine.depositMethodQesitm;
            if (ReceivedMedicine.atpnWarnQesitm == null)
            {
                Medi_WarnQesitm_textBox.Text = WARN_NULL;
            }
            else
            {
                Medi_WarnQesitm_textBox.Text = ReceivedMedicine.atpnWarnQesitm;
            }
        }
        
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.Medi_ClassNum_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Medi_Name_textBox = new System.Windows.Forms.TextBox();
            this.Medi_entpName_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Medi_efcyQesitm_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Medi_useMethod_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Medi_WarnQesitm_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Medi_atpnQesitm_textBox = new System.Windows.Forms.TextBox();
            this.Medi_intrcQesitm_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Medi_seQesitm_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Medi_deposit_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Medi_updateDe_textBox = new System.Windows.Forms.TextBox();
            this.Medi_OpenDe_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "분류번호";
            // 
            // Medi_ClassNum_Textbox
            // 
            this.Medi_ClassNum_Textbox.Location = new System.Drawing.Point(32, 55);
            this.Medi_ClassNum_Textbox.Name = "Medi_ClassNum_Textbox";
            this.Medi_ClassNum_Textbox.ReadOnly = true;
            this.Medi_ClassNum_Textbox.Size = new System.Drawing.Size(100, 21);
            this.Medi_ClassNum_Textbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "약 이름";
            // 
            // Medi_Name_textBox
            // 
            this.Medi_Name_textBox.Location = new System.Drawing.Point(294, 55);
            this.Medi_Name_textBox.Name = "Medi_Name_textBox";
            this.Medi_Name_textBox.ReadOnly = true;
            this.Medi_Name_textBox.Size = new System.Drawing.Size(150, 21);
            this.Medi_Name_textBox.TabIndex = 3;
            // 
            // Medi_entpName_textBox
            // 
            this.Medi_entpName_textBox.Location = new System.Drawing.Point(164, 55);
            this.Medi_entpName_textBox.Name = "Medi_entpName_textBox";
            this.Medi_entpName_textBox.ReadOnly = true;
            this.Medi_entpName_textBox.Size = new System.Drawing.Size(100, 21);
            this.Medi_entpName_textBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "제조사명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "사용방법";
            // 
            // Medi_efcyQesitm_textBox
            // 
            this.Medi_efcyQesitm_textBox.Location = new System.Drawing.Point(30, 139);
            this.Medi_efcyQesitm_textBox.Multiline = true;
            this.Medi_efcyQesitm_textBox.Name = "Medi_efcyQesitm_textBox";
            this.Medi_efcyQesitm_textBox.ReadOnly = true;
            this.Medi_efcyQesitm_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_efcyQesitm_textBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "복용방법";
            // 
            // Medi_useMethod_textBox
            // 
            this.Medi_useMethod_textBox.Location = new System.Drawing.Point(30, 250);
            this.Medi_useMethod_textBox.Multiline = true;
            this.Medi_useMethod_textBox.Name = "Medi_useMethod_textBox";
            this.Medi_useMethod_textBox.ReadOnly = true;
            this.Medi_useMethod_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_useMethod_textBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "경고사항";
            // 
            // Medi_WarnQesitm_textBox
            // 
            this.Medi_WarnQesitm_textBox.Location = new System.Drawing.Point(30, 356);
            this.Medi_WarnQesitm_textBox.Multiline = true;
            this.Medi_WarnQesitm_textBox.Name = "Medi_WarnQesitm_textBox";
            this.Medi_WarnQesitm_textBox.ReadOnly = true;
            this.Medi_WarnQesitm_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_WarnQesitm_textBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "주의사항";
            // 
            // Medi_atpnQesitm_textBox
            // 
            this.Medi_atpnQesitm_textBox.Location = new System.Drawing.Point(30, 449);
            this.Medi_atpnQesitm_textBox.Multiline = true;
            this.Medi_atpnQesitm_textBox.Name = "Medi_atpnQesitm_textBox";
            this.Medi_atpnQesitm_textBox.ReadOnly = true;
            this.Medi_atpnQesitm_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_atpnQesitm_textBox.TabIndex = 13;
            // 
            // Medi_intrcQesitm_textBox
            // 
            this.Medi_intrcQesitm_textBox.Location = new System.Drawing.Point(389, 139);
            this.Medi_intrcQesitm_textBox.Multiline = true;
            this.Medi_intrcQesitm_textBox.Name = "Medi_intrcQesitm_textBox";
            this.Medi_intrcQesitm_textBox.ReadOnly = true;
            this.Medi_intrcQesitm_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_intrcQesitm_textBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "혼용 주의사항";
            // 
            // Medi_seQesitm_textBox
            // 
            this.Medi_seQesitm_textBox.Location = new System.Drawing.Point(389, 250);
            this.Medi_seQesitm_textBox.Multiline = true;
            this.Medi_seQesitm_textBox.Name = "Medi_seQesitm_textBox";
            this.Medi_seQesitm_textBox.ReadOnly = true;
            this.Medi_seQesitm_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_seQesitm_textBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "부작용";
            // 
            // Medi_deposit_textBox
            // 
            this.Medi_deposit_textBox.Location = new System.Drawing.Point(391, 356);
            this.Medi_deposit_textBox.Multiline = true;
            this.Medi_deposit_textBox.Name = "Medi_deposit_textBox";
            this.Medi_deposit_textBox.ReadOnly = true;
            this.Medi_deposit_textBox.Size = new System.Drawing.Size(317, 66);
            this.Medi_deposit_textBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "보관방법";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "수정일자";
            // 
            // Medi_updateDe_textBox
            // 
            this.Medi_updateDe_textBox.Location = new System.Drawing.Point(592, 55);
            this.Medi_updateDe_textBox.Name = "Medi_updateDe_textBox";
            this.Medi_updateDe_textBox.ReadOnly = true;
            this.Medi_updateDe_textBox.Size = new System.Drawing.Size(100, 21);
            this.Medi_updateDe_textBox.TabIndex = 22;
            // 
            // Medi_OpenDe_textBox
            // 
            this.Medi_OpenDe_textBox.Location = new System.Drawing.Point(460, 55);
            this.Medi_OpenDe_textBox.Name = "Medi_OpenDe_textBox";
            this.Medi_OpenDe_textBox.ReadOnly = true;
            this.Medi_OpenDe_textBox.Size = new System.Drawing.Size(100, 21);
            this.Medi_OpenDe_textBox.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(458, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "공개일자";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(617, 492);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "닫기";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Medi_Detail
            // 
            this.ClientSize = new System.Drawing.Size(727, 549);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Medi_updateDe_textBox);
            this.Controls.Add(this.Medi_OpenDe_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Medi_deposit_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Medi_seQesitm_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Medi_intrcQesitm_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Medi_atpnQesitm_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Medi_WarnQesitm_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Medi_useMethod_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Medi_efcyQesitm_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Medi_entpName_textBox);
            this.Controls.Add(this.Medi_Name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Medi_ClassNum_Textbox);
            this.Controls.Add(this.label3);
            this.Name = "Medi_Detail";
            this.Load += new System.EventHandler(this.Medi_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Medi_ClassNum_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Medi_Name_textBox;
        private System.Windows.Forms.TextBox Medi_entpName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Medi_efcyQesitm_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Medi_useMethod_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Medi_WarnQesitm_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Medi_atpnQesitm_textBox;
        private System.Windows.Forms.TextBox Medi_intrcQesitm_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Medi_seQesitm_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Medi_deposit_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Medi_updateDe_textBox;
        private System.Windows.Forms.TextBox Medi_OpenDe_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CloseButton;
    }
}