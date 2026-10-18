namespace EFT.UI;

[CreateAssetMenu(fileName = "ChatSpecialIconSettings", menuName = "EFT/Create ChatSpecialIconSettings object", order = 0)]
public sealed class ChatSpecialIconSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public EMemberCategory targetCategory; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetDataByMemberCategory>b__0(IconsData t) { }

	}

	internal class IconsData
	{
		public string Name; //Field offset: 0x10
		public EMemberCategory Category; //Field offset: 0x18
		public Sprite IconSprite; //Field offset: 0x20
		public Color IconColor; //Field offset: 0x28

		public IconsData() { }

	}

	public const string ASSET_NAME = "ChatSpecialIconSettings"; //Field offset: 0x0
	private static readonly EMemberCategory[] _memberCategories; //Field offset: 0x0
	public EMemberCategory[] Priority; //Field offset: 0x18
	public IconsData[] IconsSettings; //Field offset: 0x20
	public PrestigeIconsDataDictionary PrestigeIcons; //Field offset: 0x28
	public PrestigeIconsDataDictionary PvePrestigeIcons; //Field offset: 0x30
	public TMP_SpriteAsset RichTextIcons; //Field offset: 0x38
	private readonly SortedList _availableFlags; //Field offset: 0x40

	private static ChatSpecialIconSettings() { }

	public ChatSpecialIconSettings() { }

	public static int GetAtlasIconId(EMemberCategory category) { }

	public IconsData GetDataByMemberCategory(EMemberCategory category) { }

	public PrestigeIconsDataDictionary GetPrestigeIcons(EGameMode gameMode) { }

	public PrestigeIconsData GetPrestigeLevelIconData(int prestigeLevel, EGameMode gameMode = 0) { }

}

