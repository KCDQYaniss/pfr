namespace Systems.Effects;

public sealed class Storage`1
{
	[IsReadOnly]
	internal struct ReadOnly
	{
		private readonly Storage _storage; //Field offset: 0x0

		public event Action OnAdd
		{
			 add { } //Length: 325
			 remove { } //Length: 325
		}

		public event Action OnChanged
		{
			 add { } //Length: 325
			 remove { } //Length: 325
		}

		public event Action OnRemove
		{
			 add { } //Length: 325
			 remove { } //Length: 325
		}

		public int Count
		{
			 get { } //Length: 55
		}

		public IReadOnlyList Data
		{
			 get { } //Length: 26
		}

		public IReadOnlyDictionary Indices
		{
			 get { } //Length: 26
		}

		internal ReadOnly(Storage storage) { }

		public void add_OnAdd(Action value) { }

		public void add_OnChanged(Action value) { }

		public void add_OnRemove(Action value) { }

		public int get_Count() { }

		public IReadOnlyList get_Data() { }

		public IReadOnlyDictionary get_Indices() { }

		public void remove_OnAdd(Action value) { }

		public void remove_OnChanged(Action value) { }

		public void remove_OnRemove(Action value) { }

		public bool TryGetIndex(T item, out int index) { }

	}

	private readonly List _items; //Field offset: 0x0
	private readonly Dictionary _indices; //Field offset: 0x0
	[CompilerGenerated]
	private Action _onAdd; //Field offset: 0x0
	[CompilerGenerated]
	private Action _onRemove; //Field offset: 0x0
	[CompilerGenerated]
	private Action _onChanged; //Field offset: 0x0

	private event Action _onAdd
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	private event Action _onChanged
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	private event Action _onRemove
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public int Count
	{
		 get { } //Length: 26
	}

	public Storage`1() { }

	public bool Add(T item) { }

	[CompilerGenerated]
	private void add__onAdd(Action value) { }

	[CompilerGenerated]
	private void add__onChanged(Action value) { }

	[CompilerGenerated]
	private void add__onRemove(Action value) { }

	public bool Changed(T item) { }

	public void Clear() { }

	public int get_Count() { }

	public ReadOnly GetAccess() { }

	public bool Remove(T item) { }

	[CompilerGenerated]
	private void remove__onAdd(Action value) { }

	[CompilerGenerated]
	private void remove__onChanged(Action value) { }

	[CompilerGenerated]
	private void remove__onRemove(Action value) { }

	public bool TryGetIndex(T item, out int index) { }

}

