using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPYDF.API.Controllers
{
    public class RentController : ApiController
    {

        /// <summary>
        /// 分页获取房间数据
        /// </summary>
        /// <param name="param">查询条件</param>
        /// <returns></returns>
        // POST: Rent/GetRoomList
        [HttpPost]
        public List<RoomView> GetRoomList(RommPageFind param)
        {
            List<RoomView> re = new List<RoomView>();
            RoomView m = new RoomView()
            {
                HouseId = 1,
                RoomID = 1,
                HouseName = "奥海谷山府",
                RoomName = "A房间",
                Price = 1800,
                RoomType = 1,
                RoomTypeName = "普通单间",
                Acreage = 80,
                Status = 1,
                AreaId = 1,
                AreaName = "天心区",
                ResourceType = 1,
                ResourceTypeName = "自营房源",
                IsJoint = 0,
                HouseType = 5,
                HouseTypeName = "4室2厅2卫",
                HouseFloor = 11,
                TotalFloor = 20,
                StreetName = "梅溪湖街道",
                IsAir = 1,
                IsHeater = 1,
                IsBay = 1,
                IsBalcony = 1,
                LiveNum = 2,
                Remark = "漂亮、干净"

            };
            List<RentImgView> imgList = new List<RentImgView>();
            RentImgView img = new RentImgView()
            {
                Path = "~/Images/a.png",
                ImgId = 1,
                Remark = "无名图"
            };
            imgList.Add(img);
            m.ImgList = imgList;
            re.Add(m);
            return re;
        }

        /// <summary>
        /// 健康接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public HealthView HealthCheck()
        {
            return new HealthView { Success = true, Msg = "访问成功",Code="0000" };
        }
    }
}
