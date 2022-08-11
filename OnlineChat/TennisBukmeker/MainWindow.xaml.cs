using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wcf_chat;
using TennisBukmeker.ServiceChatt;

namespace TennisBukmeker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ServiceChatt.IServiceChatCallback
    {
        public bool isConnected = false;
        ServiceChatt.ServiceChatClient client;
        int ID;

        public MainWindow()
        {
            InitializeComponent();

        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(txtBoxInputName.Text);
                txtBoxInputName.IsEnabled = false;
                isConnected = true;
                txtConnect.Text = "connect";
            }
        }

        void DisconectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                txtBoxInputName.IsEnabled = true;
                isConnected = false;
                txtConnect.Text = "disconect";
            }
        }

        private void TextBox_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void Button_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void btnClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DisconectUser();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(messageInput.Text))
            {
                
            }
            else
            {
                if (checkBoxName.IsChecked == true && String.IsNullOrEmpty(txtBoxInputName.Text) != true)
                {
                    client.SendMessage(messageInput.Text, ID);
                    //TextBlock txtBoxMessage = new TextBlock();
                    //txtBoxMessage.Name = "txt";
                    ////txtBoxMessage.Text = txtBoxInputName.Text + ": " + messageInput.Text;
                    //txtBoxMessage.FontSize = 16;
                    //listBox.Items.Add(txtBoxMessage);
                    //messageStackPanel.Children.Add(txtBoxMessage);
                    messageInput.Clear();
                    
                }
                    
            }
            
        }

        private void checkBoxName_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void checkBoxName_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                DisconectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        public void MessageCallback(string message)
        {
            listBox.Items.Add(message);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
