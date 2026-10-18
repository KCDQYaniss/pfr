//Type is in global namespace

public class MarksmanTargetLayer : BaseLogicLayer
{
	private bool _canLay; //Field offset: 0x90

	public MarksmanTargetLayer(BotOwner bot, int priority, bool canLay = true) { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

