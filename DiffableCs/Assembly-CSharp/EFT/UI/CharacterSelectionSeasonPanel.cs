namespace EFT.UI;

public sealed class CharacterSelectionSeasonPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public CharacterSelectionSeasonInfo seasonInfo; //Field offset: 0x10
		public CharacterSelectionSeasonPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <FillStats>b__0(ECharacterSelectionSeasonStat stat, CharacterSelectionSeasonStatView view) { }

	}

	internal sealed class StatIconDictionary : SerializableEnumDictionary
	{

		public StatIconDictionary() { }

	}

	[SerializeField]
	private CharacterSelectionSeasonPerkView _perkTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _perksContainer; //Field offset: 0x78
	[SerializeField]
	private CharacterSelectionSeasonStatView _statTemplate; //Field offset: 0x80
	[SerializeField]
	private Transform _statsContainer; //Field offset: 0x88
	[SerializeField]
	private StatIconDictionary _statIcons; //Field offset: 0x90
	private readonly List _perkViews; //Field offset: 0x98

	public CharacterSelectionSeasonPanel() { }

	public virtual void Close() { }

	private void ClosePerkViews() { }

	private void FillStats(CharacterSelectionSeasonInfo seasonInfo) { }

	public bool Show(CharacterSelectionSeasonInfo seasonInfo, SeasonalPerksData seasonalPerks) { }

	private void ShowPerks(SeasonalPerksData seasonalPerks) { }

}

