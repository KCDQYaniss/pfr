namespace EFT.Water;

public sealed class WaterDrawer
{
	[IsReadOnly]
	private struct Entry
	{
		public readonly IWaterRenderer Renderer; //Field offset: 0x0
		public readonly CommandBufferManager CommandBufferManager; //Field offset: 0x8

		public Entry(IWaterRenderer renderer, CommandBufferManager manager) { }

	}

	private readonly List _entries; //Field offset: 0x10

	public bool IsValid
	{
		 get { } //Length: 74
	}

	public WaterDrawer() { }

	public void Dispose() { }

	public void Execute(Camera camera) { }

	public bool get_IsValid() { }

	public void SetDrawingResults(IReadOnlyList cullResult) { }

	public bool TryAdd(IWaterRenderer renderer, CommandBufferManager cmdManager) { }

}

