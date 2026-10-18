namespace EFT.NextObservedPlayer.Operations;

public sealed class SpawnHandsOperation : BaseHandsOperation
{

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public SpawnHandsOperation() { }

	public static SpawnHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public virtual IHandsOperationResult Start(float animationSpeed) { }

}

