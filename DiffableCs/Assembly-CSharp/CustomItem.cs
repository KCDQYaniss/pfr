//Type is in global namespace

public class CustomItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Slot currentSlot; //Field offset: 0x10
		public CustomItem <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Init>b__0() { }

	}

	public static Dictionary InterestSlots; //Field offset: 0x0
	[SerializeField]
	private MeshFilter _meshFilter; //Field offset: 0x20
	[SerializeField]
	private CustomItemData _data; //Field offset: 0x28
	[SerializeField]
	private EClippingCustoms _itemType; //Field offset: 0x38
	private CompositeDisposable _unsubscribe; //Field offset: 0x40
	private PlayerBody _playerBody; //Field offset: 0x48

	private static CustomItem() { }

	public CustomItem() { }

	public void Init(PlayerBody playerBody) { }

	private bool NeedCustom(EClippingCustoms customs) { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void ProceedItemChanged(Item item) { }

	private void SetIsCustom(bool isCustom) { }

	private void Unsubscribe() { }

}

