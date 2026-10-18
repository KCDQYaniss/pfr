namespace EFT.UI;

public class TacticalClothingSideToggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	internal class SideIconNode
	{
		[SerializeField]
		private Sprite _activeIcon; //Field offset: 0x10
		[SerializeField]
		private Sprite _inactiveIcon; //Field offset: 0x18
		[SerializeField]
		private Sprite _disabledIcon; //Field offset: 0x20

		public SideIconNode() { }

		public Sprite GetIcon(bool isInteractive, bool isSelected) { }

	}

	[SerializeField]
	private EPlayerSide _playerSide; //Field offset: 0x20
	[SerializeField]
	private Image _sideIcon; //Field offset: 0x28
	[SerializeField]
	private Image _background; //Field offset: 0x30
	[SerializeField]
	private Image _checkmark; //Field offset: 0x38
	[SerializeField]
	private HoverTooltipArea _hover; //Field offset: 0x40
	[SerializeField]
	private SideIconNode _sideSpriteNode; //Field offset: 0x48
	[SerializeField]
	private SideIconNode _backgroundSpriteNode; //Field offset: 0x50
	[SerializeField]
	private Sprite _commonCheckmarkSprite; //Field offset: 0x58
	[SerializeField]
	private Sprite _tueCheckmarkSprite; //Field offset: 0x60
	private Action _clickAction; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsInteractive>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsOn>k__BackingField; //Field offset: 0x71

	public private bool IsInteractive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsOn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EPlayerSide PlayerSide
	{
		 get { } //Length: 4
	}

	public TacticalClothingSideToggle() { }

	[CompilerGenerated]
	public bool get_IsInteractive() { }

	[CompilerGenerated]
	public bool get_IsOn() { }

	public EPlayerSide get_PlayerSide() { }

	public void Init(bool isInteractable, EMemberCategory category, Action clickAction) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_IsInteractive(bool value) { }

	[CompilerGenerated]
	private void set_IsOn(bool value) { }

	public void SetValue(bool value) { }

}

