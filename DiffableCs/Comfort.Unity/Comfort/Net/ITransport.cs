namespace Comfort.Net;

public interface ITransport
{

	public TransportInfo Info
	{
		 get { } //Length: 0
	}

	public bool CheckConnect() { }

	public void Close() { }

	public void Destroy() { }

	public TransportInfo get_Info() { }

	public bool Receive(ref ArraySegment segment, Action callback) { }

	public bool Send(ref ArraySegment segment, Action callback) { }

}

