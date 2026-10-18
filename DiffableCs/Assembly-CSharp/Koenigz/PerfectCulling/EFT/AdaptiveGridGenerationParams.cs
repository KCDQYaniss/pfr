namespace Koenigz.PerfectCulling.EFT;

public sealed class AdaptiveGridGenerationParams : MonoBehaviour
{
	[SerializeField]
	private bool _disableHierarchy; //Field offset: 0x20
	[SerializeField]
	private float _verticalOffset; //Field offset: 0x24

	public bool DisableHierarchy
	{
		 get { } //Length: 5
	}

	public float VerticalOffset
	{
		 get { } //Length: 6
	}

	public AdaptiveGridGenerationParams() { }

	public void Apply() { }

	public bool get_DisableHierarchy() { }

	public float get_VerticalOffset() { }

	public void Revert() { }

}

