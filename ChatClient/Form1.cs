using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        TcpClient? client;
        NetworkStream? stream;
        string kullaniciAdi = "Anonim";

        public Form1()
        {
            InitializeComponent();
            btnGonder.Enabled = false;
            txtMesaj.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    GonderMesaj();
                    e.SuppressKeyPress = true;
                }
            };
        }

        private async void btnBaglan_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text.Trim();
            if (string.IsNullOrEmpty(kullaniciAdi)) kullaniciAdi = "Anonim";

            try
            {
                client = new TcpClient();
                await client.ConnectAsync("127.0.0.1", 5000);
                stream = client.GetStream();

                btnBaglan.Enabled = false;
                btnGonder.Enabled = true;
                txtKullaniciAdi.Enabled = false;

                EkranaYaz("✅ Connected the Server!");
                _ = Task.Run(MesajDinle);
            }
            catch
            {
                MessageBox.Show("Sunucuya bağlanılamadı! Önce ChatServer'ı başlat.", "Hata");
            }
        }

        private async Task MesajDinle()
        {
            var buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int bytesRead = await stream!.ReadAsync(buffer);
                    if (bytesRead == 0) break;
                    string mesaj = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    EkranaYaz(mesaj);
                }
            }
            catch
            {
                EkranaYaz("❌ Connection Disconnect.");
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            GonderMesaj();
        }

        private async void GonderMesaj()
        {
            string mesaj = txtMesaj.Text.Trim();
            if (string.IsNullOrEmpty(mesaj) || stream == null) return;

            string tamMesaj = $"[{kullaniciAdi}]: {mesaj}";
            var data = Encoding.UTF8.GetBytes(tamMesaj);
            await stream.WriteAsync(data);

            EkranaYaz($"[Ben]: {mesaj}");
            txtMesaj.Clear();
        }

        private void EkranaYaz(string mesaj)
        {
            if (rtbChat.InvokeRequired)
                rtbChat.Invoke(() => rtbChat.AppendText(mesaj + "\n"));
            else
                rtbChat.AppendText(mesaj + "\n");
        }

       
    }
}
