namespace UI.Credits;

public sealed class CreditsEntryView : UIElement
{
	[SerializeField]
	private TMP_Text _headerText; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _bodyText; //Field offset: 0x78

	public CreditsEntryView() { }

	public void SetText(CreditsEntry entry) { }

}

