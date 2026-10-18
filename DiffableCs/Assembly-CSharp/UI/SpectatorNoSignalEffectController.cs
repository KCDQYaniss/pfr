namespace UI;

public class SpectatorNoSignalEffectController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public SpectatorNoSignalEffectController <>4__this; //Field offset: 0x10
		public Action onNoSignalActiveAction; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Image line; //Field offset: 0x10
		public SpectatorNoSignalEffectController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private GameObject _noSignal; //Field offset: 0x20
	[SerializeField]
	private Image[] _lines; //Field offset: 0x28
	[SerializeField]
	private Camera _camera; //Field offset: 0x30
	[SerializeField]
	private Color _activeLineColor; //Field offset: 0x38
	[SerializeField]
	private Color _inactiveLineColor; //Field offset: 0x48
	[SerializeField]
	private float _noSignalDelay; //Field offset: 0x58
	private DigitalGlitch _effect; //Field offset: 0x60
	private Sequence _tween; //Field offset: 0x68

	public SpectatorNoSignalEffectController() { }

	public void Init() { }

	public void SetActiveLinesCount(int count) { }

	public void Show(float lineDelay, Action onNoSignalActiveAction = null) { }

	public void Show(Action onNoSignalActiveAction = null) { }

	public void Stop() { }

}

