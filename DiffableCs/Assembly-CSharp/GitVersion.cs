//Type is in global namespace

public class GitVersion
{
	public string CommitHash; //Field offset: 0x10
	public DateTime CommitDate; //Field offset: 0x18
	public string CommitSubject; //Field offset: 0x20
	public string CommitBranch; //Field offset: 0x28

	public GitVersion() { }

	public static GitVersion Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

	public virtual string ToString() { }

}

