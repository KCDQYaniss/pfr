namespace RootMotion.FinalIK;

public class FABRIKChain
{
	public FABRIK ik; //Field offset: 0x10
	[Range(0, 1)]
	public float pull; //Field offset: 0x18
	[Range(0, 1)]
	public float pin; //Field offset: 0x1C
	public int[] children; //Field offset: 0x20

	public FABRIKChain() { }

	private Vector3 GetCentroid(FABRIKChain[] chain) { }

	public void Initiate() { }

	public bool IsValid(ref string message) { }

	public void Stage1(FABRIKChain[] chain) { }

	public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) { }

}

