namespace EFT.Vaulting.Models;

public class VaultingMovesModel : IVaulingMovesModel
{
	private readonly IVaultingModel _model; //Field offset: 0x10
	private readonly Transform _gridRoot; //Field offset: 0x18
	private readonly IMovesSettings _movesSettings; //Field offset: 0x20
	private readonly VaultMoveModel _climbOverState; //Field offset: 0x28
	private readonly ClimbMoveModel _climbUpState; //Field offset: 0x30
	private readonly float _minVaultingHeight; //Field offset: 0x38
	private readonly float _maxVaultingHeight; //Field offset: 0x3C
	private readonly float _minVaultingLength; //Field offset: 0x40
	private readonly float _maxVaultingLength; //Field offset: 0x44

	public override IVaultingMove ClimbState
	{
		 get { } //Length: 76
	}

	public override float MaxVaultingHeight
	{
		 get { } //Length: 6
	}

	public override float MaxVaultingLength
	{
		 get { } //Length: 6
	}

	public override float MinVaultingHeight
	{
		 get { } //Length: 6
	}

	public override float MinVaultingLength
	{
		 get { } //Length: 6
	}

	public override IVaultingMove VaultState
	{
		 get { } //Length: 5
	}

	public VaultingMovesModel(IVaultingModel model, Transform gridRoot, IVaultingSettings settings) { }

	public override IVaultingMove get_ClimbState() { }

	public override float get_MaxVaultingHeight() { }

	public override float get_MaxVaultingLength() { }

	public override float get_MinVaultingHeight() { }

	public override float get_MinVaultingLength() { }

	public override IVaultingMove get_VaultState() { }

}

