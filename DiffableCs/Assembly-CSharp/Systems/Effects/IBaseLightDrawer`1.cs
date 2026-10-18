namespace Systems.Effects;

public interface IBaseLightDrawer`1
{

	public int Count
	{
		 get { } //Length: 0
	}

	public void Destroy() { }

	public int get_Count() { }

	public void Render(CommandBuffer buffer) { }

	public void Start(Mesh mesh, Material material) { }

	public bool Update() { }

}

