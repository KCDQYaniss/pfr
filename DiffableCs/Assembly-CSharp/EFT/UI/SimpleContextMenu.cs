namespace EFT.UI;

public class SimpleContextMenu : UIElement, IPointerExitHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0`1
	{
		public SimpleContextMenu <>4__this; //Field offset: 0x0
		public ContextInteractions contextInteractions; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal void <ShowMenu>b__0() { }

		internal void <ShowMenu>b__1() { }

	}

	[SerializeField]
	private InteractionButtonsContainer _interactionButtonsContainer; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnMouseExit; //Field offset: 0x78
	public readonly BindableEvent OnMenuClosed; //Field offset: 0x80

	public event Action OnMouseExit
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public SimpleContextMenu SubMenuTemplate
	{
		 set { } //Length: 107
	}

	public SimpleContextMenu() { }

	[CompilerGenerated]
	public void add_OnMouseExit(Action value) { }

	public virtual void Close() { }

	protected virtual void CorrectPosition(MarginsRect margins = null) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnMouseExit(Action value) { }

	public void set_SubMenuTemplate(SimpleContextMenu value) { }

	public override void Show(Vector2 position, ContextInteractions contextInteractions, IReadOnlyDictionary names = null, Item item = null) { }

	public override void Show(Vector2 position, ContextInteractions contextInteractions, IReadOnlyDictionary names, IReadOnlyDictionary icons) { }

	private void ShowMenu(Vector2 position, ContextInteractions contextInteractions, IReadOnlyDictionary names, IReadOnlyDictionary icons, Item item) { }

	private void Update() { }

}

