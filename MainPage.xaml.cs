using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;


// 빈 페이지 항목 템플릿에 대한 설명은 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x412에 나와 있습니다.

namespace App1
{
    /// <summary>
    /// 자체적으로 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            //var comm = SerialDevice.GetDeviceSelector();
            //Console.WriteLine($"{comm}");
            
            this.InitializeComponent();
            this.textbliock.Text = "Hello World!";
            //combo1.Items.Add("abcdefg");
            combo1.ItemsSource = LoadComboBoxData();




        }

       

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string val = combo1.SelectedValue.ToString();
            this.textbliock.Text = val;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }
        private string[] LoadComboBoxData()
        {
            string[] strArray =
            {
            "Coffie",
            "Tea",
            "Orange Juice",
            "Milk",
            "Mango Shake",
            "Iced Tea",
            "Soda",
            "Water"
            };
            return strArray;
        }
    }
    

}
/*
 using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;

//...   

string selector = SerialDevice.GetDeviceSelector("COM3"); 
DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(selector);
if(devices.Count > 0)
{
    DeviceInformation deviceInfo = devices[0];
    SerialDevice serialDevice = await SerialDevice.FromIdAsync(deviceInfo.Id);
    serialDevice.BaudRate = 9600;
    serialDevice.DataBits = 8;
    serialDevice.StopBits = SerialStopBitCount.Two;
    serialDevice.Parity = SerialParity.None;

    DataWriter dataWriter = new DataWriter(serialDevice.OutputStream);
    dataWriter.WriteString("your message here");
    await dataWriter.StoreAsync();
    dataWriter.DetachStream();
    dataWriter = null;
}
else
{
    MessageDialog popup = new MessageDialog("Sorry, no device found.");
    await popup.ShowAsync();
} 
 
 */
