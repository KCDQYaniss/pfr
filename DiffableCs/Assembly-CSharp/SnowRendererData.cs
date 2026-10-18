//Type is in global namespace

internal struct SnowRendererData
{
	internal RenderTexture ShadowMap; //Field offset: 0x0
	internal RenderTexture DisableSnowMask; //Field offset: 0x8
	internal RenderTargetIdentifier[] Targets; //Field offset: 0x10

	internal static SnowRendererData Create(int width, int height, bool allowHDR) { }

	internal static void Dispose(in SnowRendererData rendererData) { }

}

