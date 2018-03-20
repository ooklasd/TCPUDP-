using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace TCPUDP调试工具
{
    interface InterfaceSendRecv
    {
        void init();
        void start();
        int send(byte[] buffer);
        int recv(ref byte[] buffer);
        void stop();
        EndPoint getRemoteInfo();
        EndPoint getLocalInfo();        
    }


    class UDPSendRecv : InterfaceSendRecv
    {
        ~UDPSendRecv() { stop(); }
        public string ipRemote;
        public int portRemote;
        public int portLocal;
        private Socket socket;
        public IPEndPoint RemoteEndPoint;
        public IPEndPoint LocalEndPoint
        {
            get
            {
                if(socket != null)
                {
                    return (IPEndPoint)socket.LocalEndPoint;
                }
                return null;
            }
        }

        

        public void init()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.ReceiveBufferSize = 10 * 1000 * 1000;
            socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), portLocal));
            RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ipRemote),portRemote);
        }

        public void start()
        {

        }

        public int send(byte[] buffer)
        {
           return socket.SendTo(buffer, RemoteEndPoint);
        }

        public int recv(ref byte[] buffer)
        {
            try
            {
                EndPoint point = RemoteEndPoint;
                if (buffer == null) buffer = new byte[socket.ReceiveBufferSize];
                var recvCount = socket.ReceiveFrom(buffer, ref point);
                RemoteEndPoint = (IPEndPoint)point;
                return recvCount;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void stop()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
           
        }

        public EndPoint getRemoteInfo()
        {
            return RemoteEndPoint;
        }

        public EndPoint getLocalInfo()
        {
            return LocalEndPoint;
        }
    }
}
