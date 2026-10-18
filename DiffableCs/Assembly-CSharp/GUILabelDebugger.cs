//Type is in global namespace

public class GUILabelDebugger : MonoBehaviour
{
	private class DebugLabel
	{
		private readonly string _formatString; //Field offset: 0x10
		private readonly string _labelName; //Field offset: 0x18
		private readonly GUIStyle _lineStyle; //Field offset: 0x20
		private Color _color; //Field offset: 0x28
		private string _debugText; //Field offset: 0x38

		public DebugLabel(string name, string text, Color color, bool withWhiteBack) { }

		public void Set(object msg, Color color) { }

		public void Show() { }

	}

	private static GUILabelDebugger _instance; //Field offset: 0x0
	private readonly List _iterationList; //Field offset: 0x20
	private readonly Dictionary _namedLabels; //Field offset: 0x28

	private static GUILabelDebugger Instance
	{
		private get { } //Length: 967
	}

	public GUILabelDebugger() { }

	private static GUILabelDebugger get_Instance() { }

	private void OnGUI() { }

	[Conditional("DEBUG")]
	public static void ShowLabel(string labelName, object msg) { }

	[Conditional("DEBUG")]
	public static void ShowLabel(string labelName, object msg, Color color, bool withWhiteBack = false) { }

	[Conditional("DEBUG")]
	public static void ShowLabelContrasted(string labelName, object msg) { }

	private void Start() { }

}

