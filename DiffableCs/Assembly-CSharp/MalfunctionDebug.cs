//Type is in global namespace

public class MalfunctionDebug : MonoBehaviour
{
	private GUIStyle _style; //Field offset: 0x20
	private GUIStyle _redStyle; //Field offset: 0x28
	private GUIStyle _greenStyle; //Field offset: 0x30
	private Texture2D _texture; //Field offset: 0x38
	private Player _playerToDebug; //Field offset: 0x40
	private float _prevRandom; //Field offset: 0x48
	private int _yPos; //Field offset: 0x4C
	private List _malfSourceTuples; //Field offset: 0x50
	private Dictionary _shotCounters; //Field offset: 0x58
	private Dictionary _shotCountersDuringMalf; //Field offset: 0x60

	public MalfunctionDebug() { }

	private void CreateStyle() { }

	private string GetDebugSources(List sources) { }

	private string GetDebugSourceStates(EMalfunctionSource currentSource, List states) { }

	private void InitY(int value) { }

	private Texture2D MakeTex(int width, int height, Color col) { }

	private int NextY(int incVal) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	public void SetDebugObject(Player toDebug) { }

	public static void SimulateShotsAndGatherStats(int shotsCount, FirearmController firearmController, string filePath = null) { }

}

