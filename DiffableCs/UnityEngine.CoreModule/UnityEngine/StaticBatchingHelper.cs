namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/StaticBatching.h")]
internal struct StaticBatchingHelper
{

	[FreeFunction("StaticBatching::CombineMeshesForStaticBatching")]
	internal static void CombineMeshes(GameObject[] gos, GameObject staticBatchRoot) { }

}

