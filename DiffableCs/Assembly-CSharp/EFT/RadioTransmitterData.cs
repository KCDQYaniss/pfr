namespace EFT;

public struct RadioTransmitterData
{
	public string PlayerProfileIDForSend; //Field offset: 0x0
	public int PlayerID; //Field offset: 0x8
	public bool IsEncoded; //Field offset: 0xC
	public RadioTransmitterStatus Status; //Field offset: 0x10
	public bool IsAgressor; //Field offset: 0x14

}

