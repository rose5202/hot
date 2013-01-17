using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Rose.Model.Hot
{
    /// <summary>
    /// Pro_class:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Pro_class
    {
        public Pro_class()
        { }
        #region Model
        private int _classid_pk;
        private string _classname;
        private DateTime? _rowdate = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public int ClassId_PK
        {
            set { _classid_pk = value; }
            get { return _classid_pk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassName
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RowDate
        {
            set { _rowdate = value; }
            get { return _rowdate; }
        }
        #endregion Model

    }
}
