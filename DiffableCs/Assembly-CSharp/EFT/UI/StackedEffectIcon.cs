namespace EFT.UI;

public sealed class StackedEffectIcon : EffectIcon
{
	[SerializeField]
	private TextMeshProUGUI _stackCount; //Field offset: 0xB8

	public StackedEffectIcon() { }

	public virtual void Close() { }

	public void Show(EffectDescription variation, int stackCount, Func counterVisibility, bool blinking = false) { }

}

