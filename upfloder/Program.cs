using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace upfloder
{
    internal class Program
    {
        private static Random random = new Random();

        static byte[] GetByteArray(int sizeInKb)
        {
            Random rnd = new Random();
            byte[] b = new byte[sizeInKb]; // convert kb to byte
            rnd.NextBytes(b);
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("https://github.com/mg-token");

            string ip = "127.0.0.1";
            int port = 8090;
            long num = 1;
            int th = 1;
            try
            {
                ip = args[0];
                port = int.Parse(args[1]);
                num = long.Parse(args[2]);
                th = int.Parse(args[3]);

            }
            catch (Exception ex)
            {
                if (args.Length > 3)
                {
                    Console.WriteLine(ex.Message);
                    exit();
                    return;
                }
            }
            UdpClient udp = new UdpClient(ip, port);
            long byt = 0;
            long n2 = num * 1024 * 1024;
            var remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);
            udp.Connect(remoteEP);
            udp.Client.ReceiveTimeout = 1;
            for (int i = 0; i < th; i++)
            {
                new Thread(() =>
                {
                    if (n2 < 1)
                    {
                        while (true)
                        {
                            var strb = GetByteArray(random.Next(60000, 65000));

                            try
                            {
                                var t = udp.Send(strb, strb.Length);


                                var receivedData = udp.Receive(ref remoteEP);
                                if (receivedData.Length == 1)
                                    if (receivedData[0] == 1)
                                        byt += t;
                            }
                            catch
                            {


                            }
                            Thread.Sleep(1);
                        }
                    }
                    else
                    while (byt < n2)
                    {
                        var strb = GetByteArray(random.Next(60000, 65000));

                        try
                        {
                            var t = udp.Send(strb, strb.Length);


                            var receivedData = udp.Receive(ref remoteEP);
                            if (receivedData.Length == 1)
                                if (receivedData[0] == 1)
                                    byt += t;
                        }
                        catch
                        {


                        }
                        Thread.Sleep(1);
                    }
                })
                { IsBackground = true }.Start();
            }
            if (n2 <1)
                while (true)
                {
                    Console.Title = $"UPFloder By MG (Sended: {SizeSuffix(byt)})";
                    Thread.Sleep(125);

                }
            else
            while (byt < n2)
            {
                Console.Title = $"UPFloder By MG (Sended: {SizeSuffix(byt)})";
                Thread.Sleep(125);

            }

            GC.Collect();
            Console.Title = $"UPFloder By MG (Sended: {SizeSuffix(byt)})";
            Console.WriteLine($"Sended {SizeSuffix(byt)} to {ip}");
            Console.ReadKey();

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