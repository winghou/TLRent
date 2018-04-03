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
        /// 房类型 1.单间  2.一室一厅 等
        /// </summary>
        public int HouseType { get; set; }
        /// <summary>
        /// 区域  1.芙蓉区 2.天心区 3.岳麓区 4.开福区 5.雨花区
        /// </summary>
        public int Area { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 房间类型   1.普通单间 2.单间+卫生间 3.单间+客厅 4.单间+卫生间+客厅 5.单间+阳台
        /// </summary>
        public int RoomType { get; set; }
        /// <summary>
        /// 房源类型   1.自营 2.加盟 3.托管
        /// </summary>
        public int ResourceType { get; set; }
        /// <summary>
        /// 是否带空调 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsAir { get; set; }
        /// <summary>
        /// 是否有热水器 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsHeater { get; set; }
        /// <summary>
        /// 是否带飘窗 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsBay { get; set; }
        /// <summary>
        /// 是否有阳台 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsBalcony { get; set; }
        /// <summary>
        /// 可住人数 如2人
        /// </summary>
        public Nullable<int> LiveNum { get; set; }
        /// <summary>
        /// 关键字 
        /// </summary>
        public string FindKey { get; set; }
    }

}
