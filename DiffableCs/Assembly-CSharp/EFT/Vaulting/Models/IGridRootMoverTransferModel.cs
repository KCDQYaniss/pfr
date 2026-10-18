namespace EFT.Vaulting.Models;

public interface IGridRootMoverTransferModel
{

	public float CurrentVelocity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 ForwardProjection
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float GridOffsetX
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float GridOffsetY
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float GridOffsetZ
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float OffsetFactor
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 PlayerRealForward
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float get_CurrentVelocity() { }

	public Vector3 get_ForwardProjection() { }

	public float get_GridOffsetX() { }

	public float get_GridOffsetY() { }

	public float get_GridOffsetZ() { }

	public float get_OffsetFactor() { }

	public Vector3 get_PlayerRealForward() { }

	public void set_CurrentVelocity(float value) { }

	public void set_ForwardProjection(Vector3 value) { }

	public void set_GridOffsetX(float value) { }

	public void set_GridOffsetY(float value) { }

	public void set_GridOffsetZ(float value) { }

	public void set_OffsetFactor(float value) { }

	public void set_PlayerRealForward(Vector3 value) { }

}

