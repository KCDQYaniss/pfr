namespace EFT.UI.Settings;

public sealed class SettingsHoverTooltipArea : HoverTooltipAreaBase, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private SettingsTooltipData _tooltipData; //Field offset: 0x20
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0x28

	public SettingsHoverTooltipArea() { }

	private void OnApplicationFocus(bool inFocus) { }

	private void OnDisable() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public virtual void SetMessageText(string text, bool rawText = false) { }

	public virtual void SetMessageText(Func textGetter) { }

	public void SetValues(SettingsTooltipData tooltipData, SettingsTooltip tooltip) { }

}

