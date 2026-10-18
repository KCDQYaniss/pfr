//Type is in global namespace

public class FollowPlayerLayerEvent : BaseLogicLayer
{
	private float SDIST_TO_FOLLOW; //Field offset: 0x90

	public FollowPlayerLayerEvent(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndPlayerFollow() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnFlareDelegate(IPlayer player, Vector3 position, AmmoTemplate ammoTemplate) { }

	public virtual bool ShallUseNow() { }

}

