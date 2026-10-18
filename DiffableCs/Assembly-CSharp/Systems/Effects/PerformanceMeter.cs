namespace Systems.Effects;

public static class PerformanceMeter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__6_0() { }

	}

	internal enum PerfRating
	{
		FPS4 = 0,
		FPS16 = 1,
		FPS24 = 2,
		FPS36 = 3,
		FPS60 = 4,
		FPS100 = 5,
		FPS200 = 6,
	}

	[CompilerGenerated]
	private static Action OnFPSChange; //Field offset: 0x0
	private static Dictionary _lines; //Field offset: 0x8
	private static float _nextUpdateTime; //Field offset: 0x10
	private static float _fpsSum; //Field offset: 0x14
	[CompilerGenerated]
	private static PerfRating <PerformanceRating>k__BackingField; //Field offset: 0x18
	private static float[] _fpsMin; //Field offset: 0x20
	private static float[] _fpsMax; //Field offset: 0x28

	public static event Action OnFPSChange
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public private static PerfRating PerformanceRating
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 88
	}

	private static PerformanceMeter() { }

	[CompilerGenerated]
	public static void add_OnFPSChange(Action value) { }

	private static void AddLog(string n, object t) { }

	[CompilerGenerated]
	public static PerfRating get_PerformanceRating() { }

	public static Dictionary GetSystemInfo() { }

	[CompilerGenerated]
	public static void remove_OnFPSChange(Action value) { }

	[CompilerGenerated]
	private static void set_PerformanceRating(PerfRating value) { }

	private static void Update() { }

}

