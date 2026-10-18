//Type is in global namespace

public class WheelDrive : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Sleep>d__30 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WheelDrive <>4__this; //Field offset: 0x20

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
		public <Sleep>d__30(int <>1__state) { }

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

	internal enum EGear
	{
		Back = 0,
		Fwd = 1,
	}

	[SerializeField]
	private RigidbodySpawner _rigidSpawner; //Field offset: 0x20
	[SerializeField]
	private Transform Ballistics; //Field offset: 0x28
	[SerializeField]
	private RigidbodySpawner _bumperSpawner; //Field offset: 0x30
	[SerializeField]
	private Collider _chassisCollider; //Field offset: 0x38
	[SerializeField]
	private Collider _bumperCollider; //Field offset: 0x40
	public EGear Gear; //Field offset: 0x48
	public Vector3 SteerTarget; //Field offset: 0x4C
	public Transform SteerTargetTransform; //Field offset: 0x58
	public float Torque; //Field offset: 0x60
	public Vector2 MinSpeedAtDistance; //Field offset: 0x64
	public Vector2 MaxpeedAtDistance; //Field offset: 0x6C
	public float BrakeTorque; //Field offset: 0x74
	public float SteerSpeed; //Field offset: 0x78
	public Vector2 SpeedByTurnAngel; //Field offset: 0x7C
	private float _steerAngle; //Field offset: 0x84
	private bool _brake; //Field offset: 0x88
	public EasySuspension ES; //Field offset: 0x90
	private Rigidbody _rigid; //Field offset: 0x98
	private Rigidbody _bumper; //Field offset: 0xA0
	[Tooltip("The vehicle's speed when the physics engine can use different amount of sub-steps (in m/s).")]
	public float criticalSpeed; //Field offset: 0xA8
	[Tooltip("Simulation sub-steps when the speed is above critical.")]
	public int stepsBelow; //Field offset: 0xAC
	[Tooltip("Simulation sub-steps when the speed is below critical.")]
	public int stepsAbove; //Field offset: 0xB0
	private WheelCollider[] wheels; //Field offset: 0xB8
	private Vector3 _steerCenter; //Field offset: 0xC0
	public WheelCollider[] frontWheels; //Field offset: 0xD0
	public AudioSource AudioSource; //Field offset: 0xD8
	public AudioClip OnStartSound; //Field offset: 0xE0
	public Transform[] wheelGraphics; //Field offset: 0xE8

	public WheelDrive() { }

	public void ManualBrake() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void SetupAudioSource() { }

	private float SignedAngle(Vector3 a, Vector3 b) { }

	[IteratorStateMachine(typeof(<Sleep>d__30))]
	public IEnumerator Sleep() { }

	private void Start() { }

	public void Steer(Vector3 point) { }

	private void Update() { }

}

