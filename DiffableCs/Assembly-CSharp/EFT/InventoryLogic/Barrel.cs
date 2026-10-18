namespace EFT.InventoryLogic;

public class Barrel : MasterMod
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__8_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BarrelTemplate template; //Field offset: 0x10
		public Barrel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal float <.ctor>b__0() { }

		internal string <.ctor>b__1() { }

	}


	public float CenterOfImpactMOA
	{
		 get { } //Length: 216
	}

	public virtual float CoolFactor
	{
		 get { } //Length: 81
	}

	public virtual float DurabilityBurnModificator
	{
		 get { } //Length: 81
	}

	public virtual float HeatFactor
	{
		 get { } //Length: 81
	}

	public Barrel(string id, BarrelTemplate template) { }

	public float get_CenterOfImpactMOA() { }

	public virtual float get_CoolFactor() { }

	public virtual float get_DurabilityBurnModificator() { }

	public virtual float get_HeatFactor() { }

}

