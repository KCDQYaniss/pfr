namespace EFT.NextObservedPlayer;

public class EmptyAnimationHandsController : BaseAnimationHandsController
{
	private static readonly Dictionary _handsOperationFactories; //Field offset: 0x0

	protected virtual Dictionary HandsOperationFactories
	{
		 get { } //Length: 83
	}

	private static EmptyAnimationHandsController() { }

	public EmptyAnimationHandsController() { }

	protected virtual Dictionary get_HandsOperationFactories() { }

	public virtual void OnWeapIn() { }

}

