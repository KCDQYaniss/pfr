namespace CW2.Animations;

public class PhysicsSimulator : MonoBehaviour
{
	internal class CurveDevice
	{
		public AnimationCurve Curve; //Field offset: 0x10
		public float Frequency; //Field offset: 0x18
		public float Intensity; //Field offset: 0x1C
		public float TimeShift; //Field offset: 0x20
		public float IntensityShift; //Field offset: 0x24
		public Val ValueConfiguration; //Field offset: 0x28

		public CurveDevice() { }

		public void Initialize() { }

		public void Process(PhysicsSimulator physicsSimulator) { }

	}

	internal class InputDevice
	{
		public string AxisName; //Field offset: 0x10
		public float Intensity; //Field offset: 0x18
		public float IntensityShift; //Field offset: 0x1C
		public Val ValueConfiguration; //Field offset: 0x20

		public InputDevice() { }

		public void Initialize() { }

		public void Process(PhysicsSimulator physicsSimulator) { }

	}

	internal class RandomDevice
	{
		public float Frequency; //Field offset: 0x10
		public float Intensity; //Field offset: 0x14
		public float IntensityShift; //Field offset: 0x18
		public float TimeShift; //Field offset: 0x1C
		public bool RandomTimeShift; //Field offset: 0x20
		public bool SmoothStart; //Field offset: 0x21
		public Val ValueConfiguration; //Field offset: 0x28
		private float _rndSeed; //Field offset: 0x30
		private float _startT; //Field offset: 0x34

		public RandomDevice() { }

		public void Initialize() { }

		public void Process(PhysicsSimulator physicsSimulator) { }

	}

	internal class ScriptValueDevice
	{
		public string ValueName; //Field offset: 0x10
		public float Intensity; //Field offset: 0x18
		public float IntensityShift; //Field offset: 0x1C
		public Val ValueConfiguration; //Field offset: 0x20

		public ScriptValueDevice() { }

		public void Add(PhysicsSimulator physicsSimulator, float value) { }

		public void Initialize() { }

	}

	internal class Spring
	{
		[HideInInspector]
		public Vector3 Zero; //Field offset: 0x10
		public float ReturnSpeed; //Field offset: 0x1C
		public float Damping; //Field offset: 0x20
		public Vector3 Min; //Field offset: 0x24
		public Vector3 Max; //Field offset: 0x30
		public float VelocityMax; //Field offset: 0x3C

		public Spring() { }

		public void FixedUpdate(ref Vector3 velocity, ref Vector3 current) { }

		private static Vector3 Limit(Vector3 vec, float limit) { }

	}

	internal class UnityValueDevice
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal float <.cctor>b__6_0() { }

			internal float <.cctor>b__6_1() { }

		}

		internal enum Values
		{
			MousePosX = 0,
			MousePosY = 1,
		}

		private static Func[] _values; //Field offset: 0x0
		public Values ValueType; //Field offset: 0x10
		public float Intensity; //Field offset: 0x14
		public float IntensityShift; //Field offset: 0x18
		public Val ValueConfiguration; //Field offset: 0x20

		private static UnityValueDevice() { }

		public UnityValueDevice() { }

		public void Initialize() { }

		public void Process(PhysicsSimulator physicsSimulator) { }

	}

	internal class Val
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal float <.cctor>b__10_0(float f, float f1) { }

			internal float <.cctor>b__10_1(float f, float f1) { }

			internal void <.cctor>b__10_10(PhysicsSimulator s, Vector3 v) { }

			internal void <.cctor>b__10_11(PhysicsSimulator s, Vector3 v) { }

			internal float <.cctor>b__10_2(float f, float f1) { }

			internal float <.cctor>b__10_3(float f, float f1) { }

			internal Vector3 <.cctor>b__10_4(PhysicsSimulator s) { }

			internal Vector3 <.cctor>b__10_5(PhysicsSimulator s) { }

			internal Vector3 <.cctor>b__10_6(PhysicsSimulator s) { }

			internal Vector3 <.cctor>b__10_7(PhysicsSimulator s) { }

			internal void <.cctor>b__10_8(PhysicsSimulator s, Vector3 v) { }

			internal void <.cctor>b__10_9(PhysicsSimulator s, Vector3 v) { }

		}

		internal enum ComponentType
		{
			X = 0,
			Y = 1,
			Z = 2,
		}

		internal enum OperationType
		{
			Set = 0,
			Add = 1,
			Mult = 2,
			Clamp = 3,
			Min = 4,
			Max = 5,
		}

		internal enum TargetType
		{
			Position = 0,
			PositionVelocity = 1,
			Rotation = 2,
			RotationVelocity = 3,
		}

		private static Func[] _operations; //Field offset: 0x0
		private static Func[] _targetGets; //Field offset: 0x8
		private static Action[] _targetSets; //Field offset: 0x10
		public TargetType Target; //Field offset: 0x10
		public OperationType Operation; //Field offset: 0x14
		public ComponentType Component; //Field offset: 0x18
		private Func _operation; //Field offset: 0x20
		private Func _targetGet; //Field offset: 0x28
		private Action _targetSet; //Field offset: 0x30
		private int _component; //Field offset: 0x38

		private static Val() { }

		public Val() { }

		public void Initialize() { }

		public void Process(PhysicsSimulator physicsSimulator, float val) { }

	}

	public Vector3 Pivot; //Field offset: 0x20
	public Spring PositionSpring; //Field offset: 0x30
	public Spring RotationSpring; //Field offset: 0x38
	public RandomDevice[] RandomDevices; //Field offset: 0x40
	public CurveDevice[] CurveDevices; //Field offset: 0x48
	public InputDevice[] InputDevices; //Field offset: 0x50
	public ScriptValueDevice[] ScriptValueDevices; //Field offset: 0x58
	public UnityValueDevice[] UnityValueDevices; //Field offset: 0x60
	[HideInInspector]
	public Vector3 Position; //Field offset: 0x68
	[HideInInspector]
	public Vector3 PositionVelocity; //Field offset: 0x74
	[HideInInspector]
	public Vector3 Rotation; //Field offset: 0x80
	[HideInInspector]
	public Vector3 RotationVelocity; //Field offset: 0x8C
	private Dictionary _valueDevices; //Field offset: 0x98

	public PhysicsSimulator() { }

	public void Add(string name, float value) { }

	[ContextMenu("Awake")]
	private void Awake() { }

	private void FixedUpdate() { }

}

