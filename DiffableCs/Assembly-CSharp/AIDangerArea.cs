//Type is in global namespace

public class AIDangerArea
{
	public Vector3 Point; //Field offset: 0x10
	public float Rad; //Field offset: 0x1C
	public float Period; //Field offset: 0x20
	public float EndTime; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsAssaultIsReady>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly float <SRad>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private readonly int <Id>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <IsActive>k__BackingField; //Field offset: 0x34

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsAssaultIsReady
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float SRad
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public AIDangerArea(Vector3 point, float rad, float period) { }

	public void Complete() { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	[CompilerGenerated]
	public bool get_IsAssaultIsReady() { }

	[CompilerGenerated]
	public float get_SRad() { }

	public bool IsPointInside(Vector3 point) { }

	public void OnDrawGizmosSelected() { }

	[CompilerGenerated]
	public void set_IsAssaultIsReady(bool value) { }

}

