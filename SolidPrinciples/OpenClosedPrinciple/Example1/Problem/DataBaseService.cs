namespace SolidPrinciples.OpenClosedPrinciple.Example1.Problem
{
    public class DataBaseService
    {
        public void AddToDb(string dbType)
        {
            if (dbType == "sql")
            {

            }
            else if (dbType == "mysql")
            {

            }
            else if (dbType == "oracle")
            {

            }
            //Add other types, it is open for modification
        }
    }
}
