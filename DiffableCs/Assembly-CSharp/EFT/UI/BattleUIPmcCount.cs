namespace EFT.UI;

public sealed class BattleUIPmcCount : BattleUIPanel
{
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x78
	[SerializeField]
	private Image _template; //Field offset: 0x80
	[SerializeField]
	private RectTransform _container; //Field offset: 0x88
	[SerializeField]
	private Sprite _onSprite; //Field offset: 0x90
	[SerializeField]
	private Sprite _offSprite; //Field offset: 0x98
	private readonly List _instantiatedImages; //Field offset: 0xA0
	private int _currentCount; //Field offset: 0xA8

	public BattleUIPmcCount() { }

	private void Clear() { }

	public virtual void Close() { }

	public void Enter() { }

	public void Exit() { }

	public void Show(int maxCount, int current) { }

}

