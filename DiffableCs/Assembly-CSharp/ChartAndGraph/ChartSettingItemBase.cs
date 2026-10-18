namespace ChartAndGraph;

[ExecuteInEditMode]
[RequireComponent(typeof(AnyChart))]
public abstract class ChartSettingItemBase : MonoBehaviour, IInternalSettings
{
	[CompilerGenerated]
	private EventHandler OnDataUpdate; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler OnDataChanged; //Field offset: 0x28
	private AnyChart mChart; //Field offset: 0x30

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private event EventHandler OnDataChanged
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	private event EventHandler OnDataUpdate
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	protected abstract Action Assign
	{
		 get { } //Length: 0
	}

	private AnyChart SafeChart
	{
		private get { } //Length: 320
	}

	protected ChartSettingItemBase() { }

	[CompilerGenerated]
	private void add_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void add_OnDataUpdate(EventHandler value) { }

	protected void AddInnerItem(IInternalSettings item) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataUpdate(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataUpdate(EventHandler value) { }

	protected abstract Action get_Assign() { }

	private AnyChart get_SafeChart() { }

	private void Item_InternalOnDataChanged(object sender, EventArgs e) { }

	private void Item_InternalOnDataUpdate(object sender, EventArgs e) { }

	protected override void OnDestory() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnValidate() { }

	protected override void RaiseOnChanged() { }

	protected override void RaiseOnUpdate() { }

	[CompilerGenerated]
	private void remove_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void remove_OnDataUpdate(EventHandler value) { }

	private void SafeAssign(bool clear) { }

	protected override void Start() { }

}

