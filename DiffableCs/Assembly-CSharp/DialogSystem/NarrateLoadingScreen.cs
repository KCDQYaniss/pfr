namespace DialogSystem;

public class NarrateLoadingScreen : UIScreen
{
	[SerializeField]
	private TMP_Text _dialogueOwnerName; //Field offset: 0x90

	public NarrateLoadingScreen() { }

	public virtual void Close() { }

	public void Show(string dialogueOwnerName) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

