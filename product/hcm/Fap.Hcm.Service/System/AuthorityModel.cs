﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fap.Hcm.Service.System
{
    public class AuthorityModel
    {
        /// <summary>
        /// 权限类型
        /// 1、菜单。2、部门。3、可编辑列。4、可见列。5、用户
        /// </summary>
        public AuthorityTypeEnum AType { get; set; }
        /// <summary>
        /// 角色Uid
        /// </summary>
        public string RoleUid
        {
            get;
            set;

        }
        /// <summary>
        /// 用户Uid
        /// </summary>
        public IList<string> UserUids
        {
            get;
        } = new List<string>();
        /// <summary>
        /// 用户组Uid
        /// </summary>
        public IList<string> UserGroupUids
        {
            get;
        } = new List<string>();
        /// <summary>
        /// 菜单Uid
        /// </summary>
        public IList<string> MenuUids
        {
            get;

        } = new List<string>();
        /// <summary>
        /// 部门Uid
        /// </summary>
        public IList<string> OrgDeptUids
        {
            get;
        } = new List<string>();
        /// <summary>
        /// 实体列Uid
        /// </summary>
        public IList<GridCols> ColumnUids
        {
            get;
        } = new List<GridCols>();
        /// <summary>
        /// 报表
        /// </summary>
        public IList<string> RptUids
        {
            get;
        } = new List<string>();
        /// <summary>
        /// 按钮
        /// </summary>
        public IList<string> BtnUids { get;} = new List<string>();
        /// <summary>
        /// 权限角色
        /// </summary>
        public IList<string> PRoleUids { get;} = new List<string>();
    }
    public class GridCols
    {
        public string MenuUid { get; set; }
        public string GridId { get; set; }
        public string ColUid { get; set; }
    }
    public enum AuthorityTypeEnum
    {
        // 1、菜单。2、部门。3、可编辑列。4、可见列。5、用户
        Menu=1,Dept=2,ColumnEdit=3,ColumnView=4,User=5,Rpt=6,Role=7,Button=8
    }
}
