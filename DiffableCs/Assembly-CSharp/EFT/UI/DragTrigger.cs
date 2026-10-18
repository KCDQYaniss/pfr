namespace EFT.UI;

public class DragTrigger : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	private const int NO_POINTER = -2147483648; //Field offset: 0x0
	[CompilerGenerated]
	private Action onDrag; //Field offset: 0x20
	[CompilerGenerated]
	private Action onBeginDrag; //Field offset: 0x28
	[CompilerGenerated]
	private Action onEndDrag; //Field offset: 0x30
	private int _dragPointerId; //Field offset: 0x38

	public event Action onBeginDrag
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action onDrag
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action onEndDrag
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public DragTrigger() { }

	[CompilerGenerated]
	public void add_onBeginDrag(Action value) { }

	[CompilerGenerated]
	public void add_onDrag(Action value) { }

	[CompilerGenerated]
	public void add_onEndDrag(Action value) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	private void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_onBeginDrag(Action value) { }

	[CompilerGenerated]
	public void remove_onDrag(Action value) { }

	[CompilerGenerated]
	public void remove_onEndDrag(Action value) { }

}

