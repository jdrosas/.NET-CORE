namespace prj06_01.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
