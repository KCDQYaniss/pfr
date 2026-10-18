namespace EFT.UI;

public sealed class TradingOfferTooltipArea : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__CloseTooltip; //Field offset: 0x0

	}

	private QuestReward _reward; //Field offset: 0x70

	public TradingOfferTooltipArea() { }

	public void Clear() { }

	public virtual void Close() { }

	private static void CloseTooltip() { }

	public void Show(QuestReward reward) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

