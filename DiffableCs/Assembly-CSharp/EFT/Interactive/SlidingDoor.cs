namespace EFT.Interactive;

public class SlidingDoor : Door
{
	public AnimationCurve CustomProgressCurve; //Field offset: 0x238
	public Vector3 ShutPosition; //Field offset: 0x240
	public Vector3 OpenPosition; //Field offset: 0x24C

	public virtual float CurrentAngle
	{
		 get { } //Length: 6
		 set { } //Length: 340
	}

	public virtual AnimationCurve ProgressCurve
	{
		 get { } //Length: 8
	}

	public SlidingDoor() { }

	public virtual float get_CurrentAngle() { }

	public virtual AnimationCurve get_ProgressCurve() { }

	private void ProcessAngleAsShift(float value) { }

	protected virtual void set_CurrentAngle(float value) { }

}

