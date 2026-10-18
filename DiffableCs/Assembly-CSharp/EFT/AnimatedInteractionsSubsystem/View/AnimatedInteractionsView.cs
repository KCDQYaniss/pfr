namespace EFT.AnimatedInteractionsSubsystem.View;

public class AnimatedInteractionsView : IAnimatedInteractionsView
{
	private const int INTERACTION_LAYER_INDEX = 14; //Field offset: 0x0
	private const string INTERACTION_IDLE_STATE = "Idle"; //Field offset: 0x0
	private readonly int IS_INTERACTION_PARAMETR_HASH; //Field offset: 0x10
	private readonly int INTERACTION_INDEX_PARAMETR_HASH; //Field offset: 0x14
	private readonly IAnimator _animatorWrapper; //Field offset: 0x18

	public AnimatedInteractionsView(IAnimator animator) { }

	public override void Dispose() { }

	public override void ResetInteraction() { }

	public override void ShowInteraction(byte interactionIndex) { }

	public override void StopInteraction() { }

}

