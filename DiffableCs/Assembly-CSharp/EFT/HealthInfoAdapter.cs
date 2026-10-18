namespace EFT;

public sealed class HealthInfoAdapter : IBaseHealthController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__14_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetBodyPartHealth>b__14_0(BodyPartInfo part) { }

		internal float <GetBodyPartHealth>b__14_1(BodyPartInfo part) { }

	}

	[CompilerGenerated]
	private readonly ValueStruct <Hydration>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ValueStruct <Energy>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly ValueStruct <Temperature>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ValueStruct <Poison>k__BackingField; //Field offset: 0x4C
	private readonly HealthInfo _healthInfo; //Field offset: 0x60
	private ValueStruct _health; //Field offset: 0x68

	public override ValueStruct Energy
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	public override ValueStruct Hydration
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	public override ValueStruct Poison
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	public override ValueStruct Temperature
	{
		[CompilerGenerated]
		 get { } //Length: 17
	}

	public HealthInfoAdapter(HealthInfo healthInfo) { }

	[CompilerGenerated]
	public override ValueStruct get_Energy() { }

	[CompilerGenerated]
	public override ValueStruct get_Hydration() { }

	[CompilerGenerated]
	public override ValueStruct get_Poison() { }

	[CompilerGenerated]
	public override ValueStruct get_Temperature() { }

	public override ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false) { }

}

