namespace EFT.UI;

[RequireComponent(typeof(BattleUIComponentAnimation))]
public class AnimatedTextPanel : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _currentCrate; //Field offset: 0x70
	private BattleUIComponentAnimation _animation; //Field offset: 0x78

	public AnimatedTextPanel() { }

	public virtual void Close() { }

	public void Hide() { }

	public void Show(string message) { }

}

