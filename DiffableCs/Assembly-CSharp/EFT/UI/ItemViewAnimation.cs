namespace EFT.UI;

public sealed class ItemViewAnimation : SerializedMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private struct <<StartBackgroundBlinking>g__BlinkingAnimation|22_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemViewAnimation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<StartBlinking>g__BlinkingAnimation|24_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemViewAnimation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float BLINKING_CYCLE_SECONDS = 1; //Field offset: 0x0
	[SerializeField]
	private Transform _itemView; //Field offset: 0x60
	[SerializeField]
	private Image _mainImage; //Field offset: 0x68
	[SerializeField]
	private Image _colorPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject _notExaminedPanel; //Field offset: 0x78
	[SerializeField]
	private ItemViewExamineComponent _examineComponentTemplate; //Field offset: 0x80
	[SerializeField]
	private ItemViewLoadAmmoComponent _loadAmmoComponentTemplate; //Field offset: 0x88
	private bool _searched; //Field offset: 0x90
	private bool _examined; //Field offset: 0x91
	private bool _dragged; //Field offset: 0x92
	private bool _blinking; //Field offset: 0x93
	private bool _backgroundBlinking; //Field offset: 0x94
	private ItemViewExamineComponent _examineComponent; //Field offset: 0x98
	private ItemViewLoadAmmoComponent _loadAmmoComponent; //Field offset: 0xA0
	private Color _defaultBackgroundColor; //Field offset: 0xA8

	public ItemViewAnimation() { }

	[AsyncStateMachine(typeof(<<StartBackgroundBlinking>g__BlinkingAnimation|22_0>d))]
	[CompilerGenerated]
	private Task <StartBackgroundBlinking>g__BlinkingAnimation|22_0() { }

	[AsyncStateMachine(typeof(<<StartBlinking>g__BlinkingAnimation|24_0>d))]
	[CompilerGenerated]
	private Task <StartBlinking>g__BlinkingAnimation|24_0() { }

	public void Init(Color backgroundColor) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void SetBlinkingState(bool blinking) { }

	public void SetDragState(bool beingDragged) { }

	private void SetExaminationStatus(bool examining) { }

	public void SetExaminedState(bool examined) { }

	private void SetLoadingStatus(bool loading) { }

	public void SetSearchedState(bool searched) { }

	private void StartBackgroundBlinking() { }

	private void StartBlinking() { }

	public void StartExamination(float duration) { }

	public void StartLoading(float oneAmmoDuration, int ammoTotal, int startCount = 0) { }

	public void StartSearch() { }

	public void Stop() { }

	private void StopBackgroundBlinking() { }

	private void StopBlinking() { }

	public void StopExamination() { }

	public void StopLoading() { }

	private void StopSearch() { }

	private void UpdateMainImageAlpha() { }

	private void UpdateNotExaminedPanel() { }

}

