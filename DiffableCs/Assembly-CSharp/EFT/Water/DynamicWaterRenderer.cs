namespace EFT.Water;

public class DynamicWaterRenderer : IWaterRenderer
{
	public static DynamicWaterRenderer Instance; //Field offset: 0x0
	private static HashSet _dynamicWaterObjects; //Field offset: 0x8
	private readonly WaterProperties _properties; //Field offset: 0x10

	public override bool Enabled
	{
		 get { } //Length: 45
	}

	public DynamicWaterRenderer(WaterProperties properties) { }

	public void Add(DynamicWaterObject obj) { }

	public override void Cleanup(CommandBuffer cmd) { }

	public override bool get_Enabled() { }

	public void Remove(DynamicWaterObject obj) { }

	public override void Render(Camera camera, CommandBuffer cmd) { }

	private void Update(CommandBuffer cmd) { }

}

