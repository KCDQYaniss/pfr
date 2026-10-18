namespace Audio.AmbientSubsystem.PathMoverStrategy;

public interface IPathMovementStrategy
{

	public event Action MovementCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public EMovementStrategy MovementStrategy
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_MovementCompleted(Action value) { }

	public void Execute() { }

	public bool get_IsCompleted() { }

	public EMovementStrategy get_MovementStrategy() { }

	[CompilerGenerated]
	public void remove_MovementCompleted(Action value) { }

	public void SetSpeed(float duration) { }

	public void Stop(bool resetPosition = false) { }

}

