namespace EFT;

public class LeftStanceController
{
	internal enum ELeftStanceBodyActionType
	{
		None = 0,
		DisableAnimLeftStance = 1,
		SetToCacheValue = 2,
	}

	[CompilerGenerated]
	private bool <LeftStance>k__BackingField; //Field offset: 0x10
	private Action _setLeftStanceInPlayerAnimator; //Field offset: 0x18
	private Action _setLeftStanceInOneFrameInPlayerAnimator; //Field offset: 0x20
	private Func _canSetAnimatorLeftStanceToCacheValue; //Field offset: 0x28
	private ELeftStanceBodyActionType _lastBodyActionTypeRequest; //Field offset: 0x30
	private bool _allowBodyChangeAnim; //Field offset: 0x34
	private bool _allowBodyChangeAnimOnUnblockFromBodyAction; //Field offset: 0x35
	private bool _blockingLeftStanceOperationInProcess; //Field offset: 0x36
	private bool _blockChangeToLeftStanceFromBodyAction; //Field offset: 0x37
	[CompilerGenerated]
	private bool <LastAnimValue>k__BackingField; //Field offset: 0x38

	public override bool LastAnimValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool LeftStance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public LeftStanceController(Action setLeftStanceInPlayerAnimator, Action setLeftStanceInOneFrameInPlayerAnimator, Func canSetAnimatorLeftStanceToCacheValue) { }

	public void BlockChangeAnimationFromBodyAction() { }

	public void Clear() { }

	public void DisableLeftStanceAnimFromBodyAction() { }

	public void DisableLeftStanceAnimFromHandsAction() { }

	public void DisableLeftStanceAnimFromOpenInventory() { }

	[CompilerGenerated]
	public override bool get_LastAnimValue() { }

	[CompilerGenerated]
	public override bool get_LeftStance() { }

	[CompilerGenerated]
	protected override void set_LastAnimValue(bool value) { }

	[CompilerGenerated]
	protected override void set_LeftStance(bool value) { }

	public void SetAnimatorLeftStanceToCacheFromBodyAction(bool forceInOneFrame = false) { }

	public void SetAnimatorLeftStanceToCacheFromCloseInventory() { }

	public void SetAnimatorLeftStanceToCacheFromHandsAction() { }

	public void SetLeftStanceForce(bool value) { }

	public void ToggleLeftStance() { }

	public void UnblockChangeAnimationFromBodyAction() { }

}

