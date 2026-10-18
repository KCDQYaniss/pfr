namespace UnityEngine;

[UsedByNativeCode]
public struct LOD
{
	public float screenRelativeTransitionHeight; //Field offset: 0x0
	public float fadeTransitionWidth; //Field offset: 0x4
	public Renderer[] renderers; //Field offset: 0x8

	public LOD(float screenRelativeTransitionHeight, Renderer[] renderers) { }

}

