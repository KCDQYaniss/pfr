namespace EFT.UI.Seasons;

public sealed class BattlePassUniversalItemView : BattlePassBaseItemView
{
	private const string DEFAULT_COUNT_FORMATTER = "x{0}"; //Field offset: 0x0
	private Nullable _count; //Field offset: 0xC8
	private string _formatter; //Field offset: 0xD0

	public BattlePassUniversalItemView() { }

	[CompilerGenerated]
	private void <Show>b__3_0(int _) { }

	protected virtual string GetCountText(int itemsCount) { }

	protected virtual int GetItemsCount() { }

	protected virtual bool IsActive(int itemsCount) { }

	public void Show(BattlePassController controller, IImageLoader imageLoader) { }

	public void Show(BattlePassController controller, IImageLoader imageLoader, int count, string formatter) { }

}

