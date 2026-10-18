namespace EFT.UI;

public sealed class ProfileLoadingScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <AutoHide>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action autoHideAction; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AutoHide>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class ProfileLoadingScreenController : EftScreenController
	{

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public ProfileLoadingScreenController() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public void SetLivingStatus(bool isLiving) { }

	}

	private const string PROFILE_LOADING_TEXT = "Profile data loading..."; //Field offset: 0x0
	private const string PROFILE_LEAVING_TEXT = "Leaving the game..."; //Field offset: 0x0
	[SerializeField]
	private RectTransform _loadingPanel; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _errorPanel; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _statusField; //Field offset: 0xB0

	public ProfileLoadingScreen() { }

	[IteratorStateMachine(typeof(<AutoHide>d__9))]
	private static IEnumerator AutoHide(Action autoHideAction) { }

	private void SetLivingStatus(bool isLiving) { }

	public virtual void Show(ProfileLoadingScreenController controller) { }

	private void Show(bool loading) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

