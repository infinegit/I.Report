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
    
    public partial class MFG_ScanOperateGroup
    {
        public MFG_ScanOperateGroup()
        {
            this.MFG_ProductScanCfg = new HashSet<MFG_ProductScanCfg>();
            this.MFG_ScanOperateDetail = new HashSet<MFG_ScanOperateDetail>();
        }
    
        public int ID { get; set; }
        public string ScanOptGrp { get; set; }
        public string GroupDesc { get; set; }
        public string CreateUserAccount { get; set; }
        public string CreateMachine { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual ICollection<MFG_ProductScanCfg> MFG_ProductScanCfg { get; set; }
        public virtual ICollection<MFG_ScanOperateDetail> MFG_ScanOperateDetail { get; set; }
    }
}
