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
    
    public partial class MFG_ProduceCategory
    {
        public MFG_ProduceCategory()
        {
            this.MFG_Part = new HashSet<MFG_Part>();
        }
    
        public int ID { get; set; }
        public string ProduceCtgyCode { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryBriefCode { get; set; }
        public string InitPartNo { get; set; }
        public string InitPartVersion { get; set; }
        public string InitNextScanSite { get; set; }
        public string InitQualityStatus { get; set; }
        public int BarcodePrintLot { get; set; }
        public string CreateUserAccount { get; set; }
        public string CreateMachine { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual ICollection<MFG_Part> MFG_Part { get; set; }
    }
}