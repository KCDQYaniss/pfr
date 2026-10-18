namespace RuntimeInspector;

public class Debugger : MonoBehaviour
{
	private static Vector2 skroll; //Field offset: 0x0
	public static Texture2D classTex; //Field offset: 0x8
	public static Texture2D fieldTex; //Field offset: 0x10
	public static Texture2D methodTex; //Field offset: 0x18
	public static GUIStyle normal; //Field offset: 0x20
	public static GUIStyle selected; //Field offset: 0x28
	public static GUIStyle ClassTypeStyle; //Field offset: 0x30
	public static GUIStyle ClassTypeStyle2; //Field offset: 0x38
	public static GUIStyle ClassTypeStyleSelected; //Field offset: 0x40
	public static GUIStyle ColorField; //Field offset: 0x48
	private static GUIStyle backGround; //Field offset: 0x50
	private static bool mouseDown; //Field offset: 0x58
	public static ViewInfo Info; //Field offset: 0x60
	public static DWindow Explorer; //Field offset: 0x68
	private static bool _enableViewDebugger; //Field offset: 0x70
	private static Component[] _selectedComponents; //Field offset: 0x78
	public Color BackGroundColor; //Field offset: 0x20
	public Color TextColor; //Field offset: 0x30
	public Color TypeTextColor; //Field offset: 0x40
	public Color SelectedTextColor; //Field offset: 0x50
	public Color SelectedBackGroundColor; //Field offset: 0x60
	public Texture2D ClassTex; //Field offset: 0x70
	public Texture2D FieldTex; //Field offset: 0x78
	public Texture2D MethodTex; //Field offset: 0x80
	private Rect mainRect; //Field offset: 0x88
	private Rect explorerRect; //Field offset: 0x98
	private Rect infoRect; //Field offset: 0xA8

	public Debugger() { }

	private void Awake() { }

	public static void Close() { }

	private static Texture2D FillTex(Color color, int width, int height) { }

	private object FindObject(string parameters) { }

	private void InitStyle() { }

	public static bool LastRectClick() { }

	private void OnGUI() { }

	private void OnValidate() { }

	public static void Open(object obj) { }

	private void RunViewDebugger() { }

	private void Update() { }

}

