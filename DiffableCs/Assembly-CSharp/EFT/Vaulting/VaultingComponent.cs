namespace EFT.Vaulting;

public class VaultingComponent : IVaultingComponent, IVaultingComponentDebug, IVaultingParameters
{
	private readonly IVaultingContext _vaultingContext; //Field offset: 0x10
	private readonly IVaultingSettings _vaultingSettings; //Field offset: 0x18
	private VaultingView _view; //Field offset: 0x20
	private VaultingModel _model; //Field offset: 0x28
	private VaultingController _controller; //Field offset: 0x30
	private readonly Func _isAutoVaultingSettingEnable; //Field offset: 0x38
	private readonly Func _canVaultByStaminaGetter; //Field offset: 0x40
	private readonly Func _canClimbByStaminaGetter; //Field offset: 0x48

	public override float AbsoluteForwardVelocity
	{
		 get { } //Length: 84
	}

	public override float BehindObstacleRatio
	{
		 get { } //Length: 87
	}

	public override Vector3 MaxWeightPointPosition
	{
		 get { } //Length: 124
	}

	public override VaultingController VaultingController
	{
		 get { } //Length: 76
	}

	public override float VaultingHeight
	{
		 get { } //Length: 87
	}

	public override float VaultingLength
	{
		 get { } //Length: 87
	}

	public override IVaultingModelDebug VaultingModelDebug
	{
		 get { } //Length: 5
	}

	public VaultingComponent(IVaultingContext movementContext, IVaultingSettings settings) { }

	public VaultingComponent(IVaultingContext movementContext, IVaultingSettings settings, Func isAutoVaultingSettingEnable, Func canVaultByStaminaGetter, Func canClimbByStaminaGetter) { }

	public override bool CanDamageLeftHand(EVaultingStrategy strategy) { }

	public override bool CanDamageLegs(EVaultingStrategy strategy) { }

	public override bool CanDamageRightHand(EVaultingStrategy strategy) { }

	private bool CanVaulting() { }

	private bool DoVaultingByStrategy(EVaultingStrategy strategy) { }

	public override void DoVaultingTick() { }

	public override float get_AbsoluteForwardVelocity() { }

	public override float get_BehindObstacleRatio() { }

	public override Vector3 get_MaxWeightPointPosition() { }

	public override VaultingController get_VaultingController() { }

	public override float get_VaultingHeight() { }

	public override float get_VaultingLength() { }

	public override IVaultingModelDebug get_VaultingModelDebug() { }

	public override EVaultingStrategy GetAutoVaultingStrategy() { }

	public override EVaultingStrategy GetVaultingStrategy() { }

	private void InitializeController() { }

	private void InitializeModel() { }

	public bool IsVaulting() { }

	public override void SetCurrentMove(Nullable motion) { }

	private void SetGlobalParameters() { }

	private void SetParametersInAnimator() { }

	private void Tick() { }

	private void TryDoAutomaticVaulting() { }

	public override bool TryVaulting() { }

}

