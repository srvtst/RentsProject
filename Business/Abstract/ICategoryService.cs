using Core.Utilities.Results;
using Entities.Concrate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int categoryid);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
