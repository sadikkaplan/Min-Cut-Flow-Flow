namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtST = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtFT = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtET = new System.Windows.Forms.TextBox();
            this.txtEF = new System.Windows.Forms.TextBox();
            this.txtCE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBT = new System.Windows.Forms.TextBox();
            this.txtBE = new System.Windows.Forms.TextBox();
            this.txtAT = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxFlow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musluk Sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtST);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtCT);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.txtFT);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.txtET);
            this.groupBox1.Controls.Add(this.txtEF);
            this.groupBox1.Controls.Add(this.txtCE);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtBT);
            this.groupBox1.Controls.Add(this.txtBE);
            this.groupBox1.Controls.Add(this.txtAT);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.txtAB);
            this.groupBox1.Controls.Add(this.txtSC);
            this.groupBox1.Controls.Add(this.txtSB);
            this.groupBox1.Controls.Add(this.txtSA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtST
            // 
            this.txtST.Location = new System.Drawing.Point(159, 312);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(27, 20);
            this.txtST.TabIndex = 63;
            this.txtST.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(120, 315);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 62;
            this.label31.Text = "S-->T";
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(65, 290);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(27, 20);
            this.txtCT.TabIndex = 61;
            this.txtCT.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(26, 293);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 13);
            this.label30.TabIndex = 60;
            this.label30.Text = "C-->T";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(73, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Kapasiteler";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(76, 383);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 32;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtFT
            // 
            this.txtFT.Location = new System.Drawing.Point(159, 245);
            this.txtFT.Name = "txtFT";
            this.txtFT.Size = new System.Drawing.Size(27, 20);
            this.txtFT.TabIndex = 31;
            this.txtFT.Text = "0";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(159, 223);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(27, 20);
            this.txtDT.TabIndex = 30;
            this.txtDT.Text = "0";
            // 
            // txtET
            // 
            this.txtET.Location = new System.Drawing.Point(159, 201);
            this.txtET.Name = "txtET";
            this.txtET.Size = new System.Drawing.Size(27, 20);
            this.txtET.TabIndex = 29;
            this.txtET.Text = "0";
            // 
            // txtEF
            // 
            this.txtEF.Location = new System.Drawing.Point(159, 178);
            this.txtEF.Name = "txtEF";
            this.txtEF.Size = new System.Drawing.Size(27, 20);
            this.txtEF.TabIndex = 28;
            this.txtEF.Text = "0";
            // 
            // txtCE
            // 
            this.txtCE.Location = new System.Drawing.Point(159, 156);
            this.txtCE.Name = "txtCE";
            this.txtCE.Size = new System.Drawing.Size(27, 20);
            this.txtCE.TabIndex = 27;
            this.txtCE.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "F-->T";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "D-->T";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "E-->T";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "E-->F";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(120, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "C-->E";
            // 
            // txtBT
            // 
            this.txtBT.Location = new System.Drawing.Point(159, 267);
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(27, 20);
            this.txtBT.TabIndex = 18;
            this.txtBT.Text = "0";
            // 
            // txtBE
            // 
            this.txtBE.Location = new System.Drawing.Point(159, 290);
            this.txtBE.Name = "txtBE";
            this.txtBE.Size = new System.Drawing.Size(27, 20);
            this.txtBE.TabIndex = 17;
            this.txtBE.Text = "0";
            // 
            // txtAT
            // 
            this.txtAT.Location = new System.Drawing.Point(65, 267);
            this.txtAT.Name = "txtAT";
            this.txtAT.Size = new System.Drawing.Size(27, 20);
            this.txtAT.TabIndex = 16;
            this.txtAT.Text = "0";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(65, 245);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(27, 20);
            this.txtAD.TabIndex = 15;
            this.txtAD.Text = "0";
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(65, 223);
            this.txtAB.Name = "txtAB";
            this.txtAB.Size = new System.Drawing.Size(27, 20);
            this.txtAB.TabIndex = 14;
            this.txtAB.Text = "0";
            // 
            // txtSC
            // 
            this.txtSC.Location = new System.Drawing.Point(65, 201);
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(27, 20);
            this.txtSC.TabIndex = 13;
            this.txtSC.Text = "0";
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(65, 178);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(27, 20);
            this.txtSB.TabIndex = 12;
            this.txtSB.Text = "0";
            // 
            // txtSA
            // 
            this.txtSA.Location = new System.Drawing.Point(65, 156);
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(27, 20);
            this.txtSA.TabIndex = 11;
            this.txtSA.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "B-->T";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "B-->E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "A-->T";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "A-->D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "A-->B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "S-->C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "S-->B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "S-->A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Graf Çiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Flow: ";
            // 
            // txtMaxFlow
            // 
            this.txtMaxFlow.AutoSize = true;
            this.txtMaxFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxFlow.ForeColor = System.Drawing.Color.Red;
            this.txtMaxFlow.Location = new System.Drawing.Point(408, 11);
            this.txtMaxFlow.Name = "txtMaxFlow";
            this.txtMaxFlow.Size = new System.Drawing.Size(17, 17);
            this.txtMaxFlow.TabIndex = 3;
            this.txtMaxFlow.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtMaxFlow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtFT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtET;
        private System.Windows.Forms.TextBox txtEF;
        private System.Windows.Forms.TextBox txtCE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBT;
        private System.Windows.Forms.TextBox txtBE;
        private System.Windows.Forms.TextBox txtAT;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label txtMaxFlow;
    }
}

