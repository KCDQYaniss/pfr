namespace EFT.UI.Matchmaker;

[RequireComponent(typeof(AlphaPulsar))]
public class MatchingProgressBarSegmentView : UIElement
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private GameObject _marker; //Field offset: 0x78
	[SerializeField]
	private AlphaPulsar _alphaPulsar; //Field offset: 0x80
	private bool _isActiveState; //Field offset: 0x88

	public MatchingProgressBarSegmentView() { }

	public void Init() { }

	public void SetActiveState() { }

	public void SetCompletedState() { }

	public void SetDisabledState() { }

	public void SetMarkerEnabled(bool enable) { }

}

