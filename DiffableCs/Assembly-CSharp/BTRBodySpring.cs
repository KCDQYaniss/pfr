//Type is in global namespace

public class BTRBodySpring
{
	public float ReturnSpeed; //Field offset: 0x10
	public float Damping; //Field offset: 0x14
	public float Intensity; //Field offset: 0x18
	public bool UseOffset; //Field offset: 0x1C
	[HideInInspector]
	public Vector3 Offset; //Field offset: 0x20
	[HideInInspector]
	public Vector3 Velocity; //Field offset: 0x2C
	[HideInInspector]
	public Vector3 Current; //Field offset: 0x38
	[HideInInspector]
	public Vector3 ForceAccumulatorLimitless; //Field offset: 0x44
	[HideInInspector]
	public bool NeedUpdate; //Field offset: 0x50
	[HideInInspector]
	public bool StableOn; //Field offset: 0x51

	public BTRBodySpring() { }

	public override void AddAccelerationLimitless(int comp, float val) { }

	public override Vector3 GetValue(bool useOffset) { }

	public override void Update(float deltaTime) { }

}

