namespace EFT.Visual;

public class NightVisionMount : MonoBehaviour, IDress, IAddHandler, IItemRelatedView, IRemoveHandler
{
	[SerializeField]
	private CurveRotator _rotator; //Field offset: 0x20
	private Item _mount; //Field offset: 0x28
	private Slot[] _mountSlots; //Field offset: 0x30
	private IItemOwner _itemOwner; //Field offset: 0x38
	private TogglableComponent _currentNightVision; //Field offset: 0x40
	private Action _visorsSubscription; //Field offset: 0x48

	public NightVisionMount() { }

	[CompilerGenerated]
	private void <SetNightVision>b__11_0() { }

	public override void Deinit() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs obj) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs obj) { }

	public override void Init(Item item, bool isAnimated) { }

	private void OnItemAddedOrRemoved(IContainer slot) { }

	private void OnVisorsChanged(bool initial) { }

	private void SetNightVision(TogglableComponent togglableComponent, bool initial) { }

	private void UpdateState(bool initial) { }

}

