namespace EFT.NextObservedPlayer;

public class MedsAnimationHandsController : BaseAnimationHandsController
{
	private static readonly Dictionary _handsOperationFactories; //Field offset: 0x0
	private int _roundRobin; //Field offset: 0x80
	private AnimationVariantsComponent _animationVariantsComponent; //Field offset: 0x88

	protected virtual Dictionary HandsOperationFactories
	{
		 get { } //Length: 83
	}

	private static MedsAnimationHandsController() { }

	public MedsAnimationHandsController() { }

	private void BumpAnimationVariant() { }

	protected virtual Dictionary get_HandsOperationFactories() { }

	public void InitializeMedsAnimationVariant(Item item) { }

	protected virtual void OnAnimatorOutUse() { }

	public void OnNetworkMedEffectAdded() { }

	public void OnNetworkMedEffectRemoved() { }

	private bool TryGetVariantsLength(out int length) { }

}

