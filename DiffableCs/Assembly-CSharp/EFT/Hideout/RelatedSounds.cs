namespace EFT.Hideout;

public sealed class RelatedSounds
{
	public Dictionary Data; //Field offset: 0x10
	public AudioSequence WorkingSequence; //Field offset: 0x18
	public Dictionary FallbackSounds; //Field offset: 0x20

	public RelatedSounds() { }

	public AudioClip GetSound(EAreaActivityType soundType) { }

	public List GetSounds(EAreaActivityType[] soundTypes) { }

}

