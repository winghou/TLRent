using AutoMapper;
using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SPYDF.Core.SecurityService
{

   
    public class UserTokenManager
    {
        private const string TOKENNAME = "PASSPORT.TOKEN";
       [Import]
        public static IUserTokenService UserTokenService { get; set; }
        /// <summary>
        /// 初始化缓存
        /// </summary>
        private static List<UserTokenView> InitCache()
        {
            if (HttpRuntime.Cache[TOKENNAME] == null)
            {
                
                  var tokens = UserTokenService.GetTokenLis();
                // cache 的过期时间， 令牌过期时间 *2
                HttpRuntime.Cache.Insert(TOKENNAME, tokens, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromDays(7 * 2));
            }
            var ts = (List<UserTokenView>)HttpRuntime.Cache[TOKENNAME];
            return ts;
        }


        public static int GetUId(string token)
        {
            var tokens = InitCache();
            var result = 0;
            if (tokens.Count > 0)
            {
                var id = tokens.Where(c => c.Token == token).Select(c => c.UserId).FirstOrDefault();
            }
            return result;
        }


        //public string GetPermission(string token)
        //{
        //    var tokens = InitCache();
        //    if (tokens.Count == 0)
        //        return "NoAuthorize";
        //    else
        //        return tokens.Where(c => c.Token == token).Select(c => c.Permission).FirstOrDefault();
        //}

        public int GetUserType(string token)
        {
            var tokens = InitCache();
            if (tokens.Count == 0)
                return 0;
            else
                return tokens.Where(c => c.Token == token).Select(c => c.UserType).FirstOrDefault();
        }

        /// <summary>
        /// 判断令牌是否存在
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool IsExistToken(string token)
        {
            var tokens = InitCache();
            if (tokens.Count == 0) return false;
            else
            {
                var t = tokens.Where(c => c.Token == token).FirstOrDefault();
                if (t == null)
                    return false;
                else if (t.Timeout < DateTime.Now)
                {
                    var iToken = Mapper.Map<UserTokenView, UserTokenInput>(t);
                    RemoveToken(iToken);
                    return false;
                }
                else
                {
                    // 小于8小时 更新过期时间
                    if ((t.Timeout - DateTime.Now).TotalMinutes < 1 * 60 - 1)
                    {
                        t.Timeout = DateTime.Now.AddHours(8);
                        var iToken = Mapper.Map<UserTokenView, UserTokenInput>(t);
                        UpdateToken(iToken);
                    }
                    return true;
                }

            }
        }

        /// <summary>
        /// 添加令牌， 没有则添加，有则更新
        /// </summary>
        /// <param name="token"></param>
        public void AddToken(UserTokenInput model)
        {
            var tokens = InitCache();
            // 不存在  怎增加
            if (!IsExistToken(model.Token))
            {
                var vToken = Mapper.Map<UserTokenInput, UserTokenView>(model);
                vToken.TokenId = 0;
                tokens.Add(vToken);
                // 插入数据库
                UserTokenService.Add(model);
            }
            else  // 有则更新
            {
                UpdateToken(model);
            }
        }

        public bool UpdateToken(UserTokenInput model)
        {
            var tokens = InitCache();
            if (tokens.Count == 0) return false;
            else
            {
                var t = tokens.Where(c => c.Token == model.Token).FirstOrDefault();
                if (t == null)
                    return false;
                t.Timeout = model.Timeout;
                // 更新数据库
                var tt = UserTokenService.GetToken(model);
                if (tt != null)
                {
                    UserTokenService.Update(model);
                }
                return true;
            }
        }
        /// <summary>
        /// 移除指定令牌
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public void RemoveToken(UserTokenInput model)
        {
            var tokens = InitCache();
            if (tokens.Count == 0) return;
            var vToken = Mapper.Map<UserTokenInput, UserTokenView>(model);
            tokens.Remove(vToken);
            UserTokenService.Delete(model);
        }

        public void RemoveToken(string token)
        {
            var tokens = InitCache();
            if (tokens.Count == 0) return;

            var ts = tokens.Where(c => c.Token == token).ToList();
            foreach (var t in ts)
            {
                var model = Mapper.Map<UserTokenView,UserTokenInput>(t);
                tokens.Remove(t);
                var tt = UserTokenService.GetToken(model);
                if (tt != null)
                    UserTokenService.Delete(model);
            }
        }


        public void RemoveToken(int uid)
        {
            var tokens = InitCache();
            if (tokens.Count == 0) return;
            var ts = tokens.Where(c => c.UserId == uid).ToList();
            foreach (var t in ts)
            {
                tokens.Remove(t);
                var model = Mapper.Map<UserTokenView, UserTokenInput>(t);
                var tt = UserTokenService.GetToken(model);
                if (tt != null)
                    UserTokenService.Delete(model);
            }
        }
    }
}
