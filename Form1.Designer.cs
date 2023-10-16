
namespace TpSocket
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateUDPSocketButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.CloseSocketUDPButton = new System.Windows.Forms.Button();
            this.IpHostTextBox = new System.Windows.Forms.TextBox();
            this.PortHostTextBox = new System.Windows.Forms.TextBox();
            this.PortDestTextBox = new System.Windows.Forms.TextBox();
            this.IpDestTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(41, 156);
            this.SenderTextBox.Multiline = true;
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(166, 105);
            this.SenderTextBox.TabIndex = 0;
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.Location = new System.Drawing.Point(41, 280);
            this.ReceiverTextBox.Multiline = true;
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.ReadOnly = true;
            this.ReceiverTextBox.Size = new System.Drawing.Size(166, 105);
            this.ReceiverTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sender Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receiver Box";
            // 
            // CreateUDPSocketButton
            // 
            this.CreateUDPSocketButton.Location = new System.Drawing.Point(318, 38);
            this.CreateUDPSocketButton.Name = "CreateUDPSocketButton";
            this.CreateUDPSocketButton.Size = new System.Drawing.Size(116, 23);
            this.CreateUDPSocketButton.TabIndex = 4;
            this.CreateUDPSocketButton.Text = "Create UDP socket";
            this.CreateUDPSocketButton.UseVisualStyleBackColor = true;
            this.CreateUDPSocketButton.Click += new System.EventHandler(this.CreateUDPSocketButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(213, 156);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Envoyer";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(213, 280);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiveButton.TabIndex = 6;
            this.ReceiveButton.Text = "Recevoir";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // CloseSocketUDPButton
            // 
            this.CloseSocketUDPButton.Location = new System.Drawing.Point(318, 86);
            this.CloseSocketUDPButton.Name = "CloseSocketUDPButton";
            this.CloseSocketUDPButton.Size = new System.Drawing.Size(116, 23);
            this.CloseSocketUDPButton.TabIndex = 7;
            this.CloseSocketUDPButton.Text = "Close UDP socket";
            this.CloseSocketUDPButton.UseVisualStyleBackColor = true;
            this.CloseSocketUDPButton.Click += new System.EventHandler(this.CloseSocketUDPButton_Click);
            // 
            // IpHostTextBox
            // 
            this.IpHostTextBox.Location = new System.Drawing.Point(41, 38);
            this.IpHostTextBox.Name = "IpHostTextBox";
            this.IpHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpHostTextBox.TabIndex = 8;
            this.IpHostTextBox.Text = "127.0.0.1";
            // 
            // PortHostTextBox
            // 
            this.PortHostTextBox.Location = new System.Drawing.Point(147, 38);
            this.PortHostTextBox.Name = "PortHostTextBox";
            this.PortHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortHostTextBox.TabIndex = 9;
            this.PortHostTextBox.Text = "5001";
            // 
            // PortDestTextBox
            // 
            this.PortDestTextBox.Location = new System.Drawing.Point(147, 89);
            this.PortDestTextBox.Name = "PortDestTextBox";
            this.PortDestTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortDestTextBox.TabIndex = 11;
            this.PortDestTextBox.Text = "5000";
            // 
            // IpDestTextBox
            // 
            this.IpDestTextBox.Location = new System.Drawing.Point(41, 89);
            this.IpDestTextBox.Name = "IpDestTextBox";
            this.IpDestTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpDestTextBox.TabIndex = 10;
            this.IpDestTextBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortDestTextBox);
            this.Controls.Add(this.IpDestTextBox);
            this.Controls.Add(this.PortHostTextBox);
            this.Controls.Add(this.IpHostTextBox);
            this.Controls.Add(this.CloseSocketUDPButton);
            this.Controls.Add(this.ReceiveButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CreateUDPSocketButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiverTextBox);
            this.Controls.Add(this.SenderTextBox);
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form1";
            this.Text = "UDP Socket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateUDPSocketButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.Button CloseSocketUDPButton;
        private System.Windows.Forms.TextBox IpHostTextBox;
        private System.Windows.Forms.TextBox PortHostTextBox;
        private System.Windows.Forms.TextBox PortDestTextBox;
        private System.Windows.Forms.TextBox IpDestTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

