namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingPostProcess : MonoBehaviour
{
	[SerializeField]
	private bool _remove; //Field offset: 0x20

	public bool ShouldRemove
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public PerfectCullingPostProcess() { }

	public bool get_ShouldRemove() { }

	public void set_ShouldRemove(bool value) { }

}

