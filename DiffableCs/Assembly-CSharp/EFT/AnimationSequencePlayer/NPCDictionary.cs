namespace EFT.AnimationSequencePlayer;

public sealed class NPCDictionary
{
	public string traderId; //Field offset: 0x10
	public List animations; //Field offset: 0x18
	public List secondaryAnimations; //Field offset: 0x20
	public List lipsyncs; //Field offset: 0x28

	public NPCDictionary() { }

}

