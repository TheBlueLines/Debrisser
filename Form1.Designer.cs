namespace Debrisser
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			fromClient = new ListBox();
			fromClientText = new Label();
			fromServerText = new Label();
			fromServer = new ListBox();
			configText = new Label();
			serverPort = new NumericUpDown();
			serverPortText = new Label();
			startServer = new Button();
			stopServer = new Button();
			clientAddressText = new Label();
			clientPort = new NumericUpDown();
			clientAddress = new TextBox();
			stopClient = new Button();
			startClient = new Button();
			clientPortText = new Label();
			packetLengthText = new Label();
			packetIdText = new Label();
			packetDataText = new Label();
			packetLength = new TextBox();
			packetId = new TextBox();
			packetData = new TextBox();
			((System.ComponentModel.ISupportInitialize)serverPort).BeginInit();
			((System.ComponentModel.ISupportInitialize)clientPort).BeginInit();
			SuspendLayout();
			// 
			// fromClient
			// 
			fromClient.Enabled = false;
			fromClient.FormattingEnabled = true;
			fromClient.ItemHeight = 15;
			fromClient.Location = new Point(12, 42);
			fromClient.Name = "fromClient";
			fromClient.Size = new Size(200, 409);
			fromClient.TabIndex = 9;
			fromClient.SelectedIndexChanged += PacketSelected;
			// 
			// fromClientText
			// 
			fromClientText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			fromClientText.Location = new Point(12, 9);
			fromClientText.Name = "fromClientText";
			fromClientText.Size = new Size(200, 30);
			fromClientText.TabIndex = 1;
			fromClientText.Text = "From Client:";
			fromClientText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// fromServerText
			// 
			fromServerText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			fromServerText.Location = new Point(218, 9);
			fromServerText.Name = "fromServerText";
			fromServerText.Size = new Size(200, 30);
			fromServerText.TabIndex = 2;
			fromServerText.Text = "From Server:";
			fromServerText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// fromServer
			// 
			fromServer.FormattingEnabled = true;
			fromServer.ItemHeight = 15;
			fromServer.Location = new Point(218, 42);
			fromServer.Name = "fromServer";
			fromServer.Size = new Size(200, 409);
			fromServer.TabIndex = 5;
			fromServer.SelectedIndexChanged += PacketSelected;
			// 
			// configText
			// 
			configText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			configText.Location = new Point(424, 9);
			configText.Name = "configText";
			configText.Size = new Size(200, 30);
			configText.TabIndex = 4;
			configText.Text = "Config:";
			configText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// serverPort
			// 
			serverPort.Enabled = false;
			serverPort.Location = new Point(424, 62);
			serverPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			serverPort.Name = "serverPort";
			serverPort.Size = new Size(200, 23);
			serverPort.TabIndex = 0;
			serverPort.Value = new decimal(new int[] { 12345, 0, 0, 0 });
			// 
			// serverPortText
			// 
			serverPortText.Location = new Point(424, 39);
			serverPortText.Name = "serverPortText";
			serverPortText.Size = new Size(200, 20);
			serverPortText.TabIndex = 6;
			serverPortText.Text = "Server port:";
			serverPortText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// startServer
			// 
			startServer.Enabled = false;
			startServer.Location = new Point(424, 91);
			startServer.Name = "startServer";
			startServer.Size = new Size(200, 23);
			startServer.TabIndex = 7;
			startServer.Text = "Start Server";
			startServer.UseVisualStyleBackColor = true;
			startServer.Click += startServer_Click;
			// 
			// stopServer
			// 
			stopServer.Enabled = false;
			stopServer.Location = new Point(424, 120);
			stopServer.Name = "stopServer";
			stopServer.Size = new Size(200, 23);
			stopServer.TabIndex = 8;
			stopServer.Text = "Stop Server";
			stopServer.UseVisualStyleBackColor = true;
			stopServer.Click += stopServer_Click;
			// 
			// clientAddressText
			// 
			clientAddressText.Location = new Point(424, 146);
			clientAddressText.Name = "clientAddressText";
			clientAddressText.Size = new Size(200, 20);
			clientAddressText.TabIndex = 10;
			clientAddressText.Text = "Client address:";
			clientAddressText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// clientPort
			// 
			clientPort.Enabled = false;
			clientPort.Location = new Point(424, 218);
			clientPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			clientPort.Name = "clientPort";
			clientPort.Size = new Size(200, 23);
			clientPort.TabIndex = 11;
			clientPort.Value = new decimal(new int[] { 12345, 0, 0, 0 });
			// 
			// clientAddress
			// 
			clientAddress.Enabled = false;
			clientAddress.Location = new Point(424, 169);
			clientAddress.Name = "clientAddress";
			clientAddress.Size = new Size(200, 23);
			clientAddress.TabIndex = 12;
			clientAddress.Text = "127.0.0.1";
			// 
			// stopClient
			// 
			stopClient.Enabled = false;
			stopClient.Location = new Point(424, 276);
			stopClient.Name = "stopClient";
			stopClient.Size = new Size(200, 23);
			stopClient.TabIndex = 14;
			stopClient.Text = "Stop Client";
			stopClient.UseVisualStyleBackColor = true;
			stopClient.Click += stopClient_Click;
			// 
			// startClient
			// 
			startClient.Enabled = false;
			startClient.Location = new Point(424, 247);
			startClient.Name = "startClient";
			startClient.Size = new Size(200, 23);
			startClient.TabIndex = 13;
			startClient.Text = "Start Client";
			startClient.UseVisualStyleBackColor = true;
			startClient.Click += startClient_Click;
			// 
			// clientPortText
			// 
			clientPortText.Location = new Point(424, 195);
			clientPortText.Name = "clientPortText";
			clientPortText.Size = new Size(200, 20);
			clientPortText.TabIndex = 15;
			clientPortText.Text = "Client port:";
			clientPortText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// packetLengthText
			// 
			packetLengthText.Location = new Point(424, 302);
			packetLengthText.Name = "packetLengthText";
			packetLengthText.Size = new Size(200, 20);
			packetLengthText.TabIndex = 16;
			packetLengthText.Text = "Packet Length:";
			packetLengthText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// packetIdText
			// 
			packetIdText.Location = new Point(424, 351);
			packetIdText.Name = "packetIdText";
			packetIdText.Size = new Size(200, 20);
			packetIdText.TabIndex = 17;
			packetIdText.Text = "Packet ID:";
			packetIdText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// packetDataText
			// 
			packetDataText.Location = new Point(424, 400);
			packetDataText.Name = "packetDataText";
			packetDataText.Size = new Size(200, 20);
			packetDataText.TabIndex = 18;
			packetDataText.Text = "Packet UTF8:";
			packetDataText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// packetLength
			// 
			packetLength.Enabled = false;
			packetLength.Location = new Point(424, 325);
			packetLength.Name = "packetLength";
			packetLength.ReadOnly = true;
			packetLength.Size = new Size(200, 23);
			packetLength.TabIndex = 19;
			// 
			// packetId
			// 
			packetId.Enabled = false;
			packetId.Location = new Point(424, 374);
			packetId.Name = "packetId";
			packetId.ReadOnly = true;
			packetId.Size = new Size(200, 23);
			packetId.TabIndex = 20;
			// 
			// packetData
			// 
			packetData.Enabled = false;
			packetData.Location = new Point(424, 423);
			packetData.Name = "packetData";
			packetData.ReadOnly = true;
			packetData.Size = new Size(200, 23);
			packetData.TabIndex = 21;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(636, 461);
			Controls.Add(packetData);
			Controls.Add(packetId);
			Controls.Add(packetLength);
			Controls.Add(packetDataText);
			Controls.Add(packetIdText);
			Controls.Add(packetLengthText);
			Controls.Add(clientPortText);
			Controls.Add(stopClient);
			Controls.Add(startClient);
			Controls.Add(clientAddress);
			Controls.Add(clientPort);
			Controls.Add(clientAddressText);
			Controls.Add(stopServer);
			Controls.Add(startServer);
			Controls.Add(serverPortText);
			Controls.Add(serverPort);
			Controls.Add(configText);
			Controls.Add(fromServer);
			Controls.Add(fromServerText);
			Controls.Add(fromClientText);
			Controls.Add(fromClient);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "Debrisser";
			FormClosing += Form1_FormClosing;
			((System.ComponentModel.ISupportInitialize)serverPort).EndInit();
			((System.ComponentModel.ISupportInitialize)clientPort).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public ListBox fromClient;
		private Label fromClientText;
		private Label fromServerText;
		public ListBox fromServer;
		private Label configText;
		private NumericUpDown serverPort;
		private Label serverPortText;
		private Button startServer;
		private Button stopServer;
		private Label clientAddressText;
		private NumericUpDown clientPort;
		private TextBox clientAddress;
		private Button stopClient;
		private Button startClient;
		private Label clientPortText;
		private Label packetLengthText;
		private Label packetIdText;
		private Label packetDataText;
		private TextBox packetLength;
		private TextBox packetId;
		private TextBox packetData;
	}
}
