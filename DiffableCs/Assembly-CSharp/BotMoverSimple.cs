//Type is in global namespace

public class BotMoverSimple : BotMover
{

	public BotMoverSimple(BotOwner owner, Player player, AICoversData covers) { }

	protected virtual bool CheckCornerIndexByReachDist(float distCur, Vector3 position) { }

	protected virtual bool CheckIsOnPoint(Vector3 position) { }

	protected virtual void SetLastContex(float remainDist, Vector3 direction, Vector3 realDestPoint) { }

}

