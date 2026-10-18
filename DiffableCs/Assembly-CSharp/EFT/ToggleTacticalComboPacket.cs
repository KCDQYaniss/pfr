namespace EFT;

public struct ToggleTacticalComboPacket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__3_0(TacticalComboStatus x) { }

	}

	public bool ToggleTacticalCombo; //Field offset: 0x0
	public TacticalComboStatus[] TacticalComboStatuses; //Field offset: 0x8

	public static void Serialize(IBitStream stream, ref ToggleTacticalComboPacket packet) { }

	public virtual string ToString() { }

}

