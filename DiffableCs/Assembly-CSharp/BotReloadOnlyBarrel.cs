//Type is in global namespace

public class BotReloadOnlyBarrel : BotReload
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public BotReloadOnlyBarrel <>4__this; //Field offset: 0x10
		public Magazine currentMagazine; //Field offset: 0x18
		public Weapon weapon; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal bool <CanReload>b__0(Ammo ammo) { }

		internal bool <CanReload>b__1(Ammo ammo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public BotReloadOnlyBarrel <>4__this; //Field offset: 0x10
		public int stockCount; //Field offset: 0x18
		public MongoID ammoToAdd; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <ReloadAmmo>b__0(IResult s) { }

		internal void <ReloadAmmo>b__1(IResult s) { }

		internal void <ReloadAmmo>b__2(IResult s) { }

	}


	public BotReloadOnlyBarrel(BotOwner owner, Weapon weapon) { }

	public virtual bool CanReload(bool withCheckByPeriod, out Magazine foundMag, out List ammoForInternalReload) { }

	protected virtual void ReloadAmmo(List foundAmmo) { }

}

