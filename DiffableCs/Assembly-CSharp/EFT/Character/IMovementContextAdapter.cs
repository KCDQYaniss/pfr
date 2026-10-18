namespace EFT.Character;

public interface IMovementContextAdapter : IDisposable
{

	public event Action EnterMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action ExitMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Vector3 MountingPoint
	{
		 get { } //Length: 0
	}

	public EMountSideDirection MountSideDirection
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public void add_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public void add_StateChanged(Action value) { }

	public Vector3 get_MountingPoint() { }

	public EMountSideDirection get_MountSideDirection() { }

	[CompilerGenerated]
	public void remove_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public void remove_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public void remove_StateChanged(Action value) { }

}

