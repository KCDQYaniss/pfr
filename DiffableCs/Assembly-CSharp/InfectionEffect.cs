//Type is in global namespace

public sealed class InfectionEffect : MonoBehaviour
{
	private static int MASK_AREA_ID; //Field offset: 0x0
	[SerializeField]
	private Material _effectMaterial; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _refractCurve; //Field offset: 0x28
	[SerializeField]
	private AnimationCurve _infectCurve; //Field offset: 0x30
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	private float _effectValue; //Field offset: 0x40
	private Vector4 _maskArea; //Field offset: 0x44

	public float EffectValue
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	private static InfectionEffect() { }

	public InfectionEffect() { }

	private void Awake() { }

	public float get_EffectValue() { }

	private void InternalInfectImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_EffectValue(float value) { }

}

