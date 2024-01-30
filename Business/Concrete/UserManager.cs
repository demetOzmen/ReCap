using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            bool userResult = _userDal.Add(user);
            if (userResult == false)
            {
                return new ErrorResult(Messages.UserNotAdded);
            }
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<User> AddGet(User user)
        {
            User dbUser = _userDal.AddGet(user);
            if (dbUser == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotAdded);
            }

            return new SuccessDataResult<User>(dbUser, Messages.UserAdded);
        }


        public IDataResult<List<User>> GetAll()
        {
            return (IDataResult<List<User>>)_userDal.GetAll();
        }

        public IResult Update(User user)
        {
            bool userResult = _userDal.Update(user);
            if (userResult == false)
            {
                return new ErrorResult(Messages.UserNotUpdated);

            }
            return new SuccessResult(Messages.UserUpdated);

        }
        public IDataResult<User> GetById(int id)
        {
            var user = _userDal.Get(b => b.Id == id);
            if (user != null)
            {
                return new SuccessDataResult<User>(user);
            }
            else
            {
                return new ErrorDataResult<User>("User not found");
            }
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var user = _userDal.Get(b => b.Email == email);
            if (user != null)
            {
                return new SuccessDataResult<User>(user);
            }
            else
            {
                return new ErrorDataResult<User>("User not found");
            }
        }

        public IResult Delete(int id)
        {
            var userToDelete = _userDal.Get(c => c.Id == id);

            bool deleteResult = _userDal.Delete(userToDelete);
            if (deleteResult)
            {
                return new SuccessResult(Messages.UserDeleted);
            }
            else
            {
                return new ErrorResult(Messages.UserNotDeleted);
            }

        }
    }
}