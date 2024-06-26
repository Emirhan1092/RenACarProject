﻿using Buisness.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract.DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Conctrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
                
        }

        public User GetByMail(string email)
        {
          return _userDal.Get(filter: u=> u.Email == email); 
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return _userDal.GetClaims(user);
        }
    }
}