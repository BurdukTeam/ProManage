using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;   //for serialization
using System.Net;
using System.Net.Sockets;
using System.IO;




namespace ProManage
{
    public partial class ServerForm : Form
    {
        private TcpClient client;
        TcpListener listen;
        public StreamReader SR;
        public StreamWriter SW;
        public string reciveMsg;
        public String MSGtoSND;
        NetworkStream NSR;
        byte[] b;
        byte[] b2;
        bool ServerIsOn = false;


        
        public ServerForm()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());          //get my ip
            foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily==AddressFamily.InterNetwork)
                {
                    textSIP.Text = address.ToString();
                }
               
            }
        }

       

        private void StartServer(object sender, EventArgs e)            //Start server
        {
            ServerIsOn = true;
            SocketPermission permission = new SocketPermission(NetworkAccess.Accept, TransportType.Tcp, "", int.Parse(textSPort.Text));
            this.listen = new TcpListener(IPAddress.Any, int.Parse(textSPort.Text));
            this.listen.Start();
            
            client = listen.AcceptTcpClient();
            textBoxLog.AppendText(" >> the client connected" + "\n");
            
           backgroundWorker1.RunWorkerAsync();                          //start receiving data
           backgroundWorker1.WorkerSupportsCancellation = true;         //for the ability to cancel the thread
           backgroundWorker2.WorkerSupportsCancellation = true;         //for the ability to cancel the thread

            
        }

        private void StopServer(object sender, EventArgs e)        // botton to stop the server
        {
            this.ServerIsOn = false;
            this.listen.Stop();
            NSR.Close();
            backgroundWorker1.CancelAsync();
        }


        private void Send(object sender, System.ComponentModel.DoWorkEventArgs e)       //send data
        {
            if (client.Connected)
            {


                b2 = ObjectToByteArray(MSGtoSND);
                this.NSR.Write(b2, 0, b2.Length);
                this.NSR.Flush();
                this.textBoxLog.Invoke(new MethodInvoker(delegate() { textBoxLog.AppendText("me: " + MSGtoSND + "\n"); }));
            }
            else
            {
                //MessageBox.Show("send failed!");
                textBoxLog.AppendText("send failed!/n");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Recieve(object sender, System.ComponentModel.DoWorkEventArgs e)       //receive data
        {
            while (this.ServerIsOn)
            {
                while (client.Connected)
                {
                    try
                    {
                        
                        this.NSR = client.GetStream();
                        b = new byte[client.ReceiveBufferSize];
                        this.NSR.Read(b, 0, client.ReceiveBufferSize);
                        reciveMsg = (string)ByteArrayToObject(b);

                        this.textBoxLog.Invoke(new MethodInvoker(delegate() { textBoxLog.AppendText("friend: " + reciveMsg + "\n"); }));

                    }
                    catch (Exception EX)
                    {
                        textBoxLog.AppendText(EX.Message.ToString() + "\n");
                        if ((!client.Connected)&&(this.ServerIsOn))
                        {
                            textBoxLog.AppendText(" >> the client disconnected" + "\n");
                            client = listen.AcceptTcpClient();
                            textBoxLog.AppendText(" >> the client connected" + "\n");
                        }
                       
                    }
                }
                
            }
           
            
        }

       

        
        #region test

        /*
        private void Recieve(object sender, System.ComponentModel.DoWorkEventArgs e)       //test receive data
        {
            while (this.ServerIsOn)
            {
                while (client.Connected)
                {
                    try
                    {
                        
                        this.NSR = client.GetStream();
                        b = new byte[client.ReceiveBufferSize];
                        this.NSR.Read(b, 0, client.ReceiveBufferSize);
                        reciveMsg = (string)ByteArrayToObject(b);

                        this.textBoxLog.Invoke(new MethodInvoker(delegate() { textBoxLog.AppendText("friend: " + reciveMsg + "\n"); }));

                    }
                    catch (Exception EX)
                    {
                        textBoxLog.AppendText(EX.Message.ToString() + "\n");
                        if ((!client.Connected)&&(this.ServerIsOn))
                        {
                            textBoxLog.AppendText(" >> the client disconnected" + "\n");
                            client = listen.AcceptTcpClient();
                            textBoxLog.AppendText(" >> the client connected" + "\n");
                        }
                       
                    }
                }
                
            }
           
            
        }

        private void Send(object sender, System.ComponentModel.DoWorkEventArgs e)       //test send data
        {
            if(client.Connected)
            {
                
                
                b2 = ObjectToByteArray(MSGtoSND);
                this.NSR.Write(b2, 0, b2.Length);
                this.NSR.Flush();
                this.textBoxLog.Invoke(new MethodInvoker(delegate() { textBoxLog.AppendText("me: " + MSGtoSND + "\n"); }));
            }
            else
            {
                MessageBox.Show("send failed!");
            }
            backgroundWorker2.CancelAsync();
        }
        */

        
        private void btnSend_Click(object sender, EventArgs e)      //for testing
        {
            if(textBox2.Text != "")
            {
                MSGtoSND = textBox2.Text;
                backgroundWorker2.RunWorkerAsync();
                textBox2.Text = "";

            }

        }
        


        private static Object ByteArrayToObject(byte[] arrBytes)        // for testing
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
        private static byte[] ObjectToByteArray(Object obj)     // for testing
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        #endregion


        
    }

}
