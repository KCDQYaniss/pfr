//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class IconShadow : MonoBehaviour
{
	private static readonly int _size; //Field offset: 0x0
	private static readonly int _offset; //Field offset: 0x4
	private static readonly int _color; //Field offset: 0x8
	private static readonly int _shadow; //Field offset: 0xC
	[SerializeField]
	private Color _shadowColor; //Field offset: 0x20
	[SerializeField]
	private Vector2 _shadowOffset; //Field offset: 0x30
	private Material _shadowMaterial; //Field offset: 0x38
	private Material _blitMaterial; //Field offset: 0x40
	private Vector4 _textureSize; //Field offset: 0x48
	private Camera _cam; //Field offset: 0x58

	private Material BlitMaterial
	{
		private get { } //Length: 1003
	}

	private Material ShadowMaterial
	{
		private get { } //Length: 1291
	}

	private static IconShadow() { }

	public IconShadow() { }

	private Material get_BlitMaterial() { }

	private Material get_ShadowMaterial() { }

	private void OnRenderImage(RenderTexture source, RenderTexture dest) { }

	public void SetTexDimension(int width, int height) { }

}

