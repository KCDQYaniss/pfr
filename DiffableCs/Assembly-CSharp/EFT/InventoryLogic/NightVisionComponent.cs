namespace EFT.InventoryLogic;

public class NightVisionComponent : ItemComponent, ITogglableComponentContainer, ITogglableComponentContainer, IItemComponent
{
	internal enum EMask
	{
		Thermal = 0,
		Anvis = 1,
		Binocular = 2,
		GasMask = 3,
		OldMonocular = 4,
	}

	public readonly INightVisionComponentTemplate Template; //Field offset: 0x18
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

	public NightVisionComponent(Item item, INightVisionComponentTemplate template, TogglableComponent togglable) { }

	private override ITogglableComponent EFT.InventoryLogic.ITogglableComponentContainer.get_Togglable() { }

	[CompilerGenerated]
	public override TogglableComponent get_Togglable() { }

}

