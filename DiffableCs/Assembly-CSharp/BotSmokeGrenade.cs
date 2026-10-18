//Type is in global namespace

public class BotSmokeGrenade : BotData
{
	private readonly HashSet _affectedSmokes; //Field offset: 0x18
	private BotSettingsInGameModif _smokeModif; //Field offset: 0x20
	private AISmokeGrenadePlace _lastPlace; //Field offset: 0x28
	private bool _willShootToSmoke; //Field offset: 0x30
	private float _nextCheckTime; //Field offset: 0x34
	private float _smokeEndTime; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsInSmoke>k__BackingField; //Field offset: 0x3C

	public private bool IsInSmoke
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Vector3 PlaceToShoot
	{
		 get { } //Length: 174
	}

	public BotSmokeGrenade(BotOwner owner) { }

	public void AddSmokeGrenadeData(AISmokeGrenadePlace place) { }

	private void CheckSmoke() { }

	[CompilerGenerated]
	public bool get_IsInSmoke() { }

	public Vector3 get_PlaceToShoot() { }

	[CompilerGenerated]
	private void set_IsInSmoke(bool value) { }

	public bool ShallShoot() { }

	public void SmokeEnter(int throwableId) { }

	public void SmokeExit(int throwableId) { }

}

