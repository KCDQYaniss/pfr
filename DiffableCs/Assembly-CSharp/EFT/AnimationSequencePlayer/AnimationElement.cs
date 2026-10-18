namespace EFT.AnimationSequencePlayer;

public class AnimationElement
{
	[TextArea]
	public string info; //Field offset: 0x10
	public float minDuration; //Field offset: 0x18
	public string triggerName; //Field offset: 0x20
	public string intName; //Field offset: 0x28
	public int intValue; //Field offset: 0x30
	public string speedName; //Field offset: 0x38
	public string exitTriggerName; //Field offset: 0x40
	public string exitIntName; //Field offset: 0x48
	public int exitIntValue; //Field offset: 0x50
	public float exitTriggerOffset; //Field offset: 0x54
	public GameObject[] props; //Field offset: 0x58
	public float propsStartOffset; //Field offset: 0x60
	public float propsEndOffset; //Field offset: 0x64

	public AnimationElement() { }

}

