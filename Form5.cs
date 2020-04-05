using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;


namespace ForLesson
{

    public partial class Form5 : Form
    {

        public string Translate(string s, string lang)
        {
            if (s.Length > 0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=trnsl.1.1.20200404T141119Z.ba66a4bbea73f4a7.30f8c9b9f2e9fc3f5e493f7a0bffe9db746fb617"
                    + "&text=" + s
                    + "&lang=" + lang);

                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;

                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);

                        s = "";

                        foreach (string str in translation.text)
                        {
                            s += str;
                        }
                    }
                }

                return s;
            }
            else
                return "";
        }

        class Translation
        {
            public string code { get; set; }
            public string lang { get; set; }
            public string[] text { get; set; }
        }


        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        private void inputOk_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text.ToLower();
            textBox2.Clear();
            string[] baze = File.ReadAllLines("answer_databse.txt");

            for (int i = 0; i < baze.Length; i += 2)
            {
                if (textBox3.Text == baze[i])
                {
                    textBox1.Text = "- " + baze[1 + i];
                    break;
                }
                else
                {
                    textBox1.Text = "- Произошла ошибка, начинается процесс взлома...";
                }

            }

            if (textBox3.Text.Contains("открыть"))
            {
                string Program_name = textBox3.Text.Split().Last();
                Process.Start(Program_name + ".exe");
                textBox1.Text = "- Программа открыта.";
            }
            else if (false)
            {
                textBox1.Text = "- Программа не найдена либо вы допустили ошибку";
            }

            if (textBox3.Text.Contains("реши"))
            {
                string[] split = textBox3.Text.Split();
                int value_one = Int32.Parse(split[1]);
                int value_two = Int32.Parse(split[3]);
                if (textBox3.Text.Contains("+"))
                {
                    int result = value_one + value_two;
                    textBox1.Text = "- " + result.ToString();
                }
                else if (textBox3.Text.Contains("-"))
                {
                    int result = value_one - value_two;
                    textBox1.Text = "- " + result.ToString();
                }
                else if (textBox3.Text.Contains("*"))
                {
                    int result = value_one * value_two;
                    textBox1.Text = "- " + result.ToString();
                }
                else if (textBox3.Text.Contains("/"))
                {
                    int result = value_one / value_two;
                    textBox1.Text = "- " + result.ToString();
                }

            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }

            if (textBox3.Text.Contains("рандом"))
            {
                string[] split = textBox3.Text.Split();
                int value_one = Int32.Parse(split[1]);
                int value_two = Int32.Parse(split[2]);
                Random random = new Random();
                textBox1.Text = random.Next(value_one, value_two).ToString();
            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }

            if (textBox3.Text.Contains("или"))
            {
                string[] split = textBox3.Text.Replace("или", string.Empty).Split();
                Random random = new Random();
                split = split.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                for (int n = 1; n <= split.Length; n++)
                {
                    textBox1.Text = "- " + split[random.Next(n)].ToString();
                }


            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }

            if (textBox3.Text.Contains("день"))
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Now;
                textBox1.Text = "- Сегодня: " + date1.ToString();
            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }

            if (textBox3.Text.Contains("число"))
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Now;
                textBox1.Text = "- Сегодня: " + date1.ToString();
            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }

            if (textBox3.Text.Contains("время"))
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Now;
                textBox1.Text = "- Сегодня: " + date1.ToString();
            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }
            if (textBox3.Text.Contains("дебил"))
            {
                Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                textBox1.Text = "- А может ты?";
            }
            else if (textBox3.Text.Contains("идиот"))
            {
                Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                textBox1.Text = "- А может ты?";
            }
            else if (textBox3.Text.Contains("дурак"))
            {
                Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                textBox1.Text = "- А может ты?";
            }
            else if (textBox3.Text.Contains("тупой"))
            {
                Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                textBox1.Text = "- А может ты?";
            }

            if (textBox3.Text.Contains("перевод"))
            {
                string s = textBox3.Text.Replace("перевод", string.Empty);
                var lang = "ru-en";
                var res = Translate(s, lang);
                textBox1.Text = "- " + res;


            }
            else if (false)
            {
                textBox1.Text = "- Введите ещё раз.";
            }


        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Text = textBox2.Text.ToLower();
                textBox2.Clear();
                string[] baze = File.ReadAllLines("answer_databse.txt");

                for (int i = 0; i < baze.Length; i += 2)
                {
                    if (textBox3.Text == baze[i])
                    {
                        textBox1.Text = "- " + baze[1 + i];
                        break;
                    }
                    else
                    {
                        textBox1.Text = "- Произошла ошибка, начинается процесс взлома...";
                    }

                }

                if (textBox3.Text.Contains("открыть"))
                {
                    string Program_name = textBox3.Text.Split().Last();
                    Process.Start(Program_name + ".exe");
                    textBox1.Text = "- Программа открыта.";
                }
                else if (false)
                {
                    textBox1.Text = "- Программа не найдена либо вы допустили ошибку";
                }

                if (textBox3.Text.Contains("реши"))
                {
                    string[] split = textBox3.Text.Split();
                    int value_one = Int32.Parse(split[1]);
                    int value_two = Int32.Parse(split[3]);
                    if (textBox3.Text.Contains("+"))
                    {
                        int result = value_one + value_two;
                        textBox1.Text = "- " + result.ToString();
                    }
                    else if (textBox3.Text.Contains("-"))
                    {
                        int result = value_one - value_two;
                        textBox1.Text = "- " + result.ToString();
                    }
                    else if (textBox3.Text.Contains("*"))
                    {
                        int result = value_one * value_two;
                        textBox1.Text = "- " + result.ToString();
                    }
                    else if (textBox3.Text.Contains("/"))
                    {
                        int result = value_one / value_two;
                        textBox1.Text = "- " + result.ToString();
                    }

                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("рандом"))
                {
                    string[] split = textBox3.Text.Split();
                    int value_one = Int32.Parse(split[1]);
                    int value_two = Int32.Parse(split[2]);
                    Random random = new Random();
                    textBox1.Text = random.Next(value_one, value_two).ToString();
                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("или"))
                {        
                    string[] split = textBox3.Text.Replace("или", string.Empty).Split();
                    Random random = new Random();
                    split = split.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    for (int n = 1; n <= split.Length; n++)
                    {
                        textBox1.Text = "- " + split[random.Next(n)].ToString();
                    }

                  
                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("день"))
                {
                    DateTime date1 = new DateTime();
                    date1 = DateTime.Now;
                    textBox1.Text = "- Сегодня: " + date1.ToString();
                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("число"))
                {
                    DateTime date1 = new DateTime();
                    date1 = DateTime.Now;
                    textBox1.Text = "- Сегодня: " + date1.ToString();
                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("время"))
                {
                    DateTime date1 = new DateTime();
                    date1 = DateTime.Now;
                    textBox1.Text = "- Сегодня: " + date1.ToString();
                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("дебил"))
                {
                    Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                    textBox1.Text = "- А может ты?";
                }
                else if (textBox3.Text.Contains("идиот"))
                {
                    Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                    textBox1.Text = "- А может ты?";
                }
                else if (textBox3.Text.Contains("дурак"))
                {
                    Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                    textBox1.Text = "- А может ты?";
                }
                else if (textBox3.Text.Contains("тупой"))
                {
                    Process.Start(@"C:\Users\rocks\source\repos\ForLesson\TextFile1.bat");
                    textBox1.Text = "- А может ты?";
                }

                if (textBox3.Text.Contains("перевод"))
                {
                    string s = textBox3.Text.Replace("перевод", string.Empty);
                    var lang = "ru-en";
                    var res = Translate(s, lang);
                    textBox1.Text = "- " + res;


                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }

                if (textBox3.Text.Contains("доллар"))
                {

                    textBox1.Text = AksonBank() + RSBank();

                }
                else if (false)
                {
                    textBox1.Text = "- Введите ещё раз.";
                }
            }

        }

        private String AksonBank()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.sberometer.ru");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"<span id=""oracleCurrentCurs"">([0-9]+\.[0-9]+)</span>").Groups[1].Value;
            return "Sberometer.ru: " + Rate + " р. \r\n";
        }

        

        private String RSBank()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("http://www.rshb.ru/branches/saratov/");
            String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"<td>([0-9]+\.[0-9]+)</td>").Groups[1].Value;
            return "Россельхозбанк: " + Rate + " р. \r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
