namespace EFT.ItemInHandSubsystem;

public class LeftHandController : ILeftHandController
{
	[CompilerGenerated]
	private Action OnTakeOrRemoveItem; //Field offset: 0x10
	private readonly PlayerAnimator _playerAnimator; //Field offset: 0x18
	private readonly ILeftHandInteractionEvents _events; //Field offset: 0x20
	private readonly Transform _handBone; //Field offset: 0x28
	private Item _item; //Field offset: 0x30
	private Transform _leftHandItem; //Field offset: 0x38
	private bool _isUsingHand; //Field offset: 0x40
	private bool _inAction; //Field offset: 0x41
	private bool _isRemovingItem; //Field offset: 0x42

	public override event Action OnTakeOrRemoveItem
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool InAction
	{
		 get { } //Length: 5
	}

	public override bool IsUsing
	{
		 get { } //Length: 13
	}

	public LeftHandController(PlayerAnimator animator, ILeftHandInteractionEvents events, Transform handBone) { }

	[CompilerGenerated]
	public override void add_OnTakeOrRemoveItem(Action value) { }

	private void CreateItem(Item item) { }

	private void DestroyItem() { }

	public override void Dispose() { }

	private void EndAction(IAnimatorEventParameter param) { }

	public override bool get_InAction() { }

	public override bool get_IsUsing() { }

	private void OnRemoveItem(IAnimatorEventParameter param) { }

	private void OnTakeItem(IAnimatorEventParameter param) { }

	[CompilerGenerated]
	public override void remove_OnTakeOrRemoveItem(Action value) { }

	public override void RemoveItem(float speed = 1) { }

	private void SetItemInHand() { }

	private void SetLeftHandInAnimator(bool value) { }

	private void SetRemoveSpeedInAnimator(float speed) { }

	private void StartAction(IAnimatorEventParameter param) { }

	private void Subscribe() { }

	public override void ToggleHand(Item item) { }

	private void Unsubscribe() { }

}

