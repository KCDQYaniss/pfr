namespace FilesChecker;

public interface IConsistencyController : IFilesChecker
{

	public void EnsureConsistency(FileConsistencyMetadata fileConsistencyMetadata, ConsistencyEnsuranceMode ensuranceMode, CancellationToken cancellationToken = null) { }

}

