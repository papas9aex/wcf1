using Kt10WcfServiceLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uri uri = new Uri("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            //WSHttpBinding binding = new WSHttpBinding(SecurityMode.Message);

            //using (ServiceHost host = new ServiceHost(typeof(Service1), uri))
            //{
            //    host.Open();
            //    Console.WriteLine("Сервис запущен.");
            //    Console.WriteLine("Нажмите Enter для остановки сервиса…");
            //    Console.ReadLine();
            //    string response = host.ToS("Test message");

            //    host.Close();
            //}
            //using (ChannelFactory<ISecureService> factory = new ChannelFactory<ISecureService>(binding, uri))
            //{
            //    // Установка учетных данных
            //    factory.Credentials.UserName.UserName = "username";
            //    factory.Credentials.UserName.Password = "password";

            //    // Создание прокси
            //    ISecureService proxy = factory.CreateChannel();

            //    // Вызов метода службы
            //    string response = proxy.SecureMethod("Test message");

            //    Console.WriteLine("Response from service: " + response);
            //}
            //EndpointAddress address = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/Kt10WcfServiceLibrary2/Service1/mex");

            //// Привязка WsHttpBinding с безопасностью на уровне сообщений
            //WSHttpBinding binding = new WSHttpBinding(SecurityMode.Message);

            //// Создание канала к службе
            //using (ChannelFactory<ISecureService> factory = new ChannelFactory<ISecureService>(binding, address))
            //{
            //    // Установка учетных данных
            //    factory.Credentials.UserName.UserName = "username";
            //    factory.Credentials.UserName.Password = "password";

            //    // Создание прокси
            //    ISecureService proxy = factory.CreateChannel();

            //    // Вызов метода службы
            //    string response = proxy.SecureMethod("Test message");

            //    Console.WriteLine("Response from service: " + response);
            //}
            var binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
            MessageCredentialType.Windows;
            var endpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/Kt10WcfServiceLibrary2/Service1/");
            var channelFactory = new ChannelFactory<ISecureService>(binding, endpoint);

              var proxy = channelFactory.CreateChannel();
              var s =  proxy.SecureMethod("12");
            //proxy.SecureMethod();
            //client.Call Secure Method();
            Console.WriteLine(s);
            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();

        }
    }
}