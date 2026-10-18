//Type is in global namespace

public class ZryachiyCloseFightLayer : ZryachiyAbstractLayer
{
	public const float FIGHT_DIST = 15; //Field offset: 0x0

	public ZryachiyCloseFightLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndCrawlNode() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

