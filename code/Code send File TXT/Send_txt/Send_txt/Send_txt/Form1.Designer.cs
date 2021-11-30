
namespace Send_txt
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.ComboBox();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.File_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.send_data = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.modding = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // COM
            // 
            this.COM.FormattingEnabled = true;
            this.COM.Location = new System.Drawing.Point(99, 23);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(121, 24);
            this.COM.TabIndex = 2;
            // 
            // Mode
            // 
            this.Mode.FormattingEnabled = true;
            this.Mode.Location = new System.Drawing.Point(238, 21);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(121, 24);
            this.Mode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng thái:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.White;
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Location = new System.Drawing.Point(263, 69);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(94, 17);
            this.Status.TabIndex = 4;
            this.Status.Text = "Disconnected";
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Location = new System.Drawing.Point(99, 55);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(121, 24);
            this.Baud.TabIndex = 2;
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(34, 63);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(748, 306);
            this.Display.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data";
            // 
            // File_Name
            // 
            this.File_Name.Location = new System.Drawing.Point(417, 29);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(268, 22);
            this.File_Name.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "File Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // send_data
            // 
            this.send_data.Interval = 1;
            this.send_data.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 32);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // modding
            // 
            this.modding.AutoSize = true;
            this.modding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.modding.ForeColor = System.Drawing.Color.White;
            this.modding.Location = new System.Drawing.Point(691, 32);
            this.modding.Name = "modding";
            this.modding.Size = new System.Drawing.Size(0, 17);
            this.modding.TabIndex = 11;
            // 
            // timer2
            // 
            this.timer2.Interval = 650;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.Baud);
            this.groupBox1.Location = new System.Drawing.Point(34, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 95);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btClear);
            this.groupBox2.Controls.Add(this.btSend);
            this.groupBox2.Controls.Add(this.btRead);
            this.groupBox2.Controls.Add(this.Mode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Status);
            this.groupBox2.Location = new System.Drawing.Point(417, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 95);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(25, 56);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save File";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(106, 56);
            this.btClear.Name = "btClear";
            this.btClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(106, 24);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(25, 23);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 24);
            this.btRead.TabIndex = 5;
            this.btRead.Text = "Đọc File";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COM;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox File_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer send_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label modding;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btSave;
    }
}

