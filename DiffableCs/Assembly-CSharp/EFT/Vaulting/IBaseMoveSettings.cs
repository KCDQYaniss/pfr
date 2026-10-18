namespace EFT.Vaulting;

public interface IBaseMoveSettings
{

	public IAutoMoveRestrictions AutoMoveRestrictions
	{
		 get { } //Length: 0
	}

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public float MaxWithoutHandHeight
	{
		 get { } //Length: 0
	}

	public IMoveRestrictions MoveRestrictions
	{
		 get { } //Length: 0
	}

	public IAutoMoveRestrictions get_AutoMoveRestrictions() { }

	public bool get_IsActive() { }

	public float get_MaxWithoutHandHeight() { }

	public IMoveRestrictions get_MoveRestrictions() { }

}

