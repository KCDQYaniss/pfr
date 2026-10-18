namespace EFT.UI;

public sealed class NotifierView : UIElement, INotificationViewFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8
		public static Func <>9__27_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <CheckProfileChanges>b__27_0(ProfileChangeEventNotification n) { }

		internal ENotificationRequirements <CheckProfileChanges>b__27_1(ProfileChangeEventNotification n) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Notification notification; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <ShowNotification>b__0(BaseNotificationView x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public List notifications; //Field offset: 0x10
		public NotifierView <>4__this; //Field offset: 0x18
		public ENotificationRequirements requirement; //Field offset: 0x20

		public <>c__DisplayClass27_0() { }

		internal void <CheckProfileChanges>b__2() { }

	}

	internal interface IProfileChangeHandler
	{

		public void OnProfileChangeApplied(ENotificationRequirements requirements) { }

	}

	private const string APPLIED_PROFILE_CHANGES = "UI/Messaging/applied_profile_changes"; //Field offset: 0x0
	private const int POOL_SIZE = 4; //Field offset: 0x0
	[SerializeField]
	private BaseNotificationView _defaultNotificationTemplate; //Field offset: 0x70
	[SerializeField]
	private RectTransform _container; //Field offset: 0x78
	[SerializeField]
	private BaseNotificationView[] _notificationTemplates; //Field offset: 0x80
	private NotificationManager _notificationManager; //Field offset: 0x88
	private readonly Queue _pool; //Field offset: 0x90
	private readonly List _visibleNotifications; //Field offset: 0x98
	private readonly Queue _notificationsQueue; //Field offset: 0xA0
	private IProfileChangeHandler _profileChangeHandler; //Field offset: 0xA8
	private DialogWindowContext _profileChangeMessageContext; //Field offset: 0xB0
	private bool _isProcessingQueuedNotification; //Field offset: 0xB8

	public NotifierView() { }

	[UsedImplicitly]
	private void Awake() { }

	private void CheckProfileChanges() { }

	private void CleanUp() { }

	private override BaseNotificationView EFT.UI.INotificationViewFactory.CreateDefaultView(Notification notification) { }

	private override BaseNotificationView EFT.UI.INotificationViewFactory.CreateNotificationView(TNotification notification) { }

	public void Init() { }

	private void NotificationReceivedHandler(Notification notification) { }

	[UsedImplicitly]
	private void OnDisable() { }

	private void OnNotificationHide(Notification notification, BaseNotificationView view) { }

	private static void PlaySound(Notification notification) { }

	private void ProcessQueuedNotifications() { }

	private void RemoveNotificationView(Notification _, BaseNotificationView baseNotificationView) { }

	public void SetProfileChangeHandlerState(IProfileChangeHandler profileChangeHandler, bool active) { }

	private void SetupNotificationView(BaseNotificationView notificationView) { }

	private bool ShowNotification(Notification notification) { }

	private void Update() { }

}

