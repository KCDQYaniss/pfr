//Type is in global namespace

[DisallowMultipleComponent]
public class BloodOnScreen : MonoBehaviour
{
	private static readonly int DudvPropertyName; //Field offset: 0x0
	private static readonly int BloodAmountPropertyName; //Field offset: 0x4
	private static readonly int RefractionPropertyName; //Field offset: 0x8
	private static readonly int FadeTimeProperty; //Field offset: 0xC
	private static readonly int BloodColorPropertyName; //Field offset: 0x10
	private static readonly int _inputMin; //Field offset: 0x14
	private static readonly int _inputMax; //Field offset: 0x18
	private static readonly int _inputGamma; //Field offset: 0x1C
	private static readonly int _outputMin; //Field offset: 0x20
	private static readonly int _outputMax; //Field offset: 0x24
	private static readonly int _blured; //Field offset: 0x28
	private static readonly int _addTex; //Field offset: 0x2C
	private static readonly int _dataId; //Field offset: 0x30
	private static readonly int _ColorId; //Field offset: 0x34
	public bool DebugMode; //Field offset: 0x20
	public float BloodColorValue; //Field offset: 0x24
	public float Refraction; //Field offset: 0x28
	public int DownsamplingCount; //Field offset: 0x2C
	public float MaxBloodTime; //Field offset: 0x30
	public int InitialBloodDrops; //Field offset: 0x34
	public Color BloodColor; //Field offset: 0x38
	public bool GenerateUniqueMaterials; //Field offset: 0x48
	public Shader BloodShader; //Field offset: 0x50
	public Material BlitMaterial; //Field offset: 0x58
	public Material FadeoutMat; //Field offset: 0x60
	public Material BloodDropMaterial; //Field offset: 0x68
	private Material _bloodMaterial; //Field offset: 0x70
	public int RenderTextureDimension; //Field offset: 0x78
	private BloodDropsController _bloodDropsController; //Field offset: 0x80
	private RenderTexture _duDvMap; //Field offset: 0x88
	public Vector2 StartScaleDimension; //Field offset: 0x90
	public Vector2 EndScaleDimension; //Field offset: 0x98
	public Vector2 DropCountRange; //Field offset: 0xA0
	public Vector2 MaxRayLength; //Field offset: 0xA8
	public Vector2 StartXdistribution; //Field offset: 0xB0
	public Vector2 StartYdistribution; //Field offset: 0xB8
	public Vector2 EndXdistribution; //Field offset: 0xC0
	public Vector2 EndYdistribution; //Field offset: 0xC8
	public Vector2 DropLifetimeDistribution; //Field offset: 0xD0
	public float OffGlassScaleMultiplier; //Field offset: 0xD8
	public float OffGlassLifetimeMultiplier; //Field offset: 0xDC
	private BloodDropPlacer _bloodDropPlacer; //Field offset: 0xE0
	public int Mode; //Field offset: 0xE8
	[HideInInspector]
	[SerializeField]
	public float InputMinL; //Field offset: 0xEC
	[HideInInspector]
	[SerializeField]
	public float InputMaxL; //Field offset: 0xF0
	[HideInInspector]
	[SerializeField]
	public float InputGammaL; //Field offset: 0xF4
	[HideInInspector]
	[SerializeField]
	public float InputMinR; //Field offset: 0xF8
	[HideInInspector]
	[SerializeField]
	public float InputMaxR; //Field offset: 0xFC
	[HideInInspector]
	[SerializeField]
	public float InputGammaR; //Field offset: 0x100
	[HideInInspector]
	[SerializeField]
	public float InputMinG; //Field offset: 0x104
	[HideInInspector]
	[SerializeField]
	public float InputMaxG; //Field offset: 0x108
	[HideInInspector]
	[SerializeField]
	public float InputGammaG; //Field offset: 0x10C
	[HideInInspector]
	[SerializeField]
	public float InputMinB; //Field offset: 0x110
	[HideInInspector]
	[SerializeField]
	public float InputMaxB; //Field offset: 0x114
	[HideInInspector]
	[SerializeField]
	public float InputGammaB; //Field offset: 0x118
	[HideInInspector]
	[SerializeField]
	public float OutputMinL; //Field offset: 0x11C
	[HideInInspector]
	[SerializeField]
	public float OutputMaxL; //Field offset: 0x120
	[HideInInspector]
	[SerializeField]
	public float OutputMinR; //Field offset: 0x124
	[HideInInspector]
	[SerializeField]
	public float OutputMaxR; //Field offset: 0x128
	[HideInInspector]
	[SerializeField]
	public float OutputMinG; //Field offset: 0x12C
	[HideInInspector]
	[SerializeField]
	public float OutputMaxG; //Field offset: 0x130
	[HideInInspector]
	[SerializeField]
	public float OutputMinB; //Field offset: 0x134
	[HideInInspector]
	[SerializeField]
	public float OutputMaxB; //Field offset: 0x138
	public Vector2 center; //Field offset: 0x13C
	[Range(-100, 100)]
	public float sharpness; //Field offset: 0x144
	[Range(0, 100)]
	public float darkness; //Field offset: 0x148
	private float _lastHeavyBleedingHitTime; //Field offset: 0x14C
	protected Material _vignetteMaterial; //Field offset: 0x150
	private float _lastHitTime; //Field offset: 0x158
	private RenderTexture _tempRt; //Field offset: 0x160
	private RenderTexture _onBloodImageRenderedTmpRT; //Field offset: 0x168
	private RenderTexture _tmpHalfRT; //Field offset: 0x170
	private RenderTexture _tmpQuarterRT; //Field offset: 0x178
	private bool _locked; //Field offset: 0x180
	private bool _hasGlasses; //Field offset: 0x181
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x188

	protected Material VignetteMaterial
	{
		 get { } //Length: 469
	}

	private static BloodOnScreen() { }

	public BloodOnScreen() { }

	private void ApplyVignette(RenderTexture source, RenderTexture destination) { }

	private void Awake() { }

	public void ChangeGlassesState(bool hasGlasses) { }

	private void CreateRenderTextures() { }

	private void DestroyAssets() { }

	private void FadeDrops() { }

	protected Material get_VignetteMaterial() { }

	public void Hit(Vector3 direction) { }

	public void HitBleeding(Vector3 direction, bool isArterial = false) { }

	private void OnBloodImageRendered(RenderTexture texture) { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture source, RenderTexture destination) { }

	private void PreWarm() { }

	private void SetValues() { }

	private void Start() { }

	private void Update() { }

}

