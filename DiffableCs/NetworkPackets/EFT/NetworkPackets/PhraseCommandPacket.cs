namespace EFT.NetworkPackets;

public struct PhraseCommandPacket
{
	public bool HasPhrase; //Field offset: 0x0
	public int PhraseId; //Field offset: 0x4
	public EPhraseTrigger PhraseCommand; //Field offset: 0x8

}

