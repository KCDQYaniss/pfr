namespace EFT.UI;

public sealed class TapeCollectedNotificationView : BaseNotificationView, INotificationView
{
	private const string TITLE_LOCALE_KEY = "tapes/tapeFoundNotify{0}"; //Field offset: 0x0
	private const string TITLE_SHORT_LOCALE_KEY = "tapes/tapeFoundNotify"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _title; //Field offset: 0xE8

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public TapeCollectedNotificationView() { }

	public virtual bool get_ReturnToPool() { }

	public override void Init(NotificationTapeCollected notification) { }

}

