using System;
namespace TheFakeNewsComedy.Repository
{
    public class CategoryRepository : IDisposable
    {
        public Context database = null;
        public CategoryRepository()
        {
            database = new Context();
        }

        public int SaveCategory(Category model)
        {
            try
            {
                database.Categories.Add(model);
                database.SaveChanges();

                return model.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category GetSavedCategory(int Id)
        {
            Category model = null;
            try
            {
                model = database.Categories.Find(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        public void Dispose()
        {
            if (database != null)
            {
                database.Dispose();
            }
        }
    }
}
