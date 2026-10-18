namespace EFT.Vaulting;

public class ClimbMoveModel : BaseVaultingMoveModel
{
	private readonly IClimbSettings _settings; //Field offset: 0x20

	protected virtual float maxHoleHeight
	{
		 get { } //Length: 9
	}

	public IClimbSettings Settings
	{
		 get { } //Length: 5
	}

	public ClimbMoveModel(IVaultingModel model, Transform gridRoot, IClimbSettings settings) { }

	public virtual bool CanMove() { }

	public virtual bool CanMoveAutomaticly() { }

	private bool CheckAutoClimbCondition(float height, float length, float distance) { }

	private bool CheckClimbCondition(float height, float length, float distance) { }

	protected virtual float get_maxHoleHeight() { }

	public IClimbSettings get_Settings() { }

}

