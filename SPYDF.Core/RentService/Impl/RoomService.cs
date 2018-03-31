using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.RentService.Impl
{
    public class RoomService : IRoomService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(RoomInput model)
        {
            int result = 0;
            return result;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="listModel"></param>
        /// <returns></returns>
        public List<RoomView> Find(List<RoomInput> listModel)
        {
            var result = new List<RoomView>();
            return result;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(RoomInput model)
        {
            int result = 0;
            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(RoomInput model)
        {
            int result = 0;
            return result;
        }
    }
}
