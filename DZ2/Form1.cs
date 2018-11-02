using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace DZ2
{
    public partial class Form1 : Form
    {
        static bool isConnected = false;
        static Socket listeningSocket;
        static EndPoint remoteEP;
        static StateObject state;
        static IAsyncResult RcptRes;

        delegate void AddTextDelegate(String text);

        public Form1()
        {
            state = new StateObject();
            InitializeComponent();
            button_SendMessage.Click += Button_SendMessage_Click;
            button_Connect.Click += Button_Connect_Click;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                closeConnection();
                button_Connect.Text = "Connect";
                isConnected = false;
                textBox_Port.Enabled = true;
                textBox_Login.Enabled = true;
                return;
            }

            if (textBox_Login.Text == "")
            {
                MessageBox.Show("Input your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_Port.Text == "")
            {
                MessageBox.Show("Input connection port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button_Connect.Text = "Disconnect";
            isConnected = true;
            textBox_Port.Enabled = false;
            textBox_Login.Enabled = false;

            if (listeningSocket != null)
                return;

            listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listeningSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            listeningSocket.Bind(new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), Convert.ToInt32(textBox_Port.Text)));
            remoteEP = (EndPoint)new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox_Port.Text));

            state.workSocket = listeningSocket;
            RcptRes = listeningSocket.BeginReceiveFrom(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ref remoteEP, new AsyncCallback(Receive), state);
        }

        private void Button_SendMessage_Click(object sender, EventArgs e)
        {
            if (textBox_Message.Text == "")
                return;

            textBox_Message.Text.Replace('@', ' ');

            byte[] data = Encoding.Unicode.GetBytes(textBox_Login.Text + "@" + textBox_Message.Text);
            EndPoint remotePoint = new IPEndPoint(IPAddress.Broadcast, Convert.ToInt32(textBox_Port.Text));

            listeningSocket.SendTo(data, remotePoint);
            textBox_Message.Text = "";
        }

        private void AddText(String text)
        {
            textBox_Chat.Text += text;
        }

        private void Receive(IAsyncResult ia)
        {
            StateObject so = (StateObject)ia.AsyncState;
            Socket client = so.workSocket;

            if (listeningSocket == null)
                return;

            int readed = client.EndReceiveFrom(RcptRes, ref remoteEP);
            String strClientIP = ((IPEndPoint)remoteEP).Address.ToString();

            var message = System.Text.Encoding.Unicode.GetString(so.buffer, 0, readed);
            var messageData = message.Split('@');
            String str = String.Format("\n{0} ({1}): {2}\r\n", messageData[0], strClientIP, messageData[1]);
            textBox_Chat.BeginInvoke(new AddTextDelegate(AddText), str);

            RcptRes = listeningSocket.BeginReceiveFrom(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ref remoteEP, new AsyncCallback(Receive), state);
        }

        private void closeConnection()
        {
            if (listeningSocket != null)
            {
                listeningSocket.Shutdown(SocketShutdown.Both);
                listeningSocket.Close();
                listeningSocket = null;
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }

    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }

}
