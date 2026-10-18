//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class VisorEffect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <HitSwing>d__79 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public VisorEffect <>4__this; //Field offset: 0x20
		private float <rndX>5__2; //Field offset: 0x28
		private float <rndY>5__3; //Field offset: 0x2C
		private float <i>5__4; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <HitSwing>d__79(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum EMask
	{
		NoMask = 0,
		Narrow = 1,
		Wide = 2,
	}

	internal class VisorMask
	{
		public EMask EMask; //Field offset: 0x10
		public Texture Texture; //Field offset: 0x18

		public VisorMask() { }

	}

	private const string MASK = "_Mask"; //Field offset: 0x0
	private const string ISAFFECTEDBYLIGHT = "_IsAffectedByLight"; //Field offset: 0x0
	private const string MINLIGHTVALUE = "_MinLightValue"; //Field offset: 0x0
	private const string EDGEFADE = "_EdgeFade"; //Field offset: 0x0
	private const string INTENSITY = "_Intensity"; //Field offset: 0x0
	private const string DISTORTINTENSITY = "_DistortIntensity"; //Field offset: 0x0
	private const string ROTATION = "_Rotation"; //Field offset: 0x0
	private const string GLASSDAMAGETEX = "_GlassDamageTex"; //Field offset: 0x0
	private const string BLURTEX = "_BlurTex"; //Field offset: 0x0
	private const string BLURMASK = "_BlurMask"; //Field offset: 0x0
	private const string SCRATCHESINTENSITY = "_ScratcesIntensity"; //Field offset: 0x0
	private const string SCRATCHESTEX = "_ScratchesTex"; //Field offset: 0x0
	private const string HITZOOMVALUE = "_HitZoomValue"; //Field offset: 0x0
	private const string DISTORTMASK = "_DistortMask"; //Field offset: 0x0
	private const string SWINGVALUE = "_SwingValue"; //Field offset: 0x0
	private const string PARAMETER = "_Parameter"; //Field offset: 0x0
	[Range(0, 1)]
	public float Intensity; //Field offset: 0x20
	public AnimationCurve EdgeFadeCurve; //Field offset: 0x28
	public Shader VisorShader; //Field offset: 0x30
	public List VisorMasks; //Field offset: 0x38
	public Texture Mask; //Field offset: 0x40
	public Texture Scratches; //Field offset: 0x48
	[Range(0, 1)]
	public float ScratcesIntensity; //Field offset: 0x50
	[SerializeField]
	private Material _glassDamageMaterial; //Field offset: 0x58
	[Range(0, 1)]
	public float MinLightValue; //Field offset: 0x60
	public bool IsAffectedByLight; //Field offset: 0x64
	private RenderTexture _glassDamageRenderTexture; //Field offset: 0x68
	public GameObject VisorEffectPrefab; //Field offset: 0x70
	[Header("Blur")]
	public Texture BlurMask; //Field offset: 0x78
	[Range(0, 2)]
	public int downsample; //Field offset: 0x80
	[Range(0, 10)]
	public float blurSize; //Field offset: 0x84
	[Range(1, 4)]
	public int blurIterations; //Field offset: 0x88
	[Header("Distort")]
	public Texture DistortMask; //Field offset: 0x90
	public float DistortIntensity; //Field offset: 0x98
	[Header("Swing")]
	[Range(-1, 1)]
	public float SwingValue; //Field offset: 0x9C
	public AnimationCurve DX; //Field offset: 0xA0
	public AnimationCurve DY; //Field offset: 0xA8
	public AnimationCurve HitSwingCurve; //Field offset: 0xB0
	public AnimationCurve WalkRotation; //Field offset: 0xB8
	public float HitZoomMultiply; //Field offset: 0xC0
	private bool _couldBeSwinged; //Field offset: 0xC4
	private float _curveTime; //Field offset: 0xC8
	private Vector2 _swingValue; //Field offset: 0xCC
	private float _currentWalkRotation; //Field offset: 0xD4
	private Vector2 _currentHitdir; //Field offset: 0xD8
	private float _currentHitZoom; //Field offset: 0xE0
	private bool _visible; //Field offset: 0xE4
	protected SSAAPropagator _ssaaPropagator; //Field offset: 0xE8
	[HideInInspector]
	public float StepFrequency; //Field offset: 0xF0
	[HideInInspector]
	public float Velocity; //Field offset: 0xF4
	private Material _material; //Field offset: 0xF8
	private Material _materialUnlit; //Field offset: 0x100
	private Dictionary _visorMaskDictionary; //Field offset: 0x108
	[SerializeField]
	private Shader _blurShader; //Field offset: 0x110
	private Material _blurMaterial; //Field offset: 0x118
	private GameObject _visorPoint; //Field offset: 0x120

	public bool Visible
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public VisorEffect() { }

	public void BreakCompletely(byte seed, bool isBroken) { }

	public void Clear() { }

	private void ClearAllTextures() { }

	private void CreateVisorMaskDictionary() { }

	private void CreateVisorPoint() { }

	public void Draw(Vector3 position, Vector3 scale, float rotation) { }

	public void DrawScratches(byte seed, int hitCount) { }

	public bool get_Visible() { }

	private Material GetBlurMaterial() { }

	private Material GetMaterial() { }

	private RenderTexture GetOrCreateGlassRenderTexture() { }

	[IteratorStateMachine(typeof(<HitSwing>d__79))]
	private IEnumerator HitSwing() { }

	public void Modify(ref RenderTexture source, ref RenderTexture myTex) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageImpl(RenderTexture source, RenderTexture destination) { }

	public void set_Visible(bool value) { }

	private void SetDefault() { }

	public void SetIntensity(float intensity) { }

	public void SetMask(EMask mask) { }

	private void SetSwing(Material material) { }

	private void Start() { }

	private void Update() { }

}

