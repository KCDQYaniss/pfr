namespace EFT.UI;

public class BattleUiBipodPanel : UIElement
{
	[SerializeField]
	private List _mountDirections; //Field offset: 0x70
	[SerializeField]
	private GameObject _mountImage; //Field offset: 0x78
	[SerializeField]
	private Image _mountUnavailableImage; //Field offset: 0x80
	[SerializeField]
	private float _highlightDuration; //Field offset: 0x88
	private Player _player; //Field offset: 0x90
	private Sequence _highlightTweenSequence; //Field offset: 0x98

	public BattleUiBipodPanel() { }

	[CompilerGenerated]
	private void <OnMountUnavailable>b__9_0() { }

	[CompilerGenerated]
	private void <Subscribe>b__11_0() { }

	private void ChangeMountImage() { }

	public virtual void Close() { }

	private void OnMountUnavailable() { }

	public void Show(Player player) { }

	private void StopAnimation() { }

	private void Subscribe() { }

}

