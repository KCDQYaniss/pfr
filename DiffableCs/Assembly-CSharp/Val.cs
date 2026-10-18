//Type is in global namespace

public class Val
{
	internal enum Source
	{
		MouseXVel = 0,
		MouseXAcc = 1,
		MouseYVel = 2,
		MouseYAcc = 3,
		MoveXVel = 4,
		MoveYVel = 5,
		MoveZVel = 6,
		MoveXAcc = 7,
		MoveYAcc = 8,
		MoveZAcc = 9,
	}

	public Source From; //Field offset: 0x10
	public Target To; //Field offset: 0x14
	public ComponentType Component; //Field offset: 0x18
	public float Intensity; //Field offset: 0x1C

	public Val() { }

}

