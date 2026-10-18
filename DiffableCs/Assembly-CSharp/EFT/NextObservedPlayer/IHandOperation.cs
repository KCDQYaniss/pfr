namespace EFT.NextObservedPlayer;

public interface IHandOperation : IHandOperationLifeCircle
{

	public HandsOperationAnimatorCallbacks Callbacks
	{
		 get { } //Length: 0
	}

	public bool CanFastForward
	{
		 get { } //Length: 0
	}

	public HandsOperationAnimatorCallbacks get_Callbacks() { }

	public bool get_CanFastForward() { }

}

