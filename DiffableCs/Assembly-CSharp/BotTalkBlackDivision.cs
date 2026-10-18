//Type is in global namespace

public class BotTalkBlackDivision : BotTalk
{
	private Dictionary _blocksUntil; //Field offset: 0x40
	private float MIN_DELAY; //Field offset: 0x48
	private float MAX_DELAY; //Field offset: 0x4C

	protected private BotTalkBlackDivision(BotOwner owner) { }

	private bool CanSay(EPhraseTrigger type) { }

	public virtual bool CanSayByGroup(EPhraseTrigger type) { }

	private float GetDelay() { }

	public virtual void Say(EPhraseTrigger type, bool sayImmediately = false, Nullable additionalMask = null, ETagFilter tagFilter = 0) { }

	public void SomeBodySay(EPhraseTrigger trg) { }

	public virtual void TrySay(EPhraseTrigger type, Nullable additionaMask, bool withGroupDelay) { }

}

