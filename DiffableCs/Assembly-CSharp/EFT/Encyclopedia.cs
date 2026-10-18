namespace EFT;

public sealed class Encyclopedia
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal MongoID <ToDescriptor>b__11_0(KeyValuePair kvp) { }

		internal bool <ToDescriptor>b__11_1(KeyValuePair kvp) { }

	}

	[CompilerGenerated]
	private Action OnExamine; //Field offset: 0x10
	private readonly Dictionary _examineData; //Field offset: 0x18
	private readonly IReadOnlyDictionary _completableDataReference; //Field offset: 0x20

	public event Action OnExamine
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Encyclopedia(Dictionary examineData, IReadOnlyDictionary completableData) { }

	[CompilerGenerated]
	public void add_OnExamine(Action value) { }

	public bool Available(ItemTemplate template) { }

	public bool Examined(ItemTemplate template) { }

	public bool Forget(MongoID templateId) { }

	public void Learn(MongoID templateId) { }

	[CompilerGenerated]
	public void remove_OnExamine(Action value) { }

	public Dictionary ToDescriptor() { }

	public bool Viewed(MongoID templateId) { }

}

