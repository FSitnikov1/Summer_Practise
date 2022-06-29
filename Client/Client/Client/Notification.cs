using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Notification : Form
    {
        string login;
        string message;
        Socket socket;
        bool request;
        public Notification(Socket socket, string message, bool request, string login)
        {
            InitializeComponent();
            this.socket = socket;
            this.message = message;
            this.request = request;
            this.login = login;
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

        private void Notification_Load(object sender, EventArgs e)
        {
            if (request)
            {
                OnDelLabel.Text = " Вы уверенны что хотите удалить данное сообщение?";
            }
            else
            {
                OnDelLabel.Text = " Текущий пользователь будет удалён, вы уверенны?";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (request)
            {
                send_mes("M04^" + Convert.ToInt32(message) + "^" + login, socket);
                this.Close();
            }
            else
            {
                send_mes("L00^" + message, socket);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
