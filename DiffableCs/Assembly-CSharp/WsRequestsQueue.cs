//Type is in global namespace

public sealed class WsRequestsQueue
{
	private readonly List _requests; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 65
	}

	public WsRequestsQueue() { }

	public WsRequest Dequeue() { }

	public void Enqueue(WsRequest newReq) { }

	public void FinishTimedOutRequests() { }

	public int get_Count() { }

}

