//Type is in global namespace

public class BotReceiver : BotData
{
	private const float BIG_SDIST = 10000; //Field offset: 0x0
	private const float DELAY_FollowMe = 120; //Field offset: 0x0
	private const float DELAY_GetInCover = 120; //Field offset: 0x0
	private const float DELAY_NeedHelp = 120; //Field offset: 0x0
	private const float DELAY_Silence = 120; //Field offset: 0x0
	private const float DELAY_Spreadout = 120; //Field offset: 0x0
	private const float DELAY_Stop = 120; //Field offset: 0x0
	private const float MED_SDIST = 625; //Field offset: 0x0
	private const float SMALL_SDIST = 100; //Field offset: 0x0
	private const float STANDART_DELAY = 120; //Field offset: 0x0
	private const float TALK_DELAY = 30; //Field offset: 0x0
	private readonly TwoDimensionalDictionary _nextPossibleUse; //Field offset: 0x18
	private readonly TwoDimensionalDictionary _foreverBlock; //Field offset: 0x20

	public BotReceiver(BotOwner owner) { }

	private bool CanApply(IPlayer player) { }

	public static bool CanReceiveFromPoint(Vector3 p, Vector3 from, Vector3 dir, float cos) { }

	private bool CanUseMassCommand(PhraseDelegateInfo info) { }

	public void Dispose() { }

	private void InCoverWithDist(PhraseDelegateInfo info, float distToCenter, float period) { }

	public void Init() { }

	private void OnGestusShow(BotReceiverGestus data) { }

	private void OnHardAimDelegate(IPlayer player, bool status) { }

	private void OnPhraseSay(PhraseDelegateInfo info) { }

	private void OnQETilt(IPlayer player) { }

	private bool ShallAddOneRequest(bool comandFromMyBoss, bool addVal) { }

	private void TryHoldOrAttack(IPlayer player) { }

}

