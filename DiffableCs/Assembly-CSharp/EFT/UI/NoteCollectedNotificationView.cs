namespace EFT.UI;

public class NoteCollectedNotificationView : BaseNotificationView, INotificationView
{
	private const string TITLE_LOCALE_KEY = "tapes/noteFoundNotify{0]"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _title; //Field offset: 0xE8

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public NoteCollectedNotificationView() { }

	public virtual bool get_ReturnToPool() { }

	public override void Init(NotificationNoteCollected notification) { }

}

