//Type is in global namespace

public class TraderServicesDebug : MonoBehaviour
{
	private const int BACKGROUND_WIDTH = 250; //Field offset: 0x0
	private Player _player; //Field offset: 0x20
	private ClientPlayer _clientPlayer; //Field offset: 0x28
	private GUIStyle _style; //Field offset: 0x30
	private Texture2D _texture; //Field offset: 0x38

	public TraderServicesDebug() { }

	private void CreateStyle() { }

	private CultistAmulet GetAmulet() { }

	private Texture2D MakeTex(int width, int height, Color col) { }

	private void OnGUI() { }

	public void SetDebugObject(Player player) { }

}

