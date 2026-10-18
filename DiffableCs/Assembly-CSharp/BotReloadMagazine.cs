//Type is in global namespace

public class BotReloadMagazine : BotReload
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Weapon weapon; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <CanReload>b__0(Ammo ammo) { }

	}


	public BotReloadMagazine(BotOwner owner, Weapon weapon) { }

	public virtual bool CanReload(bool withCheckByPeriod, out Magazine foundMag, out List ammoForInternalReload) { }

}

