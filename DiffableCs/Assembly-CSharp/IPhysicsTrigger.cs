//Type is in global namespace

public interface IPhysicsTrigger
{

	public string Description
	{
		 get { } //Length: 0
	}

	public bool enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_Description() { }

	public bool get_enabled() { }

	public void OnTriggerEnter(Collider collider) { }

	public void OnTriggerExit(Collider collider) { }

	public void set_enabled(bool value) { }

}

