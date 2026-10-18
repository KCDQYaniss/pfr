//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Posteffect : MonoBehaviour
{
	[SerializeField]
	protected Shader EffectShader; //Field offset: 0x20
	[SerializeField]
	protected string EffectValueName; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	private float _effectAmount; //Field offset: 0x30
	protected Material EffectMaterial; //Field offset: 0x38

	public float EffectAmount
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public Posteffect() { }

	public float get_EffectAmount() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destanation) { }

	public void set_EffectAmount(float value) { }

	protected override void Start() { }

}

