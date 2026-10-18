//Type is in global namespace

public class GuidManager
{
	private struct GuidInfo
	{
		public GameObject go; //Field offset: 0x0
		[CompilerGenerated]
		private Action OnAdd; //Field offset: 0x8
		[CompilerGenerated]
		private Action OnRemove; //Field offset: 0x10

		public event Action OnAdd
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public event Action OnRemove
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public GuidInfo(GuidComponent comp) { }

		[CompilerGenerated]
		public void add_OnAdd(Action value) { }

		[CompilerGenerated]
		public void add_OnRemove(Action value) { }

		public void HandleAddCallback() { }

		public void HandleRemoveCallback() { }

		[CompilerGenerated]
		public void remove_OnAdd(Action value) { }

		[CompilerGenerated]
		public void remove_OnRemove(Action value) { }

	}

	private static GuidManager Instance; //Field offset: 0x0
	private Dictionary guidToObjectMap; //Field offset: 0x10

	private GuidManager() { }

	public static bool Add(GuidComponent guidComponent) { }

	private bool InternalAdd(GuidComponent guidComponent) { }

	private void InternalRemove(Guid guid) { }

	public static void Remove(Guid guid) { }

	public static GameObject ResolveGuid(Guid guid, Action onAddCallback, Action onRemoveCallback) { }

	public static GameObject ResolveGuid(Guid guid, Action onDestroyCallback) { }

	public static GameObject ResolveGuid(Guid guid) { }

	private GameObject ResolveGuidInternal(Guid guid, Action onAddCallback, Action onRemoveCallback) { }

}

