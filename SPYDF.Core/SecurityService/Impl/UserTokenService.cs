using AutoMapper;
using SPYDF.Core.BaseService.Impl;
using SPYDF.Model.DbModel;
using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.SecurityService
{
    [Export(typeof(IUserTokenService))]
    public class UserTokenService : BaseCore, IUserTokenService
    {
        /// <summary>
        /// 获取Token集合
        /// </summary>
        /// <returns></returns>
        public  List<UserTokenView> GetTokenLis()
        {
            var result = new List<UserTokenView>();
            var DbTokenList= DbEntity.Set<UserToken>().ToList();
            result= Mapper.Map<List<UserToken>, List<UserTokenView>>(DbTokenList);
            return result;
        }
        /// <summary>
        /// 更新Token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(UserTokenInput model)
        {
            var result = 0;
            return result;
        }
        /// <summary>
        /// 删除token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(UserTokenInput model)
        {
            var result = 0;
            return result;
        }
        /// <summary>
        /// 添加token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(UserTokenInput model)
        {
            var result = 0;
            return result;
        }
        /// <summary>
        /// 查询Token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserTokenView GetToken(UserTokenInput model)
        {
            UserTokenView result = new UserTokenView();
            return result;
        }
    }
}
