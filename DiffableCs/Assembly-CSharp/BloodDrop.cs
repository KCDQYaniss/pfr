//Type is in global namespace

public class BloodDrop
{
	private static readonly int _lifetimeId; //Field offset: 0x0
	private Material _material; //Field offset: 0x10
	private Vector2 _position; //Field offset: 0x18
	private Vector3 _scale; //Field offset: 0x20
	[CompilerGenerated]
	private int <DropNumber>k__BackingField; //Field offset: 0x2C
	private readonly float _aspect; //Field offset: 0x30

	public private int DropNumber
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static BloodDrop() { }

	public BloodDrop(Material material, float aspect) { }

	public void Draw() { }

	[CompilerGenerated]
	public int get_DropNumber() { }

	[CompilerGenerated]
	private void set_DropNumber(int value) { }

	public void SetLifetime(float lifetime) { }

	public void Setup(Vector2 position, Vector3 scale, int dropNumber) { }

}

