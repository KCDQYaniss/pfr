namespace EFT;

public sealed class TripwireVisualPlacer : MonoBehaviour
{
	private const float SPHERE_RADIUS = 0.05; //Field offset: 0x0
	private const float MAX_RAY_DISTANCE = 3; //Field offset: 0x0
	private const int FRAME_VALID_TIMES = 5; //Field offset: 0x0
	private const float MIN_SIZE_VALUE = 0.07; //Field offset: 0x0
	private const float MIN_PREVIEW_LENGTH = 0.3; //Field offset: 0x0
	private const float MIN_MAGNITUDE = 0.001; //Field offset: 0x0
	public const string PLANT_UNAVAILABLE_MESSAGE = "Tripwire/PlantUnavailable"; //Field offset: 0x0
	private const string PLANT_UNAVAILABLE_BAD_HEIGHT_MESSAGE = "Tripwire/PlantUnavailable/Height"; //Field offset: 0x0
	[SerializeField]
	private GameObject _firstTripwire; //Field offset: 0x20
	[SerializeField]
	private GameObject _secondTripwire; //Field offset: 0x28
	[SerializeField]
	private Transform _firstTripwirePivot; //Field offset: 0x30
	[SerializeField]
	private PreviewMaterialSetter _firstMaterialSetter; //Field offset: 0x38
	[SerializeField]
	private TripwireProceduralMesh _line; //Field offset: 0x40
	[SerializeField]
	private Color _validPlaceColor; //Field offset: 0x48
	[SerializeField]
	private Color _invalidPlaceColor; //Field offset: 0x58
	private GameObject _currentPoint; //Field offset: 0x68
	private DateTime _lastUpdate; //Field offset: 0x70
	private bool _hitValid; //Field offset: 0x78
	private bool _distanceValid; //Field offset: 0x79
	private bool _heightValid; //Field offset: 0x7A
	private RaycastHit _lastHit; //Field offset: 0x7C
	private bool _linecastValid; //Field offset: 0xA8
	private TripwireVisual _grenadeVisual; //Field offset: 0xB0
	private Transform _secondTripwirePivot; //Field offset: 0xB8
	private PreviewMaterialSetter _secondMaterialSetter; //Field offset: 0xC0
	private bool _sizeValid; //Field offset: 0xC8
	private int _minValidFrames; //Field offset: 0xCC
	private Vector3 _rootPosition; //Field offset: 0xD0
	private RaycastHit _lastFirstValidationHit; //Field offset: 0xDC
	private RaycastHit _lastSecondValidationHit; //Field offset: 0x108
	private float _maxPreviewLengthSqr; //Field offset: 0x134
	private float _minPreviewLengthSqr; //Field offset: 0x138
	private float _maxLengthSqr; //Field offset: 0x13C
	private float _minLengthSqr; //Field offset: 0x140
	private double _maxTripwireToPlayerDistanceSqr; //Field offset: 0x148
	private float _minMagnitudeSqr; //Field offset: 0x150
	[CompilerGenerated]
	private bool <AllowToPlantTripwire>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private ETripwirePlanState <TripwirePlanState>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private bool <PlantEnabled>k__BackingField; //Field offset: 0x15C
	[CompilerGenerated]
	private Vector3 <FirstPlantPosition>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Vector3 <SecondPlantPosition>k__BackingField; //Field offset: 0x16C

	private bool AllowToPlantTripwire
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Vector3 FirstPlantPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private bool PlantEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static LayerMask PlantTripwireLayerMask
	{
		private get { } //Length: 95
	}

	public private Vector3 SecondPlantPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private ETripwirePlanState TripwirePlanState
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private TripwiresGlobalSettings TripwiresSettings
	{
		private get { } //Length: 205
	}

	public TripwireVisualPlacer() { }

	public bool CanStartPlanting() { }

	public void ClearPlanting() { }

	[CompilerGenerated]
	private bool get_AllowToPlantTripwire() { }

	[CompilerGenerated]
	public Vector3 get_FirstPlantPosition() { }

	[CompilerGenerated]
	public bool get_PlantEnabled() { }

	private static LayerMask get_PlantTripwireLayerMask() { }

	[CompilerGenerated]
	public Vector3 get_SecondPlantPosition() { }

	[CompilerGenerated]
	public ETripwirePlanState get_TripwirePlanState() { }

	private TripwiresGlobalSettings get_TripwiresSettings() { }

	public void Init(ThrowWeap grenade) { }

	public void InitFirstPoint(Ray interactionOrigin) { }

	public void InitSecondPoint() { }

	public void ProcessPlacement(Ray interactionOrigin, Vector3 rootPosition) { }

	[CompilerGenerated]
	private void set_AllowToPlantTripwire(bool value) { }

	[CompilerGenerated]
	private void set_FirstPlantPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_PlantEnabled(bool value) { }

	[CompilerGenerated]
	private void set_SecondPlantPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_TripwirePlanState(ETripwirePlanState value) { }

	private void SetAvailableMaterial(bool available) { }

	private Vector3 SphereCastPosition(Ray interactionOrigin) { }

	private bool ValidateSecondState(Vector3 rootPosition, ref Vector3 targetPosition, Ray interactionRay) { }

}

