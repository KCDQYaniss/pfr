namespace EFT.UI;

public class QueueScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__2_0() { }

	}

	[SerializeField]
	private TextMeshProUGUI _queuePlace; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0x78

	public QueueScreen() { }

	private void Awake() { }

	public void SetQueue(int place, bool showExitButton) { }

}

