namespace EFT.UI;

public sealed class QuestTierAccessoryIconView : UIElement
{
	private const int MaxTierRank = 4; //Field offset: 0x0
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject _chainIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _dailyIcon; //Field offset: 0x80

	public QuestTierAccessoryIconView() { }

	public virtual void Close() { }

	private void HideAll() { }

	public void Show(ETierAccessoryType tier) { }

}

