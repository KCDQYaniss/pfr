//Type is in global namespace

[AddComponentMenu("Image Effects/SunOnGlass")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SunOnGlass : MonoBehaviour
{
	internal class SunBack
	{
		public Transform Light; //Field offset: 0x10
		public Texture SunTexture; //Field offset: 0x18
		public Color SunColor; //Field offset: 0x20
		public float size; //Field offset: 0x30
		public Transform _trans; //Field offset: 0x38
		private Vector3 _position; //Field offset: 0x40

		public SunBack() { }

		public Transform CreatePolygon() { }

		public Transform GetSun() { }

		public void Initialize(bool formEditor = false) { }

		public void UpdatePos(Vector3 camPos) { }

	}

	private static readonly int _screenTex; //Field offset: 0x0
	private static readonly int _tex; //Field offset: 0x4
	private static readonly int _sunColor; //Field offset: 0x8
	private static readonly int _sunPos; //Field offset: 0xC
	private static readonly int _sunVisible; //Field offset: 0x10
	public float Size; //Field offset: 0x20
	public Transform Sun; //Field offset: 0x28
	public Texture ScreenTexture; //Field offset: 0x30
	public Shader ScreenShader; //Field offset: 0x38
	public Shader VisibilityCheckerShader; //Field offset: 0x40
	public CustomLensFlare LensFlares; //Field offset: 0x48
	public SunBack SunBackGround; //Field offset: 0x50
	public Color SunColor; //Field offset: 0x58
	public AnimationCurve SunCurve; //Field offset: 0x68
	private bool _sunScratchesEnabled; //Field offset: 0x70
	private bool _lensFlaresEnabled; //Field offset: 0x71
	private bool _sunBackEnabled; //Field offset: 0x72
	private Texture _fallofTex; //Field offset: 0x78
	private Material _material; //Field offset: 0x80
	private Material _materialvc; //Field offset: 0x88
	private Camera _camera; //Field offset: 0x90
	private Transform _cameraTransform; //Field offset: 0x98
	private Texture2D _visibilityTexture; //Field offset: 0xA0
	private RenderTexture _vc1; //Field offset: 0xA8
	private RenderTexture _vc2; //Field offset: 0xB0
	private Rect _oneRect; //Field offset: 0xB8

	public int Settings
	{
		 set { } //Length: 34
	}

	private static SunOnGlass() { }

	public SunOnGlass() { }

	private static Color ColorCorrector(Color color) { }

	private Material GetMaterial() { }

	public static Texture2D GetTexFromCurve(AnimationCurve curve, int width = 255) { }

	private Material GetVisibilityCheckerMaterial() { }

	private bool LightVisible(Vector3 lightDirection, out Vector2 onScreen) { }

	private bool LightVisibleOnScreen(Vector2 lightPos) { }

	private void OnApplicationQuit() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_Settings(int value) { }

	public void Start() { }

	private void Update() { }

	private void VisibilityChecker(RenderTexture source, RenderTexture destination, Vector4 sunPos) { }

}

