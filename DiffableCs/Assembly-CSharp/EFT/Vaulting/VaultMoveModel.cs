namespace EFT.Vaulting;

public class VaultMoveModel : BaseVaultingMoveModel
{
	private readonly IVaultSettings _settings; //Field offset: 0x20

	protected virtual float maxHoleHeight
	{
		 get { } //Length: 9
	}

	public IVaultSettings Settings
	{
		 get { } //Length: 5
	}

	public VaultMoveModel(IVaultingModel model, Transform gridRoot, IVaultSettings settings) { }

	public virtual bool CanMove() { }

	public virtual bool CanMoveAutomaticly() { }

	private bool CheckAutoVaultCondition(float height, float length, float distance) { }

	private bool CheckBehindObstacleHeightCondition() { }

	private bool CheckBehindObstacleWall() { }

	private bool CheckVaultCondition(float height, float length, float distance) { }

	protected virtual float get_maxHoleHeight() { }

	public IVaultSettings get_Settings() { }

}

