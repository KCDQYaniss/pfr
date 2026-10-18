namespace FilesChecker;

public interface IFilesChecker
{

	public Task EnsureConsistency(ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = 3, ConsistencyEnsuranceMode criticalFileEnsuranceMode = 7, Action onProgress = null, CancellationToken cancellationToken = null) { }

	public Task EnsureConsistencySingle(string path, ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = 3, ConsistencyEnsuranceMode criticalFileEnsuranceMode = 7, CancellationToken cancellationToken = null) { }

}

