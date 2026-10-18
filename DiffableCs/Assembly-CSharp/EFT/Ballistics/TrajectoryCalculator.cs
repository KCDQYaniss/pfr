namespace EFT.Ballistics;

[DefaultMember("Item")]
public class TrajectoryCalculator
{
	private TrajectoryInfo zeroPoint; //Field offset: 0x10
	protected int cursorIndex; //Field offset: 0x30
	private float bulletMassKg; //Field offset: 0x34
	private float bulletDiameterM; //Field offset: 0x38
	protected float bulletMassKgX2; //Field offset: 0x3C
	protected float bulletBallisticCoefficient; //Field offset: 0x40
	private float bulletArea; //Field offset: 0x44
	protected float bulletSlowdown; //Field offset: 0x48
	private Vector3 gravity; //Field offset: 0x4C
	protected TrajectoryInfo[] history; //Field offset: 0x58
	[CompilerGenerated]
	private TrajectoryInfo <Current>k__BackingField; //Field offset: 0x60
	private bool _isBot; //Field offset: 0x80

	public TrajectoryInfo Current
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public TrajectoryInfo Item
	{
		 get { } //Length: 186
	}

	public int MaxAllowedLength
	{
		 get { } //Length: 26
	}

	public TrajectoryCalculator() { }

	public void ClearClass() { }

	[CompilerGenerated]
	public TrajectoryInfo get_Current() { }

	public TrajectoryInfo get_Item(int index) { }

	public int get_MaxAllowedLength() { }

	public void Initialize(Vector3 zeroPosition, Vector3 zeroVelocity, float bulletMassGram, float bulletDiameterMilimeters, float ballisticCoefficient, bool isBotShot = false) { }

	private TrajectoryInfo Next() { }

	private TrajectoryInfo NextForBot() { }

	private TrajectoryInfo NextForPlayer() { }

	public void Reset() { }

	[CompilerGenerated]
	protected void set_Current(TrajectoryInfo value) { }

}

