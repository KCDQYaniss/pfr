//Type is in global namespace

public class BotTalk : BotData
{
	private const float QUERY_WAIT_TIME = 0.15; //Field offset: 0x0
	private float _nextCanSayTime; //Field offset: 0x18
	private bool _haveSomeThingToSay; //Field offset: 0x1C
	private bool _canSay; //Field offset: 0x1D
	private float _endWaitQueryTime; //Field offset: 0x20
	private BotTalkElement _tryToTalk; //Field offset: 0x28
	private readonly Dictionary _priority; //Field offset: 0x30
	private bool _isSilence; //Field offset: 0x38
	private float _silenceEnds; //Field offset: 0x3C

	public bool IsSilenced
	{
		 get { } //Length: 401
	}

	protected BotTalk(BotOwner owner) { }

	public void Activate() { }

	private void AddToQuery(EPhraseTrigger type, bool demand, float delay, ETagStatus mask) { }

	public override bool CanSayByGroup(EPhraseTrigger type) { }

	public static BotTalk Create(BotOwner owner) { }

	public void DropNextSayPeriod() { }

	private BotTalkElement FindBetter(BotTalkElement data, BotTalkElement tryToTalk) { }

	public bool get_IsSilenced() { }

	private ETagStatus GetMask(Nullable additionaMask = null) { }

	public void ManualUpdate() { }

	private void PriorityInit() { }

	public override void Say(EPhraseTrigger type, bool sayImmediately = false, Nullable additionalMask = null, ETagFilter tagFilter = 0) { }

	private void SayAndDelay(EPhraseTrigger type) { }

	private void SayFromQuery() { }

	public void SetSilence(float period) { }

	public void TrySay(EPhraseTrigger type) { }

	public void TrySay(EPhraseTrigger type, bool withGroupDelay) { }

	public override void TrySay(EPhraseTrigger type, Nullable additionaMask, bool withGroupDelay) { }

}

