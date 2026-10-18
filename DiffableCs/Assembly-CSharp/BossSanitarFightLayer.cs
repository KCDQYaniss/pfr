//Type is in global namespace

public class BossSanitarFightLayer : AbstractSanitarFightLayer
{
	private bool _healAsked; //Field offset: 0x110

	public BossSanitarFightLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	public virtual CustomNavigationPoint FindPointForFight(bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnHealAsked(IPlayer obj) { }

	public virtual bool ShallUseNow() { }

}

