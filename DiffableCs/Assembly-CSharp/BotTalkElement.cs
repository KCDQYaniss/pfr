//Type is in global namespace

public class BotTalkElement
{
	public EPhraseTrigger type; //Field offset: 0x10
	public bool demand; //Field offset: 0x14
	public float delay; //Field offset: 0x18
	public ETagStatus mask; //Field offset: 0x1C

	public BotTalkElement(EPhraseTrigger type, bool demand, float delay, ETagStatus mask) { }

}

