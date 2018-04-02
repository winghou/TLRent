using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
    /// <summary>
    /// 房间信息
    /// </summary>
    public class RoomView
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public int RoomID { get; set; }
        /// <summary>
        /// 房编号
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public string RoomType { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        public int Acreage { get; set; }
        /// <summary>
        /// 状态 :0 待租 1 已租
        /// </summary>
        public string  Status { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 是否有空调 ：0：没有 ，1：有 
        /// </summary>
        public Nullable<int> IsAir { get; set; }
        /// <summary>
        /// 是否有热水器 0：没有 ，1：有 
        /// </summary>
        public Nullable<int> IsHeater { get; set; }
        /// <summary>
        /// 是否有飘窗 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsBay { get; set; }
        /// <summary>
        /// 是否有阳台 0：没有 ，1：有
        /// </summary>
        public Nullable<int> IsBalcony { get; set; }
        /// <summary>
        /// 可住人数
        /// </summary>
        public Nullable<int> LiveNum { get; set; }
        /// <summary>
        /// 房间图片
        /// </summary>
        public List<RentImgView> ImgList { get; set; }
    }
}
