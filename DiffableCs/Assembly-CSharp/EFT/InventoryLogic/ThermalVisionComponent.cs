namespace EFT.InventoryLogic;

public class ThermalVisionComponent : ItemComponent, ITogglableComponentContainer, ITogglableComponentContainer, IItemComponent
{
	internal enum SelectablePalette
	{
		Fusion = 0,
		Rainbow = 1,
		WhiteHot = 2,
		BlackHot = 3,
	}

	public readonly IThermalVisionComponentTemplate Template; //Field offset: 0x18
	[CompilerGenerated]
	private readonly TogglableComponent <Togglable>k__BackingField; //Field offset: 0x20

	private override ITogglableComponent EFT.InventoryLogic.ITogglableComponentContainer.Togglable
	{
		private get { } //Length: 5
	}

	public override TogglableComponent Togglable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ThermalVisionComponent(Item item, IThermalVisionComponentTemplate template, TogglableComponent togglable) { }

	private override ITogglableComponent EFT.InventoryLogic.ITogglableComponentContainer.get_Togglable() { }

	[CompilerGenerated]
	public override TogglableComponent get_Togglable() { }

}

