//Type is in global namespace

public class NavEdge
{
	public NavPoint Point1; //Field offset: 0x10
	public NavPoint Point2; //Field offset: 0x18
	public NavTriangle Triangle; //Field offset: 0x20
	public NavEdge Pair; //Field offset: 0x28
	public int IdToCompare; //Field offset: 0x30
	public float Magnitude; //Field offset: 0x34
	public int Idpoint1; //Field offset: 0x38
	public int Idpoint2; //Field offset: 0x3C
	public int IdTriangle; //Field offset: 0x40
	public int Id; //Field offset: 0x44
	[CompilerGenerated]
	private bool <Deleted>k__BackingField; //Field offset: 0x48

	public private bool Deleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool HavePair
	{
		 get { } //Length: 9
	}

	public NavEdge(int id, NavPoint p1, NavPoint p2, NavTriangle triangle) { }

	public void CalcCompareString(int halfSize) { }

	public float CalcDist() { }

	public void ChangePoints(NavPoint toRemove, NavPoint connectTo) { }

	public void DebugDraw(float up, Nullable color = null) { }

	[CompilerGenerated]
	public bool get_Deleted() { }

	public bool get_HavePair() { }

	public float GetMagnitude() { }

	public NavPoint GetOther(NavPoint key) { }

	public Vector3 GetPos() { }

	public void MarkDeleted() { }

	public void Restore(Dictionary dc, Dictionary dcTriang) { }

	[CompilerGenerated]
	private void set_Deleted(bool value) { }

	private void SettingPointToIds(NavPoint p1, NavPoint p2) { }

	public virtual string ToString() { }

}

