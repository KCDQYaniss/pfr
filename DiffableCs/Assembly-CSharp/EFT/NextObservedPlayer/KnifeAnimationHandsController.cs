namespace EFT.NextObservedPlayer;

public sealed class KnifeAnimationHandsController : BaseAnimationHandsController
{
	private static readonly Dictionary _handsOperationFactories; //Field offset: 0x0

	protected virtual Dictionary HandsOperationFactories
	{
		 get { } //Length: 83
	}

	private static KnifeAnimationHandsController() { }

	public KnifeAnimationHandsController() { }

	protected virtual Dictionary get_HandsOperationFactories() { }

	public virtual void OnFireEnd() { }

}

