//Type is in global namespace

public sealed class BotReloadRevolver : BotReload
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string templateId; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal bool <AddAmmoToPocketsSingleAmmoStack>b__0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BotReloadRevolver <>4__this; //Field offset: 0x10
		public Magazine currentMagazine; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal bool <CanReload>b__0(Ammo ammo) { }

	}

	private const float TRY_RELOAD_PERIOD = 1.3; //Field offset: 0x0
	private int _ammoMaxStackCount; //Field offset: 0x50
	private bool _ammoInited; //Field offset: 0x54
	private Dictionary _defaultAmmoInInventory; //Field offset: 0x58
	private Dictionary _searchCache; //Field offset: 0x60
	private float _prevTryReloadTime; //Field offset: 0x68

	public BotReloadRevolver(BotOwner owner, Weapon weapon) { }

	protected virtual void AddAmmoToPockets(string templateId, int targetCount) { }

	private void AddAmmoToPocketsSingleAmmoStack(string templateId, int targetCount) { }

	public virtual bool CanReload(bool withCheckByPeriod, out Magazine foundMag, out List ammoForInternalReload) { }

	public virtual void ManualUpdate() { }

	private void TryInitAmmo(Magazine foundMag, List ammoList) { }

}

