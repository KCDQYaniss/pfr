namespace EFT.UI;

public sealed class TMP_FPSCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Co_ExtendedCounters>d__97 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_FPSCounter <>4__this; //Field offset: 0x20

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
		public <Co_ExtendedCounters>d__97(int <>1__state) { }

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
	private sealed class <Co_FpsAndLimitCounters>d__95 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_FPSCounter <>4__this; //Field offset: 0x20

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
		public <Co_FpsAndLimitCounters>d__95(int <>1__state) { }

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
	private sealed class <Co_NetworkCounters>d__96 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_FPSCounter <>4__this; //Field offset: 0x20

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
		public <Co_NetworkCounters>d__96(int <>1__state) { }

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
	private sealed class <Co_WebsocketCounters>d__98 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_FPSCounter <>4__this; //Field offset: 0x20

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
		public <Co_WebsocketCounters>d__98(int <>1__state) { }

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
	private sealed class <PerformanceTest>d__104 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TMP_FPSCounter <>4__this; //Field offset: 0x20
		public int overall; //Field offset: 0x28
		public int every; //Field offset: 0x2C
		public string label; //Field offset: 0x30
		public Action onTestComplete; //Field offset: 0x38
		private float <endTime>5__2; //Field offset: 0x40
		private WaitForSeconds <waitForSeconds>5__3; //Field offset: 0x48

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
		public <PerformanceTest>d__104(int <>1__state) { }

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

	private sealed class CounterLevel
	{
		public readonly float Width; //Field offset: 0x10
		private readonly MonoBehaviour _parent; //Field offset: 0x18
		private readonly Func _routineGenerator; //Field offset: 0x20
		private Coroutine _startedRoutine; //Field offset: 0x28

		public CounterLevel(MonoBehaviour parent, Func routineGenerator, float width) { }

		public void Start() { }

		public void Stop() { }

	}

	private const long BYTES_IN_MB = 1048576; //Field offset: 0x0
	private const float AUTO_STOP_TIME = 2; //Field offset: 0x0
	private const int GRAPH_HEIGHT = 50; //Field offset: 0x0
	private const int GRAPH_WIDTH = 300; //Field offset: 0x0
	private const float WS_CONN_UPDATE_INTERVAL = 0.1; //Field offset: 0x0
	private const int TICK_LENGTH = 1; //Field offset: 0x0
	private const int LINE_SIZE = 4; //Field offset: 0x0
	[Header("UI Components")]
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI _fpsCounterLabel; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI _fpsMaxCounterLabel; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI _rttTimeCounterLabel; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI _serverFixedUpdateCounterLabel; //Field offset: 0x40
	[SerializeField]
	private TextMeshProUGUI _serverTimeDiffCounterLabel; //Field offset: 0x48
	[Header("Extended Panel Labels")]
	[SerializeField]
	private GameObject _extendedLabelsPanel; //Field offset: 0x50
	[SerializeField]
	private TextMeshProUGUI _averageFpsLabel; //Field offset: 0x58
	[SerializeField]
	private TextMeshProUGUI _onePercentLowLabel; //Field offset: 0x60
	[SerializeField]
	private TextMeshProUGUI _fixedUpdateFpsLabel; //Field offset: 0x68
	[SerializeField]
	private TextMeshProUGUI _averageFixedUpdateFpsLabel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _singleFixedUpdateFpsLabel; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _fixedUpdateBetweenUpdatesLabel; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _updateMeasurerLabel; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _gameUpdateLabel; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _renderMsLabel; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _frameMsLabel; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _distantShadowObjectsLabel; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI LocalVRamTotal; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI LocalVRamUsage; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI MaxLocalVRamUsage; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI TotalLocalVRam; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI DiskUsage; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI DiskRead; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI DiskWrite; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI VirtualMemoryBytes; //Field offset: 0xE8
	[SerializeField]
	private TextMeshProUGUI GpuUtilization; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _networkRttLabel; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _networkLossLabel; //Field offset: 0x100
	[SerializeField]
	private TextMeshProUGUI _bufferCountLabel; //Field offset: 0x108
	[SerializeField]
	private TextMeshProUGUI _cameraPositionLabel; //Field offset: 0x110
	[SerializeField]
	private TextMeshProUGUI _desiredTextureMemory; //Field offset: 0x118
	[SerializeField]
	private TextMeshProUGUI _totalMemoryReserved; //Field offset: 0x120
	[SerializeField]
	private RawImage _uiGraphImage; //Field offset: 0x128
	[Header("WebSocket Counters")]
	[SerializeField]
	private GameObject _webSocketLabelsPanel; //Field offset: 0x130
	[SerializeField]
	private TextMeshProUGUI _webSocketConnStatus; //Field offset: 0x138
	[SerializeField]
	private TextMeshProUGUI _webSocketCloseStatusCode; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI _webSocketConnIsAlive; //Field offset: 0x148
	[SerializeField]
	private TextMeshProUGUI _webSocketRequestsInProgressCount; //Field offset: 0x150
	private readonly Color32 _graphBackgroundColor; //Field offset: 0x158
	private readonly Color32 _graphBarColor; //Field offset: 0x15C
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private bool <ShowGraphs>k__BackingField; //Field offset: 0x161
	private bool _showUiGraph; //Field offset: 0x162
	private FrameMeasurer _frameMeasurer; //Field offset: 0x168
	private IMeasureStatistics _singleFixedUpdateStatistics; //Field offset: 0x170
	private IMeasureStatistics _fixedUpdateBetweenUpdatesStatistics; //Field offset: 0x178
	private IMeasureStatistics _updateMeasurerStatistics; //Field offset: 0x180
	private IMeasureStatistics _renderMeasurerStatistics; //Field offset: 0x188
	private IMeasureStatistics _frameMeasurerStatistics; //Field offset: 0x190
	private IMeasureStatistics _gameUpdateStatistics; //Field offset: 0x198
	private IMeasureStatistics _fpsMeasureStatistics; //Field offset: 0x1A0
	private IMeasureStatistics _fixedUpdatesPerFrameStatistics; //Field offset: 0x1A8
	private IMeasureStatistics _GPUUtilizationStatistics; //Field offset: 0x1B0
	private IMeasureStatistics _diskIdleStatistics; //Field offset: 0x1B8
	private IMeasureStatistics _diskReadBytesStatistics; //Field offset: 0x1C0
	private IMeasureStatistics _diskWriteBytesStatistics; //Field offset: 0x1C8
	private IMeasureStatistics _privateBytesStatistics; //Field offset: 0x1D0
	private IMeasureStatistics _desiredTextureMemoryStatistics; //Field offset: 0x1D8
	private bool _isPerfTestRunning; //Field offset: 0x1E0
	private float _notFetchPerfCountersTime; //Field offset: 0x1E4
	private AvgMeasurer GPUUtilizationMeasurer; //Field offset: 0x1E8
	private AvgMeasurer DiskIdleMeasurer; //Field offset: 0x1F0
	private AvgMeasurer DiskReadBytesMeasurer; //Field offset: 0x1F8
	private AvgMeasurer DiskWriteBytesMeasurer; //Field offset: 0x200
	private AvgMeasurer PrivateBytesMeasurer; //Field offset: 0x208
	private AvgMeasurer DesiredTextureMemoryMeasurer; //Field offset: 0x210
	private CounterLevel[] _levels; //Field offset: 0x218
	private Texture2D _uiGraphTexture; //Field offset: 0x220
	private Color32[] _uiGraphPixels; //Field offset: 0x228
	private float[] _fpsHistory; //Field offset: 0x230
	private int _fpsHistoryIndex; //Field offset: 0x238
	private float[] _sortedFps; //Field offset: 0x240
	private float _onePercentLow; //Field offset: 0x248
	private readonly StringBuilder _stringBuilder; //Field offset: 0x250
	private readonly WaitForSeconds _wsOneSecond; //Field offset: 0x258
	private readonly WaitForSeconds _wsConnUpdate; //Field offset: 0x260
	private readonly List _performanceData; //Field offset: 0x268
	private readonly object _lockObject; //Field offset: 0x270

	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool ShowGraphs
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public TMP_FPSCounter() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<Co_ExtendedCounters>d__97))]
	private IEnumerator Co_ExtendedCounters() { }

	[IteratorStateMachine(typeof(<Co_FpsAndLimitCounters>d__95))]
	private IEnumerator Co_FpsAndLimitCounters() { }

	[IteratorStateMachine(typeof(<Co_NetworkCounters>d__96))]
	private IEnumerator Co_NetworkCounters() { }

	[IteratorStateMachine(typeof(<Co_WebsocketCounters>d__98))]
	private IEnumerator Co_WebsocketCounters() { }

	[CompilerGenerated]
	public bool get_Active() { }

	[CompilerGenerated]
	public bool get_ShowGraphs() { }

	public void GetPerformanceState(out double fpsMeasure, out double gameUpdate, out double renderMeasurer, out double frameMeasurer, out double diskIdleMeasurer, out double diskReadBytesMeasurer, out double diskWriteBytesMeasurer, out double localVRAMUsageMBytes, out double privateMemMBytes, out double desiredTextureMemoryMBytes, out double totalReservedMemory, out double gpuUtilization) { }

	public void Hide() { }

	private void InitGraph(int level) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<PerformanceTest>d__104))]
	public IEnumerator PerformanceTest(int overall, int every, string label = "label", Action onTestComplete = null) { }

	private void RenderFpsGraph() { }

	private void RenderFrameTimeGraph() { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	[CompilerGenerated]
	public void set_ShowGraphs(bool value) { }

	public void Show(int level) { }

}

