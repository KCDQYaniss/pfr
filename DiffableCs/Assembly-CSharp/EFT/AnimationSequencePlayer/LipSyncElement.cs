namespace EFT.AnimationSequencePlayer;

public class LipSyncElement
{
	[TextArea]
	public string info; //Field offset: 0x10
	public BakedData bakedData; //Field offset: 0x18
	[Range(0, 2)]
	public float volume; //Field offset: 0x20

	public LipSyncElement() { }

}

