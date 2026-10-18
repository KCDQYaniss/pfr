namespace ChartAndGraph;

public class ChartDynamicMaterial
{
	public Material Normal; //Field offset: 0x10
	public Color Hover; //Field offset: 0x18
	public Color Selected; //Field offset: 0x28

	public ChartDynamicMaterial() { }

	public ChartDynamicMaterial(Material normal) { }

	public ChartDynamicMaterial(Material normal, Color hover, Color selected) { }

}

