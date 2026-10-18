//Type is in global namespace

public class ForceEffector : IEffector
{
	[CompilerGenerated]
	private sealed class <CustomExplosionShake>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public float rotationStrength; //Field offset: 0x24
		public float positionStrength; //Field offset: 0x28
		public ForceEffector <>4__this; //Field offset: 0x30
		private float <t>5__2; //Field offset: 0x38
		private float <rotStr>5__3; //Field offset: 0x3C
		private float <posStr>5__4; //Field offset: 0x40
		private float <dt>5__5; //Field offset: 0x44

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
		public <CustomExplosionShake>d__21(int <>1__state) { }

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
	private sealed class <GrenadeShake_CO>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float strength; //Field offset: 0x20
		public ForceEffector <>4__this; //Field offset: 0x28
		private float <t>5__2; //Field offset: 0x30
		private float <str>5__3; //Field offset: 0x34
		private float <dt>5__4; //Field offset: 0x38

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
		public <GrenadeShake_CO>d__19(int <>1__state) { }

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
	private sealed class <LinearExplosionShake>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public ForceEffector <>4__this; //Field offset: 0x28
		public float rotationStrength; //Field offset: 0x30
		public float positionStrength; //Field offset: 0x34
		private float <t>5__2; //Field offset: 0x38
		private float <dt>5__3; //Field offset: 0x3C

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
		public <LinearExplosionShake>d__22(int <>1__state) { }

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

	internal class Val
	{
		public ComponentType From; //Field offset: 0x10
		public Target To; //Field offset: 0x14
		public ComponentType Component; //Field offset: 0x18
		public float Intensity; //Field offset: 0x1C
		private Spring _target; //Field offset: 0x20
		private int _component; //Field offset: 0x28
		private int _fromComponent; //Field offset: 0x2C

		public Val() { }

		public void Initialize(Spring rootRotation, Spring handsPosition, Spring handsRotation) { }

		public void Process(Vector3 force) { }

	}

	public float Intensity; //Field offset: 0x10
	[UberDraw("From 60;To 120;Component 60;Intensity 80", False)]
	public Val[] Vals; //Field offset: 0x18
	private bool _initialized; //Field offset: 0x20
	private Vector3 _force; //Field offset: 0x24
	private Vector3 _forceSum; //Field offset: 0x30
	private int _framesLeft; //Field offset: 0x3C
	private Spring CameraRotationSpring; //Field offset: 0x40
	private Spring CameraPositionSpring; //Field offset: 0x48
	private Spring HandsRotationSpring; //Field offset: 0x50
	[SerializeField]
	private float _eulersNoiseXYMaxValue; //Field offset: 0x58
	[SerializeField]
	private float _eulersNoiseZMaxValue; //Field offset: 0x5C
	[SerializeField]
	private float _deltaRandom; //Field offset: 0x60
	public float WiggleMagnitude; //Field offset: 0x64

	public ForceEffector() { }

	public void AddForce(Vector3 direction, float strength = 1, float hands = 1, float camera = 1) { }

	public void AddForce(float strength = 1, float hands = 1, float camera = 1) { }

	public IEnumerator CustomExplosionShake(CustomExplosionShakeSettings settings, float Multiplier = 1) { }

	[IteratorStateMachine(typeof(<CustomExplosionShake>d__21))]
	public IEnumerator CustomExplosionShake(float rotationStrength, float positionStrength, float time) { }

	public override string DebugOutput() { }

	private void GrenadeShake(Vector3 force, float hitPower = 1) { }

	[IteratorStateMachine(typeof(<GrenadeShake_CO>d__19))]
	public IEnumerator GrenadeShake_CO(float strength) { }

	public void HardShake(float rotationStrength, float positionStrength) { }

	public void HardShake(float strength) { }

	public override void Initialize(PlayerSpring playerSpring) { }

	[IteratorStateMachine(typeof(<LinearExplosionShake>d__22))]
	public IEnumerator LinearExplosionShake(float rotationStrength, float positionStrength, float time) { }

	public override void Process(float deltaTime) { }

}

