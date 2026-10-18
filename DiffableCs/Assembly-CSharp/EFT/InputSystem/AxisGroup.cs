namespace EFT.InputSystem;

public sealed class AxisGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Converter <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AxisPair <Clone>b__6_0(AxisPair x) { }

	}

	internal sealed class AxisPair
	{
		public InputSource positive; //Field offset: 0x10
		public InputSource negative; //Field offset: 0x18

		public AxisPair() { }

		public AxisPair Clone() { }

	}

	public EAxis axisName; //Field offset: 0x10
	public List pairs; //Field offset: 0x18
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public bool isInverted; //Field offset: 0x20
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public float gravity; //Field offset: 0x24
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public bool snapToZero; //Field offset: 0x28

	public AxisGroup() { }

	public AxisGroup Clone() { }

	public static AxisGroup CopyItem(AxisGroup item) { }

	public static bool EqualityCheck(AxisGroup x, AxisGroup y) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(AxisGroup other) { }

	public virtual int GetHashCode() { }

}

