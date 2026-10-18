//Type is in global namespace

public class GraphManager : MonoBehaviour
{
	internal struct GPUDataPair
	{
		[CompilerGenerated]
		private float <Value>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Color <Color>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private bool <Mark>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Color <MarkColor>k__BackingField; //Field offset: 0x18

		public Color Color
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public bool Mark
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public Color MarkColor
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public float Value
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public GPUDataPair(float value) { }

		public GPUDataPair(float value, Color color) { }

		public GPUDataPair(float value, Color color, bool mark, Color markColor) { }

		[CompilerGenerated]
		[IsReadOnly]
		public Color get_Color() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_Mark() { }

		[CompilerGenerated]
		[IsReadOnly]
		public Color get_MarkColor() { }

		[CompilerGenerated]
		[IsReadOnly]
		public float get_Value() { }

		[CompilerGenerated]
		public void set_Color(Color value) { }

		[CompilerGenerated]
		public void set_Mark(bool value) { }

		[CompilerGenerated]
		public void set_MarkColor(Color value) { }

		[CompilerGenerated]
		public void set_Value(float value) { }

	}

	internal class GPUGraphData
	{
		public GameObject ParentUI; //Field offset: 0x10
		public List DataPairs; //Field offset: 0x18
		public string Name; //Field offset: 0x20
		public GameObject CanvasUI; //Field offset: 0x28
		public Canvas Canvas; //Field offset: 0x30
		public RectTransform CanvasRect; //Field offset: 0x38
		public GameObject MaxUI; //Field offset: 0x40
		public GameObject MinUI; //Field offset: 0x48
		public GameObject AvgUI; //Field offset: 0x50
		public Text MaxText; //Field offset: 0x58
		public Text MinText; //Field offset: 0x60
		public Text AvgText; //Field offset: 0x68
		public RectTransform MaxTransform; //Field offset: 0x70
		public RectTransform AvgTransform; //Field offset: 0x78
		public RectTransform MinTransform; //Field offset: 0x80
		[CompilerGenerated]
		private bool <IsWorldSpace>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private Matrix4x4Wrapper <TRS>k__BackingField; //Field offset: 0x8C
		[CompilerGenerated]
		private int <MaxNumPoints>k__BackingField; //Field offset: 0xF4
		private int PrevMaxNumPoints; //Field offset: 0xF8
		[CompilerGenerated]
		private float <MinValue>k__BackingField; //Field offset: 0xFC
		[CompilerGenerated]
		private float <MaxValue>k__BackingField; //Field offset: 0x100
		[CompilerGenerated]
		private bool <AutoMaxValue>k__BackingField; //Field offset: 0x104
		[CompilerGenerated]
		private bool <AutoMinValue>k__BackingField; //Field offset: 0x105
		[CompilerGenerated]
		private float <CurrentValue>k__BackingField; //Field offset: 0x108
		[CompilerGenerated]
		private float <AverageValue>k__BackingField; //Field offset: 0x10C
		[CompilerGenerated]
		private float <CurrentRange>k__BackingField; //Field offset: 0x110
		[CompilerGenerated]
		private Vector4 <Rectangle>k__BackingField; //Field offset: 0x114

		public bool AutoMaxValue
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public bool AutoMinValue
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public float AverageValue
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public float CurrentRange
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public float CurrentValue
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public bool IsWorldSpace
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public int MaxNumPoints
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public float MaxValue
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public float MinValue
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public Vector4 Rectangle
		{
			[CompilerGenerated]
			 get { } //Length: 14
			[CompilerGenerated]
			 set { } //Length: 11
		}

		public Matrix4x4Wrapper TRS
		{
			[CompilerGenerated]
			 get { } //Length: 82
			[CompilerGenerated]
			 set { } //Length: 79
		}

		public GPUGraphData() { }

		public void AddPair(float dataPoint, Color color) { }

		public void AddPair(float dataPoint, Matrix4x4Wrapper trs) { }

		public void AddPair(float dataPoint, Color color, Matrix4x4Wrapper trs) { }

		private void AddPair(GPUDataPair dataPair, Rect rectangle) { }

		public void AddPair(float dataPoint, Color color, bool mark, Color markColor, Rect rectangle) { }

		public void AddPair(float dataPoint, Color color, Rect rectangle) { }

		public void AddPair(float dataPoint) { }

		private Vector3 ConvertPoint(Vector3 pos) { }

		[CompilerGenerated]
		public bool get_AutoMaxValue() { }

		[CompilerGenerated]
		public bool get_AutoMinValue() { }

		[CompilerGenerated]
		public float get_AverageValue() { }

		[CompilerGenerated]
		public float get_CurrentRange() { }

		[CompilerGenerated]
		public float get_CurrentValue() { }

		[CompilerGenerated]
		public bool get_IsWorldSpace() { }

		[CompilerGenerated]
		public int get_MaxNumPoints() { }

		[CompilerGenerated]
		public float get_MaxValue() { }

		[CompilerGenerated]
		public float get_MinValue() { }

		[CompilerGenerated]
		public Vector4 get_Rectangle() { }

		[CompilerGenerated]
		public Matrix4x4Wrapper get_TRS() { }

		public float GetX(int index, float offset) { }

		public float GetY(int index) { }

		public void InitializeParentUI() { }

		public void Render(Material graphMaterial) { }

		public void Reset() { }

		public void ResetDefault() { }

		public void ResetUI() { }

		[CompilerGenerated]
		public void set_AutoMaxValue(bool value) { }

		[CompilerGenerated]
		public void set_AutoMinValue(bool value) { }

		[CompilerGenerated]
		public void set_AverageValue(float value) { }

		[CompilerGenerated]
		public void set_CurrentRange(float value) { }

		[CompilerGenerated]
		public void set_CurrentValue(float value) { }

		[CompilerGenerated]
		public void set_IsWorldSpace(bool value) { }

		[CompilerGenerated]
		public void set_MaxNumPoints(int value) { }

		[CompilerGenerated]
		public void set_MaxValue(float value) { }

		[CompilerGenerated]
		public void set_MinValue(float value) { }

		[CompilerGenerated]
		public void set_Rectangle(Vector4 value) { }

		[CompilerGenerated]
		public void set_TRS(Matrix4x4Wrapper value) { }

		public void Shrink() { }

		public void Update() { }

		public void UpdateStats(float dataPoint) { }

		public void UpdateText() { }

		public void UpdateUI() { }

	}

	internal class GraphManagerInstance
	{
		public Dictionary Graphs; //Field offset: 0x10

		public GraphManagerInstance() { }

		public void Plot(string key, float value) { }

		public void Plot(string key, float value, Matrix4x4Wrapper trs) { }

		public void Plot(string key, float value, Color color) { }

		public void Plot(string key, float value, Color color, Rect rectangle) { }

		public void Plot(string key, float value, Color color, bool mark, Color markColor, Rect rectangle) { }

		public void Plot(string key, float value, Color color, Matrix4x4Wrapper trs) { }

		public bool Reset(string key) { }

		public void ResetAll() { }

		public GPUGraphData Retrieve(string key, float value) { }

		public void Update() { }

	}

	internal struct Matrix4x4Wrapper
	{
		public Vector3 Translation; //Field offset: 0x0
		public Quaternion Rotation; //Field offset: 0xC
		public Vector3 Scale; //Field offset: 0x1C
		public Matrix4x4 TRS; //Field offset: 0x28

		public Matrix4x4Wrapper(Vector3 translation, Quaternion rotation, Vector3 scale) { }

	}

	public static GraphManagerInstance Graph; //Field offset: 0x0
	public static GameObject GraphManagerUI; //Field offset: 0x8
	public static GameObject GraphsUI; //Field offset: 0x10
	private Material m_GraphMaterial; //Field offset: 0x20

	public GraphManager() { }

	private static GameObject CreateGlobalObjects() { }

	public static void DrawLine(Vector3 A, Vector3 B, bool invertCoordinate) { }

	public static void DrawRectangle(Vector4 rect, bool isWorldSpace, Matrix4x4 trs, bool invertCoordinate) { }

	private static void EndRender() { }

	private static bool IsInVR() { }

	public void OnRenderObject() { }

	private void RenderGraph() { }

	public static void SaveCurrentResults(string filePath) { }

	private void Start() { }

	private static void StartRender(Material material, bool isWorldSpace) { }

	private void Update() { }

}

