namespace EFT.UI;

[RequireComponent(typeof(BattleUIComponentAnimation))]
public sealed class AzimuthPanel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _azimuthField; //Field offset: 0x70
	private BattleUIComponentAnimation _animation; //Field offset: 0x78
	private Func _azimuthFunc; //Field offset: 0x80
	private int _lastValue; //Field offset: 0x88

	public AzimuthPanel() { }

	public virtual void Close() { }

	public void Hide() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	public void Show(Func azimuthFunc) { }

}

