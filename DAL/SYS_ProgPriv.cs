//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_ProgPriv
    {
        public SYS_ProgPriv()
        {
            this.SYS_RoleProgPriv = new HashSet<SYS_RoleProgPriv>();
        }
    
        public int ID { get; set; }
        public string PrivCode { get; set; }
        public string ProgCode { get; set; }
        public string PrivName { get; set; }
        public string PrivDesc { get; set; }
        public string CreateUserAccount { get; set; }
        public string CreateMachine { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual SYS_Prog SYS_Prog { get; set; }
        public virtual ICollection<SYS_RoleProgPriv> SYS_RoleProgPriv { get; set; }
    }
}
