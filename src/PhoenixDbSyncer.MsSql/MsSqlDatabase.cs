public class MsSqlDatabase : IDatabase
{
    public IConnectionConfiguration? ConnectionConfiguration => throw new NotImplementedException();

    public IDatum[] ReadData()
    {
        throw new NotImplementedException();
    }

    public void WriteData(IDatum[] data)
    {
        throw new NotImplementedException();
    }
}