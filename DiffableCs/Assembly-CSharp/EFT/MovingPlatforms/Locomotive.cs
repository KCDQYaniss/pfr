namespace EFT.MovingPlatforms;

public class Locomotive : MovingPlatform
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__49_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <CalculateLength>b__49_0(Keyframe x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public float maxDistance; //Field offset: 0x10
		public Locomotive <>4__this; //Field offset: 0x18

		public <>c__DisplayClass49_0() { }

		internal bool <CalculateLength>b__1(Keyframe x) { }

		internal bool <CalculateLength>b__2(Keyframe x) { }

		internal bool <CalculateLength>b__3(Keyframe x) { }

	}

	[CompilerGenerated]
	private sealed class <FadeIn>d__38 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Locomotive <>4__this; //Field offset: 0x20
		public SoundEvent sound; //Field offset: 0x28
		private AudioSource <source>5__2; //Field offset: 0x30

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
		public <FadeIn>d__38(int <>1__state) { }

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
	private sealed class <FadeOut>d__39 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Locomotive <>4__this; //Field offset: 0x20
		public float time; //Field offset: 0x28
		private AudioSource <source>5__2; //Field offset: 0x30

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
		public <FadeOut>d__39(int <>1__state) { }

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

	internal enum ETravelState
	{
		NotStarted = 0,
		OnRouteToDestination = 1,
		Arrived = 2,
		Departing = 3,
		OnRouteBack = 4,
		Finished = 5,
	}

	internal class SoundEvent
	{
		public AudioClip Clip; //Field offset: 0x10
		public ETravelState TravelState; //Field offset: 0x18
		public float RelativeTime; //Field offset: 0x1C
		[HideInInspector]
		public float Time; //Field offset: 0x20
		public bool Loop; //Field offset: 0x24
		public float FadeIn; //Field offset: 0x28
		public bool InterruptsOther; //Field offset: 0x2C
		public float OtherSourceFadeOut; //Field offset: 0x30
		[Range(0, 1)]
		public float Volume; //Field offset: 0x34
		public int Rolloff; //Field offset: 0x38

		public SoundEvent() { }

		public float SetAbsoluteTime(float[] timings) { }

	}

	private static float ROUTE_BACK_DURATION; //Field offset: 0x0
	[Header("Directions Cache")]
	[SerializeField]
	private Vector3[] _cachedDirections; //Field offset: 0xE8
	[SerializeField]
	private float _cachePredictionDistance; //Field offset: 0xF0
	[Header("Sounds")]
	[SerializeField]
	private AudioSource[] Sources; //Field offset: 0xF8
	public SoundEvent[] SoundEvents; //Field offset: 0x100
	[SerializeField]
	private AudioSource HummingSource; //Field offset: 0x108
	[SerializeField]
	private int _hummingSourceRolloff; //Field offset: 0x110
	[Header("Wheels")]
	[SerializeField]
	private Transform[] WheelTransforms; //Field offset: 0x118
	[SerializeField]
	private float _wheelRadius; //Field offset: 0x120
	[SerializeField]
	private float[] _travelStateTiming; //Field offset: 0x128
	public readonly BindableState TravelState; //Field offset: 0x130
	public Carriage[] Carriage; //Field offset: 0x138
	public Action Arrived; //Field offset: 0x140
	public Action Departed; //Field offset: 0x148
	public float DepartTMinus; //Field offset: 0x150
	public bool OnRoute; //Field offset: 0x154
	public float SuspensionBlendFactor; //Field offset: 0x158
	private float _nextEventTime; //Field offset: 0x15C
	private Queue _soundQueue; //Field offset: 0x160
	private float _travel; //Field offset: 0x168
	private Action _unbind; //Field offset: 0x170

	private AudioSource ActiveSource
	{
		private get { } //Length: 175
	}

	public virtual Vector3[] CachedDirections
	{
		 get { } //Length: 8
	}

	private AudioSource FreeSource
	{
		private get { } //Length: 361
	}

	public float TravelSpeed
	{
		 get { } //Length: 94
	}

	private static Locomotive() { }

	public Locomotive() { }

	public void CacheDirections() { }

	public virtual void CalculateLength() { }

	[IteratorStateMachine(typeof(<FadeIn>d__38))]
	public IEnumerator FadeIn(SoundEvent sound) { }

	[IteratorStateMachine(typeof(<FadeOut>d__39))]
	public IEnumerator FadeOut(float time) { }

	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 end, Vector3 point) { }

	private AudioSource get_ActiveSource() { }

	public virtual Vector3[] get_CachedDirections() { }

	private AudioSource get_FreeSource() { }

	public float get_TravelSpeed() { }

	public float GetArrivedTiming() { }

	public virtual void Init(DateTime depart) { }

	private void LateUpdate() { }

	private void ManageSoundEvents() { }

	public virtual void Move(bool force = false) { }

	private void MoveKey(int index, float dt) { }

	public virtual void OnDrawGizmosSelected() { }

	public virtual void OnRouteFinished() { }

	[ContextMenu("End_Position")]
	public virtual void PlaceAtEndPosition() { }

	[ContextMenu("Start_position")]
	public virtual void PlaceAtStartPosition() { }

	public void SetBoardingTime(float time) { }

	private void TravelStateChanged(ETravelState state) { }

	private void UpdateTravelState() { }

	private void Wheels() { }

}

