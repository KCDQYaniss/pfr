namespace EFT.Dialogs;

public sealed class SubServicePlayerLine : TraderDialogTextLine
{
	[CompilerGenerated]
	private readonly DialogLineTextConstructor <LineTextConstructor>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly EDialogLineIconType <IconType>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly IReadOnlyList <Actions>k__BackingField; //Field offset: 0x50
	private readonly InventoryController _inventoryController; //Field offset: 0x58
	private readonly TraderServiceAvailabilityData _serviceAvailabilityData; //Field offset: 0x60

	public virtual IReadOnlyList Actions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected virtual EDialogLineIconType IconType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual DialogLineTextConstructor LineTextConstructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SubServicePlayerLine(DialogLineTemplate template, IDialogContext context) { }

	private DialogLineTextConstructor CreateLineConstructor(string selectedSubServiceId) { }

	[CompilerGenerated]
	public virtual IReadOnlyList get_Actions() { }

	[CompilerGenerated]
	protected virtual EDialogLineIconType get_IconType() { }

	[CompilerGenerated]
	public virtual DialogLineTextConstructor get_LineTextConstructor() { }

	private static EDialogLineIconType GetSubServiceIconType(ETraderServiceType serviceDataServiceType) { }

}

