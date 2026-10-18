namespace Unity.NativeProfiling;

public static class SimpleTraceMarkers
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public int level; //Field offset: 0x10
		public Type type; //Field offset: 0x18
		public PlayerLoopDelegate systemDelegate; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <PatchSystem>b__0() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class PlayerLoopDelegate : MulticastDelegate
	{

		public PlayerLoopDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	private static int m_LastLevel; //Field offset: 0x0
	private static SimpleProfiler _simpleProfiler; //Field offset: 0x8

	private static SimpleTraceMarkers() { }

	[Conditional("DEVELOPMENT_BUILD")]
	private static void Integrate() { }

	private static PlayerLoopSystem PatchSystem(PlayerLoopSystem system, int level, IntPtr nullFnc) { }

	private static void TraceMarker(int level, string name) { }

}

