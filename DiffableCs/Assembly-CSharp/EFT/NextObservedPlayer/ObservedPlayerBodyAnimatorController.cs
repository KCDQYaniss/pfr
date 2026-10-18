namespace EFT.NextObservedPlayer;

public class ObservedPlayerBodyAnimatorController
{
	private readonly ObservedPlayerView _player; //Field offset: 0x10
	private ObservedPlayerAnimatorModel _model; //Field offset: 0x18

	public ObservedPlayerBodyAnimatorController(ObservedPlayerView player, ObservedPlayerAnimatorModel model) { }

	public void Apply(ObservedPlayerAnimatorModel nextModel, ObservedPlayerMovementModel movementModel) { }

	private void BtrInteraction(BtrGoInInteractionMessage btrGoInInteractionMessage) { }

	private void BtrInteraction(BtrGoOutInteractionMessage btrGoOutInteractionMessage) { }

	public void Execute(ICommandMessage command) { }

	private void SetAnimatorLayerWeight(SetAnimatorLayerWeight setAnimatorLayerWeightCommand) { }

	private void SetBtrUseItem(SetHandsCommandMessage handsCommandMessage) { }

}

