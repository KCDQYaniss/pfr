//Type is in global namespace

public class SectantRunAndStrikeLayer : AbstractSectantLayerFight
{
	private const float DIST_TO_SHOOT_ANYWAY = 14; //Field offset: 0x0
	private const float SHOOT_PERIOD = 4; //Field offset: 0x0
	private float _nextPosibleStartShoot; //Field offset: 0x90
	private float _startShootFromPlace; //Field offset: 0x94
	private readonly float _shootFromPlacePeriod; //Field offset: 0x98
	[CompilerGenerated]
	private bool <HaveCoverToShoot>k__BackingField; //Field offset: 0x9C

	public private bool HaveCoverToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SectantRunAndStrikeLayer(BotOwner bot, int priority) { }

	private bool CanShootNextFrame() { }

	private bool CheckIsGoodForHide(CustomNavigationPoint pointOfSearch) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	[CompilerGenerated]
	public bool get_HaveCoverToShoot() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	[CompilerGenerated]
	private void set_HaveCoverToShoot(bool value) { }

	public virtual bool ShallUseNow() { }

}

