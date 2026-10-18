namespace Audio.AmbientSubsystem;

public interface ISoundPoint
{

	public event Action Occupied
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action Released
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsOccupied
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Occupied(Action value) { }

	[CompilerGenerated]
	public void add_Released(Action value) { }

	public bool get_IsOccupied() { }

	public void Occupy() { }

	public void Release() { }

	[CompilerGenerated]
	public void remove_Occupied(Action value) { }

	[CompilerGenerated]
	public void remove_Released(Action value) { }

}

