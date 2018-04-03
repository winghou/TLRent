using SPYDF.Model.Enum;
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
        /// 房间名称 
        /// </summary>
        public string RoomName { get; set; }
        /// <summary>
        /// 房编号
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 房名称
        /// </summary>
        public string HouseName { get; set; }
        /// <summary>
        /// 合租房  0：否 ，1：是 
        /// </summary>
        public Nullable<int> IsJoint { get; set; }
        /// <summary>
        /// 房源类型 1.自营 2.加盟 3.托管
        /// </summary>
        public int ResourceType { get; set; }
        /// <summary>
        /// 房源类型 1.自营 2.加盟 3.托管
        /// </summary>
        public string ResourceTypeName { get; set; }
        /// <summary>
        /// 房类型 1.单间  2.一室一厅
        /// </summary>
        public int HouseType { get; set; }
        /// <summary>
        /// 房类型 1.单间  2.一室一厅
        /// </summary>
        public string HouseTypeName { get; set; }
        /// <summary>
        /// 楼层   如11层
        /// </summary>
        public Nullable<int> HouseFloor { get; set; }
        /// <summary>
        /// 总楼层   共20层
        /// </summary>
        public Nullable<int> TotalFloor { get; set; }
        /// <summary>
        /// 区域名 1.芙蓉区 2.天心区 3.岳麓区 4.开福区 5.雨花区
        /// </summary>
        public int AreaId { get; set; }
        /// <summary>
        /// 区域名 1.芙蓉区 2.天心区 3.岳麓区 4.开福区 5.雨花区
        /// </summary>
        public string AreaName { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        public string StreetName { get; set; }
        /// <summary>
        /// 价格 如：999
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 房间类型 1.普通单间 2.单间+卫生间 3.单间+客厅 4.单间+卫生间+客厅 5.单间+阳台
        /// </summary>
        public int RoomType { get; set; }
        /// <summary>
        /// 房间类型 1.普通单间 2.单间+卫生间 3.单间+客厅 4.单间+卫生间+客厅 5.单间+阳台
        /// </summary>
        public string RoomTypeName { get; set; }
        /// <summary>
        /// 面积 如 80
        /// </summary>
        public int Acreage { get; set; }
        /// <summary>
        /// 状态 :0 待住 1 已入住
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 描述 如漂亮、干净
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
