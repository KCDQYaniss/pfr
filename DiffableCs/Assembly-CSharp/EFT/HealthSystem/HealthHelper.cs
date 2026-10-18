namespace EFT.HealthSystem;

[Extension]
public static class HealthHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__14_0(EBodyPart bp) { }

		internal bool <ExtractEffectInterface>b__5_0(Type type) { }

		internal bool <ExtractEffectInterface>b__5_2(Type type1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public IHealthEffect effect; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal float <GetDisplayVariation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public IHealthEffect effect; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <ExtractEffectInterface>b__1(Type type) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass5_1() { }

		internal bool <ExtractEffectInterface>b__3(Type type2) { }

	}

	internal static class EffectActivator`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal bool <.cctor>b__4_0(Type t) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public string effectType; //Field offset: 0x0
			public ConstructorInfo constructor; //Field offset: 0x0

			public <>c__DisplayClass3_0() { }

			internal bool <MakeConstructor>b__0(Type t) { }

			internal object <MakeConstructor>b__1() { }

		}

		private static readonly Dictionary _constructors; //Field offset: 0x0
		private static readonly Type[] _effectTypes; //Field offset: 0x0

		private static EffectActivator`1() { }

		public static object Create(string effectType) { }

		private static Func MakeConstructor(string effectType) { }

	}

	internal static class EffectTypeCode
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal bool <.cctor>b__5_0(Type t) { }

			internal string <.cctor>b__5_1(Type t) { }

			internal string <.cctor>b__5_2(Type t) { }

			internal byte <.cctor>b__5_3(Type t) { }

			internal byte <.cctor>b__5_4(KeyValuePair kv) { }

			internal string <.cctor>b__5_5(KeyValuePair kv) { }

		}

		private static readonly Type[] _effectTypes; //Field offset: 0x0
		private static readonly Dictionary _typeToByte; //Field offset: 0x8
		private static readonly Dictionary _byteToType; //Field offset: 0x10

		private static EffectTypeCode() { }

		public static byte Make(IHealthEffect effect) { }

		public static string Resolve(byte effectType) { }

	}

	public static readonly IReadOnlyList AllBodyParts; //Field offset: 0x0
	public static readonly IReadOnlyList RealBodyParts; //Field offset: 0x8
	public static readonly IReadOnlyList VitalBodyParts; //Field offset: 0x10
	public static readonly IReadOnlyList DamageEffectTypes; //Field offset: 0x18
	private static readonly Dictionary _typesOfEffects; //Field offset: 0x20
	private static readonly Dictionary _effectNames; //Field offset: 0x28

	private static HealthHelper() { }

	public static string EffectName(IHealthEffect effect) { }

	public static Type ExtractEffectInterface(IHealthEffect effect) { }

	[Extension]
	public static bool FromBodyPart(IHealthEffect effect, EBodyPart bodyPart) { }

	public static EffectDescription[] GetDisplayVariation(IHealthEffect effect, bool exactTime) { }

	[Extension]
	public static bool IsVital(EBodyPart bodyPart) { }

	public static bool TryGetDamageEffectType(Type type, out EDamageEffectType effectType) { }

}

