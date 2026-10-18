//Type is in global namespace

public class AISmokeGrenadePlace
{
	private readonly float sRad; //Field offset: 0x10
	[CompilerGenerated]
	private readonly float <EndTime>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly float <Radius>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly float <Duration>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly float <StartTime>k__BackingField; //Field offset: 0x2C

	public float Duration
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float EndTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public float Radius
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public AISmokeGrenadePlace(Vector3 pos, float duration, float rad) { }

	[CompilerGenerated]
	public float get_Duration() { }

	[CompilerGenerated]
	public float get_EndTime() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	[CompilerGenerated]
	public float get_Radius() { }

	[CompilerGenerated]
	public float get_StartTime() { }

	public bool IsInRadius(Vector3 pos) { }

}

