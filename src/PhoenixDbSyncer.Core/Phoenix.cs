public class Phoenix
{
    private readonly IDatabase? _fromDb;
    private readonly IDatabase? _toDb;
    public Phoenix(IDatabase fromDb, IDatabase toDb)
    {
        _fromDb = fromDb;
        _toDb = toDb;
    }

    public Phoenix()
    {
    }

    public void SyncData()
    {
        ArgumentNullException.ThrowIfNull(_fromDb, nameof(_fromDb));
        ArgumentNullException.ThrowIfNull(_toDb, nameof(_toDb));
        
        IDatum[] data = _fromDb.ReadData();
        _toDb.WriteData(data);
    }
}