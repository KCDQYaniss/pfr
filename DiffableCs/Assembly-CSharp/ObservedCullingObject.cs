//Type is in global namespace

public class ObservedCullingObject : ICullable, IDisposable, IAutocullAutomated
{
	[CompilerGenerated]
	private Action OnVisibilityChanged; //Field offset: 0x10
	private Transform _object; //Field offset: 0x18
	[CompilerGenerated]
	private readonly float <Radius>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly float <CullDistanceSqr>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private bool <CullByDistanceOnly>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <SqrCameraDistance>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsVisibleByCamera>k__BackingField; //Field offset: 0x41
	private bool _lastVisibilityValue; //Field offset: 0x42
	private bool _isVisibleByJob; //Field offset: 0x43
	private bool _isAutocullVisible; //Field offset: 0x44
	private bool _autocullingIsWorking; //Field offset: 0x45

	public event Action OnVisibilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override Bounds AutocullObjectBounds
	{
		 get { } //Length: 181
	}

	public override Vector3 ClearTransformPosition
	{
		 get { } //Length: 19
	}

	public override bool CullByDistanceOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float CullDistanceSqr
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public private override int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool IsAutocullVisible
	{
		 get { } //Length: 5
		 set { } //Length: 99
	}

	public override bool IsDynamicCullingObject
	{
		 get { } //Length: 3
	}

	public private override bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool IsVisibleByCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public override float Radius
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public override Vector3 SafeMultithreadedPosition
	{
		 get { } //Length: 19
	}

	public override float SqrCameraDistance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public ObservedCullingObject(Transform o, float radius, float cullingDistance) { }

	[CompilerGenerated]
	public void add_OnVisibilityChanged(Action value) { }

	private void CheckVisibility() { }

	public override void CustomUpdate() { }

	public override void Dispose() { }

	public override Bounds get_AutocullObjectBounds() { }

	public override Vector3 get_ClearTransformPosition() { }

	[CompilerGenerated]
	public override bool get_CullByDistanceOnly() { }

	[CompilerGenerated]
	public override float get_CullDistanceSqr() { }

	[CompilerGenerated]
	public override int get_Index() { }

	public override bool get_IsAutocullVisible() { }

	public override bool get_IsDynamicCullingObject() { }

	[CompilerGenerated]
	public override bool get_IsVisible() { }

	[CompilerGenerated]
	public override bool get_IsVisibleByCamera() { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public override float get_Radius() { }

	public override Vector3 get_SafeMultithreadedPosition() { }

	[CompilerGenerated]
	public override float get_SqrCameraDistance() { }

	public override void Register() { }

	[CompilerGenerated]
	public void remove_OnVisibilityChanged(Action value) { }

	[CompilerGenerated]
	public override void set_CullByDistanceOnly(bool value) { }

	[CompilerGenerated]
	private void set_Index(int value) { }

	public override void set_IsAutocullVisible(bool value) { }

	[CompilerGenerated]
	private void set_IsVisible(bool value) { }

	[CompilerGenerated]
	public override void set_IsVisibleByCamera(bool value) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	public override void set_SqrCameraDistance(float value) { }

	public void SetAutocullingWorkingStatus(bool isWorking) { }

	public override void SetVisibility(bool isVisible) { }

}

