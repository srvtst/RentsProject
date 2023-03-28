using Core.Utilities.Results;
using Entities.Concrate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByColorId(int colorid);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
