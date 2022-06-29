using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Chat : Form
    {

        const string ip = "127.0.0.1";
        const int port = 7070;


        IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);    // Порт
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);    // Создание сокета

        private string login = "", password;

        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (socket.Connected)
                    send_mes("L01^" + login);
            }
            catch (Exception ex) { }
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            try     // Проверка подключения
            {
                socket.Connect(tcpEndPoint); // Подключаем сокет
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                error_label.Text = " Отсутствует соединение с сервером!";
                btn_loginin.Enabled = false;
                btn_registration.Enabled = false;
                return;
            }
        }

        private void send_mes(string message)
        {
            //  Отправка
            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);
        }

        private string[] ans_mes()
        {
            byte[] buffer = new byte[1024]; // Буфер для получаемых данных
            var size = 0;                   // Количество полученных байтов
            StringBuilder answer = new StringBuilder();

            do
            {
                size = socket.Receive(buffer, buffer.Length, 0);
                answer.Append(Encoding.Unicode.GetString(buffer, 0, size));  // Из сообщения берем непустые байты
            }
            while (socket.Available > 0);
            return answer.ToString().Split('^');
        }

        private void btn_loginin_Click(object sender, EventArgs e)
        {
            login = in_login.Text;
            password = in_password.Text;

            if (login != "" && password != "")  //  Проверка полей на пустоту
            {
                if (login != "General")
                {
                    string message = "L02^" + login + "^" + password;
                    send_mes(message);
                    string[] answer = ans_mes();
                    if (answer[0] == "1")
                    {
                        // Вошли в аккаунт
                        error_label.Text = "";
                        Messanger newMes = new Messanger();
                        newMes.preload(socket, login, password, ip, port);
                        newMes.Show();
                        this.Hide();
                    }
                    else if (answer[0] == "2")
                    {
                        error_label.Text = "Пользователь уже в сети!";
                    }
                    else if (answer[0] == "0")
                    {
                        error_label.Text = "Неверное имя пользователя или пароль!";
                    }
                }
                else
                {
                    error_label.Text = "Имя пользователя занято!";
                }
            }
            else
            {
                error_label.Text = "Заполните поля!";
            }
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            login = in_login.Text;
            password = in_password.Text;

            if (login != "" && password != "")  //  Проверка полей на пустоту
            {
                if (login != "General")
                {
                    string message = "L03^" + login + "^" + password;
                    send_mes(message);
                    if (ans_mes()[0] == "1")
                    {
                        // Вошли в аккаунт
                        error_label.Text = "";
                        Messanger newMes = new Messanger();
                        newMes.preload(socket, login, password, ip, port);
                        newMes.Show();
                        this.Hide();
                    }
                    else
                    {
                        error_label.Text = "Пользователь уже существует!";
                    }
                }
                else
                {
                    error_label.Text = "Имя пользователя занято!";
                }
            }
            else
            {
                error_label.Text = "Заполните поля!";
            }
        }
    }
}
