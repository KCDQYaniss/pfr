//Type is in global namespace

public class DebugCoversChecker
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetPoint>b__6_0(CustomNavigationPoint x) { }

	}

	public bool IsStuck; //Field offset: 0x10
	public bool InEdnCompete; //Field offset: 0x11
	private List _points; //Field offset: 0x18
	private CustomNavigationPoint _lastPoint; //Field offset: 0x20
	private readonly BotOwner _owner; //Field offset: 0x28

	public DebugCoversChecker(BotOwner owner) { }

	[CompilerGenerated]
	private float <GetPoint>b__6_1(CustomNavigationPoint point) { }

	public void Dispose() { }

	public CustomNavigationPoint GetPoint(bool closest, bool withRemove) { }

	public void SetNewPoint() { }

	public void Stuck() { }

}

