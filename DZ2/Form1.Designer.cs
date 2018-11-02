namespace DZ2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Chat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(44, 359);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(129, 27);
            this.textBox_Login.TabIndex = 1;
            // 
            // textBox_Message
            // 
            this.textBox_Message.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Message.Location = new System.Drawing.Point(45, 411);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(288, 27);
            this.textBox_Message.TabIndex = 3;
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SendMessage.Location = new System.Drawing.Point(350, 404);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(96, 38);
            this.button_SendMessage.TabIndex = 4;
            this.button_SendMessage.Text = "SEND";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your message:";
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Connect.Location = new System.Drawing.Point(350, 352);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(96, 38);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Port.Location = new System.Drawing.Point(229, 359);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(104, 27);
            this.textBox_Port.TabIndex = 7;
            this.textBox_Port.Text = "4000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // textBox_Chat
            // 
            this.textBox_Chat.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Chat.Location = new System.Drawing.Point(27, 12);
            this.textBox_Chat.Multiline = true;
            this.textBox_Chat.Name = "textBox_Chat";
            this.textBox_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Chat.Size = new System.Drawing.Size(419, 322);
            this.textBox_Chat.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.textBox_Chat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SendMessage);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Chat;
    }
}

