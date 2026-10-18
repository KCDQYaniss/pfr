//Type is in global namespace

public class InteractiveSubscriber : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public PlaySettings sound; //Field offset: 0x10
		public BetterSource newSource; //Field offset: 0x18
		public InteractiveSubscriber <>4__this; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <PlayLoopingSound>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public PlaySettings sound; //Field offset: 0x10
		public InteractiveSubscriber <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <PlayOneShotSound>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public BetterSource sourceToStop; //Field offset: 0x10
		public PlaySettings sound; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <StopSound>b__0() { }

		internal void <StopSound>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Coroutine c; //Field offset: 0x10
		public InteractiveSubscriber <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <ViewsSetActive>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public Coroutine c; //Field offset: 0x10
		public InteractiveSubscriber <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_1() { }

		internal void <ViewsSetActive>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <SetActiveToContents>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Transform parent; //Field offset: 0x20
		public bool isActive; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

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
		public <SetActiveToContents>d__14(int <>1__state) { }

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
	private sealed class <Spin>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Transform t; //Field offset: 0x20
		public Vector3 spin; //Field offset: 0x28

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
		public <Spin>d__16(int <>1__state) { }

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

	internal class PlaySettings
	{
		public AudioClip Clip; //Field offset: 0x10
		public bool Loop; //Field offset: 0x18
		public float Volume; //Field offset: 0x1C
		public int MaxDistance; //Field offset: 0x20
		public float SpatialBlend; //Field offset: 0x24
		public AnimationCurve CustomCurve; //Field offset: 0x28
		public AnimationCurve SpreadCurve; //Field offset: 0x30
		public float StartDelay; //Field offset: 0x38
		public float EndDelay; //Field offset: 0x3C
		public float FadeOut; //Field offset: 0x40
		public float FadeIn; //Field offset: 0x44
		[EnumBitMask(typeof(EDoorState))]
		public EDoorState State; //Field offset: 0x48
		[EnumBitMask(typeof(EDoorState))]
		[Header("vvv For one shot sounds only vvv")]
		public EDoorState FromState; //Field offset: 0x49
		public Transform[] AdditionalPositions; //Field offset: 0x50
		public bool EnableAudioCulling; //Field offset: 0x58
		public bool Spatialize; //Field offset: 0x59
		public EOcclusionTest occlusionTest; //Field offset: 0x5C
		public AudioSourceGroupType groupType; //Field offset: 0x60
		[CompilerGenerated]
		private BetterSource <Source>k__BackingField; //Field offset: 0x68

		public BetterSource Source
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public PlaySettings() { }

		[CompilerGenerated]
		public BetterSource get_Source() { }

		[CompilerGenerated]
		public void set_Source(BetterSource value) { }

	}

	internal class ViewPerState
	{
		[EnumBitMask(typeof(EDoorState))]
		public EDoorState State; //Field offset: 0x10
		public GameObject GameObject; //Field offset: 0x18
		public bool EnableDisable; //Field offset: 0x20
		public bool EnableContentInCoroutine; //Field offset: 0x21
		public Vector3 Spin; //Field offset: 0x24

		public ViewPerState() { }

	}

	public WorldInteractiveObject Subscribee; //Field offset: 0x20
	public QueuePlayer QueuePlayer; //Field offset: 0x28
	public ViewPerState[] Views; //Field offset: 0x30
	public PlaySettings[] Sounds; //Field offset: 0x38
	private Action _cancelWorkingCoroutines; //Field offset: 0x40

	public InteractiveSubscriber() { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	protected override void OnStatusChangedHandler(WorldInteractiveObject subscribee, EDoorState previous, EDoorState next) { }

	private void PlayLoopingSound(PlaySettings sound) { }

	private void PlayOneShotSound(EDoorState fromState, PlaySettings sound) { }

	public void PlaySounds(EDoorState fromState, EDoorState state) { }

	[IteratorStateMachine(typeof(<SetActiveToContents>d__14))]
	private IEnumerator SetActiveToContents(Transform parent, bool isActive) { }

	[IteratorStateMachine(typeof(<Spin>d__16))]
	private IEnumerator Spin(Transform t, Vector3 spin) { }

	public override void Start() { }

	private void StopSound(PlaySettings sound) { }

	public override void ViewsSetActive(EDoorState state) { }

}

