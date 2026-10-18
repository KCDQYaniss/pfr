//Type is in global namespace

public class CoverSearchDataWithPrefDist : CoverSearchData
{
	private readonly float _preferedDist; //Field offset: 0xC8

	public CoverSearchDataWithPrefDist(float prefDist, Vector3 centerPos, BotOwner bot, CoverShootType shootType, float maxDistSqr, float minDistSqr, CoverSearchType searchType, ShootToPoint shoot2point, Nullable closeFriendCover, Nullable pointToBeClose, ECheckSHootHide CheckShootHide, CoverSearchDefenceData coverSearchDefenceData, PointsArrayType arrayType = 0, bool useSelfFindPoint = true, Nullable placeInfo = null, Nullable maxIterations = null) { }

	public virtual float CalcPowerOnlyDistToBot(GroupPoint point) { }

}

