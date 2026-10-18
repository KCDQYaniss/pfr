namespace UnityEngine.UIElements.UIR;

internal class DrawParams
{
	internal static readonly Rect k_UnlimitedRect; //Field offset: 0x0
	internal static readonly Rect k_FullNormalizedRect; //Field offset: 0x10
	internal readonly Stack view; //Field offset: 0x10
	internal readonly Stack scissor; //Field offset: 0x18
	internal readonly List renderTexture; //Field offset: 0x20
	internal readonly List defaultMaterial; //Field offset: 0x28

	private static DrawParams() { }

	public DrawParams() { }

	public void Reset() { }

}

