namespace Invoice_Printing_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_vergiDahil = new System.Windows.Forms.Label();
            this.lbl_kdv = new System.Windows.Forms.Label();
            this.lbl_iskonto = new System.Windows.Forms.Label();
            this.lbl_malHizmet = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.MprintDocument = new System.Drawing.Printing.PrintDocument();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 31);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 287);
            this.panel1.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 203);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(231, 31);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "KDV Oranı:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(231, 31);
            this.textBox4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yüzde İndirim:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 31);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Telefonu:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vergi Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Firma Logosu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(151, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "ÜRÜNLER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(707, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 41);
            this.label6.TabIndex = 4;
            this.label6.Text = "SEÇİLENLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(441, 209);
            this.dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 699);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(567, 483);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(441, 209);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView2_CurrentCellDirtyStateChanged);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(458, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 360);
            this.panel2.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(155, 156);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(231, 31);
            this.textBox7.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Firma Telefonu:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(155, 111);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(231, 31);
            this.textBox8.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Firma e-Postası:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(155, 61);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(231, 31);
            this.textBox9.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vergi Numarası:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(155, 14);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(231, 31);
            this.textBox10.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Firma Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(127, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 41);
            this.label14.TabIndex = 9;
            this.label14.Text = "Müşteri Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(597, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 41);
            this.label15.TabIndex = 9;
            this.label15.Text = "Firma Bilgileri";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lbl_total);
            this.panel3.Controls.Add(this.lbl_vergiDahil);
            this.panel3.Controls.Add(this.lbl_kdv);
            this.panel3.Controls.Add(this.lbl_iskonto);
            this.panel3.Controls.Add(this.lbl_malHizmet);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(894, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 253);
            this.panel3.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ödenecek Tutar:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(228, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Vergiler Dahil Toplam Tutar:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Hesaplanan KDV:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Toplam İskonto:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(247, 192);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 25);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "0 TL";
            // 
            // lbl_vergiDahil
            // 
            this.lbl_vergiDahil.AutoSize = true;
            this.lbl_vergiDahil.Location = new System.Drawing.Point(247, 150);
            this.lbl_vergiDahil.Name = "lbl_vergiDahil";
            this.lbl_vergiDahil.Size = new System.Drawing.Size(44, 25);
            this.lbl_vergiDahil.TabIndex = 0;
            this.lbl_vergiDahil.Text = "0 TL";
            // 
            // lbl_kdv
            // 
            this.lbl_kdv.AutoSize = true;
            this.lbl_kdv.Location = new System.Drawing.Point(247, 105);
            this.lbl_kdv.Name = "lbl_kdv";
            this.lbl_kdv.Size = new System.Drawing.Size(44, 25);
            this.lbl_kdv.TabIndex = 0;
            this.lbl_kdv.Text = "0 TL";
            // 
            // lbl_iskonto
            // 
            this.lbl_iskonto.AutoSize = true;
            this.lbl_iskonto.Location = new System.Drawing.Point(247, 62);
            this.lbl_iskonto.Name = "lbl_iskonto";
            this.lbl_iskonto.Size = new System.Drawing.Size(44, 25);
            this.lbl_iskonto.TabIndex = 0;
            this.lbl_iskonto.Text = "0 TL";
            // 
            // lbl_malHizmet
            // 
            this.lbl_malHizmet.AutoSize = true;
            this.lbl_malHizmet.Location = new System.Drawing.Point(247, 24);
            this.lbl_malHizmet.Name = "lbl_malHizmet";
            this.lbl_malHizmet.Size = new System.Drawing.Size(44, 25);
            this.lbl_malHizmet.TabIndex = 0;
            this.lbl_malHizmet.Text = "0 TL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mal Hizmet Tutar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1020, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 41);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tutar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(992, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fiyat Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(1065, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 233);
            this.panel4.TabIndex = 12;
            // 
            // MprintPreviewDialog
            // 
            this.MprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.MprintPreviewDialog.Enabled = true;
            this.MprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("MprintPreviewDialog.Icon")));
            this.MprintPreviewDialog.Name = "MprintPreviewDialog";
            this.MprintPreviewDialog.Text = "Baskı önizleme";
            this.MprintPreviewDialog.Visible = false;
            // 
            // MprintDocument
            // 
            this.MprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MprintDocument_PrintPage);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Müşteri e-Posta:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(231, 31);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "Firma IBAN:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(155, 206);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(231, 31);
            this.textBox11.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Image = global::Invoice_Printing_App.Properties.Resources.Fire_Exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Image = global::Invoice_Printing_App.Properties.Resources.PDF;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 55);
            this.button4.TabIndex = 2;
            this.button4.Text = "PDF Olarak Kaydet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Image = global::Invoice_Printing_App.Properties.Resources.Print;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 55);
            this.button5.TabIndex = 1;
            this.button5.Text = "Yazdır";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Invoice_Printing_App.Properties.Resources.Mavi_EN;
            this.pictureBox1.Location = new System.Drawing.Point(155, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 748);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_malHizmet;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_vergiDahil;
        private System.Windows.Forms.Label lbl_kdv;
        private System.Windows.Forms.Label lbl_iskonto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PrintPreviewDialog MprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument MprintDocument;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
    }
}

