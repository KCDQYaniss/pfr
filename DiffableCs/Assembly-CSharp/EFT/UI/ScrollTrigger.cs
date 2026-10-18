namespace EFT.UI;

public sealed class ScrollTrigger : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private Action OnOnScroll; //Field offset: 0x20

	public event Action OnOnScroll
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ScrollTrigger() { }

	[CompilerGenerated]
	public void add_OnOnScroll(Action value) { }

	public override void OnScroll(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnOnScroll(Action value) { }

}

