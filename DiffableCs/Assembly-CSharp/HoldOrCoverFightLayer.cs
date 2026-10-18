//Type is in global namespace

public class HoldOrCoverFightLayer : HoldOrCoverTargetLayer
{

	public HoldOrCoverFightLayer(BotOwner bot, int priority, Func shallUse) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

