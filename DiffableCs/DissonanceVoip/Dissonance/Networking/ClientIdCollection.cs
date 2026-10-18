namespace Dissonance.Networking;

internal sealed class ClientIdCollection : IReadonlyClientIdCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal KeyValuePair <.ctor>b__6_0(string a, int i) { }

		internal bool <.ctor>b__6_1(KeyValuePair x) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly List _items; //Field offset: 0x10
	private readonly List _freeIds; //Field offset: 0x18
	private readonly IEnumerable _alive; //Field offset: 0x20

	[NotNull]
	public IEnumerable Items
	{
		 get { } //Length: 5
	}

	private static ClientIdCollection() { }

	public ClientIdCollection() { }

	private void AddFreeId(ushort id) { }

	public void Clear() { }

	public IEnumerable get_Items() { }

	private ushort GetFreeId() { }

	public override Nullable GetId(string name) { }

	public override string GetName(ushort id) { }

	public void Load(List clients) { }

	public ushort Register(string name) { }

	public bool Unregister(string name) { }

}

