namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class MotionBlur : ImageEffectBase
{
	private static readonly int _mainTex; //Field offset: 0x0
	private static readonly int _accumOrig; //Field offset: 0x4
	public float blurAmount; //Field offset: 0x30
	public bool extraBlur; //Field offset: 0x34
	private RenderTexture accumTexture; //Field offset: 0x38
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x40

	private static MotionBlur() { }

	public MotionBlur() { }

	private void Awake() { }

	protected virtual void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

