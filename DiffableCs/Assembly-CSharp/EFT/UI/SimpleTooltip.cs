namespace EFT.UI;

public class SimpleTooltip : Tooltip
{
	private readonly Vector2 _defaultOffset; //Field offset: 0xA8
	[FormerlySerializedAs("_text")]
	[SerializeField]
	private TextMeshProUGUI _label; //Field offset: 0xB0

	public SimpleTooltip() { }

	public void SetText(string text) { }

	public CancellationToken Show(string text, Nullable offset = null, float delay = 0, Nullable maxWidth = null, bool locked = false) { }

	public void ShowInventoryError(InventoryError error) { }

	public void ShowWarning(InventoryError warning) { }

}

