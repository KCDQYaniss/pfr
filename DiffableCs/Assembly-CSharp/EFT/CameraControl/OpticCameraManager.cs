namespace EFT.CameraControl;

public class OpticCameraManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <IE_PreWarm>d__51 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public OpticCameraManager <>4__this; //Field offset: 0x20

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
		public <IE_PreWarm>d__51(int <>1__state) { }

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

	private static readonly int _camTexId; //Field offset: 0x0
	public int OpticFinalResolution; //Field offset: 0x10
	private OpticComponentUpdater _opticUpdater; //Field offset: 0x18
	private StreamingController _streamingController; //Field offset: 0x20
	private PostProcessVolume _postProcessVolume; //Field offset: 0x28
	private PostProcessLayer _postProcessLayer; //Field offset: 0x30
	private ThermalVision _thermalVision; //Field offset: 0x38
	private Coroutine _warmUpRoutine; //Field offset: 0x40
	private RenderTexture _renderTexture; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnOpticEnabled; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnOpticDisabled; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnOpticChanged; //Field offset: 0x60
	[CompilerGenerated]
	private Camera <Camera>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private OpticSight <CurrentOpticSight>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private NightVision <NightVision>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private OpticRetrice <OpticRetrice>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnOpticManagerInitialized; //Field offset: 0x88

	public event Action OnOpticChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnOpticDisabled
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnOpticEnabled
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnOpticManagerInitialized
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private Camera Camera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private OpticSight CurrentOpticSight
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private bool IsAnyOpticCameraRendering
	{
		private get { } //Length: 203
	}

	public private NightVision NightVision
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int OpticNextRenderResolution
	{
		 get { } //Length: 164
	}

	public int OpticRenderResolution
	{
		 get { } //Length: 164
	}

	public private OpticRetrice OpticRetrice
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public OpticComponentUpdater Updater
	{
		 get { } //Length: 5
	}

	private static OpticCameraManager() { }

	public OpticCameraManager() { }

	[CompilerGenerated]
	public void add_OnOpticChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnOpticDisabled(Action value) { }

	[CompilerGenerated]
	public void add_OnOpticEnabled(Action value) { }

	[CompilerGenerated]
	public void add_OnOpticManagerInitialized(Action value) { }

	public void AttachToCamera(Camera camera) { }

	private void DisableCurrentOpticSight() { }

	public override void Dispose() { }

	private void EnableCurrentOpticSight(OpticSight opticSight) { }

	[CompilerGenerated]
	public Camera get_Camera() { }

	[CompilerGenerated]
	public OpticSight get_CurrentOpticSight() { }

	private bool get_IsAnyOpticCameraRendering() { }

	[CompilerGenerated]
	public NightVision get_NightVision() { }

	public int get_OpticNextRenderResolution() { }

	public int get_OpticRenderResolution() { }

	[CompilerGenerated]
	public OpticRetrice get_OpticRetrice() { }

	public OpticComponentUpdater get_Updater() { }

	[IteratorStateMachine(typeof(<IE_PreWarm>d__51))]
	private IEnumerator IE_PreWarm() { }

	public void Init() { }

	[CompilerGenerated]
	public void remove_OnOpticChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnOpticDisabled(Action value) { }

	[CompilerGenerated]
	public void remove_OnOpticEnabled(Action value) { }

	[CompilerGenerated]
	public void remove_OnOpticManagerInitialized(Action value) { }

	[CompilerGenerated]
	private void set_Camera(Camera value) { }

	[CompilerGenerated]
	private void set_CurrentOpticSight(OpticSight value) { }

	[CompilerGenerated]
	private void set_NightVision(NightVision value) { }

	[CompilerGenerated]
	private void set_OpticRetrice(OpticRetrice value) { }

	public void SetOpticSight(OpticSight opticSight) { }

	public void SetResolution(int resolution) { }

	public void SetSSR(bool ssrEnabled) { }

}

