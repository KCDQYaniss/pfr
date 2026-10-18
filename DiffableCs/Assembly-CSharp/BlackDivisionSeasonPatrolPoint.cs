//Type is in global namespace

public class BlackDivisionSeasonPatrolPoint : PatrolPoint
{
	[SerializeField]
	private List nextPointVariants; //Field offset: 0x78
	private int order; //Field offset: 0x80
	public bool isPointOfInterest; //Field offset: 0x84
	private float _lastRollNextPointTime; //Field offset: 0x88
	private int _seed; //Field offset: 0x8C

	public List NextPointVariants
	{
		 get { } //Length: 5
	}

	public BlackDivisionSeasonPatrolPoint() { }

	private bool Contains(List lastPoints, BlackDivisionSeasonPatrolPoint candidate) { }

	public List get_NextPointVariants() { }

	public BlackDivisionSeasonPatrolPoint GetNextPoint(List lastPoints, int prevPointId, int groupId) { }

	public void LinkNextPoint() { }

	protected virtual void OnDrawGizmos() { }

	private void Start() { }

}

