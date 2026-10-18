//Type is in global namespace

public interface IPatrolMoveBossStayAtPlace
{

	public event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Nullable PointForBoss
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPositionsRecalculated(Action value) { }

	public Dictionary FollowersPositions() { }

	public Nullable get_PointForBoss() { }

	public Vector3 GetTargetToLook() { }

	[CompilerGenerated]
	public void remove_OnPositionsRecalculated(Action value) { }

	public void SetFollowersPositions() { }

}

