//Type is in global namespace

public class PatrolExfiltrationPointsData : BotData
{
	private const float MAX_FAR_SDIST = 90000; //Field offset: 0x0
	private float _nextCheck; //Field offset: 0x18
	private float _dropPointTime; //Field offset: 0x1C
	private float _lastTimeToPoint; //Field offset: 0x20
	private float _timeDropVisited; //Field offset: 0x24
	private float _stayAtPointPeriod; //Field offset: 0x28
	private AIExfiltrationPoint _cachedExfiltrationPoint; //Field offset: 0x30
	private bool _atPointNow; //Field offset: 0x38

	public AIExfiltrationPoint CachedExfiltrationPoint
	{
		 get { } //Length: 76
	}

	public PatrolExfiltrationPointsData(BotOwner owner) { }

	public void ComeToExfiltrationPoint() { }

	public AIExfiltrationPoint get_CachedExfiltrationPoint() { }

	public bool HaveActions() { }

	public void UpdateFindNextExfiltrationPoint() { }

}

