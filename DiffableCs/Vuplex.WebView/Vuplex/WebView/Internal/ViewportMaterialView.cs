namespace Vuplex.WebView.Internal;

public class ViewportMaterialView : MonoBehaviour
{

	public override Material Material
	{
		 get { } //Length: 140
		 set { } //Length: 155
	}

	public override Texture Texture
	{
		 get { } //Length: 154
		 set { } //Length: 170
	}

	private Vector4 _toVector(Rect rect) { }

	public ViewportMaterialView() { }

	protected void Awake() { }

	public override Material get_Material() { }

	public override Texture get_Texture() { }

	public override void set_Material(Material value) { }

	public override void set_Texture(Texture value) { }

	[Obsolete("ViewportMaterialView.SetCutoutRect() has been replaced with ViewportMaterialView.SetRenderBlackAsTransparent(). Please call SetRenderBlackAsTransparent(true) instead.", True)]
	public void SetCutoutRect(Rect rect) { }

	public void SetFallbackVideoRect(Rect rect) { }

	public void SetFallbackVideoTexture(Texture2D texture) { }

	public void SetRenderBlackAsTransparent(bool enabled) { }

}

