namespace EFT.UI.Gestures;

public sealed class GestureAudioBindAlignment : GesturesBindAlignment
{
	[SerializeField]
	private CustomTextMeshProUGUI _situationLabel; //Field offset: 0x48

	public GestureAudioBindAlignment() { }

	public virtual void AlignToCenter() { }

	public virtual void AlignToLeft() { }

	public virtual void AlignToRight() { }

}

