public interface IDatabase
{
    public IConnectionConfiguration? ConnectionConfiguration { get; }
    public IDatum[] ReadData();
    public void WriteData(IDatum[] data);
}