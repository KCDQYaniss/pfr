namespace EFT.Settings.Control;

public sealed class ControlSettingsGroup : SettingsGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__22_0; //Field offset: 0x8
		public static Func <>9__22_1; //Field offset: 0x10
		public static Func <>9__22_2; //Field offset: 0x18
		public static Func <>9__22_3; //Field offset: 0x20
		public static Func <>9__27_0; //Field offset: 0x28
		public static Func <>9__32_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__22_0(float value) { }

		internal float <.ctor>b__22_1(float value) { }

		internal float <.ctor>b__22_2(float value) { }

		internal float <.ctor>b__22_3(float value) { }

		internal InputSource <CreateVirtualControl>b__32_0(InputSource x) { }

		internal bool <GetKeyName>b__27_0(InputSource keyVariant) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static CopyItem <0>__CopyItem; //Field offset: 0x0
		public static EqualityCheck <1>__EqualityCheck; //Field offset: 0x8
		public static Func <2>__AxisBindingsPreProcessor; //Field offset: 0x10
		public static CopyItem <3>__CopyItem; //Field offset: 0x18
		public static EqualityCheck <4>__EqualityCheck; //Field offset: 0x20
		public static Func <5>__KeyBindingsPreProcessor; //Field offset: 0x28

	}

	public const float MOUSE_SENS_MIN = 0.1; //Field offset: 0x0
	public const float MOUSE_SENS_MAX = 5; //Field offset: 0x0
	public const float DOUBLE_CLICK_MIN = 0.3; //Field offset: 0x0
	public const float DOUBLE_CLICK_MAX = 1; //Field offset: 0x0
	public const float OPTIC_SENSITIVITY_MIN = 1; //Field offset: 0x0
	public const float OPTIC_SENSITIVITY_MAX = 5; //Field offset: 0x0
	public static readonly IReadOnlyList ReservedKeys; //Field offset: 0x0
	public readonly GameSetting InvertedXAxis; //Field offset: 0x18
	public readonly GameSetting InvertedYAxis; //Field offset: 0x20
	public readonly GameSetting MouseSensitivity; //Field offset: 0x28
	public readonly GameSetting MouseAimingSensitivity; //Field offset: 0x30
	public readonly GameSetting DoubleClickTimeout; //Field offset: 0x38
	public readonly GameSetting OpticSensitivity; //Field offset: 0x40
	[JsonProperty("axisBindings")]
	public readonly ListGameSetting UserAxisBindings; //Field offset: 0x48
	[JsonProperty("keyBindings")]
	public readonly ListGameSetting UserKeyBindings; //Field offset: 0x50
	[CompilerGenerated]
	private string <SystemMessageLocale>k__BackingField; //Field offset: 0x58
	private readonly List _generatedKeys; //Field offset: 0x60

	[JsonProperty]
	public string SystemMessage
	{
		 set { } //Length: 82
	}

	[JsonIgnore]
	public private string SystemMessageLocale
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static ControlSettingsGroup() { }

	public ControlSettingsGroup() { }

	[CompilerGenerated]
	internal static void <CreateMergedControl>g__PushInputSourceValues|31_1(InputSource source, InputSource target) { }

	[CompilerGenerated]
	internal static bool <CreateMergedControl>g__TryMergeVariants|31_0(KeyGroup group1, KeyGroup group2, ValueTuple index, out InputSource result) { }

	private static List AxisBindingsPreProcessor(List axisBindings) { }

	public virtual ControlSettingsGroup Clone() { }

	public void CreateMergedControl(EGameKey mergedControl, EGameKey control1, EGameKey control2) { }

	private void CreateVirtualControl(VirtualControlDescriptor descriptor) { }

	[CompilerGenerated]
	public string get_SystemMessageLocale() { }

	public KeyGroup[] GetAllKeyBindings() { }

	private static AxisGroup GetAxisGroup(List axisBindings, EAxis axisName) { }

	[CanBeNull]
	public string GetBoundItemNames(EBoundItem boundItem, bool shortFormat = false) { }

	private static KeyGroup GetKeyGroup(IReadOnlyList keyBindings, EGameKey keyName) { }

	[CanBeNull]
	public string GetKeyName(EGameKey key, bool shortFormat = false) { }

	private static List KeyBindingsPreProcessor(List keyBindings) { }

	public bool MergeAxisWithDefault(List defaultBindings) { }

	public bool MergeKeysWithDefault(List defaultBindings) { }

	private void RemoveKeyFromList(EGameKey toRemove) { }

	public void set_SystemMessage(string value) { }

	[CompilerGenerated]
	private void set_SystemMessageLocale(string value) { }

}

