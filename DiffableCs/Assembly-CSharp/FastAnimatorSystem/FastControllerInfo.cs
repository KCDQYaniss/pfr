namespace FastAnimatorSystem;

public class FastControllerInfo
{
	private readonly FastAnimatorController _fastAnimatorController; //Field offset: 0x10
	private readonly FastLayerInfo[] _layerInfos; //Field offset: 0x18

	public FastControllerInfo(FastAnimatorController fastAnimatorController) { }

	public FastLayerInfo GetStateInfo(int layerIndex) { }

}

