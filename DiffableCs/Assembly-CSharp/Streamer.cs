//Type is in global namespace

public class Streamer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8
		public static Func <>9__9_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal AsyncOperation <Unload>b__9_0(Chunk chunk) { }

		internal bool <Unload>b__9_1(AsyncOperation operation) { }

	}

	[CompilerGenerated]
	private sealed class <LoadChunkCoroutine>d__12 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Chunk chunk; //Field offset: 0x20
		private AsyncOperation <loadOperation>5__2; //Field offset: 0x28

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
		public <LoadChunkCoroutine>d__12(int <>1__state) { }

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
	private sealed class <LoadSceneCoroutine>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Streamer <>4__this; //Field offset: 0x20
		public Scene scene; //Field offset: 0x28
		private Chunk[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private Chunk[] <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48

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
		public <LoadSceneCoroutine>d__11(int <>1__state) { }

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
	private sealed class <Unload>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Scene scene; //Field offset: 0x20
		public Streamer <>4__this; //Field offset: 0x28
		private AsyncOperation[] <unloadOperations>5__2; //Field offset: 0x30

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
		public <Unload>d__9(int <>1__state) { }

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

	internal class Chunk
	{
		public string Name; //Field offset: 0x10
		public string Path; //Field offset: 0x18
		[HideInInspector]
		public LoadingState State; //Field offset: 0x20

		public Chunk() { }

		public Chunk(Scene scene) { }

	}

	internal enum LoadingState
	{
		Loading = 0,
		Loaded = 1,
		NotLoaded = 2,
	}

	internal class Scene
	{
		public const float DefaultDistance = 150; //Field offset: 0x0
		public string Name; //Field offset: 0x10
		public string Path; //Field offset: 0x18
		public Chunk[] Chunks; //Field offset: 0x20
		public float Distance; //Field offset: 0x28
		public GameObject[] LODs; //Field offset: 0x30
		[HideInInspector]
		public Bounds Bounds; //Field offset: 0x38
		[HideInInspector]
		public LoadingState State; //Field offset: 0x50
		[HideInInspector]
		public GameObject[] LODsInstances; //Field offset: 0x58
		[CompilerGenerated]
		private Vector2 <Distances>k__BackingField; //Field offset: 0x60

		public Vector2 Distances
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public Scene() { }

		public Scene(Scene scene, Bounds bounds, float distance) { }

		[CompilerGenerated]
		public Vector2 get_Distances() { }

		[CompilerGenerated]
		public void set_Distances(Vector2 value) { }

	}

	public Transform Player; //Field offset: 0x20
	[Range(0, 0.5)]
	public float Backlash; //Field offset: 0x28
	public int MaxPerformanceRaiting; //Field offset: 0x2C
	public Scene[] Scenes; //Field offset: 0x30
	private readonly Queue _loadScenesQueue; //Field offset: 0x38
	private readonly HashSet _unloadScenesQueue; //Field offset: 0x40
	private bool _coroutineExecuting; //Field offset: 0x48

	public Streamer() { }

	private void Awake() { }

	private void Load(Scene scene) { }

	[IteratorStateMachine(typeof(<LoadChunkCoroutine>d__12))]
	private IEnumerator LoadChunkCoroutine(Chunk chunk) { }

	[IteratorStateMachine(typeof(<LoadSceneCoroutine>d__11))]
	private IEnumerator LoadSceneCoroutine(Scene scene) { }

	[IteratorStateMachine(typeof(<Unload>d__9))]
	private IEnumerator Unload(Scene scene) { }

	private void Update() { }

}

