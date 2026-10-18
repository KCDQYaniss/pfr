namespace Audio.AmbientSubsystem;

public class SoundPoint : MonoBehaviour, ISoundPoint
{
	[CompilerGenerated]
	private Action Occupied; //Field offset: 0x20
	[CompilerGenerated]
	private Action Released; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsOccupied>k__BackingField; //Field offset: 0x30

	public override event Action Occupied
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action Released
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private override bool IsOccupied
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SoundPoint() { }

	[CompilerGenerated]
	public override void add_Occupied(Action value) { }

	[CompilerGenerated]
	public override void add_Released(Action value) { }

	[CompilerGenerated]
	public override bool get_IsOccupied() { }

	public override void Occupy() { }

	public override void Release() { }

	[CompilerGenerated]
	public override void remove_Occupied(Action value) { }

	[CompilerGenerated]
	public override void remove_Released(Action value) { }

	[CompilerGenerated]
	private void set_IsOccupied(bool value) { }

}

