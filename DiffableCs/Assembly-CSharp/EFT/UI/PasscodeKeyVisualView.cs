namespace EFT.UI;

public sealed class PasscodeKeyVisualView : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _highlightCanvasGroup; //Field offset: 0x20
	[SerializeField]
	private GameObject _disableLayer; //Field offset: 0x28
	[SerializeField]
	private float _flashInDuration; //Field offset: 0x30
	[SerializeField]
	private float _flashOutDuration; //Field offset: 0x34
	private Sequence _flashSequence; //Field offset: 0x38

	public PasscodeKeyVisualView() { }

	[CompilerGenerated]
	private void <PlayPressFlash>b__8_0() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void PlayPressFlash() { }

	public void SetDisabled(bool disabled) { }

	private void StopFlash() { }

}

