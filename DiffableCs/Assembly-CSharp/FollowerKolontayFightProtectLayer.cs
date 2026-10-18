//Type is in global namespace

public class FollowerKolontayFightProtectLayer : KolontayAbstractFightLayer
{
	private readonly BossFinder _boss; //Field offset: 0xA0
	private float _nextCheckCover; //Field offset: 0xA8
	private float _nextCheckAttack; //Field offset: 0xAC
	private float _nextCheckCoverInMiddle; //Field offset: 0xB0
	private readonly WDictionary _rndChanceOnlySuppress; //Field offset: 0xB8
	private readonly WDictionary _rndChanceWithAttackMoving; //Field offset: 0xC0
	private readonly WDictionary _rndChanceSimple; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <HaveCoverToShoot>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private CustomNavigationPoint <_coverInMiddle>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private CustomNavigationPoint <_coverForAttack>k__BackingField; //Field offset: 0xE0

	public private CustomNavigationPoint _coverForAttack
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private CustomNavigationPoint _coverInMiddle
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HaveCoverToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public FollowerKolontayFightProtectLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <FindPoint>b__26_0(GroupPoint point) { }

	private Vector3 CenterFindCoverPos() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	[CompilerGenerated]
	public CustomNavigationPoint get__coverForAttack() { }

	[CompilerGenerated]
	public CustomNavigationPoint get__coverInMiddle() { }

	[CompilerGenerated]
	public bool get_HaveCoverToShoot() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	protected void RecheckCoverAtMiddle() { }

	protected CoverSearchData RecheckCoverData() { }

	protected CoverSearchData RecheckCoverDataForAttack() { }

	protected void RecheckCoverForAttack() { }

	[CompilerGenerated]
	private void set__coverForAttack(CustomNavigationPoint value) { }

	[CompilerGenerated]
	private void set__coverInMiddle(CustomNavigationPoint value) { }

	[CompilerGenerated]
	private void set_HaveCoverToShoot(bool value) { }

	public virtual bool ShallUseNow() { }

}

