//Type is in global namespace

public class BotSearchData : BotData
{
	protected bool _going; //Field offset: 0x18
	private float _updatePointTimer; //Field offset: 0x1C
	private bool isReachableLast; //Field offset: 0x20
	private CustomNavigationPoint closePoint; //Field offset: 0x28
	private float _nextPosibleCheckTime; //Field offset: 0x30
	private float _nextPosibleGoRefresh; //Field offset: 0x34
	private float _lastCheckEnemyPos; //Field offset: 0x38
	[CompilerGenerated]
	private BotSearchPoint <SearchPoint>k__BackingField; //Field offset: 0x40
	private BotSearchPoint _lastSearchPoint; //Field offset: 0x48

	public private BotSearchPoint SearchPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BotSearchData(BotOwner owner) { }

	public override void Activate() { }

	private void Compare(BotSearchPoint nextSearchPoint) { }

	public static BotSearchData Create(BotOwner bot) { }

	public void Dispose() { }

	private BotSearchPoint FindEnemyPoint() { }

	private BotSearchPoint FindSearchPoint() { }

	private BotSearchPoint FindTargetPoint() { }

	[CompilerGenerated]
	public BotSearchPoint get_SearchPoint() { }

	protected void GoStraightCoverPoint(Vector3 goTo) { }

	private void InPoint() { }

	public void RefreshSearchPoint() { }

	private void RestartFindTime() { }

	[CompilerGenerated]
	private void set_SearchPoint(BotSearchPoint value) { }

	public override void UpdateByNode() { }

}

