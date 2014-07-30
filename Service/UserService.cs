using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Wst.IRepository;
using Wst.Model;
using Wst.Repository;

namespace Wst.Service
{
    public class UserService
    {
        /// <summary>
        /// 用户
        /// </summary>
        private IRepository<Users> uRepository;
        public UserService()
        {
            uRepository = new BaseRepository<Users>(new WstContext());
        }
        /// <summary>
        /// 根据条件获取用户
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public Users GetByCondition(Expression<Func<Users,bool>> where)
        {
            return uRepository.Get(where).FirstOrDefault(); 
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<Users>GetAll()
        {
            return uRepository.GetAll().ToList();
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Users entity)
        {
            uRepository.Update(entity);
            uRepository.Commit();
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Users entity)
        {
            uRepository.Delete(entity);
            uRepository.Commit();
        }
        /// <summary>
        /// 根据ID删除用户
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteByID(int ID)
        {
            uRepository.DeleteByID(ID);
            uRepository.Commit();
        }
        //添加单个
        public void Add(Users entity)
        {
            uRepository.Add(entity);
            uRepository.Commit();
        }
        public void Add(List<Users> entity)
        {
            uRepository.Add(entity);
            uRepository.Commit();
        }
        
    }
}