//Type is in global namespace

public class CoverSearchDebugIteration
{
	[SerializeField]
	private CoverSearchDebugPointsGroup _coverPointGroups; //Field offset: 0x10
	[SerializeField]
	public Vector3 CenterPoint; //Field offset: 0x18
	[SerializeField]
	public Nullable ResultCover; //Field offset: 0x24
	public string timeMark; //Field offset: 0x38
	public string searchLabel; //Field offset: 0x40

	public CoverSearchDebugPointsGroup CoverPointGroups
	{
		 get { } //Length: 5
	}

	public CoverSearchDebugIteration(string label = "Default") { }

	public void AddPointToIteration(Vector3 point, int level, float sqrRadius) { }

	public void Draw() { }

	public CoverSearchDebugPointsGroup get_CoverPointGroups() { }

}

