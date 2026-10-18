//Type is in global namespace

public class AICoreAgent`1 : AICoreAgentBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Nullable nodeToUse; //Field offset: 0x0
		public AICoreAgent <>4__this; //Field offset: 0x0

		public <>c__DisplayClass14_0() { }

		internal void <Update>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public AICoreNode node; //Field offset: 0x0
		public T type; //Field offset: 0x0
		public <>c__DisplayClass14_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass14_1() { }

		internal void <Update>b__1() { }

		internal void <Update>b__2() { }

	}

	private static readonly Stopwatch _stepMeasureSw; //Field offset: 0x0
	private Dictionary _nodesDictionary; //Field offset: 0x0
	private AICoreStrategy _strategy; //Field offset: 0x0
	private AICoreActionResult _lastResult; //Field offset: 0x0
	private string _handlerInfo; //Field offset: 0x0
	private readonly GameObject _monoBehObject; //Field offset: 0x0
	private readonly bool _haveObject; //Field offset: 0x0
	private AICoreLayer _lastActiveLayer; //Field offset: 0x0
	private readonly AICoreController _aiCoreController; //Field offset: 0x0
	private Func _lazyGetter; //Field offset: 0x0

	private static AICoreAgent`1() { }

	public AICoreAgent`1(AICoreController aiCoreController, AICoreStrategy strategy, Dictionary nodesDictionary, GameObject monoBehObject, string name, Func lazyGetter) { }

	public void Deactivate(int index) { }

	public void Dispose() { }

	public string GetActiveNodeName() { }

	public string GetActiveNodeReason() { }

	public virtual string GetCustomData() { }

	public AICoreActionResult LastResult() { }

	private void ManualUpdate() { }

	private void MeasureStep(string stepName, Action action) { }

	public virtual void OnDrawGizmos() { }

	private void OnEndCurDecision(AICoreActionEnd obj) { }

	private void OnLayerChangedTo(AICoreLayer obj) { }

	private void OnStartCurDecision(AICoreActionResult obj) { }

	private void Subscribe(AICoreLayer lastActiveLayer) { }

	private void Unsubscribe(AICoreLayer lastActiveLayer) { }

	public virtual void Update() { }

}

