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
    
    public partial class SYS_StkTransType
    {
        public SYS_StkTransType()
        {
            this.WMS_StkOutMstr = new HashSet<WMS_StkOutMstr>();
        }
    
        public string TransTypeCode { get; set; }
        public int ID { get; set; }
        public string TransTypeName { get; set; }
        public string InOut { get; set; }
        public bool Enabled { get; set; }
        public bool IsDelete { get; set; }
        public string CreateUserAccount { get; set; }
        public string CreateMachine { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual ICollection<WMS_StkOutMstr> WMS_StkOutMstr { get; set; }
    }
}
