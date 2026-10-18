namespace EFT.UI.Screens;

public abstract class UIScreen : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public UIScreen <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <SoftShow>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public UIScreen <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <SoftHide>b__0() { }

	}

	private sealed class UIScreenLogger : AbstractLogger
	{
		private static UIScreenLogger _instance; //Field offset: 0x0

		public static UIScreenLogger Instance
		{
			 get { } //Length: 311
		}

		private UIScreenLogger() { }

		public static UIScreenLogger get_Instance() { }

	}

	private Coroutine _showCoroutine; //Field offset: 0x80
	private Coroutine _hideCoroutine; //Field offset: 0x88

	protected CanvasGroup CanvasGroup
	{
		 get { } //Length: 167
	}

	private UIScreenLogger Logger
	{
		private get { } //Length: 311
	}

	protected UIScreen() { }

	[CompilerGenerated]
	private void <ShowGameObject>b__10_0() { }

	public virtual void Close() { }

	protected CanvasGroup get_CanvasGroup() { }

	private UIScreenLogger get_Logger() { }

	public virtual void HideGameObject() { }

	protected override void OnDestroy() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void ShowGameObject(bool instant = false) { }

	protected void SoftHide(CanvasGroup group, Action callback) { }

	private void SoftShow(CanvasGroup group, Action callback) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

}

