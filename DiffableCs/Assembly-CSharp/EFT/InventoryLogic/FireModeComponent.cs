namespace EFT.InventoryLogic;

public class FireModeComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public EFireMode fireMode; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <SetFireMode>b__0(EFireMode mode) { }

	}

	private readonly IFireModeComponentTemplate _template; //Field offset: 0x18
	public BindableEvent OnChanged; //Field offset: 0x20
	[Diffable]
	public EFireMode FireMode; //Field offset: 0x28

	public EFireMode[] AvailableEFireModes
	{
		 get { } //Length: 66
	}

	public int BurstShotsCount
	{
		 get { } //Length: 78
	}

	public FireModeComponent(Item item, IFireModeComponentTemplate template) { }

	public EFireMode[] get_AvailableEFireModes() { }

	public int get_BurstShotsCount() { }

	public EFireMode GetForceAutoFireMode() { }

	public EFireMode GetNextFireMode() { }

	public void SetFireMode(EFireMode fireMode) { }

}

