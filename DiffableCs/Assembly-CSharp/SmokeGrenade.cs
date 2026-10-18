//Type is in global namespace

public class SmokeGrenade : Grenade, IPlatformTransportee
{
	[CompilerGenerated]
	private sealed class <DelayForEmitEvent>d__34 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public SmokeGrenade <>4__this; //Field offset: 0x28

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
		public <DelayForEmitEvent>d__34(int <>1__state) { }

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
	private sealed class <EmissionAreaHandler>d__35 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SmokeGrenade <>4__this; //Field offset: 0x20
		public float rate; //Field offset: 0x28
		private float <normalTime>5__2; //Field offset: 0x2C

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
		public <EmissionAreaHandler>d__35(int <>1__state) { }

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

	private const float _maxRigidbodyLifeTime = 60; //Field offset: 0x0
	private float _emissionStart; //Field offset: 0xF0
	private float _radius; //Field offset: 0xF4
	private float _emitTime; //Field offset: 0xF8
	private Vector3 _startScaleVector; //Field offset: 0xFC
	public Action EmissionEnd; //Field offset: 0x108
	[CompilerGenerated]
	private MovingPlatform <Platform>k__BackingField; //Field offset: 0x110

	private SmokeGrenadeSettings _smokeGrenadeSettings
	{
		private get { } //Length: 122
	}

	public SphereCollider Area
	{
		 get { } //Length: 30
	}

	public float EmitTime
	{
		 get { } //Length: 9
	}

	public float LifeTime
	{
		 get { } //Length: 267
	}

	public SmokeGrenadeNetworkData NetworkData
	{
		 get { } //Length: 1921
	}

	public MovingPlatform Platform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private Vector3 Position
	{
		private get { } //Length: 204
	}

	public float Radius
	{
		 get { } //Length: 9
	}

	public SmokeGrenade() { }

	public override void Board(MovingPlatform platform) { }

	[IteratorStateMachine(typeof(<DelayForEmitEvent>d__34))]
	public IEnumerator DelayForEmitEvent(float time) { }

	[IteratorStateMachine(typeof(<EmissionAreaHandler>d__35))]
	public IEnumerator EmissionAreaHandler(float rate) { }

	private SmokeGrenadeSettings get__smokeGrenadeSettings() { }

	public SphereCollider get_Area() { }

	public float get_EmitTime() { }

	public float get_LifeTime() { }

	public SmokeGrenadeNetworkData get_NetworkData() { }

	[CompilerGenerated]
	public MovingPlatform get_Platform() { }

	private Vector3 get_Position() { }

	public float get_Radius() { }

	private void GetMaxSize() { }

	public override void GetOff(MovingPlatform platform) { }

	public virtual void Init(GrenadeSettings settings, int playerRaidId, ThrowWeap throwWeap, float timeSpent, IBallisticsCalculator calculator, bool isBeingPlanted) { }

	[ContextMenu("EmissionEnd")]
	public void InvokeEmissionEndEvent() { }

	public virtual void OnExplosion() { }

	public void RemoveRigidbody() { }

	protected override void RemoveRigidBodyOnVelocityDrop(Throwable grenade) { }

	[CompilerGenerated]
	public void set_Platform(MovingPlatform value) { }

	public void SetEmission(float time) { }

	public virtual void SetThrowForce(Vector3 force) { }

	public void StartEmissionBehaviour() { }

	[ContextMenu("Update Emission Area")]
	public void UpdateEmissionArea(float normalTime) { }

}

