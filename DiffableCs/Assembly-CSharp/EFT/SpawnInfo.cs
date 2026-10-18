namespace EFT;

public sealed class SpawnInfo
{
	public string ProfileId; //Field offset: 0x10
	public long ConnectionId; //Field offset: 0x18
	public string Side; //Field offset: 0x20
	public float PastTime; //Field offset: 0x28
	public int Connects; //Field offset: 0x2C
	public int Disconnects; //Field offset: 0x30

	public SpawnInfo() { }

}

