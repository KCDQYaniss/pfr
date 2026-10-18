namespace EFT;

public sealed class WishlistManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8
		public static Func <>9__27_1; //Field offset: 0x10
		public static Func <>9__27_2; //Field offset: 0x18
		public static Func <>9__27_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal MongoID <.ctor>b__27_0(KeyValuePair pair) { }

		internal EWishlistGroup <.ctor>b__27_1(KeyValuePair pair) { }

		internal MongoID <.ctor>b__27_2(KeyValuePair pair) { }

		internal EWishlistGroup <.ctor>b__27_3(KeyValuePair pair) { }

	}

	[CompilerGenerated]
	private sealed class <GetHideoutQolItemsEnumerator>d__40 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MongoID <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x30
		public WishlistManager <>4__this; //Field offset: 0x38
		private HideoutRepresentation <hideout>5__2; //Field offset: 0x40
		private Enumerator <>7__wrap2; //Field offset: 0x48
		private IEnumerator <>7__wrap3; //Field offset: 0x60
		private IEnumerator <>7__wrap4; //Field offset: 0x68
		private IEnumerator <>7__wrap5; //Field offset: 0x70

		private override MongoID System.Collections.Generic.IEnumerator<EFT.MongoID>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 85
		}

		[DebuggerHidden]
		public <GetHideoutQolItemsEnumerator>d__40(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.MongoID>.GetEnumerator() { }

		[DebuggerHidden]
		private override MongoID System.Collections.Generic.IEnumerator<EFT.MongoID>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly LocalizedErrorWithKey _alreadyInWishlistError; //Field offset: 0x0
	private static readonly LocalizedErrorWithKey _notInWishlistError; //Field offset: 0x8
	private static readonly LocalizedErrorWithKey _wishlistLimitReachedError; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnAddInWishlist; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnRemoveFromWishlist; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnChangeGroup; //Field offset: 0x20
	private readonly Dictionary _userItems; //Field offset: 0x28
	private readonly Dictionary _wishlistItems; //Field offset: 0x30
	private readonly Dictionary _cachedRecipesResults; //Field offset: 0x38

	public event Action OnAddInWishlist
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnChangeGroup
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRemoveFromWishlist
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private static EAutoAddToWishlist AutoAddHideoutOption
	{
		private get { } //Length: 123
	}

	private static bool AutoAddRecipes
	{
		private get { } //Length: 88
	}

	private static bool AutoAddZones
	{
		private get { } //Length: 93
	}

	private static int MaxWishlistItemsCount
	{
		private get { } //Length: 250
	}

	public IReadOnlyDictionary UserItems
	{
		 get { } //Length: 5
	}

	private static WishlistSettings WishlistSettings
	{
		private get { } //Length: 191
	}

	private static WishlistManager() { }

	public WishlistManager(Dictionary wishlistItems) { }

	[CompilerGenerated]
	public void add_OnAddInWishlist(Action value) { }

	[CompilerGenerated]
	public void add_OnChangeGroup(Action value) { }

	[CompilerGenerated]
	public void add_OnRemoveFromWishlist(Action value) { }

	public OperationResult AddToWishlist(MongoID templateId, EWishlistGroup groupType, bool simulate) { }

	public OperationResult ChangeItemGroup(MongoID templateId, EWishlistGroup groupType, bool simulate) { }

	private static EAutoAddToWishlist get_AutoAddHideoutOption() { }

	private static bool get_AutoAddRecipes() { }

	private static bool get_AutoAddZones() { }

	private static int get_MaxWishlistItemsCount() { }

	public IReadOnlyDictionary get_UserItems() { }

	private static WishlistSettings get_WishlistSettings() { }

	private HashSet GetHideoutQolItems() { }

	[IteratorStateMachine(typeof(<GetHideoutQolItemsEnumerator>d__40))]
	private IEnumerable GetHideoutQolItemsEnumerator() { }

	public IReadOnlyDictionary GetWishlist() { }

	public static ENotificationIconType GroupToWishlistIcon(EWishlistGroup group) { }

	private static bool IgnoreAreaWithUnfulfilledNonItemRequirement(RelatedRequirements requirements) { }

	public static bool IsAvailableForWishlist(Item item) { }

	private bool IsAvailableForWishlist(MongoID templateId) { }

	private bool IsInHideoutQolWishlist(MongoID templateId) { }

	public bool IsInWishlist(MongoID templateId, bool includeQol, out EWishlistGroup group) { }

	public static bool IsNotificationsEnableInMenu() { }

	public static bool IsNotificationsEnableInRaid() { }

	[CompilerGenerated]
	public void remove_OnAddInWishlist(Action value) { }

	[CompilerGenerated]
	public void remove_OnChangeGroup(Action value) { }

	[CompilerGenerated]
	public void remove_OnRemoveFromWishlist(Action value) { }

	public OperationResult RemoveFromWishlist(MongoID templateId, bool simulate) { }

}

