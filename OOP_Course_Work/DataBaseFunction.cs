using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;

namespace OOP_Course_Work
{
    public class DataBaseFunction
    {
        public void ClientAdd(string textbox1,string textbox2, string textbox3)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Client client = new Client()
                {
                    Name = textbox1,
                    Passport = textbox2,
                    Email = textbox3,
                };
                context.Client.Add(client);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Новый клиент добавлен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ClientUpdate(string textbox1, string textbox2, string textbox3, int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Client Clients = context.Client.Where(id => id.ClientID == choicecell).First();
                Clients.Name = textbox1;
                Clients.Passport = textbox2;
                Clients.Email = textbox3;
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Клиент изменен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }   
        }
        public void ClientDelete(int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Client client = context.Client.Where(id => id.ClientID == choicecell).First();
                context.Client.Remove(client);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Клиент удален!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ContractAdd(string textbox1, string textbox2, string textbox3, string textbox4, string textbox5, string textbox6)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Contract contracts = new Contract()
                {
                    ClientID = textbox1,
                    TurID = textbox2,
                    HotelID = textbox3,
                    Number = Convert.ToInt32(textbox4),
                    Cost = Convert.ToDouble(textbox5),
                    TotalCost = Convert.ToDouble(Convert.ToDouble(textbox4)*Convert.ToDouble(textbox5)),
                    Date = Convert.ToDateTime(textbox6),
                };
                context.Contract.Add(contracts);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Новый договор добавлен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ContractUpdate(string textbox1, string textbox2, string textbox3, string textbox4, string textbox5, string textbox6, int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Contract contract = context.Contract.Where(id => id.ContractID == choicecell).First();
                contract.ClientID = textbox1;
                contract.TurID = textbox2;
                contract.HotelID = textbox3;
                contract.Number = Convert.ToInt32(textbox4);
                contract.Cost = Convert.ToDouble(textbox5);
                contract.TotalCost = Convert.ToDouble(Convert.ToDouble(textbox4) * Convert.ToDouble(textbox5));
                contract.Date = Convert.ToDateTime(textbox6);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Контракт изменен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }   
        }
        public void ContractDelete(int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Contract сontract = context.Contract.Where(id => id.ContractID == choicecell).First();
                context.Contract.Remove(сontract);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Контракт удален!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void HotelAdd(string textbox1, string texbox2, string textbox3, string textbox4)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Hotel hotel = new Hotel()
                {
                    Name = textbox1,
                    Rating = Convert.ToInt32(texbox2),
                    Food = textbox3,
                    Cost = Convert.ToDouble(textbox4),
                };
                context.Hotel.Add(hotel);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Новый отель добавлен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void HotelUpdate(string textbox1, string textbox2, string textbox3, string textbox4, int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Hotel hotel = context.Hotel.Where(id => id.HotelID == choicecell).First();
                hotel.Name = textbox1;
                hotel.Rating = Convert.ToInt32(textbox2);
                hotel.Food = textbox3;
                hotel.Cost = Convert.ToDouble(textbox4);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Отель изменен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void HotelDelete(int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Hotel hotel = context.Hotel.Where(id => id.HotelID == choicecell).First();
                context.Hotel.Remove(hotel);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Отель удален!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ExcursionAdd(string textbox1, string textbox2, string textbox3, string texbox4, string textbox5, 
            string textbox6)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Excursion excursion = new Excursion()
                {
                    Name = textbox1,
                    Rating = Convert.ToInt32(textbox2),
                    Length = textbox3,
                    Time = texbox4,
                    Cost = Convert.ToDouble(textbox5),
                    Note = textbox6,
                };
                context.Excursion.Add(excursion);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Новая экскурсия добавлена!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ExcurtionUpdate(string textbox1, string textbox2, string textbox3, string textbox4, 
            string textbox5, string textbox6, int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Excursion excursion = context.Excursion.Where(id => id.ExcursionID == choicecell).First();
                excursion.Name = textbox1;
                excursion.Rating = Convert.ToInt32(textbox2);
                excursion.Length = textbox3;
                excursion.Time = textbox4;
                excursion.Cost = Convert.ToDouble(textbox5);
                excursion.Note = textbox6;
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Экскурсия изменена!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void ExcursionDelete(int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Excursion excursion = context.Excursion.Where(id => id.ExcursionID == choicecell).First();
                context.Excursion.Remove(excursion);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Экскурсия удалена!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void TurAdd(string textbox1, string textbox2, string textbox3, string textbox4,
            string textbox5, string textbox6, string combobox)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Tur tur = new Tur()
                {
                    Country = textbox1,
                    City = textbox2,
                    DateO = Convert.ToDateTime(textbox3),
                    DateI = Convert.ToDateTime(textbox4),
                    Day_Night = textbox5,
                    Cost = Convert.ToDouble(textbox6),                   
                    Name = combobox,
                };
                context.Tur.Add(tur);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Новый тур добавлен!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void TurDelete(int choicecell)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {
                Tur tur = context.Tur.Where(id => id.TurID == choicecell).First();
                context.Tur.Remove(tur);
                try
                {
                    context.SaveChanges();                   
                    MessageBox.Show("Тур удален!");
                }
                catch (Exception z)
                {
                    MessageBox.Show("Ошибка! " + z.Message);
                }
            }
        }
        public void TurUpdate(string textbox1, string textbox2, string textbox3, string textbox4, 
            string textbox5, string textbox6, string combobox, int choicecell)
        {
              using (CWModelContainer1 context = new CWModelContainer1())
              {
                  Tur tur = context.Tur.Where(id => id.TurID == choicecell).First();                 
                    tur.Country = textbox1;
                    tur.City = textbox2;
                    tur.DateO = Convert.ToDateTime(textbox3);
                    tur.DateI = Convert.ToDateTime(textbox4);
                    tur.Day_Night = textbox5;
                    tur.Cost = Convert.ToDouble(textbox6);
                    tur.Name = combobox;
                  try
                  {
                      context.SaveChanges();
                      MessageBox.Show("Данные тура обновлены");
                  }
                  catch (Exception z)
                  {
                      MessageBox.Show("Ошибка! " + z.Message);
                  }
              }
        }
        public void SelectContract(DateTime dateTime1, DateTime dateTime2)
        {
            using (CWModelContainer1 context = new CWModelContainer1())
            {               
                List<Contract> contract = context.Contract.Where(date => date.Date >= dateTime1 && date.Date <= dateTime2).ToList();              
                var doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("Contract.pdf", FileMode.Create));
                doc.Open();

                BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);              
                Paragraph a1 = new Paragraph();
                a1.Alignment = Element.ALIGN_CENTER;
                a1.Add(new Phrase("Контракты", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.UNDERLINE, new BaseColor(Color.Black))));             
                a1.Add(Environment.NewLine);
                a1.Add(Environment.NewLine);
                a1.Add(Environment.NewLine); 

                PdfPTable table = new PdfPTable(7);
                table.AddCell(new Phrase("Клиент", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Тур", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Отель", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Количество", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Стоимость", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Итого", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
                table.AddCell(new Phrase("Дата", new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));

                foreach (Contract i in contract)
                {
                    table.AddCell(new Phrase(i.ClientID.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.TurID.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.HotelID.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.Number.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.Cost.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.TotalCost.ToString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(i.Date.ToShortDateString(), new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                }
               
                doc.Add(a1);
                doc.Add(table);
                doc.Close();
                System.Diagnostics.Process.Start("Contract.pdf");           
            }
        }
    }   
}
