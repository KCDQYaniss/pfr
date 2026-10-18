namespace EFT.UI.Gestures;

public sealed class GestureItemBindAlignment : GesturesBindAlignment
{
	[SerializeField]
	private float _hotkeySpacing; //Field offset: 0x48

	public GestureItemBindAlignment() { }

	public virtual void AlignToBottom() { }

	public virtual void AlignToCenter() { }

	public virtual void AlignToLeft() { }

	public virtual void AlignToRight() { }

	public virtual void AlignToTop() { }

}

