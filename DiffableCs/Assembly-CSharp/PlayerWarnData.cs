//Type is in global namespace

public class PlayerWarnData
{
	public float ComeInsideTime; //Field offset: 0x10
	public float WarnedTime; //Field offset: 0x14
	[CompilerGenerated]
	private float <StartWarnedTime>k__BackingField; //Field offset: 0x18
	private bool comeOut; //Field offset: 0x1C
	private bool _startWarnedTimeSet; //Field offset: 0x1D
	private int comesInsideTimes; //Field offset: 0x20
	private readonly Dictionary _looksDictionary; //Field offset: 0x28

	public private float StartWarnedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public PlayerWarnData() { }

	private int AddLooks(int playerId) { }

	private bool CheckLookAtMe(IBotOwner bot, IPlayer player) { }

	public void ComeAway() { }

	[CompilerGenerated]
	public float get_StartWarnedTime() { }

	private bool IsLookTooMuch(BotOwner boss, IPlayer targetPlayer) { }

	private bool LookTooMuchSubCheck(IBotOwner bot, IPlayer targetPlayer) { }

	public void Return() { }

	[CompilerGenerated]
	private void set_StartWarnedTime(float value) { }

	public void SetStartWarnTime() { }

	private void SetZero(int playerId) { }

	public bool ShallAttack(BotOwner boss, IPlayer targetPlayer) { }

}

