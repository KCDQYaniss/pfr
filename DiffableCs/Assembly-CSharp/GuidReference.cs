//Type is in global namespace

public class GuidReference : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__23_0; //Field offset: 0x8
		public static Action <>9__23_1; //Field offset: 0x10
		public static Action <>9__24_0; //Field offset: 0x18
		public static Action <>9__24_1; //Field offset: 0x20
		public static Action <>9__25_0; //Field offset: 0x28
		public static Action <>9__25_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__23_0(GameObject go) { }

		internal void <.ctor>b__23_1() { }

		internal void <.ctor>b__24_0(GameObject go) { }

		internal void <.ctor>b__24_1() { }

		internal void <.ctor>b__25_0(GameObject go) { }

		internal void <.ctor>b__25_1() { }

	}

	private GameObject cachedReference; //Field offset: 0x10
	private bool isCacheSet; //Field offset: 0x18
	[SerializeField]
	private byte[] serializedGuid; //Field offset: 0x20
	private Guid guid; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnGuidAdded; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnGuidRemoved; //Field offset: 0x40
	private Action addDelegate; //Field offset: 0x48
	private Action removeDelegate; //Field offset: 0x50

	public event Action OnGuidAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnGuidRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public byte[] AsBytes
	{
		 get { } //Length: 5
	}

	public private GameObject gameObject
	{
		 get { } //Length: 442
		private set { } //Length: 3
	}

	public Guid ObjectGuid
	{
		 get { } //Length: 11
	}

	public string ObjectGuidString
	{
		 get { } //Length: 69
	}

	public GuidReference(GuidComponent target) { }

	public GuidReference(byte[] guidBytes) { }

	public GuidReference() { }

	[CompilerGenerated]
	public void add_OnGuidAdded(Action value) { }

	[CompilerGenerated]
	public void add_OnGuidRemoved(Action value) { }

	public byte[] get_AsBytes() { }

	public GameObject get_gameObject() { }

	public Guid get_ObjectGuid() { }

	public string get_ObjectGuidString() { }

	public T GetComponent() { }

	private void GuidAdded(GameObject go) { }

	private void GuidRemoved() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public static bool op_Equality(GuidReference a, GuidReference b) { }

	public static bool op_Inequality(GuidReference a, GuidReference b) { }

	[CompilerGenerated]
	public void remove_OnGuidAdded(Action value) { }

	[CompilerGenerated]
	public void remove_OnGuidRemoved(Action value) { }

	private void set_gameObject(GameObject value) { }

	public virtual string ToString() { }

}

