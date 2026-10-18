namespace Koenigz.PerfectCulling.EFT.Autotest;

public sealed class PerfectCullingAutoTestCamera : MonoBehaviour
{
	[SerializeField]
	private int _renderTextureSize; //Field offset: 0x20

	public int RenderTextureSize
	{
		 get { } //Length: 4
	}

	public PerfectCullingAutoTestCamera() { }

	public int get_RenderTextureSize() { }

}

