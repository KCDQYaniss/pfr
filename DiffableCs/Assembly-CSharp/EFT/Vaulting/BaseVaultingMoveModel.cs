namespace EFT.Vaulting;

public abstract class BaseVaultingMoveModel : IVaultingMove
{
	protected const float PLAYER_HEIGHT = 1.8; //Field offset: 0x0
	protected readonly Transform gridRoot; //Field offset: 0x10
	protected readonly IVaultingModel model; //Field offset: 0x18

	protected override float maxHoleHeight
	{
		 get { } //Length: 9
	}

	public BaseVaultingMoveModel(IVaultingModel model, Transform gridRoot) { }

	public abstract bool CanMove() { }

	public abstract bool CanMoveAutomaticly() { }

	protected bool CheckBeforeObstacleWall() { }

	protected bool CheckRoofCondition() { }

	protected override float get_maxHoleHeight() { }

}

