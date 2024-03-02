using System;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace TwinCat_ADS_Haberlesme
{
    public partial class Form1 : Form
    {
        //PLC Haberleşmesi için sınıf tanımı
        AdsClient adsClient = new AdsClient();
        uint nNotfiactionHandle = 0;
        private NotificationSettings notificationSettings = new NotificationSettings(
            AdsTransMode.OnChange,   // veya başka bir uygun AdsTransMode değeri
            100,                     // belki bir cycle time değeri
            10                       // belki bir max delay değeri
        );

        public Form1()
        {
            InitializeComponent();
            //Connect iki parametre alıyor,İlki Ads.Net Id's İkinci port PlC twincat 3 projesinde 851
            adsClient.Connect("", 851);

            uint nNotfiactionHandle = adsClient.AddDeviceNotificationEx(
             "Main.nCounter",     // Sembol Yolu
             notificationSettings,                  // Bildirim Ayarları
             null,                                   // Kullanıcı Verisi
             typeof(Int16)                           // Veri Tipi
             );
            adsClient.AdsNotificationEx += AdsClient_AdsNotificationEx;
        }

        private void AdsClient_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.Handle == nNotfiactionHandle)
            {
                textBoxnCounter.Invoke(
                    new Action(() => textBoxnCounter.Text = e.Value.ToString()));

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   //Handle değerini siliyoruz
            adsClient.DeleteDeviceNotification(nNotfiactionHandle);
            //plc'yi kapatıyoruz
            adsClient.Disconnect();

        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            uint nVariableHandle = (uint)adsClient.CreateVariableHandle("Main.fValue");
            double fValue = Convert.ToDouble(adsClient.ReadAny(nVariableHandle, typeof(double)));

            adsClient.DeleteVariableHandle(nNotfiactionHandle);
            textBox_fValue.Text = nVariableHandle.ToString();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            uint nVariableHandle = (uint)adsClient.CreateVariableHandle("Main.fValue");
            double fValue = Convert.ToDouble(textBox_fValue.Text);
            adsClient.WriteAny(nVariableHandle, fValue);
            adsClient.DeleteVariableHandle(nNotfiactionHandle);

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            uint nVariableHandle = (uint)adsClient.CreateVariableHandle("Main.bReset");
            adsClient.WriteAny(nVariableHandle, true);
            adsClient.DeleteVariableHandle(nVariableHandle);
        }
    }
}
