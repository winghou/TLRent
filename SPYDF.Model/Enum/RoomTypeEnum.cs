using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.Enum
{
    /// <summary>
    /// 房间类型
    /// </summary>
    public enum RoomTypeEnum
    {
        /// <summary>
        /// 普通单间
        /// </summary>
        OrdinarySingle=1,
        /// <summary>
        /// 单间+卫生间
        /// </summary>
        Single_Washroom=2,
        /// <summary>
        /// 单间+客厅
        /// </summary>
        Single_Parlour=3,
        /// <summary>
        /// 单间+卫生间+客厅
        /// </summary>
        Single_Washroom_Parlour=4,
        /// <summary>
        /// 单间+阳台
        /// </summary>
        Single_Balcony=5,
        /// <summary>
        /// 套房
        /// </summary>
        Suite=6

    }
}
