namespace System.Threading.Channels;

public sealed class BoundedChannelOptions : ChannelOptions
{
	private int _capacity; //Field offset: 0x18
	private BoundedChannelFullMode _mode; //Field offset: 0x1C

	public int Capacity
	{
		 get { } //Length: 4
	}

	public BoundedChannelFullMode FullMode
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public BoundedChannelOptions(int capacity) { }

	public int get_Capacity() { }

	public BoundedChannelFullMode get_FullMode() { }

	public void set_FullMode(BoundedChannelFullMode value) { }

}

