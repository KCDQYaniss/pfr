namespace EFT;

public sealed class TrafficData
{
	public TrafficState GameSent; //Field offset: 0x10
	public TrafficState GameReceived; //Field offset: 0x1C
	public TrafficState VoipSent; //Field offset: 0x28
	public TrafficState VoipReceived; //Field offset: 0x34

	public TrafficData() { }

}

