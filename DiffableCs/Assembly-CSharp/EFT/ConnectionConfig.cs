namespace EFT;

public class ConnectionConfig
{
	private const int g_MinPacketSize = 128; //Field offset: 0x0
	[SerializeField]
	private ushort m_PacketSize; //Field offset: 0x10
	[SerializeField]
	private ushort m_FragmentSize; //Field offset: 0x12
	[SerializeField]
	private uint m_ResendTimeout; //Field offset: 0x14
	[SerializeField]
	private uint m_DisconnectTimeout; //Field offset: 0x18
	[SerializeField]
	private uint m_ConnectTimeout; //Field offset: 0x1C
	[SerializeField]
	private uint m_MinUpdateTimeout; //Field offset: 0x20
	[SerializeField]
	private uint m_PingTimeout; //Field offset: 0x24
	[SerializeField]
	private uint m_ReducedPingTimeout; //Field offset: 0x28
	[SerializeField]
	private uint m_AllCostTimeout; //Field offset: 0x2C
	[SerializeField]
	private byte m_NetworkDropThreshold; //Field offset: 0x30
	[SerializeField]
	private byte m_OverflowDropThreshold; //Field offset: 0x31
	[SerializeField]
	private byte m_MaxConnectionAttempt; //Field offset: 0x32
	[SerializeField]
	private uint m_AckDelay; //Field offset: 0x34
	[SerializeField]
	private uint m_SendDelay; //Field offset: 0x38
	[SerializeField]
	private ushort m_MaxCombinedReliableMessageSize; //Field offset: 0x3C
	[SerializeField]
	private ushort m_MaxCombinedReliableMessageCount; //Field offset: 0x3E
	[SerializeField]
	private ushort m_MaxSentMessageQueueSize; //Field offset: 0x40
	[SerializeField]
	private ConnectionAcksType m_AcksType; //Field offset: 0x44
	[SerializeField]
	private bool m_UsePlatformSpecificProtocols; //Field offset: 0x48
	[SerializeField]
	private uint m_InitialBandwidth; //Field offset: 0x4C
	[SerializeField]
	private float m_BandwidthPeakFactor; //Field offset: 0x50
	[SerializeField]
	private ushort m_WebSocketReceiveBufferMaxSize; //Field offset: 0x54
	[SerializeField]
	private uint m_UdpSocketReceiveBufferMaxSize; //Field offset: 0x58
	[SerializeField]
	private string m_SSLCertFilePath; //Field offset: 0x60
	[SerializeField]
	private string m_SSLPrivateKeyFilePath; //Field offset: 0x68
	[SerializeField]
	private string m_SSLCAFilePath; //Field offset: 0x70
	[SerializeField]
	internal List m_Channels; //Field offset: 0x78
	[SerializeField]
	internal List m_SharedOrderChannels; //Field offset: 0x80

	public uint AckDelay
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ConnectionAcksType AcksType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public uint AllCostTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float BandwidthPeakFactor
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public int ChannelCount
	{
		 get { } //Length: 65
	}

	public List Channels
	{
		 get { } //Length: 5
	}

	public uint ConnectTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public uint DisconnectTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ushort FragmentSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public uint InitialBandwidth
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[Obsolete("IsAcksLong is deprecated. Use AcksType = ConnectionAcksType.Acks64", False)]
	public bool IsAcksLong
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public ushort MaxCombinedReliableMessageCount
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public ushort MaxCombinedReliableMessageSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public byte MaxConnectionAttempt
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ushort MaxSentMessageQueueSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public uint MinUpdateTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public byte NetworkDropThreshold
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public byte OverflowDropThreshold
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ushort PacketSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public uint PingTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public uint ReducedPingTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public uint ResendTimeout
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public uint SendDelay
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int SharedOrderChannelCount
	{
		 get { } //Length: 68
	}

	public string SSLCAFilePath
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public string SSLCertFilePath
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public string SSLPrivateKeyFilePath
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public uint UdpSocketReceiveBufferMaxSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool UsePlatformSpecificProtocols
	{
		 get { } //Length: 5
		 set { } //Length: 237
	}

	public ushort WebSocketReceiveBufferMaxSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public ConnectionConfig() { }

	public ConnectionConfig(ConnectionConfig config) { }

	public byte AddChannel(QosType value) { }

	public uint get_AckDelay() { }

	public ConnectionAcksType get_AcksType() { }

	public uint get_AllCostTimeout() { }

	public float get_BandwidthPeakFactor() { }

	public int get_ChannelCount() { }

	public List get_Channels() { }

	public uint get_ConnectTimeout() { }

	public uint get_DisconnectTimeout() { }

	public ushort get_FragmentSize() { }

	public uint get_InitialBandwidth() { }

	public bool get_IsAcksLong() { }

	public ushort get_MaxCombinedReliableMessageCount() { }

	public ushort get_MaxCombinedReliableMessageSize() { }

	public byte get_MaxConnectionAttempt() { }

	public ushort get_MaxSentMessageQueueSize() { }

	public uint get_MinUpdateTimeout() { }

	public byte get_NetworkDropThreshold() { }

	public byte get_OverflowDropThreshold() { }

	public ushort get_PacketSize() { }

	public uint get_PingTimeout() { }

	public uint get_ReducedPingTimeout() { }

	public uint get_ResendTimeout() { }

	public uint get_SendDelay() { }

	public int get_SharedOrderChannelCount() { }

	public string get_SSLCAFilePath() { }

	public string get_SSLCertFilePath() { }

	public string get_SSLPrivateKeyFilePath() { }

	public uint get_UdpSocketReceiveBufferMaxSize() { }

	public bool get_UsePlatformSpecificProtocols() { }

	public ushort get_WebSocketReceiveBufferMaxSize() { }

	public QosType GetChannel(byte idx) { }

	public IList GetSharedOrderChannels(byte idx) { }

	public void MakeChannelsSharedOrder(List channelIndices) { }

	public void set_AckDelay(uint value) { }

	public void set_AcksType(ConnectionAcksType value) { }

	public void set_AllCostTimeout(uint value) { }

	public void set_BandwidthPeakFactor(float value) { }

	public void set_ConnectTimeout(uint value) { }

	public void set_DisconnectTimeout(uint value) { }

	public void set_FragmentSize(ushort value) { }

	public void set_InitialBandwidth(uint value) { }

	public void set_IsAcksLong(bool value) { }

	public void set_MaxCombinedReliableMessageCount(ushort value) { }

	public void set_MaxCombinedReliableMessageSize(ushort value) { }

	public void set_MaxConnectionAttempt(byte value) { }

	public void set_MaxSentMessageQueueSize(ushort value) { }

	public void set_MinUpdateTimeout(uint value) { }

	public void set_NetworkDropThreshold(byte value) { }

	public void set_OverflowDropThreshold(byte value) { }

	public void set_PacketSize(ushort value) { }

	public void set_PingTimeout(uint value) { }

	public void set_ReducedPingTimeout(uint value) { }

	public void set_ResendTimeout(uint value) { }

	public void set_SendDelay(uint value) { }

	public void set_SSLCAFilePath(string value) { }

	public void set_SSLCertFilePath(string value) { }

	public void set_SSLPrivateKeyFilePath(string value) { }

	public void set_UdpSocketReceiveBufferMaxSize(uint value) { }

	public void set_UsePlatformSpecificProtocols(bool value) { }

	public void set_WebSocketReceiveBufferMaxSize(ushort value) { }

	public static void Validate(ConnectionConfig config) { }

}

