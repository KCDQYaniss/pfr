namespace EFT.InventoryLogic;

public interface IMapComponentTemplate
{

	public string ConfigPathStr
	{
		 get { } //Length: 0
	}

	public int MaxMarkersCount
	{
		 get { } //Length: 0
	}

	public float ScaleMax
	{
		 get { } //Length: 0
	}

	public float ScaleMin
	{
		 get { } //Length: 0
	}

	public string get_ConfigPathStr() { }

	public int get_MaxMarkersCount() { }

	public float get_ScaleMax() { }

	public float get_ScaleMin() { }

}

