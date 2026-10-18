namespace EFT.InputSystem;

public sealed class KeyGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Converter <>9__7_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal InputSource <Clone>b__7_0(InputSource x) { }

		internal bool <get_PressTypeAvailable>b__6_0(InputSource keyVariant) { }

	}

	public EGameKey keyName; //Field offset: 0x10
	public List variants; //Field offset: 0x18
	public EPressType pressType; //Field offset: 0x20
	[DefaultValue(True)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public bool pressAvailable; //Field offset: 0x24
	public bool IgnorePool; //Field offset: 0x25

	[JsonIgnore]
	public bool PressTypeAvailable
	{
		 get { } //Length: 354
	}

	public KeyGroup() { }

	[CompilerGenerated]
	internal static InputSource <Create>g__GetSource|13_0(KeyCode keyCode) { }

	public KeyGroup Clone() { }

	public static KeyGroup CopyItem(KeyGroup item) { }

	public static KeyGroup Create(EGameKey gameKey, EPressType press, KeyCode main, Nullable alt = null) { }

	public static KeyGroup CreateFrom(KeyGroup source, EGameKey gameKey, EPressType pressType, bool ignorePool) { }

	public static bool EqualityCheck(KeyGroup x, KeyGroup y) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(KeyGroup other) { }

	public bool get_PressTypeAvailable() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

