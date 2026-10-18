namespace EFT.UI;

public abstract class HoverTooltipAreaBase : MonoBehaviour
{

	protected HoverTooltipAreaBase() { }

	public abstract void SetMessageText(Func textGetter) { }

	public abstract void SetMessageText(string text, bool rawText = false) { }

}

