

namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGonder = new Button();
            btnBaglan = new Button();
            txtMesaj = new TextBox();
            txtKullaniciAdi = new TextBox();
            rtbChat = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGonder);
            panel1.Controls.Add(btnBaglan);
            panel1.Controls.Add(txtMesaj);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 0;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(667, 41);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(94, 29);
            btnGonder.TabIndex = 3;
            btnGonder.Text = "Send";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // btnBaglan
            // 
            btnBaglan.BackColor = SystemColors.Control;
            btnBaglan.ForeColor = SystemColors.ControlText;
            btnBaglan.Location = new Point(667, 4);
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(94, 29);
            btnBaglan.TabIndex = 2;
            btnBaglan.Text = "Connect";
            btnBaglan.UseVisualStyleBackColor = false;
            btnBaglan.Click += btnBaglan_Click;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(12, 41);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.PlaceholderText = "Write A Message";
            txtMesaj.Size = new Size(638, 27);
            txtMesaj.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(12, 6);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Your Name";
            txtKullaniciAdi.Size = new Size(638, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = SystemColors.ActiveCaptionText;
            rtbChat.Dock = DockStyle.Fill;
            rtbChat.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbChat.ForeColor = Color.WhiteSmoke;
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(800, 370);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbChat);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnBaglan_Click_1Async(object sender, EventArgs e)
        {
            
        }

        private void SuspendLayout()
        {
            
        }

        #endregion

        private Panel panel1;
        private Button btnGonder;
        private Button btnBaglan;
        private TextBox txtMesaj;
        private TextBox txtKullaniciAdi;
        private RichTextBox rtbChat;
    }
}
