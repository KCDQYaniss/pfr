namespace EFT.UI.DragAndDrop;

public class ItemViewFactory : MonoBehaviour
{
	[CompilerGenerated]
	private struct <GetItemSpriteAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Item item; //Field offset: 0x20
		public int scaleFactor; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Quaternion VerticalRotation; //Field offset: 0x0
	public const int CellSize = 62; //Field offset: 0x0
	public const int BorderSize = 1; //Field offset: 0x0
	public const string PrefabLayoutsPath = "Prefabs/UGUI/Layouts/"; //Field offset: 0x0
	public static readonly Quaternion HorizontalRotation; //Field offset: 0x10

	private static ItemViewFactory() { }

	public ItemViewFactory() { }

	public static T CreateFromPool(string prefabName) { }

	public static T CreateFromPrefab(string prefabName) { }

	public static IntVec2 GetCellPixelSize(IntVec2 size) { }

	[AsyncStateMachine(typeof(<GetItemSpriteAsync>d__9))]
	public static Task GetItemSpriteAsync(Item item, int scaleFactor = 1) { }

	public static EItemType GetItemType(Type itemType) { }

	public static EModClass GetModClass(Type modType) { }

	public static string GetModClassIconName(Item item) { }

	public static string GetModClassIconName(Type type) { }

	public static string GetModIconName(Item item) { }

	public static string GetModIconName(Type type) { }

	public static string GetModSlotName(EWeaponModType modType) { }

	public static EModSubclass GetModSubclass(Type modType) { }

	public static EModClass GetSlotModClass(EWeaponModType modType) { }

	public static string GetSpecialIcon(Item item) { }

	public static bool IsSecureContainer(Item item) { }

	public static ItemIcon LoadItemIcon(Item item, int scaleFactor = 1, bool forcedGeneration = false) { }

	[CanBeNull]
	public static Sprite LoadItemTypeSprite(Type type) { }

	[CanBeNull]
	public static Sprite LoadModClassIconSprite(Item item) { }

	[CanBeNull]
	public static Sprite LoadModClassIconSprite(Type type) { }

	[CanBeNull]
	public static Sprite LoadModIconSprite(Type type) { }

	[CanBeNull]
	public static Sprite LoadModIconSprite(Item item) { }

}

