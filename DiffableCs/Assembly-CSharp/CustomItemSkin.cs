//Type is in global namespace

public class CustomItemSkin : CustomSkin
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Slot currentSlot; //Field offset: 0x10
		public CustomItemSkin <>4__this; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Init>b__0() { }

	}

	[SerializeField]
	private EClippingCustoms _itemType; //Field offset: 0x40
	private PlayerBody _playerBody; //Field offset: 0x48
	private CompositeDisposable _unsubscribe; //Field offset: 0x50

	public CustomItemSkin() { }

	public void Init(Skeleton skeleton, PlayerBody playerBody) { }

	private bool NeedCustom(EClippingCustoms customs) { }

	private void OnDestroy() { }

	private void ProceedItemChanged(Item item) { }

	private void SetIsCustom(bool isCustom) { }

	public virtual void Unskin() { }

}

