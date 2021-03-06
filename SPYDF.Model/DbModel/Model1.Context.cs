﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPYDF.Model.DbModel
{
    using System;
    using System.ComponentModel.Composition;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    /// <summary>
    /// 租房实体
    /// </summary>
    [Export(typeof(DbContext))]
    public partial class RentEntities : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RentEntities()
            : base("name=RentEntities")
        {
        }
        /// <summary>
        /// model创建
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        /// <summary>
        /// 房间信息
        /// </summary>
        public virtual DbSet<Houses> Houses { get; set; }
        /// <summary>
        /// 意向信息
        /// </summary>
        public virtual DbSet<IntentInfo> IntentInfo { get; set; }
        /// <summary>
        /// 房间信息
        /// </summary>
        public virtual DbSet<Rooms> Rooms { get; set; }
        /// <summary>
        /// 用户信息
        /// </summary>
        public virtual DbSet<SysUser> SysUser { get; set; }
        /// <summary>
        /// 照片信息
        /// </summary>
        public virtual DbSet<RentImg> RentImg { get; set; }
        /// <summary>
        /// 用户Token信息
        /// </summary>
        public virtual DbSet<UserToken> UserToken { get; set; }
    }
}
