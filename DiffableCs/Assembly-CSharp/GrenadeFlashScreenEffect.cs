//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class GrenadeFlashScreenEffect : MonoBehaviour
{
	private const string BLINDNESSCOEF = "_BlindnessCoef"; //Field offset: 0x0
	private static readonly int _coef; //Field offset: 0x0
	public PrismEffects PrismEffects; //Field offset: 0x20
	public AnimationCurve WhiteBlack; //Field offset: 0x28
	public Material FlashMaterial; //Field offset: 0x30
	[CompilerGenerated]
	private float <EffectStrength>k__BackingField; //Field offset: 0x38
	private Vector3 _toneValues; //Field offset: 0x3C
	private float _explosionTime; //Field offset: 0x48
	private float _flashStrength; //Field offset: 0x4C
	private float _flashTime; //Field offset: 0x50
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x58

	public float EffectStrength
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private static GrenadeFlashScreenEffect() { }

	public GrenadeFlashScreenEffect() { }

	private void Awake() { }

	public void Explode(float flashStrength) { }

	[CompilerGenerated]
	public float get_EffectStrength() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

	[CompilerGenerated]
	public void set_EffectStrength(float value) { }

	private void Update() { }

}

