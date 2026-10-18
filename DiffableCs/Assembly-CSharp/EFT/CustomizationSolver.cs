namespace EFT;

public sealed class CustomizationSolver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8
		public static Func <>9__31_2; //Field offset: 0x10
		public static Func <>9__32_1; //Field offset: 0x18
		public static Func <>9__35_0; //Field offset: 0x20
		public static Func <>9__35_1; //Field offset: 0x28
		public static Func <>9__35_3; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <GetAvailableHideoutCustomizationItems>b__31_0(AvailableCustomization c) { }

		internal bool <GetAvailableHideoutCustomizationItems>b__31_2(HideoutCustomizationItem item) { }

		internal bool <GetAvailableHideoutMannequinPoses>b__32_1(CustomizationHideoutMannequinPose pose) { }

		internal bool <GetBundlesToLoad>b__35_0(CustomizationClothing x) { }

		internal ResourceKey <GetBundlesToLoad>b__35_1(CustomizationClothing x) { }

		internal bool <GetBundlesToLoad>b__35_3(ResourceKey x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public string profileVersion; //Field offset: 0x18
		public EPlayerSide playerSide; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal CustomizationSuite <GetAvailableSuites>b__0(AvailableCustomization suite) { }

		internal bool <GetAvailableSuites>g__Selector|1(CustomizationSuite suite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public EPlayerSide playerSide; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal CustomizationDogTag <GetAvailableDogTags>b__0(AvailableCustomization dogTag) { }

		internal bool <GetAvailableDogTags>b__1(CustomizationDogTag dogTag) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public EPlayerSide playerSide; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal CustomizationGesture <GetAvailableGestures>b__0(AvailableCustomization gesture) { }

		internal bool <GetAvailableGestures>b__1(CustomizationGesture gesture) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public EPlayerSide playerSide; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal CustomizationEnvironmentUI <GetAvailableEnvironmentUIs>b__0(AvailableCustomization environmentUI) { }

		internal bool <GetAvailableEnvironmentUIs>b__1(CustomizationEnvironmentUI environmentUI) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public EPlayerSide playerSide; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal CustomizationHead <GetAvailableHeads>b__0(AvailableCustomization head) { }

		internal bool <GetAvailableHeads>b__1(CustomizationHead head) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public CustomizationSolver <>4__this; //Field offset: 0x10
		public EPlayerSide playerSide; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal CustomizationPlayerVoice <GetAvailableVoices>b__0(AvailableCustomization voice) { }

		internal bool <GetAvailableVoices>b__1(CustomizationPlayerVoice voice) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public MongoID suiteId; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <IsCustomizationAvailable>b__0(AvailableCustomization customization) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public ECustomizationType type; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <GetAvailableCustomizationsByType>b__0(AvailableCustomization x) { }

	}

	private readonly Dictionary _customizationItemsCategories; //Field offset: 0x10
	private readonly Dictionary _customizationClothingTemplates; //Field offset: 0x18
	private readonly Dictionary _customizationSuiteTemplates; //Field offset: 0x20
	private readonly Dictionary _voices; //Field offset: 0x28
	private readonly Dictionary _dogTagTemplates; //Field offset: 0x30
	private readonly Dictionary _headTemplates; //Field offset: 0x38
	private readonly Dictionary _gestures; //Field offset: 0x40
	private readonly Dictionary _environmentUis; //Field offset: 0x48
	private readonly Dictionary _hideoutCustomizationTemplates; //Field offset: 0x50
	private readonly Dictionary _hideoutMannequinPoses; //Field offset: 0x58
	private readonly HashSet _availableCustomizations; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnAvailableCustomizationsChanged; //Field offset: 0x68

	public event Action OnAvailableCustomizationsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public IReadOnlyCollection AvailableCustomizations
	{
		 get { } //Length: 5
	}

	public CustomizationClothing[] ClothingTemplates
	{
		 get { } //Length: 223
	}

	public IEnumerable EnvironmentUIs
	{
		 get { } //Length: 73
	}

	public IEnumerable HideoutCustomizationItems
	{
		 get { } //Length: 73
	}

	public IEnumerable HideoutMannequinPoses
	{
		 get { } //Length: 73
	}

	public CustomizationSolver(Dictionary customizationTemplates) { }

	[CompilerGenerated]
	private HideoutCustomizationItem <GetAvailableHideoutCustomizationItems>b__31_1(AvailableCustomization item) { }

	[CompilerGenerated]
	private CustomizationHideoutMannequinPose <GetAvailableHideoutMannequinPoses>b__32_0(AvailableCustomization pose) { }

	[CompilerGenerated]
	private ResourceKey <GetBundlesToLoad>b__35_2(CustomizationClothing x) { }

	[CompilerGenerated]
	public void add_OnAvailableCustomizationsChanged(Action value) { }

	public IReadOnlyCollection get_AvailableCustomizations() { }

	public CustomizationClothing[] get_ClothingTemplates() { }

	public IEnumerable get_EnvironmentUIs() { }

	public IEnumerable get_HideoutCustomizationItems() { }

	public IEnumerable get_HideoutMannequinPoses() { }

	public BaseCustomizationItem GetAnyCustomizationItem(MongoID id) { }

	private IEnumerable GetAvailableCustomizationsByType(ECustomizationType type) { }

	public IEnumerable GetAvailableDogTags(EPlayerSide playerSide) { }

	public IEnumerable GetAvailableEnvironmentUIs(EPlayerSide playerSide) { }

	public IEnumerable GetAvailableGestures(EPlayerSide playerSide) { }

	public IEnumerable GetAvailableHeads(EPlayerSide playerSide) { }

	public IEnumerable GetAvailableHideoutCustomizationItems() { }

	public IEnumerable GetAvailableHideoutMannequinPoses() { }

	public IEnumerable GetAvailableSuites(EPlayerSide playerSide, string profileVersion) { }

	public IEnumerable GetAvailableVoices(EPlayerSide playerSide) { }

	[CanBeNull]
	public ResourceKey GetBundle(MongoID templateId) { }

	public IEnumerable GetBundlesToLoad(IEnumerable customizationIds) { }

	public bool GetCustomizationCategory(MongoID itemId, out ECustomizationItemCategory category) { }

	private T GetCustomizationItem(MongoID id, Dictionary dictionary) { }

	public CustomizationDogTag GetDogTag(MongoID dogTagId) { }

	[CanBeNull]
	public CustomizationClothing GetItem(MongoID templateId) { }

	[CanBeNull]
	public CustomizationSuite GetSuite(MongoID suiteId) { }

	public CustomizationPlayerVoice GetVoice(MongoID voiceId) { }

	public WatchBundleInfo GetWatchBundle(MongoID templateId) { }

	public bool HasIntegratedArmor(MongoID templateId) { }

	public bool IsCustomizationAvailable(MongoID suiteId) { }

	[CompilerGenerated]
	public void remove_OnAvailableCustomizationsChanged(Action value) { }

	public void SetAvailableCustomizations(IEnumerable availableSuites, bool overrideExisting = false) { }

}

