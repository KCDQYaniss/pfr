namespace EFT.UI.WeaponModding;

public sealed class WeaponPreview : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_2; //Field offset: 0x8
		public static Func <>9__30_0; //Field offset: 0x10
		public static Func <>9__30_1; //Field offset: 0x18
		public static Func <>9__30_2; //Field offset: 0x20
		public static Func <>9__30_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <GetBounds>b__30_0(Renderer x) { }

		internal Bounds <GetBounds>b__30_1(Renderer r) { }

		internal bool <GetBounds>b__30_2(Bounds b) { }

		internal Bounds <GetBounds>b__30_3(Bounds current, Bounds next) { }

		internal bool <SetupItemPreview>b__23_2(LightComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Token tokensToLoad; //Field offset: 0x10
		public WeaponPreview <>4__this; //Field offset: 0x18
		public Action onLoadingFinished; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		public bool setAsClosest; //Field offset: 0x30
		public Callback onFinished; //Field offset: 0x38

		public <>c__DisplayClass23_0() { }

		internal void <SetupItemPreview>b__0() { }

		internal void <SetupItemPreview>g__ObjectsLoaded|1(Token tokens) { }

	}

	[SerializeField]
	private GameObject _weaponPreviewLights; //Field offset: 0x20
	[FormerlySerializedAs("WeaponPreviewCamera")]
	[SerializeField]
	private Camera _cameraTemplate; //Field offset: 0x28
	private Camera _weaponPreviewCamera; //Field offset: 0x30
	public Transform Rotator; //Field offset: 0x38
	private Transform _rotatorParent; //Field offset: 0x40
	private GameObject _originalObject; //Field offset: 0x48
	private Token _objectTokens; //Field offset: 0x50
	private Token _previousTokens; //Field offset: 0x58
	private Nullable _originalBounds; //Field offset: 0x60
	private readonly List _enabledLightMods; //Field offset: 0x80
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"light", "mask"})]
	private readonly List _cachedLightMasks; //Field offset: 0x88
	private CancellationTokenSource _unsubscribe; //Field offset: 0x90
	private Item _currentItem; //Field offset: 0x98
	private float _currentYaw; //Field offset: 0xA0
	private float _currentTilt; //Field offset: 0xA4
	private Action _resolutionBinding; //Field offset: 0xA8
	private Nullable _initialRotation; //Field offset: 0xB0
	private Transform _positionedObject; //Field offset: 0xC0
	private Transform _previewPivot; //Field offset: 0xC8

	public Camera WeaponPreviewCamera
	{
		 get { } //Length: 76
	}

	public WeaponPreview() { }

	[CompilerGenerated]
	private void <DisplaySettingsChangedHandler>b__27_0() { }

	[CompilerGenerated]
	private bool <Hide>b__36_0(LightComponent x) { }

	private void Awake() { }

	private void CreateRotator() { }

	private void CreateRotatorParent() { }

	private void CreateWeaponPreviewCamera() { }

	private void DestroyObjectIfNeeded() { }

	private void DestroyOriginalObject() { }

	private void DisplaySettingsChangedHandler(EftDisplaySettings _) { }

	public Camera get_WeaponPreviewCamera() { }

	public static Bounds GetBounds(GameObject itemGameObject) { }

	private void GetRidOfObject(ref T object) { }

	public void Hide() { }

	public void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void PositionGameObject(GameObject itemGameObject, Nullable initialRotation = null) { }

	private void ReleasePreviousTokensIfNeeded() { }

	public void ResetRotator(float defaultZ) { }

	private void RestorePreviousObjectLightMasks() { }

	public void Rotate(float angle, float tilt = 0, float minTilt = -30, float maxTilt = 30) { }

	private void SetPreviewMaskToChildrenLights() { }

	public void SetupItemPreview(Item item, Action onLoadingStart = null, Action onLoadingFinished = null, Callback onFinished = null, bool setAsClosest = true, Nullable initialRotation = null, bool enableWeaponLights = true) { }

	public void Zoom(float zoom) { }

}

