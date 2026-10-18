namespace EFT;

public static class LocationAccessRequirementsUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Comparison <>9__6_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <TryConsumeByTemplate>b__6_0(Item left, Item right) { }

		internal string <TryFindSatisfiedRequirement>b__4_0(KeyValuePair x) { }

	}


	public static bool HasAnyValidAccessRequirement(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Func canUseItem = null) { }

	private static bool HasSufficientKeyCharges(KeyComponent keyComponent, int requiredCount) { }

	public static void RemoveAllNonKeyItemsByTemplate(IEnumerable inventoryItems, string templateId) { }

	public static bool TryConsumeAccessRequirement(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Func canUseItem) { }

	private static bool TryConsumeByTemplate(IEnumerable inventoryItems, string templateId, int requiredCount, Func canUseItem) { }

	private static bool TryFindSatisfiedRequirement(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Func canUseItem, out Item selectedItem, out string selectedTemplateId, out int requiredCount) { }

	public static bool TryGetUsedLocationItemRequirement(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Func canUseItem, out string selectedTemplateId, out int requiredCount) { }

	public static bool TryRemoveItem(Item itemToRemove) { }

	public static bool TrySelectAccessItem(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount, Func canUseItem, out Item selectedItem) { }

}

