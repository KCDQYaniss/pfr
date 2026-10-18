namespace EFT;

public class HostTopology
{
	[SerializeField]
	private ConnectionConfig m_DefConfig; //Field offset: 0x10
	[SerializeField]
	private int m_MaxDefConnections; //Field offset: 0x18
	[SerializeField]
	private List m_SpecialConnections; //Field offset: 0x20
	[SerializeField]
	private ushort m_ReceivedMessagePoolSize; //Field offset: 0x28
	[SerializeField]
	private ushort m_SentMessagePoolSize; //Field offset: 0x2A
	[SerializeField]
	private float m_MessagePoolSizeGrowthFactor; //Field offset: 0x2C

	public ConnectionConfig DefaultConfig
	{
		 get { } //Length: 5
	}

	public int MaxDefaultConnections
	{
		 get { } //Length: 4
	}

	public float MessagePoolSizeGrowthFactor
	{
		 get { } //Length: 6
		 set { } //Length: 128
	}

	public ushort ReceivedMessagePoolSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public ushort SentMessagePoolSize
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public List SpecialConnectionConfigs
	{
		 get { } //Length: 5
	}

	public int SpecialConnectionConfigsCount
	{
		 get { } //Length: 65
	}

	public HostTopology(ConnectionConfig defaultConfig, int maxDefaultConnections) { }

	private HostTopology() { }

	public int AddSpecialConnectionConfig(ConnectionConfig config) { }

	public ConnectionConfig get_DefaultConfig() { }

	public int get_MaxDefaultConnections() { }

	public float get_MessagePoolSizeGrowthFactor() { }

	public ushort get_ReceivedMessagePoolSize() { }

	public ushort get_SentMessagePoolSize() { }

	public List get_SpecialConnectionConfigs() { }

	public int get_SpecialConnectionConfigsCount() { }

	public ConnectionConfig GetSpecialConnectionConfig(int i) { }

	public void set_MessagePoolSizeGrowthFactor(float value) { }

	public void set_ReceivedMessagePoolSize(ushort value) { }

	public void set_SentMessagePoolSize(ushort value) { }

}

