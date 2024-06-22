using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Printing_App
{
    public partial class Form1 : Form
    {
        String[] Urunler = { "MicroController", "Resistor", "Capacitor", "Led Display", "USB-C Connector" };
        double[] Fiyatlar = { 300.99, 1.5, 3.0, 95.55, 62.99 };
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        double malHizmet = 0;
        double kdvDahil;
        int yuzdeIndirim;
        int kdv;
        double iskonto;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Ürün Adı"); dt1.Columns.Add("Ürün Adı");
            dt.Columns.Add("Fiyatı"); dt1.Columns.Add("Fiyatı");
            dt.Columns.Add("Adet"); dt1.Columns.Add("Adet");
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt1;
            for (int i = 0; i < Urunler.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = Urunler[i];
                dr[1] = Fiyatlar[i];
                dr[2] = 1;
                dt.Rows.Add(dr);
            }
            dataGridView1.Columns["Adet"].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView2.Columns["Ürün Adı"].ReadOnly = true;
            dataGridView2.Columns["Fiyatı"].ReadOnly = true;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value == row.Cells[0].Value)
                {
                    int sayi = Convert.ToInt32(row.Cells[2].Value);
                    sayi++;
                    row.Cells[2].Value = sayi.ToString();
                    i = 1;
                }
            }
            if (i == 0)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = dataGridView1.SelectedRows[0].Cells[0].Value;
                dr[1] = dataGridView1.SelectedRows[0].Cells[1].Value;
                dr[2] = dataGridView1.SelectedRows[0].Cells[2].Value;
                dt1.Rows.Add(dr);
            }
            yuzdeIndirim = (textBox4.Text == "") ? 0 : Convert.ToInt32(textBox4.Text);
            kdv = (textBox5.Text == "") ? 0 : Convert.ToInt32(textBox5.Text);

            if (dataGridView2.Rows.Count == 0)
            {
                return;
            }
            else
            {
                malHizmet = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    malHizmet += (Convert.ToDouble(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value));
                }
            }
            iskonto = (malHizmet * yuzdeIndirim) / 100;
            kdvDahil = malHizmet + (malHizmet * kdv) / 100;
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView2.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentCell.Value == null|| dataGridView2.CurrentCell.Value == DBNull.Value|| String.IsNullOrWhiteSpace(dataGridView2.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Değer Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView2.CurrentCell.Value = "1";
            }
            else
            {             
                    if (Convert.ToInt32(dataGridView2.CurrentCell.Value) == 0)
                    {
                        dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                    }
               
            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Seçilen Ürün Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                yuzdeIndirim = (textBox4.Text == "") ? 0 : Convert.ToInt32(textBox4.Text);
                kdv = (textBox5.Text == "") ? 0 : Convert.ToInt32(textBox5.Text);
                if (dataGridView2.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    malHizmet = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        malHizmet += (Convert.ToDouble(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value));
                    }
                }
                iskonto = (malHizmet * yuzdeIndirim) / 100;
                lbl_malHizmet.Text = malHizmet.ToString() + " TL";
                lbl_iskonto.Text = ((malHizmet * yuzdeIndirim) / 100).ToString() + " TL";
                lbl_kdv.Text = ((malHizmet * kdv) / 100).ToString() + " TL";
                kdvDahil = malHizmet + (malHizmet * kdv) / 100;
                lbl_vergiDahil.Text = kdvDahil.ToString() + " TL";
                lbl_total.Text = (kdvDahil - iskonto).ToString() + " TL";
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MprintPreviewDialog.Document = MprintDocument;
            MprintPreviewDialog.ShowDialog();
        }

        private void MprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 50; // Kenar boşlukları
            float y = margin;
            float x = margin;
            float musteriBaslangicY;
            Font font = new Font("Arial", 11);

            e.Graphics.DrawString("e-fatura uygulaması github.com/mustafayakin", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            Pen pen = new Pen(Color.Black, 3.0f);
            e.Graphics.DrawLine(pen, 0, 45, 250, 45);
            float lineHeight = font.GetHeight(e.Graphics);
            float maxWidth = e.PageBounds.Width - 2 * margin;
            string[] lines = SplitString(textBox10.Text, 36); // 33 karakterde bir böl

            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, font, Brushes.DimGray, new RectangleF(0, y, maxWidth, lineHeight));
                y += lineHeight;
            }
            Image image = pictureBox1.Image;
            e.Graphics.DrawImage(image, 630, 15, 200, 100);
            Bitmap bitmap = Properties.Resources._100px;
            image = bitmap;
            e.Graphics.DrawImage(image, 350, 50, 100, 100);
            e.Graphics.DrawString("e-FATURA", new Font("Arial", 14, FontStyle.Bold), Brushes.DarkGray, new Point(345, 160));
            e.Graphics.DrawString("Tel: " + textBox7.Text, font, Brushes.Gray, new Point(0,Convert.ToInt32(y+5)));
            y += lineHeight + 5;
            e.Graphics.DrawString("e-Posta: " + textBox8.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 5;
            e.Graphics.DrawString("Vergi Numarası: " + textBox9.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 15;
            e.Graphics.DrawLine(pen, 0, y, 250, y);
            y += 40; musteriBaslangicY = y;
            e.Graphics.DrawLine(pen, 0, y, 250, y);
            e.Graphics.DrawString("SAYIN" , new Font("Times New Roman", 11, FontStyle.Bold), Brushes.DimGray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 5;
            e.Graphics.DrawString(textBox1.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 5;
            e.Graphics.DrawString("Tel: " + textBox3.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 5;
            e.Graphics.DrawString("e-Posta: " + textBox6.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 5;
            e.Graphics.DrawString("VKN: " + textBox2.Text, font, Brushes.Gray, new Point(0, Convert.ToInt32(y + 5)));
            y += lineHeight + 15;
            e.Graphics.DrawLine(pen, 0, y, 250, y);
            float cellWidth = 130;
            float cellHeight = 21;
            Random rnd = new Random();
            Pen tablepen = new Pen(Color.DimGray, 3.0f);
            string[,] tableData = new string[,]
            {
                { "Özelleştirme No:", "TR1.2" },
                { "Fatura Tipi", "Basit" },
                { "Fatura NO:", rnd.Next(1000,2147483645).ToString()},
                { "Fatura Tarihi:", DateTime.Now.ToString("dd/MM/yyyy") },
                { "Fatura Saati:", DateTime.Now.ToString("HH:mm:ss") }
            };
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    float xx = 550 + col * cellWidth;
                    y = musteriBaslangicY + row * cellHeight;

                    // Hücreyi çiz
                    e.Graphics.DrawRectangle(tablepen, xx, y, cellWidth, cellHeight);

                    // Hücre içeriğini yaz
                    if (col == 0)
                    {
                        string text = tableData[row, col];
                        e.Graphics.DrawString(text, font, Brushes.Black, new RectangleF(xx, y, cellWidth, cellHeight));
                    }
                    else
                    {
                        string text = tableData[row, col];
                        e.Graphics.DrawString(text, font, Brushes.DimGray, new RectangleF(xx, y, cellWidth, cellHeight));
                    }
                }
            }
            y += 90;
            tableData = new string[,]
            {
                { "SN", "Ürün Adı","Miktarı","Birim Fiyatı","İskonto Oranı","İskonto Tutarı","Mal Hizmet Tutarı" },
                { "Fatura Tipi", "Basit","Fatura Tipi", "Basit" ,"Fatura Tipi", "Basit" ,"Fatura Tipi" },
            };
            cellHeight = 30;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center; // Yatay ortalama
            sf.LineAlignment = StringAlignment.Center; // Dikey ortalama
            float baslangicX;
            for (int row = 0; row < dataGridView2.Rows.Count + 1; row++)
            {
                baslangicX = 20;
                for (int col = 0; col < 7; col++)
                {
                    switch (col)
                    {
                        case 0:
                            cellWidth = 50;
                            break;
                        case 1:
                            cellWidth = 150;
                            break;
                        case 6:
                            cellWidth = 150;
                            break;
                        default:
                            cellWidth = 110;
                            break;

                    }
                    float yy =  y + row * cellHeight;
                    
                    // Hücre içeriğini yaz
                    if (row == 0)
                    {
                        e.Graphics.DrawRectangle(tablepen, baslangicX, yy, cellWidth, 40);
                        string text = tableData[row, col];
                        e.Graphics.DrawString(text, font, Brushes.Black, new RectangleF(baslangicX, yy, cellWidth, 40), sf);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(tablepen, baslangicX, yy+10, cellWidth, cellHeight);
                        double satis_fiyati = Convert.ToDouble(dataGridView2.Rows[row - 1].Cells[1].Value);
                        int miktari = Convert.ToInt32(dataGridView2.Rows[row - 1].Cells[2].Value);
                        double tekIskonto = (satis_fiyati * miktari * yuzdeIndirim / 100);
                        string[] satir = { row.ToString(), dataGridView2.Rows[row-1].Cells[0].Value.ToString(), dataGridView2.Rows[row - 1].Cells[2].Value.ToString() + " Adet", dataGridView2.Rows[row - 1].Cells[1].Value.ToString() + " TL","%"+yuzdeIndirim.ToString(), tekIskonto.ToString()+" TL", (satis_fiyati*miktari).ToString()+" TL" };
                        if (col == 0)
                        {
                            e.Graphics.DrawString(satir[col], font, Brushes.DimGray, new RectangleF(baslangicX, yy+10, cellWidth, cellHeight),sf);
                        }
                        else
                        {
                            e.Graphics.DrawString(satir[col], font, Brushes.DimGray, new RectangleF(baslangicX+6, yy+14, cellWidth, cellHeight));
                        }
                        
                    }
                    baslangicX += cellWidth;
                    if(row == dataGridView2.Rows.Count && col == 6)
                    {
                        y += row * cellHeight + 60;
                    }
                }
            }
            string[,] fiyatHesabi = new string[,]
            {
                { "Mal Hizmet Toplam Tutarı", malHizmet.ToString()+" TL" },
                { "Toplam İskonto", iskonto.ToString()+" TL" },
                { "Hesaplanan KDV(%"+kdv.ToString()+")", ((malHizmet * kdv) / 100).ToString() + " TL"},
                { "Vergiler Dahil Toplam Tutar", kdvDahil.ToString() + " TL" },
                { "Ödenecek Tutar", (kdvDahil - iskonto).ToString() + " TL" }
            };
            cellHeight = 20;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    float xx = 431 + col * cellWidth;
                    float yy = y + row * cellHeight;
                    switch (col)
                    {
                        case 0:
                            cellWidth = 230;
                            break;
                        case 1:
                            cellWidth = 150;
                            break;

                    }
                    // Hücreyi çiz
                    e.Graphics.DrawRectangle(tablepen, xx, yy, cellWidth, cellHeight);

                    // Hücre içeriğini yaz
                    if (col == 0)
                    {
                        string text = fiyatHesabi[row, col];
                        e.Graphics.DrawString(text, font, Brushes.Black, new RectangleF(xx, yy, cellWidth, 20));
                    }
                    else
                    {
                        string text = fiyatHesabi[row, col];
                        e.Graphics.DrawString(text, font, Brushes.DimGray, new RectangleF(xx, yy, cellWidth, cellHeight));
                    }
                if(row == 4 && col == 1)
                    {
                        y += row * cellHeight + 20;
                    }
                }
            }
            y += 20;
            Pen borderPen = new Pen(Color.DimGray, 2);
            e.Graphics.DrawRectangle(borderPen, 20, y+40, 793, 50); y += 40;
            e.Graphics.DrawString("Not: ", font, Brushes.Black, new Point(22, Convert.ToInt32(y + 5)));
            string sayiOkunusu;
            string orjSayi = (kdvDahil - iskonto).ToString();
            if (decimal.TryParse(orjSayi, out decimal number))
            {
               sayiOkunusu = NumberToWords(number);
            }
            else
            {
                sayiOkunusu = "Geçersiz sayı!";
            }
            e.Graphics.DrawString("Yalnız #" + sayiOkunusu.Replace(" ","")+"#", font, Brushes.DimGray, new Point(55, Convert.ToInt32(y + 5)));
            y += 15;
            e.Graphics.DrawString("İrsaliye yerine geçer.", new Font("Arial",10,FontStyle.Bold), Brushes.DimGray, new Point(22, Convert.ToInt32(y + 10)));
            y += 40;
            e.Graphics.DrawRectangle(borderPen, 20, y + 40, 793, 60); y += 40;
            cellHeight = 20;
            cellWidth = 111;
            string[,] bankaHesabi = new string[,]
            {
                { "BANKA","ŞUBE","ŞUBE KODU","HESAP NO","DÖVİZ","SWİFT KODU","IBAN"},
                { "T.GARANTİ BANKASI A.Ş.","SERDİVAN","000001","123456789","TL","555454",textBox11.Text },
                { "T.İŞ BANKASI A.Ş.","TERME","000001","55555554","USD","555454",textBox11.Text }
            };
            for (int row = 0; row < 3; row++)
            {
                baslangicX = 20;
                for (int col = 0; col < 7; col++)
                {
                    float xx = 20 + col * cellWidth;
                    float yy = y + row * cellHeight;
                    switch (col)
                    {
                        case 0:
                            cellWidth = 170;
                            break;
                        case 1:
                            cellWidth = 90;
                            break;
                        case 2:
                            cellWidth = 90;
                            break;
                        case 3:
                            cellWidth = 90;
                            break;
                        case 4:
                            cellWidth = 60;
                            break;
                        case 5:
                            cellWidth = 90;
                            break;
                        case 6:
                            cellWidth = 200;
                            break;

                    }
                    if (row == 0)
                    {
                        string text = bankaHesabi[row, col];
                        e.Graphics.DrawString(text,new Font("Times New Roman", 9, FontStyle.Regular), Brushes.Black, new RectangleF(baslangicX, yy+5, cellWidth, cellHeight));
                    }
                    else
                    {
                        string text = bankaHesabi[row, col];
                        e.Graphics.DrawString(text, new Font("Arial", 9, FontStyle.Regular), Brushes.DimGray, new RectangleF(baslangicX, yy+2, cellWidth, cellHeight));
                    }
                    baslangicX += cellWidth;
                }
            }
        }


        private string[] SplitString(string text, int maxLineLength)
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');

            string currentLine = string.Empty;

            foreach (string word in words)
            {
                if ((currentLine + word).Length > maxLineLength)
                {
                    lines.Add(currentLine.Trim());
                    currentLine = string.Empty;
                }

                currentLine += word + " ";
            }

            if (!string.IsNullOrWhiteSpace(currentLine))
            {
                lines.Add(currentLine.Trim());
            }

            return lines.ToArray();
        }
        private string NumberToWords(decimal number)
        {
            int wholePart = (int)Math.Floor(number);
            int fractionalPart = (int)((number - wholePart) * 100);

            string result = $"{NumberToWords(wholePart)} lira";

            if (fractionalPart > 0)
            {
                result += $"{NumberToWords(fractionalPart)} kuruş";
            }

            return result.Trim();
        }

        private string NumberToWords(int number)
        {
            if (number == 0)
                return "sıfır";

            if (number < 0)
                return "eksi " + NumberToWords(Math.Abs(number));

            string[] unitsMap = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] tensMap = { "sıfır", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " milyon ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                if (number / 1000 == 1)
                    words += "bin ";
                else
                    words += NumberToWords(number / 1000) + " bin ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                if (number / 100 == 1)
                    words += "yüz ";
                else
                    words += NumberToWords(number / 100) + " yüz ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 10)
                    words += unitsMap[number];
                else if (number < 20)
                    words += tensMap[number / 10] + (number % 10 > 0 ? " " + unitsMap[number % 10] : "");
                else
                    words += tensMap[number / 10] + (number % 10 > 0 ? " " + unitsMap[number % 10] : "");
            }

            return words.Trim();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files(*.png)|*.png| JPG files(*.jpg)|*.jpg|JPEG files(*.jpeg)|*.jpeg";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!\n(yalnızca .png)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MprintDocument.Print();
        }
    }
}
