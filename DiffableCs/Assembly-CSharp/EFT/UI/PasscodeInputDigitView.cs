namespace EFT.UI;

public sealed class PasscodeInputDigitView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public PasscodeInputDigitView <>4__this; //Field offset: 0x10
		public Action onCompleted; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <PlayDeleteFadeOut>b__0() { }

	}

	[SerializeField]
	private TMP_Text _symbolText; //Field offset: 0x20
	[SerializeField]
	private Image _stateStripeImage; //Field offset: 0x28
	[SerializeField]
	private char _emptySymbol; //Field offset: 0x30
	[SerializeField]
	private float _symbolFadeInDuration; //Field offset: 0x34
	[SerializeField]
	private float _symbolFadeOutDuration; //Field offset: 0x38
	[Header("Symbol Colors")]
	[SerializeField]
	private Color _emptySymbolColor; //Field offset: 0x3C
	[SerializeField]
	private Color _filledSymbolColor; //Field offset: 0x4C
	[SerializeField]
	private Color _deletingSymbolColor; //Field offset: 0x5C
	[SerializeField]
	private Color _errorSymbolColor; //Field offset: 0x6C
	[SerializeField]
	private Color _successSymbolColor; //Field offset: 0x7C
	private Sequence _symbolTween; //Field offset: 0x90

	public PasscodeInputDigitView() { }

	[CompilerGenerated]
	private void <SetFilledWithFadeIn>b__15_0() { }

	private void ApplyStripeSprite(EPasscodeSymbolState state) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void PlayDeleteFadeOut(Action onCompleted) { }

	private Color ResolveStateColor(EPasscodeSymbolState state) { }

	public void SetEmpty() { }

	public void SetFilledWithFadeIn(char symbol, EPasscodeSymbolState state = 1) { }

	public void SetState(EPasscodeSymbolState state) { }

	public void SetSymbol(char symbol) { }

	private void SetSymbolColor(EPasscodeSymbolState state) { }

	private void StopSymbolTween() { }

}

