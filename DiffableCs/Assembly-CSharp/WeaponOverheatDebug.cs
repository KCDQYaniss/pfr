//Type is in global namespace

public class WeaponOverheatDebug : MonoBehaviour
{
	private GUIStyle _style; //Field offset: 0x20
	private GUIStyle _redStyle; //Field offset: 0x28
	private GUIStyle _greenStyle; //Field offset: 0x30
	private Texture2D _texture; //Field offset: 0x38
	private Player _playerToDebug; //Field offset: 0x40

	public WeaponOverheatDebug() { }

	private void CreateStyle() { }

	private Texture2D MakeTex(int width, int height, Color col) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	public void SetDebugObject(Player toDebug) { }

}

