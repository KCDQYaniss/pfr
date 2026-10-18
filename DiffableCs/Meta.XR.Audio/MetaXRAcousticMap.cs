//Type is in global namespace

public class MetaXRAcousticMap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public ReadOnly data; //Field offset: 0x10
		public MetaXRAcousticMap <>4__this; //Field offset: 0x20
		public int result; //Field offset: 0x28

		public <>c__DisplayClass41_0() { }

		internal void <LoadMapFromMemoryAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_1
	{
		public Action delayedEnable; //Field offset: 0x10
		public <>c__DisplayClass41_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass41_1() { }

		internal void <LoadMapFromMemoryAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <LoadGeometry>d__35 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MetaXRAcousticMap <>4__this; //Field offset: 0x20
		private MetaXRAcousticGeometry[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private MetaXRAcousticGeometry <ag>5__4; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadGeometry>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadMapAsync>d__38 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string streamingAssetsSubPath; //Field offset: 0x20
		public MetaXRAcousticMap <>4__this; //Field offset: 0x28
		private string <path>5__2; //Field offset: 0x30
		private float <startTime>5__3; //Field offset: 0x38
		private Task <readTask>5__4; //Field offset: 0x40
		private Exception <error>5__5; //Field offset: 0x48
		private byte[] <mapData>5__6; //Field offset: 0x50
		private NativeArray <nativeArray>5__7; //Field offset: 0x58
		private Task <loadTask>5__8; //Field offset: 0x68

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadMapAsync>d__38(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadMapFromMemoryAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ReadOnly data; //Field offset: 0x20
		public MetaXRAcousticMap <>4__this; //Field offset: 0x30
		private <>c__DisplayClass41_0 <>8__1; //Field offset: 0x38
		private float <startTime>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFileAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private FileStream <fs>5__2; //Field offset: 0x30
		private long <length>5__3; //Field offset: 0x38
		private byte[] <buffer>5__4; //Field offset: 0x40
		private int <offset>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal const string FILE_EXTENSION = "xramap"; //Field offset: 0x0
	public static bool DrawGizmosEnabled; //Field offset: 0x0
	internal const float DISTANCE_PARAMETER_MAX = 10000; //Field offset: 0x0
	internal const int Success = 0; //Field offset: 0x0
	[SerializeField]
	internal MetaXRAcousticSceneGroup SceneGroup; //Field offset: 0x20
	[SerializeField]
	internal bool customPointsEnabled; //Field offset: 0x28
	internal bool IsLoaded; //Field offset: 0x29
	[SerializeField]
	internal AcousticMapFlags Flags; //Field offset: 0x2C
	[SerializeField]
	internal uint ReflectionCount; //Field offset: 0x30
	[Range(0, 10000)]
	[SerializeField]
	internal float MinSpacing; //Field offset: 0x34
	[Range(0, 10000)]
	[SerializeField]
	internal float MaxSpacing; //Field offset: 0x38
	[Range(0, 10000)]
	[SerializeField]
	internal float HeadHeight; //Field offset: 0x3C
	[Range(0, 10000)]
	[SerializeField]
	internal float MaxHeight; //Field offset: 0x40
	[SerializeField]
	private Vector3 gravityVector; //Field offset: 0x44
	[FormerlySerializedAs("relativeFilePath_")]
	[SerializeField]
	private string relativeFilePath; //Field offset: 0x50
	internal IntPtr mapHandle; //Field offset: 0x58
	private Coroutine _loadCoroutine; //Field offset: 0x60
	private CancellationTokenSource _loadTokenSource; //Field offset: 0x68

	internal string AbsoluteFilePath
	{
		internal get { } //Length: 268
		internal set { } //Length: 685
	}

	internal bool Diffraction
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal Vector3 GravityVector
	{
		internal get { } //Length: 19
		internal set { } //Length: 40
	}

	internal bool NoFloating
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal string RelativeFilePath
	{
		internal get { } //Length: 5
	}

	internal bool StaticOnly
	{
		internal get { } //Length: 7
		internal set { } //Length: 25
	}

	public MetaXRAcousticMap() { }

	private void ApplyTransform() { }

	public void CancelLoad() { }

	internal void DestroyInternal() { }

	internal string get_AbsoluteFilePath() { }

	internal bool get_Diffraction() { }

	internal Vector3 get_GravityVector() { }

	internal bool get_NoFloating() { }

	internal string get_RelativeFilePath() { }

	internal bool get_StaticOnly() { }

	private void LateUpdate() { }

	[IteratorStateMachine(typeof(<LoadGeometry>d__35))]
	private IEnumerator LoadGeometry() { }

	[IteratorStateMachine(typeof(<LoadMapAsync>d__38))]
	private IEnumerator LoadMapAsync(string streamingAssetsSubPath) { }

	[AsyncStateMachine(typeof(<LoadMapFromMemoryAsync>d__41))]
	private Task LoadMapFromMemoryAsync(ReadOnly data) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[AsyncStateMachine(typeof(<ReadFileAsync>d__39))]
	private Task ReadFileAsync(string path, CancellationToken token) { }

	internal void set_AbsoluteFilePath(string value) { }

	internal void set_Diffraction(bool value) { }

	internal void set_GravityVector(Vector3 value) { }

	internal void set_NoFloating(bool value) { }

	internal void set_StaticOnly(bool value) { }

	private void Start() { }

	internal void StartInternal(bool autoLoad = true) { }

}

