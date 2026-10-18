namespace EFT.GameRandoms;

public class PrecalculatedRandoms : IRandom
{
	private readonly PrecalculatedQaternionRandoms _randomQuaternions; //Field offset: 0x10
	private readonly PrecalculatedFloatRandoms _randomFloats; //Field offset: 0x18
	private readonly PrecalculatedVector3Randoms _randomVector3s; //Field offset: 0x20
	private readonly PrecalculatedNormalDistributedRandoms _randomNormalDistributedRandoms; //Field offset: 0x28
	private int _seed; //Field offset: 0x30
	private int _randomsCount; //Field offset: 0x34

	public PrecalculatedRandoms(int randomsCount, int seed) { }

	public override float GetNormalDistributedRandomFloat(int random, float mean, float stdDiviation) { }

	public override Vector3 GetRandomDirection(int random) { }

	public override float GetRandomFloat(int random) { }

	public override Quaternion GetRandomRotation(int random) { }

	public virtual string ToString() { }

}

