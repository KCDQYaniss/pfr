//Type is in global namespace

internal class LeaveMapLayer : BaseLogicLayer
{
	private const float DIST_NOT_TO_LEAVE = 50; //Field offset: 0x0
	private float _nextClosestDist; //Field offset: 0x90
	[CompilerGenerated]
	private float <ClosestPlayerDist>k__BackingField; //Field offset: 0x94

	private float ClosestPlayerDist
	{
		[CompilerGenerated]
		private get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public LeaveMapLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLeaveMap() { }

	[CompilerGenerated]
	private float get_ClosestPlayerDist() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	[CompilerGenerated]
	private void set_ClosestPlayerDist(float value) { }

	public virtual bool ShallUseNow() { }

}

