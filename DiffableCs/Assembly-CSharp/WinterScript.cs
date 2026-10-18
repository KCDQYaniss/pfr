//Type is in global namespace

public class WinterScript : MonoBehaviour
{
	internal class AudioLerper
	{
		private AudioClip _sourceClip; //Field offset: 0x10
		private float[] _data; //Field offset: 0x18
		private float[] _sourceData; //Field offset: 0x20
		private float[] _addData; //Field offset: 0x28
		private int _length; //Field offset: 0x30

		public AudioLerper(AudioClip sourceClip, float[] addData) { }

		public void Add(float f) { }

	}

	internal class TerrainDetailsRepaint
	{
		private class DetailColorLerper
		{
			private static readonly Color White; //Field offset: 0x0
			private DetailPrototype _prototype; //Field offset: 0x10
			private Color _dryColor; //Field offset: 0x18
			private Color _healthyColor; //Field offset: 0x28

			private static DetailColorLerper() { }

			public DetailColorLerper(DetailPrototype prototype) { }

			public void Lerp(float t) { }

			private static Color Lerp(Color a, Color b, float t) { }

		}

		private TerrainData _terrainData; //Field offset: 0x10
		private DetailPrototype[] _prototypes; //Field offset: 0x18
		private DetailColorLerper[] _lerpers; //Field offset: 0x20
		private int[] _green; //Field offset: 0x28
		private Color32[] _source; //Field offset: 0x30
		private Color32[] _current; //Field offset: 0x38
		private Texture2D _texture; //Field offset: 0x40
		private float _lastT; //Field offset: 0x48

		public TerrainDetailsRepaint(Terrain terrain, Texture2D detailTex) { }

		private static byte Add(byte a, int b) { }

		private static void CalcWithoutShader(Color32[] source, Color32[] current, int[] green) { }

		public void Update(float t) { }

	}

	private static readonly int _specColor; //Field offset: 0x0
	public float debugValue; //Field offset: 0x20
	public bool debugWrite; //Field offset: 0x24
	public Texture SnowTex; //Field offset: 0x28
	public float StartTime; //Field offset: 0x30
	public AnimationCurve SnowLevelCurve; //Field offset: 0x38
	public AnimationCurve SnowFallingCurve; //Field offset: 0x40
	public AnimationCurve DesaturateSunCurve; //Field offset: 0x48
	public AnimationCurve SunIntensityCurve; //Field offset: 0x50
	public AnimationCurve SoundsLerpCurve; //Field offset: 0x58
	public AudioClip[] SnowStepClip; //Field offset: 0x60
	public AudioClip SnowyWind; //Field offset: 0x68
	public AnimationCurve MusicFadeOut; //Field offset: 0x70
	public AnimationCurve MusicFadeIn; //Field offset: 0x78
	public AnimationCurve BreathCurve; //Field offset: 0x80
	public float FadeShadow; //Field offset: 0x88
	public float FadeScratches; //Field offset: 0x8C
	public float FadeFog; //Field offset: 0x90
	private Light _sun; //Field offset: 0x98
	private Color _sourceSunColor; //Field offset: 0xA0
	private Color _desaturatedSunColor; //Field offset: 0xB0
	private float _sunIntensity; //Field offset: 0xC0
	private float _shadowStrength; //Field offset: 0xC4
	private float _lastStepLerpVal; //Field offset: 0xC8
	private AudioSource _oldMusic; //Field offset: 0xD0
	private AudioSource _newMusic; //Field offset: 0xD8
	private LinkedList _lerpers; //Field offset: 0xE0
	public Transform BreathSystem; //Field offset: 0xE8
	private Transform _breathTr; //Field offset: 0xF0
	private ParticleSystem _breathPs; //Field offset: 0xF8
	private Transform _cameraParent; //Field offset: 0x100
	public LayerMask DepthRendererMask; //Field offset: 0x108
	public Material DepthMaterial; //Field offset: 0x110
	public Material TerrainMaterial; //Field offset: 0x118
	private TerrainDetailsRepaint _terrainDetailsRepaint; //Field offset: 0x120
	public AnimationCurve TerrainDetailCurve; //Field offset: 0x128
	public Texture2D[] TerrainDetails; //Field offset: 0x130

	private static WinterScript() { }

	public WinterScript() { }

	private static Color Desaturate(Color color) { }

	private static LinkedList FindTrees() { }

	private void FixTerrainSpecular() { }

	private static Vector2 GetMinMaxY() { }

	private void RenderSnowDepth() { }

	private void SoundInit() { }

	private void Start() { }

	private void StartLevel() { }

	private void Update() { }

}

