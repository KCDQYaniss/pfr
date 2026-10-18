namespace EFT.RocketLauncher;

public class BackblastModel
{
	[CompilerGenerated]
	private sealed class <ConeBlast>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BackblastModel <>4__this; //Field offset: 0x20
		public Coroutine coroutine; //Field offset: 0x28
		private int <steps>5__2; //Field offset: 0x30
		private int <coneSteps>5__3; //Field offset: 0x34
		private Vector3 <coneDir>5__4; //Field offset: 0x38
		private Quaternion <stepRot>5__5; //Field offset: 0x44
		private Quaternion <innerStepRot>5__6; //Field offset: 0x54
		private NativeArray <playerCollisionCommands>5__7; //Field offset: 0x68
		private NativeArray <hitColliderCommands>5__8; //Field offset: 0x78
		private NativeArray <playerCollisionResults>5__9; //Field offset: 0x88
		private NativeArray <hitColliderResults>5__10; //Field offset: 0x98
		private JobHandle <playerCollisionHandler>5__11; //Field offset: 0xA8
		private JobHandle <hitColliderHandler>5__12; //Field offset: 0xB8
		private int <raysCount>5__13; //Field offset: 0xC8

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
		public <ConeBlast>d__8(int <>1__state) { }

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

	private IPlayer _player; //Field offset: 0x10
	private IBackBlastSettings _settings; //Field offset: 0x18
	private Transform _smokeport; //Field offset: 0x20
	private float _angleStep; //Field offset: 0x28
	private Weapon _weapon; //Field offset: 0x30
	private readonly Queue _tempReflectedRayCommands; //Field offset: 0x38

	public BackblastModel() { }

	[IteratorStateMachine(typeof(<ConeBlast>d__8))]
	public IEnumerator ConeBlast(Coroutine coroutine) { }

	private RaycastCommand CreateReflectRaycastCommand(RaycastHit hit, Vector3 directionIn, LayerMask mask) { }

	public void Dispose() { }

	public void Initialize(IBackBlastSettings settings, Transform smokeport, IPlayer player, Weapon weapon) { }

	private bool TryDamagePlayer(Player player, BodyPartCollider bodyPartCollider, float damageValue) { }

	private bool TryDetectPlayer(Collider collider, out Player player) { }

	private bool TryGetBodyPartCollider(Collider collider, out BodyPartCollider bodyPartCollider) { }

}

