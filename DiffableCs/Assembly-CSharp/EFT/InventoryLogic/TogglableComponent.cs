namespace EFT.InventoryLogic;

public sealed class TogglableComponent : ItemComponent, ITogglableComponent, IItemComponent
{
	[Diffable]
	public bool On; //Field offset: 0x18
	public readonly BindableEvent OnChanged; //Field offset: 0x20

	private override bool EFT.InventoryLogic.ITogglableComponent.On
	{
		private get { } //Length: 5
	}

	public TogglableComponent(Item item) { }

	private override bool EFT.InventoryLogic.ITogglableComponent.get_On() { }

	public void ForceToggle(bool targetToggle) { }

	public OperationResult Set(bool value, bool simulate = false, bool silent = false) { }

	public override void Toggle() { }

	public override void ToggleSilent() { }

}

