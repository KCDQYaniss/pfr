//Type is in global namespace

[ExecuteInEditMode]
public class CullingLightObject : CullingObject
{
	private const int FullGlobalUpdateCount = 20; //Field offset: 0x0
	private static int _currentGlobalUpdateIndex; //Field offset: 0x0
	[SerializeField]
	private Light _light; //Field offset: 0x98
	[SerializeField]
	private float _fadeStartDistance; //Field offset: 0xA0
	[SerializeField]
	private float _fadeEndDistance; //Field offset: 0xA4
	[SerializeField]
	private AnimationCurve _fadeCurve; //Field offset: 0xA8
	[SerializeField]
	private bool _useLightIntensityFromEditor; //Field offset: 0xB0
	[Range(0, 8)]
	[SerializeField]
	private float _maxLightIntensity; //Field offset: 0xB4
	[SerializeField]
	private bool _takeFlareParametersFromThisScript; //Field offset: 0xB8
	private GUIStyle style; //Field offset: 0xC0
	[SerializeField]
	private bool _cullShadowsByDistance; //Field offset: 0xC8
	[Header("Shadows")]
	[SerializeField]
	private float _shadowsFadeStartDistance; //Field offset: 0xCC
	[SerializeField]
	private float _shadowsFadeEndDistance; //Field offset: 0xD0
	private float _initialShadowStrength; //Field offset: 0xD4
	private float _maxIntensityFinal; //Field offset: 0xD8
	private bool _isEnabled; //Field offset: 0xDC
	private float _intensityMultiplier; //Field offset: 0xE0
	private int _updateIndex; //Field offset: 0xE4
	private int _currentUpdateIndex; //Field offset: 0xE8
	private float _fadeStartDistanceSqr; //Field offset: 0xEC
	private float _fadeEndDistanceSqr; //Field offset: 0xF0
	private float _fadeLengthDistanceSqr; //Field offset: 0xF4
	private LightFlicker _flicker; //Field offset: 0xF8
	private VolumetricLight _volumetricLight; //Field offset: 0x100
	private float _fadeShadowStartDistanceSqr; //Field offset: 0x108
	private float _fadeShadowEndDistanceSqr; //Field offset: 0x10C
	private float _shadowFadeLengthDistanceSqr; //Field offset: 0x110
	private float _lastShadowMultiplier; //Field offset: 0x114
	private float _lastMultiplier; //Field offset: 0x118
	private float _lastIntensityMultiplier; //Field offset: 0x11C
	private bool _callUpdateWhenMagicHappens; //Field offset: 0x120
	private bool _isCullingManagerCreated; //Field offset: 0x121
	[SerializeField]
	private LightShadows _initialShadowsMode; //Field offset: 0x124

	public bool CullShadowsByDistance
	{
		 get { } //Length: 8
	}

	public float CurrentLightIntensity
	{
		 get { } //Length: 17
	}

	public float IntensityMultiplier
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public bool IsLightEnabled
	{
		 get { } //Length: 8
	}

	public float MaxLightIntensity
	{
		 get { } //Length: 9
	}

	public bool TakeFlareParametersFromCullingLight
	{
		 get { } //Length: 8
	}

	public CullingLightObject() { }

	protected virtual void Awake() { }

	private void CacheLightSqrDistances() { }

	private void CacheShadowSqrDistances() { }

	private float CalculateMultiplier() { }

	protected float CalculateShadowMultiplier() { }

	public virtual void CustomUpdate() { }

	public bool get_CullShadowsByDistance() { }

	public float get_CurrentLightIntensity() { }

	public float get_IntensityMultiplier() { }

	public bool get_IsLightEnabled() { }

	public float get_MaxLightIntensity() { }

	public bool get_TakeFlareParametersFromCullingLight() { }

	public bool GetCullShadowsByDistance() { }

	public Light GetEditorLight() { }

	public float GetFadEndDistance() { }

	public float GetFadeStartDistance() { }

	public LightFlicker GetFlicker() { }

	public LightShadows GetInitialShadowsMode() { }

	public Light GetLight() { }

	public float getMaxIntensityFinal() { }

	private void OnCullingManagerInstanceCreated() { }

	private void OnCullingManagerInstanceDestroyed() { }

	protected virtual void OnDestroy() { }

	protected override void OnDisable() { }

	public void set_IntensityMultiplier(float value) { }

	public virtual void SetVisibility(bool isVisible) { }

	public void Switch(bool enable) { }

	protected override void UpdateCullingObject(float multiplier, float shadowMultiplier) { }

	private void UpdateIntensity() { }

}

