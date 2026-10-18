namespace Coffee.UISoftMaskInternal;

internal static class MaterialRepository
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"shaderName", "keywords"})]
		public static Func <>9__6_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Material <Get>b__5_0(string x) { }

		internal Material <Get>b__6_0(ValueTuple x) { }

	}

	private static readonly ObjectRepository s_Repository; //Field offset: 0x0

	public static int count
	{
		 get { } //Length: 125
	}

	private static MaterialRepository() { }

	public static void Get(Hash128 hash, ref Material material, Func onCreate) { }

	public static void Get(Hash128 hash, ref Material material, string shaderName) { }

	public static void Get(Hash128 hash, ref Material material, string shaderName, string[] keywords) { }

	public static void Get(Hash128 hash, ref Material material, Func onCreate, T source) { }

	public static int get_count() { }

	public static void Release(ref Material material) { }

	public static bool Valid(Hash128 hash, Material material) { }

}

