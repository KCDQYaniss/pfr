//Type is in global namespace

public interface IPathTargetPoint : IPositionPoint
{

	public void BotCome(BotOwner owner) { }

	public bool IsSame(IPathTargetPoint point) { }

}

