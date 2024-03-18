namespace XMLApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            saveBtn = new Button();
            LoadBtn = new Button();
            groupBox2 = new GroupBox();
            deleteBtn = new Button();
            selectBtn = new Button();
            prevBtn = new Button();
            nextBtn = new Button();
            txtSearchName = new TextBox();
            clearBtn = new Button();
            searchBtn = new Button();
            insertBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            allTreeView = new TreeView();
            groupBox4 = new GroupBox();
            totallabel = new Label();
            groupBox5 = new GroupBox();
            indexlabel = new Label();
            empTreeView = new TreeView();
            groupBox6 = new GroupBox();
            txtEmail = new TextBox();
            label9 = new Label();
            groupBox8 = new GroupBox();
            label8 = new Label();
            txtCity = new TextBox();
            label7 = new Label();
            txtRegion = new TextBox();
            txtCountry = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBuildingNumber = new TextBox();
            txtStreet = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            txtMobilePhone = new TextBox();
            txtHomePhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtWorkPhone = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            groupBox7 = new GroupBox();
            button1 = new Button();
            updateBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(LoadBtn);
            groupBox1.Location = new Point(1113, 413);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(475, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Operations";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlDark;
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(271, 51);
            saveBtn.Margin = new Padding(4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(161, 64);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save File";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = SystemColors.ControlDark;
            LoadBtn.ForeColor = SystemColors.Control;
            LoadBtn.Location = new Point(61, 51);
            LoadBtn.Margin = new Padding(4);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(161, 64);
            LoadBtn.TabIndex = 0;
            LoadBtn.Text = "Load File";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Controls.Add(selectBtn);
            groupBox2.Controls.Add(prevBtn);
            groupBox2.Controls.Add(nextBtn);
            groupBox2.Controls.Add(txtSearchName);
            groupBox2.Controls.Add(clearBtn);
            groupBox2.Controls.Add(searchBtn);
            groupBox2.Location = new Point(18, 318);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(572, 367);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Display Operations";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.IndianRed;
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(218, 248);
            deleteBtn.Margin = new Padding(4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 64);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // selectBtn
            // 
            selectBtn.BackColor = SystemColors.ControlDark;
            selectBtn.ForeColor = SystemColors.Control;
            selectBtn.Location = new Point(218, 161);
            selectBtn.Margin = new Padding(4);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(161, 64);
            selectBtn.TabIndex = 5;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = false;
            selectBtn.Click += selectBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = SystemColors.ControlDark;
            prevBtn.ForeColor = SystemColors.Control;
            prevBtn.Location = new Point(113, 161);
            prevBtn.Margin = new Padding(4);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(84, 151);
            prevBtn.TabIndex = 4;
            prevBtn.Text = "<<";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = SystemColors.ControlDark;
            nextBtn.ForeColor = SystemColors.Control;
            nextBtn.Location = new Point(400, 161);
            nextBtn.Margin = new Padding(4);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(84, 151);
            nextBtn.TabIndex = 3;
            nextBtn.Text = ">>";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchName.Location = new Point(113, 30);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(371, 31);
            txtSearchName.TabIndex = 2;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.ControlDark;
            clearBtn.ForeColor = SystemColors.Control;
            clearBtn.Location = new Point(400, 75);
            clearBtn.Margin = new Padding(4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(84, 64);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ActiveCaption;
            searchBtn.ForeColor = SystemColors.Control;
            searchBtn.Location = new Point(113, 75);
            searchBtn.Margin = new Padding(4);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(266, 64);
            searchBtn.TabIndex = 0;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.DarkKhaki;
            insertBtn.ForeColor = SystemColors.Control;
            insertBtn.Location = new Point(14, 31);
            insertBtn.Margin = new Padding(4);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(161, 64);
            insertBtn.TabIndex = 0;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(1101, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 647);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(597, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 647);
            panel2.TabIndex = 7;
            // 
            // allTreeView
            // 
            allTreeView.Location = new Point(26, 41);
            allTreeView.Name = "allTreeView";
            allTreeView.Size = new Size(420, 249);
            allTreeView.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(totallabel);
            groupBox4.Controls.Add(allTreeView);
            groupBox4.Location = new Point(1113, 38);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(475, 342);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "All Employees";
            // 
            // totallabel
            // 
            totallabel.AutoSize = true;
            totallabel.Location = new Point(26, 304);
            totallabel.Name = "totallabel";
            totallabel.Size = new Size(81, 23);
            totallabel.TabIndex = 9;
            totallabel.Text = "Total = 0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(indexlabel);
            groupBox5.Controls.Add(empTreeView);
            groupBox5.Location = new Point(18, 24);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(572, 265);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search Employee";
            // 
            // indexlabel
            // 
            indexlabel.AutoSize = true;
            indexlabel.Location = new Point(26, 232);
            indexlabel.Name = "indexlabel";
            indexlabel.Size = new Size(90, 23);
            indexlabel.TabIndex = 10;
            indexlabel.Text = "index = --";
            // 
            // empTreeView
            // 
            empTreeView.Location = new Point(26, 41);
            empTreeView.Name = "empTreeView";
            empTreeView.Size = new Size(519, 188);
            empTreeView.TabIndex = 8;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtEmail);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Controls.Add(groupBox3);
            groupBox6.Controls.Add(txtName);
            groupBox6.Controls.Add(label1);
            groupBox6.Location = new Point(617, 38);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(466, 540);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Employee Form";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 30);
            txtEmail.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 77);
            label9.Name = "label9";
            label9.Size = new Size(64, 23);
            label9.TabIndex = 13;
            label9.Text = "Email :";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label8);
            groupBox8.Controls.Add(txtCity);
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(txtRegion);
            groupBox8.Controls.Add(txtCountry);
            groupBox8.Controls.Add(label5);
            groupBox8.Controls.Add(label6);
            groupBox8.Controls.Add(txtBuildingNumber);
            groupBox8.Controls.Add(txtStreet);
            groupBox8.Controls.Add(label4);
            groupBox8.Location = new Point(14, 274);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(427, 251);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 160);
            label8.Name = "label8";
            label8.Size = new Size(52, 23);
            label8.TabIndex = 10;
            label8.Text = "City :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(128, 160);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(285, 30);
            txtCity.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 118);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 8;
            label7.Text = "Region :";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(128, 118);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(285, 30);
            txtRegion.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(128, 202);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(285, 30);
            txtCountry.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 202);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 4;
            label5.Text = "Country :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 76);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 6;
            label6.Text = "Building N. :";
            // 
            // txtBuildingNumber
            // 
            txtBuildingNumber.Location = new Point(128, 76);
            txtBuildingNumber.Name = "txtBuildingNumber";
            txtBuildingNumber.Size = new Size(285, 30);
            txtBuildingNumber.TabIndex = 7;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(128, 34);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(285, 30);
            txtStreet.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 34);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 2;
            label4.Text = "Street :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtMobilePhone);
            groupBox3.Controls.Add(txtHomePhone);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtWorkPhone);
            groupBox3.Location = new Point(14, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 155);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phones";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 108);
            label10.Name = "label10";
            label10.Size = new Size(76, 23);
            label10.TabIndex = 6;
            label10.Text = "Mobile :";
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(128, 108);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(285, 30);
            txtMobilePhone.TabIndex = 7;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(128, 29);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(285, 30);
            txtHomePhone.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 2;
            label2.Text = "Home :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 4;
            label3.Text = "Work :";
            // 
            // txtWorkPhone
            // 
            txtWorkPhone.Location = new Point(128, 72);
            txtWorkPhone.Name = "txtWorkPhone";
            txtWorkPhone.Size = new Size(285, 30);
            txtWorkPhone.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 30);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(updateBtn);
            groupBox7.Controls.Add(insertBtn);
            groupBox7.Location = new Point(617, 579);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(466, 106);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Manipulate Operations";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(357, 31);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(84, 64);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.ActiveCaption;
            updateBtn.ForeColor = SystemColors.Control;
            updateBtn.Location = new Point(183, 31);
            updateBtn.Margin = new Padding(4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 64);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 718);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "XML Editor";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button LoadBtn;
        private GroupBox groupBox2;
        private Button searchBtn;
        private TextBox txtSearchName;
        private Button clearBtn;
        private Button prevBtn;
        private Button nextBtn;
        private GroupBox groupBox3;
        private Button deleteBtn;
        private Button insertBtn;
        private Button saveBtn;
        private Panel panel1;
        private Panel panel2;
        private TreeView allTreeView;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TreeView empTreeView;
        private Label totallabel;
        private Label indexlabel;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button updateBtn;
        private Button button3;
        private Button selectBtn;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBox8;
        private Label label8;
        private TextBox txtCity;
        private Label label7;
        private TextBox txtRegion;
        private Label label6;
        private TextBox txtBuildingNumber;
        private TextBox txtStreet;
        private Label label4;
        private Label label5;
        private TextBox txtCountry;
        private TextBox txtHomePhone;
        private Label label2;
        private Label label3;
        private TextBox txtWorkPhone;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private TextBox txtMobilePhone;
        private Button button1;
    }
}
