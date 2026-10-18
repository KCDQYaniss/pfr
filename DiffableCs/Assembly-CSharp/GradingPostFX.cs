//Type is in global namespace

[ExecuteInEditMode]
public class GradingPostFX : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public ColorBlindMode colorBlindMode; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <GetCurrentColorBlindTexture>b__0(ColorBlindConnector colorBlindTexture) { }

	}

	internal class ColorBlindConnector
	{
		public ColorBlindMode ColorBlindMode; //Field offset: 0x10
		public Texture2D Texture; //Field offset: 0x18

		public ColorBlindConnector() { }

	}

	internal enum ColorBlindMode
	{
		None = 0,
		Deuteranopia = 1,
		Tritanopia = 2,
		Protanopia = 3,
	}

	private static readonly int _tex3Id; //Field offset: 0x0
	private static readonly int _adaptiveSharpenId; //Field offset: 0x4
	private static readonly int _clarityStrengthId; //Field offset: 0x8
	private static readonly int _brightnessId; //Field offset: 0xC
	private static readonly int _saturationId; //Field offset: 0x10
	private static readonly int _colourfulnessId; //Field offset: 0x14
	private static readonly int _lumaSharpenStrengthId; //Field offset: 0x18
	private static readonly int _adaptiveSharpenStrengthId; //Field offset: 0x1C
	private static readonly int _desaturateId; //Field offset: 0x20
	private static readonly int _colorBlindTexId; //Field offset: 0x24
	private static readonly int _colorBlindScaleId; //Field offset: 0x28
	private static readonly int _colorBlindOffsetId; //Field offset: 0x2C
	private static readonly int _blindAmountId; //Field offset: 0x30
	private static readonly int _lutTextId; //Field offset: 0x34
	private static readonly int _lutAmountId; //Field offset: 0x38
	[SerializeField]
	private Shader _shader; //Field offset: 0x20
	[SerializeField]
	private List _colorBlindTextures; //Field offset: 0x28
	private Camera _camera; //Field offset: 0x30
	private SSAA _ssaa; //Field offset: 0x38
	private Material _material; //Field offset: 0x40
	private RenderTexture _tmpTex; //Field offset: 0x48
	private RenderTexture _finalTex; //Field offset: 0x50
	private RenderTexture _clarityTex; //Field offset: 0x58
	private RenderTexture _clarityTex2; //Field offset: 0x60
	private RenderTexture _clarityTex3; //Field offset: 0x68
	private RenderTexture _adaptiveSharpen; //Field offset: 0x70
	private Texture3D _lut3d; //Field offset: 0x78
	private float _clarityStrength; //Field offset: 0x80
	private float _brightness; //Field offset: 0x84
	private float _saturation; //Field offset: 0x88
	private float _colourfulness; //Field offset: 0x8C
	private float _lumaSharpenStrength; //Field offset: 0x90
	private float _adaptiveSharpenStrength; //Field offset: 0x94
	private ColorBlindMode _colorBlindMode; //Field offset: 0x98
	private float _colorBlindAmount; //Field offset: 0x9C
	private Filter _currentFilter; //Field offset: 0xA0
	private float _currentFilterAmount; //Field offset: 0xA4
	private CC_Sharpen _desaturateEffect; //Field offset: 0xA8
	private Texture2D _lutTexture; //Field offset: 0xB0
	private readonly Vector2 _clarityStrengthMinMax; //Field offset: 0xB8
	private readonly Vector2 _technicolorBrightnessMinMax; //Field offset: 0xC0
	private readonly Vector2 _technicolorSaturationMinMax; //Field offset: 0xC8
	private readonly Vector2 _desaturateMultiplyMinMax; //Field offset: 0xD0
	private readonly Vector2 _colourfulnessMinMax; //Field offset: 0xD8
	private readonly Vector2 _lumaSharpenStrengthMinMax; //Field offset: 0xE0
	private readonly Vector2 _adaptiveSharpenStrengthMinMax; //Field offset: 0xE8
	[CompilerGenerated]
	private Action OnAfterDestroy; //Field offset: 0xF0
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xF8

	public event Action OnAfterDestroy
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	private static GradingPostFX() { }

	public GradingPostFX() { }

	[CompilerGenerated]
	public void add_OnAfterDestroy(Action value) { }

	private void Awake() { }

	private void CreateLut3d(Texture2D texture) { }

	private void CreateRenderTextures(int cameraWidth, int cameraHeight) { }

	private void Destroy() { }

	private Texture2D GetCurrentColorBlindTexture(ColorBlindMode colorBlindMode) { }

	private int GetPixelHeight() { }

	private int GetPixelWidth() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[CompilerGenerated]
	public void remove_OnAfterDestroy(Action value) { }

	private void RenderAdaptiveSharpness() { }

	private void RenderClarity() { }

	private void RenderColorBlindness() { }

	private void RenderColorGrading() { }

	private void RenderLUTColoring() { }

	public void SetColorBlindMode(ColorBlindMode colorBlindMode) { }

	public void SetFilter(Filter filter) { }

	public override void Update() { }

	public void UpdateAdaptiveSharpenStrength(float coef) { }

	public void UpdateClarityStrength(float coef) { }

	public void UpdateColorBlindAmount(float coef) { }

	public void UpdateColourfullness(float coef) { }

	private void UpdateDynamicValues() { }

	public void UpdateFilterAmount(float coef) { }

	public void UpdateLumaSharpenStrength(float coef) { }

	public void UpdateTechnicolorBrightness(float coef) { }

	public void UpdateTechnicolorSaturation(float coef) { }

	private void СreateMaterial() { }

}

