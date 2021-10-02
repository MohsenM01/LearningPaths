
namespace SolidPrinciples.DependencyInversionPrinciple.Example1.Solution
{
    public class PostService
    {
        private readonly IDataBase _dataBase;

        public PostService(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public void AddPost()
        {
            _dataBase.AddToDb();
        }
        

    }
}