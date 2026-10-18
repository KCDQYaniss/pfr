//Type is in global namespace

public class FollowerGluharScoutFightLayer : GluharFightAbstractLayer
{
	private bool _shallAttack; //Field offset: 0xF0

	public FollowerGluharScoutFightLayer(BotOwner owner, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	public virtual string Name() { }

	public void ShallAttack(bool val) { }

}

