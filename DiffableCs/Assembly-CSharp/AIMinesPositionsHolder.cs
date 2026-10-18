//Type is in global namespace

public class AIMinesPositionsHolder : MonoBehaviour
{
	public List Mines; //Field offset: 0x20
	private List _minesSimple; //Field offset: 0x28
	private List _minesPrewarm; //Field offset: 0x30

	public List MinesForRewarm
	{
		 get { } //Length: 76
	}

	public List MinesSimple
	{
		 get { } //Length: 5
	}

	public AIMinesPositionsHolder() { }

	public List get_MinesForRewarm() { }

	public List get_MinesSimple() { }

	public void InGameRestore(AICoversData data) { }

	public void SetMines(List minePoints) { }

}

