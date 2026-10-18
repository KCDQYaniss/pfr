namespace EFT.InventoryLogic;

public sealed class HealthEffectsComponent : StimulatorBuffsComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__11_2() { }

	}

	private readonly IHealthEffectsComponentTemplate _template; //Field offset: 0x20

	public KeyValuePair[] BodyPartTimeMults
	{
		 get { } //Length: 202
	}

	public Dictionary DamageEffects
	{
		 get { } //Length: 203
	}

	public Dictionary HealthEffects
	{
		 get { } //Length: 203
	}

	public float UseTime
	{
		 get { } //Length: 75
	}

	private string UseTimeString
	{
		private get { } //Length: 223
	}

	public HealthEffectsComponent(Item item, IHealthEffectsComponentTemplate template) { }

	[CompilerGenerated]
	private string <.ctor>b__11_0() { }

	[CompilerGenerated]
	private string <.ctor>b__11_1() { }

	[CompilerGenerated]
	private bool <AffectsAny>b__12_0(EDamageEffectType type) { }

	public bool AffectsAny(EDamageEffectType[] effectTypes) { }

	public KeyValuePair[] get_BodyPartTimeMults() { }

	public Dictionary get_DamageEffects() { }

	public Dictionary get_HealthEffects() { }

	public float get_UseTime() { }

	private string get_UseTimeString() { }

	public float UseTimeFor(EBodyPart bodyPart) { }

}

