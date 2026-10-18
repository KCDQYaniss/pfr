//Type is in global namespace

public abstract class BaseAbstractKojaniyLayer : BaseLogicLayer
{
	protected Nullable _firstAppearPos; //Field offset: 0x90
	private Vector3 _lootPosition; //Field offset: 0xA0
	[CompilerGenerated]
	private IBossKojaniy <_bossKojaniy>k__BackingField; //Field offset: 0xB0

	protected private IBossKojaniy _bossKojaniy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BaseAbstractKojaniyLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	[CompilerGenerated]
	protected IBossKojaniy get__bossKojaniy() { }

	public HashSet GetCarePos(HashSet prevPositions) { }

	private void OnThrowRequest() { }

	[CompilerGenerated]
	private void set__bossKojaniy(IBossKojaniy value) { }

	protected void SetBossData(IBossKojaniy bossData) { }

	public void SetCarePosition(Vector3 lootPosition) { }

	protected abstract bool ShallAttack() { }

	protected bool SomeOneSeeEnemy() { }

}

