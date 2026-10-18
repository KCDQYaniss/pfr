namespace EFT.Expansions;

[IsReadOnly]
public struct ExpansionsShopNotificationEffects
{
	[CompilerGenerated]
	private readonly bool <GameEditionUpgrade>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <CustomizationUpdate>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	private readonly bool <ProfileReload>k__BackingField; //Field offset: 0x2
	[CompilerGenerated]
	private readonly bool <FullReload>k__BackingField; //Field offset: 0x3

	public bool CustomizationUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool FullReload
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool GameEditionUpgrade
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool ProfileReload
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private ExpansionsShopNotificationEffects(bool gameEditionUpgrade, bool customizationUpdate, bool profileReload, bool fullReload) { }

	[CompilerGenerated]
	public bool get_CustomizationUpdate() { }

	[CompilerGenerated]
	public bool get_FullReload() { }

	[CompilerGenerated]
	public bool get_GameEditionUpgrade() { }

	[CompilerGenerated]
	public bool get_ProfileReload() { }

	public static ExpansionsShopNotificationEffects Resolve(ExpansionsShopNotificationData data) { }

}

