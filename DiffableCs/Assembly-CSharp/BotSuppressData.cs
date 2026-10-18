//Type is in global namespace

public abstract class BotSuppressData : BotData
{
	protected bool _inProcess; //Field offset: 0x18
	protected CustomNavigationPoint _pointToSuppressFrom; //Field offset: 0x20
	protected EnemyInfo _enemyToSupress; //Field offset: 0x28
	private float _supressedTime; //Field offset: 0x30
	private Nullable _posToShoot; //Field offset: 0x34
	protected float _anyWayEndTime; //Field offset: 0x44
	[CompilerGenerated]
	private bool <Complete>k__BackingField; //Field offset: 0x48

	public private bool Complete
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CustomNavigationPoint PointToSuppressFrom
	{
		 get { } //Length: 5
	}

	protected BotSuppressData(BotOwner owner) { }

	public abstract void Activate() { }

	protected void CompleteTo(float delta) { }

	public float DeltaLastSupperss() { }

	public abstract void Dispose() { }

	[CompilerGenerated]
	public bool get_Complete() { }

	public CustomNavigationPoint get_PointToSuppressFrom() { }

	public override Nullable GetPoint() { }

	protected bool InitEnemy(EnemyInfo enemyToSupress, CustomNavigationPoint pos = null) { }

	protected bool InitEnemy(Vector3 posToShoot, CustomNavigationPoint pos = null) { }

	[CompilerGenerated]
	private void set_Complete(bool value) { }

}

