//Type is in global namespace

public class BotGroupTalk
{
	private float _groupAnyPhraseDelay; //Field offset: 0x10
	private float _groupExactlyPhraseDelay; //Field offset: 0x14
	private readonly Dictionary _nextPossibleTalkTTime; //Field offset: 0x18
	private float _totalNextTime; //Field offset: 0x20

	public BotGroupTalk() { }

	public bool CanSay(BotOwner bot, EPhraseTrigger ePhrase) { }

	public void PhraseSad(BotOwner bot, EPhraseTrigger ePhrase) { }

}

