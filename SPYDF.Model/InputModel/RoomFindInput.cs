using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.InputModel
{
    /// <summary>
    /// 房间查询输入
    /// </summary>
    public class RoomFindInput
    {
        /// <summary>
        /// 区域
        /// </summary>
        public int Area { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public int RoomType { get; set; }
        /// <summary>
        /// 房源类型
        /// </summary>
        public int HouseType { get; set; }
        /// <summary>
        /// 是否带空调
        /// </summary>
        public Nullable<int> IsAir { get; set; }
        /// <summary>
        /// 是否有热水器
        /// </summary>
        public Nullable<int> IsHeater { get; set; }
        /// <summary>
        /// 是否带飘窗
        /// </summary>
        public Nullable<int> IsBay { get; set; }
        /// <summary>
        /// 是否有阳台
        /// </summary>
        public Nullable<int> IsBalcony { get; set; }
        /// <summary>
        /// 可住人数
        /// </summary>
        public Nullable<int> LiveNum { get; set; }
        /// <summary>
        /// 关键字
        /// </summary>
        public string FindKey { get; set; }
    }

}
