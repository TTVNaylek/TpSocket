//This file is part of TpSocket
//TpSocket is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//TpSocket is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with TpSocket If not, see <https://www.gnu.org/licenses/>
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

            //Delai de réception d'un message pour ne pas bloquer l'app
            UDPsocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);

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

            //Génère une exception qui permet d'annoncer la non connectivité au serveur
            try
            {
                UDPsocket.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref senderRemote);
            }
            catch (Exception ex)
            {
                //Message box erreur
                string title = "Exception";
                string message = "Erreur: La connexion au serveur à échoué. \nPour plus de précisions: \n" + ex;
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Retry)
                {
                    //Do nothing
                }
                else if(result == DialogResult.Cancel) {
                    //Do nothing
                }
            }
            //affiche le message réceptionné dans la textbox
            this.ReceiverTextBox.Text += Encoding.ASCII.GetString(buffer, 0, buffer.Length);
        }

        private void CloseSocketUDPButton_Click(object sender, EventArgs e)
        {
            UDPsocket.Close();
        }
    }
}
