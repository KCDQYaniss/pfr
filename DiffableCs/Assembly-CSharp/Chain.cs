//Type is in global namespace

public class Chain
{
	internal enum ESpeaker
	{
		Self = 0,
		Group = 1,
		Other = 2,
	}

	public EPhraseTrigger Event; //Field offset: 0x10
	public int Probability; //Field offset: 0x14
	public ESpeaker Who; //Field offset: 0x18

	public Chain() { }

}

