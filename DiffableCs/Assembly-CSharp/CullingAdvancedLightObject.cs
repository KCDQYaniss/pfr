//Type is in global namespace

[ExecuteInEditMode]
public class CullingAdvancedLightObject : CullingObject
{
	private static int _currentGlobalUpdateIndex; //Field offset: 0x0
	private const int FullGlobalUpdateCount = 20; //Field offset: 0x0
	[SerializeField]
	private BaseLight _light; //Field offset: 0x98
	[SerializeField]
	private float _fadeStartDistance; //Field offset: 0xA0
	[SerializeField]
	private float _fadeEndDistance; //Field offset: 0xA4
	[SerializeField]
	private AnimationCurve _fadeCurve; //Field offset: 0xA8
	[SerializeField]
	private float _maxLightIntensity; //Field offset: 0xB0
	[SerializeField]
	private bool _isControlledByLampController; //Field offset: 0xB4
	private float _maxIntensityFinal; //Field offset: 0xB8
	private float _intensityMultiplier; //Field offset: 0xBC
	private int _updateIndex; //Field offset: 0xC0
	private int _currentUpdateIndex; //Field offset: 0xC4
	private float _fadeStartDistanceSqr; //Field offset: 0xC8
	private float _fadeEndDistanceSqr; //Field offset: 0xCC
	private float _fadeLengthDistanceSqr; //Field offset: 0xD0

	public float IntensityMultiplier
	{
		 set { } //Length: 9
	}

	public CullingAdvancedLightObject() { }

	protected virtual void Awake() { }

	protected float CalculateMultiplayer() { }

	public virtual void CustomUpdate() { }

	protected virtual void OnDestroy() { }

	protected override void OnDisable() { }

	public void set_IntensityMultiplier(float value) { }

	public virtual void SetVisibility(bool isVisible) { }

	protected void UpdateCullingObject(float multiplier) { }

	private void UpdateIntensity() { }

}

