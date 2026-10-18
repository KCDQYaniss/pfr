//Type is in global namespace

[AddComponentMenu("Colorful/Wiggle")]
[ExecuteInEditMode]
public class CC_Wiggle : CC_Base
{
	private static readonly int _timer; //Field offset: 0x0
	private static readonly int _scale; //Field offset: 0x4
	private static readonly int _str; //Field offset: 0x8
	public float timer; //Field offset: 0x38
	public float speed; //Field offset: 0x3C
	public float scale; //Field offset: 0x40
	public float str; //Field offset: 0x44
	public bool autoTimer; //Field offset: 0x48

	private static CC_Wiggle() { }

	public CC_Wiggle() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected override void Update() { }

}

