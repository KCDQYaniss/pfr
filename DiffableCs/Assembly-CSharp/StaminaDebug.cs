//Type is in global namespace

public class StaminaDebug : MonoBehaviour
{
	public PhysicalBase Physical; //Field offset: 0x20
	private GUIStyle _style; //Field offset: 0x28
	private Texture2D _texture; //Field offset: 0x30
	private Player _player; //Field offset: 0x38
	private RollingMedian _median; //Field offset: 0x40
	private int _index; //Field offset: 0x48
	private Vector3 _previousPosition; //Field offset: 0x4C

	public StaminaDebug() { }

	private void CreateStyle() { }

	private string GetDebugString(Stamina parameter, string title) { }

	private Texture2D MakeTex(int width, int height, Color col) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	public void SetDebugObject(Player toDebug) { }

	private void Update() { }

}

