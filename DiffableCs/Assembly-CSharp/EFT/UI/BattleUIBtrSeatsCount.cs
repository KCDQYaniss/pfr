namespace EFT.UI;

public sealed class BattleUIBtrSeatsCount : BattleUIPanel
{
	[SerializeField]
	private Image _iconTemplate; //Field offset: 0x78
	[SerializeField]
	private Image _dividerTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _container; //Field offset: 0x88
	[SerializeField]
	private Color _onColor; //Field offset: 0x90
	[SerializeField]
	private Color _offColor; //Field offset: 0xA0
	private readonly List _instantiatedPlaces; //Field offset: 0xB0
	private bool _initialized; //Field offset: 0xB8

	public BattleUIBtrSeatsCount() { }

	[CompilerGenerated]
	private void <Show>b__7_0() { }

	private void CheckCurrentScreen(EEftScreenType screenType) { }

	public void Show(bool[][] sidesInfo) { }

}

