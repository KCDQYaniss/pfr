namespace EFT;

public class ChannelQOS
{
	[SerializeField]
	internal QosType m_Type; //Field offset: 0x10
	[SerializeField]
	internal bool m_BelongsSharedOrderChannel; //Field offset: 0x14

	public bool BelongsToSharedOrderChannel
	{
		 get { } //Length: 5
	}

	public QosType QOS
	{
		 get { } //Length: 164
	}

	public ChannelQOS(QosType value) { }

	public ChannelQOS() { }

	public ChannelQOS(ChannelQOS channel) { }

	public bool get_BelongsToSharedOrderChannel() { }

	public QosType get_QOS() { }

}

