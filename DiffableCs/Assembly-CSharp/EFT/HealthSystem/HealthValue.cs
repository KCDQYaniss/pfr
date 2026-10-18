namespace EFT.HealthSystem;

public class HealthValue
{
	protected ValueStruct Value; //Field offset: 0x10
	[CompilerGenerated]
	private float <LastDiff>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <DownMult>k__BackingField; //Field offset: 0x28

	public bool AtMaximum
	{
		 get { } //Length: 11
	}

	public bool AtMinimum
	{
		 get { } //Length: 11
	}

	public override float Current
	{
		 get { } //Length: 6
		 set { } //Length: 88
	}

	public ValueStruct CurrentAndMaximum
	{
		 get { } //Length: 17
	}

	public float DownMult
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float LastDiff
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float Maximum
	{
		 get { } //Length: 6
	}

	public float Minimum
	{
		 get { } //Length: 6
	}

	public float Normalized
	{
		 get { } //Length: 11
	}

	public HealthValue(ValueInfo valueInfo) { }

	public HealthValue(float cur, float max, float min = 0) { }

	public bool get_AtMaximum() { }

	public bool get_AtMinimum() { }

	public override float get_Current() { }

	public ValueStruct get_CurrentAndMaximum() { }

	[CompilerGenerated]
	public float get_DownMult() { }

	[CompilerGenerated]
	public float get_LastDiff() { }

	public float get_Maximum() { }

	public float get_Minimum() { }

	public float get_Normalized() { }

	private void Init(float cur, float min, float max) { }

	public override void set_Current(float value) { }

	[CompilerGenerated]
	public void set_DownMult(float value) { }

	[CompilerGenerated]
	protected void set_LastDiff(float value) { }

}

