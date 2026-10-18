namespace EFT.Character;

public abstract class AbstractMovementContextAdapter : IMovementContextAdapter, IDisposable
{

	public abstract event Action EnterMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action ExitMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract Vector3 MountingPoint
	{
		 get { } //Length: 0
	}

	public abstract EMountSideDirection MountSideDirection
	{
		 get { } //Length: 0
	}

	protected AbstractMovementContextAdapter() { }

	[CompilerGenerated]
	public abstract void add_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public abstract void add_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public abstract void add_StateChanged(Action value) { }

	public abstract void Dispose() { }

	protected abstract void EnterMountedStateHandler(float timeToMount) { }

	protected abstract void ExitMountedStateHandler(float timeToUnmount) { }

	protected virtual void Finalize() { }

	public abstract Vector3 get_MountingPoint() { }

	public abstract EMountSideDirection get_MountSideDirection() { }

	[CompilerGenerated]
	public abstract void remove_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public abstract void remove_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public abstract void remove_StateChanged(Action value) { }

	protected abstract void StateChangedHandler(EPlayerState previousState, EPlayerState nextState) { }

}

