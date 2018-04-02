using SPYDF.Core.RentService;
using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.API.BLL.Rent
{
    [Export]
    public  class RoomBll
    {
        #region Service
        [Import]
        public IRoomService RoomService { get; set; }
        #endregion

        /// <summary>
        /// 分页获取房间信息
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<RoomView> GetRoomsByPageIndex(PageFind<RoomInput> model)
        {
            List<RoomView> result = new List<RoomView>();
            return result;
        }

        
    }
}
