namespace Coffee.UISoftMask;

public class GraphicProxy
{
	private static readonly List s_Proxies; //Field offset: 0x0

	private static GraphicProxy() { }

	public GraphicProxy() { }

	public static GraphicProxy Find(Graphic graphic) { }

	public override float GetAlpha(Graphic graphic) { }

	public override Texture GetMainTexture(Graphic graphic) { }

	protected override bool IsValid(Graphic graphic) { }

	public static void Register(GraphicProxy proxy) { }

	public override void SetMaterialDirty(Graphic graphic) { }

}

