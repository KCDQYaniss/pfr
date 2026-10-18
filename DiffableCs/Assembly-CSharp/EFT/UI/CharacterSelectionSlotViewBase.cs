namespace EFT.UI;

public class CharacterSelectionSlotViewBase : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__63_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SetupShopUnavailableTooltip>b__63_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public CharacterSelectionSlotViewBase <>4__this; //Field offset: 0x10
		public bool state; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <CrossFadeGlow>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static UnityAction <0>__CloseTooltip; //Field offset: 0x0
		public static Action <1>__CloseTooltip; //Field offset: 0x8

	}

	[Header("Texts & Info")]
	[SerializeField]
	private TextMeshProUGUI _modeTitle; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _modeInfo; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _modeDescription; //Field offset: 0x80
	[SerializeField]
	private ChatSpecialIcon _profileInfo; //Field offset: 0x88
	[Header("Visuals & Animations")]
	[SerializeField]
	private Color _TextIdleColor; //Field offset: 0x90
	[SerializeField]
	private Color _TextHoverColor; //Field offset: 0xA0
	[SerializeField]
	private CanvasGroup _glowIdle; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _glowHover; //Field offset: 0xB8
	[SerializeField]
	private FrameSequenceAnimator _glowIdleAnimator; //Field offset: 0xC0
	[SerializeField]
	private FrameSequenceAnimator _glowHoverAnimator; //Field offset: 0xC8
	[SerializeField]
	private Image _sideImage; //Field offset: 0xD0
	[SerializeField]
	private Sprite _bearBg; //Field offset: 0xD8
	[SerializeField]
	private Sprite _usecBg; //Field offset: 0xE0
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0xE8
	[SerializeField]
	private GameObject _playerPreviewRoot; //Field offset: 0xF0
	[Header("Action & State")]
	[SerializeField]
	private DefaultUIButton _actionButton; //Field offset: 0xF8
	[SerializeField]
	private DefaultUIButton _purchaseButton; //Field offset: 0x100
	[SerializeField]
	private GameObject _emptyStateRoot; //Field offset: 0x108
	[SerializeField]
	private CanvasGroup _emptyStateIdle; //Field offset: 0x110
	[SerializeField]
	private CanvasGroup _emptyStateHover; //Field offset: 0x118
	[SerializeField]
	private float _emptyStateCrossFadeDuration; //Field offset: 0x120
	[Header("Animation Layer")]
	[SerializeField]
	private string _animationLayerName; //Field offset: 0x128
	[SerializeField]
	private string _hoverAnimationCheckBoxName; //Field offset: 0x130
	private CharacterSelectionSlotViewModel _viewModel; //Field offset: 0x138
	private EGameMode _gameMode; //Field offset: 0x178
	private bool _previewLoaded; //Field offset: 0x17C
	private bool _isHovered; //Field offset: 0x17D
	private Tween _glowCrossFadeTween; //Field offset: 0x180
	private Tween _emptyStateCrossFadeTween; //Field offset: 0x188
	private CharacterSelectionProfileData _profileData; //Field offset: 0x190
	[CompilerGenerated]
	private Action Selected; //Field offset: 0x198
	[CompilerGenerated]
	private Action PurchaseRequested; //Field offset: 0x1A0

	public event Action PurchaseRequested
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action Selected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected EGameMode GameMode
	{
		 get { } //Length: 7
	}

	protected bool IsHovered
	{
		 get { } //Length: 8
	}

	protected TextMeshProUGUI ModeInfo
	{
		 get { } //Length: 5
	}

	protected CharacterSelectionProfileData ProfileData
	{
		 get { } //Length: 8
	}

	public CharacterSelectionSlotViewBase() { }

	[CompilerGenerated]
	private void <CrossFadeEmptyState>b__45_0() { }

	[CompilerGenerated]
	public void add_PurchaseRequested(Action value) { }

	[CompilerGenerated]
	public void add_Selected(Action value) { }

	private void ApplyEmptyStateAlpha(float idleAlpha, float hoverAlpha) { }

	private void ApplyGlowAlpha(float idleAlpha, float hoverAlpha) { }

	private void ApplyPreviewAnimationState() { }

	public virtual void Close() { }

	private void CrossFadeEmptyState(bool state, bool forced = false) { }

	private void CrossFadeGlow(bool state, bool forced = false) { }

	private void DescriptionTextColorChange(bool hover) { }

	protected EGameMode get_GameMode() { }

	protected bool get_IsHovered() { }

	protected TextMeshProUGUI get_ModeInfo() { }

	protected CharacterSelectionProfileData get_ProfileData() { }

	private Sprite GetSideSprite(EPlayerSide side) { }

	private void OnActionButtonPressed() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void OnPreviewLoadingCompleted() { }

	private void OnPurchaseButtonPressed() { }

	private void PlayGlowAnimator(bool hover) { }

	protected override void RefreshHoverState(bool hovered, bool forced = false) { }

	protected override void RefreshModeSpecificState(EGameMode gameMode, CharacterSelectionProfileData profileData) { }

	[CompilerGenerated]
	public void remove_PurchaseRequested(Action value) { }

	[CompilerGenerated]
	public void remove_Selected(Action value) { }

	private void ResetHoverState() { }

	protected override void ResetModeSpecificState() { }

	public void SetInteractable(bool interactable) { }

	private void SetProfileInfoVisible(bool visible) { }

	private void SetupShopUnavailableTooltip() { }

	public void Show(EGameMode gameMode, CharacterSelectionProfileData profileData, CharacterSelectionSlotViewModel viewModel) { }

	private void StopGlowAnimator(bool hover) { }

}

