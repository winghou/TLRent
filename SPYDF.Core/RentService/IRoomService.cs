using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.RentService
{
    interface IRoomService
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(RoomInput model);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="listModel"></param>
        /// <returns></returns>
        List<RoomView> Find(List<RoomInput> listModel);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Update(RoomInput model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Delete(RoomInput model);
    }
}
