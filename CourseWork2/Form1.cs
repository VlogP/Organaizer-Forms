using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace CourseWork2
{
   
    public partial class Form1 : Form
    {
        int x1 = 0, x2 = 0, x3 = 0,kolvo=0;
        int flagofSost = 0, flagofADD = 0, flagofADD1=0,bufi1;
        BinaryFormatter formatter = new BinaryFormatter();
        int x11 = 5;





        [Serializable]
        public class FILEOFTEXT
        {

            public string Text;
            public string Date;
            public string Number;
           
       
        }


        FILEOFTEXT[] MassivOfWork = new FILEOFTEXT[100];
 

        public Form1()
        {
      
            InitializeComponent();
   
       
        }
       
       

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
            label1.Text = "Today is " + DateTime.Now.ToShortDateString();
            label2.Text = "Time is " + DateTime.Now.ToLongTimeString();
            if (x1 == 0 && x2==0 && x3 <=255 )
            {
                x3=x3+5;
            }
            if (x1 == 0 && x3 == 255  && x2<=255 )
            {
                x2=x2+5;
            }
            if (x1 <= 255 && x2 == 255 && x3 == 255)
            {
                x1=x1+5;

            }
           
            if (x3 >= 1 && x1 == 255 && x2 == 255)
            {
                x3=x3-5;
            }
            if (x3 == 0 && x1 >= 1 && x2 == 255)
            {
                x1=x1-5;
            }
            if (x3 == 0 && x1 ==0 && x2 >= 1)
            {
                x2=x2-5;
            }
            label3.ForeColor = Color.FromArgb(x1, x2, x3);
            
            if (flagofSost == 1)
            {

                ButtonADD.Visible = false;
                buttonOfWatch.Visible = false;
                buttonOfDelete.Visible = false;
                buttonOfEdit.Visible = false;
                buttonOfGame.Visible = false;
                buttonOfExit.Text = "Назад";
                textBoxOfHelp.Visible = true;
                buttonOfHelp.Visible = false;
            }
            if (flagofSost == 0)
            {
                ButtonADD.Visible = true;
                buttonOfWatch.Visible = true;
                buttonOfDelete.Visible = true;
                buttonOfEdit.Visible = true;
                buttonOfGame.Visible = true;
                buttonOfExit.Text = "Выход";
                textBoxOfHelp.Visible = false;
                buttonOfHelp.Visible = false;
            }
            if (flagofSost == 2)
            {

                ButtonADD.Visible = false;
                buttonOfWatch.Visible = false;
                buttonOfDelete.Visible = false;
                buttonOfEdit.Visible = false;
                buttonOfGame.Visible = false;
                buttonOfExit.Text = "Назад";
                richTextBoxOfShow.Visible = true;
                textBoxOfHelp.Visible = false;
                buttonOfHelp.Visible = false;
            }
            if (flagofSost == 3)
            {
                ButtonADD.Visible = false;
                buttonOfWatch.Visible = false;
                buttonOfDelete.Visible = false;
                buttonOfEdit.Visible = false;
                buttonOfGame.Visible = false;
                buttonOfExit.Text = "Назад";
                richTextBoxOfShow.Visible = true;            
                buttonOfHelp.Visible = true;
            }


          



        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Process.Start("D:/Course Work/FSS1.exe");
        }

        

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (flagofADD == 1 && textBoxOfHelp.TextLength > 0 && flagofSost!=4)
            {
              
                char[] massiv = new char[2];
                massiv[0] = '\r';
                massiv[1] = '\n';

                FileStream datafile = new FileStream("DataOrg.txt", FileMode.Create) ;
                MassivOfWork[kolvo - 1].Text = textBoxOfHelp.Text.Trim(massiv);
                MassivOfWork[kolvo - 1].Text.Trim(massiv);
               
                flagofADD = 2;
                flagofSost = 0;
           
                textBoxOfHelp.Text = "";
                textBoxOfHelp.Text.Trim();
                textBoxOfHelp.Multiline = false;
                textBoxOfHelp.Location = new Point(617, 326);
                textBoxOfHelp.Size = new Size(153, 20);
                List<FILEOFTEXT> stds = new List<FILEOFTEXT>();

                string buf;
                string buf1;
             
                int min;
                int j;
                if (kolvo >= 2)
                {
                    for (int i = 0; i < kolvo; i++)
                    {
                        min = i;
                        for (j = i + 1; j < kolvo; j++)
                        {
                            if (Convert.ToDateTime(MassivOfWork[j].Date) <= Convert.ToDateTime(MassivOfWork[min].Date)) { min = j; }
                        }
                        buf = MassivOfWork[i].Date;
                        MassivOfWork[i].Date = MassivOfWork[min].Date;
                        MassivOfWork[min].Date = buf;

                        buf1 = MassivOfWork[i].Text;
                        MassivOfWork[i].Text = MassivOfWork[min].Text;
                        MassivOfWork[min].Text = buf1;

                    }
                }








                for (int i = 0; i < kolvo; i++)
                {
                    stds.Add(MassivOfWork[i]);
                }
                formatter.Serialize(datafile, stds);
           

                
                MessageBox.Show("Информация записана");
                datafile.Close();
                datafile.Dispose();
            }
            else
            {
                if (textBoxOfHelp.TextLength <= 0 && flagofADD == 1)
                {
                    MessageBox.Show("Пустой ввод");
                }
            }




            if (flagofSost == 4 && flagofADD1 == 2 && textBoxOfHelp.TextLength > 0)
            {

                char[] massiv = new char[2];
                massiv[0] = '\r';
                massiv[1] = '\n';

                FileStream datafile = new FileStream("DataOrg.txt", FileMode.Create);
                MassivOfWork[bufi1-1].Text = textBoxOfHelp.Text.Trim(massiv);
                MassivOfWork[bufi1 - 1].Text.Trim(massiv);

                flagofADD1 = 0;
                flagofSost = 0;
                richTextBoxOfShow.Text = "";
                textBoxOfHelp.Text = "";
                textBoxOfHelp.Text.Trim();
                textBoxOfHelp.Multiline = false;
                textBoxOfHelp.Location = new Point(617, 326);
                textBoxOfHelp.Size = new Size(153, 20);
                List<FILEOFTEXT> stds = new List<FILEOFTEXT>();

                string buf;
                string buf1;

                int min;
                int j;
                if (kolvo >= 2)
                {
                    for (int i = 0; i < kolvo; i++)
                    {
                        min = i;
                        for (j = i + 1; j < kolvo; j++)
                        {
                            if (Convert.ToDateTime(MassivOfWork[j].Date) <= Convert.ToDateTime(MassivOfWork[min].Date)) { min = j; }
                        }
                        buf = MassivOfWork[i].Date;
                        MassivOfWork[i].Date = MassivOfWork[min].Date;
                        MassivOfWork[min].Date = buf;

                        buf1 = MassivOfWork[i].Text;
                        MassivOfWork[i].Text = MassivOfWork[min].Text;
                        MassivOfWork[min].Text = buf1;

                    }
                }








                for (int i = 0; i < kolvo; i++)
                {
                    stds.Add(MassivOfWork[i]);
                }
                formatter.Serialize(datafile, stds);



                MessageBox.Show("Информация записана");
                datafile.Close();
                datafile.Dispose();
            }
            else
            {
                if (textBoxOfHelp.TextLength <= 0 && flagofADD == 1)
                {
                    MessageBox.Show("Пустой ввод");
                }
            }

        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bufstring;
            ButtonADD.Visible = false;
            buttonOfWatch.Visible = false;
            buttonOfDelete.Visible = false;
            buttonOfEdit.Visible = false;
            buttonOfGame.Visible = false;
            buttonOfExit.Text = "Назад";
            richTextBoxOfShow.Visible = true;
            textBoxOfHelp.Visible = false;
            buttonOfHelp.Visible = false;
            Font fnt = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font fnt1 = new Font("Vineta BT", 12, FontStyle.Italic, GraphicsUnit.Point);
            Font fnt2 = new Font("Monotype Corsiva", 20, FontStyle.Italic, GraphicsUnit.Point);
            flagofSost = 2;
            richTextBoxOfShow.Visible = true;
            int my1stPosition;
          
            for (int i = 0; i < kolvo; i++)
            {
        
                richTextBoxOfShow.Text = richTextBoxOfShow.Text + "                                   " + MassivOfWork[i].Number+ "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text+"                                    "+ MassivOfWork[i].Date + "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text +  MassivOfWork[i].Text + "\r\n";

             
               

               

            }

 
            for (int i = 0; i < kolvo; i++)
            {



                int s_start = richTextBoxOfShow.SelectionStart, startIndex = 0, index;

                while ((index = richTextBoxOfShow.Text.IndexOf(MassivOfWork[i].Date, startIndex)) != -1)
                {
                    richTextBoxOfShow.Select(index, MassivOfWork[i].Date.Length);
                    richTextBoxOfShow.SelectionColor = Color.Blue; ;
                    richTextBoxOfShow.SelectionFont = fnt1;
                    startIndex = index + MassivOfWork[i].Date.Length;
                }

                richTextBoxOfShow.SelectionStart = s_start;
                richTextBoxOfShow.SelectionLength = 0;
                richTextBoxOfShow.SelectionColor = Color.Black;
                richTextBoxOfShow.SelectionFont = fnt2;







            }

            for (int i = 0; i < kolvo; i++)
            {
                my1stPosition = richTextBoxOfShow.Find(MassivOfWork[i].Number);
                richTextBoxOfShow.SelectionStart = my1stPosition;
                richTextBoxOfShow.SelectionFont = fnt;
                richTextBoxOfShow.SelectionLength = MassivOfWork[i].Number.Length;
                richTextBoxOfShow.SelectionColor = Color.DarkRed;

            }
            int j, j1 = 0;
            for (j = 0; j < kolvo; j++)
            {
                if (Convert.ToDateTime(MassivOfWork[j].Date).Year == DateTime.Now.Year)
                {
                    if (Convert.ToDateTime(MassivOfWork[j].Date).Month == DateTime.Now.Month)
                    {
                        if (Convert.ToDateTime(MassivOfWork[j].Date).Day == DateTime.Now.Day)
                        {
                            j1++;
                        }
                    }

                }
            }


            MessageBox.Show("На сегодня есть: " + Convert.ToString(j1) + " дело");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flagofSost = 3;
            ButtonADD.Visible = false;
            buttonOfWatch.Visible = false;
            buttonOfDelete.Visible = false;
            buttonOfEdit.Visible = false;
            buttonOfGame.Visible = false;
            buttonOfExit.Text = "Назад";
            richTextBoxOfShow.Visible = true;
            buttonOfHelp.Visible = true;
            buttonOfHelp.Text = "Удаление";
            int my1stPosition;
            Font fnt = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font fnt1 = new Font("Vineta BT", 12, FontStyle.Italic, GraphicsUnit.Point);
            Font fnt2 = new Font("Monotype Corsiva", 20, FontStyle.Italic, GraphicsUnit.Point);

            for (int i = 0; i < kolvo; i++)
            {

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + "                                   " + MassivOfWork[i].Number + "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + "                                    " + MassivOfWork[i].Date + "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + MassivOfWork[i].Text + "\r\n";






            }


            for (int i = 0; i < kolvo; i++)
            {




                int s_start = richTextBoxOfShow.SelectionStart, startIndex = 0, index;

                while ((index = richTextBoxOfShow.Text.IndexOf(MassivOfWork[i].Date, startIndex)) != -1)
                {
                    richTextBoxOfShow.Select(index, MassivOfWork[i].Date.Length);
                    richTextBoxOfShow.SelectionColor = Color.Blue; ;
                    richTextBoxOfShow.SelectionFont = fnt1;
                    startIndex = index + MassivOfWork[i].Date.Length;
                }

                richTextBoxOfShow.SelectionStart = s_start;
                richTextBoxOfShow.SelectionLength = 0;
                richTextBoxOfShow.SelectionColor = Color.Black;
                richTextBoxOfShow.SelectionFont = fnt2;



            }

            for (int i = 0; i < kolvo; i++)
            {
                my1stPosition = richTextBoxOfShow.Find(MassivOfWork[i].Number);
                richTextBoxOfShow.SelectionStart = my1stPosition;
                richTextBoxOfShow.SelectionFont = fnt;
                richTextBoxOfShow.SelectionLength = MassivOfWork[i].Number.Length;
                richTextBoxOfShow.SelectionColor = Color.DarkRed;

            }

        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOfHelp.Location = new Point(1031, 277);
            textBoxOfHelp.Visible = true;
            MessageBox.Show("Введите номер элемента");
        }

     
       

        private void button4_Click(object sender, EventArgs e)
        {
            flagofSost = 4;
            flagofADD1 = 0;
            buttonOfHelp.Text = "Редактирование";
               ButtonADD.Visible = false;
                buttonOfWatch.Visible = false;
                buttonOfDelete.Visible = false;
                buttonOfEdit.Visible = false;
                buttonOfGame.Visible = false;
                buttonOfExit.Text = "Назад";
                richTextBoxOfShow.Visible = true;
                buttonOfHelp.Visible = true;
            int my1stPosition;
            Font fnt = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font fnt1 = new Font("Vineta BT", 12, FontStyle.Italic, GraphicsUnit.Point);
            Font fnt2 = new Font("Monotype Corsiva", 20, FontStyle.Italic, GraphicsUnit.Point);

            for (int i = 0; i < kolvo; i++)
            {

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + "                                   " + MassivOfWork[i].Number + "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + "                                    " + MassivOfWork[i].Date + "\r\n";

                richTextBoxOfShow.Text = richTextBoxOfShow.Text + MassivOfWork[i].Text + "\r\n";



            }


            for (int i = 0; i < kolvo; i++)
            {


                int s_start = richTextBoxOfShow.SelectionStart, startIndex = 0, index;

                while ((index = richTextBoxOfShow.Text.IndexOf(MassivOfWork[i].Date, startIndex)) != -1)
                {
                    richTextBoxOfShow.Select(index, MassivOfWork[i].Date.Length);
                    richTextBoxOfShow.SelectionColor = Color.Blue; ;
                    richTextBoxOfShow.SelectionFont = fnt1;
                    startIndex = index + MassivOfWork[i].Date.Length;
                }

                richTextBoxOfShow.SelectionStart = s_start;
                richTextBoxOfShow.SelectionLength = 0;
                richTextBoxOfShow.SelectionColor = Color.Black;
                richTextBoxOfShow.SelectionFont = fnt2;


            }

            for (int i = 0; i < kolvo; i++)
            {
                my1stPosition = richTextBoxOfShow.Find(MassivOfWork[i].Number);
                richTextBoxOfShow.SelectionStart = my1stPosition;
                richTextBoxOfShow.SelectionFont = fnt;
                richTextBoxOfShow.SelectionLength = MassivOfWork[i].Number.Length;
                richTextBoxOfShow.SelectionColor = Color.DarkRed;

            }
          

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            DateTime dob,bufdate;
            string bufstring;
            int bufi;
            if (flagofSost == 1)
            {

                if (e.KeyCode == Keys.Enter && flagofADD == 0)
                {



                    if (DateTime.TryParseExact(textBoxOfHelp.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out dob))
                    {

                        if (dob >= DateTime.Now.Date)
                        {
                           
                            
                            MassivOfWork[kolvo] = new FILEOFTEXT();
                            MassivOfWork[kolvo].Number = "Номер Записи:" + Convert.ToString(kolvo+1);
                            MassivOfWork[kolvo].Date = textBoxOfHelp.Text;
                            kolvo++;
                            flagofADD = 1;
                            textBoxOfHelp.Text = "";

                            textBoxOfHelp.Multiline = true;
                            textBoxOfHelp.Location = new Point(486, 148);
                            textBoxOfHelp.Size = new Size(443, 470);
                        }
                        else
                        {
                            MessageBox.Show("Дата неактуальна");
                            textBoxOfHelp.Text = "";
                            textBoxOfHelp.Text.Trim();
                            flagofADD = 0;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный формат");
                        textBoxOfHelp.Text = "";
                        textBoxOfHelp.Text.Trim();
                        flagofADD = 0;

                    }

                }
         
                        }
            //Второе состояние

            if (flagofSost == 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bufi = 0;
                    for (int i=0;i< textBoxOfHelp.Text.Length; i++)
                    {
                        
                        if (textBoxOfHelp.Text[i] < '0' || textBoxOfHelp.Text[i] > '9')
                        {
                            bufi++;
                        }
                    }
                    if (bufi == 0)
                    {

                        bufi1 = Convert.ToInt32(textBoxOfHelp.Text);
                    if(bufi1>0 && bufi1 <= kolvo)
                        {
                           
                            for (int i = bufi1 - 1; i < kolvo - 1; i++)
                            {
                                MassivOfWork[i].Text = MassivOfWork[i + 1].Text;
                                MassivOfWork[i].Date = MassivOfWork[i + 1].Date;
                                if (i == kolvo -2 )
                                {
                                    MassivOfWork[kolvo - 1] = null;
                                }
                            }
                            kolvo--;
                            textBoxOfHelp.Text = "";
                            MessageBox.Show("Элемент удален");
                            FileStream datafile = new FileStream("DataOrg.txt", FileMode.Create);
                            List<FILEOFTEXT> stds = new List<FILEOFTEXT>();
                            for (int i = 0; i < kolvo; i++)
                            {
                                stds.Add(MassivOfWork[i]);
                            }
                            formatter.Serialize(datafile, stds);
                            richTextBoxOfShow.Text = "";
                            richTextBoxOfShow.Visible = false;
                          flagofSost = 0;
                            datafile.Close();
                            datafile.Dispose();
                            textBoxOfHelp.Location = new Point(617, 326);
                            textBoxOfHelp.Size = new Size(153, 20);
                        }
                       else
                        {
                            MessageBox.Show("Неправильный формат");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Неправильный формат");

                    }



                }


            }


            if (flagofSost == 4 && flagofADD1 == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {



                    if (DateTime.TryParseExact(textBoxOfHelp.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out dob))
                    {

                        if (dob >= DateTime.Now.Date)
                        {
                            MassivOfWork[bufi1 - 1].Date = textBoxOfHelp.Text;

                            MessageBox.Show("Введите своё занятие");
                            buttonOfHelp.Visible = false;
                            richTextBoxOfShow.Visible = false;

  
                              textBoxOfHelp.Text = "";
                            flagofADD1 = 2;
                            textBoxOfHelp.Multiline = true;
                            textBoxOfHelp.Location = new Point(486, 148);
                            textBoxOfHelp.Size = new Size(443, 470);
                            textBoxOfHelp.Text = MassivOfWork[bufi1 - 1].Text;
                        }
                        else
                        {
                            MessageBox.Show("Дата неактуальна");
                            textBoxOfHelp.Text = "";
                            textBoxOfHelp.Text.Trim();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный формат");
                        textBoxOfHelp.Text = "";
                        textBoxOfHelp.Text.Trim();


                    }

                }

            }



            if (flagofSost == 4 && flagofADD1 == 0 )
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bufi = 0;
                    for (int i = 0; i < textBoxOfHelp.Text.Length; i++)
                    {

                        if (textBoxOfHelp.Text[i] < '0' || textBoxOfHelp.Text[i] > '9')
                        {
                            bufi++;
                        }
                    }
                    if (bufi == 0)
                    {
                       
                        bufi1 = Convert.ToInt32(textBoxOfHelp.Text);
                        if (bufi1 <= kolvo&& bufi1>0)
                        {
                            flagofADD1 = 1;

                            MessageBox.Show("Введите дату");
                            textBoxOfHelp.Clear();
                        }
                        else {
                            MessageBox.Show("Неправильный формат");
                            textBoxOfHelp.Text = "";

                        }


                    }
                    else {
                        MessageBox.Show("Неправильный формат");
                        textBoxOfHelp.Text = "";
                    }



                }
                }

           



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i =-1;
        FileStream datafile = new FileStream("DataOrg.txt", FileMode.Open) ;

            try
            {
                List<FILEOFTEXT> stds = (List<FILEOFTEXT>)formatter.Deserialize(datafile);
            
                if (stds.Count != 0)
                {
                    for (i = 0; i < stds.Count; i++)
                        MassivOfWork[i] = new FILEOFTEXT();

                    stds.CopyTo(MassivOfWork);
                    kolvo = stds.Count;
                   
                }
            }
            catch(Exception ex)
            {
                kolvo = 0;
               

            }






            
            datafile.Close();
            datafile.Dispose();
     


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
         flagofSost=1;
            flagofADD = 0;
            MessageBox.Show("Введите дату");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flagofSost == 0)
            {
                this.Close();
           }
            if (flagofSost == 1)
            {
                flagofSost = 0;
                textBoxOfHelp.Text = "";
                textBoxOfHelp.Multiline = false;
                textBoxOfHelp.Location = new Point(617, 326);
                textBoxOfHelp.Size = new Size(153, 20);
                if (flagofADD >= 1)
                {
                    flagofADD = 0;
                    kolvo--;
                }
            }

            if (flagofSost == 2)
            {
                flagofSost = 0;
                richTextBoxOfShow.Visible = false;
                richTextBoxOfShow.Text = "";
            }

            if (flagofSost == 3)
            {
                flagofSost = 0;
                richTextBoxOfShow.Visible = false;
                richTextBoxOfShow.Text = "";
                buttonOfHelp.Visible = false;
                textBoxOfHelp.Visible = false;
                textBoxOfHelp.Location = new Point(617, 326);
            }

            if (flagofSost == 4)
            {
                flagofSost = 0;
                richTextBoxOfShow.Visible = false;
                richTextBoxOfShow.Text = "";
                buttonOfHelp.Visible = false;
                textBoxOfHelp.Visible = false;
                textBoxOfHelp.Location = new Point(617, 326);
                textBoxOfHelp.Size = new Size(153, 20);
                textBoxOfHelp.Text = "";
            }

        }
    }
}
