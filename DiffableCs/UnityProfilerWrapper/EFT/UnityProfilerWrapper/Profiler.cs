namespace EFT.UnityProfilerWrapper;

public static class Profiler
{
	[IsReadOnly]
	private struct Marker
	{
		public readonly string MarkerName; //Field offset: 0x0
		public readonly string CallerMemberName; //Field offset: 0x8

		public Marker(string markerName, string callerMemberName) { }

		public virtual string ToString() { }

	}

	internal struct ReleaseToken : IDisposable
	{

		public override void Dispose() { }

	}

	internal struct Token : IDisposable
	{

		public override void Dispose() { }

	}

	private static readonly Stack _markers; //Field offset: 0x0
	private static int _currentFrame; //Field offset: 0x8

	public static bool enabled
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	private static bool IsMainThread
	{
		private get { } //Length: 104
	}

	private static Profiler() { }

	[Conditional("DEBUG")]
	public static void BeginSample(string name, string callerMemberName = "") { }

	[Conditional("PROFILER_MARKERS_DEBUG")]
	private static void BeginSampleDebug(string name, string callerMemberName) { }

	[Conditional("DEBUG")]
	public static void BeginSampleDouble(string name1, string name2, string callerMemberName = "") { }

	[Conditional("DEBUG")]
	public static void BeginSampleInMainThread(string name) { }

	[Conditional("DEBUG")]
	private static void BeginSampleInternal(string name, string callerMemberName) { }

	public static Token BeginSampleWithToken(string name, string callerMemberName = "") { }

	[Conditional("PROFILER_MARKERS_DEBUG")]
	private static void CheckFrameChange() { }

	[Conditional("DEBUG")]
	public static void EndSample(bool ignoreInconsistency = false, string callerMemberName = "") { }

	[Conditional("PROFILER_MARKERS_DEBUG")]
	private static void EndSampleDebug(string callerMemberName, bool ignoreInconsistency) { }

	[Conditional("DEBUG")]
	public static void EndSampleDouble(string callerMemberName = "") { }

	[Conditional("DEBUG")]
	private static void EndSampleInternal(bool ignoreInconsistency, string callerMemberName) { }

	[Conditional("DEBUG")]
	public static void EndSampleIsMainThread() { }

	public static bool get_enabled() { }

	private static bool get_IsMainThread() { }

	[Conditional("PROFILER_MARKERS_DEBUG")]
	private static void OnFrameChanged() { }

	public static void ReleaseBeginSample(string name, string callerMemberName = "") { }

	public static ReleaseToken ReleaseBeginSampleWithToken(string name, string callerMemberName = "") { }

	[Conditional("ENABLE_RELEASE_PROFILER")]
	public static void ReleaseEndSample(bool ignoreInconsistency = false, string callerMemberName = "") { }

	public static void set_enabled(bool value) { }

}

