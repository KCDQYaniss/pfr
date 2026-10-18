//Type is in global namespace

public class BotMalfunctionData : BotData
{
	private enum EInnerMalfunctionState
	{
		None = 0,
		UnknownMalfunction = 1,
		KnownMalfunction = 2,
		MalfunctionFixInProgress = 3,
		MalfunctionFixed = 4,
	}

	private const float END_OPERATION_DURATION = 8.5; //Field offset: 0x0
	private EInnerMalfunctionState _malfState; //Field offset: 0x18
	private float _nextOperationTime; //Field offset: 0x1C
	private bool _malfFixed; //Field offset: 0x20
	private bool _ignoreMalfunction; //Field offset: 0x21
	private bool _preFixed; //Field offset: 0x22
	private bool _weaponExamined; //Field offset: 0x23

	public BotMalfunctionData(BotOwner owner) { }

	private bool AllowMalfunction() { }

	public void Dispose() { }

	public string GetCustomBotInfoData() { }

	public bool HaveMalfunction() { }

	private bool IsWeaponInIdleState() { }

	public EMalfunctionState MalfunctionType() { }

	public void Update() { }

	public bool ValidateMalfunction(EMalfunctionState malfState) { }

}

