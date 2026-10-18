namespace System.Runtime.Remoting;

internal class ChannelInfo : IChannelInfo
{
	private object[] channelData; //Field offset: 0x10

	public override object[] ChannelData
	{
		 get { } //Length: 5
	}

	public ChannelInfo() { }

	public ChannelInfo(object remoteChannelData) { }

	public override object[] get_ChannelData() { }

}

