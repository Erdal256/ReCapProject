using Entities.Concrate;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
    }
}
