namespace EFT;

public sealed class DamageHistory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DamageStats <.ctor>b__3_0(DamageStatsDescriptor damage) { }

	}

	public EBodyPart LethalDamagePart; //Field offset: 0x10
	[CanBeNull]
	public DamageStats LethalDamage; //Field offset: 0x18
	public readonly Dictionary BodyParts; //Field offset: 0x20

	public DamageHistory(DamageHistoryDescriptor descriptor) { }

	public void Clear() { }

}

