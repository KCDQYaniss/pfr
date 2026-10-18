//Type is in global namespace

public class BotSuppressStationary : BotData
{
	[CompilerGenerated]
	private Func <PointToArtSuppress>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private AbstractSuppressStationary <CurUsingLogic>k__BackingField; //Field offset: 0x20
	private NoSuppressData _noSupress; //Field offset: 0x28
	private BotMGSuppress _mgSuppress; //Field offset: 0x30
	private BotArtillerySuppress _artillerySuppress; //Field offset: 0x38
	private EnemyInfo _enemyInfo; //Field offset: 0x40
	[CompilerGenerated]
	private float <LastHitTargetTime>k__BackingField; //Field offset: 0x48

	public private AbstractSuppressStationary CurUsingLogic
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float LastHitTargetTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private Func PointToArtSuppress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotSuppressStationary(BotOwner owner) { }

	public void Activate() { }

	public void Dispose() { }

	[CompilerGenerated]
	public AbstractSuppressStationary get_CurUsingLogic() { }

	[CompilerGenerated]
	public float get_LastHitTargetTime() { }

	[CompilerGenerated]
	public Func get_PointToArtSuppress() { }

	public bool HaveEnemy() { }

	private void OnHitTarget(DamageInfo damageInfo, EBodyPart arg2, float arg3) { }

	private void OnLinkedWeaponChange(StationaryWeaponLink obj) { }

	[CompilerGenerated]
	private void set_CurUsingLogic(AbstractSuppressStationary value) { }

	[CompilerGenerated]
	private void set_LastHitTargetTime(float value) { }

	[CompilerGenerated]
	private void set_PointToArtSuppress(Func value) { }

	public void SetTargetGetter(Func pointToArtSuppress) { }

	public void SetTargetGetter(Func pointToArtSuppress, EnemyInfo enemyInfo) { }

	private void TryUnsubscribe() { }

}

