namespace Dissonance;

public interface IChannel`1 : IDisposable
{

	[NotNull]
	public ChannelProperties Properties
	{
		 get { } //Length: 0
	}

	public ushort SubscriptionId
	{
		 get { } //Length: 0
	}

	public T TargetId
	{
		 get { } //Length: 0
	}

	public ChannelProperties get_Properties() { }

	public ushort get_SubscriptionId() { }

	public T get_TargetId() { }

}

