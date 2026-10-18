namespace ChartAndGraph;

public abstract class AnyChart : MonoBehaviour, IInternalUse
{
	private bool mGenerating; //Field offset: 0x20
	private Dictionary mHorizontalValueToStringMap; //Field offset: 0x28
	private Dictionary mVerticalValueToStringMap; //Field offset: 0x30
	[SerializeField]
	private bool keepOrthoSize; //Field offset: 0x38
	[SerializeField]
	private bool vRSpaceText; //Field offset: 0x39
	[SerializeField]
	private float vRSpaceScale; //Field offset: 0x3C
	private HashSet mHovered; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsUnderCanvas>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <CanvasChanged>k__BackingField; //Field offset: 0x49
	protected ItemLabels mItemLabels; //Field offset: 0x50
	protected VerticalAxis mVerticalAxis; //Field offset: 0x58
	protected HorizontalAxis mHorizontalAxis; //Field offset: 0x60
	protected CategoryLabels mCategoryLabels; //Field offset: 0x68
	protected GroupLabels mGroupLabels; //Field offset: 0x70
	protected GameObject VerticalMainDevisions; //Field offset: 0x78
	protected GameObject VerticalSubDevisions; //Field offset: 0x80
	protected GameObject HorizontalMainDevisions; //Field offset: 0x88
	protected GameObject HorizontalSubDevisions; //Field offset: 0x90
	private bool mGenerateOnNextUpdate; //Field offset: 0x98
	protected bool hideHierarchy; //Field offset: 0x99
	private List mAxis; //Field offset: 0xA0
	[CompilerGenerated]
	private TextController <TextController>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private Action ChartGenerated; //Field offset: 0xB0

	private override event Action ChartAndGraph.IInternalUse.Generated
	{
		private add { } //Length: 251
		private remove { } //Length: 251
	}

	private event Action ChartGenerated
	{
		[CompilerGenerated]
		private add { } //Length: 251
		[CompilerGenerated]
		private remove { } //Length: 251
	}

	protected private bool CanvasChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private override CategoryLabels ChartAndGraph.IInternalUse.CategoryLabels
	{
		private get { } //Length: 5
		private set { } //Length: 835
	}

	private override GroupLabels ChartAndGraph.IInternalUse.GroupLabels
	{
		private get { } //Length: 5
		private set { } //Length: 835
	}

	private override bool ChartAndGraph.IInternalUse.HideHierarchy
	{
		private get { } //Length: 8
	}

	private override HorizontalAxis ChartAndGraph.IInternalUse.HorizontalAxis
	{
		private get { } //Length: 5
		private set { } //Length: 819
	}

	private override bool ChartAndGraph.IInternalUse.InternalSupportsCategoryLables
	{
		private get { } //Length: 20
	}

	private override bool ChartAndGraph.IInternalUse.InternalSupportsGroupLabels
	{
		private get { } //Length: 20
	}

	private override bool ChartAndGraph.IInternalUse.InternalSupportsItemLabels
	{
		private get { } //Length: 20
	}

	private override Camera ChartAndGraph.IInternalUse.InternalTextCamera
	{
		private get { } //Length: 20
	}

	private override TextController ChartAndGraph.IInternalUse.InternalTextController
	{
		private get { } //Length: 8
	}

	private override float ChartAndGraph.IInternalUse.InternalTextIdleDistance
	{
		private get { } //Length: 20
	}

	private override float ChartAndGraph.IInternalUse.InternalTotalDepth
	{
		private get { } //Length: 20
	}

	private override float ChartAndGraph.IInternalUse.InternalTotalHeight
	{
		private get { } //Length: 20
	}

	private override float ChartAndGraph.IInternalUse.InternalTotalWidth
	{
		private get { } //Length: 20
	}

	private override ItemLabels ChartAndGraph.IInternalUse.ItemLabels
	{
		private get { } //Length: 5
		private set { } //Length: 835
	}

	private override VerticalAxis ChartAndGraph.IInternalUse.VerticalAxis
	{
		private get { } //Length: 5
		private set { } //Length: 819
	}

	public Dictionary HorizontalValueToStringMap
	{
		 get { } //Length: 5
	}

	protected bool Invalidating
	{
		 get { } //Length: 8
	}

	protected private bool IsUnderCanvas
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool KeepOrthoSize
	{
		 get { } //Length: 5
		 set { } //Length: 10
	}

	protected abstract bool SupportsCategoryLabels
	{
		 get { } //Length: 0
	}

	protected abstract bool SupportsGroupLables
	{
		 get { } //Length: 0
	}

	protected abstract bool SupportsItemLabels
	{
		 get { } //Length: 0
	}

	protected override Camera TextCameraLink
	{
		 get { } //Length: 3
	}

	protected private TextController TextController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override float TextIdleDistanceLink
	{
		 get { } //Length: 9
	}

	protected abstract float TotalDepthLink
	{
		 get { } //Length: 0
	}

	protected abstract float TotalHeightLink
	{
		 get { } //Length: 0
	}

	protected abstract float TotalWidthLink
	{
		 get { } //Length: 0
	}

	public Dictionary VerticalValueToStringMap
	{
		 get { } //Length: 76
	}

	public float VRSpaceScale
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public bool VRSpaceText
	{
		 get { } //Length: 5
		 set { } //Length: 10
	}

	protected AnyChart() { }

	[CompilerGenerated]
	private void add_ChartGenerated(Action value) { }

	private void AxisChanged(object sender, EventArgs e) { }

	private override void ChartAndGraph.IInternalUse.add_Generated(Action value) { }

	private override void ChartAndGraph.IInternalUse.CallOnValidate() { }

	private override CategoryLabels ChartAndGraph.IInternalUse.get_CategoryLabels() { }

	private override GroupLabels ChartAndGraph.IInternalUse.get_GroupLabels() { }

	private override bool ChartAndGraph.IInternalUse.get_HideHierarchy() { }

	private override HorizontalAxis ChartAndGraph.IInternalUse.get_HorizontalAxis() { }

	private override bool ChartAndGraph.IInternalUse.get_InternalSupportsCategoryLables() { }

	private override bool ChartAndGraph.IInternalUse.get_InternalSupportsGroupLabels() { }

	private override bool ChartAndGraph.IInternalUse.get_InternalSupportsItemLabels() { }

	private override Camera ChartAndGraph.IInternalUse.get_InternalTextCamera() { }

	private override TextController ChartAndGraph.IInternalUse.get_InternalTextController() { }

	private override float ChartAndGraph.IInternalUse.get_InternalTextIdleDistance() { }

	private override float ChartAndGraph.IInternalUse.get_InternalTotalDepth() { }

	private override float ChartAndGraph.IInternalUse.get_InternalTotalHeight() { }

	private override float ChartAndGraph.IInternalUse.get_InternalTotalWidth() { }

	private override ItemLabels ChartAndGraph.IInternalUse.get_ItemLabels() { }

	private override VerticalAxis ChartAndGraph.IInternalUse.get_VerticalAxis() { }

	private override bool ChartAndGraph.IInternalUse.InternalHasValues(AxisBase axis) { }

	private override void ChartAndGraph.IInternalUse.InternalItemHovered(object userData) { }

	private override void ChartAndGraph.IInternalUse.InternalItemLeave(object userData) { }

	private override void ChartAndGraph.IInternalUse.InternalItemSelected(object userData) { }

	private override double ChartAndGraph.IInternalUse.InternalMaxValue(AxisBase axis) { }

	private override double ChartAndGraph.IInternalUse.InternalMinValue(AxisBase axis) { }

	private override void ChartAndGraph.IInternalUse.remove_Generated(Action value) { }

	private override void ChartAndGraph.IInternalUse.set_CategoryLabels(CategoryLabels value) { }

	private override void ChartAndGraph.IInternalUse.set_GroupLabels(GroupLabels value) { }

	private override void ChartAndGraph.IInternalUse.set_HorizontalAxis(HorizontalAxis value) { }

	private override void ChartAndGraph.IInternalUse.set_ItemLabels(ItemLabels value) { }

	private override void ChartAndGraph.IInternalUse.set_VerticalAxis(VerticalAxis value) { }

	protected override void ClearChart() { }

	private void CreateTextController() { }

	private void DoCanvas(bool start) { }

	private void EnsureTextController() { }

	protected void GenerateAxis(bool force) { }

	public void GenerateChart() { }

	[CompilerGenerated]
	protected bool get_CanvasChanged() { }

	public Dictionary get_HorizontalValueToStringMap() { }

	protected bool get_Invalidating() { }

	[CompilerGenerated]
	protected bool get_IsUnderCanvas() { }

	public bool get_KeepOrthoSize() { }

	protected abstract bool get_SupportsCategoryLabels() { }

	protected abstract bool get_SupportsGroupLables() { }

	protected abstract bool get_SupportsItemLabels() { }

	protected override Camera get_TextCameraLink() { }

	[CompilerGenerated]
	protected TextController get_TextController() { }

	protected override float get_TextIdleDistanceLink() { }

	protected abstract float get_TotalDepthLink() { }

	protected abstract float get_TotalHeightLink() { }

	protected abstract float get_TotalWidthLink() { }

	public Dictionary get_VerticalValueToStringMap() { }

	public float get_VRSpaceScale() { }

	public bool get_VRSpaceText() { }

	protected override double GetScrollOffset(int axis) { }

	protected abstract bool HasValues(AxisBase axis) { }

	public override void InternalGenerateChart() { }

	protected private override IAxisGenerator InternalUpdateAxis(ref GameObject axisObject, AxisBase axisBase, ChartOrientation axisOrientation, bool isSubDiv, bool forceRecreate, double scrollOffset) { }

	protected override void Invalidate() { }

	private void Labels_OnDataChanged(object sender, EventArgs e) { }

	private void Labels_OnDataUpdate(object sender, EventArgs e) { }

	protected override void LateUpdate() { }

	protected abstract double MaxValue(AxisBase axis) { }

	protected abstract double MinValue(AxisBase axis) { }

	protected override void OnAxisValuesChanged() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnItemHoverted(object userData) { }

	protected override void OnItemLeave(object userData) { }

	protected override void OnItemSelected(object userData) { }

	protected override void OnLabelSettingChanged() { }

	protected override void OnLabelSettingsSet() { }

	protected override void OnNonHoverted() { }

	protected override void OnPropertyUpdated() { }

	protected override void OnValidate() { }

	[CompilerGenerated]
	private void remove_ChartGenerated(Action value) { }

	[CompilerGenerated]
	private void set_CanvasChanged(bool value) { }

	[CompilerGenerated]
	private void set_IsUnderCanvas(bool value) { }

	public void set_KeepOrthoSize(bool value) { }

	[CompilerGenerated]
	private void set_TextController(TextController value) { }

	public void set_VRSpaceScale(float value) { }

	public void set_VRSpaceText(bool value) { }

	protected override void Start() { }

	protected override void Update() { }

	protected override void ValidateProperties() { }

}

