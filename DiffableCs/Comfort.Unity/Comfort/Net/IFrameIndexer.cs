namespace Comfort.Net;

public interface IFrameIndexer
{

	public ulong EstimatedRemoteIndex
	{
		 get { } //Length: 0
	}

	public ulong LocalIndex
	{
		 get { } //Length: 0
	}

	public ulong RemoteIndex
	{
		 get { } //Length: 0
	}

	public ulong get_EstimatedRemoteIndex() { }

	public ulong get_LocalIndex() { }

	public ulong get_RemoteIndex() { }

}

