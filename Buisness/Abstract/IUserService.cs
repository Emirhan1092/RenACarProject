﻿using Core.Utilities.Results;
using Entities.Concrete;

namespace Buisness.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> Get(int id);

    }
}
