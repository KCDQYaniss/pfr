namespace EFT.UI;

public class StatItemView : UIElement
{
	public const string UNITS_LITERS = "UI/ProfileStats/Liters"; //Field offset: 0x0
	public const string UNITS_METERS = "UI/ProfileStats/Meters"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _value; //Field offset: 0x78

	public StatItemView() { }

	private static string GetStatSuffix(EStatType statType) { }

	public void Show(StatInfo statItem) { }

}

