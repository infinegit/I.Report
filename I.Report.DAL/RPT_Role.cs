//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace I.Report.DAL
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class RPT_Role
    {
        public int ID { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string RoleDesc { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
