//Type is in global namespace

public class BossKilla : ABossLogic
{
	public const string ALARM_EVENT_END = "autoId_00000_ALARM_KIBA_CONSOLE"; //Field offset: 0x0
	public const string ALARM_EVENT_START = "autoId_00000_ALARM_KIBA"; //Field offset: 0x0
	private const string ALARM_BOUNDS = "AlarmBounds"; //Field offset: 0x0
	private const string KILLA_PATROL_ALT = "KILLA_PATROL_ALT"; //Field offset: 0x0
	private BotSettingsInGameModif _last; //Field offset: 0x20
	private int _burnPower; //Field offset: 0x28
	private bool _isAlarmed; //Field offset: 0x2C
	[CompilerGenerated]
	private Action OnAlarmChange; //Field offset: 0x30
	[CompilerGenerated]
	private AIPlaceInfo <AlarmBounds>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HaveSecurityInfo>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <AlarmActivated>k__BackingField; //Field offset: 0x41

	public event Action OnAlarmChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool AlarmActivated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private AIPlaceInfo AlarmBounds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HaveSecurityInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BossKilla(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnAlarmChange(Action value) { }

	public virtual void BossLogicUpdate() { }

	private void DismissLastBuff() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public bool get_AlarmActivated() { }

	[CompilerGenerated]
	public AIPlaceInfo get_AlarmBounds() { }

	[CompilerGenerated]
	public bool get_HaveSecurityInfo() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnInteractObject(string doorId, Vector3 position) { }

	private void OnPeaceChange(bool isPeace) { }

	[CompilerGenerated]
	public void remove_OnAlarmChange(Action value) { }

	[CompilerGenerated]
	private void set_AlarmActivated(bool value) { }

	[CompilerGenerated]
	private void set_AlarmBounds(AIPlaceInfo value) { }

	[CompilerGenerated]
	private void set_HaveSecurityInfo(bool value) { }

	public virtual void SetPatrolMode() { }

}

