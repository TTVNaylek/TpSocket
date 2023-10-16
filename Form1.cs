using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TpSocket
{
    public partial class Form1 : Form
    {
        //Création des variables pour créer le socket et les points de terminaison
        Socket UDPsocket;
        IPEndPoint IPedD;
        IPEndPoint IPedE;
        IPEndPoint IPedFrom;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateUDPSocketButton_Click(object sender, EventArgs e)
        {
            //Création d'un socket de protocol UDP
            UDPsocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //Création des points de terminaison
            this.IPedD = new IPEndPoint(IPAddress.Parse(this.IpHostTextBox.Text), int.Parse(this.PortHostTextBox.Text));
            this.IPedE = new IPEndPoint(IPAddress.Parse(this.IpDestTextBox.Text), int.Parse(this.PortDestTextBox.Text));
            this.IPedFrom = new IPEndPoint(IPAddress.Any, 0);

            //Permet de lier le socket à la destination
            UDPsocket.Bind(IPedE);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //Permet d'envoyer le message
            var msgEnvoie = Encoding.ASCII.GetBytes(SenderTextBox.Text);
            try
            {
                UDPsocket.SendTo(msgEnvoie, msgEnvoie.Length, SocketFlags.None, IPedD);
            }
            catch (Exception ex)
            {
                this.SenderTextBox.Clear();
                this.SenderTextBox.Text += ex.Message;
            }
        }

        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            //Permet de receptionner le message 
            EndPoint senderRemote = (EndPoint)IPedD;
            var buffer = new byte[1024];
            UDPsocket.ReceiveFrom(buffer, buffer.Length,SocketFlags.None, ref senderRemote);
            //affiche le message dans la textbox
            this.ReceiverTextBox.Text += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        }

        private void CloseSocketUDPButton_Click(object sender, EventArgs e)
        {
            UDPsocket.Close();
        }
    }
}
