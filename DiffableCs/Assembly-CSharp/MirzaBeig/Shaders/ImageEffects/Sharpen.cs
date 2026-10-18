namespace MirzaBeig.Shaders.ImageEffects;

[ExecuteInEditMode]
public class Sharpen : IEBase
{
	private static readonly int _strength; //Field offset: 0x0
	private static readonly int _edgeMult; //Field offset: 0x4
	[Range(-2, 2)]
	public float strength; //Field offset: 0x38
	[Range(0, 8)]
	public float edgeMult; //Field offset: 0x3C

	private static Sharpen() { }

	public Sharpen() { }

	private void Awake() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

	private void Update() { }

}

