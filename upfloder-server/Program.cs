using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace upfloder_server
{
    internal class Program
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxwyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("https://github.com/mg-token");


            int port =8090;
            try
            {
                
                 port = int.Parse(args[0]);
            }
            catch (Exception ex)
            {
                if (args.Length > 0)
                {
                    Console.WriteLine(ex.Message);
                    exit();
                    return;
                }
            }
            UdpClient udpServer = new UdpClient(port);
            long byt = 0;
            // int cls = 0;
            new Thread(() => { 
            while (true)
            {
                try
                {

              

                var remoteEP = new IPEndPoint(IPAddress.Any, port);
                var data = udpServer.Receive(ref remoteEP); // listen on port 8090 or...
                byt += data.Length;
                //cls++;
                //if (cls == 100)
                //{
                //    cls = 0;
                //    Console.Clear();
                //}
               // Console.WriteLine($"ip: {remoteEP.Address.ToString()} len: {data.Length}");
                udpServer.Send(new byte[] { 1 }, 1, remoteEP);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            })
            { IsBackground = true }.Start();
            while (true)
            {
                Console.Title = $"UPFloder By MG (Received: {SizeSuffix(byt)})";
                Thread.Sleep(150);
            }


        }
        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }
        static void exit()
        {
            Console.WriteLine("please enter ip and port at args...");
            Console.ReadKey();
        }

    }
}
