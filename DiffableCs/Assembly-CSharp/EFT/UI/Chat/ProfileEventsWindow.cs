namespace EFT.UI.Chat;

public sealed class ProfileEventsWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <AcceptAll>b__8_0(ProfileChangeEvent profileEvent) { }

	}

	[SerializeField]
	private Transform _eventsList; //Field offset: 0xB8
	[SerializeField]
	private ProfileEventView _eventViewTemplate; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _applyAllButton; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0xD0
	private IEnumerable _profileEvents; //Field offset: 0xD8

	public ProfileEventsWindow() { }

	[CompilerGenerated]
	private void <Show>b__6_0(ProfileChangeEvent item, ProfileEventView view) { }

	[CompilerGenerated]
	private void <Show>b__6_1(ProfileChangeEvent profileEvent) { }

	private void Accept(IEnumerable events) { }

	private void AcceptAll() { }

	protected virtual void Awake() { }

	public ProfileEventsWindowContext Show(IEnumerable profileEvents) { }

}

