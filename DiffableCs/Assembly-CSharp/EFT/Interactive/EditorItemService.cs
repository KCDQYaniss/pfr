namespace EFT.Interactive;

public class EditorItemService : SelfInitializedSingleton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string templateId; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <GetItem>b__0(ItemPreset preset) { }

	}

	private const int DEFAULT_RELOAD_RETRIES_COUNT = 1; //Field offset: 0x0
	public ItemTemplates ItemTemplates; //Field offset: 0x10
	public Dictionary ItemPresets; //Field offset: 0x18
	private int _templatesReloadRetries; //Field offset: 0x20
	[CompilerGenerated]
	private ObjectsFactory <ObjectFactory>k__BackingField; //Field offset: 0x28
	private bool _initializing; //Field offset: 0x30

	public private ObjectsFactory ObjectFactory
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EditorItemService() { }

	private static void ClearProgress() { }

	private static void DisplayProgress(string header, string message, float progress) { }

	[CompilerGenerated]
	public ObjectsFactory get_ObjectFactory() { }

	public Item GetItem(string templateId) { }

	public void Init() { }

	private void InitItemFactory() { }

	private void InitItemPresets() { }

	private void InitItemTemplates() { }

	[CompilerGenerated]
	private void set_ObjectFactory(ObjectsFactory value) { }

}

