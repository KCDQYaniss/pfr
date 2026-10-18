namespace EFT.UI;

public sealed class SeasonalModifiersList : UIElement
{
	[SerializeField]
	private SeasonalModifierIconView _template; //Field offset: 0x70
	[Header("Common")]
	[SerializeField]
	private Transform _commonContainer; //Field offset: 0x78
	[SerializeField]
	private GameObject _commonSection; //Field offset: 0x80
	[Header("Personal")]
	[SerializeField]
	private Transform _positiveContainer; //Field offset: 0x88
	[SerializeField]
	private GameObject _positiveSection; //Field offset: 0x90
	[SerializeField]
	private Transform _negativeContainer; //Field offset: 0x98
	[SerializeField]
	private GameObject _negativeSection; //Field offset: 0xA0
	private readonly List _activeViews; //Field offset: 0xA8
	private readonly Queue _viewsPool; //Field offset: 0xB0

	public SeasonalModifiersList() { }

	private void Awake() { }

	public virtual void Close() { }

	private void RecycleViews() { }

	private static void SetSectionActive(GameObject section, Transform container, bool active) { }

	public void Show(IEnumerable commonPerks, IEnumerable personalPerks, IImageLoader imageLoader) { }

	private void ShowPerk(ISeasonalPerk perk, Transform container, IImageLoader imageLoader) { }

}

