using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Messanger : Form
    {
        private string login;
        private string password;
        Socket socket;
        private string ip;
        private int port;
        List<(string, string, string)> listMes = new List<(string, string, string)>();

        public void preload(Socket socket, string login, string password, string ip, int port)
        {
            this.socket = socket;
            this.login = login;
            this.password = password;
            this.ip = ip;
            this.port = port;
        }

        public Messanger()
        {
            InitializeComponent();
        }

        private void send_mes(string message, Socket socket)
        {
            //  Отправка
            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);
        }

        private string[] ans_mes(Socket socket)
        {
            byte[] buffer = new byte[1024]; // Буфер для получаемых данных
            var size = 0;                   // Количество полученных байтов
            StringBuilder answer = new StringBuilder();

            do
            {
                size = socket.Receive(buffer, buffer.Length, 0); //**
                answer.Append(Encoding.Unicode.GetString(buffer, 0, size));  // Из сообщения берем непустые байты
            }
            while (socket.Available > 0);
            return answer.ToString().Split('^');
        }

        private void Messanger_Load(object sender, EventArgs e)
        {
            this.Show();

            ChatListView.Items[0].Focused = true;   // Выбор общего чата по дефолту
            ChatListView.Items[0].Selected = true;
            ChatListView.Items[0].EnsureVisible();

            CurUserToolStripTextBox.Text = login;

            UpdateData();

            timer1.Enabled = true;
        }

        private void Messanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            send_mes("L01", socket);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text != "")
            {
                string message = MessageTextBox.Text, recipient = CurrentRecipientLabel.Text;
                if (CurrentRecipientLabel.Text == "Общий чат")
                    recipient = "Global";
                send_mes("M02^" + login + "^" + recipient + "^" + message, socket);
                MessageTextBox.Text = "";
            }
        }

        private void ChatListView_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            //  Обновление списка пользователей  //
            string current = "Общий чат";
            bool f = false;
            for (int i = 0; i < ChatListView.Items.Count; i++)
                if (ChatListView.Items[i].Selected)
                    current = ChatListView.Items[i].Text;
            int countU; // кол-во пользователей
            ChatListView.Items.Clear();
            ChatListView.Items.Add("Общий чат");
            send_mes("M01^" + login, socket);
            countU = Convert.ToInt32(ans_mes(socket)[0]);
            for (int i = 1; i < countU + 1; i++)
            {
                int pict = 0;
                send_mes(" ", socket);
                string[] ans = ans_mes(socket);
                if (ans[1] != login)
                {
                    if (ans[0] == "1")
                        pict = 1;
                    ChatListView.Items.Add(ans[1]).ImageIndex = pict;
                }
            }
            for (int i = 0; i < ChatListView.Items.Count; i++)
                if (ChatListView.Items[i].Text == current)
                {
                    ChatListView.Items[i].Selected = true;
                    f = true;
                }
            if (!f)
            {
                ChatListView.Items[0].Selected = true;
            }
            //                                   //

        }

        private void UserDelToolStripMenuItem_Click(object sender, EventArgs e) //  Удаление пользователя
        {
            Notification note = new Notification(socket, login, false, login);
            note.Show();
        }

        private void ChatListBox_DoubleClick(object sender, EventArgs e)
        {

            Notification note = new Notification(socket, listMes[ChatListBox.SelectedIndex].Item1, true, login);
            note.Show();
        }
    }
}
