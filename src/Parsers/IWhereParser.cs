using System.Linq;

namespace BigBangDotNet.Data.Filters.Parsers
{
    public interface IWhereParser
    {

        public IQueryable<T> ParseWhere<T>(WhereCondition condition, IQueryable<T> source, string suffix = "");


    }
}
