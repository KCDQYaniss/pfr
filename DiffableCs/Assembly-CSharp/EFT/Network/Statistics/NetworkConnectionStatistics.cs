namespace EFT.Network.Statistics;

public struct NetworkConnectionStatistics
{
	public float Rtt; //Field offset: 0x0
	public float Lose; //Field offset: 0x4
	public int Disordered; //Field offset: 0x8
	public int Duplicated; //Field offset: 0xC
	public float ReliableReceivedAverage; //Field offset: 0x10
	public float ReliableSentAverage; //Field offset: 0x14
	public float UnreliableReceivedAverage; //Field offset: 0x18
	public float UnreliableSentAverage; //Field offset: 0x1C
	public float ReceivedAverage; //Field offset: 0x20
	public float SentAverage; //Field offset: 0x24
	public int ReceivedTotal; //Field offset: 0x28
	public int SentTotal; //Field offset: 0x2C

}

