
namespace GenericRepository
{
    public class GenericRepository<T> : IRepository<T> where T : Model
    {
        private static List<T> items = new List<T>();

        public void Add(T entity)
        {
            items.Add(entity);
        }

        public T? GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }

        public void Update(T entity)
        {
            int index = items.FindIndex(x => x.Id == entity.Id);

            if (index != -1)
            {
                items[index] = entity;
            }
        }

        public void Delete(int id)
        {
            items.RemoveAll(x => x.Id == id);
        }
    }
}