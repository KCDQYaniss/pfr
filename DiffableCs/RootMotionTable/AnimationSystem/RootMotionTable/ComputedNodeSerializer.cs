namespace AnimationSystem.RootMotionTable;

public static class ComputedNodeSerializer
{

	private static ComputedNode CreateNode(EComputedNodeType nodeType, IBlendParametersKeeper paramsKeeper) { }

	public static ComputedNode DeserializeNode(BinaryReader reader, IBlendParametersKeeper paramsKeeper) { }

	public static void SerializeNode(BinaryWriter writer, ComputedNode node) { }

}

