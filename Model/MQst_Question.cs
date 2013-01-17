using System;
using System.Collections.Generic;
using System.Linq;

namespace Rose.Model.Hot
{
    /// <summary>
    /// MPro_question:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MPro_question
    {
        public MPro_question()
        { }
        #region Model
        private int _questionid_pk;
        private string _q_content;
        private int _userid_fk;
        private string _username;
        private DateTime _rowdate = DateTime.Now;
        private int _productid_fk;
        private bool _isshow = true;
        /// <summary>
        /// 
        /// </summary>
        public int QuestionId_Pk
        {
            set { _questionid_pk = value; }
            get { return _questionid_pk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Q_Content
        {
            set { _q_content = value; }
            get { return _q_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserId_Fk
        {
            set { _userid_fk = value; }
            get { return _userid_fk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RowDate
        {
            set { _rowdate = value; }
            get { return _rowdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ProductId_Fk
        {
            set { _productid_fk = value; }
            get { return _productid_fk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsShow
        {
            set { _isshow = value; }
            get { return _isshow; }
        }
        #endregion Model

    }
}


