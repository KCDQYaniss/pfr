namespace EFT.Character;

public class ObservedPlayerMovementContextAdapter : AbstractMovementContextAdapter
{
	private readonly ObservedPlayerStateContext _context; //Field offset: 0x10
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action EnterMountedState; //Field offset: 0x20
	[CompilerGenerated]
	private Action ExitMountedState; //Field offset: 0x28

	public virtual event Action EnterMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public virtual event Action ExitMountedState
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public virtual event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public virtual Vector3 MountingPoint
	{
		 get { } //Length: 41
	}

	public virtual EMountSideDirection MountSideDirection
	{
		 get { } //Length: 26
	}

	public ObservedPlayerMovementContextAdapter(ObservedPlayerStateContext context) { }

	[CompilerGenerated]
	public virtual void add_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public virtual void add_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public virtual void add_StateChanged(Action value) { }

	public virtual void Dispose() { }

	protected virtual void EnterMountedStateHandler(float timeToMount) { }

	protected virtual void ExitMountedStateHandler(float timeToUnmount) { }

	public virtual Vector3 get_MountingPoint() { }

	public virtual EMountSideDirection get_MountSideDirection() { }

	[CompilerGenerated]
	public virtual void remove_EnterMountedState(Action value) { }

	[CompilerGenerated]
	public virtual void remove_ExitMountedState(Action value) { }

	[CompilerGenerated]
	public virtual void remove_StateChanged(Action value) { }

	protected virtual void StateChangedHandler(EPlayerState previousState, EPlayerState nextState) { }

}

