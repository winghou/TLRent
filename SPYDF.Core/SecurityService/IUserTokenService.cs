using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.SecurityService
{
    public interface IUserTokenService
    {
        /// <summary>
        /// 获取Token集合
        /// </summary>
        /// <returns></returns>
        List<UserTokenView> GetTokenLis();
        /// <summary>
        /// 更新Token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Update(UserTokenInput model);
        /// <summary>
        /// 删除token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Delete(UserTokenInput model);
        /// <summary>
        /// 添加token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(UserTokenInput model);
        /// <summary>
        /// 查询Token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        UserTokenView GetToken(UserTokenInput model);
    }
}
