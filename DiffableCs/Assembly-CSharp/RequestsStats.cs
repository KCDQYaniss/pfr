//Type is in global namespace

public class RequestsStats
{
	public int RequestsRecieved; //Field offset: 0x10
	public int AcceptedFromAI; //Field offset: 0x14
	public int AcceptedFromPlayer; //Field offset: 0x18
	public int ComletedByPlayer; //Field offset: 0x1C
	public int ComletedByAI; //Field offset: 0x20
	public bool DieDoingRequest; //Field offset: 0x24

	public RequestsStats() { }

}

