namespace EFT.Interactive;

public sealed class UnlockResult : InteractionResult, IOperationResult, IRollable
{
	public readonly KeyComponent Key; //Field offset: 0x18
	public readonly bool Succeed; //Field offset: 0x20
	public readonly bool KeyChargeConsumed; //Field offset: 0x21
	private readonly ItemAddress _from; //Field offset: 0x28
	[CanBeNull]
	private readonly DiscardResult _discardResult; //Field offset: 0x30

	public UnlockResult(KeyComponent key, DiscardResult discardResult, bool succeed, bool keyChargeConsumed = true) { }

	public override bool CanExecute(ItemController itemController) { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

