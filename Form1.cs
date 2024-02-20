using System.Net.Sockets;
using System.Text;
using TTMC.Debris;

namespace Debrisser
{
	public partial class Form1 : Form
	{
		public List<NetworkStream> streams = new();
		public List<Packet> clientPackets = new();
		public List<Packet> serverPackets = new();
		public ClientHanlde? clientHandler = null;
		public ServerHanlde? serverHanlde = null;
		public Client? client = null;
		public Server? server = null;
		public Form1()
		{
			InitializeComponent();
			serverPort.Enabled = true;
			startServer.Enabled = true;
			clientPort.Enabled = true;
			clientAddress.Enabled = true;
			startClient.Enabled = true;
		}
		private void startServer_Click(object sender, EventArgs e)
		{
			SwitchServer(true);
		}
		private void startClient_Click(object sender, EventArgs e)
		{
			SwitchClient(true);
		}
		private void stopServer_Click(object sender, EventArgs e)
		{
			SwitchServer(false);
		}
		private void stopClient_Click(object sender, EventArgs e)
		{
			SwitchClient(false);
		}
		private void SwitchServer(bool mode = true)
		{
			startServer.Enabled = !mode;
			serverPort.Enabled = !mode;
			stopServer.Enabled = mode;
			fromClient.Enabled = mode;
			if (!mode && server != null)
			{
				server.StopServer();
			}
			else
			{
				fromClient.Items.Clear();
			}
			serverHanlde = mode ? new(this) : null;
			server = mode ? new Server((ushort)serverPort.Value, serverHanlde) : null;
		}
		private void SwitchClient(bool mode = true)
		{
			startClient.Enabled = !mode;
			clientAddress.Enabled = !mode;
			clientPort.Enabled = !mode;
			stopClient.Enabled = mode;
			fromServer.Enabled = mode;
			if (!mode && client != null)
			{
				client.Disconnect();
			}
			else
			{
				fromServer.Items.Clear();
			}
			clientHandler = mode ? new(this) : null;
			client = mode ? new Client(clientAddress.Text, (ushort)clientPort.Value, clientHandler) : null;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SwitchClient(false);
			SwitchServer(false);
		}

		private void PacketSelected(object sender, EventArgs e)
		{
			ListBox listBox = (ListBox)sender;
			int index = listBox.SelectedIndex;
			bool mode = index >= 0;
			packetLength.Enabled = mode;
			packetId.Enabled = mode;
			packetData.Enabled = mode;
			if (mode)
			{
				Packet packet = new();
				if (listBox == fromClient)
				{
					packet = serverPackets[index];
				}
				else if (listBox == fromServer)
				{
					packet = clientPackets[index];
				}
				packetLength.Text = packet.length.ToString();
				packetId.Text = packet.id.ToString();
				packetData.Text = Encoding.UTF8.GetString(packet.data);
			}
			else
			{
				packetLength.Text = string.Empty;
				packetId.Text = string.Empty;
				packetData.Text = string.Empty;
			}
		}
	}
	public class ClientHanlde : Handle
	{
		private Form1 form;
		public ClientHanlde(Form1 form)
		{
			this.form = form;
		}
		public override Packet? Message(Packet packet, NetworkStream stream)
		{
			form.clientPackets.Add(packet);
			form.fromServer.Items.Add($"({packet.length}) {packet.id}");
			form.fromServer.Refresh();
			foreach (NetworkStream networkStream in form.streams)
			{
				try
				{
					Packet.SendPacket(networkStream, packet);
				}
				catch
				{
					form.streams.Remove(networkStream);
				}
			}
			return null;
		}
	}
	public class ServerHanlde : Handle
	{
		private Form1 form;
		public ServerHanlde(Form1 form)
		{
			this.form = form;
		}
		public override Packet? Message(Packet packet, NetworkStream stream)
		{
			if (!form.streams.Contains(stream))
			{
				form.streams.Add(stream);
			}
			form.serverPackets.Add(packet);
			form.fromClient.Items.Add($"({packet.length}) {packet.id}");
			form.fromClient.Refresh();
			if (form.client != null)
			{
				form.client.SendPacket(packet);
			}
			return null;
		}
	}
}