//Type is in global namespace

public class BotMoverBTR : BotMover
{

	public BotMoverBTR(BotOwner owner, Player player, AICoversData covers) { }

	protected virtual bool CheckCornerIndexByReachDist(float distCur, Vector3 position) { }

	protected virtual bool CheckIsOnPoint(Vector3 position) { }

	public virtual void GoToByWay(Vector3[] way, float reachDist) { }

	public virtual void ManualUpdate() { }

	protected virtual void SetLastContex(float remainDist, Vector3 directionMove, Vector3 targetPos) { }

	protected virtual EBotLinkResult SetPlayerToNavMesh(Vector3 castPoint, Vector3 deltaMove, out bool onTerrain) { }

	public virtual void SetPose(float targetPose) { }

	public virtual void Sprint(bool val, bool withDebugCallback = true) { }

}

