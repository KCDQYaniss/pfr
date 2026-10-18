//Type is in global namespace

public abstract class AICoreStrategy`1
{
	private readonly Dictionary _layers; //Field offset: 0x0
	private readonly List _activeLayers; //Field offset: 0x0
	private readonly HashSet _activeLayersHash; //Field offset: 0x0
	private AICoreAgentBase _coreAgent; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnLayerChangedTo; //Field offset: 0x0
	[CompilerGenerated]
	private AICoreLayer <CurLayer>k__BackingField; //Field offset: 0x0

	public event Action OnLayerChangedTo
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected private AICoreLayer CurLayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AICoreStrategy`1() { }

	public void Activate(AICoreAgentBase coreAgent) { }

	public void ActivateLayer(int index) { }

	[CompilerGenerated]
	public void add_OnLayerChangedTo(Action value) { }

	public void DeactivateLayer(int index) { }

	public override void Dispose() { }

	[CompilerGenerated]
	protected AICoreLayer get_CurLayer() { }

	public string GetActiveLayerDebug() { }

	public bool HaveLayer() { }

	public bool HaveLayer(out TLayer layerTarget) { }

	private void InsertLayerToActive(AICoreLayer layer, int index) { }

	protected bool IsLayerActive(AICoreLayer index) { }

	public bool IsLayerActive() { }

	public override void ManualUpdate() { }

	public void OnDrawGizmos() { }

	[CompilerGenerated]
	public void remove_OnLayerChangedTo(Action value) { }

	[CompilerGenerated]
	private void set_CurLayer(AICoreLayer value) { }

	protected bool TryAddLayer(int index, AICoreLayer layer, bool activeOnStart) { }

	public Nullable Update(AICoreActionResult prevResult) { }

}

