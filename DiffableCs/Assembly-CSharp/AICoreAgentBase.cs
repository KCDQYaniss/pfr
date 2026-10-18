//Type is in global namespace

public abstract class AICoreAgentBase
{
	private readonly List _allLayersName; //Field offset: 0x10
	private readonly HashSet _activeLayers; //Field offset: 0x18
	private bool _logSameNode; //Field offset: 0x20
	private bool _logSameReason; //Field offset: 0x21
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <NodeSame>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <ReasonSame>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <LastPeriod>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <LastNode>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <PrevNode>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <EndReason>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <LastReason>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <UsingLayer>k__BackingField; //Field offset: 0x60

	public string EndReason
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string LastNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float LastPeriod
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public string LastReason
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private int NodeSame
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string PrevNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private int ReasonSame
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string UsingLayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected AICoreAgentBase(string name) { }

	public void ActivateLayer(string layer) { }

	public void AddLayer(int id, string name, int priority) { }

	public void Deactivate(string name) { }

	protected void DeActivateLayer(string layer) { }

	[CompilerGenerated]
	public string get_EndReason() { }

	[CompilerGenerated]
	public string get_LastNode() { }

	[CompilerGenerated]
	public float get_LastPeriod() { }

	[CompilerGenerated]
	public string get_LastReason() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public int get_NodeSame() { }

	[CompilerGenerated]
	public string get_PrevNode() { }

	[CompilerGenerated]
	public int get_ReasonSame() { }

	[CompilerGenerated]
	public string get_UsingLayer() { }

	public List GetAllLAyersName() { }

	public abstract string GetCustomData() { }

	private void InsertLayerToActive(AILayerDebugStruct layer) { }

	public bool IsLayerActive(string layer) { }

	public bool IsProblem() { }

	public int NodeRepeats() { }

	public override void OnDrawGizmos() { }

	[CompilerGenerated]
	public void set_EndReason(string value) { }

	[CompilerGenerated]
	public void set_LastNode(string value) { }

	[CompilerGenerated]
	public void set_LastPeriod(float value) { }

	[CompilerGenerated]
	public void set_LastReason(string value) { }

	[CompilerGenerated]
	private void set_NodeSame(int value) { }

	[CompilerGenerated]
	public void set_PrevNode(string value) { }

	[CompilerGenerated]
	private void set_ReasonSame(int value) { }

	[CompilerGenerated]
	public void set_UsingLayer(string value) { }

	protected void SetDebugData(string lastNode, string lastReason, float time) { }

	protected void SetEndReason(string endReason) { }

	protected void SetLayer(string activeLayer) { }

	public abstract void Update() { }

}

