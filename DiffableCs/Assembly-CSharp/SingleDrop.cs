//Type is in global namespace

public class SingleDrop
{
	public static float _maxScale; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsDropsShouldMove>k__BackingField; //Field offset: 0x4
	public AnimationCurve ScaleCurve; //Field offset: 0x10
	public float Lifetime; //Field offset: 0x18
	private float _scaleTimer; //Field offset: 0x1C
	private Action _callback; //Field offset: 0x20
	public float _initialScale; //Field offset: 0x28
	[CompilerGenerated]
	private Vector3 <CurrentScale>k__BackingField; //Field offset: 0x2C
	public bool _isActive; //Field offset: 0x38
	public Vector2 Scale; //Field offset: 0x3C
	private bool _move; //Field offset: 0x44
	private float _amount; //Field offset: 0x48
	private float _intensity; //Field offset: 0x4C
	private Material _dropMaterial; //Field offset: 0x50
	private float _invAspect; //Field offset: 0x58
	[CompilerGenerated]
	private Vector3 <CurrentPosition>k__BackingField; //Field offset: 0x5C

	public private Vector3 CurrentPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private Vector3 CurrentScale
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public static bool IsDropsShouldMove
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	private static SingleDrop() { }

	public SingleDrop(AnimationCurve scaleCurve, Action callback, Material dropMateral, float aspect) { }

	public void Draw() { }

	[CompilerGenerated]
	public Vector3 get_CurrentPosition() { }

	[CompilerGenerated]
	public Vector3 get_CurrentScale() { }

	[CompilerGenerated]
	public static bool get_IsDropsShouldMove() { }

	[CompilerGenerated]
	private void set_CurrentPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_CurrentScale(Vector3 value) { }

	[CompilerGenerated]
	public static void set_IsDropsShouldMove(bool value) { }

	public void UpdateDrop(float dt) { }

	public void Use(float amount, float intensity, Vector3 localPosition) { }

}

