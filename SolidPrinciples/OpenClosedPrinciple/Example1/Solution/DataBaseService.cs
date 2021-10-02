namespace SolidPrinciples.OpenClosedPrinciple.Example1.Solution
{
    public class DataBaseService
    {
        public void AddToDb(IDataBase dataBase)
        {
            dataBase.AddToDb();
        }
    }
}
