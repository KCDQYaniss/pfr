namespace EFT.GameRandoms;

public interface IRandom
{

	public float GetNormalDistributedRandomFloat(int random, float mean, float stdDiviation) { }

	public Vector3 GetRandomDirection(int random) { }

	public float GetRandomFloat(int random) { }

	public Quaternion GetRandomRotation(int random) { }

}

