namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingGridContent : MonoBehaviour
{
	[SerializeField]
	private CullingGridCellContent[] _cellContent; //Field offset: 0x20

	public CullingGridCellContent[] CellContent
	{
		 get { } //Length: 5
	}

	public CullingGridContent() { }

	public CullingGridCellContent[] get_CellContent() { }

}

