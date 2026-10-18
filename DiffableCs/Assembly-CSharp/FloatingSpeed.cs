//Type is in global namespace

public class FloatingSpeed
{
	private FloatingSum _distance; //Field offset: 0x10
	private FloatingSum _time; //Field offset: 0x18
	[CompilerGenerated]
	private int <Capacity>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Speed>k__BackingField; //Field offset: 0x24

	public private int Capacity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float Speed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public FloatingSpeed(int capacity) { }

	public void Add(float distance, float time) { }

	public void Clear() { }

	[CompilerGenerated]
	public int get_Capacity() { }

	[CompilerGenerated]
	public float get_Speed() { }

	[CompilerGenerated]
	private void set_Capacity(int value) { }

	[CompilerGenerated]
	private void set_Speed(float value) { }

}

