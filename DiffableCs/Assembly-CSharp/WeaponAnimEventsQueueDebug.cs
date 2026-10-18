//Type is in global namespace

public class WeaponAnimEventsQueueDebug : MonoBehaviour
{
	private GUIStyle _style; //Field offset: 0x20
	private GUIStyle _redStyle; //Field offset: 0x28
	private GUIStyle _greenStyle; //Field offset: 0x30
	private Texture2D _texture; //Field offset: 0x38
	private Player _playerToDebug; //Field offset: 0x40
	private float _lastUpdateNextShotDurability; //Field offset: 0x48
	private float _prevNextShotDurabilityLos; //Field offset: 0x4C
	private float _prevNextShotResourceLoss; //Field offset: 0x50

	public WeaponAnimEventsQueueDebug() { }

	private void CreateStyle() { }

	private Texture2D MakeTex(int width, int height, Color col) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	public void SetDebugObject(Player toDebug) { }

}

