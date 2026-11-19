using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWParser
{
    public partial class Form1 : Form
    {
        ConcurrentBag<string> validUsers = new ConcurrentBag<string>();
        List<string> users = new List<string>();
        List<string> _endings = new List<string> { "_redacted" };
        HttpClient client = new HttpClient();
        bool ischecked = false;

        public Form1()
        {
            InitializeComponent();
        }

        string OpenD(string Title)
        {
            var d = new OpenFileDialog { DefaultExt = ".txt", Title = Title };
            if (d.ShowDialog() == DialogResult.OK)
            {
                return d.FileName;
            }
            return "";
        }

        string SaveD(string Title)
        {
            var d = new SaveFileDialog { DefaultExt = ".txt", Title = Title };
            if (d.ShowDialog() == DialogResult.OK)
            {
                return d.FileName;
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnInput.Text = OpenD("Файл с юзами");
            if (System.IO.File.Exists(fnInput.Text))
            {
                users = System.IO.File.ReadAllLines(fnInput.Text).Select(x => x.Replace("@", "").Split('/').Last()).Distinct().ToList();
            }
            totalEndings.Text = $"{users.Count}/{users.Count * _endings.Count}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnOut.Text = SaveD("Выходной файл");
        }

        void Working(bool w)
        {
            doBreak = false;
            button2.Enabled = !w;
            button4.Enabled = !w;
            button1.Enabled = !w;
            endings.Enabled = !w;
            progressBar1.Value = 0;
            validUsers = new ConcurrentBag<string>();
        }

        private async Task<bool> checkUser(string username)
        {
            try
            {
                var r = await client.GetStringAsync($"https://t.me/{username}");
                if (r.Contains("tg://resolve?domain=") && !r.Contains("<meta name=\"robots\" content=\"noindex, nofollow\">"))
                {
                    Console.WriteLine(username + " is valid");
                    validUsers.Add(username);
                    return true;
                }
                else
                {
                    Console.WriteLine(username + " is invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
//                throw ex;
            }
            return false;
        }

        private async Task ExecTasks(List<Task> tasks)
        {
            await Task.WhenAll(tasks);
            Console.WriteLine($"Valid Users: {validUsers.Count}");
            succParsed.BeginInvoke(new Action(() =>
            {
                succParsed.Text = validUsers.Count.ToString();
            }));
            progressBar1.BeginInvoke(new Action(() =>
            {
                int v = (int)Math.Round((double)validUsers.Count / (double)(users.Count*(ischecked ? _endings.Count : 1)) * 100, 0);
                progressBar1.Value = v >= 100 ? 100 : (v <= 0 ? 0 : v);
            }));
            tasks.Clear();
            File.WriteAllLines(fnOut.Text, validUsers);
        }
        bool doBreak = false;

        private async Task Parse()
        {
            List<Task> tasks = new List<Task>();
            foreach (var u in users)
            {
                if (doBreak)
                {
                    doBreak = false;
                    MessageBox.Show("Остановлено.");
                    return;
                }
                tasks.Add(Task.Run(async ()=>await checkUser(u)));
                if (endings.Checked)
                {
                    _endings.ForEach(x => tasks.Add(Task.Run(async () => await checkUser(u + x))));
                }
                if (tasks.Count >= 10)
                {
                    await ExecTasks(tasks);
                    Thread.Sleep(1000);
                }
            }
            await ExecTasks(tasks);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (
                System.IO.File.Exists(fnInput.Text) &&
                users.Count != 0
            )
            {
                ischecked = endings.Checked;
                Working(true);
                await Task.Run(() => Parse());
                Working(false);
                MessageBox.Show("Готово!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doBreak = true;
        }
    }
}
