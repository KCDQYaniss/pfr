namespace EFT.WboitSmoke;

internal sealed class EnvironmentStencilCache
{
	private readonly Dictionary _stencilFactorByCell; //Field offset: 0x10
	private readonly float _cellSize; //Field offset: 0x18

	public EnvironmentStencilCache(float cellSize) { }

	public void Clear() { }

	private Vector3Int GetCell(float3 worldPos) { }

	public float GetStencilFactor(float3 worldPos) { }

	private static Vector3 ToVector3(float3 value) { }

}

