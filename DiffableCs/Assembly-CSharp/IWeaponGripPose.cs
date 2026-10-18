//Type is in global namespace

[DefaultMember("Item")]
public interface IWeaponGripPose
{

	public bool IsAlternative
	{
		 get { } //Length: 0
	}

	public bool IsCached
	{
		 get { } //Length: 0
	}

	public Quaternion Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Quaternion Rotation
	{
		 get { } //Length: 0
	}

	public bool get_IsAlternative() { }

	public bool get_IsCached() { }

	public Quaternion get_Item(int index) { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public void set_Item(int index, Quaternion value) { }

}

