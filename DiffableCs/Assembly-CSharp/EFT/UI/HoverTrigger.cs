namespace EFT.UI;

public sealed class HoverTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private Action OnHoverStart; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnHoverEnd; //Field offset: 0x28

	public event Action OnHoverEnd
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnHoverStart
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public HoverTrigger() { }

	[CompilerGenerated]
	public void add_OnHoverEnd(Action value) { }

	[CompilerGenerated]
	public void add_OnHoverStart(Action value) { }

	public void Init(Action onHoverStart, Action onHoverEnd) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnHoverEnd(Action value) { }

	[CompilerGenerated]
	public void remove_OnHoverStart(Action value) { }

}

