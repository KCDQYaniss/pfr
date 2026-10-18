namespace EFT.NextObservedPlayer.Operations;

public sealed class RemoveHandsOperation : BaseHandsOperation
{
	internal struct Input
	{
		public float animationSpeed; //Field offset: 0x0
		public bool fastHide; //Field offset: 0x4

	}

	private bool _skipEvent; //Field offset: 0x20

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public RemoveHandsOperation() { }

	public static RemoveHandsOperation CreateInstance() { }

	public virtual void Entry(IHandOperation from) { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	public virtual IHandsOperationResult Start(Input input) { }

}

