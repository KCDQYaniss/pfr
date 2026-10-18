namespace Koenigz.PerfectCulling.EFT;

[DisallowMultipleComponent]
public sealed class PerfectCullingCrossSceneContentMeshes : PerfectCullingCrossSceneContent
{
	[SerializeField]
	private Renderer[] _windows; //Field offset: 0x40

	public Renderer[] Windows
	{
		 get { } //Length: 5
	}

	public PerfectCullingCrossSceneContentMeshes() { }

	public void FillWindows() { }

	public Renderer[] get_Windows() { }

}

