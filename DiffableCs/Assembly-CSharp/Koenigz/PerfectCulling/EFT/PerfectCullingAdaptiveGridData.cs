namespace Koenigz.PerfectCulling.EFT;

[CreateAssetMenu(fileName = "New grid data", menuName = "Perfect Culling/Adaptive grid data", order = 1)]
[PreferBinarySerialization]
public sealed class PerfectCullingAdaptiveGridData : ScriptableObject
{
	public const int INVALID_GROUP_INDEX = -1; //Field offset: 0x0
	[SerializeField]
	public List CellData; //Field offset: 0x18
	[SerializeField]
	public List GroupMapping; //Field offset: 0x20

	public int NumCells
	{
		 get { } //Length: 65
	}

	public PerfectCullingAdaptiveGridData() { }

	public int get_NumCells() { }

	public int GetGroupIndex(GuidReference groupGuid) { }

	public void ReadFromFile(string filePath, CancellationToken token, IProgress progress = null) { }

}

