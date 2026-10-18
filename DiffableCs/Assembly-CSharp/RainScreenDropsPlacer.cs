//Type is in global namespace

public class RainScreenDropsPlacer
{
	private const float AmountScale = 1.2; //Field offset: 0x0
	private const float _intensityThreshold = 0.15; //Field offset: 0x0
	[CompilerGenerated]
	private float <Intensity>k__BackingField; //Field offset: 0x10
	private RenderTexture _dropsTexture; //Field offset: 0x18
	private float _rainDropsDelay; //Field offset: 0x20
	private Vector2 _dropsScale; //Field offset: 0x24
	private float _dropLifetime; //Field offset: 0x2C
	private float _dropLifetimeWihtoutGlass; //Field offset: 0x30
	private int _maxDropsAtOnce; //Field offset: 0x34
	private bool _invertLifetime; //Field offset: 0x38
	private readonly Queue _freeDrops; //Field offset: 0x40
	private readonly List _dropsInUse; //Field offset: 0x48
	private readonly List _pendingForRemovalList; //Field offset: 0x50
	private Transform _cameraTransform; //Field offset: 0x58
	private Camera _targetCamera; //Field offset: 0x60
	private Material _dropMaterial; //Field offset: 0x68
	private float _timer; //Field offset: 0x70
	private bool enabled; //Field offset: 0x74
	private float _offGlassScaleMultiplier; //Field offset: 0x78
	private float _currentScaleMultiplier; //Field offset: 0x7C
	private float _currentDropLifetime; //Field offset: 0x80

	public float Intensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public RainScreenDropsPlacer(AnimationCurve scaleCurve, RenderTexture dropsTexture, int dropsAmount, float rainDropsDelay, Vector2 dropsScale, float dropLifetime, float dropLifetimeWithoutGlass, int maxDropsAtOnce, Camera targetCamera, Material dropMaterial, float offGlassScaleMultiplier) { }

	private void BackDropCallback(SingleDrop drop) { }

	public void ChangeGlassState(bool hasGlasses) { }

	public void Clear() { }

	[CompilerGenerated]
	public float get_Intensity() { }

	[CompilerGenerated]
	public void set_Intensity(float value) { }

	private void SpawnDrop(float amount) { }

	public void Update(float dt) { }

	private void UpdateAndDrawDrops(float dt) { }

	public void UpdateValues(AnimationCurve scaleCurve, RenderTexture dropsTexture, int dropsAmount, float rainDropsDelay, Vector2 dropsScale, float dropLifetime, float dropLifetimeWithoutGlass, int maxDropsAtOnce, Camera targetCamera, Material dropMaterial, float offGlassScaleMultiplier) { }

}

