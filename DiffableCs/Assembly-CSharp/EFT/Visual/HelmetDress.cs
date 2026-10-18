namespace EFT.Visual;

public class HelmetDress : MonoBehaviour, IDress, IAddHandler, IItemRelatedView, IRemoveHandler
{
	public Quaternion OffRotation; //Field offset: 0x20
	public Quaternion OnRotation; //Field offset: 0x30
	public Transform HingeTransform; //Field offset: 0x40
	public HysteresisFilter Filter; //Field offset: 0x48
	private Item _helmet; //Field offset: 0x50
	private Slot[] _helmetSlots; //Field offset: 0x58
	private IItemOwner _itemOwner; //Field offset: 0x60
	private FaceShieldComponent _currentFaceShield; //Field offset: 0x68
	private Action _unsubscribe; //Field offset: 0x70

	public HelmetDress() { }

	[CompilerGenerated]
	private void <Init>b__9_0(float x) { }

	[CompilerGenerated]
	private void <SetFaceShield>b__14_0() { }

	public override void Deinit() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs obj) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs obj) { }

	public override void Init(Item item, bool isAnimated) { }

	private void OnFaceShieldChanged(bool initial) { }

	private void OnItemAddedOrRemoved(IContainer slot) { }

	private void SetFaceShield(FaceShieldComponent faceShield, bool initial) { }

	private void UpdateState(bool initial) { }

}

