namespace EFT.UI;

[Extension]
public static class UISetExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindSetMethod>b__11_0(MethodInfo t) { }

	}

	private const string SET_METHOD_NAME = "Set"; //Field offset: 0x0
	private const int SET_PARAMETERS_LENGTH = 2; //Field offset: 0x0
	private static readonly MethodInfo toggleSetMethod; //Field offset: 0x0
	private static readonly MethodInfo sliderSetMethod; //Field offset: 0x8
	private static readonly MethodInfo scrollbarSetMethod; //Field offset: 0x10
	private static readonly FieldInfo dropdownValueField; //Field offset: 0x18

	private static UISetExtensions() { }

	[CanBeNull]
	private static MethodInfo FindSetMethod(Type objectType) { }

	[Extension]
	public static void Set(Toggle instance, bool value, bool sendCallback = false) { }

	[Extension]
	public static void Set(Slider instance, float value, bool sendCallback = false) { }

	[Extension]
	public static void Set(Scrollbar instance, float value, bool sendCallback = false) { }

	[Extension]
	public static void Set(Dropdown instance, int value) { }

}

