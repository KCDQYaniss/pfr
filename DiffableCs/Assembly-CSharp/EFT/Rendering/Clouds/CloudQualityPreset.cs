namespace EFT.Rendering.Clouds;

[IsReadOnly]
public struct CloudQualityPreset
{
	public static readonly CloudQualityPreset Low; //Field offset: 0x0
	public static readonly CloudQualityPreset Medium; //Field offset: 0x10
	public static readonly CloudQualityPreset High; //Field offset: 0x20
	public static readonly CloudQualityPreset Ultra; //Field offset: 0x30
	public readonly CloudResolution Resolution; //Field offset: 0x0
	public readonly CloudShadowsResolution ShadowResolution; //Field offset: 0x4
	public readonly int RaycastSteps; //Field offset: 0x8
	public readonly bool CastShadow; //Field offset: 0xC

	private static CloudQualityPreset() { }

	public CloudQualityPreset(CloudResolution resolution, CloudShadowsResolution shadowResolution, int raycastSteps, bool castShadow) { }

	public void Apply(CloudLayer settings) { }

}

