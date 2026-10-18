//Type is in global namespace

public class BotGoToPointData : BotData
{
	private const float SDIST_TO_RECALC = 9; //Field offset: 0x0
	private bool _pointhRefreshed; //Field offset: 0x18
	private float _distToPoint; //Field offset: 0x1C
	private float _lastPosibleRecalc; //Field offset: 0x20
	private Vector3 _lastRecalc; //Field offset: 0x24
	[CompilerGenerated]
	private Vector3 <Point>k__BackingField; //Field offset: 0x30
	private NavMeshPath _path; //Field offset: 0x40

	public private Vector3 Point
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public BotGoToPointData(BotOwner owner) { }

	[CompilerGenerated]
	public Vector3 get_Point() { }

	public bool HaveTarget() { }

	public bool IsCome() { }

	[CompilerGenerated]
	private void set_Point(Vector3 value) { }

	public void SetPoint(Vector3 p) { }

	public void UpdateToGo(bool sprint, float speed = 1, float pose = 1) { }

}

