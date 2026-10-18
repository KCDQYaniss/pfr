//Type is in global namespace

public class ScopeZoomHandler : MonoBehaviour
{
	[CompilerGenerated]
	private struct <>c__DisplayClass65_0
	{
		public GameSetting inverseAxis; //Field offset: 0x0
		public float scroll; //Field offset: 0x8
		public ControlSettingsGroup settings; //Field offset: 0x10

	}

	private const float EPSILON = 0.0001; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSmoothScopeStateChanged; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSmoothSensetivityChange; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnSmoothScopeZoomValueChanged; //Field offset: 0x30
	public Transform ScopeSwitcher; //Field offset: 0x38
	public Transform StartPivot; //Field offset: 0x40
	public Transform EndPivot; //Field offset: 0x48
	[Space]
	public bool InverseRotation; //Field offset: 0x50
	[CompilerGenerated]
	private ScopePrefabCache <ScopeCache>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private ScopeSmoothCameraData <CameraData>k__BackingField; //Field offset: 0x60
	private float _currentFieldOfView; //Field offset: 0x68
	private float _targetFieldOfView; //Field offset: 0x6C
	private float _speed; //Field offset: 0x70
	private float _zoomAmount; //Field offset: 0x74
	private float _normalizedZoom; //Field offset: 0x78
	private float _delta; //Field offset: 0x7C
	private float _previousScroll; //Field offset: 0x80
	private bool _isFieldOfViewEquals; //Field offset: 0x84
	private bool _isUpdateEnable; //Field offset: 0x85
	private bool _isOpticCameraManagerInitialized; //Field offset: 0x86
	private ESmoothScopeState _currentSmoothScopeState; //Field offset: 0x88
	private ESmoothScopeState _lastEdgeSmoothScopeState; //Field offset: 0x8C
	private IAdjustableOpticData _adjustableOpticData; //Field offset: 0x90
	private float _scroll; //Field offset: 0x98
	private SightComponent _sightComponent; //Field offset: 0xA0
	private bool _isInited; //Field offset: 0xA8
	private CompositeDisposable _unsubscribe; //Field offset: 0xB0
	private KeyGroup _zoomInControl; //Field offset: 0xB8
	private KeyGroup _zoomOutControl; //Field offset: 0xC0

	public event Action OnSmoothScopeStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSmoothScopeZoomValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSmoothSensetivityChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float BlendFactor
	{
		 get { } //Length: 125
	}

	public ScopeSmoothCameraData CameraData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float FiledOfView
	{
		 get { } //Length: 6
	}

	private float FovSpeed
	{
		private get { } //Length: 92
	}

	private float MaxFov
	{
		private get { } //Length: 92
	}

	private float MinFov
	{
		private get { } //Length: 91
	}

	public ScopePrefabCache ScopeCache
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ScopeZoomHandler() { }

	[CompilerGenerated]
	internal static bool <GetZoomInput>g__IsAllKeysInVariantPressed|65_1(InputSource variant) { }

	[CompilerGenerated]
	internal static bool <GetZoomInput>g__IsScrollInputsPressed|65_0(KeyGroup keyGroup, bool positive, out float value, ref <>c__DisplayClass65_0 unnamed_param_3) { }

	private void AccumulateZoom() { }

	private Quaternion Add(Quaternion p, Quaternion q) { }

	[CompilerGenerated]
	public void add_OnSmoothScopeStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothScopeZoomValueChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothSensetivityChange(Action value) { }

	private void Awake() { }

	public void ForceChangeScopeState() { }

	public float get_BlendFactor() { }

	[CompilerGenerated]
	public ScopeSmoothCameraData get_CameraData() { }

	public float get_FiledOfView() { }

	private float get_FovSpeed() { }

	private float get_MaxFov() { }

	private float get_MinFov() { }

	[CompilerGenerated]
	public ScopePrefabCache get_ScopeCache() { }

	private float GetZoomInput() { }

	public void Init(SightComponent sightComponent) { }

	private void InterruptZoom() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnOpticManagerInitialized() { }

	[CompilerGenerated]
	public void remove_OnSmoothScopeStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothScopeZoomValueChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothSensetivityChange(Action value) { }

	private void ResetProperties() { }

	private Quaternion ScalarMultiply(Quaternion input, float scalar) { }

	[CompilerGenerated]
	public void set_CameraData(ScopeSmoothCameraData value) { }

	[CompilerGenerated]
	public void set_ScopeCache(ScopePrefabCache value) { }

	public void SetSpectatorZoomValue(float zoomValue) { }

	private void SetSwitchRotation() { }

	public void SetUpdateEnable(bool updateEnable) { }

	private Quaternion Slerp(Quaternion p, Quaternion q, float t, bool shortWay) { }

	private void Update() { }

	private void UpdateAccumulateZoom() { }

	private void UpdateFieldOfView() { }

	private void UpdateRetrice() { }

	public void UpdateScope() { }

	private void UpdateSensitivity() { }

	private void UpdateSpectatorRetrice() { }

	private void UpdateSwitchRotation() { }

	private void ValidateControlSettings(List userKeyBindings) { }

	private void ValidateCurrentSmoothScopeState() { }

	private float ZoomBlendFactor() { }

	private float ZoomFactor() { }

}

