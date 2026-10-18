namespace GPUInstancer;

public class TerrainGenerator : MonoBehaviour
{
	public static readonly string HELPTEXT_detailHealthyColor; //Field offset: 0x0
	public static readonly string HELPTEXT_detailDryColor; //Field offset: 0x8
	public static readonly string HELPTEXT_noiseSpread; //Field offset: 0x10
	public static readonly string HELPTEXT_ambientOcclusion; //Field offset: 0x18
	public static readonly string HELPTEXT_gradientPower; //Field offset: 0x20
	public static readonly string HELPTEXT_windIdleSway; //Field offset: 0x28
	public static readonly string HELPTEXT_windWavesOn; //Field offset: 0x30
	public static readonly string HELPTEXT_windWaveTintColor; //Field offset: 0x38
	public static readonly string HELPTEXT_windWaveSize; //Field offset: 0x40
	public static readonly string HELPTEXT_windWaveSway; //Field offset: 0x48
	public static readonly string HELPTEXT_windWaveTint; //Field offset: 0x50
	public static readonly string HELPTEXT_isBillboard; //Field offset: 0x58
	public static readonly string HELPTEXT_crossQuads; //Field offset: 0x60
	public static readonly string HELPTEXT_quadCount; //Field offset: 0x68
	public static readonly string HELPTEXT_billboardDistance; //Field offset: 0x70
	public static readonly string HELPTEXT_detailScale; //Field offset: 0x78
	public static readonly string HELPTEXT_isShadowCasting; //Field offset: 0x80
	public static readonly string HELPTEXT_isFrustumCulling; //Field offset: 0x88
	public static readonly string HELPTEXT_frustumOffset; //Field offset: 0x90
	public static readonly string HELPTEXT_maxDetailDistance; //Field offset: 0x98
	public static readonly string HELPTEXT_windVector; //Field offset: 0xA0
	public Texture2D groundTexture; //Field offset: 0x20
	public Texture2D detailTexture; //Field offset: 0x28
	public GameObject FpsController; //Field offset: 0x30
	public GameObject FixedCamera; //Field offset: 0x38
	private int terrainSize; //Field offset: 0x40
	private int terrainCounter; //Field offset: 0x44
	private Vector3 terrainShiftX; //Field offset: 0x48
	private Vector3 terrainShiftZ; //Field offset: 0x54
	private Terrain[] terrainArray; //Field offset: 0x60
	private bool isCurrentCameraFixed; //Field offset: 0x68
	private Color _healthyColor; //Field offset: 0x6C
	private Color _dryColor; //Field offset: 0x7C
	private float _noiseSpread; //Field offset: 0x8C
	private float _ambientOcclusion; //Field offset: 0x90
	private float _gradientPower; //Field offset: 0x94
	private float _windIdleSway; //Field offset: 0x98
	private bool _windWavesOn; //Field offset: 0x9C
	private float _windWaveTint; //Field offset: 0xA0
	private float _windWaveSize; //Field offset: 0xA4
	private float _windWaveSway; //Field offset: 0xA8
	private Color _windWaveTintColor; //Field offset: 0xAC
	private bool _isBillboard; //Field offset: 0xBC
	private bool _useCrossQuads; //Field offset: 0xBD
	private int _crossQuadCount; //Field offset: 0xC0
	private float _crossQuadBillboardDistance; //Field offset: 0xC4
	private Vector4 _scale; //Field offset: 0xC8
	private bool _isShadowCasting; //Field offset: 0xD8
	private bool _isFrustumCulling; //Field offset: 0xD9
	private float _frustumOffset; //Field offset: 0xDC
	private float _maxDistance; //Field offset: 0xE0
	private Image _healthyColorImage; //Field offset: 0xE8
	private Image _dryColorImage; //Field offset: 0xF0
	private Slider _noiseSpreadSlider; //Field offset: 0xF8
	private Slider _ambientOcclusionSlider; //Field offset: 0x100
	private Slider _gradientPowerSlider; //Field offset: 0x108
	private Slider _windIdleSwaySlider; //Field offset: 0x110
	private Toggle _windWavesOnToggle; //Field offset: 0x118
	private Slider _windWavesTintSlider; //Field offset: 0x120
	private Slider _windWavesSizeSlider; //Field offset: 0x128
	private Slider _windWavesSwaySlider; //Field offset: 0x130
	private Image _windWavesTintColorImage; //Field offset: 0x138
	private Toggle _billboardToggle; //Field offset: 0x140
	private Toggle _crossQuadsToggle; //Field offset: 0x148
	private Slider _crossQuadsCountSlider; //Field offset: 0x150
	private Slider _crossQuadsBillboardDistanceSlider; //Field offset: 0x158
	private InputField _scaleMinWidthInput; //Field offset: 0x160
	private InputField _scaleMaxWidthInput; //Field offset: 0x168
	private InputField _scaleMinHeightInput; //Field offset: 0x170
	private InputField _scaleMaxHeightInput; //Field offset: 0x178
	private Toggle _isShadowCastingToggle; //Field offset: 0x180
	private Toggle _isFrustumCullingToggle; //Field offset: 0x188
	private Slider _frustumOffsetSlider; //Field offset: 0x190
	private Slider _maxDistanceSlider; //Field offset: 0x198
	private Text _helpDescriptionText; //Field offset: 0x1A0
	private Text _helpDescriptionTitleText; //Field offset: 0x1A8
	private Selectable _addTerrainButton; //Field offset: 0x1B0
	private Selectable _removeTerrainButton; //Field offset: 0x1B8
	private Canvas _uiCanvas; //Field offset: 0x1C0

	private static TerrainGenerator() { }

	public TerrainGenerator() { }

	private void AddInstancer(Terrain terrain) { }

	public void AddTerrain() { }

	private TerrainData CreateTerrainData(int terrainSize, float terrainHeight, int baseTextureResolution = 16, int detailResolutionPerPatch = 16, SplatPrototype[] splatPrototypes = null, DetailPrototype[] detailPrototypes = null) { }

	private void GenerateTerrain() { }

	public void HideHelpDescription() { }

	private Terrain InitializeTerrainObject(Vector3 position, int terrainSize, float terrainHeight, int baseTextureResolution = 16, int detailResolutionPerPatch = 16, SplatPrototype[] splatPrototypes = null, DetailPrototype[] detailPrototypes = null) { }

	private void ManageButtons() { }

	public void ReInitializeManagers() { }

	public void RemoveTerrain() { }

	private void SetDetailMap(Terrain terrain) { }

	private void SetupUI() { }

	public void ShowHelpDescription(Text itemTitle) { }

	private TerrainLayer[] SplatPrototypesToTerrainLayers(SplatPrototype[] splatPrototypes) { }

	private void Start() { }

	private void SwitchCameras() { }

	private void Update() { }

	public void UpdateDetailSettings() { }

	private void UpdateManagers() { }

}

