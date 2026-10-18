namespace EFT.WboitSmoke;

[IsReadOnly]
internal struct ParticleRenderTargetSize
{
	public readonly int SourceWidth; //Field offset: 0x0
	public readonly int SourceHeight; //Field offset: 0x4
	public readonly int TargetWidth; //Field offset: 0x8
	public readonly int TargetHeight; //Field offset: 0xC

	public ParticleRenderTargetSize(int sourceWidth, int sourceHeight, int targetWidth, int targetHeight) { }

}

