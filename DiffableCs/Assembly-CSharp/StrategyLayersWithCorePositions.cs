//Type is in global namespace

public abstract class StrategyLayersWithCorePositions : BaseBrain
{

	protected StrategyLayersWithCorePositions(BotOwner owner) { }

	public abstract void SetCorePosition(Vector3 pos) { }

}

