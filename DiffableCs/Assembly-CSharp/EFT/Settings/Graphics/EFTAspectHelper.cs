namespace EFT.Settings.Graphics;

[Extension]
internal static class EFTAspectHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <get_SortedAspectRatios>b__6_0(AspectRatio ratio) { }

	}

	private const float ASPECT_RATIO_THRESHOLD = 0.04; //Field offset: 0x0
	private static readonly AspectRatio[] _landscapeAspectRatios; //Field offset: 0x0
	private static readonly AspectRatio[] _portraitAspectRatios; //Field offset: 0x8

	internal static AspectRatio[] AvailableAspectRatios
	{
		internal get { } //Length: 618
	}

	internal static ReadOnlyCollection SortedAspectRatios
	{
		internal get { } //Length: 814
	}

	private static EFTAspectHelper() { }

	private static AspectRatio CalculateAspectRatio(int width, int height) { }

	private static bool CorrectAspectRatio(ref AspectRatio aspectRatio) { }

	private static bool CorrectNonStandardAspectRatio(ref AspectRatio aspectRatio, bool isLandscape) { }

	private static int Gcd(int a, int b) { }

	internal static AspectRatio[] get_AvailableAspectRatios() { }

	internal static ReadOnlyCollection get_SortedAspectRatios() { }

	private static HashSet GetAspectRatios(EftResolution[] resolutions) { }

	private static bool IsClose(in AspectRatio first, in AspectRatio second) { }

	[Extension]
	internal static AspectRatio SuitableAspectRatio(in EftResolution resolution) { }

}

