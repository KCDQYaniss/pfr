namespace EFT.NetworkPackets;

public struct ShotTrajectoryPart
{
	public Vector3 StartPosition; //Field offset: 0x0
	public Vector3 StartVelocity; //Field offset: 0xC
	public float BulletMassGram; //Field offset: 0x18
	public float BulletDiameterMilimeters; //Field offset: 0x1C
	public float BallisticCoefficient; //Field offset: 0x20
	public float Duration; //Field offset: 0x24
	public bool HitObstacleAtTheEnd; //Field offset: 0x28

	public virtual string ToString() { }

}

