using System;
namespace SolidPrinciples.LiskovSubstitutionPrinciple.Example1.Problem
{
    public class ReadonlyPostService : PostService
    {
        public new void Edit()
        {
            throw new Exception("You can not change the post");
        }
    }
}
