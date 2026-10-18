//Type is in global namespace

public class VSRFTargetLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private CustomNavigationPoint <_coverInMiddle>k__BackingField; //Field offset: 0x90
	private float _nextCheckCoverInMiddle; //Field offset: 0x98

	public private CustomNavigationPoint _coverInMiddle
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public VSRFTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	[CompilerGenerated]
	public CustomNavigationPoint get__coverInMiddle() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	protected CoverSearchData RecheckCoverData() { }

	[CompilerGenerated]
	private void set__coverInMiddle(CustomNavigationPoint value) { }

	public virtual bool ShallUseNow() { }

	private bool ShouldHeal() { }

}

