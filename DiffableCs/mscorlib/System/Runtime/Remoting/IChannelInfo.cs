namespace System.Runtime.Remoting;

[ComVisible(True)]
public interface IChannelInfo
{

	public object[] ChannelData
	{
		 get { } //Length: 0
	}

	public object[] get_ChannelData() { }

}

