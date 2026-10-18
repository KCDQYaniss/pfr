namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass492_0
	{
		public VisualElement <>4__this; //Field offset: 0x10
		public StyleValues to; //Field offset: 0x18

		public <>c__DisplayClass492_0() { }

		internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

	}

	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private VisualElement <element>k__BackingField; //Field offset: 0x38
		public bool isScheduled; //Field offset: 0x40
		private VisualElementPanelActivator m_Activator; //Field offset: 0x48

		public private override VisualElement element
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override bool isActive
		{
			 get { } //Length: 27
		}

		protected BaseVisualElementScheduledItem(VisualElement handler) { }

		public override bool CanBeActivated() { }

		public override IVisualElementScheduledItem Every(long intervalMs) { }

		public override void ExecuteLater(long delayMs) { }

		[CompilerGenerated]
		public override VisualElement get_element() { }

		public override bool get_isActive() { }

		internal virtual void OnItemUnscheduled() { }

		public override void OnPanelActivate() { }

		public override void OnPanelDeactivate() { }

		public override void Pause() { }

		public override void Resume() { }

		[CompilerGenerated]
		private void set_element(VisualElement value) { }

		public override IVisualElementScheduledItem StartingIn(long delayMs) { }

	}

	public class CustomStyleAccess : ICustomStyle
	{
		private Dictionary m_CustomProperties; //Field offset: 0x10
		private float m_DpiScaling; //Field offset: 0x18

		public CustomStyleAccess() { }

		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

		public void SetContext(Dictionary customProperties, float dpiScaling) { }

		public override bool TryGetValue(CustomStyleProperty property, out float value) { }

		public override bool TryGetValue(CustomStyleProperty property, out int value) { }

		public override bool TryGetValue(CustomStyleProperty property, out Color value) { }

		public override bool TryGetValue(CustomStyleProperty property, out Texture2D value) { }

		public override bool TryGetValue(CustomStyleProperty property, out Sprite value) { }

		public override bool TryGetValue(CustomStyleProperty property, out VectorImage value) { }

		public override bool TryGetValue(CustomStyleProperty property, out string value) { }

		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	}

	[DefaultMember("Item")]
	internal struct Hierarchy
	{
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; //Field offset: 0x0
		private readonly VisualElement m_Owner; //Field offset: 0x0

		public int childCount
		{
			 get { } //Length: 76
		}

		internal List children
		{
			internal get { } //Length: 29
		}

		public VisualElement Item
		{
			 get { } //Length: 123
		}

		public VisualElement parent
		{
			 get { } //Length: 29
		}

		internal Hierarchy(VisualElement element) { }

		public void Add(VisualElement child) { }

		internal void BringToFront(VisualElement child) { }

		public IEnumerable Children() { }

		public void Clear() { }

		public VisualElement ElementAt(int index) { }

		public virtual bool Equals(object obj) { }

		public bool Equals(Hierarchy other) { }

		public int get_childCount() { }

		internal List get_children() { }

		public VisualElement get_Item(int key) { }

		public VisualElement get_parent() { }

		public virtual int GetHashCode() { }

		public int IndexOf(VisualElement element) { }

		public void Insert(int index, VisualElement child) { }

		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

		public static bool op_Equality(Hierarchy x, Hierarchy y) { }

		internal void PlaceBehind(VisualElement child, VisualElement over) { }

		private void PutChildAtIndex(VisualElement child, int index) { }

		private void ReleaseChildList() { }

		public void Remove(VisualElement child) { }

		public void RemoveAt(int index) { }

		private void RemoveChildAtIndex(int index) { }

		internal void SendToBack(VisualElement child) { }

		private void SetParent(VisualElement value) { }

	}

	internal enum MeasureMode
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2,
	}

	public enum RenderTargetMode
	{
		None = 0,
		NoColorConversion = 1,
		LinearToGamma = 2,
		GammaToLinear = 3,
	}

	private class SimpleScheduledItem : VisualElementScheduledItem
	{

		public SimpleScheduledItem(VisualElement handler, Action updateEvent) { }

		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	private class TimerStateScheduledItem : VisualElementScheduledItem
	{

		public TimerStateScheduledItem(VisualElement handler, Action updateEvent) { }

		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	public class TypeData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Type <type>k__BackingField; //Field offset: 0x10
		private string m_FullTypeName; //Field offset: 0x18
		private string m_TypeName; //Field offset: 0x20
		private string m_TypeNamespace; //Field offset: 0x28

		public string fullTypeName
		{
			 get { } //Length: 144
		}

		public Type type
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public string typeName
		{
			 get { } //Length: 268
		}

		public string typeNamespace
		{
			 get { } //Length: 144
		}

		public TypeData(Type type) { }

		public string get_fullTypeName() { }

		[CompilerGenerated]
		public Type get_type() { }

		public string get_typeName() { }

		public string get_typeNamespace() { }

	}

	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
		private UxmlStringAttributeDescription m_ViewDataKey; //Field offset: 0x20
		protected UxmlEnumAttributeDescription m_PickingMode; //Field offset: 0x28
		private UxmlStringAttributeDescription m_Tooltip; //Field offset: 0x30
		private UxmlEnumAttributeDescription m_UsageHints; //Field offset: 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private UxmlIntAttributeDescription <focusIndex>k__BackingField; //Field offset: 0x40
		private UxmlIntAttributeDescription m_TabIndex; //Field offset: 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private UxmlBoolAttributeDescription <focusable>k__BackingField; //Field offset: 0x50
		private UxmlStringAttributeDescription m_Class; //Field offset: 0x58
		private UxmlStringAttributeDescription m_ContentContainer; //Field offset: 0x60
		private UxmlStringAttributeDescription m_Style; //Field offset: 0x68

		protected UxmlBoolAttributeDescription focusable
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected UxmlIntAttributeDescription focusIndex
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public UxmlTraits() { }

		[CompilerGenerated]
		protected UxmlBoolAttributeDescription get_focusable() { }

		[CompilerGenerated]
		protected UxmlIntAttributeDescription get_focusIndex() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private abstract class VisualElementScheduledItem`1 : BaseVisualElementScheduledItem
	{
		public ActionType updateEvent; //Field offset: 0x0

		public VisualElementScheduledItem`1(VisualElement handler, ActionType upEvent) { }

	}

	private static uint s_NextId; //Field offset: 0x0
	internal const string k_RootVisualContainerName = "rootVisualContainer"; //Field offset: 0x0
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3; //Field offset: 0x0
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25; //Field offset: 0x0
	private static List s_EmptyClassList; //Field offset: 0x8
	internal static readonly PropertyName userDataPropertyKey; //Field offset: 0x10
	public static readonly string disabledUssClassName; //Field offset: 0x18
	internal static readonly Rect s_InfiniteRect; //Field offset: 0x20
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; //Field offset: 0x30
	private static Material s_runtimeMaterial; //Field offset: 0x38
	private static uint s_NextParentVersion; //Field offset: 0x40
	private static readonly List s_EmptyList; //Field offset: 0x48
	internal static CustomStyleAccess s_CustomStyleAccess; //Field offset: 0x50
	private static readonly Regex s_InternalStyleSheetPath; //Field offset: 0x58
	internal static readonly PropertyName tooltipPropertyKey; //Field offset: 0x60
	private static readonly Dictionary s_TypeData; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; //Field offset: 0x34
	private string m_Name; //Field offset: 0x38
	private List m_ClassList; //Field offset: 0x40
	private List m_PropertyBag; //Field offset: 0x48
	internal VisualElementFlags m_Flags; //Field offset: 0x50
	private string m_ViewDataKey; //Field offset: 0x58
	private RenderHints m_RenderHints; //Field offset: 0x60
	internal Rect lastLayout; //Field offset: 0x64
	internal Rect lastPseudoPadding; //Field offset: 0x74
	internal RenderChainVEData renderChainData; //Field offset: 0x88
	private Rect m_Layout; //Field offset: 0x1D0
	private Rect m_BoundingBox; //Field offset: 0x1E0
	private Rect m_WorldBoundingBox; //Field offset: 0x1F0
	private Matrix4x4 m_WorldTransformCache; //Field offset: 0x200
	private Matrix4x4 m_WorldTransformInverseCache; //Field offset: 0x240
	private Rect m_WorldClip; //Field offset: 0x280
	private Rect m_WorldClipMinusGroup; //Field offset: 0x290
	private bool m_WorldClipIsInfinite; //Field offset: 0x2A0
	internal PseudoStates triggerPseudoMask; //Field offset: 0x2A4
	internal PseudoStates dependencyPseudoMask; //Field offset: 0x2A8
	private PseudoStates m_PseudoStates; //Field offset: 0x2AC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <containedPointerIds>k__BackingField; //Field offset: 0x2B0
	private PickingMode m_PickingMode; //Field offset: 0x2B4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private YogaNode <yogaNode>k__BackingField; //Field offset: 0x2B8
	internal ComputedStyle m_Style; //Field offset: 0x2C0
	internal StyleVariableContext variableContext; //Field offset: 0x318
	internal int inheritedStylesHash; //Field offset: 0x320
	internal readonly uint controlid; //Field offset: 0x324
	internal int imguiContainerDescendantCount; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enabledSelf>k__BackingField; //Field offset: 0x32C
	private LanguageDirection m_LanguageDirection; //Field offset: 0x330
	private LanguageDirection m_LocalLanguageDirection; //Field offset: 0x334
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <generateVisualContent>k__BackingField; //Field offset: 0x338
	private RenderTargetMode m_SubRenderTargetMode; //Field offset: 0x340
	private Material m_defaultMaterial; //Field offset: 0x348
	private List m_RunningAnimations; //Field offset: 0x350
	private uint m_NextParentCachedVersion; //Field offset: 0x358
	private uint m_NextParentRequiredVersion; //Field offset: 0x35C
	private VisualElement m_CachedNextParentWithEventCallback; //Field offset: 0x360
	private int m_EventCallbackCategories; //Field offset: 0x368
	private int m_CachedEventCallbackParentCategories; //Field offset: 0x36C
	private readonly int m_DefaultActionEventCategories; //Field offset: 0x370
	private readonly int m_DefaultActionAtTargetEventCategories; //Field offset: 0x374
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Hierarchy <hierarchy>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isRootVisualContainer>k__BackingField; //Field offset: 0x380
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <cacheAsBitmap>k__BackingField; //Field offset: 0x381
	private VisualElement m_PhysicalParent; //Field offset: 0x388
	private VisualElement m_LogicalParent; //Field offset: 0x390
	private List m_Children; //Field offset: 0x398
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseVisualElementPanel <elementPanel>k__BackingField; //Field offset: 0x3A0
	private VisualTreeAsset m_VisualTreeAssetSource; //Field offset: 0x3A8
	internal InlineStyleAccess inlineStyleAccess; //Field offset: 0x3B0
	internal List styleSheetList; //Field offset: 0x3B8
	private TypeData m_TypeData; //Field offset: 0x3C0

	internal Rect boundingBox
	{
		internal get { } //Length: 66
	}

	private Rect boundingBoxInParentSpace
	{
		private get { } //Length: 78
	}

	public virtual bool canGrabFocus
	{
		 get { } //Length: 237
	}

	public int childCount
	{
		 get { } //Length: 152
	}

	internal List classList
	{
		internal get { } //Length: 256
	}

	internal ComputedStyle computedStyle
	{
		internal get { } //Length: 8
	}

	internal int containedPointerIds
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override VisualElement contentContainer
	{
		 get { } //Length: 6
	}

	public Rect contentRect
	{
		 get { } //Length: 641
	}

	public ICustomStyle customStyle
	{
		 get { } //Length: 214
	}

	internal Material defaultMaterial
	{
		internal get { } //Length: 10
	}

	internal bool disableClipping
	{
		internal get { } //Length: 9
		internal set { } //Length: 45
	}

	internal BaseVisualElementPanel elementPanel
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool enabledInHierarchy
	{
		 get { } //Length: 16
	}

	public private bool enabledSelf
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal bool enableViewDataPersistence
	{
		internal get { } //Length: 9
		private set { } //Length: 45
	}

	internal int eventCallbackCategories
	{
		internal get { } //Length: 7
		internal set { } //Length: 125
	}

	internal int eventCallbackParentCategories
	{
		internal get { } //Length: 237
	}

	public IExperimentalFeatures experimental
	{
		 get { } //Length: 6
	}

	public virtual FocusController focusController
	{
		 get { } //Length: 73
	}

	internal string fullTypeName
	{
		internal get { } //Length: 160
	}

	public Action generateVisualContent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal bool hasCompletedAnimations
	{
		internal get { } //Length: 83
	}

	internal bool hasDefaultRotationAndScale
	{
		internal get { } //Length: 303
	}

	internal bool hasInlineStyle
	{
		internal get { } //Length: 12
	}

	internal bool hasRunningAnimations
	{
		internal get { } //Length: 83
	}

	public private Hierarchy hierarchy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal bool isBoundingBoxDirty
	{
		internal get { } //Length: 9
		internal set { } //Length: 43
	}

	internal bool isCompositeRoot
	{
		internal get { } //Length: 9
		internal set { } //Length: 58
	}

	internal bool isEventCallbackParentCategoriesDirty
	{
		internal get { } //Length: 9
		internal set { } //Length: 43
	}

	internal bool isHierarchyDisplayed
	{
		internal get { } //Length: 9
		internal set { } //Length: 45
	}

	internal bool isLayoutManual
	{
		internal get { } //Length: 9
		private set { } //Length: 43
	}

	private bool isParentEnabledInHierarchy
	{
		private get { } //Length: 67
	}

	internal bool isRootVisualContainer
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool isWorldBoundingBoxDirty
	{
		internal set { } //Length: 43
	}

	internal bool isWorldBoundingBoxOrDependenciesDirty
	{
		internal get { } //Length: 8
	}

	internal bool isWorldClipDirty
	{
		internal get { } //Length: 9
		internal set { } //Length: 43
	}

	internal bool isWorldTransformDirty
	{
		internal get { } //Length: 7
		internal set { } //Length: 43
	}

	internal bool isWorldTransformInverseDirty
	{
		internal set { } //Length: 43
	}

	internal bool isWorldTransformInverseOrDependenciesDirty
	{
		internal get { } //Length: 8
	}

	public VisualElement Item
	{
		 get { } //Length: 212
	}

	public LanguageDirection languageDirection
	{
		 get { } //Length: 7
	}

	public internal Rect layout
	{
		 get { } //Length: 460
		internal set { } //Length: 1940
	}

	public Rect localBound
	{
		 get { } //Length: 128
	}

	internal LanguageDirection localLanguageDirection
	{
		internal get { } //Length: 7
		internal set { } //Length: 320
	}

	public string name
	{
		 get { } //Length: 7
		 set { } //Length: 196
	}

	internal VisualElement nextParentWithEventCallback
	{
		internal get { } //Length: 572
	}

	protected Rect paddingRect
	{
		 get { } //Length: 337
	}

	public IPanel panel
	{
		 get { } //Length: 10
	}

	public VisualElement parent
	{
		 get { } //Length: 10
	}

	public PickingMode pickingMode
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	private Vector3 positionWithLayout
	{
		private get { } //Length: 142
	}

	internal PseudoStates pseudoStates
	{
		internal get { } //Length: 9
		internal set { } //Length: 130
	}

	internal Rect rect
	{
		internal get { } //Length: 88
	}

	internal RenderHints renderHints
	{
		internal get { } //Length: 6
		internal set { } //Length: 97
	}

	internal bool requireMeasureFunction
	{
		internal get { } //Length: 9
		internal set { } //Length: 106
	}

	public IResolvedStyle resolvedStyle
	{
		 get { } //Length: 4
	}

	internal float scaledPixelsPerPoint
	{
		internal get { } //Length: 157
	}

	public IVisualElementScheduler schedule
	{
		 get { } //Length: 6
	}

	public IStyle style
	{
		 get { } //Length: 190
	}

	internal IStylePropertyAnimations styleAnimation
	{
		internal get { } //Length: 4
	}

	internal bool styleInitialized
	{
		internal get { } //Length: 9
		internal set { } //Length: 45
	}

	public VisualElementStyleSheetSet styleSheets
	{
		 get { } //Length: 91
	}

	internal RenderTargetMode subRenderTargetMode
	{
		internal get { } //Length: 9
	}

	public string tooltip
	{
		 get { } //Length: 156
		 set { } //Length: 376
	}

	public ITransform transform
	{
		 get { } //Length: 6
	}

	private TypeData typeData
	{
		private get { } //Length: 439
	}

	internal string typeName
	{
		internal get { } //Length: 35
	}

	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
	{
		private get { } //Length: 6
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
	{
		private get { } //Length: 87
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
	{
		private get { } //Length: 87
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
	{
		private get { } //Length: 83
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
	{
		private get { } //Length: 83
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
	{
		private get { } //Length: 109
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
	{
		private get { } //Length: 90
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
	{
		private get { } //Length: 106
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
	{
		private get { } //Length: 90
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
	{
		private get { } //Length: 109
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
	{
		private get { } //Length: 90
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
	{
		private get { } //Length: 83
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
	{
		private get { } //Length: 83
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.bottom
	{
		private get { } //Length: 104
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.color
	{
		private get { } //Length: 87
	}

	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
	{
		private get { } //Length: 68
	}

	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
	{
		private get { } //Length: 68
	}

	private override float UnityEngine.UIElements.IResolvedStyle.flexGrow
	{
		private get { } //Length: 70
	}

	private override float UnityEngine.UIElements.IResolvedStyle.flexShrink
	{
		private get { } //Length: 70
	}

	private override float UnityEngine.UIElements.IResolvedStyle.height
	{
		private get { } //Length: 104
	}

	private override float UnityEngine.UIElements.IResolvedStyle.left
	{
		private get { } //Length: 104
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginBottom
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginLeft
	{
		private get { } //Length: 106
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginRight
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginTop
	{
		private get { } //Length: 109
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
	{
		private get { } //Length: 85
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
	{
		private get { } //Length: 85
	}

	private override float UnityEngine.UIElements.IResolvedStyle.opacity
	{
		private get { } //Length: 73
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingBottom
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingLeft
	{
		private get { } //Length: 106
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingRight
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingTop
	{
		private get { } //Length: 109
	}

	private override float UnityEngine.UIElements.IResolvedStyle.right
	{
		private get { } //Length: 104
	}

	private override Scale UnityEngine.UIElements.IResolvedStyle.scale
	{
		private get { } //Length: 87
	}

	private override float UnityEngine.UIElements.IResolvedStyle.top
	{
		private get { } //Length: 104
	}

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
	{
		private get { } //Length: 45
	}

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.translate
	{
		private get { } //Length: 45
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
	{
		private get { } //Length: 87
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
	{
		private get { } //Length: 68
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
	{
		private get { } //Length: 68
	}

	private override float UnityEngine.UIElements.IResolvedStyle.unitySliceScale
	{
		private get { } //Length: 70
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
	{
		private get { } //Length: 90
	}

	private override float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
	{
		private get { } //Length: 73
	}

	private override Visibility UnityEngine.UIElements.IResolvedStyle.visibility
	{
		private get { } //Length: 71
	}

	private override float UnityEngine.UIElements.IResolvedStyle.width
	{
		private get { } //Length: 104
	}

	private override int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
	{
		[CompilerGenerated]
		private get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private override int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
	{
		[CompilerGenerated]
		private get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private override Vector3 UnityEngine.UIElements.ITransform.position
	{
		private get { } //Length: 120
		private set { } //Length: 525
	}

	private override Vector3 UnityEngine.UIElements.ITransform.scale
	{
		private get { } //Length: 123
	}

	public UsageHints usageHints
	{
		 get { } //Length: 45
		 set { } //Length: 134
	}

	public object userData
	{
		 get { } //Length: 119
		 set { } //Length: 114
	}

	public string viewDataKey
	{
		 get { } //Length: 5
		 set { } //Length: 207
	}

	public bool visible
	{
		 get { } //Length: 83
		 set { } //Length: 120
	}

	internal VisualTreeAsset visualTreeAssetSource
	{
		internal set { } //Length: 82
	}

	public Rect worldBound
	{
		 get { } //Length: 263
	}

	internal Rect worldBoundingBox
	{
		internal get { } //Length: 179
	}

	internal Rect worldClip
	{
		internal get { } //Length: 66
	}

	internal bool worldClipIsInfinite
	{
		internal get { } //Length: 52
	}

	internal Rect worldClipMinusGroup
	{
		internal get { } //Length: 66
	}

	public Matrix4x4 worldTransform
	{
		 get { } //Length: 107
	}

	internal Matrix4x4 worldTransformInverse
	{
		internal get { } //Length: 165
	}

	internal Matrix4x4 worldTransformRef
	{
		internal get { } //Length: 48
	}

	internal YogaNode yogaNode
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static VisualElement() { }

	public VisualElement() { }

	[CompilerGenerated]
	private YogaSize <AssignMeasureFunction>b__432_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) { }

	public void Add(VisualElement child) { }

	internal void AddStyleSheetPath(string sheetPath) { }

	public void AddToClassList(string className) { }

	private void AssignMeasureFunction() { }

	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	public void BringToFront() { }

	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	private void ChangeIMGUIContainerCount(int delta) { }

	private static void CheckUserKeyArgument(PropertyName key) { }

	public IEnumerable Children() { }

	public bool ClassListContains(string cls) { }

	public void Clear() { }

	internal void ClearManualLayout() { }

	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	public bool Contains(VisualElement child) { }

	public override bool ContainsPoint(Vector2 localPoint) { }

	private void DirtyNextParentWithEventCallback() { }

	protected private override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	public VisualElement ElementAt(int index) { }

	internal VisualElement ElementAtTreePath(List childIndexes) { }

	public void EnableInClassList(string className, bool enable) { }

	internal void EnsureWorldTransformAndClipUpToDate() { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(MouseOverEvent), typeof(MouseOutEvent), typeof(MouseCaptureOutEvent), typeof(PointerEnterEvent), typeof(PointerLeaveEvent), typeof(PointerCaptureEvent), typeof(PointerCaptureOutEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(TooltipEvent)})]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	private void FinalizeLayout() { }

	public VisualElement FindCommonAncestor(VisualElement other) { }

	internal bool FindElementInTree(VisualElement element, List outChildIndexes) { }

	public virtual void Focus() { }

	private void GatherAllChildren(List elements) { }

	internal Rect get_boundingBox() { }

	private Rect get_boundingBoxInParentSpace() { }

	public virtual bool get_canGrabFocus() { }

	public int get_childCount() { }

	internal List get_classList() { }

	internal ComputedStyle get_computedStyle() { }

	[CompilerGenerated]
	internal int get_containedPointerIds() { }

	public override VisualElement get_contentContainer() { }

	public Rect get_contentRect() { }

	public ICustomStyle get_customStyle() { }

	internal Material get_defaultMaterial() { }

	internal bool get_disableClipping() { }

	[CompilerGenerated]
	internal BaseVisualElementPanel get_elementPanel() { }

	public bool get_enabledInHierarchy() { }

	[CompilerGenerated]
	public bool get_enabledSelf() { }

	internal bool get_enableViewDataPersistence() { }

	internal int get_eventCallbackCategories() { }

	internal int get_eventCallbackParentCategories() { }

	public IExperimentalFeatures get_experimental() { }

	public virtual FocusController get_focusController() { }

	internal string get_fullTypeName() { }

	[CompilerGenerated]
	public Action get_generateVisualContent() { }

	internal bool get_hasCompletedAnimations() { }

	internal bool get_hasDefaultRotationAndScale() { }

	internal bool get_hasInlineStyle() { }

	internal bool get_hasRunningAnimations() { }

	[CompilerGenerated]
	public Hierarchy get_hierarchy() { }

	internal bool get_isBoundingBoxDirty() { }

	internal bool get_isCompositeRoot() { }

	internal bool get_isEventCallbackParentCategoriesDirty() { }

	internal bool get_isHierarchyDisplayed() { }

	internal bool get_isLayoutManual() { }

	private bool get_isParentEnabledInHierarchy() { }

	[CompilerGenerated]
	internal bool get_isRootVisualContainer() { }

	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	internal bool get_isWorldClipDirty() { }

	internal bool get_isWorldTransformDirty() { }

	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	public VisualElement get_Item(int key) { }

	public LanguageDirection get_languageDirection() { }

	public Rect get_layout() { }

	public Rect get_localBound() { }

	internal LanguageDirection get_localLanguageDirection() { }

	public string get_name() { }

	internal VisualElement get_nextParentWithEventCallback() { }

	protected Rect get_paddingRect() { }

	public IPanel get_panel() { }

	public VisualElement get_parent() { }

	public PickingMode get_pickingMode() { }

	private Vector3 get_positionWithLayout() { }

	internal PseudoStates get_pseudoStates() { }

	internal Rect get_rect() { }

	internal RenderHints get_renderHints() { }

	internal bool get_requireMeasureFunction() { }

	public IResolvedStyle get_resolvedStyle() { }

	internal float get_scaledPixelsPerPoint() { }

	public IVisualElementScheduler get_schedule() { }

	public IStyle get_style() { }

	internal IStylePropertyAnimations get_styleAnimation() { }

	internal bool get_styleInitialized() { }

	public VisualElementStyleSheetSet get_styleSheets() { }

	internal RenderTargetMode get_subRenderTargetMode() { }

	public string get_tooltip() { }

	public ITransform get_transform() { }

	private TypeData get_typeData() { }

	internal string get_typeName() { }

	public UsageHints get_usageHints() { }

	public object get_userData() { }

	public string get_viewDataKey() { }

	public bool get_visible() { }

	public Rect get_worldBound() { }

	internal Rect get_worldBoundingBox() { }

	internal Rect get_worldClip() { }

	internal bool get_worldClipIsInfinite() { }

	internal Rect get_worldClipMinusGroup() { }

	public Matrix4x4 get_worldTransform() { }

	internal Matrix4x4 get_worldTransformInverse() { }

	internal Matrix4x4 get_worldTransformRef() { }

	[CompilerGenerated]
	internal YogaNode get_yogaNode() { }

	private VisualElementAnimationSystem GetAnimationSystem() { }

	internal bool GetCachedNextParentWithEventCallback(out VisualElement nextParent) { }

	internal List GetClassesForIteration() { }

	public T GetFirstAncestorOfType() { }

	internal VisualElement GetFirstAncestorWhere(Predicate predicate) { }

	public T GetFirstOfType() { }

	internal string GetFullHierarchicalViewDataKey() { }

	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	internal VisualElement GetNextElementDepthFirst() { }

	internal static TypeData GetOrCreateTypeData(Type t) { }

	internal T GetOrCreateViewData(object existing, string key) { }

	private Nullable GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	internal VisualElement GetPreviousElementDepthFirst() { }

	internal object GetProperty(PropertyName key) { }

	internal VisualElement GetRoot() { }

	internal VisualElement GetRootVisualContainer() { }

	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	internal override Rect GetTooltipRect() { }

	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	internal bool HasDefaultAction(EventCategory eventCategory) { }

	internal bool HasEventCallbacks(EventCategory eventCategory) { }

	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	internal bool HasProperty(PropertyName key) { }

	internal void IncrementVersion(VersionChangeType changeType) { }

	public int IndexOf(VisualElement element) { }

	public void Insert(int index, VisualElement element) { }

	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	internal void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	public void MarkDirtyRepaint() { }

	internal void MarkRenderHintsClean() { }

	internal static float Max(float a, float b, float c, float d) { }

	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	internal static float Min(float a, float b, float c, float d) { }

	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	internal void OnViewDataReady(bool enablePersistence) { }

	internal override void OnViewDataReady() { }

	internal static void OrderMinMaxRect(ref Rect rect) { }

	internal void OverwriteFromViewData(object obj, string key) { }

	public void PlaceBehind(VisualElement sibling) { }

	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	private void PropagateEnabledToChildren(bool value) { }

	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	private void RegisterRunningAnimations() { }

	public void RemoveFromClassList(string className) { }

	public void RemoveFromHierarchy() { }

	private void RemoveMeasureFunction() { }

	private StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	private Quaternion ResolveRotation() { }

	private Vector3 ResolveScale() { }

	private Vector3 ResolveTransformOrigin() { }

	private Vector3 ResolveTranslate() { }

	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	internal void SaveViewData() { }

	public virtual void SendEvent(EventBase e) { }

	internal virtual void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	public void SendToBack() { }

	[CompilerGenerated]
	private void set_containedPointerIds(int value) { }

	internal void set_disableClipping(bool value) { }

	[CompilerGenerated]
	private void set_elementPanel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	private void set_enabledSelf(bool value) { }

	private void set_enableViewDataPersistence(bool value) { }

	internal void set_eventCallbackCategories(int value) { }

	[CompilerGenerated]
	public void set_generateVisualContent(Action value) { }

	[CompilerGenerated]
	private void set_hierarchy(Hierarchy value) { }

	internal void set_isBoundingBoxDirty(bool value) { }

	internal void set_isCompositeRoot(bool value) { }

	internal void set_isEventCallbackParentCategoriesDirty(bool value) { }

	internal void set_isHierarchyDisplayed(bool value) { }

	private void set_isLayoutManual(bool value) { }

	[CompilerGenerated]
	internal void set_isRootVisualContainer(bool value) { }

	internal void set_isWorldBoundingBoxDirty(bool value) { }

	internal void set_isWorldClipDirty(bool value) { }

	internal void set_isWorldTransformDirty(bool value) { }

	internal void set_isWorldTransformInverseDirty(bool value) { }

	internal void set_layout(Rect value) { }

	internal void set_localLanguageDirection(LanguageDirection value) { }

	public void set_name(string value) { }

	public void set_pickingMode(PickingMode value) { }

	internal void set_pseudoStates(PseudoStates value) { }

	internal void set_renderHints(RenderHints value) { }

	internal void set_requireMeasureFunction(bool value) { }

	internal void set_styleInitialized(bool value) { }

	public void set_tooltip(string value) { }

	public void set_usageHints(UsageHints value) { }

	public void set_userData(object value) { }

	public void set_viewDataKey(string value) { }

	public void set_visible(bool value) { }

	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	[CompilerGenerated]
	private void set_yogaNode(YogaNode value) { }

	private void SetAsNextParentWithEventCallback() { }

	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	public void SetEnabled(bool value) { }

	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	internal void SetPanel(BaseVisualElementPanel p) { }

	internal void SetProperty(PropertyName key, object value) { }

	private void SetPropertyInternal(PropertyName key, object value) { }

	private void SetTooltip(TooltipEvent e) { }

	internal bool ShouldClip() { }

	private ValueAnimation Start(Func fromValueGetter, StyleValues to, int durationMs) { }

	private static ValueAnimation StartAnimation(ValueAnimation anim, Func fromValueGetter, T to, int durationMs, Action onValueChanged) { }

	private Rect SubstractBorderPadding(Rect worldRect) { }

	public virtual string ToString() { }

	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	private bool TryGetPropertyInternal(PropertyName key, out object value) { }

	private override ValueAnimation UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	private override Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	private override Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	private override float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	[CompilerGenerated]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[CompilerGenerated]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	private override void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List outPropertyIds) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func easingCurve) { }

	private override bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func easingCurve) { }

	private override void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	private override Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	private override Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	private override void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action timerUpdateEvent) { }

	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	private void UnregisterRunningAnimations() { }

	internal void UpdateBoundingBox() { }

	private void UpdateCallbackParentCategories() { }

	private void UpdateCursorStyle(long eventType) { }

	private void UpdateHoverPseudoState() { }

	internal void UpdateWorldBoundingBox() { }

	private void UpdateWorldClip() { }

	internal void UpdateWorldTransform() { }

	internal void UpdateWorldTransformInverse() { }

	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

}

