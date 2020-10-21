﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Net.Sockets;
using static Utils.IObserver;
using System.IO;

namespace ServerApp
{
    class Server:Observable
    {
        private int latestSessionID = 0;

        public void StartServer()
        {
            if (!File.Exists(Application.StartupPath + "\\SGBD.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create("SGBD.xml"))
                {
                    writer.WriteStartElement("Databases");
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }

            var serverListener = new TcpListener(IPAddress.Parse(TCPConfigs.IP), TCPConfigs.Port);
            serverListener.Start();

            Console.WriteLine("Server session started....");

            while (true)
            {
                var tcpClient = serverListener.AcceptTcpClient();
                Task.Factory.StartNew(() =>
                {
                    latestSessionID++;
                    var clientSession = new Session(latestSessionID, tcpClient);
                    Console.WriteLine("Client connected with ID: " + latestSessionID);
                    Subscribe(clientSession);

                    while (true)
                    {
                        try
                        {
                            var clientRequest = clientSession.Read();
                            clientSession.DisplayClientRequest(clientRequest);
                            var response = clientSession.HandleClientRequest(clientRequest);
                            clientSession.Write(response);
                        }
                        catch (Exception)
                        {
                            break; // todo: error handling calume 
                        }
                    }
                    Console.WriteLine("Client disconnected with ID: " + clientSession.getSessionID());
                    latestSessionID--;
                    Unsubscribe(clientSession);
                    tcpClient.Close();

                });

            }
            serverListener.Stop();
        }
    }
}
