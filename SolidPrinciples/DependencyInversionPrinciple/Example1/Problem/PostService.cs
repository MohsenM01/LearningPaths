
namespace SolidPrinciples.DependencyInversionPrinciple.Example1.Problem
{
    public class PostService
    {
        private IDataBase _dataBase;

        public PostService()
        {
            _dataBase = new MySqlDataBaseService();
        }

        public void AddPost()
        {
            _dataBase.AddToDb();
        }
        

    }
}