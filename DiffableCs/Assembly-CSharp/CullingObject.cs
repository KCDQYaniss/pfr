//Type is in global namespace

[ExecuteInEditMode]
[ScriptOrder(20000)]
public class CullingObject : MonoBehaviour, ICullable, IPreProcessHandler
{
	[SerializeField]
	protected float CullDistance; //Field offset: 0x20
	[SerializeField]
	protected float _radius; //Field offset: 0x24
	[SerializeField]
	protected Vector3 _shift; //Field offset: 0x28
	[SerializeField]
	private bool _drawSphere; //Field offset: 0x34
	[SerializeField]
	private bool _cullByDistanceOnly; //Field offset: 0x35
	[SerializeField]
	protected List _componentsToTurnOff; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private List _componentsToTurnOffDefaultState; //Field offset: 0x40
	[SerializeField]
	private List _gameObjectsToTurnOff; //Field offset: 0x48
	[SerializeField]
	private Transform _transform; //Field offset: 0x50
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x58
	private Vector3 _cachedPosition; //Field offset: 0x5C
	protected bool _isVisible; //Field offset: 0x68
	[CompilerGenerated]
	private float <SqrCameraDistance>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private bool <IsVisibleByCamera>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsAutocullVisible>k__BackingField; //Field offset: 0x71
	[SerializeField]
	private int _componentsSwitchPerFrameOnEnable; //Field offset: 0x74
	[SerializeField]
	private int _objectsSwitchPerFrameOnEnable; //Field offset: 0x78
	[SerializeField]
	private int _componentsSwitchPerFrameOnDisable; //Field offset: 0x7C
	[SerializeField]
	private int _objectsSwitchPerFrameOnDisable; //Field offset: 0x80
	private Stopwatch _stopwatch; //Field offset: 0x88
	private IEnumerator _setComponentsEnabledWorker; //Field offset: 0x90

	public override Vector3 ClearTransformPosition
	{
		 get { } //Length: 162
	}

	public override bool CullByDistanceOnly
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override float CullDistanceSqr
	{
		 get { } //Length: 10
	}

	public override int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override bool IsAutocullVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override bool IsVisible
	{
		 get { } //Length: 5
		private set { } //Length: 4
	}

	public override bool IsVisibleByCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 214
	}

	public override float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override Vector3 SafeMultithreadedPosition
	{
		 get { } //Length: 19
	}

	public Vector3 Shift
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public override float SqrCameraDistance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public CullingObject() { }

	protected override void Awake() { }

	public override void CustomUpdate() { }

	public override Vector3 get_ClearTransformPosition() { }

	public override bool get_CullByDistanceOnly() { }

	public override float get_CullDistanceSqr() { }

	[CompilerGenerated]
	public override int get_Index() { }

	[CompilerGenerated]
	public override bool get_IsAutocullVisible() { }

	public override bool get_IsVisible() { }

	[CompilerGenerated]
	public override bool get_IsVisibleByCamera() { }

	public override Vector3 get_Position() { }

	public override float get_Radius() { }

	public override Vector3 get_SafeMultithreadedPosition() { }

	public Vector3 get_Shift() { }

	[CompilerGenerated]
	public override float get_SqrCameraDistance() { }

	protected override Transform GetTransform() { }

	protected override void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	public override void OnPreProcess() { }

	protected override void OnValidate() { }

	public override void Register() { }

	public override void set_CullByDistanceOnly(bool value) { }

	[CompilerGenerated]
	protected void set_Index(int value) { }

	[CompilerGenerated]
	private void set_IsAutocullVisible(bool value) { }

	private void set_IsVisible(bool value) { }

	[CompilerGenerated]
	public override void set_IsVisibleByCamera(bool value) { }

	protected void set_Radius(float value) { }

	protected void set_Shift(Vector3 value) { }

	[CompilerGenerated]
	public override void set_SqrCameraDistance(float value) { }

	public void SetAutocullVisibility(bool flag) { }

	private void SetComponentsEnabled(bool isVisible) { }

	public override void SetVisibility(bool isVisible) { }

	public void SortComponentsToTurnOff() { }

	public void Start() { }

}

