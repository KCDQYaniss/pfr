//Type is in global namespace

public class BlackDivisionSeasonPatrollingData : PatrollingData
{
	public int BlackDivPatrollingPointIndex; //Field offset: 0xC8
	public float DistanceToNextPoint; //Field offset: 0xCC
	public float WayForAllPreviousParts; //Field offset: 0xD0
	public float WayFromLastPointToCurrentPosition; //Field offset: 0xD4
	private PatrolPointContainer _curPatrolPoint; //Field offset: 0xD8

	public virtual PatrolPointContainer CurPatrolPoint
	{
		 get { } //Length: 8
	}

	public BlackDivisionSeasonPatrollingData(BotOwner owner) { }

	public virtual PatrolPointContainer get_CurPatrolPoint() { }

	public void SetPatrolPoint(BlackDivisionSeasonPatrolPoint point) { }

}

