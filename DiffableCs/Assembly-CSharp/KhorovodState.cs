//Type is in global namespace

public class KhorovodState
{
	public float RotationVelocity; //Field offset: 0x10
	public float BotsVelocity; //Field offset: 0x14
	public float Radius; //Field offset: 0x18
	public EInteraction Gesture; //Field offset: 0x1C
	public EPhraseTrigger Phrase; //Field offset: 0x20
	public int speakersLimit; //Field offset: 0x24
	public bool HaveGesture; //Field offset: 0x28
	public bool RandomGesture; //Field offset: 0x29
	public bool HavePhrase; //Field offset: 0x2A
	public bool RandomPhrase; //Field offset: 0x2B
	public bool ForcedAutomaticFireMode; //Field offset: 0x2C
	public bool Shooting; //Field offset: 0x2D
	public float LookHeight; //Field offset: 0x30
	public bool skip; //Field offset: 0x34
	public float StateDuration; //Field offset: 0x38

	public KhorovodState() { }

}

